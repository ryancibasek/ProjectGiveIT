using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    [Table("Charity")]
    public class Charity : User
    {
        [Required]
        [Display(Name = "Charity Name *")]
        [StringLength(100)]
        public string CharityName { get; set; }
        
        [Display(Name = "Mission, Location of Population Served")]
        [DataType(DataType.MultilineText)]
        public string MissionAndLocation { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}-\d{7}$",
               ErrorMessage = "EIN entered is not valid. Please try again.")]
        [StringLength(10)]
        public string EIN { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(80)]
        public string StreetAddress { get; set; }

        [Display(Name = "Street Address 2")]
        [StringLength(80)]
        public string StreetAddress2 { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [RegularExpression(@"^(\d{5}-\d{4}|\d{5}|\d{9})$|^([a-zA-Z]\d[a-zA-Z] \d[a-zA-Z]\d)$",
            ErrorMessage = "Please enter a valid zip code consists of 5 or 9 numeric characters.")]
        [StringLength(10)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
    }
}
