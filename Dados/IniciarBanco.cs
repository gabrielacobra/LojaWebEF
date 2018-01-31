using System.Linq;
using LojaWebEF.Models;

namespace LojaWebEF.Dados
{
    public class IniciarBanco
    {
        public static void Inicializar(LojaContexto contexto)
        {
            contexto.Database.EnsureCreated(); //contexto = DbContext personalizado pela lojacontexto. Esse método confere se o banco foi criado
            if (contexto.Cliente.Any())
            { //verifica se há algo dentro da tabela, caso não tenha infos, ele cria na primeira execução. a verificação poderia ser em produto, cliente ou produto
                return; //retorno para mostrar que tem algo criado no banco
            }
            var cliente = new Cliente()
            { //o tipo poderia ser cliente. estamos usando linq, pode retornar uma coleção ou um objeto simples, o var permite isso
                Nome = "João",
                Email = "joao@gmail.com",
                Idade = 32
            };
            contexto.Cliente.Add(cliente);

            var produto = new Produto()
            {
                NomeProduto = "Mouse",
                Descricao = "Mouse Microsoft",
                Preco = 25.30M,
                Quantidade = 50
            };
            contexto.Produto.Add(produto);

            var pedido = new Pedido()
            {
                IdProduto = produto.IdProduto,
                IdCliente = cliente.IdCliente,
                Quantidade = 60
            };
            contexto.Pedido.Add(pedido);
            contexto.SaveChanges();
        }
    }
}