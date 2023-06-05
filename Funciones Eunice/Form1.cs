using System.Xml.Linq;
using System.Drawing;
namespace Funciones_Eunice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PanelSimpson.Visible = false;
            PanelTrapecio.Visible = false;
        }
        #region Animaciones de paneles
        //Funcion de animacion para moverse del panel1 a PanelSimpson
        private void AnimatePanels(Panel panel)
        {
            int panel1TargetX = -panel1.Width; // Posici�n final en el eje X para ocultar el Panel1
            int panelSimpsonTargetX = 0; // Posici�n final en el eje X para mostrar el PanelSimpson

            // Configurar la posici�n inicial de los paneles
            panel1.Location = new Point(panel1.Location.X, 0);
            panel.Location = new Point(panel1.Location.X + panel1.Width, 0);

            // Animaci�n para ocultar el Panel1 y mostrar el PanelSimpson
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 15; // Intervalo de actualizaci�n de la animaci�n (en milisegundos)
            animationTimer.Tick += (sender, e) =>
            {
                // Actualizar la posici�n de los paneles en cada tick del timer
                panel1.Location = new Point(panel1.Location.X - 10, panel1.Location.Y);
                panel.Location = new Point(panel.Location.X - 10, panel.Location.Y);

                // Verificar si se alcanz� la posici�n final y detener la animaci�n
                if (panel1.Location.X <= panel1TargetX && panel.Location.X <= panelSimpsonTargetX)
                {
                    animationTimer.Stop();
                }
            };

            animationTimer.Start();
        }

        //Funcion de animacion para ir de PanelSImpson a panel1
        private void AnimateBackToPanel1(Panel panel)
        {
            int panel1TargetX = 0; // Posici�n final en el eje X para mostrar el Panel1
            int panelSimpsonTargetX = panel1.Width; // Posici�n final en el eje X para ocultar el PanelSimpson

            // Configurar la posici�n inicial de los paneles
            panel1.Location = new Point(-panel1.Width, 0);
            panel.Location = new Point(0, 0);

            // Animaci�n para ocultar el PanelSimpson y mostrar el Panel1
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10; // Intervalo de actualizaci�n de la animaci�n (en milisegundos)
            animationTimer.Tick += (sender, e) =>
            {
                // Actualizar la posici�n de los paneles en cada tick del timer
                panel1.Location = new Point(panel1.Location.X + 10, panel1.Location.Y);
                panel.Location = new Point(panel.Location.X + 10, panel.Location.Y);

                // Verificar si se alcanz� la posici�n final y detener la animaci�n
                if (Math.Abs(panel1.Location.X) >= Math.Abs(panel1TargetX) && Math.Abs(panel.Location.X) >= Math.Abs(panelSimpsonTargetX))
                {
                    animationTimer.Stop();
                }
            };

            animationTimer.Start();
        }


        #endregion
        #region Panel Simpson
        private void Button1_Click(object sender, EventArgs e)
        {
            PanelTrapecio.Visible = false;
            PanelSimpson.Visible = true;
            AnimatePanels(PanelSimpson);

        }

        #region TextBox Solo reciben numeros
        private void MaterialTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MaterialTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void MaterialTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Botones para calcular y limpiar
        [Obsolete]
        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            ReglaSimpsons.CalcularYMostrarGrafico(materialTextBox1.Text, Convert.ToDouble(materialTextBox2.Text), Convert.ToDouble(materialTextBox3.Text), Convert.ToInt32(materialTextBox4.Text), pictureBox1);

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            materialTextBox1.Text = "";
            materialTextBox2.Text = "";
            materialTextBox3.Text = "";
            materialTextBox4.Text = "";
            pictureBox1.Image = null;
        }
        #endregion

        private void materialButton3_Click(object sender, EventArgs e)
        {
            AnimateBackToPanel1(PanelSimpson);
        }
        #endregion
        #region Panel Trapecio
        [Obsolete]
        private void materialButton6_Click(object sender, EventArgs e)
        {
            ReglaTrapecio.CalcularYMostrarGrafico(materialTextBox8.Text, Convert.ToDouble(materialTextBox7.Text), Convert.ToDouble(materialTextBox6.Text), Convert.ToInt32(materialTextBox5.Text), pictureBox3);
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            materialTextBox8.Text = "";
            materialTextBox7.Text = "";
            materialTextBox6.Text = "";
            materialTextBox5.Text = "";
            pictureBox3.Image = null;
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            PanelTrapecio.Visible = true;
            AnimateBackToPanel1(PanelTrapecio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelTrapecio.Visible = true;
            PanelSimpson.Visible = false;
            AnimatePanels(PanelTrapecio);


        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelTrapecio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}