using Recruit.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recruit.Shared
{
    public class PersonnelsDb
    {
        [Key]
        public int PsnPrkID { get; set; }
        public string PsnID { get; set; }
        public string PsnName { get; set; }
        //public DateOnly? PsnBirthday { get; set; }
        //public string? PsnSexID { get; set; }
        //public string? PsnPlace { get; set; }
        //public string? PsnRacePrkID { get; set; }
        //public string? PsnAddr { get; set; }
        //public string? PsnCountryPrkID { get; set; }
        //public string? PsnFunction { get; set; }
        //public string? PsnPhone { get; set; }
        //public string? PsnEmail { get; set; }
        //public string? PsnTypeID { get; set; }
        //public string? DeptPrkID { get; set; }
        //public DateOnly? DateStartWork { get; set; }
        //public DateOnly? DateStopWork { get; set; }
        //public string? Note { get; set; }
        //public bool? IsActive { get; set; }
        //public string? Chucvu { get; set; }
        //public DateOnly? NgayVaoDang { get; set; }
        //public string? ChuyenMon { get; set; }
        //public string? ChuyenNganh { get; set; }
        //public string? DocJobRegNum { get; set; }
        //public string? PsnCardID { get; set; }
        //public string? PsnFunctionCardID { get; set; }
        //public string? PsnInsNum { get; set; }
        //public string? ChucvuID { get; set; }
        //public string? ChuyenmonPrkID { get; set; }
        //public string? UserNameDTDT { get; set; }
        //public string? PassWordDTDT { get; set; }
        //public string? MaBHXH { get; set; }
        //public string? PsnNameIns { get; set; }
        //public string? KHOA_HANH_CHINH_PrkID { get; set; }
        //public DateOnly? PsnBirthday { get; set; }
        //public ICollection<ChamCongHeaderDb>? ChamCongHeaders { get; set; }
        //public ICollection<ChamCongLineDb>? ChamCongLines { get; set; }
        //public virtual Applicant? Applicant { get; set; }
    }
}
