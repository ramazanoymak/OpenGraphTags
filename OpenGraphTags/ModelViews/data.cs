using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OpenGraphTags.ModelViews
{
    [Serializable]
    public class data
    {
        public string baslik {get;set;}
        public string yazi { get; set; }
        public string resimUrl { get; set; }
        public string Url { get; set; }
    }
}