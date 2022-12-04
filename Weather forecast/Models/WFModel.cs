using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Weather_forecast.Models
{
    public class WFModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int humidity { get; set; }

        public int temperature { get; set; }

        public int pressure { get; set; }

        public string? Summaries { get; set; }

    }
}