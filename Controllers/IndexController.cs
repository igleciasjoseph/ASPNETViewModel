using Microsoft.AspNetCore.Mvc;
using viewModelFun.Models;
using System.Collections.Generic;
namespace viewModelFun.Controllers
{
    public class IndexController : Controller {
        [HttpGet("")]
        public IActionResult Index() {
            String stringModel = new String(){
                stringModel = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Aliquid architecto repellat consequuntur sit odio quos culpa reprehenderit vitae, eaque modi tempore repudiandae? Quas eos iste molestias itaque voluptate asperiores odio. Lorem ipsum dolor sit amet consectetur adipisicing elit. Odio, dolor necessitatibus harum repudiandae hic et officiis voluptatem nostrum ad excepturi libero aliquam reiciendis deleniti accusamus consectetur ullam eum perspiciatis temporibus corporis autem voluptates? Magni placeat incidunt fuga suscipit modi adipisci doloremque exercitationem consequatur velit inventore facilis atque esse optio officiis asperiores doloribus nam nobis illo, ipsa tempora mollitia possimus nisi? Accusamus quia eaque molestias delectus dolore recusandae explicabo facere molestiae."
            };
            return View(stringModel);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers() {
            NumArray numarray = new NumArray();
            numarray.numarray = new int[] {
                1,
                2,
                3,
                4,
                5,
            };
            return View(numarray);
        }

        [HttpGet("user")]
        public IActionResult OneUser() {
            User someUser = new User(){
                FirstName = "John",
                LastName = "Doe"
            };
            return View(someUser);
        }
        [HttpGet("users")]
        public IActionResult AllUsers() {
            User someUser = new User()
            {
                FirstName = "John",
                LastName = "Doe"
            };
            User someUser2 = new User()
            {
                FirstName = "Jane",
                LastName = "Doe"
            };
            User someUser3 = new User()
            {
                FirstName = "R",
                LastName = "J"
            };
            User someUser4 = new User()
            {
                FirstName = "Leo",
                LastName = "Zheng"
            };
            User someUser5 = new User()
            {
                FirstName = "Caleb",
                LastName = "Kim"
            };
            User userlist = new User();
            userlist.userlist = new List<User>();
            userlist.userlist.Add(someUser);
            userlist.userlist.Add(someUser2);
            userlist.userlist.Add(someUser3);
            userlist.userlist.Add(someUser4);
            userlist.userlist.Add(someUser5);
            return View(userlist);
        }
    }
}