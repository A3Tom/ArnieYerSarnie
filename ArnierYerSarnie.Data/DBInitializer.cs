using ArnieYerSarnie.Data;
using ArnieYerSarnie.Domain.Enums;
using ArnieYerSarnie.Domain.Models;
using System.Linq;

namespace ArnieYerSarnie.Data
{
    public static class DBInitializer
    {
        public static void Initialize(FoodContext context)
        {
            context.Database.EnsureCreated();

            if(context.Menu.Any())
            {
                return;
            }

            var Menus = new Menu[]
            {
                new Menu() { Id = 1, Title = "McDs Special", Vendor = VendorEnum.MCDONALDS },
                new Menu() { Id = 619, Title = "Who Ye Goni Call", Vendor = VendorEnum.FULL_REMO }
            };

            context.Menu.AddRange(Menus);

            context.SaveChanges();

            var menuItems = new MenuItem[]
            {
                new MenuItem() { Id = 1, Name = "", MenuId = 1, Price = 1.99, Protien = 1, Fat = 1, Carbohydrates = 1}
            };

            context.MenuItem.AddRange(menuItems);

            context.SaveChanges();
        }
    }
}
