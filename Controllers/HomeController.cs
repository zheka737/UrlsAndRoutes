using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;
namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("Result",
        new Result
        {
            Controller = nameof(HomeController),
            Action = nameof(Index)
        });
    }
}