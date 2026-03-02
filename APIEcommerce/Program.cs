using APIEcommerce;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

testeComunicacao.TesteComunicacao();

app.MapGet("/", () => "Hello World!");

app.Run();