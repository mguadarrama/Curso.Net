using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Class15_Todo.Models;

namespace Class15_Todo.Controllers
{
    public class ManuelController : Controller
    {
        private TodoDatabaseEntities db = new TodoDatabaseEntities();

        //
        // GET: /Manuel2/

        public string Index()
        {
            return "Hola";
        }

        public string Detalles(int id)
        {
            return "He recibido el numero:" + id;
        }

        public ActionResult DetallesVista()
        {
            ViewBag.Friki = "Hola Planetas";
            return View();
        }


        public ActionResult Detalles()
        {
            var todo = db.Todos.Find(9);
            return View(todo);
        }


        public ActionResult Helpers()
        {
            return View();
        }
    
    
    }
}
