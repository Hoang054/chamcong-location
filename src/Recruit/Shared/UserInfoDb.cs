using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruit.Shared
{
    public class UserInfoDb
    {
        [Key]
        public int UserPrkID { get; set; }
        public string UserID { get; set; }
        public string? UserName { get; set; }
        public int UserGrpPrkID { get; set; }
        public string? UserPassword { get; set; }
        public DateTime? UserDateReg { get; set; }
        public string? UserNote { get; set; }
        public Boolean? IsActive { get; set; }
        public int? UserPsnPrkID { get; set; }
        public int? UserDeptWorkPrkID { get; set; }
        public string? UserInfoData { get; set; }
        public Boolean? IsFullRightsHSBADT { get; set; }
        public Boolean? IsAllowChangeChamCong { get; set; }
        public string? ListUserDeptWorkPrkID { get; set; }
        public string? KHOA_HANH_CHINH_PrkID { get; set; }
    }
}
