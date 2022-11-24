using BioskopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioskopMVC.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Index()
        {
            var members = Details();

            return View(members);
        }

        public IEnumerable<Member> Details()
        {
            List<Member> members = new List<Member>
            {
                new Member
                {
                    Id = 1,
                    FirstName = "Pera",
                    LastName = "Peric",
                    PersonalNumber = "0123456789",
                    Adress = "Rumenacka 7"

                }, new Member
                {
                    Id = 2,
                    FirstName = "Sima",
                    LastName = "Simic",
                    PersonalNumber = "9876543210",
                    Adress = "Laze Nancica 4"

                }
            };
            return members;
   
        }

        public ActionResult GetMember(int id)
        {
            var member = Details().SingleOrDefault(q => q.Id == id);

            return View(member);
        }
    }
}