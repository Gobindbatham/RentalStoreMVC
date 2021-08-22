using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentalStore.Models
{
    public class book
    {
        // books table model
        public int id { get; set; }

        [Display(Name = "Book Name")]
        public string BName { get; set; }


        [Display(Name = "Subject ")]
        public string Subject { get; set; }


        [Display(Name = "No of Pages ")]
        public string NPage { get; set; }

        public Author author { get; set; }
        public Publisher publisher { get; set; }

    }
}
