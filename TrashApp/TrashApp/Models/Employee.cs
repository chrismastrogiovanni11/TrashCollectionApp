using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashApp.Models
{
    public class Employee
    {
        [Key]
        public int ZipCode { get; set; }

        public int Bill { get; set; }
    }
}