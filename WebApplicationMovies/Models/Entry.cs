using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplicationMovies.Models
{
    [Table("ENTRY")]
    public class Entry
    {

 
        [Column("entry_id")]
        public int EntryID { get; set; }

        [Required]
        [Column("entry_fname")]
        [Display(Name = "First Name")]
        public string EntryFname { get; set; }

        [Required]
        [Column("entry_sname")]
        [Display(Name = "Surname")]
        public string EntrySname { get; set; }

        [Required]
        [Display(Name = "Bio")]
        [DataType(DataType.MultilineText)]
        [Column("entry_desc")]
        public string EntryDesc { get; set; }

        [Column("entry_img")]
        [Display(Name = "Profile Image")]
        public string EntryImage { get; set; }



        public string EntryDescTrimmed
        {
            get
            {

                if ((EntryDesc.Length) > 100)

                    return EntryDesc.Substring(0, 100) + "...";
                else
                    return EntryDesc; 
            }
        }

  
    }
}