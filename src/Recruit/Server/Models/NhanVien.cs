using Recruit.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recruit.Server.Models
{
    public class NhanVien
    {
        [Key]
        public Double STT { get; set; }
        [Column("MA_NV")]
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public Double GioiTinh { get; set; }
        public Double PsnTypeID { get; set; }
        public string CCHN { get; set; }
        //public ICollection<NgayCong> NgayCongs { get; set; }
        public ICollection<ChamCongLine>? NgayCongs { get; set; }
        public int applicantId { get; set; }
        public virtual Applicant? Applicant { get; set; }
    }
}
