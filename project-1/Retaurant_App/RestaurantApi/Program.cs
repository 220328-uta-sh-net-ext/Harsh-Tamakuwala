global using Serilog;

using RestaurantBl;
using RestaurantDl;
using RestaurantModel;

Log.Logger = new LoggerConfiguration().WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllers()
//    .AddXmlSerializerFormatters();
// Add services to the container.

builder.Services.AddControllers().AddXmlSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


ConfigurationManager Config = builder.Configuration;

builder.Services.AddScoped<IItemRepository<UserModelClass>>(repo => new UserRepository(Config.GetConnectionString("RestaurantDb")));
builder.Services.AddScoped<SearchUser>();
builder.Services.AddScoped<AddUserLogic>();
builder.Services.AddScoped<IItemRepository<ReviewModelClass>>(repo => new ReviewRepository(Config.GetConnectionString("RestaurantDb")));
builder.Services.AddScoped<ReviewLogic>();
builder.Services.AddScoped<IItemRepository<RestaurantModelClass>>(repo => new RestaurantRepository(Config.GetConnectionString("RestaurantDb")));
builder.Services.AddScoped<RestaurantLogic>();
builder.Services.AddScoped<SearchRestaurantBl>();
//app here refers to pipline middleware(passes through diff sets of software called middleware)
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

