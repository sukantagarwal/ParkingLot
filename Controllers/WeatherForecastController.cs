using Microsoft.AspNetCore.Mvc;

namespace ParkingLotApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ParkingController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ParkingController> _logger;
    private readonly ILiteDbContext _liteDbContext;

    public ParkingController(ILogger<ParkingController> logger, ILiteDbContext liteDbContext)
    {
        _logger = logger;
        _liteDbContext = liteDbContext;
    }

    [HttpGet(Name = "GetParkingLots")]
    public IEnumerable<ParkingLot> Get()
    {
        throw new NotImplementedException();
    }
}
