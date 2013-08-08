using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class15_Todo.Controllers
{
    public class ManuelController : Controller
    {
        //
        // GET: /Manuel/


        // Controllers within the MVC pattern are responsible for responding to user input, often making
        // changes to the model in response to user input. In this way, controllers in the MVC pattern are concerned
        // with the fl ow of the application, working with data coming in, and providing data going out
        // to the relevant view.




        public string Index()
        {
            return "Hola";
        }

        public string Detalles(int id)
        {
            return "He recibido el numero:" + id;
        }






        public ViewResult Index2()
        {
            ViewBag.UnParametro= "Pasando Params";
            return View();
            //return View("View1");
        }

    }
}
