var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Merhaba Veteriner!");
app.MapGet("/hakkinda", () => "Bu bir veteriner kliniği uygulamasıdır'!!.");

app.Run();