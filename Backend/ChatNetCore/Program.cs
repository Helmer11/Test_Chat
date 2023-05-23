using ChatNetCore.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();


builder.Services.AddCors(option =>
{
    option.AddPolicy("PoliticaNueva", app =>
    {
        app.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapHub<HubChat>("/chat");
//});

app.UseAuthorization();

app.UseCors("PoliticaNueva");

app.MapControllers();

app.Run();
