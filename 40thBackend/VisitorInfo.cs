using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace _40thBackend
{
    public class VisitorInfo
    {
        public long Id { get; set; }    
        public DateTime Timestamp { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string ConnectionId { get; set; }
        public string? RemoteIP { get; set; }
        public int RemotePort { get; set; }
        public string RequestPath { get; set; }

        public VisitorInfo()
        {
            ConnectionId= string.Empty;
            Headers = new Dictionary<string, string>();
            Timestamp = DateTime.Now;
        }
        public static VisitorInfo FromHttpContext(HttpContext context)
        {

            return new VisitorInfo
            {
                Timestamp = DateTime.Now,
                Headers = context.Request.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                ConnectionId = context.Connection.Id,
                RemoteIP = context.Connection.RemoteIpAddress?.ToString(),
                RemotePort = context.Connection.RemotePort,
                RequestPath = context.Request.Path
            };
        }
    }
}
