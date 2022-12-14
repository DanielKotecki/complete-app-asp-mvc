using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using eTickets.Data.Base;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key] 
        public int Id { get; set; }
        [Display(Name = "Profile Picture Url")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50,MinimumLength = 3,ErrorMessage = "Min char is 3 char max char is 50")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }
    }
}