using TaskFLow.Interfaces;
using TaskFLow.Repository;
using TaskFLow.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<ITaskRepository, InMemoryTaskRepository>();
builder.Services.AddScoped<TaskService>();

var app = builder.Build();

app.MapControllers();
app.Run();