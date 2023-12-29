using Recruit.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recruit.Server.Models.ModelView
{
    public class ChamCongHeaderView
    {
        public int PsnPrkID { get; set; }
        public Double MngChamCongPrkID { get; set; }
        public int ThangCC { get; set; }
        public int NamCC { get; set; }
        public List<ChamCongTypesView> ChamCongTypes { get; set; } 
    }
    public class ChamCongTypesView
    {
        public int IdTypeChamCong { get; set; }
        public string? KyHieuChamCong { get; set; }
        public string? TenLoaiChamCong { get; set; }
    }
}
