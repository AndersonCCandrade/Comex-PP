namespace Comex.Util
{
    public class RequisicaoAPIUtil
    {
        HttpClient client = new HttpClient();

        public async Task<string> conexao()
        {
            try
            {
                string resultado = await client.GetStringAsync("https://fakestoreapi.com/products");
                return resultado;
            }
            catch (Exception ex)
            {

                return $"Temos um problema: {ex.Message}";
            }

        }

    }
}
