namespace custom_middleware.MyCustomMiddleware;

public class MyCustomMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        await context.Response.WriteAsync("HELLO");
        await next(context);
        await context.Response.WriteAsync("There");

    }
}