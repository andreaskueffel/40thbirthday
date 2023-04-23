using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace _40thBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedbackController
    {

        private readonly ILogger<FeedbackController> _logger;
        private readonly LiteDBContext _dbcontext;

        public FeedbackController(ILogger<FeedbackController> logger, LiteDBContext dbcontext)
        {
            _dbcontext = dbcontext;
            _logger = logger;
        }
        [IgnoreAntiforgeryToken]
        [HttpPost]
        public ActionResult<FeedbackDto> Post(FeedbackDto feedbackDto)
        {
            _dbcontext.DB.GetCollection<FeedbackDto>().Insert(feedbackDto);
            return new ActionResult<FeedbackDto>(feedbackDto);
            //return new CreatedAtActionResult(nameof(Post), nameof(FeedbackController), null, null); 
        }
        [HttpGet]
        public ActionResult<IEnumerable<FeedbackDto>> Index()
        {
            return new ActionResult<IEnumerable<FeedbackDto>>(_dbcontext.DB.GetCollection<FeedbackDto>().FindAll());
            
            //return new CreatedAtActionResult(nameof(Post), nameof(FeedbackController), null, null); 
        }
    }
}
