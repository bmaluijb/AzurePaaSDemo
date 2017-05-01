using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InternationalCookies.ViewComponents
{
    public class UserViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (!string.IsNullOrEmpty(Request.Headers["X-MS-CLIENT-PRINCIPAL-NAME"]))
            {
                var user = Request.Headers["X-MS-CLIENT-PRINCIPAL-NAME"];
                ViewData.Add("name", user);
            }

            return View();
        }
    }
}
