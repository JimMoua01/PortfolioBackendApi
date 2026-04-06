using PortfolioApi.Models;

namespace PortfolioApi.Data
{
    public class DbSeeder
    {
        public static void Seed(DataContext db)
        {
            if (!db.Projects.Any())
            {
                db.Projects.AddRange(
                    new Project { Id = 1, Title = "Create Your Own Database", Description = "For my Data Concepts class, I used SQL to create a database around my hobby of Gunpla. Initially, I made a data dictionary and crow’s foot diagram to establish its structure. Then I went into SQL Server to create the database and the entities/tables within, along with adding in the necessary data. This project was a culmination of everything I learned in Data Concepts A-C regarding database design and entity relationships.", Type = "Data Concepts", Link = "", Image = "/images/project1_DataConcepts.png" },
                    new Project { Id = 2, Title = "Success PAT", Description = "For College 101, I created a visual of what I thought were the most important qualities to succeed. During the course, I was to read an online book, with each chapter detailing a specific quality needed to succeed. Out of the total eight, I chose ‘Emotional Intelligence’, ‘Lifelong Learning’, and ‘Greater Personal Responsibility’ as the most vital. These three qualities would be the most important in achieving my personal form of success.", Type = "Other", Link = "", Image = "/images/project2_College101.png" },
                    new Project { Id = 3, Title = "Pixel Arcade", Description = "For my Web Design class, I was to finish this website by handling its interactivity and animation. Using HTML and CSS, I gave each of the headings (DOWNLOAD, SCREENSHOTS, etc.) visual changes and inserted three animals that could move on the screen. This was probably the most difficult assignment for me as I had to use tools like F12 to fix some of the issues with the animals not loading in correctly.", Type = "Web Design", Link = "", Image = "/images/project3_WebDesign.png" }
                );
            }

            if (!db.Contacts.Any())
            {
                db.Contacts.AddRange(
                    new Contact { Id = 1, Company = "Test", FirstName = "Jim", LastName = "Moua", City = "Wausau", State = "WI", Email = "hello@gmail.com", PhoneNumber = "715-517-3421", Zip = "54401", Comment = "Hello Jim." }
                );
            }
        }
    }
}
