using NGEMA_Resturant.Repositkey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NGEMA_Resturant.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
              CustomerRepositkey objCustomerRepositkey= new CustomerRepositkey();
              ItemRepositkey objItemRepositkey= new ItemRepositkey();
              PaymentTypeRepositkey objPaymentTypeRepositkey = new PaymentTypeRepositkey();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
               (objCustomerRepositkey.GetAllCustomers(), objItemRepositkey.GetAllItems(), objPaymentTypeRepositkey.GetAllPaymentType());

            return View(objMultipleModels);
        }
    }
}