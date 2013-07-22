using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    [Table("UserProfile")]
    public class User
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name *")]
        [StringLength(30)]
        public string ContactFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name *")]
        [StringLength(30)]
        public string ContactLastName { get; set; }

        [Required]
        [Display(Name = "User Name*")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Email Address *")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Please enter a valid email address.")]
        [StringLength(100)]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Confirm Email Address *")]
        [Compare("EmailAddress", ErrorMessage = "The Email address and confirmation email address do not match.")]
        [StringLength(100)]
        public string ConfirmEmailAddress { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password *")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password *")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Telephone Number *")]
        [RegularExpression(@"^\(?([1-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
               ErrorMessage = "Entered phone number format is not valid.  Please try again.")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Extension")]
        [StringLength(10)]
        public string PhoneNoExtension { get; set; }
        
        [StringLength(30)]
        public string Title { get; set; }
    }
}