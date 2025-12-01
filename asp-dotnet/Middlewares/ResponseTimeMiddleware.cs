namespace MyWebApplication.Middlewares;

public class ResponseTimeMiddleware
{
    private readonly RequestDelegate _next;

    public ResponseTimeMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        context.Response.OnStarting(() =>
        {
            context.Response.Headers.Append("X-Response-Time", DateTime.UtcNow.ToString("O"));
            return Task.CompletedTask;
        });

        await _next(context);
    }
}
