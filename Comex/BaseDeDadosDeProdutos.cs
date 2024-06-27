namespace Comex;

public static class DataBaseDeProdutos
{
    public static List<Produto> ListaDeProdutos()
    {
        List<Produto> ListaDeProdutos = new()
        {
            new Produto("Notebook")
            {
                Descricao = "Notebook Dell Inspiron",
                PrecoUnitario = 3500.00,
                Quantidade = 10
            },
            new Produto("Smartphone")
            {
                Descricao = "Smartphone Samsung Galaxy",
                PrecoUnitario = 1200.00,
                Quantidade = 25
            },
            new Produto("Monitor")
            {
                Descricao = "Monitor LG Ultrawide",
                PrecoUnitario = 800.00,
                Quantidade = 15
            },
            new Produto("Teclado")
            {
                Descricao = "Teclado Mecânico RGB",
                PrecoUnitario = 250.00,
                Quantidade = 50
            }
        };
        return ListaDeProdutos;
    }    
}
