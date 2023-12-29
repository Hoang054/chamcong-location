using System.ComponentModel.DataAnnotations;

namespace Recruit.Server.Models
{
    public class ChamCongHeader
    {
        [Key]
        public decimal MngChamCongPrkID { get; set; }
        [Required]
        public decimal PsnPrkID { get; set; }
        [Required]
        public int ThangCC { get; set; }
        [Required]
        public int NamCC { get; set; }
        public int NgayCC { get; set; }
        public int? BuoiSang { get; set; }
        public int? BuoiChieu { get; set; }
        public DateTime NgayCham { get; set; }
        public DateTime? NgayChinhSua { get; set; }
        public string? GioBatDau { get; set; }
        public string? GioKetThuc { get; set; }
    }
}
