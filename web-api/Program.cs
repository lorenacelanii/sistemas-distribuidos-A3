using web_api.Data;
using web_api.Services;
using web_api.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register your services
builder.Services.AddSingleton<IMongoDBService, MongoDBService>();
builder.Services.AddSingleton<UsersService>();
builder.Services.AddSingleton<ItemsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Comment out this line during development if causing issues
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
