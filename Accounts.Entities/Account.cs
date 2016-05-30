using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Entities
{
   public class Account
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string firstname { get; set; }
        [Required]
        [StringLength(255)]
        public string lastname { get; set; }
        [Required]
        [StringLength(255)]
        public string adress { get; set; }
    }
}
