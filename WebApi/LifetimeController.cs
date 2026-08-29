using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class LifetimeController : ControllerBase
{
    private readonly PaymentService _service1;
    private readonly PaymentService _service2;

    public LifetimeController(
        PaymentService service1,
        PaymentService service2)
    {
        _service1 = service1;
        _service2 = service2;
    }

    [HttpGet]
    public IActionResult GetLifetime()
    {
        return Ok(new
        {
            Service1 = _service1.ServiceId,
            Service2 = _service2.ServiceId,

            Payment1 = _service1.PaymentId,
            Payment2 = _service2.PaymentId
        });
    }
}