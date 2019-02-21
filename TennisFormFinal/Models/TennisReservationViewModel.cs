using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisFormFinal.Models
{
    public class TennisReservationViewModel
    {

        public TennisReservationViewModel()
        {
        }

        public TennisReservationViewModel(TennisReservation reservation, SelectList nameSelectList, SelectList typeSelectList)
        {
            Reservation = reservation;
            NameSelectList = nameSelectList;
            TypeSelectList = typeSelectList;
        }

        public TennisReservation Reservation { get; set; }
        

        public SelectList NameSelectList { get; set; }
        public SelectList TypeSelectList { get; set; }
    }
}
