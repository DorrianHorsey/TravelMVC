using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelMVC.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Attraction { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }

}