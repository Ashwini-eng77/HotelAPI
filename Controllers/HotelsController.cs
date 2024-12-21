using Microsoft.AspNetCore.Mvc;
using HotelApi.Models;
using HotelApi.Services;
using System.Collections.Generic;

namespace HotelApi.Controllers
{
[ApiController]
[Route("[controller]")]
public class HotelsController : ControllerBase
{
        private readonly HotelService _hotelService;

        public HotelsController(HotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var hotels = _hotelService.GetHotels();
                return Ok(hotels);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving hotel data.", Details = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var hotel = _hotelService.GetHotelById(id);
                if (hotel == null)
                {
                    return NotFound(new { Message = "Hotel not found" });
                }
                return Ok(hotel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving hotel data.", Details = ex.Message });
            }
        }
    }
}