using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Class15_Todo.Models;
using Class15_Todo.ViewModels;

namespace Class15_Todo.Controllers
{
    public class TodoController : Controller
    {
        private TodoDatabaseEntities db = new TodoDatabaseEntities();




        //
        // GET: /Todo/

        public ActionResult Index()
        {

            TodoViewModel viewModel = new TodoViewModel();
            viewModel.TodoList = db.Todos.ToList();
            viewModel.TodoNew = db.Todos.Add(new Todo());
            return View(viewModel);
            //return View(db.Todos.ToList());
        }

        //
        // POST: /Todo/Index

        [HttpPost]
        public ActionResult Index(TodoViewModel todoViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Todos.Add(todoViewModel.TodoNew);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(todoViewModel);
        }









        //
        // GET: /Todo/Details/5

        public ActionResult Details(int id = 1)
        {
            Todo todo = db.Todos.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        //
        // GET: /Todo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Todo/Create

        [HttpPost]
        public ActionResult Create(Todo todo)
        {
            if (ModelState.IsValid)
            {
                db.Todos.Add(todo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(todo);
        }

        //
        // GET: /Todo/Edit/5

        public ActionResult Edit(int id = 1)
        {
            Todo todo = db.Todos.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        //
        // POST: /Todo/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Todo todo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(todo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todo);
        }

        //
        // GET: /Todo/Delete/5

        public ActionResult Delete(int id = 1)
        {
            Todo todo = db.Todos.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        //
        // POST: /Todo/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Todo todo = db.Todos.Find(id);
            db.Todos.Remove(todo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}