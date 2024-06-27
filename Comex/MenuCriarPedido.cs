namespace Comex;

public class MenuCriarPedido
{
    public Pedido CriaNovoPedido(List<Produto> listaDeProduto)
    {
        Console.Clear();
        Console.WriteLine("Criando um novo pedido\n");

        Console.Write("Digite o nome do cliente: ");
        string nomeCliente = Console.ReadLine()!;
        var cliente = new Cliente();
        cliente.Nome = nomeCliente;

        var pedido = new Pedido(cliente);

        Console.WriteLine("\nProdutos disponíveis:");
        for (int i = 0; i < listaDeProduto.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {listaDeProduto[i].Nome}");
        }

        Console.Write("Digite o número do produto que deseja adicionar (ou 0 para finalizar): ");
        int numeroProduto = int.Parse(Console.ReadLine()!);

        var produtoEscolhido = listaDeProduto[numeroProduto - 1];

        Console.Write("Digite a quantidade: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        var itemDePedido = new ItemDePedido(produtoEscolhido, quantidade, produtoEscolhido.PrecoUnitario);
        pedido.AdicionarItem(itemDePedido);

        Console.WriteLine($"Item adicionado: {itemDePedido}\n");

        
        Console.WriteLine($"\nPedido criado com sucesso:\n{pedido}");
        ConcluirOperacaoDoMenu.FinalizarMenu();

        return pedido;
    }
}
