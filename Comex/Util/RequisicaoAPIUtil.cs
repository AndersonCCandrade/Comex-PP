namespace Comex.Util
{
    public class RequisicaoAPIUtil
    {
        HttpClient client = new HttpClient();

        public async Task<string> conexao(string uri = "https://fakestoreapi.com/products")
        {
            try
            {
                string resultado = await client.GetStringAsync(uri);
                return resultado;
            }
            catch (Exception ex)
            {

                return $"Temos um problema: {ex.Message}";
            }

        }

    }
}
