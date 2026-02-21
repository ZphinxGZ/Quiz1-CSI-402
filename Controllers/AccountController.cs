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
        var students = new List<StudentDetailsViewModel>
        {
            new StudentDetailsViewModel { FirstName = "สมชาย", LastName = "คุณากร", StudentId = "6607507001", Age = 20, Email = "somchai1@example.com", PhoneNumber = "0812345678", Department = "วิทยาศาสตร์คอมพิวเตอร์", Address = "123 ถนนประชาชาติ กรุงเทพฯ" },
            new StudentDetailsViewModel { FirstName = "สมหญิง", LastName = "ปัญญา", StudentId = "6607507002", Age = 19, Email = "somying@example.com", PhoneNumber = "0823456789", Department = "วิทยาศาสตร์คอมพิวเตอร์", Address = "456 ถนนวิทยุ กรุงเทพฯ" },
            new StudentDetailsViewModel { FirstName = "วิชัย", LastName = "มหาชน", StudentId = "6607507003", Age = 21, Email = "vichai@example.com", PhoneNumber = "0834567890", Department = "วิทยาศาสตร์คอมพิวเตอร์", Address = "789 ถนนรามคำแหง กรุงเทพฯ" },
            new StudentDetailsViewModel { FirstName = "นิดา", LastName = "สุขสมบูรณ์", StudentId = "6607507004", Age = 20, Email = "nida@example.com", PhoneNumber = "0845678901", Department = "วิทยาศาสตร์คอมพิวเตอร์", Address = "321 ถนนสุขุมวิท กรุงเทพฯ" },
            new StudentDetailsViewModel { FirstName = "ธนพัฒน์", LastName = "อัฑฒโณ", StudentId = "6607507005", Age = 19, Email = "thanaphat@example.com", PhoneNumber = "0856789012", Department = "วิทยาศาสตร์คอมพิวเตอร์", Address = "654 ถนนเพชรบุรี กรุงเทพฯ" },
            new StudentDetailsViewModel { FirstName = "จิตรา", LastName = "ศรีสม", StudentId = "6607507006", Age = 20, Email = "chitra@example.com", PhoneNumber = "0867890123", Department = "วิทยาศาสตร์คอมพิวเตอร์", Address = "987 ถนนสีลม กรุงเทพฯ" },
            new StudentDetailsViewModel { FirstName = "กิตศ", LastName = "พิมพ์สุข", StudentId = "6607507007", Age = 21, Email = "kitsak@example.com", PhoneNumber = "0878901234", Department = "วิทยาศาสตร์คอมพิวเตอร์", Address = "147 ถนนพญาไท กรุงเทพฯ" },
            new StudentDetailsViewModel { FirstName = "อมรา", LastName = "ทิพย์สม", StudentId = "6607507008", Age = 20, Email = "amara@example.com", PhoneNumber = "0889012345", Department = "วิทยาศาสตร์คอมพิวเตอร์", Address = "258 ถนนคนธอง กรุงเทพฯ" }
        };

        ViewBag.UserId = StudentController.userList.LastOrDefault()?.UserId;
        return View(students);
    }
}