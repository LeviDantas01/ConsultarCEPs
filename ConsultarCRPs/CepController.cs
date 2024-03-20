using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarCEPs
{
    public class CepController
    {

        public static async Task<string> GetCep(string cep)
        {
            using (var client = new HttpClient())
            {
                if (!string.IsNullOrWhiteSpace(cep))
                {
                    try
                    {
                        var url = $"https://viacep.com.br/ws/{cep}/json/";
                        var response = await client.GetAsync(url);
                        response.EnsureSuccessStatusCode();
                        var content = await response.Content.ReadAsStringAsync();
                        var endereco = JsonConvert.DeserializeObject<Dados>(content);
                        return content;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, cep, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                }
                else
                {
                    MessageBox.Show("Digite um CEP valido");
                    return null;
                }
            }
        }

    }
}
