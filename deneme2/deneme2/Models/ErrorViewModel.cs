namespace deneme2.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class formbil
    {
        public string ad { get; set; }
        public string konu { get; set; }
        public string email { get; set; }
        public string ileti { get; set; }
    }
}
