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

    public IActionResult CalculateForm()
    {
        var vm = new ScoreViewModel { Scores = new List<int>(new int[10]) };
        return View(vm);
    }

    [HttpPost]
    public IActionResult CalculateForm(ScoreViewModel form)
    {
        if (form.Scores != null && form.Scores.Count > 0)
        {
            form.TotalScore = form.Scores.Sum();
            
            // Determine grade based on total score
            if (form.TotalScore >= 800)
                form.Grade = "A";
            else if (form.TotalScore >= 700)
                form.Grade = "B";
            else if (form.TotalScore >= 600)
                form.Grade = "C";
            else if (form.TotalScore >= 500)
                form.Grade = "D";
            else
                form.Grade = "F";
        }

        ViewBag.UserId = userList.LastOrDefault()?.UserId;
        ViewBag.TotalScore = form.TotalScore;
        ViewBag.Grade = form.Grade;
        
        return View(form);
    }

    public IActionResult MyDetails()
    {
        ViewBag.FirstName = "สมชาย";
        ViewBag.LastName = "คุณากร";
        ViewBag.StudentId = "6607507xxx";
        ViewBag.Age = 20;
        ViewBag.Email = "somchai@example.com";
        ViewBag.PhoneNumber = "0812345678";
        ViewBag.Department = "วิทยาศาสตร์คอมพิวเตอร์";
        ViewBag.Address = "123 ถนนประชาชาติ กรุงเทพฯ 10110";

        return View();
    }
}
