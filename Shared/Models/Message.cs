namespace Shared.Models
{
    public class Message
    {
        public string Role { get; set; }
        public string Content { get; set; }
        public string MessageId { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsStreaming { get; set; }
        public string Model { get; set; }
        public int? InputTokenCount { get; set; }
        public int? OutputTokenCount { get; set; }
        public object RawMessage { get; set; }
        public string Id { get; set; }
        public bool IsUser { get; set; }
        public List<Attachment> Attachments { get; set; } = new List<Attachment>();
    }
}