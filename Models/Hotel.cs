namespace HotelApi.Models

{
    public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public double Rating { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public List<string> DatesOfTravel { get; set; } = new List<string>();
    public string BoardBasis { get; set; } = string.Empty;
    public List<Room> Rooms { get; set; } = new List<Room>();
}

public class Room
{
    public string RoomType { get; set; } = string.Empty;
    public int Amount { get; set; }
}
}