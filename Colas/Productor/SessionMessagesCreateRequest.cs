using System;

namespace Productor
{
    internal class SessionMessagesCreateRequest
    {
        public string SessionId { get; set; }
        public int MessageId { get; set; }
        public DateTime EnqueueTimeUtc { get; set; }
        public string TestRunId { get; set; }
        public int ConsumerWorkTime { get; set; }
    }
}