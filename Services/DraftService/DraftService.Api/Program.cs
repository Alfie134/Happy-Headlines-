using Microsoft.EntityFrameworkCore;
using Serilog;
using Services.DraftService.DraftService.Infrastructure.Data;


// Add services to the container.


Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .Enrich.WithProperty("Service", "DraftService")
    .WriteTo.Console()
    .WriteTo.Seq("http://localhost:5341")
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog();
var app = builder.Build();

builder.Services.AddDbContext<DraftDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DraftDbContext")));

app.UseHttpsRedirection();


app.Run();
