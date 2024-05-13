namespace EmailProvider.Models;

public class EmailRequest
{
    public string To { get; set; } = null!;
    public string Subject { get; set; } = null!;
    public string Htmlbody { get; set; } = null!;
    public string PlainText { get; set; } = null!;
}
