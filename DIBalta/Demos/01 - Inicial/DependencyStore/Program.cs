using DependencyStore;
using DependencyStore.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Configuration>();
builder.Services.AddSqlConnection(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();