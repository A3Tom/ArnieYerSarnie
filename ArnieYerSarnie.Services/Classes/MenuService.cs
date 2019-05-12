using ArnieYerSarnie.Data;
using ArnieYerSarnie.Domain.Models;
using ArnieYerSarnie.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArnieYerSarnie.Services.Classes
{
    public class MenuService : IMenuService
    {
        private readonly FoodContext _dbContext;

        public MenuService(FoodContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Menu> GetMenu(int menuId)
        {
            var menu = await _dbContext.Menu
                .Include(x => x.MenuItems)
                .FirstOrDefaultAsync(x => x.Id == menuId);

            return menu;
        }

        public async Task<List<Menu>> GetAllMenus()
        {
            var menus = await _dbContext.Menu
                .Include(x => x.MenuItems)
                .ToListAsync();

            return menus;
        }
    }
}