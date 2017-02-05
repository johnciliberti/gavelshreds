using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GavelShreds.com.Models.HomeViewModels;
using GavelShreds.com.Services;
using MailKit.Net.Smtp;

namespace GavelShreds.com.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        private readonly IEmailSender _emailSender;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Band()
        {
            return View();
        }

        public IActionResult Music()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Events()
        {

            return View();
        }

        public IActionResult Video()
        {

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            var model = new ContactModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                var message = string.Format("From: {0}{3}Email: {1}{3}Message:{3}{2}", 
                    model.UserName, model.EmailAddress, model.Message, Environment.NewLine);
                try
                {
                    await _emailSender.SendEmailAsync("gavelshreds@myonlineband.com", "Fan Question from GavelShreds", message);
                }
                catch (SmtpCommandException ex)
                {

                    model.ContactErrorMessage = ex.Message;
                    return View(model);
                }
                
                return View("ContactThanks", model);
            }
            return View(model);
        }

        public IActionResult Fans()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
