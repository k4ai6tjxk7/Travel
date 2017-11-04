using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelWeb.Models;
using TravelWeb.ViewModel;

namespace TravelWeb.Controllers
{
    public class TravelController : Controller
    {
        private AttractionsImgRespository AttractionsImgData = new AttractionsImgRespository();
        private AttractionsRespository AttractionsData = new AttractionsRespository();
        // GET: Travel
        public ActionResult Index()
        {
            TravelViewModel TravelViewModelData = new TravelViewModel()
            {
                Attractionslist = AttractionsData.GetAll(),
                AttractionsImglist = AttractionsImgData.GetAll()
            };
            if (TravelViewModelData == null)
            {
                return HttpNotFound();
            }
            return View(TravelViewModelData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Attractions Data)
        {
            if (Data == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (Data.CityName != null && Data.CityName.Trim().Substring(0, 1) == "台")
            {
                Data.CityName = Data.CityName.Replace('台', '臺');
            }

            
            TravelViewModel TravelViewModelData = new TravelViewModel()
            {
                Attractionslist = AttractionsData.GetDataforCityName(Data),
                AttractionsImglist = AttractionsImgData.GetDataforCityName(Data)
            };
            if (TravelViewModelData == null)
            {

                return HttpNotFound();
            }
            return View(TravelViewModelData);
        }
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelDetailViewModel TravelViewModelData = new TravelDetailViewModel()
            {
                Attractions = AttractionsData.GetDetail(id),
                AttractionsImglist = AttractionsImgData.GetDetail(id)
            };
            if (TravelViewModelData == null)
            {
                return HttpNotFound();
            }
            return View(TravelViewModelData);
        }
    }
}