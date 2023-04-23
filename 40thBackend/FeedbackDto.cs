namespace _40thBackend
{
    public class FeedbackDto
    {
        public DateTime Timestamp { get; set; } 
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Feedback { get; set; }
        public FeedbackDto()
        {
            Timestamp = DateTime.Now;
        }
    }
}
