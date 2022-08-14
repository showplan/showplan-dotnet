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
//builder.Services.AddScoped<IShowplanInterceptorAction, ShowplanLoggerAction>();
builder.Services.AddScoped<IShowplanInterceptorAction, SpectreShowPlan>();
builder.Services.AddDbContext<StackExchangeContext>((provider, options) =>
{
    var interceptorActions = provider.GetServices<IShowplanInterceptorAction>().ToArray();
    if (interceptorActions.Length > 0)
    {
        options.AddInterceptors(new ShowplanInterceptor(interceptorActions));
    }

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
