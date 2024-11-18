namespace CompanyWebSite.Dto;

public class NavbarFooterSidePanelDto
{
    public int Id { get; set; }
    public IEnumerable<FooterDto>? Footers { get; set; }
    public IEnumerable<NavbarItemDto>? NavbarItems { get; set; }
    public IEnumerable<NewsletterDto>? Newsletters { get; set; }
    public IEnumerable<CompanyInfoDto>? CompanyInfos { get; set; }
    public IEnumerable<SidePanelDto>? SidePanels { get; set; }
    public IEnumerable<LanguageDto>? Languages { get; set; }
}
