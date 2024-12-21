using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using HotelApi.Models;

namespace HotelApi.Services
{
    public class HotelService
    {
        private readonly string _filePath = "Data/Hotels.json";

        public List<Hotel> GetHotels()
        {
            var jsonData = File.ReadAllText(_filePath);
            var hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonData) ?? new List<Hotel>();
            return hotels;
        }

        public Hotel GetHotelById(int id)
        {
            var hotels = GetHotels();
            var hotel = hotels.FirstOrDefault(h => h.Id == id);
            if (hotel == null)
            {
                throw new KeyNotFoundException($"Hotel with ID {id} not found.");
            }
            return hotel;
        }
    }

    public class Hotel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public double? Rating { get; set; }
        public string? ImageUrl { get; set; }
        public List<string>? DatesOfTravel { get; set; }
        public string? BoardBasis { get; set; }
        public List<Room>? Rooms { get; set; }
    }

    public class Room
    {
        public string? RoomType { get; set; }
        public int? Amount { get; set; }
    }
}