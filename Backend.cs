using controleDeEstoque.Models;
using controleDeEstoque.Dao;
using controleDeEstoque.Rotas;

var builder = WebApplication.CreateBuilder(args);

// Configuração do CORS
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

// Configuração do middleware
app.UseCors();
app.UseRouting();

Banco.PopularBancoDeDados(app.Services);

// Rota simples para mensagem de controle de estoque
app.MapGet("/", () => "Sistema de Controle de Estoque - API");

app.MapGetRoutes();
app.MapPostRoutes();
app.MapPutRoutes();
app.MapDeleteRoutes();

app.Urls.Add("http://localhost:5077");

app.Run(); 