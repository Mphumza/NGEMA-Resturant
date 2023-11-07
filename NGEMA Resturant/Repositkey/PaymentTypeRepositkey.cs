using NGEMA_Resturant.Models;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NGEMA_Resturant.Repositkey
{
    public class PaymentTypeRepositkey
    {
        private ResturantDBEntities objResturantDbEntities;
        public PaymentTypeRepositkey() 
        {
         objResturantDbEntities = new ResturantDBEntities();
        

        }
        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
           var objSelectListItems = new List<SelectListItem>();
             objSelectListItems = (from obj in  objResturantDbEntities.PaymentIds
                                 select new SelectListItem()
                                 {
                                  Text= obj.PaymentTypeName,
                                  Value=obj.PaymentTypeId.ToString(),
                                  Selected = true
                                 }).ToList();

            return objSelectListItems;
        }
    }
}