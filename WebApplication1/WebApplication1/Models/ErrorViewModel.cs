namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }


        public int ErrorId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
