using System.Xml.Linq;
using System.Drawing;
using MathNet.Symbolics;
using System.Security.Cryptography;

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
            int panel1TargetX = -panel1.Width; // Posición final en el eje X para ocultar el Panel1
            int panelSimpsonTargetX = 0; // Posición final en el eje X para mostrar el PanelSimpson

            // Configurar la posición inicial de los paneles
            panel1.Location = new Point(panel1.Location.X, 0);
            panel.Location = new Point(panel1.Location.X + panel1.Width, 0);

            // Animación para ocultar el Panel1 y mostrar el PanelSimpson
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 6; // Intervalo de actualización de la animación (en milisegundos)
            animationTimer.Tick += (sender, e) =>
            {
                // Actualizar la posición de los paneles en cada tick del timer
                panel1.Location = new Point(panel1.Location.X - 10, panel1.Location.Y);
                panel.Location = new Point(panel.Location.X - 10, panel.Location.Y);

                // Verificar si se alcanzó la posición final y detener la animación
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
            int panel1TargetX = 0; // Posición final en el eje X para mostrar el Panel1
            int panelSimpsonTargetX = panel1.Width; // Posición final en el eje X para ocultar el PanelSimpson

            // Configurar la posición inicial de los paneles
            panel1.Location = new Point(-panel1.Width, 0);
            panel.Location = new Point(0, 0);

            // Animación para ocultar el PanelSimpson y mostrar el Panel1
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 6; // Intervalo de actualización de la animación (en milisegundos)
            animationTimer.Tick += (sender, e) =>
            {
                // Actualizar la posición de los paneles en cada tick del timer
                panel1.Location = new Point(panel1.Location.X + 10, panel1.Location.Y);
                panel.Location = new Point(panel.Location.X + 10, panel.Location.Y);

                // Verificar si se alcanzó la posición final y detener la animación
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
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MaterialTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void MaterialTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void materialTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void materialTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void materialTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Botones para calcular y limpiar
        [Obsolete]
        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            ReglaSimpsons.Regla_Simpson(materialTextBox1.Text, Convert.ToDouble(materialTextBox2.Text), Convert.ToDouble(materialTextBox3.Text), Convert.ToInt32(materialTextBox4.Text), pictureBox1, Tiempo_Simpson);

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
            ReglaTrapecio.Regla_Trapecio(materialTextBox8.Text, Convert.ToDouble(materialTextBox7.Text), Convert.ToDouble(materialTextBox6.Text), Convert.ToInt32(materialTextBox5.Text), pictureBox3, Tiempo_Trapecio);
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


        string desplegar_filedialog()
        {
            // Crea una instancia del cuadro de diálogo de selección de archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configura las propiedades del cuadro de diálogo
            openFileDialog.Title = "Seleccionar archivo";
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            // Muestra el cuadro de diálogo y espera a que el usuario seleccione un archivo
            DialogResult result = openFileDialog.ShowDialog();

            // Verifica si el usuario ha seleccionado un archivo y presionado el botón "Aceptar"
            if (result == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string selectedFilePath = openFileDialog.FileName;
                LecturaYExportacion a = new();
                return selectedFilePath;
            }
            else
            {
                return "";
            }

        }//lectura

        string desplegar_filedialo() // escritura
        {

            // Crea una instancia del cuadro de diálogo de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Configura las propiedades del cuadro de diálogo
            saveFileDialog.Title = "Guardar archivo";
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.CheckPathExists = true;

            // Muestra el cuadro de diálogo y espera a que el usuario seleccione una ruta de archivo
            DialogResult result = saveFileDialog.ShowDialog();

            // Verifica si el usuario ha seleccionado una ruta de archivo y presionado el botón "Aceptar"
            if (result == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string selectedFilePath = saveFileDialog.FileName;

                // Retorna la ruta del archivo seleccionado
                return selectedFilePath;
            }

            // Si el usuario cancela el cuadro de diálogo o cierra sin seleccionar un archivo, retorna una cadena vacía
            return string.Empty;
        }



        LecturaYExportacion a = new();


        #region Botones leer y exportar archivos Trapecio
        //Leer archivo panel trapecio
        private void materialButton7_Click(object sender, EventArgs e)//Lectura
        {

            string info = a.ReadTextFile(desplegar_filedialog());
            string[] info2 = info.Split(',');
            materialTextBox8.Text = info2[0];
            materialTextBox7.Text = info2[1];
            materialTextBox6.Text = info2[2];
            materialTextBox5.Text = info2[3];
        }
        private void materialButton9_Click(object sender, EventArgs e) //Exportar
        {
            string informacion = "Formula: " + ReglaTrapecio.expresion2 + " Limite a: " + ReglaTrapecio.limitea + " Limite b: " + ReglaTrapecio.limiteb + " Numero de intervalos: " + ReglaTrapecio.limiten + " Resultado: " + ReglaTrapecio.resultado + "Tiempo : " + ReglaTrapecio.tiempo1 + " \n";
            a.WriteTextToFile(desplegar_filedialo(), informacion);

        }

        #endregion

        #region Botonos leer y exportar simpson
        private void materialButton8_Click(object sender, EventArgs e) //simpson
        {

            string info = a.ReadTextFile(desplegar_filedialog());
            string[] info2 = info.Split(',');
            materialTextBox1.Text = info2[0];
            materialTextBox2.Text = info2[1];
            materialTextBox3.Text = info2[2];
            materialTextBox4.Text = info2[3];
        }

        private void materialButton10_Click(object sender, EventArgs e)//exportar simpson
        {
            string informacion = "Formula: " + ReglaSimpsons.expresion2 + " Limite a: " + ReglaSimpsons.limitea + " Limite b: " + ReglaSimpsons.limiteb + " Numero de intervalos: " + ReglaSimpsons.limiten + " Resultado: " + ReglaSimpsons.resultado +" Tiempo" + ReglaSimpsons.tiempo1 + " \n";
            a.WriteTextToFile(desplegar_filedialo(), informacion);

        }
        #endregion

    }
}