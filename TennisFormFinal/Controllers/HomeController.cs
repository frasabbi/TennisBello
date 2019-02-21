using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TennisFormFinal.Models;
using Microsoft.AspNetCore.Http;
using TennisFormFinal.Extensions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TennisFormFinal.Controllers
{
    public class HomeController : Controller
    {
        
        private ITSRepository repository;
        private SessionReservation sReservation;

        public HomeController(ITSRepository repo)
        {
            repository = repo;
        }
        // GET: /<controller>/
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult ReservationForm()
        {
            var courtNameList = new SelectList(repository.Courts.Select(c => c.Name), repository.Courts.First().Name);
            var courtTypeList = new SelectList(repository.Courts.Select(c => c.Type).Distinct(), repository.Courts.First().Type);

            TennisReservationViewModel model = new TennisReservationViewModel(new TennisReservation() {ReservationTime=DateTime.Now }, courtNameList, courtTypeList);
            return View(model);
        }
        public SessionReservation GetSessionReservation()
        {    
             return HttpContext.Session.GetJson<SessionReservation>("session_reservation");
        }
        public void SaveSessionReservation(SessionReservation sR)
        {
            HttpContext.Session.SetJson("session_reservation", sR);
        }
        [HttpPost]
        public IActionResult ReservationForm(TennisReservationViewModel reservationVM)
        {
            if (ModelState.IsValid)
            {
                reservationVM.Reservation.Court = repository.Courts.Where(c => c.Name == reservationVM.Reservation.Court.Name).First();
                reservationVM.Reservation.CourtId = reservationVM.Reservation.Court.Id;

                repository.AddReservation(reservationVM.Reservation);

                SessionReservation res = GetSessionReservation()?? new SessionReservation();
                res.AddReservation(reservationVM.Reservation);
                SaveSessionReservation(res);

                return RedirectToAction("DisplayList");
            }
            else
            {
                // there is a validation error
                //ModelState.AddModelError("ReviewErrors", "some error occured");
                //return RedirectToAction(new { uniqueUri = Request.RequestContext.RouteData.Values["uniqueUri"] });
                
                return View(reservationVM);
            }
        }

        [HttpGet]
        public ViewResult DisplayList(string courtType /*string courtName, DateTime selectedDate*/)
        {
            IQueryable<TennisReservation> filteredReservation;


            try
            {
                foreach (var item in GetSessionReservation().Reservations)
                {
                    Console.WriteLine(item.MatchType);
                }
            }
            catch (Exception)
            {

                
            }



            var courtNameList = new SelectList(repository.Courts.Select(c => c.Name), repository.Courts.First().Name);
            var courtTypeList = new SelectList(repository.Courts.Select(c => c.Type).Distinct(), repository.Courts.First().Type);
        
            if (String.IsNullOrEmpty(courtType))
            {
                filteredReservation = repository.Reservations;
            }
            else
            {
                filteredReservation = repository.FindByCourtType(courtType);
            }
            ReservationsViewModel model = new ReservationsViewModel(filteredReservation, courtNameList, courtTypeList);
           
            return View(model);
        }


        [HttpPost]
        public ViewResult DisplayList(ReservationsViewModel model)
        {
                IEnumerable<TennisReservation> filtered = repository.Reservations;

                if (!String.IsNullOrEmpty(model.PageInfo.FilterField))
                {
                    filtered = filtered.Where(r => r.Court.Name == model.PageInfo.FilterField);
                }
                if(model.PageInfo.FilterDate != null && model.PageInfo.FilterDate.Year!=1)
                {
                    filtered = filtered.Where(r => r.ReservationTime.ToShortDateString() == model.PageInfo.FilterDate.ToShortDateString());
                }
            var courtNameList = new SelectList(repository.Courts.Select(c => c.Name), repository.Courts.First().Name);
            var courtTypeList = new SelectList(repository.Courts.Select(c => c.Type).Distinct(), repository.Courts.First().Type);

            ReservationsViewModel newModel = new ReservationsViewModel(filtered, courtNameList, courtTypeList);

            return View(newModel);
        }



        [HttpGet]
        public ViewResult SessionListView(string courtType /*string courtName, DateTime selectedDate*/)
        {
            IQueryable<TennisReservation> filteredReservation;


            try
            {
                foreach (var item in GetSessionReservation().Reservations)
                {
                    Console.WriteLine(item.MatchType);
                }
            }
            catch (Exception)
            {


            }

            var courtNameList = new SelectList(repository.Courts.Select(c => c.Name), repository.Courts.First().Name);
            var courtTypeList = new SelectList(repository.Courts.Select(c => c.Type).Distinct(), repository.Courts.First().Type);


            SessionReservation res = GetSessionReservation() ?? new SessionReservation();

            if (String.IsNullOrEmpty(courtType))
            {

                filteredReservation =res.Reservations.AsQueryable<TennisReservation>();
            }
            else
            {
                filteredReservation = res.GetReservationByCourtType(courtType).AsQueryable<TennisReservation>();
            }
            ReservationsViewModel model = new ReservationsViewModel(filteredReservation, courtNameList, courtTypeList);

            return View(model);
        }

        //public ViewResult Delete(int id)
        //{
        //    repository.Delete(repository.Reservations.ToList()[id-1]);

        //    return View("DisplayList",new TennisReservationViewModel() { reservations=repository.Reservations});
        //}

    }
}
