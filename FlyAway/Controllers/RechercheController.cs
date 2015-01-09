using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyAway.Controllers
{
    public class RechercheController : Controller
    {
        FlyAwayDataEntities db = new FlyAwayDataEntities();
        // GET: Recherche
        public ActionResult Index(string searchString, string search,string datedepart, string datearrivee, string heuredepart)
        {
            var vol = from m in db.Vols select m;
            if (!string.IsNullOrEmpty(searchString))
            {
                vol = vol.Where(s => s.Depart.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(search))
            {
                vol = vol.Where(s => s.Arrivee.Contains(search));
            }

            if (!string.IsNullOrEmpty(datedepart))
            {
                vol = vol.Where(s => s.Arrivee.Contains(datedepart));
            }

            if (!string.IsNullOrEmpty(datearrivee))
            {
                vol = vol.Where(s => s.Arrivee.Contains(datearrivee));
            }

            if (!string.IsNullOrEmpty(heuredepart))
            {
                vol = vol.Where(s => s.Arrivee.Contains(heuredepart));
            }
            return View(vol);

        }
    }
}