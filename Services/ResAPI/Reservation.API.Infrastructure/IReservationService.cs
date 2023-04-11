using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public interface IReservationService
    {
        ReservationDTO GetReservationByBookingNumber(int bookingNumber);
    }
}
