using System.Xml.Linq;

namespace Funciones_Eunice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simpson a = new();
            a.ShowDialog();
            panel1.Hide();
            string name = ReglaSimpsons.name;
            pictureBox1.Image = Image.FromFile(name);
        }
    }
}