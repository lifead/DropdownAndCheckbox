using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DropdownAndCheckbox.Domain.ViewModels.CheckboxElement
{
    /// <summary>
    /// Строка таблицы со списком checkbox
    /// </summary>
    public class RowCheckboxViewModel
    {
        /// <summary>
        /// Скачать
        /// </summary>
        [DisplayName("Скачать")]
        public bool Download { get; set; }


        /// <summary>
        /// Удалить
        /// </summary>
        [DisplayName("Удалить")]
        public bool Delete { get; set; }


        /// <summary>
        /// Изменить
        /// </summary>
        [DisplayName("Изменить")]
        public bool Edit { get; set; }


        /// <summary>
        /// Создать
        /// </summary>
        [DisplayName("Создать")]
        public bool Create { get; set; }


        /// <summary>
        /// Чтение
        /// </summary>
        [DisplayName("Чтение")]
        public bool Read { get; set; }
    }
}
