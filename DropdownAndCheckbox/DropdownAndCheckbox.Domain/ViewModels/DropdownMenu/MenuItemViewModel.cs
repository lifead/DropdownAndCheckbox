using System;
using System.Collections.Generic;
using System.Text;

namespace DropdownAndCheckbox.Domain.ViewModels.DropdownMenu
{
    /// <summary>
    /// Элемент списка меню
    /// </summary>
    public class MenuItemViewModel
    {
        /// <summary>
        /// Иконка ссылки
        /// </summary>
        public string ImageIcon { get; set; }

        /// <summary>
        /// Отображаемое наименование ссылки меню
        /// </summary>
        public string NameLink { get; set; }

        /// <summary>
        /// Адрес ссылки меню
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Список дочерних ссылок меню
        /// </summary>
        public IEnumerable<MenuItemViewModel> ChilrdenMenuItems { get; set; }

        /// <summary>
        /// Элемент меню - разделитель
        /// </summary>
        public bool IsDivider { get; set; } = false;

        /// <summary>
        /// Пустой элемент меню
        /// </summary>
        public bool IsEmpty { get; set; } = false;


    }
}
