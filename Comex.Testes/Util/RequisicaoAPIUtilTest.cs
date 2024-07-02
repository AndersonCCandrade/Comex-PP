using Comex.Util;

namespace Comex.Testes.Util;
public class RequisicaoAPIUtilTest
{
    RequisicaoAPIUtil requisicao = new RequisicaoAPIUtil();
    [Fact]
    public void QuandoUrlInvalidaDeveRetornarStringDeErro()
    {
        //Arrage
        var urlInvalida = "urlinvalida.com";

        //Act
        var retornoAPI = requisicao.conexao(urlInvalida).Result;

        //Assert            
        Assert.Contains("Temos um problema:", retornoAPI);

    }
}