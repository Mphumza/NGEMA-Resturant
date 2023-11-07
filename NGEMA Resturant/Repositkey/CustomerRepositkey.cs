using NGEMA_Resturant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGEMA_Resturant.Repositkey
{
    public class CustomerRepositkey
    {
        private ResturantDBEntities objResturantDbEntities;
        public CustomerRepositkey()
        {
            objResturantDbEntities = new ResturantDBEntities();


        }
        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objResturantDbEntities.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerId.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }
    }
}