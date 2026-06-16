using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EF_CODEFIRST.Models
{
    public class Category
    {
        [Key]
        public long CategoryID { set; get; }
        public string CategoryName { set; get; }

    }
}