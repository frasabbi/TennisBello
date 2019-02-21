using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisFormFinal.Models
{
    public interface ITSRepository
    {
        IQueryable<TennisReservation> Reservations { get; }
        IQueryable<Court> Courts { get; }
        IQueryable<string> CourtTypes { get; }
        void AddReservation(TennisReservation reservation);
        void Delete(TennisReservation reservation);
        IQueryable<TennisReservation> FindByMatchType(string queryString);
        IQueryable<TennisReservation> FindByCourtType(string queryString);
        
       

    }

}
