using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Models;
using Reservation.API.Services;

namespace Reservation.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        [HttpGet("{id}")]
        public ReservationDTO Get(int id)
        {
            return _reservationService.GetReservationByBookingNumber(id);
        }
    }
}
