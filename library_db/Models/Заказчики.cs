using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class Заказчики
    {
        public long Телефон { get; set; }
        public long ПаспортныеДанные { get; set; }
        public long Адрес { get; set; }
        public long Фио { get; set; }
        public long КодЗаказчика { get; set; }
    }
}
