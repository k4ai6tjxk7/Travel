using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelWeb.Models
{
    
    public class AttractionsImgRespository
    {
        private TravelEntities db = new TravelEntities();

        /// <summary>
        /// 取的所有資料
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AttractionsImg> GetAll()
        {
            return db.AttractionsImg;
        }

        /// <summary>
        /// 取的單一個景點的圖片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<AttractionsImg> GetDetail(string id)
        {
            return db.AttractionsImg.Where(x => x.id == id);
        }

        public IEnumerable<AttractionsImg> GetDataforCityName(Attractions data)
        {
            IQueryable<AttractionsImg> q = db.AttractionsImg;

            if (data.CityName != null)
            {
                q = q.Where(x => x.Attractions.CityName == data.CityName);
            }
            if (data.Startdate != DateTime.MinValue || data.Enddate != DateTime.MinValue)
            {
                q = q.Where(x => x.Attractions.Startdate >= data.Startdate && x.Attractions.Enddate <= data.Enddate);
            }
            //var aa = db.AttractionsImg.Where(x => x.Attractions.CityName == data.CityName);
            return q;

        }
    }
}