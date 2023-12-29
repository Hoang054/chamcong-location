using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruit.Shared
{
    public class UserGrpDb
    {
        [Key]
        public int UserGrpPrkID { get; set; }
        public string UserGrpID { get; set; }
        public string? UserGrpName { get; set; }
        public string? UserGrpNote { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsActive { get; set; }
        public string? XmlMenuAcept { get; set; }
    }
}