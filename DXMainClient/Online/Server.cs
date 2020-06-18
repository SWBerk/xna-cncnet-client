using System.Security.Authentication;

namespace DTAClient.Online
{
    /// <summary>
    /// A struct containing information on an IRC server.
    /// </summary>
    public struct Server
    {
        public Server(string host, string name, int[] ports, bool useSsl = false,
            SslProtocols? sslProtocols = null)
        {
            Host = host;
            Name = name;
            Ports = ports;
            UseSsl = useSsl;
            SslProtocols = sslProtocols;
        }

        public string Host;
        public string Name;
        public int[] Ports;
        public bool UseSsl { get; }
        public SslProtocols? SslProtocols { get; set; }
    }
}
