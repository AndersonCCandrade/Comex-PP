using Comex.Modelo;

namespace Comex.Testes.Modelo;
public class ProdutoTestes
{
    [Fact]
    public void ProdutoDeveInicializarComNome()
    {
        //Arrange
        string nome = "Camisa";

        //Act
        Produto produto = new Produto(nome);

        //Assert
        Assert.Equal(nome, produto.Nome);        
        
    }

    [Fact] 
    public void MetodoExibirInformacaoRetornarStringCorretra()
    {
        //Arrange
        var produto = new Produto("Camisa")
        {
            Descricao = "Camisa Social",
            PrecoUnitario = 100,
            Quantidade = 1,
        };

        //Act
        var mensagem = produto.ExibiInformacaoDoProduto();

        //Assert
        Assert.Equal($"Produto: Camisa \nDescrição: Camisa Social \nPreco Unitário: 100 \n", mensagem);

    }
}
