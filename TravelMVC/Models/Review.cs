using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelMVC.Models
{
    public class Review
    {

        [Key]
        [Display(Name = "Review ID")]
        public int ReviewID { get; set; }

        [Display(Name = "Traveler Name")]
        public string TravelerName { get; set; }

        [Display(Name = "Destination")]
        public string Destination { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Review Date")]
        public DateTime ReviewDate { get; set; }


        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }



    }



}