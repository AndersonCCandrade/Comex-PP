using System.Text.Json.Serialization;

namespace Comex.Modelo;

public class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }

    [JsonPropertyName("title")]
    public string Nome { get; set; }
    [JsonPropertyName("description")]
    public string Descricao { get; set; }
    [JsonPropertyName("price")]
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public string ExibiInformacaoDoProduto()
    {
        return $"Produto: {Nome} \n" +
                $"Descrição: {Descricao} \n" +
                $"Preco Unitário: {PrecoUnitario} \n";
    }
}
