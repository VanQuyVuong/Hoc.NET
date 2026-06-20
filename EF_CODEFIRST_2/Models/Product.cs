using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EF_CODEFIRST_2.Models
{
    public class Product
    {
        public long ProductID { set; get; }
        public string ProductName { set; get; }
        public Nullable<decimal> Price { set; get; }
        public Nullable<System.DateTime> DateOfPurchase { set; get; }
        public string AvailabilityStatus { set; get; }

        public Nullable<long> BrandID { set; get; }
        public Nullable<long> CategoryID { set; get; }
        public Nullable<bool> Active { set; get; }

       // public Nullable<long> Quality { set; get; }
        public virtual Brand Brand { set; get; }
        public virtual Category Category { set; get; }

    }
}