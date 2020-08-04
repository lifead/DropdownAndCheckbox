using DropdownAndCheckbox.Domain.ViewModels.DropdownMenu;
using Microsoft.AspNetCore.Mvc;


namespace DropdownAndCheckbox.Components
{
    public class MenuViewComponent : ViewComponent
    {
        static MenuItemViewModel[] ArrMenu = new MenuItemViewModel[]
        {
            new MenuItemViewModel { IsEmpty = true },
            new MenuItemViewModel { IsDivider = true },
            new MenuItemViewModel { ImageIcon = "P", NameLink = "Администрирование", Link = "#", ChilrdenMenuItems = null },
            new MenuItemViewModel { ImageIcon = "H", NameLink = "Пользователи", Link = "#", ChilrdenMenuItems = null },
            new MenuItemViewModel { ImageIcon = "H", NameLink = "Профиль", Link = "#", ChilrdenMenuItems = null },
            new MenuItemViewModel { ImageIcon = "H", NameLink = "Журнал пользователей", Link = "#", ChilrdenMenuItems = null }
        };

        public IViewComponentResult Invoke()
        {
            return View(ArrMenu);
        }
    }
}
