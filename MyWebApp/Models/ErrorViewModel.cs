namespace MyWebApp.Models;

public class ErrorViewModel
{
    public string RequestId { get; set; } = string.Empty;

    public bool ShowRequestId => !string.IsNullOrWhiteSpace(RequestId);
}