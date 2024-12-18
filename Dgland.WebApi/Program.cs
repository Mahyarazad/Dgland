using Dgland.Persistence;
using Dgland.Persistence.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddPersistanceDependencies(builder.Configuration);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddProblemDetails();


var app = builder.Build();

using var scope = app.Services.CreateScope();

using var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

if(context.Database.GetPendingMigrations().Any())
{
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

