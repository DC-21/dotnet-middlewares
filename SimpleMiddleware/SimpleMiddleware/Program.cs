var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//running a chain of middlewares that executes a couple middlewares.
//comment first middleware if you want to try a middleware that ives a single response.
app.Use(async (HttpContext context,RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello");
    await next(context);

});
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("ba");
    await next(context);
});
//using Run() method to build a middleware(with lambda expression) that executes one request only
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("dev");
});


app.Run();