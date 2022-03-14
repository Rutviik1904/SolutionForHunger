using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.ComponentModel.DataAnnotations;



namespace Hunger.web.Models.Enums
{
    public class MyIdentityGenders
    {
        public enum MyIdentityGender
        {
            [Display(Name ="Male")]
            Male,

            [Display(Name ="Feamle")]
            Female,

            [Display(Name = "Other")]
            Other,
        }
    }
}
