var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Загрузка информации их файла конфигурации 

// var configuration = app.Configuration;

// var config = configuration["CustomGreetings"]; // считывает и все

app.MapGet("/", () => app.Configuration["CustomGreetings"]); // в реальном времени выводит актуальную информацию

app.Run();
