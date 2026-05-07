using FormsPruebaApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPruebaApi
{
    public partial class Form1 : Form
    {

        private readonly string apiUrl = "https://localhost:7198/api/Usuarios"; // Reemplaza con tu URL de API

        private readonly HttpClient _httpclient;

        public Form1()
        {
            InitializeComponent();
            _httpclient = new HttpClient();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await listaRegistros();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            await CrearRegistro();
            listaRegistros(); // refresca la tabla
        }
        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await ActualizarRegistro();
            listaRegistros();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            await eliminarRegistro();
            listaRegistros();
        }
        private async void btnPatch_Click(object sender, EventArgs e)
        {
            listaRegistros();
            await actualizaParcia();
        }
        private async Task listaRegistros()
        {

            HttpResponseMessage response = await _httpclient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                var registros = JsonConvert.DeserializeObject<List<Usuarios>>(data);

                dgDatos.DataSource = registros;

                // Aquí ya tienes la lista correcta
            }
            else
            {
                MessageBox.Show($"Error: {response.ReasonPhrase}");
            }

        }

        private async Task CrearRegistro()
        {
            Usuarios registro = new Usuarios
            {
                Nombre = txbNombre.Text,
                Edad = int.Parse(txbEdad.Text),
                Matricula = int.Parse(txbMatricula.Text),
                Tipo = int.Parse(txbTipo.Text)
            };

            string jsonData = JsonConvert.SerializeObject(registro);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await _httpclient.PostAsync(apiUrl, content);

            if (response.IsSuccessStatusCode)
                MessageBox.Show("Creado");
            else
                MessageBox.Show("Error");
        }

        private async Task ActualizarRegistro()
        {
            int id = int.Parse(txbId.Text);

            Usuarios registroActualizado = new Usuarios
            {
                Nombre = txbNombre.Text,
                Edad = int.Parse(txbEdad.Text),
                Matricula = int.Parse(txbMatricula.Text),
                Tipo = int.Parse(txbTipo.Text)
            };

            string jsonData = JsonConvert.SerializeObject(registroActualizado);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpclient.PutAsync($"{apiUrl}/{id}", content);

            if (response.IsSuccessStatusCode)
                MessageBox.Show("Actualizado");
            else
                MessageBox.Show("Error");
        }

        private async Task eliminarRegistro()
        {
            int id = int.Parse(txbId.Text);

            HttpResponseMessage response = await _httpclient.DeleteAsync($"{apiUrl}/{id}");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Registro eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar registro: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task actualizaParcia()
        {
            var diccionarioDatos = new Dictionary<string, object>();

            diccionarioDatos.Add("Nombre", "Efrain");
            int id = 1;

            string jsonData = JsonConvert.SerializeObject(diccionarioDatos);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), $"{apiUrl}/{id}")
            {
                Content = content
            };

            HttpResponseMessage response = await _httpclient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Actualizado parcialmente");
            }

            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
