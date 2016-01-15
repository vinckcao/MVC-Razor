using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Razor.Models
{
    public class Album
    {
        public string Title { set; get; }


        [Required(ErrorMessage = "An album title is required")]
        [StringLength(160)]
        [DataType(DataType.MultilineText)]
        public string TitleAttribute { set; get; }

        public string GenreId { set; get; }
    }
}