using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenGraphTags.ModelViews;

namespace OpenGraphTags.Controllers
{
    public class anasayfaController : Controller
    {
        //
        // GET: /anasayfa/
        data veri = new data();
        public ActionResult Index()
        {
            veri.baslik = "Open Graph Tagları ile Çalışma";
            veri.yazi = "Open Graph Meta Etiketleri kısaca  bizlere sosyal medyada yaptığımız paylaşımların sadece bizim gözükmesini istediğimiz kısımlarının gösterilmesini sağlar..";
            veri.resimUrl = "/Content/indir.jpg";
            veri.Url = "http://localhost:49822/";
            return View(veri);
        }

    }
}
