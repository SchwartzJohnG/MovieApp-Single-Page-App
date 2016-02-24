using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieAppSPA.Domain.Models {
    public class Movie {

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [MaxLength(10)]
        public string Director { get; set; }
    }
}