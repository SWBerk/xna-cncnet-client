using System;

namespace DTAClient.Online.EventArguments
{
    public class KickEventArgs : EventArgs
    {
        public KickEventArgs(string channelName, string userName, string reason)
        {
            ChannelName = channelName;
            UserName = userName;
            Reason = reason;
        }

        public string ChannelName { get; private set; }
        public string UserName { get; private set; }
        public string Reason { get; set; }
    }
}
