using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Domain.Entities
{
    public class SidePanel
    {
        public int Id { get; set; }
        public string? SidePanelMainTitle { get; set; }
        public string? SidePanelMainContent { get; set; }
        public string? SidePanelContactTitle { get; set; }
        public string? SidePanelContactContent { get; set; }
    }
}
