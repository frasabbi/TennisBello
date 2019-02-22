using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisFormFinal.Models
{
    public class SessionReservation
    {
        public List<TennisReservation> Reservations { get; set; }

        public SessionReservation ()
        {
            Reservations = new List<TennisReservation>();
        }
     
        public virtual void AddReservation(TennisReservation reservation)
        {

            Reservations.Add(reservation);
        }
        public IEnumerable<TennisReservation> GetReservationByCourtType(string courtType)
        {
            return Reservations.Where(r => r.Court.Type == courtType);
        }
    }
}
