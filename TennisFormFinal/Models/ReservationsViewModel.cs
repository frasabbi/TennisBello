using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennisFormFinal.Models
{
    public class ReservationsViewModel
    {
        public IEnumerable<TennisReservation> Reservations { get; set; }
        public PageInfo PageInfo { get; set; }


        public SelectList NameSelectList { get; set; }
        public SelectList TypeSelectList { get; set; }


        public ReservationsViewModel()
        {
            
            PageInfo = new PageInfo();
        }

        public ReservationsViewModel(IEnumerable<TennisReservation> reservations, SelectList nameSelectList, SelectList typeSelectList)
        {
            Reservations = reservations;
            NameSelectList = nameSelectList;
            TypeSelectList = typeSelectList;
            PageInfo = new PageInfo();
        }
        




    }

    public class PageInfo
    {
        public string FilterField { get; set; }
        public DateTime FilterDate { get; set; }
    }


}

