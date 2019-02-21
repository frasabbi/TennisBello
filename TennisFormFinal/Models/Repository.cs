using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisFormFinal.Models
{
    public class Repository:ITSRepository
    {
        private TRDBContext context;
        public Repository(TRDBContext ctx)
        {
            context = ctx;
        }

        public IQueryable<TennisReservation> Reservations => context.TReservations;
        public IQueryable<Court> Courts => context.TCourts;
        public IQueryable<string> CourtTypes => Courts.Select(x => x.Type).Distinct().OrderBy(x => x);
       

        public void AddReservation(TennisReservation reservation)
        {
            context.TReservations.Add(reservation);
            context.SaveChanges();
        }

        public void Delete(TennisReservation reservation)
        {
            context.TReservations.Remove(reservation);
            context.SaveChanges();
        }

        public IQueryable<TennisReservation> FindByMatchType(string courtType)
        {
            return Reservations.Where(r => r.MatchType == courtType);
        }
        public IQueryable<TennisReservation> FindByCourtType(string courtType)
        {
            return Reservations.Where(r=>r.Court.Type== courtType);
        }
        

    }
}
