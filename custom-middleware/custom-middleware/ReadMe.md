This project simulates custom middlewares which inherits from the IMiddleware interface
These middlewares are not defined in Program.cs but rather created in separate files as reusable components.
Click on IMiddleware to implement interface and add missing components.
Add custom middleware class in Program.cs
The syntax is simple:

class MiddleWareClassName : IMiddleware {
       public async Task InvokeAsync(HttpContext context,RequestDelegate next)=>{
                //before logic
                await next(context);
               //after logic
  }
}