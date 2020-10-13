using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class Сотрудники
    {
        public long КодСотрудника { get; set; }
        public long Фио { get; set; }
        public long Возраст { get; set; }
        public long Пол { get; set; }
        public long Адрес { get; set; }
        public long Телефон { get; set; }
        public long КодДолжности { get; set; }
    }
}
