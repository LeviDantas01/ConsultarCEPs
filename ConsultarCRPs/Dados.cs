using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarCEPs
{
    public record Dados (string cep, string uf, string localidade, string bairro, string logradouro)
    {

    }
}
