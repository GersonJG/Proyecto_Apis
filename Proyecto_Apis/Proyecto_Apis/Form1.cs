using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Proyecto_Apis
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void BotonBuscar_Click(object sender, EventArgs e)
        {
            int idJuego = Convert.ToInt32(textBoxId.Text);
            string url = $"https://www.cheapshark.com/api/1.0/games?id={idJuego}";
            try
            {
                string response = await client.GetStringAsync(url);
                JObject data = JObject.Parse(response);

                labelTitulo.Text = data["info"]["title"].ToString();
                labelTitulo.Visible = true;
                string imageUrl = data["info"]["thumb"].ToString();
                pictureBox1.Load(imageUrl);
                labelPrecioMin.Text = data["cheapestPriceEver"]["price"].ToString();
                labelPrecioMin.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Botonform2_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "";
            labelPrecioMin.Text = "";
            textBoxId.Text = "";
            pictureBox1.Image = null;

        }
    }
}
