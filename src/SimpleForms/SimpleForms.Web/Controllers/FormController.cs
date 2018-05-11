using Microsoft.AspNetCore.Mvc;
using SimpleForms.Web.Helper;
using SimpleForms.Web.Models;

namespace SimpleForms.Web.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Send()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult List()
        {
            return View(Data.Contacts);
        }
        
        [HttpPost]
        public IActionResult Send(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                Data.Add(model);
                return View("Send", model);
            }
            else
            {
                return View("Index");
            }

        }
    }
}