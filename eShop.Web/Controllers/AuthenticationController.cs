using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eShop.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        [Route("/authenticate")]
        public async Task<IActionResult> Authenticate([FromQuery] string user, [FromQuery] string pwd)
        {
            if (user == "admin" && pwd == "12345")
            {
                var userClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user),
                    new Claim(ClaimTypes.Email, "admin@eshop.com"),
                    new Claim(ClaimTypes.HomePhone,"12345678")
                };
                var userIdentity = new ClaimsIdentity(userClaims, "eShop.CookieAuth");
                var userPrincipal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync("eShop.CookieAuth", userPrincipal);
            }
            return Redirect("/admin");
        }
        [Route("/logout")]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/admin");
        }
    }
}
