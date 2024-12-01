namespace RoomateFinderEngne
{
    public class Message
    {
        public string Sender { get; set; }     // Username of the sender
        public string Receiver { get; set; }   // Username of the receiver
        public string Content { get; set; }    // The message content
        public DateTime Timestamp { get; set; } // The time the message was sent
    }
}
