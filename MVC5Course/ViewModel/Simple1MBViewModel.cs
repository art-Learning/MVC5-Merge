using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.ViewModel
{
    public class Simple1MBViewModel:IValidatableObject
    {
        [Required]
        public string username { get; set; }
        
        [Required]
        public string password { get; set; }

        [Required]
        [Compare("password")]
        public string confirmpass { get; set; }

        [Required]
        public int age { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}