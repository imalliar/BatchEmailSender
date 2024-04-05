namespace BatchEmailSender.Models;

public class SenderWorkerOptions
{
    public string? To { get; set; }

    public string? ToName { get; set; }

    public string? Subject { get; set; }
    public string? Template { get; set; }
    public string? From { get; set; }
    public string? FromName { get; set; }
}