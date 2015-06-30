using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace KiteSurfingFinalProject.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public int ProductTypeID { get; set; }
        public string UserID { get; set; }
        public string Company { get; set; }
        public decimal Size { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public virtual User user { get; set; }
        public virtual ICollection<ProductType> ProductType { get; set; }

    }
}