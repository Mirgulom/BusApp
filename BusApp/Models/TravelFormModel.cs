namespace BusApp.Models;

public class TravelFormModel
{
    public string FromLocation { get; set; }
    public string ToLocation { get; set; }
    public DateTime TravelDate { get; set; }
    public string BusType { get; set; }
}