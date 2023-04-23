using Microsoft.AspNetCore.Mvc;

namespace _40thBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedbackController
    {

        private readonly ILogger<FeedbackController> _logger;

        public FeedbackController(ILogger<FeedbackController> logger)
        {
            _logger = logger;
        }

    }
}
