using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Proyecto_Apis
{

    public partial class Form2 : Form
    {
        private HttpClient client = new HttpClient();
        public Form2()
        {
            InitializeComponent();
        }

        private async void BotonBuscar2_Click(object sender, EventArgs e)
        {
            string gamename = textBox1.Text;
            string url = $"https://www.cheapshark.com/api/1.0/games?title={gamename}";

            try
            {
                // Al ser una lista lo hize de este modo: PASOS
                // Realiza la solicitud GET a la API
                string response = await client.GetStringAsync(url);

                // Deserializa el JSON en una lista de objetos
                var juegos = JsonConvert.DeserializeObject<List<Juegos>>(response);

                // Asigna la lista al DataGridView
                dataGridView1.DataSource = juegos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la API: " + ex.Message);
            }
        }

        private void botonregresar_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Botonlimpiar2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.DataSource = null;
        }
    }


}
