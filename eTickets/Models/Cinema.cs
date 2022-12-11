using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using eTickets.Data.Base;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key] public int Id { get; set; }
        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Cinema logo is required")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Cinema Name is required")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema description is required")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}