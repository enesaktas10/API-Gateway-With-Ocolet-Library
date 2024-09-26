using Ocelot.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelit.json");
builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

app.Run();
