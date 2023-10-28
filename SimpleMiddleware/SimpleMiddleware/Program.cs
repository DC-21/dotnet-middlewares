var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//using Run() method to build a middleware(with lambda expression) that executes one request only
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello chola");
});

app.Run();