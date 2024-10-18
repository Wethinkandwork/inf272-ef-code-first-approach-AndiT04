using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinceMiniAss1.Models
{
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }

        [StringLength(250)]
        public String FirstName { get; set; }

        [StringLength(250)]
        public String LastName { get; set; }

        [StringLength(250)]
        public String Email { get; set; }

        [StringLength(10)]
        public String Phone { get; set; }

        [Required]
        public bool Active { get; set; }

        //FK
        public int? StoreID { get; set; }
        public virtual Store Store { get; set; }
    }
}