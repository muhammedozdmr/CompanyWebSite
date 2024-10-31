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
        }
            );
        }

    }
}
