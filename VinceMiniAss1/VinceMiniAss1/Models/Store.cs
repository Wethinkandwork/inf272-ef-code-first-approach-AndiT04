using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinceMiniAss1.Models
{
    public class Store
    {
        [Key]
        public int StoreID { get; set; }

        [StringLength(250)]
        public String StoreName { get; set; }

        [StringLength(10)]
        public String Phone { get; set; }

        [StringLength(250)]
        public String Email { get; set; }

        [StringLength(250)]
        public String Street { get; set; }

        [StringLength(250)]
        public String City { get; set; }

        [StringLength(250)]
        public String State { get; set; }

        [Required]
        public String ZipCode { get; set; }

        public ICollection<Staff> Staffs { get; set; }

        public ICollection<Stock> Stocks { get; set; }
    }
}