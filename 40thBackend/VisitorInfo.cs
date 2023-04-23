using Microsoft.Extensions.Primitives;

namespace _40thBackend
{
    public class VisitorInfo
    {

        public Dictionary<string, StringValues> Headers { get; set; }
        public ConnInfo ConnectionInfo { get; set; }
        public VisitorInfo()
        {

        }
        public static VisitorInfo FromHttpContext(HttpContext context)
        {
            return new VisitorInfo
            {
                Headers = context.Request.Headers.ToDictionary(x => x.Key, x => x.Value),
                ConnectionInfo = ConnInfo.FromConnectionInfo(context.Connection)
            };
        }
    }
}
