namespace Comex;

public class MenuExibirListaDeProduto
{
    public void ExibiListaDeProdutos(List<Produto> listaDeProduto)
    {
        Console.Clear();

        //ExibirTituloDaOpcao("Exibindo todos os produtos registradoss na nossa aplicação");
        Console.WriteLine("Exibindo todos os produtos registradoss na nossa aplicação");

        for (int i = 0; i < listaDeProduto.Count; i++)
        {
            Console.WriteLine($"Produto: {listaDeProduto[i].Nome}, Preço: {listaDeProduto[i].PrecoUnitario:F2}");
        }

        ConcluirOperacaoDoMenu.FinalizarMenu();
    }
}
