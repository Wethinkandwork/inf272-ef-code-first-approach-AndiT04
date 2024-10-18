using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinceMiniAss1.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }

        [StringLength(250)]
        public String BrandName { get; set; }

        public ICollection<Product> Products { get; set; }

    }
 
}