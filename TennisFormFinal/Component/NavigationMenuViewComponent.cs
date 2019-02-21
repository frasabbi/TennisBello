using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisFormFinal.Models;

namespace TennisFormFinal.Component
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        private ITSRepository repository;

        public NavigationMenuViewComponent(ITSRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["courtsType"];
            return View(repository.CourtTypes);
        }
    }
}
