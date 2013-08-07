using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Class14_MVC.Models;

namespace Class14_MVC.Controllers
{
    public class BlogApiController : ApiController
    {
        private BloggingContext db = new BloggingContext();

        // GET api/BlogApi
        public IEnumerable<Blog> GetBlogs()
        {
            return db.Blogs.AsEnumerable();
        }

        // GET api/BlogApi/5
        public Blog GetBlog(int id)
        {
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return blog;
        }

        // PUT api/BlogApi/5
        public HttpResponseMessage PutBlog(int id, Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != blog.BlogId)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(blog).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/BlogApi
        public HttpResponseMessage PostBlog(Blog blog)
        {
            if (ModelState.IsValid)
            {
                db.Blogs.Add(blog);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, blog);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = blog.BlogId }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/BlogApi/5
        public HttpResponseMessage DeleteBlog(int id)
        {
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Blogs.Remove(blog);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, blog);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}