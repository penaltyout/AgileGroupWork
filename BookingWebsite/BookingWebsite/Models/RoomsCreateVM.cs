using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingWebsite.Models
{
    public class RoomsCreateVM
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "*Name required")]
        public string Name { get; set; }

        [Display(Name = "Grade")]
        [Required(ErrorMessage = "*Grade required")]
        public string Grade { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "*Price required")]
        public double Price { get; set; }

        [Display(Name = "Size")]
        [Required(ErrorMessage = "*Size required")]
        public int Size { get; set; }

        [Display(Name = "Smoker or non-smoker")]
        [Required(ErrorMessage = "*Smoker required")]
        public bool Smoker { get; set; }

        [Display(Name = "Breakfast incl.")]
        [Required(ErrorMessage = "*Breakfast required")]
        public bool Breakfast { get; set; }

        [Display(Name = "Wi-Fi")]
        [Required(ErrorMessage = "*Wi-Fi required")]
        public bool Wifi { get; set; }
    }
}
