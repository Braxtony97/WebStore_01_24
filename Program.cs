var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// �������� ���������� �� ����� ������������ 

var configuration = app.Configuration;

var config = configuration["CustomGreetings"];

app.MapGet("/", () => config);

app.Run();
