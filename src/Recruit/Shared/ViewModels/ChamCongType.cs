using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruit.Shared.ViewModels
{
    public class ChamCongType
    {
        [Key]
        public int IdTypeChamCong { get; set; }
        public string? KyHieuChamCong { get; set; }
        public string? TenLoaiChamCong { get; set; }
    }
}
