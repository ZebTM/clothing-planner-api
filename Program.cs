using ClothingPlanner.DatabaseContext;
using ClothingPlanner.Repository;
using ClothingPlanner.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IClothingRepository, ClothingRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserClothingRepository, UserClothingRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IClothingService, ClothingService>();
builder.Services.AddScoped<IUserClothingRepository, UserClothingRepository>();

builder.Services.AddCors();
builder.Services.AddDbContext<MyDatabaseContext>();

var app = builder.Build();
 
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

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
