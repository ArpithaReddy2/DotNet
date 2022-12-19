using System.ComponentModel.DataAnnotations;

namespace MvcCustomExceptionFilter.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please choose gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter age")]
        public Nullable<int> Age { get; set; }

        [Required(ErrorMessage = "Please enter position")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Please enter you office location")]
        public string Office { get; set; }

        [Required(ErrorMessage = "Please enter your salary")]
        public Nullable<int> Salary { get; set; }
    }
}