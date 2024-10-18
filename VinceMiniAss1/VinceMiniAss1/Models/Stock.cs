using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinceMiniAss1.Models
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }

        [Range(1,1000)]
        public int Quantity { get; set; }

        //FK
        public int? StoreID { get; set; }
        public virtual Store Store { get; set; }

        //FK
        public int? ProductID { get; set; }
        public virtual Product Product { get; set; }

    }
}