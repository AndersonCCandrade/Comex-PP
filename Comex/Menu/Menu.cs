using System.Text.Json;
using Comex.DataBase;
using Comex.Modelo;
using Comex.Util;

namespace Comex.Menu;
public class Menu
{
    List<Produto> listaDeProduto = DataBaseDeProdutos.ListaDeProdutos();
    List<Pedido> listaDePedido = new();
    MenuCriarProduto cadastroDeProduto = new();
    MenuExibirListaDeProduto exibirDeProdutos = new();
    MenuExibiListaDeProdutosExternoAsync exibirProdutosDelistaExterna = new();
    MenuOrdernaListaDeProduto ordenaListaDeProdutos = new();
    MenuCriarPedido menuCriarPedido = new();
    MenuExibirListaDePedido exibirPedido = new();
    public async Task ExibiOpcoesDoMenu()
    {
        Console.Clear();
        var logo = new Logo();
        logo.ExibiLogoDoSistema();
        Console.WriteLine("\nDigite 1 Criar Produto");
        Console.WriteLine("Digite 2 Listar Produtos");
        Console.WriteLine("Digite 3 Consultar API Externa");
        Console.WriteLine("Digite 4 Ordenar Produtos pelo Título");
        Console.WriteLine("Digite 5 Ordenar Produtos pelo Preço");
        Console.WriteLine("Digite 6 Criar Pedido");
        Console.WriteLine("Digite 7 Listar Pedidos");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                listaDeProduto.Add(cadastroDeProduto.CriaNovoProdutoAdicionaNaLista());
                break;
            case 2:
                exibirDeProdutos.ExibiListaDeProdutos(listaDeProduto);
                break;
            case 3:
                exibirProdutosDelistaExterna.ExibiListaDeProdutosExterna();
                break;
            case 4:
                ordenaListaDeProdutos.OrdenaProdutosPorTitulo(listaDeProduto);
                break;
            case 5:
                ordenaListaDeProdutos.OrdenaProdutoPorPreco(listaDeProduto);
                break;
            case 6:
                var pedido = menuCriarPedido.CriaNovoPedido(listaDeProduto);
                listaDePedido.Add(pedido);
                break;
            case 7:
                exibirPedido.ExibirTodosOsPedidosDaBase(listaDePedido);
                break;
            case -1:
                Console.WriteLine("Tchau tchau :)");
                break;
            default:
                Console.WriteLine("Opção inválida");
                ConcluirOperacaoDoMenu.FinalizarMenu();
                break;
        }
        if (opcaoEscolhidaNumerica != -1)
        {
            await ExibiOpcoesDoMenu();
        }
    }
}
