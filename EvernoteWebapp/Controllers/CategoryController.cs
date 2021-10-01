using Evernote.BusinessLayer;
using Evernote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EvernoteWebapp.Controllers
{
    public class CategoryController : Controller
    {
        // TempData ile Category listeleme

        //// GET: Category
        //public ActionResult Select(int? id)
        //{
        //    if(id == null)
        //    {
        //        // 404 gibi kodları döndürmemizi sağlıyor.
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CategoryManager cm = new CategoryManager();
        //        // Id nullable tip'tir. Tip uyuşmazlığından kaynaklı hata veriyordu. Biz de bu yüzden .Value ekledik.
        //    EvernoteCategory category = cm.GetCategoryById(id.Value);

        //    if(category == null)
        //    {
        //        return HttpNotFound();
        //    }

        //        // Farklı bir controller'dan bir başka controller'a erişim sağlamak ve model göndermemiz gerekiyor. Link'te selecek controller'ı istedik.
        //        // TempData bir action'dan bir başka action'a geçerken verileri öldürmüyor.
        //    TempData["mm"] = category.Notes;
        //    return RedirectToAction("Index", "Home");
        //}
    }
}