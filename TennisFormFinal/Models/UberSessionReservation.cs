using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisFormFinal.Extensions;

namespace TennisFormFinal.Models
{
    public class UberSessionReservation : SessionReservation
    {
        public static UberSessionReservation GetSessionReservation(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            UberSessionReservation res = session?.GetJson<UberSessionReservation>("session_reservation")
                ?? new UberSessionReservation();
            res.Session = session;
            return res;
        }
        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddReservation(TennisReservation res)
        {
            base.AddReservation(res);
            Session.SetJson("session_reservation", this);
        }
    }
}
