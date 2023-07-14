using SotoGomezTelesforo.Alumno.Service.Application.Extensions;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Extensions;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.Extensions;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructure(options => options.ConnectionString = builder.Configuration.GetConnectionString("SchoolConnectionString"));
builder.Services.AddApplication();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.RegisterEndpoints();
app.UseSeedData();
app.Run();

