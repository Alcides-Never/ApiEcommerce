using APIEcommerce;
using APIEcommerce.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ECommerceContext, ECommerceContext>();

var app = builder.Build();

testeComunicacao.TesteComunicacao();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

//app.MapGet("/", () => "Hello World!");

app.Run();