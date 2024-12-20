﻿using CompanyWebSite.DataAccess.EntityConfiguration;
using CompanyWebSite.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.DataAccess
{
    public class CompanyWebSiteContext : DbContext
    {
        public CompanyWebSiteContext(DbContextOptions<CompanyWebSiteContext> options) : base(options)
        {
        }

        //DbSets
        public DbSet<About>? Abouts { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<CompanyInfo>? CompanyInfos { get; set; }
        public DbSet<ContactForm>? Contacts { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<History>? Histories { get; set; }
        public DbSet<Language>? Languages { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<FAQ>? FAQs { get; set; }
        public DbSet<BlogCategory>? BlogCategories { get; set; }
        public DbSet<ServiceCategory>? ServiceCategories { get; set; }
        public DbSet<Highlight> Highlights { get; set; }
        public DbSet<Media> MediaItems { get; set; }
        public DbSet<NavbarItem> NavbarItems { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<SidePanel> SidePanels { get; set; }
        public DbSet<Page> Pages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AboutConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyInfoConfiguration());
            modelBuilder.ApplyConfiguration(new FAQConfiguration());
            modelBuilder.ApplyConfiguration(new HistoryConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new TranslationConfiguration());
            modelBuilder.ApplyConfiguration(new BlogCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new MediaConfiguration());
            modelBuilder.ApplyConfiguration(new HighlightConfiguration());
            modelBuilder.ApplyConfiguration(new NavbarItemConfiguration());
            modelBuilder.ApplyConfiguration(new FooterConfiguration());
            modelBuilder.ApplyConfiguration(new SidePanelConfiguration());
            modelBuilder.ApplyConfiguration(new PageConfiguration());
        }
    }
}
