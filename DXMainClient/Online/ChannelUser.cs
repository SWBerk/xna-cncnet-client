namespace DTAClient.Online
{
    /// <summary>
    /// An user on an IRC channel.
    /// </summary>
    public class ChannelUser
    {
        public ChannelUser(IRCUser ircUser)
        {
            IRCUser = ircUser;
        }

        public IRCUser IRCUser { get; private set; }

        public bool IsAdmin { get; set; }

        public bool issuperadmin { get; set; }
        public bool IsFancy { get; set; }
        public bool isSuperOP { get; set; }
        public bool isFounder { get; set; }
        public bool isbot { get; set; }
        public bool isvoice { get; set; }
        public bool Isvoice { get; internal set; }
    }
}
