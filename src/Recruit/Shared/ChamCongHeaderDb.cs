using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruit.Shared
{
    public class ChamCongHeaderDb
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public decimal MngChamCongPrkID { get; set; }
        [Required]
        public decimal PsnPrkID { get; set; }
        [Required]
        public int ThangCC { get; set; }
        [Required]
        public int NamCC { get; set; }

    }
}
