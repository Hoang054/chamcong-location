using Recruit.Server.Models.ModelView;
using Recruit.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recruit.Server.Models
{
    public class NgayCong
    {
        [Key]
        public int PsnPrkID { get; set; }
        public string PsnID { get; set; }
        public string PsnName { get; set; }
        public DateOnly? PsnBirthday { get; set; }
        public List<ChamCongHeaderClient>? ChamCongHeaders { get; set; }
        public List<ChamCongLinesClient>? ChamCongLines { get; set; }
    }
    public class ChamCongHeaderClient
    {
        public decimal MngChamCongPrkID { get; set; }
        public decimal PsnPrkID { get; set; }
        public int ThangCC { get; set; }
        public int NamCC { get; set; }

    }
    public class ChamCongLinesClient
    {
        public decimal MngChamCongPrkID { get; set; }
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
