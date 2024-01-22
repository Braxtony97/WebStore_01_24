var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Загрузка информации их файла конфигурации 

var configuration = app.Configuration;

var config = configuration["CustomGreetings"];

app.MapGet("/", () => config);

app.Run();
