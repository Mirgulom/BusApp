using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BusApp.Models;

namespace BusApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new TravelFormModel();

        // Здесь может быть логика для заполнения списка мест отправления, назначения и типов автобусов

        return View(model);
    }
    [HttpPost]
    public IActionResult Index(TripModel model)
    {
        
        var fromLocation = model.TravelInfo.FromLocation;
        var toLocation = model.TravelInfo.ToLocation;
        return RedirectToAction("Confirmation");
    }

    public IActionResult Confirmation()
    {
        return View();
    }
    public IActionResult Schedule()
    {
        var trips = new List<TripModel>
        {
            new TripModel
            {
                TripId = 1,
                TravelInfo = new TravelFormModel
                {
                    FromLocation = "Ташкент",
                    ToLocation = "Самарканд",
                    TravelDate = DateTime.Now.Date,
                    BusType = "Эконом"
                },
                DepartureTime = DateTime.Now.AddHours(8),
                ArrivalTime = DateTime.Now.AddHours(12),
                BusId = 101,
                AvailableSeats = 30
            },
            new TripModel
            {
                TripId = 2,
                TravelInfo = new TravelFormModel
                {
                    FromLocation = "Бухара",
                    ToLocation = "Ташкент",
                    TravelDate = DateTime.Now.Date.AddDays(1),
                    BusType = "Люкс"
                },
                DepartureTime = DateTime.Now.AddHours(10),
                ArrivalTime = DateTime.Now.AddHours(15),
                BusId = 102,
                AvailableSeats = 20
            },
            new TripModel
            {
                TripId = 3,
                TravelInfo = new TravelFormModel
                {
                    FromLocation = "Андижан",
                    ToLocation = "Навоий",
                    TravelDate = DateTime.Now.Date.AddDays(1),
                    BusType = "Люкс"
                },
                DepartureTime = DateTime.Now.AddHours(10),
                ArrivalTime = DateTime.Now.AddHours(15),
                BusId = 103,
                AvailableSeats = 20
            },
            new TripModel
            {
                TripId = 4,
                TravelInfo = new TravelFormModel
                {
                    FromLocation = "Андижан",
                    ToLocation = "Ургенч",
                    TravelDate = DateTime.Now.Date.AddDays(1),
                    BusType = "Люкс"
                },
                DepartureTime = DateTime.Now.AddHours(10),
                ArrivalTime = DateTime.Now.AddHours(15),
                BusId = 104,
                AvailableSeats = 17
            },
            new TripModel
            {
                TripId = 5,
                TravelInfo = new TravelFormModel
                {
                    FromLocation = "Шахрисабз",
                    ToLocation = "Наманган",
                    TravelDate = DateTime.Now.Date.AddDays(1),
                    BusType = "Люкс"
                },
                DepartureTime = DateTime.Now.AddHours(10),
                ArrivalTime = DateTime.Now.AddHours(15),
                BusId = 105,
                AvailableSeats = 15
            },
            new TripModel
            {
                TripId = 6,
                TravelInfo = new TravelFormModel
                {
                    FromLocation = "Бухара",
                    ToLocation = "Хива",
                    TravelDate = DateTime.Now.Date.AddDays(1),
                    BusType = "Эконом"
                },
                DepartureTime = DateTime.Now.AddHours(10),
                ArrivalTime = DateTime.Now.AddHours(15),
                BusId = 106,
                AvailableSeats = 18
            },
            
        };

        return View(trips);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}