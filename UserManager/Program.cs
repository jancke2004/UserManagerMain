
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

//Add CORS policy
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAllOrigins", builder =>
//    {
//        builder.WithOrigins("http://localhost:4200", "http://localhost")
//               .AllowAnyOrigin()  // Allow requests from any origin (e.g., your Angular app)
//               .AllowAnyHeader()  // Allow any header (e.g., Authorization headers)
//               .AllowAnyMethod(); // Allow any HTTP methods (GET, POST, PUT, etc.)
//    });
//});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder => builder
    .WithOrigins("http://localhost:4200", "http://localhost")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());
});

var app = builder.Build();
app.UseCors("AllowSpecificOrigin");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();
app.Run();
