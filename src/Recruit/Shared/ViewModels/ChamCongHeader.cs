using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruit.Shared.ViewModels
{
    public class ChamCongHeader
    {

        public Double MngChamCongPrkID { get; set; }
        public Double PsnPrkID { get; set; }
        public int ThangCC { get; set; }
        public int NamCC { get; set; }
        public int NgayCC { get; set; }
        public int? BuoiSang { get; set; }
        public int? BuoiChieu { get; set; }
        public int? TrangThai { get; set; }
        public DateTime NgayCham { get; set; }
        public DateTime? NgayChinhSua { get; set; }
    }
}
