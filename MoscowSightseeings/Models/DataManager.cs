using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoscowSightseeings.Models
{
    public class DataManager
    {
        private PlacesListDBEntities5 _db;

        public DataManager()
        {
            _db = new PlacesListDBEntities5();
        }

        public IQueryable<Places> GetItems()
        {
            return _db.Places;
        }

        public Places GetItemByID(Guid ID)
        {
            return _db.Places.FirstOrDefault(x => x.PlaceId == ID);
        }

    }
}