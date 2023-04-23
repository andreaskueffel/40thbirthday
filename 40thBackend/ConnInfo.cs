namespace _40thBackend
{
    public class ConnInfo
    {
        public string ID { get; set; }
        public string RemoteIP { get; set; }
        public int RemotePort { get; set; }

        public ConnInfo()
        {

        }

        public static ConnInfo FromConnectionInfo(ConnectionInfo connectionInfo)
        {
            return new ConnInfo()
            {
                ID = connectionInfo.Id,
                RemoteIP = connectionInfo.RemoteIpAddress?.ToString(),
                RemotePort = connectionInfo.RemotePort
            };
        }
    }
}
