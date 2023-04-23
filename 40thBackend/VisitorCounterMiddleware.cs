namespace _40thBackend
{
    public class VisitorCounterMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        public VisitorCounterMiddleware(RequestDelegate _requestDelegate) { 
        requestDelegate = _requestDelegate;
        }
        public async Task Invoke(HttpContext context)
        {
            System.Diagnostics.Trace.WriteLine(context.Request);

            await requestDelegate(context);
        }
    }
}
