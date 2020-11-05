using System.Threading.Tasks;

namespace SitePiranhaCMS.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string messages);
    }
}
