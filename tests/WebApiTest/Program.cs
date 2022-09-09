using Microsoft.EntityFrameworkCore;
using ShowPlan.EntityFrameworkCore7.Interceptor;
using Showplan.Tests.Data;
using WebApiTest;
using WebApiTest.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IShowplanInterceptorAction, ShowplanLoggerAction>();
builder.Services.AddTransient<IShowplanInterceptorAction, SpectreShowPlan>();
builder.Services.AddTransient<ShowplanInterceptor>();
builder.Services.AddDbContext<StackExchangeContext>((provider, options) =>
{
    options.AddInterceptors(provider.GetRequiredService<ShowplanInterceptor>());
    options.UseSqlServer("Data Source=.;Initial Catalog=sports.stackexchange.com;integrated security=true;TrustServerCertificate=True");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
