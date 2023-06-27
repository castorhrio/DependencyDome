using DependencyDome.Model;
using Microsoft.AspNetCore.Mvc;

namespace DependencyDome.Controllers
{
    public class HomeController : Controller
    {
        private IDemoScoped _scoped1;
        private IDemoScoped _scoped2;
        private IDemoSingleton _singleton1;
        private IDemoSingleton _singleton2;
        private IDemoTransient _transient1;
        private IDemoTransient _transient2;

        public HomeController(
            IDemoTransient transient1,
            IDemoTransient transient2,
            IDemoSingleton singleton1,
            IDemoSingleton singleton2,
            IDemoScoped scoped1,
            IDemoScoped scoped2)
        {
            _transient1 = transient1;
            _transient2 = transient2;
            _singleton1 = singleton1;
            _singleton2 = singleton2;
            _scoped1 = scoped1;
            _scoped2 = scoped2;
        }

        public IActionResult Index()
        {
            ViewBag.transient1 = "First Instance: " + _transient1.GetID();
            ViewBag.transient2 = "Second Instance: " + _transient2.GetID();

            ViewBag.singleton1 = "First Instance: " + _singleton1.GetID();
            ViewBag.singleton2 = "Second Instance: " + _singleton2.GetID();

            ViewBag.scoped1 = "First Instance: " + _scoped1.GetID();
            ViewBag.scoped2 = "Second Instance: " + _scoped2.GetID();
            return View();
        }
    }
}