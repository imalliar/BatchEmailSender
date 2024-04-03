namespace BatchEmailSender.Models;

public class ErrorModel
{
    public required string Email { get; set; }

    public string? Error { get; set; } 
}