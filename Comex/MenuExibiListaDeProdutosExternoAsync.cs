using System.Text.Json;

namespace Comex;

public class MenuExibiListaDeProdutosExternoAsync
{
    private RequisicaoAPIUtil requisicaoAPIUtil;
    private string resposta;
    public MenuExibiListaDeProdutosExternoAsync()
    {
        requisicaoAPIUtil =  new RequisicaoAPIUtil();
        resposta = requisicaoAPIUtil.conexao().Result;
    }

    public void ExibiListaDeProdutosExterna()
    {
        if (resposta.Contains("Temos um problema:"))
        {
            Console.WriteLine(resposta);
        } 
        else 
        { 
            var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta)!;
            produtos.ForEach(produto => Console.WriteLine(produto.ExibiInformacaoDoProduto()));
        }
        ConcluirOperacaoDoMenu.FinalizarMenu();
    }
}
