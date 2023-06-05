using System.Xml.Linq;
using System.Drawing;
namespace Funciones_Eunice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PanelSimpson.Hide();


        }
        //Funcion de animacion para moverse del panel1 a PanelSimpson
        private void AnimatePanels()
        {
            int panel1TargetX = -panel1.Width; // Posición final en el eje X para ocultar el Panel1
            int panelSimpsonTargetX = 0; // Posición final en el eje X para mostrar el PanelSimpson

            // Configurar la posición inicial de los paneles
            panel1.Location = new Point(panel1.Location.X, 0);
            PanelSimpson.Location = new Point(panel1.Location.X + panel1.Width, 0);

            // Animación para ocultar el Panel1 y mostrar el PanelSimpson
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 5; // Intervalo de actualización de la animación (en milisegundos)
            animationTimer.Tick += (sender, e) =>
            {
                // Actualizar la posición de los paneles en cada tick del timer
                panel1.Location = new Point(panel1.Location.X - 10, panel1.Location.Y);
                PanelSimpson.Location = new Point(PanelSimpson.Location.X - 10, PanelSimpson.Location.Y);

                // Verificar si se alcanzó la posición final y detener la animación
                if (panel1.Location.X <= panel1TargetX && PanelSimpson.Location.X <= panelSimpsonTargetX)
                {
                    panel1.Visible = false;
                    PanelSimpson.Visible = true;
                    PanelSimpson.BringToFront();
                    animationTimer.Stop();
                }
            };

            animationTimer.Start();
        }

        //Funcion de animacion para ir de PanelSImpson a panel1
        private void AnimateBackToPanel1()
        {
            int panel1TargetX = 0; // Posición final en el eje X para mostrar el Panel1
            int panelSimpsonTargetX = panel1.Width; // Posición final en el eje X para ocultar el PanelSimpson

            // Configurar la posición inicial de los paneles
            panel1.Location = new Point(-panel1.Width, 0);
            PanelSimpson.Location = new Point(0, 0);

            // Animación para ocultar el PanelSimpson y mostrar el Panel1
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10; // Intervalo de actualización de la animación (en milisegundos)
            animationTimer.Tick += (sender, e) =>
            {
                // Actualizar la posición de los paneles en cada tick del timer
                panel1.Location = new Point(panel1.Location.X + 10, panel1.Location.Y);
                PanelSimpson.Location = new Point(PanelSimpson.Location.X + 10, PanelSimpson.Location.Y);

                // Verificar si se alcanzó la posición final y detener la animación
                if (Math.Abs(panel1.Location.X) >= Math.Abs(panel1TargetX) && Math.Abs(PanelSimpson.Location.X) >= Math.Abs(panelSimpsonTargetX))
                {
                    panel1.Visible = true;
                    PanelSimpson.Visible = false;
                    panel1.BringToFront();
                    animationTimer.Stop();
                }
            };

            animationTimer.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AnimatePanels();

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
            AnimateBackToPanel1();
        }
    }
}