using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class Материалы
    {
        public long КодМатериала { get; set; }
        public long Наименование { get; set; }
        public long Упаковка { get; set; }
        public long Описание { get; set; }
        public long Цена { get; set; }
    }
}
