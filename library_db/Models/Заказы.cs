using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class Заказы
    {
        public long КодЗаказчика { get; set; }
        public long КодВидаРабот { get; set; }
        public long КодБригады { get; set; }
        public long Стоимость { get; set; }
        public long ДатаНачала { get; set; }
        public long ДатаОкончания { get; set; }
        public long ОтметкаОЗавершении { get; set; }
        public long ОбОплате { get; set; }
        public long КодСотрудника { get; set; }
    }
}
