namespace CompanyWebSite.Dto;

public class NavbarAndFooterDto
{
    public int Id { get; set; }
    public IEnumerable<NavbarItemDto> NavbarItems { get; set; }
    public IEnumerable<NewsletterDto> Newsletters { get; set; }
    public IEnumerable<CompanyInfoDto> CompanyInfos { get; set; }
}
