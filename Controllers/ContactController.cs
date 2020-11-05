using Microsoft.AspNetCore.Mvc;
using SitePiranhaCMS.Services;
using System.Threading.Tasks;

namespace SitePiranhaCMS.Web.Controllers
{
    public class ContactController : Controller
    {

        private readonly IEmailSender _emailSender;

        public ContactController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task SendMail(string toEmail, string subject, string message)
        {
            await _emailSender.SendEmailAsync(toEmail, subject, message);
        }
    }
}