

using System;

using System.ComponentModel.DataAnnotations;

namespace TennisFormFinal.Models
{



    public class TennisReservation
    {
        [Key]
        public int ReservationId { get; set; }
        public int CourtId { get; set; }
        public virtual Court Court { get; set; }
        [DateRange]
        public DateTime ReservationTime { get; set; }
        public String MatchType { get; set; }
        public string GetPrice()
        {
            
            decimal price= MatchType  == "Doppio" ? Court.Price * 1.25m : Court.Price;
            return string.Format("{0:.00}€",price);
        }


        public class DateRangeAttribute : RangeAttribute
        {
            public DateRangeAttribute()
              : base(typeof(DateTime), DateTime.Now.ToShortDateString(), DateTime.Now.AddYears(2).ToShortDateString()) { }
        }
    }
}
