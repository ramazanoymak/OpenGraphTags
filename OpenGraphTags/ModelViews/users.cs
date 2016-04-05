using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OpenGraphTags.ModelViews
{
    public class users
    {
        [Required]
        public string ad { get; set; }
          [Required]
        public string soyad { get; set; }
          [Required]
        public string parola { get; set; }

    }
}