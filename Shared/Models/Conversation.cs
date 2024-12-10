namespace Shared.Models
{
    public class Conversation
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();
    }
}