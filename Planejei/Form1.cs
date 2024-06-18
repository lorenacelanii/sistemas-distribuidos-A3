using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace projcadastro
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void listaview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Método assíncrono para editar um usuário
        private async Task EditarUsuarioAsync(string id, string name, string email, string password)
        {
            string apiUrl = $"https://localhost:7243/api/Users/{id}"; // URL do endpoint de edição

            // Criação do objeto usuário para ser enviado na requisição
            var user = new User
            {
                Id = id,
                Name = name,
                Email = email,
                Password = password
            };

            // Serializa o objeto usuário para JSON
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PutAsync(apiUrl, data);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Usuário atualizado com sucesso!");
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Erro ao consumir a API: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private async void btn_editar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem de Popup");
            // Exemplo de dados do usuário a ser editado
            string userId = "605c72c882d8f60ac41d7877"; // Substitua pelo ID real do usuário
            string userName = "Nome Atualizado";
            string userEmail = "email@atualizado.com";
            string userPassword = "novaSenha";

            await EditarUsuarioAsync(userId, userName, userEmail, userPassword);
        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void textbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
