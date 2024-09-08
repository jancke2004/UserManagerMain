
using Microsoft.EntityFrameworkCore;
using UserManager.Logic.Interfaces;
using UserManager.Logic.Users;
using UserManager.Repository.Interfaces;
using UserManager.Repository.Models;
using UserManager.Repository.Users;

var builder = WebApplication.CreateBuilder(args);

// Add UserContext to the DI container
builder.Services.AddDbContext<UserContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DbCon")));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService,UserService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();
app.Run();
