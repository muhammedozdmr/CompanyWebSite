namespace CompanyWebSite.Domain.Entities;

public class Newsletter
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Email { get; set; }
    public DateTime? SubscribedDate { get; set; }
}
