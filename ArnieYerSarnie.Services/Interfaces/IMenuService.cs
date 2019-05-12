using ArnieYerSarnie.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArnieYerSarnie.Services.Interfaces
{
    public interface IMenuService
    {
        Task<Menu> GetMenu(int menuId);
        Task<List<Menu>> GetAllMenus();
    }
}
