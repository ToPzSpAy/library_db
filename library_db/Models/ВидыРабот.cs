using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class ВидыРабот
    {
        public long Наименование { get; set; }
        public long КодМатериала1 { get; set; }
        public long Описание { get; set; }
        public long ЦенаРаботы { get; set; }
        public long КодВида { get; set; }
        public long КодМатериала2 { get; set; }
        public long КодМатериала3 { get; set; }
    }
}
