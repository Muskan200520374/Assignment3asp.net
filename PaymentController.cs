
public class PaymentController : Controller
{
    private readonly StripeService _stripeService;

    public PaymentController(StripeService stripeService)
    {
        _stripeService = stripeService;
    }

    public IActionResult Checkout()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Charge(string stripeToken, int eventId)
    {
        
        
        return RedirectToAction("PaymentConfirmation", new { eventId });
    }
}
