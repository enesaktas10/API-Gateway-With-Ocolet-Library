var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();

app.MapGet("/", () => "API 1");

app.Run();
