using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServiceBusAutomation.Data;
using ServiceBusAutomation.Middlewares;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.WebHost.UseUrls("http://192.168.2.122:5078");
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        policy => policy.WithOrigins("http://192.168.2.122:5078")
        .AllowAnyHeader()
        .AllowAnyMethod());
});

var app = builder.Build();
app.UseCorsMiddleware();
app.UseCors("AllowOrigin");
app.MapControllerRoute("main", "{controller=Home}/{action=Index}/{id?}");

app.Run();
