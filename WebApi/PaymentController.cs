using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : ControllerBase
{
    private readonly PaymentService _paymentService;

    public PaymentController(PaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    //Route parameter
    // [HttpPost("{amount}")]
    // public IActionResult Pay(decimal amount)
    // {
    //     _paymentService.ProcessPayment(amount);

    //     return Ok("Payment successful");
    // }

    //Query string parameter
    // [HttpPost]
    // public IActionResult Pay([FromQuery] decimal amount)
    // {
    //     _paymentService.ProcessPayment(amount);

    //     return Ok("Payment successful");
    // }

    //Request body parameter
    // [HttpPost]
    // public IActionResult Pay(PaymentRequest request)
    // {
    //     _paymentService.ProcessPayment(request.Amount);

    //     return Ok("Payment successful");
    // }


}