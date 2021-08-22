using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentalStore.Models
{
    public class Rental
    {
        // rental model 
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Contact")]
        public string Contact { get; set; }

        [Display(Name = "Date")]
        public DateTime dt { get; set; }



        public book Book { get; set; }
        
    }
}
