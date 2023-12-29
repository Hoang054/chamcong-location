using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recruit.Server.Models
{
    public class ChamCongLine
    {
        public Double MngChamCongPrkID { get; set; }
        public int NgayCC { get; set; }
        public int? BuoiSang { get; set; }
        public int? BuoiChieu { get; set; }
        public DateTime NgayCham { get; set; }
        public DateTime? NgayChinhSua { get; set; }
        public string? GioBatDau { get; set; }
        public string? GioKetThuc { get; set; }
        public int ThangCC { get; set; }
        public int NamCC { get; set; }
    }
}
