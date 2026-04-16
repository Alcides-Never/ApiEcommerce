using APIEcommerce;
using APIEcommerce.Context;
using APIEcommerce.Interfaces;
using APIEcommerce.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
//builder.Services.AddTransient<ECommerceContext, ECommerceContext>();
builder.Services.AddScoped<ECommerceContext, ECommerceContext>();
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IPagamentoRepository, PagamentoRepository>();

var app = builder.Build();

testeComunicacao.TesteComunicacao();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

//app.MapGet("/", () => "Hello World!");

app.Run();