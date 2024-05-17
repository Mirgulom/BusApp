using System.ComponentModel.DataAnnotations;

namespace BusApp.Models;

public class TripModel
{
    public int TripId { get; set; }

    // Связь с моделью TravelFormModel
    public TravelFormModel TravelInfo { get; set; }

    // Дополнительные свойства для таблицы рейсов
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public int BusId { get; set; }
    public int AvailableSeats { get; set; }
}