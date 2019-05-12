using ArnieYerSarnie.Domain.Models;
using ArnieYerSarnie.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArnieYerSarnie.App.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MenuController
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuservice)
        {
            _menuService = menuservice;
        }


        [HttpGet]
        public string Get()
        {
            return "Yer mawwwww";
        }

        public Task<Menu> GetMenu(int Id)
        {
            return _menuService.GetMenu(Id == 0 ? 1 : Id);
        }

        public Task<List<Menu>> GetAll()
        {
            return _menuService.GetAllMenus();
        }
    }
}
