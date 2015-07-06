using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace KiteSurfingFinalProject.Models
{
    public class ProductType
    {
        [Key]
        public int ProductTypeID { get; set; }
        public string ProductName { get; set; }

        public virtual ICollection<Product> product { get; set; }

    }
}