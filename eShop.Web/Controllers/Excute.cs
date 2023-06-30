using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;
namespace eShop.Web.Controls
{
    public class ProductExecute : Controller
    {
        ThemSanPhamController product = new ThemSanPhamController();
        [Route("/Them")]
        public async Task<IActionResult> Insert([FromQuery] int ProductId, [FromQuery] string Brand, [FromQuery] string Name, [FromQuery] double Price,
                            [FromQuery] string ImageLink, [FromQuery] string Description)
        {
            product.Insert(ProductId, Brand, Name, Price, ImageLink, Description);

            var userClaims = new List<Claim>()
            {
            };

            var userIdentity = new ClaimsIdentity(userClaims, "eShop.CookieAuth");
            var userPrincipal = new ClaimsPrincipal(userIdentity);

            await HttpContext.SignInAsync("eShop.CookieAuth", userPrincipal);
            return Redirect("/themsp");
        }

        [Route("/Sua")]
        public void UpDate([FromQuery] int ProductId, [FromQuery] string Brand, [FromQuery] string Name, [FromQuery] double Price,
                          [FromQuery] string ImageLink, [FromQuery] string Description)
        {
            product.Update(ProductId, Brand, Name, Price, ImageLink, Description);
            Redirect("/SuaSanPham");
        }

        [Route("/Xoa")]
        public void Delete([FromQuery] int ProductId, [FromQuery] string Brand, [FromQuery] string Name, [FromQuery] double Price,
                         [FromQuery] string ImageLink, [FromQuery] string Description)
        {
            product.Delete(ProductId);
            Redirect("/admin");
        }




    }
}