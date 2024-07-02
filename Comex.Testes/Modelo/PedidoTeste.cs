using Comex.Modelo;

namespace Comex.Testes.Modelo;

public class PedidoTeste
{
    private Cliente _cliente;

    public PedidoTeste()
    {
        _cliente = new Cliente();
    }

    [Fact]
    public void PedidoDeveInicializarComClienteDataEUmaListaDePedido()
    {
        //Arrange
        _cliente.Nome = "Fulano";
        //Act
        Pedido pedido = new(_cliente);
        //Assert
        Assert.Equal(_cliente.Nome, pedido.Cliente.Nome);
        Assert.True(DateTime.Now.Subtract(pedido.Data).TotalSeconds < 1);
        Assert.Empty(pedido.Itens);
        Assert.Equal(0, pedido.Total);
    }

    [Fact]
    public void ValidaAdicaoDeitensAoPedido()
    {
        //Arrange
        var cliente = new Cliente() { Nome = "Fulano" };
        var produto1 = new Produto("Calça") { PrecoUnitario = 10.00 };
        ItemDePedido item1 = new(produto1, 2, produto1.PrecoUnitario);
        var pedido = new Pedido(cliente);

        //Act
        pedido.AdicionarItem(item1);

        //Assert
        Assert.True(pedido.Itens.Count == 1);
        Assert.Contains(item1, pedido.Itens);
        Assert.Equal(produto1.Nome, pedido.Itens[0].Produto.Nome);
    }


    [Fact]
    public void ValidaValorDoSubTotalDosItensDoPedido()
    {
        //Arrange
        var cliente = new Cliente() { Nome = "Fulano" };
        var produto1 = new Produto("Calça") { PrecoUnitario = 10.00 };
        ItemDePedido item1 = new(produto1, 2,produto1.PrecoUnitario);

        //Act
        var total = item1.Subtotal;
        //Assert
        Assert.Equal(20.00, total);

    }

    [Fact]
    public void ValidaValorTotalDoPedido()
    {
        //Arrange
        var cliente = new Cliente() { Nome = "Fulano" };
        var produto1 = new Produto("Calça") { PrecoUnitario = 10.00 };
        var produto2 = new Produto("Meia") { PrecoUnitario = 10.00 };
        var produto3 = new Produto("Sapato") { PrecoUnitario = 10.00 };
        ItemDePedido item1 = new(produto1, 1, produto1.PrecoUnitario);
        ItemDePedido item2 = new(produto2, 1,produto2.PrecoUnitario);
        ItemDePedido item3 = new(produto3, 1,produto3.PrecoUnitario);
        var pedido = new Pedido(cliente);
        pedido.AdicionarItem(item1);
        pedido.AdicionarItem(item2);
        pedido.AdicionarItem(item3);

        //Act
        var totalGeral = pedido.Total;

        //Assert
        Assert.Equal(30.00, totalGeral);
    }

    [Fact]
    public void ValidaDadosDoPedido()
    {
        //Arrange
        var cliente = new Cliente() { Nome = "Fulano" };
        var produto1 = new Produto("Calça") { PrecoUnitario = 10.00 };
        var produto2 = new Produto("Meia") { PrecoUnitario = 10.00 };
        var produto3 = new Produto("Sapato") { PrecoUnitario = 10.00 };
        ItemDePedido item1 = new(produto1, 1, produto1.PrecoUnitario);
        ItemDePedido item2 = new(produto2, 1, produto2.PrecoUnitario);
        ItemDePedido item3 = new(produto3, 1, produto3.PrecoUnitario);
        var pedido = new Pedido(cliente);
        pedido.AdicionarItem(item1);
        pedido.AdicionarItem(item2);
        pedido.AdicionarItem(item3);

        //Act
        string dadosDoPedido = pedido.ToString();

        //Assert
        Assert.Contains($"Cliente: Fulano,", dadosDoPedido);
    }
}
