namespace controleDeEstoque.Models;
using Microsoft.Extensions.DependencyInjection;
using controleDeEstoque.Dao;

public static class Banco
{
    public static void PopularBancoDeDados(IServiceProvider app)
    {
        using (var scope = app.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();

            if (!context.Categorias.Any())
            {
                context.Categorias.Add(new Categoria { nome = "Eletrônicos", descricao = "Produtos eletrônicos em geral" });
                context.Categorias.Add(new Categoria { nome = "Informática", descricao = "Produtos de informática" });
                context.Categorias.Add(new Categoria { nome = "Móveis", descricao = "Móveis para escritório" });
                context.Categorias.Add(new Categoria { nome = "Papelaria", descricao = "Material de escritório" });
                context.Categorias.Add(new Categoria { nome = "Limpeza", descricao = "Produtos de limpeza" });
                context.SaveChanges();
            }

            if (!context.Fornecedores.Any())
            {
                context.Fornecedores.Add(new Fornecedor { 
                    nome = "Tech Solutions", 
                    cnpj = "12345678901234", 
                    telefone = "41987654321",
                    email = "contato@techsolutions.com",
                    endereco = "Rua das Flores, 123",
                    cidade = "Curitiba",
                    estado = "PR",
                    cep = "80010-000"
                });
                context.Fornecedores.Add(new Fornecedor { 
                    nome = "Office Supplies", 
                    cnpj = "23456789012345", 
                    telefone = "41987654322",
                    email = "contato@officesupplies.com",
                    endereco = "Av. Principal, 456",
                    cidade = "São Paulo",
                    estado = "SP",
                    cep = "01310-000"
                });
                context.SaveChanges();
            }

            if (!context.Produtos.Any())
            {
                context.Produtos.Add(new Produto { 
                    nome = "Notebook Dell", 
                    descricao = "Notebook Dell Inspiron 15", 
                    preco = 3500.00m,
                    quantidade = 10,
                    categoriaId = 1,
                    fornecedorId = 1,
                    dataCadastro = DateTime.Now
                });
                context.Produtos.Add(new Produto { 
                    nome = "Monitor LG", 
                    descricao = "Monitor LG 24 polegadas", 
                    preco = 800.00m,
                    quantidade = 15,
                    categoriaId = 1,
                    fornecedorId = 1,
                    dataCadastro = DateTime.Now
                });
                context.Produtos.Add(new Produto { 
                    nome = "Mesa Escritório", 
                    descricao = "Mesa de escritório em madeira", 
                    preco = 450.00m,
                    quantidade = 8,
                    categoriaId = 3,
                    fornecedorId = 2,
                    dataCadastro = DateTime.Now
                });
                context.Produtos.Add(new Produto { 
                    nome = "Cadeira Ergonômica", 
                    descricao = "Cadeira ergonômica para escritório", 
                    preco = 650.00m,
                    quantidade = 12,
                    categoriaId = 3,
                    fornecedorId = 2,
                    dataCadastro = DateTime.Now
                });
                context.Produtos.Add(new Produto { 
                    nome = "Papel A4", 
                    descricao = "Pacote com 500 folhas", 
                    preco = 25.00m,
                    quantidade = 50,
                    categoriaId = 4,
                    fornecedorId = 2,
                    dataCadastro = DateTime.Now
                });
                context.Produtos.Add(new Produto { 
                    nome = "Impressora HP", 
                    descricao = "Impressora HP LaserJet Pro", 
                    preco = 1200.00m,
                    quantidade = 5,
                    categoriaId = 2,
                    fornecedorId = 1,
                    dataCadastro = DateTime.Now
                });
                context.Produtos.Add(new Produto { 
                    nome = "Teclado Mecânico", 
                    descricao = "Teclado mecânico RGB", 
                    preco = 250.00m,
                    quantidade = 20,
                    categoriaId = 2,
                    fornecedorId = 1,
                    dataCadastro = DateTime.Now
                });
                context.Produtos.Add(new Produto { 
                    nome = "Mouse Gamer", 
                    descricao = "Mouse gamer com 6 botões", 
                    preco = 150.00m,
                    quantidade = 25,
                    categoriaId = 2,
                    fornecedorId = 1,
                    dataCadastro = DateTime.Now
                });
                context.Produtos.Add(new Produto { 
                    nome = "Detergente", 
                    descricao = "Detergente líquido 500ml", 
                    preco = 8.50m,
                    quantidade = 30,
                    categoriaId = 5,
                    fornecedorId = 2,
                    dataCadastro = DateTime.Now
                });
                context.Produtos.Add(new Produto { 
                    nome = "Caneta Esferográfica", 
                    descricao = "Pacote com 10 canetas", 
                    preco = 15.00m,
                    quantidade = 100,
                    categoriaId = 4,
                    fornecedorId = 2,
                    dataCadastro = DateTime.Now
                });
                context.SaveChanges();
            }

            if (!context.Movimentacoes.Any())
            {
                context.Movimentacoes.Add(new Movimentacao { 
                    produtoId = 1,
                    tipo = "Entrada",
                    quantidade = 10,
                    data = DateTime.Now,
                    observacao = "Entrada inicial de estoque"
                });
                context.Movimentacoes.Add(new Movimentacao { 
                    produtoId = 2,
                    tipo = "Entrada",
                    quantidade = 15,
                    data = DateTime.Now,
                    observacao = "Entrada inicial de estoque"
                });
                context.Movimentacoes.Add(new Movimentacao { 
                    produtoId = 3,
                    tipo = "Entrada",
                    quantidade = 8,
                    data = DateTime.Now,
                    observacao = "Entrada inicial de estoque"
                });
                context.SaveChanges();
            }
        }
    }
} 