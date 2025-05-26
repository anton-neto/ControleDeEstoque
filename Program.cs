using controleDeEstoque.Models;
using controleDeEstoque.Dao;
using controleDeEstoque.Rotas;

var builder = WebApplication.CreateBuilder(args);

// Adiciona CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddDbContext<AppDbContext>();
var app = builder.Build();

// Habilita CORS
app.UseCors();

Banco.PopularBancoDeDados(app.Services);

app.MapGet("/", () => "API de Controle de Estoque");
app.MapGetRoutes();
app.MapPostRoutes();
app.MapDeleteRoutes();

// Configura a porta explicitamente
app.Urls.Add("http://localhost:5077");

app.Run(); 