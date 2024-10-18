using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinceMiniAss1.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(250)]
        public String CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}