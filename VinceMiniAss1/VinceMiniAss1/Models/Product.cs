using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Security;

namespace VinceMiniAss1.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(250)]
        public String ProductName { get; set; }

        [Range(1886, 9999, ErrorMessage = "Model year must be between 1886 and the current year or next year.")]
        public int ProductModelYear { get; set; }

        [Required]
        public int ProductListPrice { get; set; }

        //FK 
        public int? BrandID { get; set; }
        public virtual Brand Brand { get; set; }

        //FK 
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Stock> Stocks { get; set; }
    }
}