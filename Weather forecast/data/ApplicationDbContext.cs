using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Weather_forecast.Models;

namespace Weather_forecast.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<WFModel> WFs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WFModel>().HasData(
                new WFModel
                {
                    Id = 1,
                    Date = new DateTime(2022, 12, 01),
                    humidity = 75,
                    temperature = 0,
                    pressure = 742,
                    Summaries = "Chilly"
                },
                new WFModel
                {
                    Id = 2,
                    Date = new DateTime(2022, 12, 02),
                    humidity = 78,
                    temperature = -1,
                    pressure = 743,
                    Summaries = "Bracing"
                },
                new WFModel
                {
                    Id = 3,
                    Date = new DateTime(2022, 12, 03),
                    humidity = 82,
                    temperature = -3,
                    pressure = 744,
                    Summaries = "Bracing"
                },
                new WFModel
                {
                    Id = 4,
                    Date = new DateTime(2022, 12, 04),
                    humidity = 79,
                    temperature = -5,
                    pressure = 746,
                    Summaries = "Freezing"
                },
                new WFModel
                {
                    Id = 5,
                    Date = new DateTime(2022, 12, 05),
                    humidity = 82,
                    temperature = -7,
                    pressure = 746,
                    Summaries = "Freezing"
                },
                new WFModel
                {
                    Id = 6,
                    Date = new DateTime(2022, 12, 06),
                    humidity = 84,
                    temperature = -3,
                    pressure = 742,
                    Summaries = "Bracing"
                },
                new WFModel
                {
                    Id = 7,
                    Date = new DateTime(2022, 12, 07),
                    humidity = 86,
                    temperature = -2,
                    pressure = 744,
                    Summaries = "Bracing"
                },
                new WFModel
                {
                    Id = 8,
                    Date = new DateTime(2022, 12, 08),
                    humidity = 83,
                    temperature = 0,
                    pressure = 748,
                    Summaries = "Bracing"
                },
                new WFModel
                {
                    Id = 9,
                    Date = new DateTime(2022, 12, 09),
                    humidity = 85,
                    temperature = 1,
                    pressure = 745,
                    Summaries = "Chilly"
                },
                new WFModel
                {
                    Id = 10,
                    Date = new DateTime(2022, 12, 10),
                    humidity = 87,
                    temperature = 2,
                    pressure = 743,
                    Summaries = "Chilly"
                },
                new WFModel
                {
                    Id = 11,
                    Date = new DateTime(2022, 12, 11),
                    humidity = 78,
                    temperature = -1,
                    pressure = 743,
                    Summaries = "Bracing"
                },
                new WFModel
                {
                    Id = 12,
                    Date = new DateTime(2022, 12, 12),
                    humidity = 75,
                    temperature = 0,
                    pressure = 742,
                    Summaries = "Chilly"
                },
                new WFModel
                {
                    Id = 13,
                    Date = new DateTime(2022, 12, 13),
                    humidity = 82,
                    temperature = -7,
                    pressure = 746,
                    Summaries = "Freezing"
                },
                new WFModel
                {
                    Id = 14,
                    Date = new DateTime(2022, 12, 14),
                    humidity = 84,
                    temperature = -3,
                    pressure = 742,
                    Summaries = "Bracing"
                },
                new WFModel
                {
                    Id = 15,
                    Date = new DateTime(2022, 12, 15),
                    humidity = 82,
                    temperature = -3,
                    pressure = 744,
                    Summaries = "Bracing"
                },
                new WFModel
                {
                    Id = 16,
                    Date = new DateTime(2022, 12, 16),
                    humidity = 79,
                    temperature = -5,
                    pressure = 746,
                    Summaries = "Freezing"
                },
                new WFModel
                {
                    Id = 17,
                    Date = new DateTime(2022, 12, 17),
                    humidity = 85,
                    temperature = 1,
                    pressure = 745,
                    Summaries = "Chilly"
                },
                new WFModel
                {
                    Id = 18,
                    Date = new DateTime(2022, 12, 18),
                    humidity = 87,
                    temperature = 2,
                    pressure = 743,
                    Summaries = "Chilly"
                },
                new WFModel
                {
                    Id = 19,
                    Date = new DateTime(2022, 12, 19),
                    humidity = 86,
                    temperature = -2,
                    pressure = 744,
                    Summaries = "Bracing"
                },
                new WFModel
                {
                    Id = 20,
                    Date = new DateTime(2022, 12, 20),
                    humidity = 83,
                    temperature = 0,
                    pressure = 748,
                    Summaries = "Bracing"
                });
        }
    }
}
