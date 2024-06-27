using Comex.Modelo;
using Comex.Util;

namespace Comex.Menu;

public class MenuExibirListaDePedido
{
    public void ExibirTodosOsPedidosDaBase(List<Pedido> listaDePedido)
    {
        Console.Clear();
        Console.WriteLine("Exibindo todos os pedidos registrados na nossa aplicação\n");

        if (listaDePedido.Count != 0)
        {

            var pedidosOrdenados = listaDePedido.OrderBy(p => p.Cliente.Nome).ToList();

            foreach (var Pedido in pedidosOrdenados)
            {
                Console.WriteLine($"Cliente: {Pedido.Cliente.Nome}, Total: {Pedido.Total:F2}");
            }
        }
        else
        {
            Console.WriteLine("\nNão existe pedido na lista");
        }
        ConcluirOperacaoDoMenu.FinalizarMenu();
    }
}
