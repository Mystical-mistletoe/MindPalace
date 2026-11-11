using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindPalace.Models
{
    /// <summary>
    /// Заметка: заголовок, текст и признак удаления.
    /// </summary>
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public int? SubjectId { get; set; }
        public int? ScheduleItemId { get; set; }

        /// <summary>
        /// Помечает заметку удаленной
        /// заметку можно восстановить (остается в бд)
        /// </summary>
        public void SoftDelete()
        {
            IsDeleted = true;
        }
    }
}
