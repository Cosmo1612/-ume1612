﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHocDTOcs
    {
            public int Id { get; set; }
            public int IdHocVien { get; set; }
            public string MonHoc { get; set; } = string.Empty;
            public int SoTinChi { get; set; }
            public decimal SoTien { get; set; }
            public DateTime NgayThanhToan { get; set; }
        }
    }


