using custom_middleware.MyCustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
//inject dependence here
builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();

//register middleware here
app.UseMiddleware<MyCustomMiddleware>();

//app.MapGet("/", () => "Hello World!");

app.Run();