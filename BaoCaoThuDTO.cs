﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoThuDTO
    {
        public int Id { get; set; }
        public Decimal TongThu { get; set; }
        public DateTime NgayThu { get; set; }
        public string NoiDung { get; set; }
    }
}
