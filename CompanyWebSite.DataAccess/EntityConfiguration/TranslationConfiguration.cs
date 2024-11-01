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
            Value = "Software development is the process of creating programs that provide a solution to a problem. Technological advancements have brought significant changes in software development processes...",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 14,
            EntityName = "Blog",
            EntityId = 1,
            Key = "DefaultContent",
            Value = "Softwareentwicklung ist der Prozess der Erstellung von Programmen, die eine Lösung für ein Problem bieten. Technologische Fortschritte haben bedeutende Veränderungen in den Softwareentwicklungsprozessen mit sich gebracht...",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 15,
            EntityName = "Blog",
            EntityId = 1,
            Key = "DefaultContent",
            Value = "Разработка программного обеспечения - это процесс создания программ, обеспечивающих решение проблемы. Технологические достижения внесли значительные изменения в процессы разработки программного обеспечения...",
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
            Value = "The process of developing a mobile application includes various stages from design to user experience. To create a successful mobile app, it is essential to understand user needs and offer solutions...",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 20,
            EntityName = "Blog",
            EntityId = 2,
            Key = "DefaultContent",
            Value = "Der Prozess der Entwicklung einer mobilen Anwendung umfasst verschiedene Phasen vom Design bis zur Benutzererfahrung. Um eine erfolgreiche mobile App zu erstellen, ist es wichtig, die Bedürfnisse der Benutzer zu verstehen...",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 21,
            EntityName = "Blog",
            EntityId = 2,
            Key = "DefaultContent",
            Value = "Процесс разработки мобильного приложения включает в себя различные этапы, от дизайна до пользовательского опыта. Чтобы создать успешное мобильное приложение, важно понимать потребности пользователей...",
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
            Value = "API integration enables different software systems to interact with each other, maintaining data security and functionality during data sharing...",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 26,
            EntityName = "Blog",
            EntityId = 3,
            Key = "DefaultContent",
            Value = "Die API-Integration ermöglicht es verschiedenen Softwaresystemen, miteinander zu interagieren, wobei die Datensicherheit und Funktionalität beim Datenaustausch gewährleistet wird...",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 27,
            EntityName = "Blog",
            EntityId = 3,
            Key = "DefaultContent",
            Value = "Интеграция API позволяет различным программным системам взаимодействовать друг с другом, поддерживая безопасность данных и функциональность при обмене данными...",
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
            Value = "ERP systems allow businesses to manage their operations more efficiently. These systems integrate various departments such as finance, human resources, and supply chain into one platform...",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 32,
            EntityName = "Blog",
            EntityId = 4,
            Key = "DefaultContent",
            Value = "ERP-Systeme ermöglichen es Unternehmen, ihre Abläufe effizienter zu verwalten. Diese Systeme integrieren verschiedene Abteilungen wie Finanzen, Personalwesen und Lieferkette in eine Plattform...",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 33,
            EntityName = "Blog",
            EntityId = 4,
            Key = "DefaultContent",
            Value = "ERP-системы позволяют компаниям более эффективно управлять своими операциями. Эти системы интегрируют различные отделы, такие как финансы, кадры и цепочка поставок, в одну платформу...",
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
            Value = "Technologies used in the game development world are rapidly evolving, presenting new opportunities. Unity and Unreal Engine game engines provide developers with superior performance...",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 38,
            EntityName = "Blog",
            EntityId = 5,
            Key = "DefaultContent",
            Value = "Die in der Spieleentwicklungswelt verwendeten Technologien entwickeln sich rasant weiter und bieten neue Möglichkeiten. Unity- und Unreal Engine-Spiel-Engines bieten Entwicklern überlegene Leistung...",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 39,
            EntityName = "Blog",
            EntityId = 5,
            Key = "DefaultContent",
            Value = "Технологии, используемые в мире разработки игр, быстро развиваются, представляя новые возможности. Игровые движки Unity и Unreal Engine обеспечивают разработчикам высокую производительность...",
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
            Value = "Progressive Web Apps (PWA) are a type of web application that enhances the user experience. PWAs work like native apps on mobile devices, offering fast loading times, offline access...",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 44,
            EntityName = "Blog",
            EntityId = 6,
            Key = "DefaultContent",
            Value = "Progressive Web Apps (PWA) sind eine Art von Webanwendung, die das Benutzererlebnis verbessert. PWAs funktionieren wie native Apps auf mobilen Geräten und bieten schnelle Ladezeiten...",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 45,
            EntityName = "Blog",
            EntityId = 6,
            Key = "DefaultContent",
            Value = "Прогрессивные веб-приложения (PWA) - это тип веб-приложений, улучшающих пользовательский опыт. PWA работают как родные приложения на мобильных устройствах, обеспечивая быстрое время загрузки...",
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
    Value = "Küplüce Mahallesi 5. Zeytinlik Sokak No:13/A",
    LanguageId = 2 // English
},
new Translation
{
    Id = 53,
    EntityName = "CompanyInfo",
    EntityId = 1,
    Key = "Address",
    Value = "Küplüce Mahallesi 5. Zeytinlik Straße Nr.13/A",
    LanguageId = 3 // German
},
new Translation
{
    Id = 54,
    EntityName = "CompanyInfo",
    EntityId = 1,
    Key = "Address",
    Value = "Кюплюдже Махаллеси 5. Зейтинлик Сокак No:13/A",
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
    Value = "You can reach us by email (info@techliberty.co) or phone (+90 (543) 233 33 32). You can also contact us through our social media accounts.",
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
            Value = "Here you can find details about the growth of TechLiberty, our vision, and projects since our founding.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 125,
            EntityName = "History",
            EntityId = 1,
            Key = "DefaultContent",
            Value = "Hier finden Sie Details über das Wachstum von TechLiberty, unsere Vision und Projekte seit unserer Gründung.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 126,
            EntityName = "History",
            EntityId = 1,
            Key = "DefaultContent",
            Value = "Здесь вы найдете подробности о росте TechLiberty, нашем видении и проектах с момента основания.",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 127,
            EntityName = "History",
            EntityId = 1,
            Key = "YearDescription",
            Value = "TechLiberty Software Solutions was founded on October 29, 2023, with the aim of addressing shortcomings in ERP solutions in the private sector. Our founder set out with the goal of developing next-generation software solutions to increase the efficiency of industry companies and contribute to their digital transformation.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 128,
            EntityName = "History",
            EntityId = 1,
            Key = "YearDescription",
            Value = "TechLiberty Software Solutions wurde am 29. Oktober 2023 mit dem Ziel gegründet, die Mängel der ERP-Lösungen im privaten Sektor zu beheben. Unser Gründer verfolgte das Ziel, die Effizienz der Unternehmen in der Branche zu steigern und deren digitale Transformation durch die Entwicklung von Softwarelösungen der nächsten Generation zu unterstützen.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 129,
            EntityName = "History",
            EntityId = 1,
            Key = "YearDescription",
            Value = "TechLiberty Software Solutions была основана 29 октября 2023 года с целью устранения недостатков ERP-решений в частном секторе. Наш основатель стремился повысить эффективность компаний отрасли и способствовать их цифровой трансформации, разрабатывая программные решения нового поколения.",
            LanguageId = 4 // Russian
        },

        // History Id = 2 Translations
        new Translation
        {
            Id = 130,
            EntityName = "History",
            EntityId = 2,
            Key = "DefaultTitle",
            Value = "Our Company History",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 131,
            EntityName = "History",
            EntityId = 2,
            Key = "DefaultTitle",
            Value = "Die Geschichte unseres Unternehmens",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 132,
            EntityName = "History",
            EntityId = 2,
            Key = "DefaultTitle",
            Value = "История нашей компании",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 133,
            EntityName = "History",
            EntityId = 2,
            Key = "DefaultContent",
            Value = "Here you can find details about the growth of TechLiberty, our vision, and projects since our founding.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 134,
            EntityName = "History",
            EntityId = 2,
            Key = "DefaultContent",
            Value = "Hier finden Sie Details über das Wachstum von TechLiberty, unsere Vision und Projekte seit unserer Gründung.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 135,
            EntityName = "History",
            EntityId = 2,
            Key = "DefaultContent",
            Value = "Здесь вы найдете подробности о росте TechLiberty, нашем видении и проектах с момента основания.",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 136,
            EntityName = "History",
            EntityId = 2,
            Key = "YearDescription",
            Value = "TechLiberty announced the 'Gof Games' project, inspired by the founder's beloved dog, Gofret, aiming to offer both fun and emotional experiences. We also accelerated our work on developing flexible and powerful ERP solutions.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 137,
            EntityName = "History",
            EntityId = 2,
            Key = "YearDescription",
            Value = "TechLiberty kündigte das Projekt 'Gof Games' an, inspiriert vom geliebten Hund des Gründers, Gofret, und bot den Spielern sowohl Spaß als auch emotionale Erlebnisse. Wir haben auch unsere Arbeit an der Entwicklung flexibler und leistungsstarker ERP-Lösungen beschleunigt.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 138,
            EntityName = "History",
            EntityId = 2,
            Key = "YearDescription",
            Value = "TechLiberty анонсировала проект 'Gof Games', вдохновленный любимой собакой основателя Гофрет, с целью предложить игрокам как веселые, так и эмоциональные переживания. Мы также ускорили работу над созданием гибких и мощных ERP-решений.",
            LanguageId = 4 // Russian
        },

        // History Id = 3 Translations
        new Translation
        {
            Id = 139,
            EntityName = "History",
            EntityId = 3,
            Key = "DefaultTitle",
            Value = "Our Company History",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 140,
            EntityName = "History",
            EntityId = 3,
            Key = "DefaultTitle",
            Value = "Die Geschichte unseres Unternehmens",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 141,
            EntityName = "History",
            EntityId = 3,
            Key = "DefaultTitle",
            Value = "История нашей компании",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 142,
            EntityName = "History",
            EntityId = 3,
            Key = "DefaultContent",
            Value = "Here you can find details about the growth of TechLiberty, our vision, and projects since our founding.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 143,
            EntityName = "History",
            EntityId = 3,
            Key = "DefaultContent",
            Value = "Hier finden Sie Details über das Wachstum von TechLiberty, unsere Vision und Projekte seit unserer Gründung.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 144,
            EntityName = "History",
            EntityId = 3,
            Key = "DefaultContent",
            Value = "Здесь вы найдете подробности о росте TechLiberty, нашем видении и проектах с момента основания.",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 145,
            EntityName = "History",
            EntityId = 3,
            Key = "YearDescription",
            Value = "At TechLiberty, we focus on placing technology and innovation at the center of our business. We offer innovative solutions to support the digital transformation of companies and optimize their processes.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 146,
            EntityName = "History",
            EntityId = 3,
            Key = "YearDescription",
            Value = "Bei TechLiberty legen wir den Schwerpunkt auf Technologie und Innovation im Zentrum unseres Geschäfts. Wir bieten innovative Lösungen zur Unterstützung der digitalen Transformation von Unternehmen und zur Optimierung ihrer Prozesse.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 147,
            EntityName = "History",
            EntityId = 3,
            Key = "YearDescription",
            Value = "В компании TechLiberty мы делаем акцент на технологии и инновации в центре нашего бизнеса. Мы предлагаем инновационные решения для поддержки цифровой трансформации компаний и оптимизации их процессов.",
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
            Value = "We offer professional web development services to help you plan, create, manage, and market your web project.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 152,
            EntityName = "Service",
            EntityId = 1,
            Key = "DefaultContent",
            Value = "Wir bieten professionelle Webentwicklungsdienste an, um Ihnen bei der Planung, Erstellung, Verwaltung und Vermarktung Ihres Webprojekts zu helfen.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 153,
            EntityName = "Service",
            EntityId = 1,
            Key = "DefaultContent",
            Value = "Мы предлагаем профессиональные услуги веб-разработки, чтобы помочь вам спланировать, создать, управлять и продвигать ваш веб-проект.",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 154,
            EntityName = "Service",
            EntityId = 1,
            Key = "ServiceSummary",
            Value = "We offer professional web development services for web projects.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 155,
            EntityName = "Service",
            EntityId = 1,
            Key = "ServiceSummary",
            Value = "Wir bieten professionelle Webentwicklungsdienste für Webprojekte an.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 156,
            EntityName = "Service",
            EntityId = 1,
            Key = "ServiceSummary",
            Value = "Мы предлагаем профессиональные услуги веб-разработки для веб-проектов.",
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
            Value = "We offer comprehensive services to support mobile app development for iOS and Android platforms.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 161,
            EntityName = "Service",
            EntityId = 2,
            Key = "DefaultContent",
            Value = "Wir bieten umfassende Dienstleistungen zur Unterstützung der mobilen App-Entwicklung für iOS- und Android-Plattformen an.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 162,
            EntityName = "Service",
            EntityId = 2,
            Key = "DefaultContent",
            Value = "Мы предлагаем комплексные услуги по поддержке разработки мобильных приложений для платформ iOS и Android.",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 163,
            EntityName = "Service",
            EntityId = 2,
            Key = "ServiceSummary",
            Value = "We provide user-friendly mobile app development services.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 164,
            EntityName = "Service",
            EntityId = 2,
            Key = "ServiceSummary",
            Value = "Wir bieten benutzerfreundliche mobile App-Entwicklungsdienste an.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 165,
            EntityName = "Service",
            EntityId = 2,
            Key = "ServiceSummary",
            Value = "Мы предоставляем удобные услуги по разработке мобильных приложений.",
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
            Value = "We provide game development services using advanced technologies to help you create fun and interactive games.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 170,
            EntityName = "Service",
            EntityId = 3,
            Key = "DefaultContent",
            Value = "Wir bieten Spieleentwicklungsdienste mit fortschrittlichen Technologien an, um Ihnen bei der Erstellung von lustigen und interaktiven Spielen zu helfen.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 171,
            EntityName = "Service",
            EntityId = 3,
            Key = "DefaultContent",
            Value = "Мы предоставляем услуги по разработке игр с использованием передовых технологий, чтобы помочь вам создать веселые и интерактивные игры.",
            LanguageId = 4 // Russian
        },
        new Translation
        {
            Id = 172,
            EntityName = "Service",
            EntityId = 3,
            Key = "ServiceSummary",
            Value = "We offer interactive game development services.",
            LanguageId = 2 // English
        },
        new Translation
        {
            Id = 173,
            EntityName = "Service",
            EntityId = 3,
            Key = "ServiceSummary",
            Value = "Wir bieten interaktive Spieleentwicklungsdienste an.",
            LanguageId = 3 // German
        },
        new Translation
        {
            Id = 174,
            EntityName = "Service",
            EntityId = 3,
            Key = "ServiceSummary",
            Value = "Мы предлагаем услуги по разработке интерактивных игр.",
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
    Value = "We provide API development and integration services to optimize data flow between different systems.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 179,
    EntityName = "Service",
    EntityId = 4,
    Key = "DefaultContent",
    Value = "Wir bieten API-Entwicklungs- und Integrationsdienste an, um den Datenfluss zwischen verschiedenen Systemen zu optimieren.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 180,
    EntityName = "Service",
    EntityId = 4,
    Key = "DefaultContent",
    Value = "Мы предоставляем услуги по разработке и интеграции API для оптимизации потоков данных между различными системами.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 181,
    EntityName = "Service",
    EntityId = 4,
    Key = "ServiceSummary",
    Value = "Data flow optimization with API integration services.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 182,
    EntityName = "Service",
    EntityId = 4,
    Key = "ServiceSummary",
    Value = "Datenflussoptimierung mit API-Integrationsdiensten.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 183,
    EntityName = "Service",
    EntityId = 4,
    Key = "ServiceSummary",
    Value = "Оптимизация потоков данных с помощью услуг по интеграции API.",
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
    Value = "We offer comprehensive CRM solutions to improve customer relationships and manage processes.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 188,
    EntityName = "Service",
    EntityId = 5,
    Key = "DefaultContent",
    Value = "Wir bieten umfassende CRM-Lösungen zur Verbesserung der Kundenbeziehungen und zur Prozessverwaltung.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 189,
    EntityName = "Service",
    EntityId = 5,
    Key = "DefaultContent",
    Value = "Мы предлагаем комплексные CRM-решения для улучшения отношений с клиентами и управления процессами.",
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
    Value = "Umfassende CRM-Lösungen zur Verwaltung von Kundenbeziehungen.",
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
    Value = "We offer advanced ERP solutions to manage business processes and increase efficiency.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 197,
    EntityName = "Service",
    EntityId = 6,
    Key = "DefaultContent",
    Value = "Wir bieten fortschrittliche ERP-Lösungen zur Verwaltung von Geschäftsprozessen und zur Steigerung der Effizienz.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 198,
    EntityName = "Service",
    EntityId = 6,
    Key = "DefaultContent",
    Value = "Мы предлагаем современные ERP-решения для управления бизнес-процессами и повышения эффективности.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 199,
    EntityName = "Service",
    EntityId = 6,
    Key = "ServiceSummary",
    Value = "Advanced ERP solutions for managing business processes.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 200,
    EntityName = "Service",
    EntityId = 6,
    Key = "ServiceSummary",
    Value = "Fortschrittliche ERP-Lösungen zur Verwaltung von Geschäftsprozessen.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 201,
    EntityName = "Service",
    EntityId = 6,
    Key = "ServiceSummary",
    Value = "Современные ERP-решения для управления бизнес-процессами.",
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
    Value = "Manage your data efficiently with secure and scalable database management systems.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 206,
    EntityName = "Service",
    EntityId = 7,
    Key = "DefaultContent",
    Value = "Verwalten Sie Ihre Daten effizient mit sicheren und skalierbaren Datenbankverwaltungssystemen.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 207,
    EntityName = "Service",
    EntityId = 7,
    Key = "DefaultContent",
    Value = "Управляйте своими данными эффективно с помощью безопасных и масштабируемых систем управления базами данных.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 208,
    EntityName = "Service",
    EntityId = 7,
    Key = "ServiceSummary",
    Value = "Database solutions for effective data management.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 209,
    EntityName = "Service",
    EntityId = 7,
    Key = "ServiceSummary",
    Value = "Datenbanklösungen für eine effektive Datenverwaltung.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 210,
    EntityName = "Service",
    EntityId = 7,
    Key = "ServiceSummary",
    Value = "Решения для эффективного управления данными.",
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
    Value = "We analyze your business processes and provide system designs tailored to your needs.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 215,
    EntityName = "Service",
    EntityId = 8,
    Key = "DefaultContent",
    Value = "Wir analysieren Ihre Geschäftsprozesse und bieten maßgeschneiderte Systemdesigns.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 216,
    EntityName = "Service",
    EntityId = 8,
    Key = "DefaultContent",
    Value = "Мы анализируем ваши бизнес-процессы и предоставляем системы, адаптированные к вашим потребностям.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 217,
    EntityName = "Service",
    EntityId = 8,
    Key = "ServiceSummary",
    Value = "Customized system analysis and design services.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 218,
    EntityName = "Service",
    EntityId = 8,
    Key = "ServiceSummary",
    Value = "Individuelle Systemanalyse- und Design-Dienstleistungen.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 219,
    EntityName = "Service",
    EntityId = 8,
    Key = "ServiceSummary",
    Value = "Услуги по анализу и проектированию систем, адаптированные к вашим потребностям.",
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
    Value = "We provide professional project management solutions to help you manage your projects effectively.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 224,
    EntityName = "Service",
    EntityId = 9,
    Key = "DefaultContent",
    Value = "Wir bieten professionelle Projektmanagement-Lösungen an, um Ihnen zu helfen, Ihre Projekte effektiv zu verwalten.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 225,
    EntityName = "Service",
    EntityId = 9,
    Key = "DefaultContent",
    Value = "Мы предоставляем профессиональные решения для эффективного управления проектами.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 226,
    EntityName = "Service",
    EntityId = 9,
    Key = "ServiceSummary",
    Value = "Project management solutions for successful project delivery.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 227,
    EntityName = "Service",
    EntityId = 9,
    Key = "ServiceSummary",
    Value = "Projektmanagementlösungen für eine erfolgreiche Projektabwicklung.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 228,
    EntityName = "Service",
    EntityId = 9,
    Key = "ServiceSummary",
    Value = "Решения для успешного управления проектами.",
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
    Value = "We provide scalable and reliable cloud solutions for data storage and management.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 233,
    EntityName = "Service",
    EntityId = 10,
    Key = "DefaultContent",
    Value = "Wir bieten skalierbare und zuverlässige Cloud-Lösungen zur Datenspeicherung und -verwaltung.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 234,
    EntityName = "Service",
    EntityId = 10,
    Key = "DefaultContent",
    Value = "Мы предоставляем масштабируемые и надежные облачные решения для хранения и управления данными.",
    LanguageId = 4 // Russian
},
new Translation
{
    Id = 235,
    EntityName = "Service",
    EntityId = 10,
    Key = "ServiceSummary",
    Value = "Reliable and scalable cloud solutions for data management.",
    LanguageId = 2 // English
},
new Translation
{
    Id = 236,
    EntityName = "Service",
    EntityId = 10,
    Key = "ServiceSummary",
    Value = "Zuverlässige und skalierbare Cloud-Lösungen zur Datenverwaltung.",
    LanguageId = 3 // German
},
new Translation
{
    Id = 237,
    EntityName = "Service",
    EntityId = 10,
    Key = "ServiceSummary",
    Value = "Надежные и масштабируемые облачные решения для управления данными.",
    LanguageId = 4 // Russian
}
            );
        }

    }
}
