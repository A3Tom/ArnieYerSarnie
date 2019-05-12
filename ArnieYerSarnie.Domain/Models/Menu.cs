using ArnieYerSarnie.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArnieYerSarnie.Domain.Models
{
    [Table("Menus")]
    public class Menu 
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public VendorEnum Vendor { get; set; }

        public IEnumerable<MenuItem> MenuItems { get; set; }

        public DateTime DateTimeCreated { get; set; }
    }
}
