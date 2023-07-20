using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebHookController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> WebhookHandlerAsync()
        {
            try
            {
                // Log the request body
                using (StreamReader reader = new StreamReader(Request.Body))
                {
                    string requestBody = await reader.ReadToEndAsync();
                    Console.WriteLine("Received Payload: " + requestBody);
                }

                // Process the webhook payload here
                // Add your logic to handle the received payload

                // Example: Return a response
                return Ok("Webhook received successfully.");
            }
            catch (Exception ex)
            {
                // Log any exceptions that occurred during webhook processing
                Console.WriteLine("Exception: " + ex.Message);
                return BadRequest("Error processing webhook: " + ex.Message);
            }
        }

    }
}
