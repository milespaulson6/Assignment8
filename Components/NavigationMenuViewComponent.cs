using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private ILetriniaRepository repository;

        public NavigationMenuViewComponent (ILetriniaRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Products.Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }

    }
}
