using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace PermissionManagement.MVC.Controllers
{
    [Authorize(Roles = "Basic , Admin , SuperAdmin")]
    public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}