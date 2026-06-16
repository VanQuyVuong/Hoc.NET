using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace EF_CODEFIRST.Models
{
    public class Brand
    {
        [Key]
        public long BrandID { set; get; }
        public string BrandName { set; get; }
    

    }
}