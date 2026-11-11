using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindPalace.Models
{
    /// <summary>
    /// Учебный предмет
    /// </summary>
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Note> Notes { get; set; } = new();
        /// <summary>
        /// проверка заполненности названия предмета
        /// </summary>
        /// <returns>true - название содержит хотя бы один символ (не пробел)</returns>
        public bool IsValid() => !string.IsNullOrWhiteSpace(Name);
    }
}
