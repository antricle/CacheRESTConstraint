var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddResponseCaching();

var app = builder.Build();

app.UseResponseCaching();
app.UseAuthorization();

app.MapControllers();

app.Run();
