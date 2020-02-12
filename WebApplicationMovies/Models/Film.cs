using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplicationMovies.Models
{   [Table("FILM")]
    public class Film
    {
        [Column("film_id")]
        public int FilmID { get; set; }
        [Column("film_title")]
        public string FilmTitle { get; set; }
        [Column("film_genre")]
        public string FilmGenre { get; set; }
        [Column("film_desc")]
        public string FilmDesc { get; set; }
        [Column("film_date")]
        public DateTime FilmReleaseDate { get; set; }
        [Column("film_img")]
        public string FilmImage { get; set; }


        public string FilmSecTrimmed;

    }
}