using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recruit.Shared
{
    public class ChamCongLineDb
    {
        

        [Key]
        public decimal? MngChamCongPrkID { get; set; }
        public int NgayCC { get; set; }
        public int? BuoiSang { get; set; }
        public int? BuoiChieu { get; set; }
        public DateTime NgayCham { get; set; }
        public DateTime? NgayChinhSua { get; set; }
        public string? GioBatDau { get; set; }
        public string? GioKetThuc { get; set; }
        public int? UserWritePrkID { get; set; }
        public string? ComputerIP { get; set; }
        public string? ComputerName { get; set; }
}
}
