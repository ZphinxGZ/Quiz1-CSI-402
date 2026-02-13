using Microsoft.AspNetCore.Mvc;
using Quiz_5070_Kunakorn.Models;

namespace Quiz_5070_Kunakorn.Controllers;

public class StudentController : Controller
{
    public static List<UserViewModel> userList = new()
    {
        new UserViewModel { UserId = "user1", password = "pass123" },
        new UserViewModel { UserId = "user2", password = "pass123" },
        new UserViewModel { UserId = "user3", password = "pass123" },
        new UserViewModel { UserId = "user4", password = "pass123" },
        new UserViewModel { UserId = "user5", password = "pass123" },
        new UserViewModel { UserId = "user6", password = "pass123" },
        new UserViewModel { UserId = "user7", password = "pass123" },
        new UserViewModel { UserId = "user8", password = "pass123" }
    };
    
    public IActionResult Index()
    {
        var vm = new UserViewModel
        {
            Users = userList
        };
        ViewBag.UserId = userList.LastOrDefault()?.UserId;
        return View(vm);
    }
    
    public IActionResult StudentList()
    {
        var vm = new UserViewModel
        {
            Users = userList
        };
        ViewBag.UserId = userList.LastOrDefault()?.UserId;
        return View(vm);
    }
}