using System;
using System.Collections.Generic;
using System.Text;

namespace _080726Movies.Models
{
    public class TypeOfMedia
    {
        public string MediaType { get; set; } // Type of media (e.g., Movie, TV Show, Documentary)
        public string ProductionCompany { get; set; } // Production company of the media
        public string Title { get; set; } // Title of the movie
        public string Genre { get; set; }  // Genre of the movie (e.g., Action, Comedy, Drama)
        public string Tags { get; set; } // Tags associated with the movie (e.g., "Action, Adventure, Thriller")
        public string Director { get; set; } // Director of the movie
        public string Writer { get; set; } // Writer of the movie
        public int Length { get; set; }


    }
}
