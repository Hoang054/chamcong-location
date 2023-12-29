using System.ComponentModel.DataAnnotations;

namespace Recruit.Server.Models.ModelView
{
    public class NgayCongServer
    {
        [Key]
        public int PsnPrkID { get; set; }
        public string PsnID { get; set; }
        public string PsnName { get; set; }
        public DateOnly? PsnBirthday { get; set; }

        public List<ChamCongHeaderServer> ChamCongHeaders { get; set; }
        public List<ChamCongLinesServer> ChamCongLines { get; set; }
    }
    public class ChamCongHeaderServer
    {
        public decimal MngChamCongPrkID { get; set; }
        public decimal PsnPrkID { get; set; }
        public int ThangCC { get; set; }
        public int NamCC { get; set; }

    }
    public class ChamCongLinesServer
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
