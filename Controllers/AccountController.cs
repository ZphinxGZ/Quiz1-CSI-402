using Microsoft.AspNetCore.Mvc;
using Quiz_5070_Kunakorn.Models;

namespace Quiz_5070_Kunakorn.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        var vm = new UserViewModel();
        return View(vm);
    }

    [HttpPost]
    public IActionResult Login(UserViewModel form)
    {
        if (!string.IsNullOrWhiteSpace(form.UserId))
        {
            StudentController.userList.Add(new UserViewModel
            {
                UserId = form.UserId,
                password = form.password
            });
        }
        return RedirectToAction("Index", "Student");
    }

    public IActionResult StudentList()
    {
        return View();
    }
}