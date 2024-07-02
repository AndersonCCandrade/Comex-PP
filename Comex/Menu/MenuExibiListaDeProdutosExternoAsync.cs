using System.Text.Json;
using Comex.Modelo;
using Comex.Util;

namespace Comex.Menu;

public class MenuExibiListaDeProdutosExternoAsync
{
    private RequisicaoAPIUtil requisicaoAPIUtil;
    private string resposta;
    public MenuExibiListaDeProdutosExternoAsync()
    {
        requisicaoAPIUtil = new RequisicaoAPIUtil();
        resposta = requisicaoAPIUtil.conexao().Result;
    }

    public void ExibiListaDeProdutosExterna()
    {
        Console.WriteLine();
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
