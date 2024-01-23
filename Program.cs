var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddControllersWithViews(); // добавляем структуру MVC

var app = builder.Build();

if (app.Environment.IsDevelopment()) // если приложение находится в состоянии разработки
{
    app.UseDeveloperExceptionPage(); // добавляем промежуточное ПО - перехватывает все исключения
    // визуализирует ошибки на страничке в браузере
}

app.UseRouting(); // добавляем систему маршутизации

// Загрузка информации их файла конфигурации
// var configuration = app.Configuration;
// var config = configuration["CustomGreetings"]; // считывает и все

// app.MapGet("/", () => app.Configuration["CustomGreetings"]); // маршрут - в реальном времени выводит актуальную информацию - перехватывает все обращения к корню сайта
app.MapGet("/throw", () => { 
    throw new ApplicationException("Ошибка в программе"); 
});

app.MapDefaultControllerRoute(); // добавляем обработку входящих подключений системы MVC

app.Run();
