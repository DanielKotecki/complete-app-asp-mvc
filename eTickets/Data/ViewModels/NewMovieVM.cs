using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTickets.Data.Base;
using eTickets.Data.Enums;
using eTickets.Models;
using Newtonsoft.Json;

namespace eTickets.Data.ViewModels
{
    public class NewMovieVM
    {
        [Display(Description = "Movie name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Display(Description = "Movie Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        [Display(Description = "Movie Price")]
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }

        [Display(Description = "Movie Image")]
        [Required(ErrorMessage = "Poster Url is Required")]
        public string ImageURL { get; set; }

        [Display(Description = "Movie Start Date")]
        [Required(ErrorMessage = "Start Date is Required")]
        public DateTime StartDate { get; set; }

        [Display(Description = "Movie End date")]
        [Required(ErrorMessage = "End date is Required")]
        public DateTime EndDate { get; set; }

        [Display(Description = "Selcet category")]
        [Required(ErrorMessage = "Category selected is required")]
        public MovieCategory MovieCategory { get; set; }

        [Display(Description = "Selcet actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is required")]
        public List<int> ActorIds { get; set; }

        [Display(Description = "Selcet cinema(s)")]
        [Required(ErrorMessage = "Movie cinema(s) is required")]
        public int CinemaId { get; set; }

        [Display(Description = "Selcet producer(s)")]
        [Required(ErrorMessage = "Movie producer(s) is required")]
        public int ProducerId { get; set; }

        public int Id { get; set; }
    }
}