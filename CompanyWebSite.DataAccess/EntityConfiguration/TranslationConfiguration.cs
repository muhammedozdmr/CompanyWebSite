using CompanyWebSite.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.DataAccess.EntityConfiguration
{
    public class TranslationConfiguration : IEntityTypeConfiguration<Translation>
    {
        public void Configure(EntityTypeBuilder<Translation> builder)
        {
            builder.ToTable(nameof(Translation));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.EntityName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.EntityId).IsRequired();
            builder.Property(x => x.Key).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Value).HasColumnType("nvarchar(max)").IsRequired();
            builder.HasOne(x => x.Language).WithMany(y => y.Translations).HasForeignKey(x => x.LanguageId).OnDelete(DeleteBehavior.Cascade);


            builder.HasData(
                // DefaultTitle Translations for "About"
                new Translation
                {
                    Id = 1,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "DefaultTitle",
                    Value = "About Us",
                    LanguageId = 2 // English
                },
                new Translation
                {
                    Id = 2,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "DefaultTitle",
                    Value = "Über uns",
                    LanguageId = 3 // German
                },
                new Translation
                {
                    Id = 3,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "DefaultTitle",
                    Value = "О нас",
                    LanguageId = 4 // Russian
                },

                // DefaultContent Translations for "About"
                new Translation
                {
                    Id = 4,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "DefaultContent",
                    Value = "As TechLiberty Software Solutions, our company, founded on October 29, 2023, has adopted the mission of providing technological solutions to its clients. In line with the requirements of the digital age, we offer professional solutions in a wide range such as mobile applications, web projects, game development, project management, SEO optimization, API services, CRM and ERP services, database management systems, and system analysis. With our experienced and innovative team, we are a reliable business partner in the digital transformation journey of businesses. Our goal is to add value by providing sustainable success through efficient and scalable solutions to our clients.",
                    LanguageId = 2 // English
                },
                new Translation
                {
                    Id = 5,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "DefaultContent",
                    Value = "Als TechLiberty Software Solutions hat unser am 29. Oktober 2023 gegründetes Unternehmen die Mission übernommen, seinen Kunden technologische Lösungen bereitzustellen. Im Einklang mit den Anforderungen des digitalen Zeitalters bieten wir professionelle Lösungen in einer breiten Palette wie mobile Anwendungen, Webprojekte, Spieleentwicklung, Projektmanagement, SEO-Optimierung, API-Dienste, CRM- und ERP-Dienste, Datenbankverwaltungssysteme und Systemanalyse. Mit unserem erfahrenen und innovativen Team sind wir ein zuverlässiger Geschäftspartner auf dem Weg der digitalen Transformation von Unternehmen. Unser Ziel ist es, unseren Kunden durch effiziente und skalierbare Lösungen nachhaltigen Erfolg zu bieten und Mehrwert zu schaffen.",
                    LanguageId = 3 // German
                },
                new Translation
                {
                    Id = 6,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "DefaultContent",
                    Value = "Компания TechLiberty Software Solutions, основанная 29 октября 2023 года, взяла на себя миссию по предоставлению технологических решений своим клиентам. В соответствии с требованиями цифровой эпохи мы предлагаем профессиональные решения в широком диапазоне, включая мобильные приложения, веб-проекты, разработку игр, управление проектами, оптимизацию SEO, API-сервисы, услуги CRM и ERP, системы управления базами данных и анализ систем. Наша опытная и новаторская команда является надежным партнером в процессе цифровой трансформации бизнеса. Наша цель - создать ценность, предлагая клиентам устойчивый успех через эффективные и масштабируемые решения.",
                    LanguageId = 4 // Russian
                },

                // Summary Translations for "About"
                new Translation
                {
                    Id = 7,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "Summary",
                    Value = "TechLiberty Software Solutions is a reliable business partner in the digital transformation processes of businesses, offering mobile applications, web projects, game development, and corporate solutions.",
                    LanguageId = 2 // English
                },
                new Translation
                {
                    Id = 8,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "Summary",
                    Value = "TechLiberty Software Solutions ist ein zuverlässiger Geschäftspartner in den digitalen Transformationsprozessen von Unternehmen und bietet mobile Anwendungen, Webprojekte, Spieleentwicklung und Unternehmenslösungen.",
                    LanguageId = 3 // German
                },
                new Translation
                {
                    Id = 9,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "Summary",
                    Value = "TechLiberty Software Solutions - надежный партнер в процессах цифровой трансформации бизнеса, предлагающий мобильные приложения, веб-проекты, разработку игр и корпоративные решения.",
                    LanguageId = 4 // Russian
                },
// Blog Id = 1 Translations
new Translation
{
    Id = 10,
    EntityName = "Blog",
    EntityId = 1,
    Key = "DefaultTitle",
    Value = "Fundamentals of Software Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 11,
    EntityName = "Blog",
    EntityId = 1,
    Key = "DefaultTitle",
    Value = "Grundlagen der Softwareentwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 12,
    EntityName = "Blog",
    EntityId = 1,
    Key = "DefaultTitle",
    Value = "Основы разработки программного обеспечения",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 13,
    EntityName = "Blog",
    EntityId = 1,
    Key = "DefaultContent",
    Value = "Software development is the process of creating programs that provide a solution to a problem. Technological advancements have brought significant changes in software development processes, enabling developers to design user-friendly interfaces, build efficient algorithms, and ensure secure data management.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 14,
    EntityName = "Blog",
    EntityId = 1,
    Key = "DefaultContent",
    Value = "Softwareentwicklung ist der Prozess der Erstellung von Programmen, die eine Lösung für ein Problem bieten. Technologische Fortschritte haben bedeutende Veränderungen in den Softwareentwicklungsprozessen mit sich gebracht, die es Entwicklern ermöglichen, benutzerfreundliche Schnittstellen zu entwerfen, effiziente Algorithmen zu erstellen und eine sichere Datenverwaltung zu gewährleisten.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 15,
    EntityName = "Blog",
    EntityId = 1,
    Key = "DefaultContent",
    Value = "Разработка программного обеспечения - это процесс создания программ, обеспечивающих решение проблемы. Технологический прогресс внес значительные изменения в процессы разработки ПО, позволяя разработчикам создавать удобные интерфейсы, разрабатывать эффективные алгоритмы и обеспечивать безопасное управление данными.",
    LanguageId = 4 // Russian
},

// Blog Id = 2 Translations
new Translation
{
    Id = 16,
    EntityName = "Blog",
    EntityId = 2,
    Key = "DefaultTitle",
    Value = "Important Tips for Mobile App Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 17,
    EntityName = "Blog",
    EntityId = 2,
    Key = "DefaultTitle",
    Value = "Wichtige Tipps für die Entwicklung mobiler Apps",
    LanguageId = 3 // German
},
new Translation
{
    Id = 18,
    EntityName = "Blog",
    EntityId = 2,
    Key = "DefaultTitle",
    Value = "Важные советы по разработке мобильных приложений",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 19,
    EntityName = "Blog",
    EntityId = 2,
    Key = "DefaultContent",
    Value = "Developing a mobile application involves several stages, from design to user experience. Understanding user needs and delivering value-driven solutions are crucial for creating a successful app. Security and cross-platform compatibility are also vital factors for long-term success.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 20,
    EntityName = "Blog",
    EntityId = 2,
    Key = "DefaultContent",
    Value = "Die Entwicklung einer mobilen Anwendung umfasst mehrere Phasen, vom Design bis zur Benutzererfahrung. Das Verständnis der Benutzerbedürfnisse und das Anbieten wertschöpfender Lösungen sind entscheidend für die erfolgreiche Entwicklung einer App. Sicherheit und plattformübergreifende Kompatibilität sind ebenfalls wichtige Faktoren für den langfristigen Erfolg.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 21,
    EntityName = "Blog",
    EntityId = 2,
    Key = "DefaultContent",
    Value = "Разработка мобильного приложения включает в себя несколько этапов, от дизайна до пользовательского опыта. Понимание потребностей пользователей и предоставление решений, ориентированных на ценность, имеют решающее значение для создания успешного приложения. Безопасность и кроссплатформенная совместимость также являются важными факторами для долгосрочного успеха.",
    LanguageId = 4 // Russian
},

// Blog Id = 3 Translations
new Translation
{
    Id = 22,
    EntityName = "Blog",
    EntityId = 3,
    Key = "DefaultTitle",
    Value = "API Integration and Data Security",
    LanguageId = 2 // English
},
new Translation
{
    Id = 23,
    EntityName = "Blog",
    EntityId = 3,
    Key = "DefaultTitle",
    Value = "API-Integration und Datensicherheit",
    LanguageId = 3 // German
},
new Translation
{
    Id = 24,
    EntityName = "Blog",
    EntityId = 3,
    Key = "DefaultTitle",
    Value = "Интеграция API и безопасность данных",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 25,
    EntityName = "Blog",
    EntityId = 3,
    Key = "DefaultContent",
    Value = "API integration facilitates data sharing between different systems, ensuring both functionality and data security. Sensitive data must be protected with encryption and secure APIs to prevent data leaks and performance issues.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 26,
    EntityName = "Blog",
    EntityId = 3,
    Key = "DefaultContent",
    Value = "Die API-Integration ermöglicht den Datenaustausch zwischen verschiedenen Systemen und gewährleistet sowohl Funktionalität als auch Datensicherheit. Sensible Daten müssen mit Verschlüsselung und sicheren APIs geschützt werden, um Datenlecks und Leistungsprobleme zu vermeiden.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 27,
    EntityName = "Blog",
    EntityId = 3,
    Key = "DefaultContent",
    Value = "Интеграция API облегчает обмен данными между различными системами, обеспечивая как функциональность, так и безопасность данных. Конфиденциальные данные должны защищаться с помощью шифрования и безопасных API, чтобы предотвратить утечки данных и проблемы с производительностью.",
    LanguageId = 4 // Russian
},

// Blog Id = 4 Translations
new Translation
{
    Id = 28,
    EntityName = "Blog",
    EntityId = 4,
    Key = "DefaultTitle",
    Value = "Benefits of ERP Systems for Businesses",
    LanguageId = 2 // English
},
new Translation
{
    Id = 29,
    EntityName = "Blog",
    EntityId = 4,
    Key = "DefaultTitle",
    Value = "Vorteile von ERP-Systemen für Unternehmen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 30,
    EntityName = "Blog",
    EntityId = 4,
    Key = "DefaultTitle",
    Value = "Преимущества ERP-систем для бизнеса",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 31,
    EntityName = "Blog",
    EntityId = 4,
    Key = "DefaultContent",
    Value = "ERP systems allow businesses to manage their operations more efficiently. By integrating departments like finance, human resources, and supply chain, businesses can centralize their data management.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 32,
    EntityName = "Blog",
    EntityId = 4,
    Key = "DefaultContent",
    Value = "ERP-Systeme ermöglichen es Unternehmen, ihre Abläufe effizienter zu verwalten. Durch die Integration von Abteilungen wie Finanzen, Personalwesen und Lieferkette können Unternehmen ihre Datenverwaltung zentralisieren.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 33,
    EntityName = "Blog",
    EntityId = 4,
    Key = "DefaultContent",
    Value = "ERP-системы позволяют компаниям более эффективно управлять своими операциями. Интеграция таких отделов, как финансы, кадры и цепочка поставок, позволяет компаниям централизовать управление данными.",
    LanguageId = 4 // Russian
},

// Blog Id = 5 Translations
new Translation
{
    Id = 34,
    EntityName = "Blog",
    EntityId = 5,
    Key = "DefaultTitle",
    Value = "Leading Technologies in Game Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 35,
    EntityName = "Blog",
    EntityId = 5,
    Key = "DefaultTitle",
    Value = "Führende Technologien in der Spieleentwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 36,
    EntityName = "Blog",
    EntityId = 5,
    Key = "DefaultTitle",
    Value = "Передовые технологии в разработке игр",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 37,
    EntityName = "Blog",
    EntityId = 5,
    Key = "DefaultContent",
    Value = "Game development technologies are advancing rapidly, providing new opportunities. Engines like Unity and Unreal Engine offer high performance and visuals.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 38,
    EntityName = "Blog",
    EntityId = 5,
    Key = "DefaultContent",
    Value = "Die Technologien in der Spieleentwicklung schreiten schnell voran und bieten neue Möglichkeiten. Engines wie Unity und Unreal Engine bieten hohe Leistung und visuelle Qualität.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 39,
    EntityName = "Blog",
    EntityId = 5,
    Key = "DefaultContent",
    Value = "Технологии разработки игр быстро развиваются, предоставляя новые возможности. Движки, такие как Unity и Unreal Engine, предлагают высокую производительность и визуальные эффекты.",
    LanguageId = 4 // Russian
},

// Blog Id = 6 Translations
new Translation
{
    Id = 40,
    EntityName = "Blog",
    EntityId = 6,
    Key = "DefaultTitle",
    Value = "Web Development Trend: Progressive Web Apps",
    LanguageId = 2 // English
},
new Translation
{
    Id = 41,
    EntityName = "Blog",
    EntityId = 6,
    Key = "DefaultTitle",
    Value = "Web-Entwicklungstrend: Progressive Web Apps",
    LanguageId = 3 // German
},
new Translation
{
    Id = 42,
    EntityName = "Blog",
    EntityId = 6,
    Key = "DefaultTitle",
    Value = "Тренд веб-разработки: Прогрессивные веб-приложения",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 43,
    EntityName = "Blog",
    EntityId = 6,
    Key = "DefaultContent",
    Value = "Progressive Web Apps (PWA) are web applications that enhance user experience with fast load times, offline access, and push notifications.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 44,
    EntityName = "Blog",
    EntityId = 6,
    Key = "DefaultContent",
    Value = "Progressive Web Apps (PWA) sind Webanwendungen, die das Benutzererlebnis mit schnellen Ladezeiten, Offline-Zugang und Push-Benachrichtigungen verbessern.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 45,
    EntityName = "Blog",
    EntityId = 6,
    Key = "DefaultContent",
    Value = "Прогрессивные веб-приложения (PWA) - это веб-приложения, которые улучшают пользовательский опыт благодаря быстрой загрузке, офлайн-доступу и push-уведомлениям.",
    LanguageId = 4 // Russian
},
        new Translation
        {
            Id = 46,
            EntityName = "CompanyInfo",
            EntityId = 1,
            Key = "CompanyArea",
            Value = "Health and Technology Services Limited Company",
            LanguageId = 2 // English
        },
new Translation
{
    Id = 47,
    EntityName = "CompanyInfo",
    EntityId = 1,
    Key = "CompanyArea",
    Value = "Gesundheits- und Technologiedienstleistungen GmbH",
    LanguageId = 3 // German
},
new Translation
{
    Id = 48,
    EntityName = "CompanyInfo",
    EntityId = 1,
    Key = "CompanyArea",
    Value = "Компания по предоставлению услуг в области здравоохранения и технологий",
    LanguageId = 4 // Russian
},

new Translation
{
    Id = 49,
    EntityName = "CompanyInfo",
    EntityId = 1,
    Key = "Residence",
    Value = "Istanbul, Turkey",
    LanguageId = 2 // English
},
new Translation
{
    Id = 50,
    EntityName = "CompanyInfo",
    EntityId = 1,
    Key = "Residence",
    Value = "Istanbul, Türkei",
    LanguageId = 3 // German
},
new Translation
{
    Id = 51,
    EntityName = "CompanyInfo",
    EntityId = 1,
    Key = "Residence",
    Value = "Стамбул, Турция",
    LanguageId = 4 // Russian
},

new Translation
{
    Id = 52,
    EntityName = "CompanyInfo",
    EntityId = 1,
    Key = "Address",
    Value = "5th Zeytinlik Street No:13/A, 34676 Küplüce Neighborhood, Üsküdar",
    LanguageId = 2 // English
},
new Translation
{
    Id = 53,
    EntityName = "CompanyInfo",
    EntityId = 1,
    Key = "Address",
    Value = "5. Zeytinlik Straße Nr.13/A, 34676 Küplüce Viertel, Üsküdar",
    LanguageId = 3 // German
},
new Translation
{
    Id = 54,
    EntityName = "CompanyInfo",
    EntityId = 1,
    Key = "Address",
    Value = "Улица 5-я Зейтинлик, дом 13/A, 34676, район Кюплюдже, Ускюдар",
    LanguageId = 4 // Russian
},
        // FAQ Id = 1 Translations
        new Translation
        {
            Id = 55,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "DefaultTitle",
            Value = "Frequently Asked Questions",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 56,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "DefaultTitle",
            Value = "Häufig gestellte Fragen",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 57,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "DefaultTitle",
            Value = "Часто задаваемые вопросы",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 58,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "DefaultContent",
            Value = "Here you can find answers to frequently asked questions about our services and company.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 59,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "DefaultContent",
            Value = "Hier finden Sie Antworten auf häufig gestellte Fragen zu unseren Dienstleistungen und unserem Unternehmen.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 60,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "DefaultContent",
            Value = "Здесь вы можете найти ответы на часто задаваемые вопросы о наших услугах и компании.",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 61,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "Question",
            Value = "What is TechLiberty?",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 62,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "Question",
            Value = "Was ist TechLiberty?",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 63,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "Question",
            Value = "Что такое TechLiberty?",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 64,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "Answer",
            Value = "TechLiberty is a technology company providing software solutions and supporting businesses in digital transformation processes.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 65,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "Answer",
            Value = "TechLiberty ist ein Technologieunternehmen, das Softwarelösungen anbietet und Unternehmen bei der digitalen Transformation unterstützt.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 66,
            EntityName = "FAQ",
            EntityId = 1,
            Key = "Answer",
            Value = "TechLiberty — это технологическая компания, предоставляющая программные решения и поддерживающая компании в процессе цифровой трансформации.",
            LanguageId = 4 // Russian
        },

        // FAQ Id = 2 Translations
        new Translation
        {
            Id = 67,
            EntityName = "FAQ",
            EntityId = 2,
            Key = "Question",
            Value = "Which services do you offer?",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 68,
            EntityName = "FAQ",
            EntityId = 2,
            Key = "Question",
            Value = "Welche Dienstleistungen bieten Sie an?",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 69,
            EntityName = "FAQ",
            EntityId = 2,
            Key = "Question",
            Value = "Какие услуги вы предлагаете?",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 70,
            EntityName = "FAQ",
            EntityId = 2,
            Key = "Answer",
            Value = "We offer mobile and web application development, game development, API integration, CRM and ERP solutions, database management, and system analysis services.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 71,
            EntityName = "FAQ",
            EntityId = 2,
            Key = "Answer",
            Value = "Wir bieten mobile und Webanwendungsentwicklung, Spieleentwicklung, API-Integration, CRM- und ERP-Lösungen, Datenbankmanagement und Systemanalyse an.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 72,
            EntityName = "FAQ",
            EntityId = 2,
            Key = "Answer",
            Value = "Мы предлагаем разработку мобильных и веб-приложений, разработку игр, интеграцию API, решения CRM и ERP, управление базами данных и анализ систем.",
            LanguageId = 4 // Russian
        },
// FAQ Id = 3 Translations
new Translation
{
    Id = 73,
    EntityName = "FAQ",
    EntityId = 3,
    Key = "Question",
    Value = "How can I contact you?",
    LanguageId = 2 // English
},
new Translation
{
    Id = 74,
    EntityName = "FAQ",
    EntityId = 3,
    Key = "Question",
    Value = "Wie kann ich Sie kontaktieren?",
    LanguageId = 3 // German
},
new Translation
{
    Id = 75,
    EntityName = "FAQ",
    EntityId = 3,
    Key = "Question",
    Value = "Как я могу с вами связаться?",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 76,
    EntityName = "FAQ",
    EntityId = 3,
    Key = "Answer",
    Value = "You can reach us by email (info@techliberty.co) or phone (+90 (543) 233 33 32). You can also c us through our social media accounts.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 77,
    EntityName = "FAQ",
    EntityId = 3,
    Key = "Answer",
    Value = "Sie können uns per E-Mail (info@techliberty.co) oder telefonisch (+90 (543) 233 33 32) erreichen. Sie können uns auch über unsere Social-Media-Konten kontaktieren.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 78,
    EntityName = "FAQ",
    EntityId = 3,
    Key = "Answer",
    Value = "Вы можете связаться с нами по электронной почте (info@techliberty.co) или по телефону (+90 (543) 233 33 32). Также вы можете связаться с нами через наши аккаунты в социальных сетях.",
    LanguageId = 4 // Russian
},

// FAQ Id = 4 Translations
new Translation
{
    Id = 79,
    EntityName = "FAQ",
    EntityId = 4,
    Key = "Question",
    Value = "What is the process of a project?",
    LanguageId = 2 // English
},
new Translation
{
    Id = 80,
    EntityName = "FAQ",
    EntityId = 4,
    Key = "Question",
    Value = "Wie verläuft ein Projektprozess?",
    LanguageId = 3 // German
},
new Translation
{
    Id = 81,
    EntityName = "FAQ",
    EntityId = 4,
    Key = "Question",
    Value = "Как происходит процесс проекта?",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 82,
    EntityName = "FAQ",
    EntityId = 4,
    Key = "Answer",
    Value = "Our projects consist of analysis, design, development, testing, and delivery stages. We maintain close communication with the client at each stage.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 83,
    EntityName = "FAQ",
    EntityId = 4,
    Key = "Answer",
    Value = "Unsere Projekte bestehen aus den Phasen Analyse, Design, Entwicklung, Test und Lieferung. In jeder Phase stehen wir in engem Kontakt mit dem Kunden.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 84,
    EntityName = "FAQ",
    EntityId = 4,
    Key = "Answer",
    Value = "Наши проекты состоят из этапов анализа, проектирования, разработки, тестирования и доставки. На каждом этапе мы поддерживаем тесную связь с клиентом.",
    LanguageId = 4 // Russian
},

// FAQ Id = 5 Translations
new Translation
{
    Id = 85,
    EntityName = "FAQ",
    EntityId = 5,
    Key = "Question",
    Value = "Do you offer support after delivery?",
    LanguageId = 2 // English
},
new Translation
{
    Id = 86,
    EntityName = "FAQ",
    EntityId = 5,
    Key = "Question",
    Value = "Bieten Sie nach der Lieferung Unterstützung an?",
    LanguageId = 3 // German
},
new Translation
{
    Id = 87,
    EntityName = "FAQ",
    EntityId = 5,
    Key = "Question",
    Value = "Вы оказываете поддержку после доставки?",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 88,
    EntityName = "FAQ",
    EntityId = 5,
    Key = "Answer",
    Value = "Yes, we provide maintenance and support services after project delivery. We offer all the assistance needed to ensure the successful continuation of your project.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 89,
    EntityName = "FAQ",
    EntityId = 5,
    Key = "Answer",
    Value = "Ja, wir bieten Wartungs- und Unterstützungsdienste nach der Projektauslieferung an. Wir bieten alle erforderliche Unterstützung, um den erfolgreichen Fortbestand Ihres Projekts zu gewährleisten.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 90,
    EntityName = "FAQ",
    EntityId = 5,
    Key = "Answer",
    Value = "Да, мы предоставляем услуги по техническому обслуживанию и поддержке после завершения проекта. Мы предоставляем всю необходимую помощь для успешного продолжения вашего проекта.",
    LanguageId = 4 // Russian
},

// FAQ Id = 6 Translations
new Translation
{
    Id = 91,
    EntityName = "FAQ",
    EntityId = 6,
    Key = "Question",
    Value = "What industries do you serve?",
    LanguageId = 2 // English
},
new Translation
{
    Id = 92,
    EntityName = "FAQ",
    EntityId = 6,
    Key = "Question",
    Value = "Welche Branchen bedienen Sie?",
    LanguageId = 3 // German
},
new Translation
{
    Id = 93,
    EntityName = "FAQ",
    EntityId = 6,
    Key = "Question",
    Value = "Какие отрасли вы обслуживаете?",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 94,
    EntityName = "FAQ",
    EntityId = 6,
    Key = "Answer",
    Value = "We offer software solutions for various sectors including finance, healthcare, education, retail, manufacturing, and logistics.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 95,
    EntityName = "FAQ",
    EntityId = 6,
    Key = "Answer",
    Value = "Wir bieten Softwarelösungen für verschiedene Branchen, darunter Finanzen, Gesundheitswesen, Bildung, Einzelhandel, Produktion und Logistik.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 96,
    EntityName = "FAQ",
    EntityId = 6,
    Key = "Answer",
    Value = "Мы предлагаем программные решения для различных отраслей, включая финансы, здравоохранение, образование, розничную торговлю, производство и логистику.",
    LanguageId = 4 // Russian
},

// FAQ Id = 7 Translations
new Translation
{
    Id = 97,
    EntityName = "FAQ",
    EntityId = 7,
    Key = "Question",
    Value = "How long does a project take?",
    LanguageId = 2 // English
},
new Translation
{
    Id = 98,
    EntityName = "FAQ",
    EntityId = 7,
    Key = "Question",
    Value = "Wie lange dauert ein Projekt?",
    LanguageId = 3 // German
},
new Translation
{
    Id = 99,
    EntityName = "FAQ",
    EntityId = 7,
    Key = "Question",
    Value = "Сколько времени занимает проект?",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 100,
    EntityName = "FAQ",
    EntityId = 7,
    Key = "Answer",
    Value = "The project duration varies depending on the complexity and requirements. Generally, a project can take several weeks to several months.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 101,
    EntityName = "FAQ",
    EntityId = 7,
    Key = "Answer",
    Value = "Die Projektdauer variiert je nach Komplexität und Anforderungen. In der Regel dauert ein Projekt mehrere Wochen bis mehrere Monate.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 102,
    EntityName = "FAQ",
    EntityId = 7,
    Key = "Answer",
    Value = "Продолжительность проекта зависит от сложности и требований. Обычно проект может занять от нескольких недель до нескольких месяцев.",
    LanguageId = 4 // Russian
},

// FAQ Id = 8 Translations
new Translation
{
    Id = 103,
    EntityName = "FAQ",
    EntityId = 8,
    Key = "Question",
    Value = "Do you have international experience?",
    LanguageId = 2 // English
},
new Translation
{
    Id = 104,
    EntityName = "FAQ",
    EntityId = 8,
    Key = "Question",
    Value = "Haben Sie internationale Erfahrung?",
    LanguageId = 3 // German
},
new Translation
{
    Id = 105,
    EntityName = "FAQ",
    EntityId = 8,
    Key = "Question",
    Value = "У вас есть международный опыт?",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 106,
    EntityName = "FAQ",
    EntityId = 8,
    Key = "Answer",
    Value = "Yes, we have worked with many clients abroad and are familiar with international business processes.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 107,
    EntityName = "FAQ",
    EntityId = 8,
    Key = "Answer",
    Value = "Ja, wir haben mit vielen Kunden im Ausland zusammengearbeitet und sind mit internationalen Geschäftsprozessen vertraut.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 108,
    EntityName = "FAQ",
    EntityId = 8,
    Key = "Answer",
    Value = "Да, мы работали со многими клиентами за рубежом и знакомы с международными бизнес-процессами.",
    LanguageId = 4 // Russian
},

// FAQ Id = 9 Translations
new Translation
{
    Id = 109,
    EntityName = "FAQ",
    EntityId = 9,
    Key = "Question",
    Value = "What technologies do you use?",
    LanguageId = 2 // English
},
new Translation
{
    Id = 110,
    EntityName = "FAQ",
    EntityId = 9,
    Key = "Question",
    Value = "Welche Technologien verwenden Sie?",
    LanguageId = 3 // German
},
new Translation
{
    Id = 111,
    EntityName = "FAQ",
    EntityId = 9,
    Key = "Question",
    Value = "Какие технологии вы используете?",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 112,
    EntityName = "FAQ",
    EntityId = 9,
    Key = "Answer",
    Value = "Depending on project requirements, we use various programming languages and tools like .NET, Java, Python, React, Angular, and Flutter.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 113,
    EntityName = "FAQ",
    EntityId = 9,
    Key = "Answer",
    Value = "Je nach Projektanforderungen verwenden wir verschiedene Programmiersprachen und Tools wie .NET, Java, Python, React, Angular und Flutter.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 114,
    EntityName = "FAQ",
    EntityId = 9,
    Key = "Answer",
    Value = "В зависимости от требований проекта мы используем различные языки программирования и инструменты, такие как .NET, Java, Python, React, Angular и Flutter.",
    LanguageId = 4 // Russian
},

// FAQ Id = 10 Translations
new Translation
{
    Id = 115,
    EntityName = "FAQ",
    EntityId = 10,
    Key = "Question",
    Value = "How do you ensure data security?",
    LanguageId = 2 // English
},
new Translation
{
    Id = 116,
    EntityName = "FAQ",
    EntityId = 10,
    Key = "Question",
    Value = "Wie gewährleisten Sie die Datensicherheit?",
    LanguageId = 3 // German
},
new Translation
{
    Id = 117,
    EntityName = "FAQ",
    EntityId = 10,
    Key = "Question",
    Value = "Как вы обеспечиваете безопасность данных?",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 118,
    EntityName = "FAQ",
    EntityId = 10,
    Key = "Answer",
    Value = "We ensure data security through security protocols and best practices. We take measures such as data encryption, secure APIs, and access controls.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 119,
    EntityName = "FAQ",
    EntityId = 10,
    Key = "Answer",
    Value = "Wir gewährleisten die Datensicherheit durch Sicherheitsprotokolle und bewährte Verfahren. Wir treffen Maßnahmen wie Datenverschlüsselung, sichere APIs und Zugangskontrollen.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 120,
    EntityName = "FAQ",
    EntityId = 10,
    Key = "Answer",
    Value = "Мы обеспечиваем безопасность данных с помощью протоколов безопасности и передовых методов. Мы принимаем такие меры, как шифрование данных, безопасные API и контроль доступа.",
    LanguageId = 4 // Russian
},
// History Id = 1 Translations
new Translation
{
    Id = 121,
    EntityName = "History",
    EntityId = 1,
    Key = "DefaultTitle",
    Value = "Our Company History",
    LanguageId = 2 // English
},
new Translation
{
    Id = 122,
    EntityName = "History",
    EntityId = 1,
    Key = "DefaultTitle",
    Value = "Die Geschichte unseres Unternehmens",
    LanguageId = 3 // German
},
new Translation
{
    Id = 123,
    EntityName = "History",
    EntityId = 1,
    Key = "DefaultTitle",
    Value = "История нашей компании",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 124,
    EntityName = "History",
    EntityId = 1,
    Key = "DefaultContent",
    Value = "Discover TechLiberty's growth, vision, and key projects from our inception to now.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 125,
    EntityName = "History",
    EntityId = 1,
    Key = "DefaultContent",
    Value = "Entdecken Sie TechLibertys Wachstum, Vision und wichtige Projekte von Anfang an bis heute.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 126,
    EntityName = "History",
    EntityId = 1,
    Key = "DefaultContent",
    Value = "Узнайте о росте, видении и ключевых проектах компании TechLiberty с момента основания.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 127,
    EntityName = "History",
    EntityId = 1,
    Key = "YearDescription",
    Value = "TechLiberty Software Solutions was founded on October 29, 2023, to address ERP shortcomings in the private sector, aiming for digital transformation.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 128,
    EntityName = "History",
    EntityId = 1,
    Key = "YearDescription",
    Value = "TechLiberty Software Solutions wurde am 29. Oktober 2023 gegründet, um ERP-Lücken im privaten Sektor zu schließen und die digitale Transformation zu fördern.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 129,
    EntityName = "History",
    EntityId = 1,
    Key = "YearDescription",
    Value = "TechLiberty Software Solutions основана 29 октября 2023 года для устранения недостатков ERP в частном секторе, нацеленного на цифровую трансформацию.",
    LanguageId = 4 // Russian
},

// History Id = 2 Translations
new Translation
{
    Id = 130,
    EntityName = "History",
    EntityId = 2,
    Key = "DefaultTitle",
    Value = "Expanding Our Vision",
    LanguageId = 2 // English
},
new Translation
{
    Id = 131,
    EntityName = "History",
    EntityId = 2,
    Key = "DefaultTitle",
    Value = "Unsere Vision erweitern",
    LanguageId = 3 // German
},
new Translation
{
    Id = 132,
    EntityName = "History",
    EntityId = 2,
    Key = "DefaultTitle",
    Value = "Расширение нашего видения",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 133,
    EntityName = "History",
    EntityId = 2,
    Key = "DefaultContent",
    Value = "Explore the journey of TechLiberty's growth, vision, and achievements since the foundation.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 134,
    EntityName = "History",
    EntityId = 2,
    Key = "DefaultContent",
    Value = "Erfahren Sie mehr über TechLibertys Wachstum, Vision und Erfolge seit der Gründung.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 135,
    EntityName = "History",
    EntityId = 2,
    Key = "DefaultContent",
    Value = "Узнайте о пути роста, видении и достижениях TechLiberty с момента основания.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 136,
    EntityName = "History",
    EntityId = 2,
    Key = "YearDescription",
    Value = "In 2024, 'Gof Games' was launched, inspired by the founder's dog Gofret, aiming for fun and emotion in gaming.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 137,
    EntityName = "History",
    EntityId = 2,
    Key = "YearDescription",
    Value = "2024 wurde 'Gof Games' inspiriert vom Hund des Gründers Gofret ins Leben gerufen und strebt nach Spaß und Emotion im Gaming.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 138,
    EntityName = "History",
    EntityId = 2,
    Key = "YearDescription",
    Value = "В 2024 году был запущен 'Gof Games', вдохновленный собакой основателя Гофрет, для веселья и эмоций в играх.",
    LanguageId = 4 // Russian
},

// History Id = 3 Translations
new Translation
{
    Id = 139,
    EntityName = "History",
    EntityId = 3,
    Key = "DefaultTitle",
    Value = "Ongoing Innovation",
    LanguageId = 2 // English
},
new Translation
{
    Id = 140,
    EntityName = "History",
    EntityId = 3,
    Key = "DefaultTitle",
    Value = "Laufende Innovation",
    LanguageId = 3 // German
},
new Translation
{
    Id = 141,
    EntityName = "History",
    EntityId = 3,
    Key = "DefaultTitle",
    Value = "Непрерывные инновации",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 142,
    EntityName = "History",
    EntityId = 3,
    Key = "DefaultContent",
    Value = "Explore TechLiberty's journey in offering innovative solutions for digital transformation.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 143,
    EntityName = "History",
    EntityId = 3,
    Key = "DefaultContent",
    Value = "Erkunden Sie TechLibertys Reise bei der Bereitstellung innovativer Lösungen für die digitale Transformation.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 144,
    EntityName = "History",
    EntityId = 3,
    Key = "DefaultContent",
    Value = "Исследуйте путь TechLiberty в предоставлении инновационных решений для цифровой трансформации.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 145,
    EntityName = "History",
    EntityId = 3,
    Key = "YearDescription",
    Value = "TechLiberty focuses on innovation and technology at its core, aiming to support companies’ digital transformations.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 146,
    EntityName = "History",
    EntityId = 3,
    Key = "YearDescription",
    Value = "TechLiberty konzentriert sich auf Innovation und Technologie und unterstützt die digitale Transformation von Unternehmen.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 147,
    EntityName = "History",
    EntityId = 3,
    Key = "YearDescription",
    Value = "TechLiberty сосредотачивается на инновациях и технологиях, поддерживая цифровую трансформацию компаний.",
    LanguageId = 4 // Russian
},

// Service Id = 1 Translations
new Translation
{
    Id = 148,
    EntityName = "Service",
    EntityId = 1,
    Key = "DefaultTitle",
    Value = "Web Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 149,
    EntityName = "Service",
    EntityId = 1,
    Key = "DefaultTitle",
    Value = "Webentwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 150,
    EntityName = "Service",
    EntityId = 1,
    Key = "DefaultTitle",
    Value = "Веб-разработка",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 151,
    EntityName = "Service",
    EntityId = 1,
    Key = "DefaultContent",
    Value = "Web development is a strategic process to strengthen your digital presence. We analyze your needs and goals to offer user-friendly, modern, and scalable web solutions. Our professional team supports you at every stage, from design and user experience to performance, prioritizing code quality, SEO compliance, and security to help your business succeed online.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 152,
    EntityName = "Service",
    EntityId = 1,
    Key = "DefaultContent",
    Value = "Webentwicklung ist ein strategischer Prozess zur Stärkung Ihrer digitalen Präsenz. Wir analysieren Ihre Bedürfnisse und Ziele, um benutzerfreundliche, moderne und skalierbare Weblösungen anzubieten. Unser professionelles Team unterstützt Sie in jeder Phase, von Design und Benutzererfahrung bis zur Leistung, wobei wir Codequalität, SEO-Konformität und Sicherheit priorisieren, um Ihrem Unternehmen online zum Erfolg zu verhelfen.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 153,
    EntityName = "Service",
    EntityId = 1,
    Key = "DefaultContent",
    Value = "Веб-разработка - это стратегический процесс, направленный на укрепление вашего цифрового присутствия. Мы анализируем ваши потребности и цели, чтобы предложить удобные, современные и масштабируемые веб-решения. Наша профессиональная команда поддерживает вас на каждом этапе, от проектирования и пользовательского опыта до производительности, уделяя первоочередное внимание качеству кода, соответствию SEO и безопасности, чтобы помочь вашему бизнесу добиться успеха в Интернете.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 154,
    EntityName = "Service",
    EntityId = 1,
    Key = "ServiceSummary",
    Value = "We offer professional web development to deliver modern, user-friendly, and scalable websites.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 155,
    EntityName = "Service",
    EntityId = 1,
    Key = "ServiceSummary",
    Value = "Wir bieten professionelle Webentwicklung, um moderne, benutzerfreundliche und skalierbare Websites bereitzustellen.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 156,
    EntityName = "Service",
    EntityId = 1,
    Key = "ServiceSummary",
    Value = "Мы предлагаем профессиональную веб-разработку для создания современных, удобных и масштабируемых веб-сайтов.",
    LanguageId = 4 // Russian
},

// Service Id = 2 Translations
new Translation
{
    Id = 157,
    EntityName = "Service",
    EntityId = 2,
    Key = "DefaultTitle",
    Value = "Mobile App Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 158,
    EntityName = "Service",
    EntityId = 2,
    Key = "DefaultTitle",
    Value = "Mobile App Entwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 159,
    EntityName = "Service",
    EntityId = 2,
    Key = "DefaultTitle",
    Value = "Разработка мобильных приложений",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 160,
    EntityName = "Service",
    EntityId = 2,
    Key = "DefaultContent",
    Value = "Mobile app development has become central to user experience today. We develop high-performance, user-friendly applications on iOS and Android. By analyzing user habits, we deliver designs that enhance engagement and capture attention. Our applications focus on security, speed, and are built for easy updates and scalability, offering a long-term solution for growth in the digital world.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 161,
    EntityName = "Service",
    EntityId = 2,
    Key = "DefaultContent",
    Value = "Die Entwicklung mobiler Apps ist heute zentral für das Benutzererlebnis. Wir entwickeln leistungsstarke, benutzerfreundliche Anwendungen für iOS und Android. Durch die Analyse der Benutzergewohnheiten bieten wir Designs, die das Engagement steigern und die Aufmerksamkeit fesseln. Unsere Anwendungen sind sicher, schnell und bieten einfache Updates und Skalierbarkeit als langfristige Lösung für das Wachstum in der digitalen Welt.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 162,
    EntityName = "Service",
    EntityId = 2,
    Key = "DefaultContent",
    Value = "Разработка мобильных приложений стала центральным элементом пользовательского опыта сегодня. Мы разрабатываем высокопроизводительные, удобные приложения для iOS и Android. Анализируя привычки пользователей, мы создаем дизайны, которые повышают вовлеченность и привлекают внимание. Наши приложения сосредоточены на безопасности, скорости и имеют легкую масштабируемость и обновления, предлагая долгосрочное решение для роста в цифровом мире.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 163,
    EntityName = "Service",
    EntityId = 2,
    Key = "ServiceSummary",
    Value = "User-centered mobile app development for iOS and Android.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 164,
    EntityName = "Service",
    EntityId = 2,
    Key = "ServiceSummary",
    Value = "Benutzerzentrierte mobile App-Entwicklung für iOS und Android.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 165,
    EntityName = "Service",
    EntityId = 2,
    Key = "ServiceSummary",
    Value = "Разработка мобильных приложений для iOS и Android, ориентированная на пользователя.",
    LanguageId = 4 // Russian
},

// Service Id = 3 Translations
new Translation
{
    Id = 166,
    EntityName = "Service",
    EntityId = 3,
    Key = "DefaultTitle",
    Value = "Game Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 167,
    EntityName = "Service",
    EntityId = 3,
    Key = "DefaultTitle",
    Value = "Spieleentwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 168,
    EntityName = "Service",
    EntityId = 3,
    Key = "DefaultTitle",
    Value = "Разработка игр",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 169,
    EntityName = "Service",
    EntityId = 3,
    Key = "DefaultContent",
    Value = "Game development is both a technical and creative process. We leverage advanced technologies to create fun, immersive, and high-performance games. Working with powerful tools like Unity and Unreal Engine, we develop games that meet your target audience's expectations with quality graphics and smooth gameplay. We focus on creating games that captivate players, foster emotional connections, and encourage repeated play.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 170,
    EntityName = "Service",
    EntityId = 3,
    Key = "DefaultContent",
    Value = "Die Spieleentwicklung ist sowohl ein technischer als auch ein kreativer Prozess. Wir nutzen fortschrittliche Technologien, um unterhaltsame, immersive und leistungsstarke Spiele zu entwickeln. Mit leistungsstarken Tools wie Unity und Unreal Engine erstellen wir Spiele, die den Erwartungen Ihrer Zielgruppe mit hochwertiger Grafik und reibungslosem Gameplay gerecht werden. Wir konzentrieren uns darauf, Spiele zu entwickeln, die Spieler fesseln, emotionale Verbindungen fördern und zum erneuten Spielen anregen.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 171,
    EntityName = "Service",
    EntityId = 3,
    Key = "DefaultContent",
    Value = "Разработка игр - это одновременно технический и творческий процесс. Мы используем передовые технологии для создания увлекательных, захватывающих и высокопроизводительных игр. Работая с такими мощными инструментами, как Unity и Unreal Engine, мы разрабатываем игры, которые соответствуют ожиданиям вашей целевой аудитории благодаря качественной графике и плавному игровому процессу. Мы сосредоточены на создании игр, которые привлекают игроков, способствуют эмоциональной связи и побуждают к повторной игре.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 172,
    EntityName = "Service",
    EntityId = 3,
    Key = "ServiceSummary",
    Value = "Engaging game development using advanced technologies.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 173,
    EntityName = "Service",
    EntityId = 3,
    Key = "ServiceSummary",
    Value = "Fesselnde Spieleentwicklung mit fortschrittlichen Technologien.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 174,
    EntityName = "Service",
    EntityId = 3,
    Key = "ServiceSummary",
    Value = "Увлекательная разработка игр с использованием передовых технологий.",
    LanguageId = 4 // Russian
},
// Service Id = 4 Translations
new Translation
{
    Id = 175,
    EntityName = "Service",
    EntityId = 4,
    Key = "DefaultTitle",
    Value = "API Integration",
    LanguageId = 2 // English
},
new Translation
{
    Id = 176,
    EntityName = "Service",
    EntityId = 4,
    Key = "DefaultTitle",
    Value = "API-Integration",
    LanguageId = 3 // German
},
new Translation
{
    Id = 177,
    EntityName = "Service",
    EntityId = 4,
    Key = "DefaultTitle",
    Value = "Интеграция API",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 178,
    EntityName = "Service",
    EntityId = 4,
    Key = "DefaultContent",
    Value = "API integration allows different systems to communicate securely and efficiently. We offer API development and integration services to streamline data flow and enhance process efficiency in your business, prioritizing security for sensitive data and building a stable infrastructure.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 179,
    EntityName = "Service",
    EntityId = 4,
    Key = "DefaultContent",
    Value = "Die API-Integration ermöglicht es verschiedenen Systemen, sicher und effizient zu kommunizieren. Wir bieten API-Entwicklungs- und Integrationsdienste zur Optimierung des Datenflusses und zur Verbesserung der Prozesseffizienz in Ihrem Unternehmen an, wobei die Sicherheit sensibler Daten und eine stabile Infrastruktur im Vordergrund stehen.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 180,
    EntityName = "Service",
    EntityId = 4,
    Key = "DefaultContent",
    Value = "Интеграция API позволяет различным системам безопасно и эффективно взаимодействовать. Мы предлагаем услуги по разработке и интеграции API для оптимизации потоков данных и повышения эффективности процессов в вашем бизнесе, уделяя приоритетное внимание безопасности конфиденциальных данных и созданию стабильной инфраструктуры.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 181,
    EntityName = "Service",
    EntityId = 4,
    Key = "ServiceSummary",
    Value = "API integration for secure and optimized data flow.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 182,
    EntityName = "Service",
    EntityId = 4,
    Key = "ServiceSummary",
    Value = "API-Integration für sicheren und optimierten Datenfluss.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 183,
    EntityName = "Service",
    EntityId = 4,
    Key = "ServiceSummary",
    Value = "Интеграция API для безопасного и оптимизированного потока данных.",
    LanguageId = 4 // Russian
},

// Service Id = 5 Translations
new Translation
{
    Id = 184,
    EntityName = "Service",
    EntityId = 5,
    Key = "DefaultTitle",
    Value = "CRM Solutions",
    LanguageId = 2 // English
},
new Translation
{
    Id = 185,
    EntityName = "Service",
    EntityId = 5,
    Key = "DefaultTitle",
    Value = "CRM-Lösungen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 186,
    EntityName = "Service",
    EntityId = 5,
    Key = "DefaultTitle",
    Value = "CRM-решения",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 187,
    EntityName = "Service",
    EntityId = 5,
    Key = "DefaultContent",
    Value = "CRM is essential for building strong, lasting relationships with your customers. Our CRM solutions enhance customer satisfaction and optimize your sales, marketing, and service processes. We offer a system that consolidates all customer data in one platform, helping you to grow your business and reach your goals faster.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 188,
    EntityName = "Service",
    EntityId = 5,
    Key = "DefaultContent",
    Value = "CRM ist entscheidend für den Aufbau starker, dauerhafter Beziehungen zu Ihren Kunden. Unsere CRM-Lösungen steigern die Kundenzufriedenheit und optimieren Ihre Verkaufs-, Marketing- und Serviceprozesse. Wir bieten ein System, das alle Kundendaten auf einer Plattform konsolidiert und Ihnen hilft, Ihr Geschäft auszubauen und Ihre Ziele schneller zu erreichen.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 189,
    EntityName = "Service",
    EntityId = 5,
    Key = "DefaultContent",
    Value = "CRM играет ключевую роль в построении прочных и долгосрочных отношений с клиентами. Наши CRM-решения повышают удовлетворенность клиентов и оптимизируют ваши процессы продаж, маркетинга и обслуживания. Мы предлагаем систему, которая объединяет все данные о клиентах на одной платформе, помогая вам развивать бизнес и быстрее достигать целей.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 190,
    EntityName = "Service",
    EntityId = 5,
    Key = "ServiceSummary",
    Value = "Comprehensive CRM solutions for managing customer relationships.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 191,
    EntityName = "Service",
    EntityId = 5,
    Key = "ServiceSummary",
    Value = "Umfassende CRM-Lösungen für das Kundenmanagement.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 192,
    EntityName = "Service",
    EntityId = 5,
    Key = "ServiceSummary",
    Value = "Комплексные CRM-решения для управления отношениями с клиентами.",
    LanguageId = 4 // Russian
},

// Service Id = 6 Translations
new Translation
{
    Id = 193,
    EntityName = "Service",
    EntityId = 6,
    Key = "DefaultTitle",
    Value = "ERP Solutions",
    LanguageId = 2 // English
},
new Translation
{
    Id = 194,
    EntityName = "Service",
    EntityId = 6,
    Key = "DefaultTitle",
    Value = "ERP-Lösungen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 195,
    EntityName = "Service",
    EntityId = 6,
    Key = "DefaultTitle",
    Value = "ERP-решения",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 196,
    EntityName = "Service",
    EntityId = 6,
    Key = "DefaultContent",
    Value = "Our ERP solutions help to digitize and streamline your business processes for greater efficiency. By integrating finance, HR, and supply chain functions in a single system, we enhance your operational workflow, reduce costs, and speed up decision-making. ERP is an ideal solution for sustainable growth.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 197,
    EntityName = "Service",
    EntityId = 6,
    Key = "DefaultContent",
    Value = "Unsere ERP-Lösungen helfen, Ihre Geschäftsprozesse für mehr Effizienz zu digitalisieren und zu optimieren. Durch die Integration von Finanz-, HR- und Lieferkettenfunktionen in einem einzigen System verbessern wir Ihren operativen Workflow, senken die Kosten und beschleunigen die Entscheidungsfindung. ERP ist eine ideale Lösung für nachhaltiges Wachstum.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 198,
    EntityName = "Service",
    EntityId = 6,
    Key = "DefaultContent",
    Value = "Наши ERP-решения помогают оцифровать и оптимизировать ваши бизнес-процессы для повышения эффективности. Интегрируя финансы, HR и цепочку поставок в одну систему, мы улучшаем рабочий процесс, сокращаем расходы и ускоряем принятие решений. ERP - это идеальное решение для устойчивого роста.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 199,
    EntityName = "Service",
    EntityId = 6,
    Key = "ServiceSummary",
    Value = "Efficient ERP solutions for sustainable business growth.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 200,
    EntityName = "Service",
    EntityId = 6,
    Key = "ServiceSummary",
    Value = "Effiziente ERP-Lösungen für nachhaltiges Unternehmenswachstum.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 201,
    EntityName = "Service",
    EntityId = 6,
    Key = "ServiceSummary",
    Value = "Эффективные ERP-решения для устойчивого роста бизнеса.",
    LanguageId = 4 // Russian
},
// Service Id = 7 Translations
new Translation
{
    Id = 202,
    EntityName = "Service",
    EntityId = 7,
    Key = "DefaultTitle",
    Value = "Database Management Systems",
    LanguageId = 2 // English
},
new Translation
{
    Id = 203,
    EntityName = "Service",
    EntityId = 7,
    Key = "DefaultTitle",
    Value = "Datenbankverwaltungssysteme",
    LanguageId = 3 // German
},
new Translation
{
    Id = 204,
    EntityName = "Service",
    EntityId = 7,
    Key = "DefaultTitle",
    Value = "Системы управления базами данных",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 205,
    EntityName = "Service",
    EntityId = 7,
    Key = "DefaultContent",
    Value = "Data security and accessibility are critical for every business. Our database management systems help you efficiently manage your data with secure, scalable solutions, ensuring performance optimization and continuous data availability.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 206,
    EntityName = "Service",
    EntityId = 7,
    Key = "DefaultContent",
    Value = "Datensicherheit und Zugänglichkeit sind für jedes Unternehmen von entscheidender Bedeutung. Unsere Datenbankverwaltungssysteme helfen Ihnen, Ihre Daten effizient mit sicheren, skalierbaren Lösungen zu verwalten, die Leistungsoptimierung und kontinuierliche Datenverfügbarkeit gewährleisten.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 207,
    EntityName = "Service",
    EntityId = 7,
    Key = "DefaultContent",
    Value = "Безопасность и доступность данных критически важны для любого бизнеса. Наши системы управления базами данных помогают эффективно управлять вашими данными с помощью безопасных, масштабируемых решений, обеспечивая оптимизацию производительности и непрерывную доступность данных.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 208,
    EntityName = "Service",
    EntityId = 7,
    Key = "ServiceSummary",
    Value = "Secure and scalable database solutions for effective data management.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 209,
    EntityName = "Service",
    EntityId = 7,
    Key = "ServiceSummary",
    Value = "Sichere und skalierbare Datenbanklösungen für ein effektives Datenmanagement.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 210,
    EntityName = "Service",
    EntityId = 7,
    Key = "ServiceSummary",
    Value = "Безопасные и масштабируемые решения для эффективного управления данными.",
    LanguageId = 4 // Russian
},

// Service Id = 8 Translations
new Translation
{
    Id = 211,
    EntityName = "Service",
    EntityId = 8,
    Key = "DefaultTitle",
    Value = "System Analysis and Design",
    LanguageId = 2 // English
},
new Translation
{
    Id = 212,
    EntityName = "Service",
    EntityId = 8,
    Key = "DefaultTitle",
    Value = "Systemanalyse und -design",
    LanguageId = 3 // German
},
new Translation
{
    Id = 213,
    EntityName = "Service",
    EntityId = 8,
    Key = "DefaultTitle",
    Value = "Анализ и проектирование систем",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 214,
    EntityName = "Service",
    EntityId = 8,
    Key = "DefaultContent",
    Value = "We conduct a comprehensive analysis to create systems tailored to your business needs. Our solutions prioritize performance, security, and scalability, supporting your digital transformation goals.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 215,
    EntityName = "Service",
    EntityId = 8,
    Key = "DefaultContent",
    Value = "Wir führen eine umfassende Analyse durch, um Systeme zu erstellen, die auf die Bedürfnisse Ihres Unternehmens zugeschnitten sind. Unsere Lösungen priorisieren Leistung, Sicherheit und Skalierbarkeit und unterstützen Ihre digitalen Transformationsziele.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 216,
    EntityName = "Service",
    EntityId = 8,
    Key = "DefaultContent",
    Value = "Мы проводим всесторонний анализ для создания систем, адаптированных к потребностям вашего бизнеса. Наши решения уделяют приоритетное внимание производительности, безопасности и масштабируемости, поддерживая цели вашей цифровой трансформации.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 217,
    EntityName = "Service",
    EntityId = 8,
    Key = "ServiceSummary",
    Value = "Customized system analysis and design for digital transformation.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 218,
    EntityName = "Service",
    EntityId = 8,
    Key = "ServiceSummary",
    Value = "Individuelle Systemanalyse und -design für die digitale Transformation.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 219,
    EntityName = "Service",
    EntityId = 8,
    Key = "ServiceSummary",
    Value = "Индивидуальный анализ и проектирование систем для цифровой трансформации.",
    LanguageId = 4 // Russian
},

// Service Id = 9 Translations
new Translation
{
    Id = 220,
    EntityName = "Service",
    EntityId = 9,
    Key = "DefaultTitle",
    Value = "Project Management",
    LanguageId = 2 // English
},
new Translation
{
    Id = 221,
    EntityName = "Service",
    EntityId = 9,
    Key = "DefaultTitle",
    Value = "Projektmanagement",
    LanguageId = 3 // German
},
new Translation
{
    Id = 222,
    EntityName = "Service",
    EntityId = 9,
    Key = "DefaultTitle",
    Value = "Управление проектами",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 223,
    EntityName = "Service",
    EntityId = 9,
    Key = "DefaultContent",
    Value = "Our project management solutions ensure effective use of resources and on-time delivery within budget, focusing on quality at every stage for successful project completion.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 224,
    EntityName = "Service",
    EntityId = 9,
    Key = "DefaultContent",
    Value = "Unsere Projektmanagementlösungen gewährleisten eine effektive Ressourcennutzung und pünktliche Lieferung innerhalb des Budgets, wobei in jeder Phase auf Qualität geachtet wird, um eine erfolgreiche Projektdurchführung sicherzustellen.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 225,
    EntityName = "Service",
    EntityId = 9,
    Key = "DefaultContent",
    Value = "Наши решения для управления проектами обеспечивают эффективное использование ресурсов и своевременную доставку в рамках бюджета, уделяя внимание качеству на каждом этапе для успешного завершения проекта.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 226,
    EntityName = "Service",
    EntityId = 9,
    Key = "ServiceSummary",
    Value = "Strategic project management solutions for quality delivery.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 227,
    EntityName = "Service",
    EntityId = 9,
    Key = "ServiceSummary",
    Value = "Strategische Projektmanagementlösungen für hochwertige Lieferung.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 228,
    EntityName = "Service",
    EntityId = 9,
    Key = "ServiceSummary",
    Value = "Стратегические решения для управления проектами с акцентом на качество.",
    LanguageId = 4 // Russian
},

// Service Id = 10 Translations
new Translation
{
    Id = 229,
    EntityName = "Service",
    EntityId = 10,
    Key = "DefaultTitle",
    Value = "Cloud Solutions",
    LanguageId = 2 // English
},
new Translation
{
    Id = 230,
    EntityName = "Service",
    EntityId = 10,
    Key = "DefaultTitle",
    Value = "Cloud-Lösungen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 231,
    EntityName = "Service",
    EntityId = 10,
    Key = "DefaultTitle",
    Value = "Облачные решения",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 232,
    EntityName = "Service",
    EntityId = 10,
    Key = "DefaultContent",
    Value = "We provide secure and scalable cloud solutions for data storage and management, offering flexibility and ease of access from anywhere while ensuring data security.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 233,
    EntityName = "Service",
    EntityId = 10,
    Key = "DefaultContent",
    Value = "Wir bieten sichere und skalierbare Cloud-Lösungen zur Datenspeicherung und -verwaltung und bieten Flexibilität und einfachen Zugriff von überall, während die Datensicherheit gewährleistet wird.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 234,
    EntityName = "Service",
    EntityId = 10,
    Key = "DefaultContent",
    Value = "Мы предоставляем безопасные и масштабируемые облачные решения для хранения и управления данными, обеспечивая гибкость и доступ из любого места при сохранении безопасности данных.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 235,
    EntityName = "Service",
    EntityId = 10,
    Key = "ServiceSummary",
    Value = "Flexible and secure cloud solutions for data management.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 236,
    EntityName = "Service",
    EntityId = 10,
    Key = "ServiceSummary",
    Value = "Flexible und sichere Cloud-Lösungen für das Datenmanagement.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 237,
    EntityName = "Service",
    EntityId = 10,
    Key = "ServiceSummary",
    Value = "Гибкие и безопасные облачные решения для управления данными.",
    LanguageId = 4 // Russian
},
// ServiceCategory Id = 1 Translations
new Translation
{
    Id = 238,
    EntityName = "ServiceCategory",
    EntityId = 1,
    Key = "Name",
    Value = "Web Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 239,
    EntityName = "ServiceCategory",
    EntityId = 1,
    Key = "Name",
    Value = "Webentwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 240,
    EntityName = "ServiceCategory",
    EntityId = 1,
    Key = "Name",
    Value = "Веб-разработка",
    LanguageId = 4 // Russian
},

// ServiceCategory Id = 2 Translations
new Translation
{
    Id = 241,
    EntityName = "ServiceCategory",
    EntityId = 2,
    Key = "Name",
    Value = "Mobile Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 242,
    EntityName = "ServiceCategory",
    EntityId = 2,
    Key = "Name",
    Value = "Mobile Entwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 243,
    EntityName = "ServiceCategory",
    EntityId = 2,
    Key = "Name",
    Value = "Разработка мобильных приложений",
    LanguageId = 4 // Russian
},

// ServiceCategory Id = 3 Translations
new Translation
{
    Id = 244,
    EntityName = "ServiceCategory",
    EntityId = 3,
    Key = "Name",
    Value = "Game Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 245,
    EntityName = "ServiceCategory",
    EntityId = 3,
    Key = "Name",
    Value = "Spieleentwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 246,
    EntityName = "ServiceCategory",
    EntityId = 3,
    Key = "Name",
    Value = "Разработка игр",
    LanguageId = 4 // Russian
},

// ServiceCategory Id = 4 Translations
new Translation
{
    Id = 247,
    EntityName = "ServiceCategory",
    EntityId = 4,
    Key = "Name",
    Value = "API Integration",
    LanguageId = 2 // English
},
new Translation
{
    Id = 248,
    EntityName = "ServiceCategory",
    EntityId = 4,
    Key = "Name",
    Value = "API-Integration",
    LanguageId = 3 // German
},
new Translation
{
    Id = 249,
    EntityName = "ServiceCategory",
    EntityId = 4,
    Key = "Name",
    Value = "Интеграция API",
    LanguageId = 4 // Russian
},

// ServiceCategory Id = 5 Translations
new Translation
{
    Id = 250,
    EntityName = "ServiceCategory",
    EntityId = 5,
    Key = "Name",
    Value = "CRM Solutions",
    LanguageId = 2 // English
},
new Translation
{
    Id = 251,
    EntityName = "ServiceCategory",
    EntityId = 5,
    Key = "Name",
    Value = "CRM-Lösungen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 252,
    EntityName = "ServiceCategory",
    EntityId = 5,
    Key = "Name",
    Value = "CRM-решения",
    LanguageId = 4 // Russian
},

// ServiceCategory Id = 6 Translations
new Translation
{
    Id = 253,
    EntityName = "ServiceCategory",
    EntityId = 6,
    Key = "Name",
    Value = "ERP Solutions",
    LanguageId = 2 // English
},
new Translation
{
    Id = 254,
    EntityName = "ServiceCategory",
    EntityId = 6,
    Key = "Name",
    Value = "ERP-Lösungen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 255,
    EntityName = "ServiceCategory",
    EntityId = 6,
    Key = "Name",
    Value = "ERP-решения",
    LanguageId = 4 // Russian
},

// ServiceCategory Id = 7 Translations
new Translation
{
    Id = 256,
    EntityName = "ServiceCategory",
    EntityId = 7,
    Key = "Name",
    Value = "Database Management",
    LanguageId = 2 // English
},
new Translation
{
    Id = 257,
    EntityName = "ServiceCategory",
    EntityId = 7,
    Key = "Name",
    Value = "Datenbankverwaltung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 258,
    EntityName = "ServiceCategory",
    EntityId = 7,
    Key = "Name",
    Value = "Управление базами данных",
    LanguageId = 4 // Russian
},

// ServiceCategory Id = 8 Translations
new Translation
{
    Id = 259,
    EntityName = "ServiceCategory",
    EntityId = 8,
    Key = "Name",
    Value = "System Analysis",
    LanguageId = 2 // English
},
new Translation
{
    Id = 260,
    EntityName = "ServiceCategory",
    EntityId = 8,
    Key = "Name",
    Value = "Systemanalyse",
    LanguageId = 3 // German
},
new Translation
{
    Id = 261,
    EntityName = "ServiceCategory",
    EntityId = 8,
    Key = "Name",
    Value = "Анализ систем",
    LanguageId = 4 // Russian
},

// ServiceCategory Id = 9 Translations
new Translation
{
    Id = 262,
    EntityName = "ServiceCategory",
    EntityId = 9,
    Key = "Name",
    Value = "Project Management",
    LanguageId = 2 // English
},
new Translation
{
    Id = 263,
    EntityName = "ServiceCategory",
    EntityId = 9,
    Key = "Name",
    Value = "Projektmanagement",
    LanguageId = 3 // German
},
new Translation
{
    Id = 264,
    EntityName = "ServiceCategory",
    EntityId = 9,
    Key = "Name",
    Value = "Управление проектами",
    LanguageId = 4 // Russian
},

// ServiceCategory Id = 10 Translations
new Translation
{
    Id = 265,
    EntityName = "ServiceCategory",
    EntityId = 10,
    Key = "Name",
    Value = "Cloud Solutions",
    LanguageId = 2 // English
},
new Translation
{
    Id = 266,
    EntityName = "ServiceCategory",
    EntityId = 10,
    Key = "Name",
    Value = "Cloud-Lösungen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 267,
    EntityName = "ServiceCategory",
    EntityId = 10,
    Key = "Name",
    Value = "Облачные решения",
    LanguageId = 4 // Russian
},
// BlogCategory Id = 1 Translations
new Translation
{
    Id = 268,
    EntityName = "BlogCategory",
    EntityId = 1,
    Key = "Name",
    Value = "Software",
    LanguageId = 2 // English
},
new Translation
{
    Id = 269,
    EntityName = "BlogCategory",
    EntityId = 1,
    Key = "Name",
    Value = "Software",
    LanguageId = 3 // German
},
new Translation
{
    Id = 270,
    EntityName = "BlogCategory",
    EntityId = 1,
    Key = "Name",
    Value = "Программное обеспечение",
    LanguageId = 4 // Russian
},

// BlogCategory Id = 2 Translations
new Translation
{
    Id = 271,
    EntityName = "BlogCategory",
    EntityId = 2,
    Key = "Name",
    Value = "Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 272,
    EntityName = "BlogCategory",
    EntityId = 2,
    Key = "Name",
    Value = "Entwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 273,
    EntityName = "BlogCategory",
    EntityId = 2,
    Key = "Name",
    Value = "Разработка",
    LanguageId = 4 // Russian
},

// BlogCategory Id = 3 Translations
new Translation
{
    Id = 274,
    EntityName = "BlogCategory",
    EntityId = 3,
    Key = "Name",
    Value = "Mobile Application",
    LanguageId = 2 // English
},
new Translation
{
    Id = 275,
    EntityName = "BlogCategory",
    EntityId = 3,
    Key = "Name",
    Value = "Mobile Anwendung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 276,
    EntityName = "BlogCategory",
    EntityId = 3,
    Key = "Name",
    Value = "Мобильное приложение",
    LanguageId = 4 // Russian
},

// BlogCategory Id = 4 Translations
new Translation
{
    Id = 277,
    EntityName = "BlogCategory",
    EntityId = 4,
    Key = "Name",
    Value = "API",
    LanguageId = 2 // English
},
new Translation
{
    Id = 278,
    EntityName = "BlogCategory",
    EntityId = 4,
    Key = "Name",
    Value = "API",
    LanguageId = 3 // German
},
new Translation
{
    Id = 279,
    EntityName = "BlogCategory",
    EntityId = 4,
    Key = "Name",
    Value = "API",
    LanguageId = 4 // Russian
},

// BlogCategory Id = 5 Translations
new Translation
{
    Id = 280,
    EntityName = "BlogCategory",
    EntityId = 5,
    Key = "Name",
    Value = "Data Security",
    LanguageId = 2 // English
},
new Translation
{
    Id = 281,
    EntityName = "BlogCategory",
    EntityId = 5,
    Key = "Name",
    Value = "Datensicherheit",
    LanguageId = 3 // German
},
new Translation
{
    Id = 282,
    EntityName = "BlogCategory",
    EntityId = 5,
    Key = "Name",
    Value = "Безопасность данных",
    LanguageId = 4 // Russian
},

// BlogCategory Id = 6 Translations
new Translation
{
    Id = 283,
    EntityName = "BlogCategory",
    EntityId = 6,
    Key = "Name",
    Value = "ERP",
    LanguageId = 2 // English
},
new Translation
{
    Id = 284,
    EntityName = "BlogCategory",
    EntityId = 6,
    Key = "Name",
    Value = "ERP",
    LanguageId = 3 // German
},
new Translation
{
    Id = 285,
    EntityName = "BlogCategory",
    EntityId = 6,
    Key = "Name",
    Value = "ERP",
    LanguageId = 4 // Russian
},

// BlogCategory Id = 7 Translations
new Translation
{
    Id = 286,
    EntityName = "BlogCategory",
    EntityId = 7,
    Key = "Name",
    Value = "Business Management",
    LanguageId = 2 // English
},
new Translation
{
    Id = 287,
    EntityName = "BlogCategory",
    EntityId = 7,
    Key = "Name",
    Value = "Geschäftsführung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 288,
    EntityName = "BlogCategory",
    EntityId = 7,
    Key = "Name",
    Value = "Управление бизнесом",
    LanguageId = 4 // Russian
},

// BlogCategory Id = 8 Translations
new Translation
{
    Id = 289,
    EntityName = "BlogCategory",
    EntityId = 8,
    Key = "Name",
    Value = "Game Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 290,
    EntityName = "BlogCategory",
    EntityId = 8,
    Key = "Name",
    Value = "Spieleentwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 291,
    EntityName = "BlogCategory",
    EntityId = 8,
    Key = "Name",
    Value = "Разработка игр",
    LanguageId = 4 // Russian
},

// BlogCategory Id = 9 Translations
new Translation
{
    Id = 292,
    EntityName = "BlogCategory",
    EntityId = 9,
    Key = "Name",
    Value = "Technology",
    LanguageId = 2 // English
},
new Translation
{
    Id = 293,
    EntityName = "BlogCategory",
    EntityId = 9,
    Key = "Name",
    Value = "Technologie",
    LanguageId = 3 // German
},
new Translation
{
    Id = 294,
    EntityName = "BlogCategory",
    EntityId = 9,
    Key = "Name",
    Value = "Технология",
    LanguageId = 4 // Russian
},

// BlogCategory Id = 10 Translations
new Translation
{
    Id = 295,
    EntityName = "BlogCategory",
    EntityId = 10,
    Key = "Name",
    Value = "Web Development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 296,
    EntityName = "BlogCategory",
    EntityId = 10,
    Key = "Name",
    Value = "Webentwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 297,
    EntityName = "BlogCategory",
    EntityId = 10,
    Key = "Name",
    Value = "Веб-разработка",
    LanguageId = 4 // Russian
},

// BlogCategory Id = 11 Translations
new Translation
{
    Id = 298,
    EntityName = "BlogCategory",
    EntityId = 11,
    Key = "Name",
    Value = "PWA",
    LanguageId = 2 // English
},
new Translation
{
    Id = 299,
    EntityName = "BlogCategory",
    EntityId = 11,
    Key = "Name",
    Value = "PWA",
    LanguageId = 3 // German
},
new Translation
{
    Id = 300,
    EntityName = "BlogCategory",
    EntityId = 11,
    Key = "Name",
    Value = "PWA",
    LanguageId = 4 // Russian
},
// Highlight Id = 1 Translations
new Translation
{
    Id = 301,
    EntityName = "Highlight",
    EntityId = 1,
    Key = "Content",
    Value = "Modern and user-friendly web solutions",
    LanguageId = 2 // English
},
new Translation
{
    Id = 302,
    EntityName = "Highlight",
    EntityId = 1,
    Key = "Content",
    Value = "Moderne und benutzerfreundliche Weblösungen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 303,
    EntityName = "Highlight",
    EntityId = 1,
    Key = "Content",
    Value = "Современные и удобные веб-решения",
    LanguageId = 4 // Russian
},

// Highlight Id = 2 Translations
new Translation
{
    Id = 304,
    EntityName = "Highlight",
    EntityId = 2,
    Key = "Content",
    Value = "SEO-compliant web development",
    LanguageId = 2 // English
},
new Translation
{
    Id = 305,
    EntityName = "Highlight",
    EntityId = 2,
    Key = "Content",
    Value = "SEO-konforme Webentwicklung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 306,
    EntityName = "Highlight",
    EntityId = 2,
    Key = "Content",
    Value = "Веб-разработка, соответствующая требованиям SEO",
    LanguageId = 4 // Russian
},

// Highlight Id = 3 Translations
new Translation
{
    Id = 307,
    EntityName = "Highlight",
    EntityId = 3,
    Key = "Content",
    Value = "High-performance and security-focused",
    LanguageId = 2 // English
},
new Translation
{
    Id = 308,
    EntityName = "Highlight",
    EntityId = 3,
    Key = "Content",
    Value = "Leistungsstark und sicherheitsorientiert",
    LanguageId = 3 // German
},
new Translation
{
    Id = 309,
    EntityName = "Highlight",
    EntityId = 3,
    Key = "Content",
    Value = "Ориентированность на высокую производительность и безопасность",
    LanguageId = 4 // Russian
},

// Highlight Id = 4 Translations
new Translation
{
    Id = 310,
    EntityName = "Highlight",
    EntityId = 4,
    Key = "Content",
    Value = "Development for iOS and Android platforms",
    LanguageId = 2 // English
},
new Translation
{
    Id = 311,
    EntityName = "Highlight",
    EntityId = 4,
    Key = "Content",
    Value = "Entwicklung für iOS- und Android-Plattformen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 312,
    EntityName = "Highlight",
    EntityId = 4,
    Key = "Content",
    Value = "Разработка для платформ iOS и Android",
    LanguageId = 4 // Russian
},

// Highlight Id = 5 Translations
new Translation
{
    Id = 313,
    EntityName = "Highlight",
    EntityId = 5,
    Key = "Content",
    Value = "User-friendly and interactive design",
    LanguageId = 2 // English
},
new Translation
{
    Id = 314,
    EntityName = "Highlight",
    EntityId = 5,
    Key = "Content",
    Value = "Benutzerfreundliches und interaktives Design",
    LanguageId = 3 // German
},
new Translation
{
    Id = 315,
    EntityName = "Highlight",
    EntityId = 5,
    Key = "Content",
    Value = "Удобный и интерактивный дизайн",
    LanguageId = 4 // Russian
},

// Highlight Id = 6 Translations
new Translation
{
    Id = 316,
    EntityName = "Highlight",
    EntityId = 6,
    Key = "Content",
    Value = "Easily updatable and scalable structure",
    LanguageId = 2 // English
},
new Translation
{
    Id = 317,
    EntityName = "Highlight",
    EntityId = 6,
    Key = "Content",
    Value = "Leicht aktualisierbare und skalierbare Struktur",
    LanguageId = 3 // German
},
new Translation
{
    Id = 318,
    EntityName = "Highlight",
    EntityId = 6,
    Key = "Content",
    Value = "Легко обновляемая и масштабируемая структура",
    LanguageId = 4 // Russian
},

// Highlight Id = 7 Translations
new Translation
{
    Id = 319,
    EntityName = "Highlight",
    EntityId = 7,
    Key = "Content",
    Value = "Fun and high-performance games",
    LanguageId = 2 // English
},
new Translation
{
    Id = 320,
    EntityName = "Highlight",
    EntityId = 7,
    Key = "Content",
    Value = "Spaßige und leistungsstarke Spiele",
    LanguageId = 3 // German
},
new Translation
{
    Id = 321,
    EntityName = "Highlight",
    EntityId = 7,
    Key = "Content",
    Value = "Веселые и высокопроизводительные игры",
    LanguageId = 4 // Russian
},

// Highlight Id = 8 Translations
new Translation
{
    Id = 322,
    EntityName = "Highlight",
    EntityId = 8,
    Key = "Content",
    Value = "Development with tools like Unity and Unreal Engine",
    LanguageId = 2 // English
},
new Translation
{
    Id = 323,
    EntityName = "Highlight",
    EntityId = 8,
    Key = "Content",
    Value = "Entwicklung mit Werkzeugen wie Unity und Unreal Engine",
    LanguageId = 3 // German
},
new Translation
{
    Id = 324,
    EntityName = "Highlight",
    EntityId = 8,
    Key = "Content",
    Value = "Разработка с использованием Unity и Unreal Engine",
    LanguageId = 4 // Russian
},

// Highlight Id = 9 Translations
new Translation
{
    Id = 325,
    EntityName = "Highlight",
    EntityId = 9,
    Key = "Content",
    Value = "Game design ensuring replayability",
    LanguageId = 2 // English
},
new Translation
{
    Id = 326,
    EntityName = "Highlight",
    EntityId = 9,
    Key = "Content",
    Value = "Spieldesign, das die Wiederspielbarkeit sicherstellt",
    LanguageId = 3 // German
},
new Translation
{
    Id = 327,
    EntityName = "Highlight",
    EntityId = 9,
    Key = "Content",
    Value = "Дизайн игры, обеспечивающий повторное прохождение",
    LanguageId = 4 // Russian
},

// Highlight Id = 10 Translations
new Translation
{
    Id = 328,
    EntityName = "Highlight",
    EntityId = 10,
    Key = "Content",
    Value = "Efficient and secure data flow",
    LanguageId = 2 // English
},
new Translation
{
    Id = 329,
    EntityName = "Highlight",
    EntityId = 10,
    Key = "Content",
    Value = "Effizienter und sicherer Datenfluss",
    LanguageId = 3 // German
},
new Translation
{
    Id = 330,
    EntityName = "Highlight",
    EntityId = 10,
    Key = "Content",
    Value = "Эффективный и безопасный поток данных",
    LanguageId = 4 // Russian
},
// Highlight Id = 11 Translations
new Translation
{
    Id = 331,
    EntityName = "Highlight",
    EntityId = 11,
    Key = "Content",
    Value = "Compatibility across different systems",
    LanguageId = 2 // English
},
new Translation
{
    Id = 332,
    EntityName = "Highlight",
    EntityId = 11,
    Key = "Content",
    Value = "Kompatibilität zwischen verschiedenen Systemen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 333,
    EntityName = "Highlight",
    EntityId = 11,
    Key = "Content",
    Value = "Совместимость между различными системами",
    LanguageId = 4 // Russian
},

// Highlight Id = 12 Translations
new Translation
{
    Id = 334,
    EntityName = "Highlight",
    EntityId = 12,
    Key = "Content",
    Value = "Security-focused integration",
    LanguageId = 2 // English
},
new Translation
{
    Id = 335,
    EntityName = "Highlight",
    EntityId = 12,
    Key = "Content",
    Value = "Sicherheitsorientierte Integration",
    LanguageId = 3 // German
},
new Translation
{
    Id = 336,
    EntityName = "Highlight",
    EntityId = 12,
    Key = "Content",
    Value = "Интеграция с фокусом на безопасность",
    LanguageId = 4 // Russian
},

// Highlight Id = 13 Translations
new Translation
{
    Id = 337,
    EntityName = "Highlight",
    EntityId = 13,
    Key = "Content",
    Value = "Solutions that strengthen customer relationships",
    LanguageId = 2 // English
},
new Translation
{
    Id = 338,
    EntityName = "Highlight",
    EntityId = 13,
    Key = "Content",
    Value = "Lösungen, die Kundenbeziehungen stärken",
    LanguageId = 3 // German
},
new Translation
{
    Id = 339,
    EntityName = "Highlight",
    EntityId = 13,
    Key = "Content",
    Value = "Решения для укрепления отношений с клиентами",
    LanguageId = 4 // Russian
},

// Highlight Id = 14 Translations
new Translation
{
    Id = 340,
    EntityName = "Highlight",
    EntityId = 14,
    Key = "Content",
    Value = "Optimization of sales, marketing, and services",
    LanguageId = 2 // English
},
new Translation
{
    Id = 341,
    EntityName = "Highlight",
    EntityId = 14,
    Key = "Content",
    Value = "Optimierung von Vertrieb, Marketing und Dienstleistungen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 342,
    EntityName = "Highlight",
    EntityId = 14,
    Key = "Content",
    Value = "Оптимизация продаж, маркетинга и услуг",
    LanguageId = 4 // Russian
},

// Highlight Id = 15 Translations
new Translation
{
    Id = 343,
    EntityName = "Highlight",
    EntityId = 15,
    Key = "Content",
    Value = "Analysis of all customer data",
    LanguageId = 2 // English
},
new Translation
{
    Id = 344,
    EntityName = "Highlight",
    EntityId = 15,
    Key = "Content",
    Value = "Analyse aller Kundendaten",
    LanguageId = 3 // German
},
new Translation
{
    Id = 345,
    EntityName = "Highlight",
    EntityId = 15,
    Key = "Content",
    Value = "Анализ всех данных о клиентах",
    LanguageId = 4 // Russian
},

// Highlight Id = 16 Translations
new Translation
{
    Id = 346,
    EntityName = "Highlight",
    EntityId = 16,
    Key = "Content",
    Value = "Inter-departmental data integration",
    LanguageId = 2 // English
},
new Translation
{
    Id = 347,
    EntityName = "Highlight",
    EntityId = 16,
    Key = "Content",
    Value = "Abteilungsübergreifende Datenintegration",
    LanguageId = 3 // German
},
new Translation
{
    Id = 348,
    EntityName = "Highlight",
    EntityId = 16,
    Key = "Content",
    Value = "Интеграция данных между отделами",
    LanguageId = 4 // Russian
},

// Highlight Id = 17 Translations
new Translation
{
    Id = 349,
    EntityName = "Highlight",
    EntityId = 17,
    Key = "Content",
    Value = "Structure optimizing business processes",
    LanguageId = 2 // English
},
new Translation
{
    Id = 350,
    EntityName = "Highlight",
    EntityId = 17,
    Key = "Content",
    Value = "Struktur zur Optimierung von Geschäftsprozessen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 351,
    EntityName = "Highlight",
    EntityId = 17,
    Key = "Content",
    Value = "Структура, оптимизирующая бизнес-процессы",
    LanguageId = 4 // Russian
},

// Highlight Id = 18 Translations
new Translation
{
    Id = 352,
    EntityName = "Highlight",
    EntityId = 18,
    Key = "Content",
    Value = "Accelerating decision-making processes",
    LanguageId = 2 // English
},
new Translation
{
    Id = 353,
    EntityName = "Highlight",
    EntityId = 18,
    Key = "Content",
    Value = "Beschleunigung von Entscheidungsprozessen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 354,
    EntityName = "Highlight",
    EntityId = 18,
    Key = "Content",
    Value = "Ускорение процесса принятия решений",
    LanguageId = 4 // Russian
},

// Highlight Id = 19 Translations
new Translation
{
    Id = 355,
    EntityName = "Highlight",
    EntityId = 19,
    Key = "Content",
    Value = "Robust and secure database infrastructure",
    LanguageId = 2 // English
},
new Translation
{
    Id = 356,
    EntityName = "Highlight",
    EntityId = 19,
    Key = "Content",
    Value = "Robuste und sichere Datenbankinfrastruktur",
    LanguageId = 3 // German
},
new Translation
{
    Id = 357,
    EntityName = "Highlight",
    EntityId = 19,
    Key = "Content",
    Value = "Надежная и безопасная инфраструктура базы данных",
    LanguageId = 4 // Russian
},

// Highlight Id = 20 Translations
new Translation
{
    Id = 358,
    EntityName = "Highlight",
    EntityId = 20,
    Key = "Content",
    Value = "Optimized for high performance",
    LanguageId = 2 // English
},
new Translation
{
    Id = 359,
    EntityName = "Highlight",
    EntityId = 20,
    Key = "Content",
    Value = "Optimiert für hohe Leistung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 360,
    EntityName = "Highlight",
    EntityId = 20,
    Key = "Content",
    Value = "Оптимизировано для высокой производительности",
    LanguageId = 4 // Russian
},
// Highlight Id = 21 Translations
new Translation
{
    Id = 361,
    EntityName = "Highlight",
    EntityId = 21,
    Key = "Content",
    Value = "Continuous accessibility of data",
    LanguageId = 2 // English
},
new Translation
{
    Id = 362,
    EntityName = "Highlight",
    EntityId = 21,
    Key = "Content",
    Value = "Kontinuierliche Datenzugänglichkeit",
    LanguageId = 3 // German
},
new Translation
{
    Id = 363,
    EntityName = "Highlight",
    EntityId = 21,
    Key = "Content",
    Value = "Непрерывная доступность данных",
    LanguageId = 4 // Russian
},

// Highlight Id = 22 Translations
new Translation
{
    Id = 364,
    EntityName = "Highlight",
    EntityId = 22,
    Key = "Content",
    Value = "Custom design tailored to business processes",
    LanguageId = 2 // English
},
new Translation
{
    Id = 365,
    EntityName = "Highlight",
    EntityId = 22,
    Key = "Content",
    Value = "Maßgeschneidertes Design für Geschäftsprozesse",
    LanguageId = 3 // German
},
new Translation
{
    Id = 366,
    EntityName = "Highlight",
    EntityId = 22,
    Key = "Content",
    Value = "Индивидуальный дизайн, адаптированный к бизнес-процессам",
    LanguageId = 4 // Russian
},

// Highlight Id = 23 Translations
new Translation
{
    Id = 367,
    EntityName = "Highlight",
    EntityId = 23,
    Key = "Content",
    Value = "Comprehensive analysis and performance optimization",
    LanguageId = 2 // English
},
new Translation
{
    Id = 368,
    EntityName = "Highlight",
    EntityId = 23,
    Key = "Content",
    Value = "Umfassende Analyse und Leistungsoptimierung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 369,
    EntityName = "Highlight",
    EntityId = 23,
    Key = "Content",
    Value = "Комплексный анализ и оптимизация производительности",
    LanguageId = 4 // Russian
},

// Highlight Id = 24 Translations
new Translation
{
    Id = 370,
    EntityName = "Highlight",
    EntityId = 24,
    Key = "Content",
    Value = "Scalable and reliable solutions",
    LanguageId = 2 // English
},
new Translation
{
    Id = 371,
    EntityName = "Highlight",
    EntityId = 24,
    Key = "Content",
    Value = "Skalierbare und zuverlässige Lösungen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 372,
    EntityName = "Highlight",
    EntityId = 24,
    Key = "Content",
    Value = "Масштабируемые и надежные решения",
    LanguageId = 4 // Russian
},

// Highlight Id = 25 Translations
new Translation
{
    Id = 373,
    EntityName = "Highlight",
    EntityId = 25,
    Key = "Content",
    Value = "Strategic management solutions for projects",
    LanguageId = 2 // English
},
new Translation
{
    Id = 374,
    EntityName = "Highlight",
    EntityId = 25,
    Key = "Content",
    Value = "Strategische Managementlösungen für Projekte",
    LanguageId = 3 // German
},
new Translation
{
    Id = 375,
    EntityName = "Highlight",
    EntityId = 25,
    Key = "Content",
    Value = "Стратегические решения для управления проектами",
    LanguageId = 4 // Russian
},

// Highlight Id = 26 Translations
new Translation
{
    Id = 376,
    EntityName = "Highlight",
    EntityId = 26,
    Key = "Content",
    Value = "Timely and on-budget delivery",
    LanguageId = 2 // English
},
new Translation
{
    Id = 377,
    EntityName = "Highlight",
    EntityId = 26,
    Key = "Content",
    Value = "Rechtzeitige und budgetgerechte Lieferung",
    LanguageId = 3 // German
},
new Translation
{
    Id = 378,
    EntityName = "Highlight",
    EntityId = 26,
    Key = "Content",
    Value = "Своевременная доставка в рамках бюджета",
    LanguageId = 4 // Russian
},

// Highlight Id = 27 Translations
new Translation
{
    Id = 379,
    EntityName = "Highlight",
    EntityId = 27,
    Key = "Content",
    Value = "Management with a focus on quality",
    LanguageId = 2 // English
},
new Translation
{
    Id = 380,
    EntityName = "Highlight",
    EntityId = 27,
    Key = "Content",
    Value = "Management mit Fokus auf Qualität",
    LanguageId = 3 // German
},
new Translation
{
    Id = 381,
    EntityName = "Highlight",
    EntityId = 27,
    Key = "Content",
    Value = "Управление с акцентом на качество",
    LanguageId = 4 // Russian
},

// Highlight Id = 28 Translations
new Translation
{
    Id = 382,
    EntityName = "Highlight",
    EntityId = 28,
    Key = "Content",
    Value = "Secure and flexible cloud infrastructure",
    LanguageId = 2 // English
},
new Translation
{
    Id = 383,
    EntityName = "Highlight",
    EntityId = 28,
    Key = "Content",
    Value = "Sichere und flexible Cloud-Infrastruktur",
    LanguageId = 3 // German
},
new Translation
{
    Id = 384,
    EntityName = "Highlight",
    EntityId = 28,
    Key = "Content",
    Value = "Безопасная и гибкая облачная инфраструктура",
    LanguageId = 4 // Russian
},

// Highlight Id = 29 Translations
new Translation
{
    Id = 385,
    EntityName = "Highlight",
    EntityId = 29,
    Key = "Content",
    Value = "Access from anywhere with data security",
    LanguageId = 2 // English
},
new Translation
{
    Id = 386,
    EntityName = "Highlight",
    EntityId = 29,
    Key = "Content",
    Value = "Zugang von überall mit Datensicherheit",
    LanguageId = 3 // German
},
new Translation
{
    Id = 387,
    EntityName = "Highlight",
    EntityId = 29,
    Key = "Content",
    Value = "Доступ отовсюду с безопасностью данных",
    LanguageId = 4 // Russian
},

// Highlight Id = 30 Translations
new Translation
{
    Id = 388,
    EntityName = "Highlight",
    EntityId = 30,
    Key = "Content",
    Value = "Scalable solutions to lighten workload",
    LanguageId = 2 // English
},
new Translation
{
    Id = 389,
    EntityName = "Highlight",
    EntityId = 30,
    Key = "Content",
    Value = "Skalierbare Lösungen zur Entlastung der Arbeitslast",
    LanguageId = 3 // German
},
new Translation
{
    Id = 390,
    EntityName = "Highlight",
    EntityId = 30,
    Key = "Content",
    Value = "Масштабируемые решения для уменьшения рабочей нагрузки",
    LanguageId = 4 // Russian
},

                //History Id = 4 Translations
                new Translation
                {
                    Id = 391,
                    EntityName = "History",
                    EntityId = 4,
                    Key = "YearDescription",
                    Value = "The Şantiye Bul project is an innovative initiative aimed at connecting small and medium-sized enterprises (SMEs) with large construction sites and projects. This project seeks to maximize the efficiency of state control mechanisms, support the development of SMEs, and ensure the construction of safer and higher quality buildings nationwide. Through Şantiye Bul, it is possible to reduce earthquake risks, prevent illegal construction, minimize the risks associated with cheap labor, and control the use of low-quality materials. As a result, industry standards will improve, and more solid, reliable, and sustainable buildings will be established across the country. This initiative is an important step towards enhancing quality and safety in Turkey's construction sector.",
                    LanguageId = 2 // English
                },
new Translation
{
    Id = 392,
    EntityName = "History",
    EntityId = 4,
    Key = "YearDescription",
    Value = "Das Projekt Şantiye Bul ist eine innovative Initiative, die darauf abzielt, kleine und mittlere Unternehmen (KMU) mit großen Baustellen und Bauprojekten zu verbinden. Dieses Projekt strebt an, die Effizienz der staatlichen Kontrollmechanismen zu maximieren, die Entwicklung von KMU zu unterstützen und den Bau sichererer und hochwertigerer Gebäude im ganzen Land zu gewährleisten. Durch Şantiye Bul wird es möglich, Erdbebenrisiken zu verringern, illegale Bebauung zu verhindern, die mit billiger Arbeit verbundenen Risiken zu minimieren und die Verwendung minderwertiger Materialien zu kontrollieren. Dadurch werden die Branchenstandards verbessert, und es entstehen landesweit solidere, zuverlässigere und nachhaltigere Gebäude. Diese Initiative ist ein wichtiger Schritt zur Verbesserung der Qualität und Sicherheit im türkischen Bausektor.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 393,
    EntityName = "History",
    EntityId = 4,
    Key = "YearDescription",
    Value = "Проект Şantiye Bul — это инновационная инициатива, направленная на объединение малых и средних предприятий (МСП) с крупными строительными объектами и проектами. Этот проект направлен на максимальное повышение эффективности государственных контрольных механизмов, поддержку развития МСП и обеспечение строительства более безопасных и качественных зданий по всей стране. Благодаря Şantiye Bul станет возможным уменьшение рисков землетрясений, предотвращение незаконного строительства, минимизация рисков, связанных с дешевой рабочей силой, и контроль за использованием некачественных материалов. В результате стандарты в отрасли будут улучшены, и по всей стране появятся более прочные, надежные и устойчивые здания. Эта инициатива является важным шагом к повышению качества и безопасности в строительной отрасли Турции.",
    LanguageId = 4 // Russian
},
// DefaultTitle Translations
new Translation
{
    Id = 394,
    EntityName = "History",
    EntityId = 4,
    Key = "DefaultTitle",
    Value = "Our Company History",
    LanguageId = 2 // English
},
new Translation
{
    Id = 395,
    EntityName = "History",
    EntityId = 4,
    Key = "DefaultTitle",
    Value = "Die Geschichte unseres Unternehmens",
    LanguageId = 3 // German
},
new Translation
{
    Id = 396,
    EntityName = "History",
    EntityId = 4,
    Key = "DefaultTitle",
    Value = "История нашей компании",
    LanguageId = 4 // Russian
},

// DefaultContent Translations
new Translation
{
    Id = 397,
    EntityName = "History",
    EntityId = 4,
    Key = "DefaultContent",
    Value = "Discover details about our growth, vision, and projects at TechLiberty since our foundation.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 398,
    EntityName = "History",
    EntityId = 4,
    Key = "DefaultContent",
    Value = "Entdecken Sie Details über unser Wachstum, unsere Vision und Projekte bei TechLiberty seit unserer Gründung.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 399,
    EntityName = "History",
    EntityId = 4,
    Key = "DefaultContent",
    Value = "Узнайте подробнее о нашем росте, видении и проектах в TechLiberty с момента основания.",
    LanguageId = 4 // Russian
},
                //Translations for NavbarItem
                new Translation { Id = 400, EntityName = "NavbarItem", EntityId = 1, Key = "Name", Value = "Home", LanguageId = 2 },
    new Translation { Id = 401, EntityName = "NavbarItem", EntityId = 1, Key = "Name", Value = "Startseite", LanguageId = 3 },
    new Translation { Id = 402, EntityName = "NavbarItem", EntityId = 1, Key = "Name", Value = "Главная", LanguageId = 4 },

    new Translation { Id = 403, EntityName = "NavbarItem", EntityId = 2, Key = "Name", Value = "About Us", LanguageId = 2 },
    new Translation { Id = 404, EntityName = "NavbarItem", EntityId = 2, Key = "Name", Value = "Über uns", LanguageId = 3 },
    new Translation { Id = 405, EntityName = "NavbarItem", EntityId = 2, Key = "Name", Value = "О нас", LanguageId = 4 },

    new Translation { Id = 406, EntityName = "NavbarItem", EntityId = 3, Key = "Name", Value = "Services", LanguageId = 2 },
    new Translation { Id = 407, EntityName = "NavbarItem", EntityId = 3, Key = "Name", Value = "Dienstleistungen", LanguageId = 3 },
    new Translation { Id = 408, EntityName = "NavbarItem", EntityId = 3, Key = "Name", Value = "Услуги", LanguageId = 4 },

    new Translation { Id = 409, EntityName = "NavbarItem", EntityId = 4, Key = "Name", Value = "Blog", LanguageId = 2 },
    new Translation { Id = 410, EntityName = "NavbarItem", EntityId = 4, Key = "Name", Value = "Blog", LanguageId = 3 },
    new Translation { Id = 411, EntityName = "NavbarItem", EntityId = 4, Key = "Name", Value = "Блог", LanguageId = 4 },

    new Translation { Id = 412, EntityName = "NavbarItem", EntityId = 5, Key = "Name", Value = "ContactForm", LanguageId = 2 },
    new Translation { Id = 413, EntityName = "NavbarItem", EntityId = 5, Key = "Name", Value = "Kontakt", LanguageId = 3 },
    new Translation { Id = 414, EntityName = "NavbarItem", EntityId = 5, Key = "Name", Value = "Контакт", LanguageId = 4 },

    new Translation { Id = 415, EntityName = "NavbarItem", EntityId = 6, Key = "Name", Value = "FAQ", LanguageId = 2 },
    new Translation { Id = 416, EntityName = "NavbarItem", EntityId = 6, Key = "Name", Value = "FAQ", LanguageId = 3 },
    new Translation { Id = 417, EntityName = "NavbarItem", EntityId = 6, Key = "Name", Value = "Вопросы и ответы", LanguageId = 4 },
    new Translation
    {
        Id = 418,
        EntityName = "CompanyInfo",
        EntityId = 1,
        Key = "WorkingHours",
        Value = "Monday - Friday: 9:00 AM - 6:00 PM",
        LanguageId = 2 // English
    },
    new Translation
    {
        Id = 419,
        EntityName = "CompanyInfo",
        EntityId = 1,
        Key = "WorkingHours",
        Value = "Montag - Freitag: 9:00 - 18:00 Uhr",
        LanguageId = 3 // German
    },
    new Translation
    {
        Id = 420,
        EntityName = "CompanyInfo",
        EntityId = 1,
        Key = "WorkingHours",
        Value = "Понедельник - Пятница: 9:00 - 18:00",
        LanguageId = 4 // Russian
    },
                new Translation
                {
                    Id = 421,
                    EntityName = "ContactForm",
                    EntityId = 1,
                    Key = "FullNamePlaceholder",
                    Value = "Your Full Name",
                    LanguageId = 2 // English
                },
new Translation
{
    Id = 422,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "FullNamePlaceholder",
    Value = "Ihr vollständiger Name",
    LanguageId = 3 // German
},
new Translation
{
    Id = 423,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "FullNamePlaceholder",
    Value = "Ваше полное имя",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 424,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "EmailPlaceholder",
    Value = "Your Email Address",
    LanguageId = 2 // English
},
new Translation
{
    Id = 425,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "EmailPlaceholder",
    Value = "Ihre E-Mail-Adresse",
    LanguageId = 3 // German
},
new Translation
{
    Id = 426,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "EmailPlaceholder",
    Value = "Ваш адрес электронной почты",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 427,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "PhonePlaceholder",
    Value = "Your Phone Number",
    LanguageId = 2 // English
},
new Translation
{
    Id = 428,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "PhonePlaceholder",
    Value = "Ihre Telefonnummer",
    LanguageId = 3 // German
},
new Translation
{
    Id = 429,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "PhonePlaceholder",
    Value = "Ваш номер телефона",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 430,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "SubjectPlaceholder",
    Value = "Subject",
    LanguageId = 2 // English
},
new Translation
{
    Id = 431,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "SubjectPlaceholder",
    Value = "Betreff",
    LanguageId = 3 // German
},
new Translation
{
    Id = 432,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "SubjectPlaceholder",
    Value = "Тема",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 433,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "MessagePlaceholder",
    Value = "Your Message",
    LanguageId = 2 // English
},
new Translation
{
    Id = 434,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "MessagePlaceholder",
    Value = "Ihre Nachricht",
    LanguageId = 3 // German
},
new Translation
{
    Id = 435,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "MessagePlaceholder",
    Value = "Ваше сообщение",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 436,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "SendButton",
    Value = "Send Message",
    LanguageId = 2 // English
},
new Translation
{
    Id = 437,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "SendButton",
    Value = "Nachricht senden",
    LanguageId = 3 // German
},
new Translation
{
    Id = 438,
    EntityName = "ContactForm",
    EntityId = 1,
    Key = "SendButton",
    Value = "Отправить сообщение",
    LanguageId = 4 // Russian
},

//Footer Translations
// English Translations
new Translation
{
    Id = 439,
    EntityName = "Footer",
    EntityId = 1,
    Key = "CompanyInfoTitle",
    Value = "Where Can You Find Us?",
    LanguageId = 2 // English
},
new Translation
{
    Id = 440,
    EntityName = "Footer",
    EntityId = 1,
    Key = "NewsletterTitle",
    Value = "Subscribe to Our Newsletter",
    LanguageId = 2 // English
},
new Translation
{
    Id = 441,
    EntityName = "Footer",
    EntityId = 1,
    Key = "NewsletterPlaceholder",
    Value = "Enter your email address",
    LanguageId = 2 // English
},
new Translation
{
    Id = 442,
    EntityName = "Footer",
    EntityId = 1,
    Key = "QuickLinksTitle",
    Value = "Quick Links",
    LanguageId = 2 // English
},

// German Translations
new Translation
{
    Id = 443,
    EntityName = "Footer",
    EntityId = 1,
    Key = "CompanyInfoTitle",
    Value = "Wo Sie uns finden können?",
    LanguageId = 3 // German
},
new Translation
{
    Id = 444,
    EntityName = "Footer",
    EntityId = 1,
    Key = "NewsletterTitle",
    Value = "Abonnieren Sie unseren Newsletter",
    LanguageId = 3 // German
},
new Translation
{
    Id = 445,
    EntityName = "Footer",
    EntityId = 1,
    Key = "NewsletterPlaceholder",
    Value = "Geben Sie Ihre E-Mail-Adresse ein",
    LanguageId = 3 // German
},
new Translation
{
    Id = 446,
    EntityName = "Footer",
    EntityId = 1,
    Key = "QuickLinksTitle",
    Value = "Schnellzugriff",
    LanguageId = 3 // German
},

// Russian Translations
new Translation
{
    Id = 447,
    EntityName = "Footer",
    EntityId = 1,
    Key = "CompanyInfoTitle",
    Value = "Где нас найти?",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 448,
    EntityName = "Footer",
    EntityId = 1,
    Key = "NewsletterTitle",
    Value = "Подписаться на нашу рассылку",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 449,
    EntityName = "Footer",
    EntityId = 1,
    Key = "NewsletterPlaceholder",
    Value = "Введите ваш адрес электронной почты",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 450,
    EntityName = "Footer",
    EntityId = 1,
    Key = "QuickLinksTitle",
    Value = "Быстрые ссылки",
    LanguageId = 4 // Russian
},
// English Translations
new Translation
{
    Id = 451,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelMainTitle",
    Value = "Get Ready to Grow with Scalable Solutions",
    LanguageId = 2 // English
},
new Translation
{
    Id = 452,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelMainContent",
    Value = "Grow your business with digital solutions and gain an edge over your competitors. Whether you are a startup or a corporate company, we add value to your business with scalable and effective solutions. Bring your projects to life with TechLiberty's expert team.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 453,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelContactTitle",
    Value = "Let's Shape the Digital Future Together",
    LanguageId = 2 // English
},
new Translation
{
    Id = 454,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelContactContent",
    Value = "Looking for support for a new project? The TechLiberty team is here to create creative and scalable solutions tailored to your needs. Let us guide you on your digital transformation journey. Contact us to discuss collaboration opportunities that will elevate your business to the next level!",
    LanguageId = 2 // English
},

// German Translations
new Translation
{
    Id = 455,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelMainTitle",
    Value = "Bereit zum Wachstum mit skalierbaren Lösungen",
    LanguageId = 3 // German
},
new Translation
{
    Id = 456,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelMainContent",
    Value = "Wachsen Sie Ihr Geschäft mit digitalen Lösungen und verschaffen Sie sich einen Vorteil gegenüber Ihren Wettbewerbern. Ob Startup oder Unternehmensunternehmen, wir fügen Ihrem Unternehmen mit skalierbaren und effektiven Lösungen Wert hinzu. Bringen Sie Ihre Projekte mit dem Expertenteam von TechLiberty erfolgreich zum Leben.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 457,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelContactTitle",
    Value = "Lassen Sie uns gemeinsam die digitale Zukunft gestalten",
    LanguageId = 3 // German
},
new Translation
{
    Id = 458,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelContactContent",
    Value = "Suchen Sie Unterstützung für ein neues Projekt? Das Team von TechLiberty ist hier, um kreative und skalierbare Lösungen zu entwickeln, die auf Ihre Bedürfnisse zugeschnitten sind. Lassen Sie uns Sie auf Ihrer digitalen Transformationsreise begleiten. Kontaktieren Sie uns, um Kooperationsmöglichkeiten zu besprechen, die Ihr Unternehmen auf die nächste Stufe bringen!",
    LanguageId = 3 // German
},

// Russian Translations
new Translation
{
    Id = 459,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelMainTitle",
    Value = "Приготовьтесь к росту с масштабируемыми решениями",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 460,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelMainContent",
    Value = "Развивайте свой бизнес с помощью цифровых решений и получите преимущество перед конкурентами. Будь вы стартап или корпоративная компания, мы добавляем ценность вашему бизнесу с масштабируемыми и эффективными решениями. Реализуйте свои проекты с командой экспертов TechLiberty.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 461,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelContactTitle",
    Value = "Давайте вместе формировать цифровое будущее",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 462,
    EntityName = "SidePanel",
    EntityId = 1,
    Key = "SidePanelContactContent",
    Value = "Ищете поддержку для нового проекта? Команда TechLiberty здесь, чтобы создавать креативные и масштабируемые решения, адаптированные к вашим потребностям. Позвольте нам быть вашим гидом на пути цифровой трансформации. Свяжитесь с нами, чтобы обсудить возможности сотрудничества, которые поднимут ваш бизнес на новый уровень!",
    LanguageId = 4 // Russian
},
                new Translation
                {
                    Id = 463,
                    EntityName = "CompanyInfo",
                    EntityId = 1,
                    Key = "CompanySlogan",
                    Value = "Where Creativity Meets Excellence",
                    LanguageId = 2
                },
                new Translation
                {
                    Id = 464,
                    EntityName = "CompanyInfo",
                    EntityId = 1,
                    Key = "CompanySlogan",
                    Value = "Wo Kreativität Exzellenz Trifft",
                    LanguageId = 3
                },
                new Translation
                {
                    Id = 465,
                    EntityName = "CompanyInfo",
                    EntityId = 1,
                    Key = "CompanySlogan",
                    Value = "Там, где творчество встречается с превосходством",
                    LanguageId = 4
                },
                new Translation
                {
                    Id = 466,
                    EntityName = "CompanyInfo",
                    EntityId = 1,
                    Key = "HomeButtonName",
                    Value = "Contact Us",
                    LanguageId = 2
                },
                new Translation
                {
                    Id = 467,
                    EntityName = "CompanyInfo",
                    EntityId = 1,
                    Key = "HomeButtonName",
                    Value = "Kontaktieren Sie Uns",
                    LanguageId = 3
                },
                new Translation
                {
                    Id = 468,
                    EntityName = "CompanyInfo",
                    EntityId = 1,
                    Key = "HomeButtonName",
                    Value = "Свяжитесь с нами",
                    LanguageId = 4
                },
                new Translation
                {
                    Id = 469,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "AboutSlogan",
                    Value = "Because You Deserve the Best",
                    LanguageId = 2
                },
                new Translation
                {
                    Id = 470,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "AboutSlogan",
                    Value = "Weil Sie Das Beste Verdienen",
                    LanguageId = 3
                },
                new Translation
                {
                    Id = 471,
                    EntityName = "About",
                    EntityId = 1,
                    Key = "AboutSlogan",
                    Value = "Потому что вы заслуживаете лучшее",
                    LanguageId = 4
                },
                new Translation
                {
                    Id = 472,
                    EntityName = "Service",
                    EntityId = 1,
                    Key = "ServiceSlogan",
                    Value = "Empowering Your Growth Through Digital Excellence",
                    LanguageId = 2
                },
                new Translation
                {
                    Id = 473,
                    EntityName = "Service",
                    EntityId = 1,
                    Key = "ServiceSlogan",
                    Value = "Digitaler Erfolg Für Ihr Unternehmen",
                    LanguageId = 3
                },
                new Translation
                {
                    Id = 474,
                    EntityName = "Service",
                    EntityId = 1,
                    Key = "ServiceSlogan",
                    Value = "Цифровые решения для вашего успеха",
                    LanguageId = 4
                },
                new Translation
                {
                    Id = 475,
                    EntityName = "Service",
                    EntityId = 1,
                    Key = "ServiceHomeTitle",
                    Value = "Our Steps",
                    LanguageId = 2
                },
                new Translation
                {
                    Id = 476,
                    EntityName = "Service",
                    EntityId = 1,
                    Key = "ServiceHomeTitle",
                    Value = "Unser Prozess",
                    LanguageId = 3
                },
                new Translation
                {
                    Id = 477,
                    EntityName = "Service",
                    EntityId = 1,
                    Key = "ServiceHomeTitle",
                    Value = "Наш Процесс",
                    LanguageId = 4
                },
// About Us - Page 1
new Translation { Id = 478, EntityName = "Page", EntityId = 1, Key = "PageHeaderTitle", Value = "About Us", LanguageId = 2 }, // English
new Translation { Id = 479, EntityName = "Page", EntityId = 1, Key = "PageHeaderTitle", Value = "Über uns", LanguageId = 3 }, // German
new Translation { Id = 480, EntityName = "Page", EntityId = 1, Key = "PageHeaderTitle", Value = "О нас", LanguageId = 4 }, // Russian
new Translation { Id = 481, EntityName = "Page", EntityId = 1, Key = "PageHeaderSubtitle", Value = "Discover our expertise. Explore our success stories.", LanguageId = 2 }, // English
new Translation { Id = 482, EntityName = "Page", EntityId = 1, Key = "PageHeaderSubtitle", Value = "Entdecken Sie unsere Expertise. Erforschen Sie unsere Erfolgsgeschichten.", LanguageId = 3 }, // German
new Translation { Id = 483, EntityName = "Page", EntityId = 1, Key = "PageHeaderSubtitle", Value = "Откройте для себя наш опыт. Изучите наши истории успеха.", LanguageId = 4 }, // Russian

// Services - Page 2
new Translation { Id = 484, EntityName = "Page", EntityId = 2, Key = "PageHeaderTitle", Value = "Services", LanguageId = 2 }, // English
new Translation { Id = 485, EntityName = "Page", EntityId = 2, Key = "PageHeaderTitle", Value = "Dienstleistungen", LanguageId = 3 }, // German
new Translation { Id = 486, EntityName = "Page", EntityId = 2, Key = "PageHeaderTitle", Value = "Услуги", LanguageId = 4 }, // Russian
new Translation { Id = 487, EntityName = "Page", EntityId = 2, Key = "PageHeaderSubtitle", Value = "Creative services to bring your digital vision to life.", LanguageId = 2 }, // English
new Translation { Id = 488, EntityName = "Page", EntityId = 2, Key = "PageHeaderSubtitle", Value = "Kreative Dienstleistungen, um Ihre digitale Vision zu verwirklichen.", LanguageId = 3 }, // German
new Translation { Id = 489, EntityName = "Page", EntityId = 2, Key = "PageHeaderSubtitle", Value = "Креативные услуги для воплощения вашей цифровой мечты.", LanguageId = 4 }, // Russian

// Blog - Page 3
new Translation { Id = 490, EntityName = "Page", EntityId = 3, Key = "PageHeaderTitle", Value = "Blog", LanguageId = 2 }, // English
new Translation { Id = 491, EntityName = "Page", EntityId = 3, Key = "PageHeaderTitle", Value = "Blog", LanguageId = 3 }, // German
new Translation { Id = 492, EntityName = "Page", EntityId = 3, Key = "PageHeaderTitle", Value = "Блог", LanguageId = 4 }, // Russian
new Translation { Id = 493, EntityName = "Page", EntityId = 3, Key = "PageHeaderSubtitle", Value = "Inspiring stories and expert insights.", LanguageId = 2 }, // English
new Translation { Id = 494, EntityName = "Page", EntityId = 3, Key = "PageHeaderSubtitle", Value = "Inspirierende Geschichten und Experteneinblicke.", LanguageId = 3 }, // German
new Translation { Id = 495, EntityName = "Page", EntityId = 3, Key = "PageHeaderSubtitle", Value = "Вдохновляющие истории и экспертные мнения.", LanguageId = 4 }, // Russian

// Blog Details - Page 4
new Translation { Id = 496, EntityName = "Page", EntityId = 4, Key = "PageHeaderTitle", Value = "Blog", LanguageId = 2 }, // English
new Translation { Id = 497, EntityName = "Page", EntityId = 4, Key = "PageHeaderTitle", Value = "Blog", LanguageId = 3 }, // German
new Translation { Id = 498, EntityName = "Page", EntityId = 4, Key = "PageHeaderTitle", Value = "Блог", LanguageId = 4 }, // Russian
new Translation { Id = 499, EntityName = "Page", EntityId = 4, Key = "PageHeaderSubtitle", Value = "Discover the details behind the story.", LanguageId = 2 }, // English
new Translation { Id = 500, EntityName = "Page", EntityId = 4, Key = "PageHeaderSubtitle", Value = "Entdecken Sie die Details hinter der Geschichte.", LanguageId = 3 }, // German
new Translation { Id = 501, EntityName = "Page", EntityId = 4, Key = "PageHeaderSubtitle", Value = "Узнайте подробности за историей.", LanguageId = 4 }, // Russian

// Contact - Page 5
new Translation { Id = 502, EntityName = "Page", EntityId = 5, Key = "PageHeaderTitle", Value = "Contact", LanguageId = 2 }, // English
new Translation { Id = 503, EntityName = "Page", EntityId = 5, Key = "PageHeaderTitle", Value = "Kontakt", LanguageId = 3 }, // German
new Translation { Id = 504, EntityName = "Page", EntityId = 5, Key = "PageHeaderTitle", Value = "Контакт", LanguageId = 4 }, // Russian
new Translation { Id = 505, EntityName = "Page", EntityId = 5, Key = "PageHeaderSubtitle", Value = "We’re here to answer your questions and support you.", LanguageId = 2 }, // English
new Translation { Id = 506, EntityName = "Page", EntityId = 5, Key = "PageHeaderSubtitle", Value = "Wir sind hier, um Ihre Fragen zu beantworten und Sie zu unterstützen.", LanguageId = 3 }, // German
new Translation { Id = 507, EntityName = "Page", EntityId = 5, Key = "PageHeaderSubtitle", Value = "Мы здесь, чтобы ответить на ваши вопросы и поддержать вас.", LanguageId = 4 }, // Russian
new Translation { Id = 508, EntityName = "Page", EntityId = 5, Key = "PageMainSlogan", Value = "Reach out to us. Let’s build the future with digital solutions.", LanguageId = 2 }, // English
new Translation { Id = 509, EntityName = "Page", EntityId = 5, Key = "PageMainSlogan", Value = "Kontaktieren Sie uns. Lassen Sie uns die Zukunft mit digitalen Lösungen gestalten.", LanguageId = 3 }, // German
new Translation { Id = 510, EntityName = "Page", EntityId = 5, Key = "PageMainSlogan", Value = "Свяжитесь с нами. Давайте строить будущее с цифровыми решениями.", LanguageId = 4 }, // Russian
new Translation { Id = 511, EntityName = "Page", EntityId = 5, Key = "PageSubSlogan", Value = "Every great success starts with a step. Take that step now.", LanguageId = 2 }, // English
new Translation { Id = 512, EntityName = "Page", EntityId = 5, Key = "PageSubSlogan", Value = "Jeder große Erfolg beginnt mit einem Schritt. Machen Sie diesen Schritt jetzt.", LanguageId = 3 }, // German
new Translation { Id = 513, EntityName = "Page", EntityId = 5, Key = "PageSubSlogan", Value = "Каждый великий успех начинается с шага. Сделайте этот шаг сейчас.", LanguageId = 4 }, // Russian

// FAQ - Page 6
new Translation { Id = 514, EntityName = "Page", EntityId = 6, Key = "PageHeaderTitle", Value = "FAQ", LanguageId = 2 }, // English
new Translation { Id = 515, EntityName = "Page", EntityId = 6, Key = "PageHeaderTitle", Value = "FAQ", LanguageId = 3 }, // German
new Translation { Id = 516, EntityName = "Page", EntityId = 6, Key = "PageHeaderTitle", Value = "Часто задаваемые вопросы", LanguageId = 4 }, // Russian
new Translation { Id = 517, EntityName = "Page", EntityId = 6, Key = "PageHeaderSubtitle", Value = "You’re in the right place to find answers to your questions.", LanguageId = 2 }, // English
new Translation { Id = 518, EntityName = "Page", EntityId = 6, Key = "PageHeaderSubtitle", Value = "Hier sind Sie richtig, um Antworten auf Ihre Fragen zu finden.", LanguageId = 3 }, // German
new Translation { Id = 519, EntityName = "Page", EntityId = 6, Key = "PageHeaderSubtitle", Value = "Вы находитесь в правильном месте, чтобы найти ответы на свои вопросы.", LanguageId = 4 } // Russian
            );
        }

    }
}
