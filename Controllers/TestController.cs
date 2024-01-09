using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.Controllers;

public class TestController : Controller
{
    public IActionResult Test()
    {
        return View();
    }
 
    public IActionResult Form(Test test)
    {
        if (ModelState.IsValid)
        {
             return  Content(test.Name);
        }
        else
        {
            return RedirectToAction("Test");
        }
    }
}