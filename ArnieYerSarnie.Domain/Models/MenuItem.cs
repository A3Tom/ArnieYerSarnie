using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArnieYerSarnie.Domain.Models
{
    [Table("MenuItems")]
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Menu")]
        public int MenuId { get; set; }

        [ForeignKey("MenuId")]
        public Menu Menu { get; set; }

        public string Name { get; set; }

        public double? Price { get; set; }

        public double Fat { get; set; }

        public double Protien { get; set; }

        public double Carbohydrates { get; set; }

        public double Calories => ((Fat * 9) + (Protien * 4) + (Carbohydrates * 4) * 1.05);
    }
}
