using HomeWork5.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork5.Controllers
{
    public class FriendController : Controller
    {
        public static List<Friend> Friends = new List<Friend>() 
            { 
                new Friend() { FriendId = 0, FriendName = "Diana", Place = "Kyiv" },
                new Friend() { FriendId = 1, FriendName = "Sam", Place = "Helsinki" },
                new Friend() { FriendId = 2, FriendName = "Mark", Place = "Berlin" },
                new Friend() { FriendId = 3, FriendName = "Milana", Place = "Budapest" },
                new Friend() { FriendId = 4, FriendName = "Robert", Place = "Monreal" }
            };

        public static int Id;

        public IActionResult Index()
        {
             return View(Friends);
        }

        public IActionResult Insert()
        {
            return View("Insert");
        }

        [HttpPost]
        public IActionResult Insert(Friend friend)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            Friends.Add(friend);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var fr = Friends.Where(f => f.FriendId == id).FirstOrDefault();
            Id = id;
            return View(fr);
        }

        [HttpPost]
        public IActionResult Edit(Friend friend)
        {
            var fr = Friends.Where(f => f.FriendId == Id).FirstOrDefault();
            fr.FriendId = friend.FriendId;
            fr.FriendName = friend.FriendName;
            fr.Place = friend.Place;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var fr = Friends.Where(f => f.FriendId == id).FirstOrDefault();
            Id = id;
            return View(fr);
        }

        [HttpPost]
        public IActionResult Delete()
        {
            var fr = Friends.Where(f => f.FriendId == Id).FirstOrDefault();
            Friends.Remove(fr);
            return RedirectToAction("Index");
        }
    }
}
