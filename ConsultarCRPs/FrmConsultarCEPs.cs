using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using WSCorreios;
using System.Net.Http.Json;
using ConsultarCEPs;
using Newtonsoft.Json;

namespace ConsultarCRPs
{

    public partial class FrmConsultarCEPs : Form
    {
        public FrmConsultarCEPs()
        {
            InitializeComponent();
        }

        private void FrmConsultarCEPs_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCEP.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtRua.Text = string.Empty;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            GetEndereco();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public async void GetEndereco()
        {
            var cep = txtCEP.Text;
            var json = await CepController.GetCep(cep);
            var endereco = JsonConvert.DeserializeObject<Dados>(json);

            txtEstado.Text = endereco.uf;
            txtCidade.Text = endereco.localidade;
            txtBairro.Text = endereco.bairro;
            txtRua.Text = endereco.logradouro;
        }
    }
}

