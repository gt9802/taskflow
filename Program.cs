using Microsoft.EntityFrameworkCore;
using System;
using TaskFLow.Data;
using TaskFLow.Interfaces;
using TaskFLow.Repository;
using TaskFLow.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ITaskRepository, PostgresTaskRepository>();
builder.Services.AddScoped<TaskService>();
builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("TaskFlow")
        );
});
var app = builder.Build();
app.MapControllers();
app.Run();