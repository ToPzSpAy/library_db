using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class Должности
    {
        public long КодДолжности { get; set; }
        public long НаименованиеДолжности { get; set; }
        public long Оклад { get; set; }
        public long Обязанности { get; set; }
        public long Требования { get; set; }
    }
}
