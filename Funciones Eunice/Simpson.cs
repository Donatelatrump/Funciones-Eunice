using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones_Eunice
{
    public partial class Simpson : Form
    {
        public Simpson()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(textBox4.Text);
         //  double func = double.Parse(textBox1.Text);//funcion
            double a = double.Parse(textBox2.Text);//limite inferior
            double b = double.Parse(textBox3.Text);//limite superior
            ReglaSimpsons.Calcular(a,b,n);
            Close();

        }
    }
}
