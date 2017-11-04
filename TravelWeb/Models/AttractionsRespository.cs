using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace TravelWeb.Models
{
    
    public class AttractionsRespository
    {
        private TravelEntities db = new TravelEntities();

        /// <summary>
        /// 取的所有資料
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Attractions> GetAll()
        {
            return db.Attractions.OrderBy(x => x.CityName);
        }

        /// <summary>
        /// 取的單一個景點的資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Attractions GetDetail(string id)
        {
            return db.Attractions.Find(id);
        }

        /// <summary>
        /// 取的景點的資料 where條件 by CityName
        /// </summary>
        /// <param name="CityName"></param>
        /// <returns></returns>
        public IEnumerable<Attractions> GetDataforCityName(Attractions data)
        {
            IQueryable<Attractions> q = db.Attractions;
            if (data.CityName != null)
            {
                q = q.Where(x => x.CityName == data.CityName);
            }
            if (data.Startdate != DateTime.MinValue || data.Enddate != DateTime.MinValue)
            {
                q = q.Where(x => x.Startdate >= data.Startdate && x.Enddate <= data.Enddate);
            }

            return q;
        }

        //public IEnumerable<Attractions> FuncName(Expression<Func<Attractions, bool>> condition)
        //{
        //    return Attractions.Where(condition);
        //}

    }
}