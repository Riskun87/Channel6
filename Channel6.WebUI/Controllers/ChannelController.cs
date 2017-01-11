/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Channel6.Dal.Concrete;
using Channel6.Dal.Entities;
using System.Security.Claims;
using System.Data.Entity;

namespace Channel6.WebUI.Controllers
{
    public class ChannelController : Controller
    {
        // GET: Channel
        public ActionResult Index()
        {
            var db = new EFDbContext();
            return View(db.Channels.ToList());
        }

        [HttpPost]
        public ActionResult Index(Channel channel)
        {
            if (ModelState.IsValid)
            {
                using (var db = new EFDbContext())
                {
                    Claim sessionEmail = ClaimsPrincipal.Current.FindFirst(ClaimTypes.Email);
                    string userEmail = sessionEmail.Value;
                    var userIdQuery = db.Users.Where(u => u.Email == userEmail).Select(u => u.Id);
                    var userId = userIdQuery.ToList();
                    Channel dbChannel = new Channel();

                    if (Request.Form["id"] != null)
                    {
                        dbChannel = db.Channels.Find(Int32.Parse(Request.Form["id"]));
                    }
                    else
                    {
                        dbChannel = db.Channels.Create();
                        dbChannel.UserId = userId[0];
                        dbChannel.DateAdded = DateTime.Now;
                    }
                    
                    dbChannel.Name = Request.Form["name"];
                    dbChannel.Website = Request.Form["website"];
                    dbChannel.Resource = Request.Form["resource"];
                    
                    switch (Request.Form["Type"])
                    {
                        case "RSS":
                            dbChannel.Type = ChannelType.RSS;
                            break;
                        case "Youtube":
                            dbChannel.Type = ChannelType.Youtube;
                            break;
                    }

                    if (Request.Form["id"] != null)
                    {
                        db.Entry(dbChannel).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Channels.Add(dbChannel);
                    }

                    db.SaveChanges();
                }
            }
            else
            {
                ModelState.AddModelError("", "Incorrect format has been placed");
            }

            var listTable = new EFDbContext();
            return View(listTable.Channels.ToList());
        }

        [HttpGet]
        public ActionResult Edit (int id)
        {
            var db = new EFDbContext();

            var model = new Channel();
            model = db.Channels.Find(id);

            ViewBag.model = model;
            return View(db.Channels.ToList());
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var db = new EFDbContext();
            var model = db.Channels.Find(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            db.Channels.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
*/