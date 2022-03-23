using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tcgy_4_TimeTravelParty.Models
{
    public class Participant
    {
        [Display(Name = "Name:")]
        [Required(ErrorMessage ="Name cannot be empty!")]
        [MinLength(2,ErrorMessage ="Name must be at least 2 characters.")]
        public string Name { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage ="Last Name cannot be empty!")]
        [MinLength(2,ErrorMessage ="Last name must be at least 2 characters.")]
        public string LastName { get; set; }

        [Display(Name = "E-Mail:")]
        [Required(ErrorMessage = "E-Mail cannot be empty!")]
        [EmailAddress(ErrorMessage ="E-Mail is invalid.")]
        public string Email { get; set; }

        [Display(Name = "Living Date:")]
        [Required(ErrorMessage = "Your current date cannot be empty.")]
        public DateTime DateYouLive { get; set; }

        [Display(Name = "Participation:")]
        public bool Participation { get; set; }

        [Display(Name = "Did you get your covid shot?:")]
        public bool CovidShot { get; set; }
    }
}
