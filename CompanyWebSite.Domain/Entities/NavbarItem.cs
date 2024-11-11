namespace CompanyWebSite.Domain.Entities;

public class NavbarItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
    public IEnumerable<Translation> Translations { get; set; }
}
