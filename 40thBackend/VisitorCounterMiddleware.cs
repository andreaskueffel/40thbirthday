namespace _40thBackend
{
    public class VisitorCounterMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        private readonly LiteDBContext dbContext;
        private readonly ILogger logger;
        public VisitorCounterMiddleware(RequestDelegate _requestDelegate, LiteDBContext _dbContext, ILogger<VisitorCounterMiddleware> _logger)
        {
            requestDelegate = _requestDelegate;
            dbContext = _dbContext;
            logger = _logger;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                VisitorInfo visitorInfo = VisitorInfo.FromHttpContext(context);
                dbContext.DB.GetCollection<VisitorInfo>().Insert(visitorInfo);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Exception in DB handling");
            }
            await requestDelegate(context);
        }
    }
}
