using NGEMA_Resturant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGEMA_Resturant.Repositkey
{
    public class ItemRepositkey
    {
        private ResturantDBEntities objResturantDbEntities;
        public ItemRepositkey()
        {
            objResturantDbEntities = new ResturantDBEntities();


        }
        public IEnumerable<SelectListItem> GetAllItems()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objResturantDbEntities.Items
                                  select new SelectListItem()
                                  {
                                      Text = obj.ItemName,
                                      Value = obj.ItemId.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }
    }
}