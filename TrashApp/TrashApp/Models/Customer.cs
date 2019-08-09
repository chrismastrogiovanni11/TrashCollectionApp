using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashApp.Models
{
    
    public class Customer
    {
        [Key]
        public string ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }


        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }


        [Display(Name = "City")]
        public string City { get; set; }


        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Start Date")]
        public string StartDate { get; set; }

        [Display(Name = "End Date")]
        public int EndDate { get; set; }

        [Display(Name = "Pick Up Day")]
        public int PickUpDay { get; set; }

        [Display(Name = "Special One Time Pick Up")]
        public int SpecialPickUpDay { get; set; }

        [Display(Name = "Balance")]
        public int Bill { get; set; }


        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}