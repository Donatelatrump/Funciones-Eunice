using NCalc;
using ScottPlot;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Funciones_Eunice
{
    internal class ReglaSimpsons
    {

        public static double limitea = 0;
        public static double limiteb = 0;
        public static int limiten = 0;
        public static string expresion2 = "";
        public static double resultado = 0;
        public static string tiempo1 = "";

        [Obsolete]
        public static void Regla_Simpson(string expresion, double a, double b, int n, PictureBox pictureBox,Label label)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            limitea = a;
            limiteb = b;
            limiten = n;
            expresion2 = expresion;
            try
            {
                // Reemplazar x^n por x*x*x*...*x
                expresion = Regex.Replace(expresion, @"x\^(\d+)", match =>
                {
                    int repeticiones = int.Parse(match.Groups[1].Value);
                    return "x" + string.Concat(Enumerable.Repeat("*x", repeticiones - 1));
                });

                Expression expression = new Expression(expresion);

                var plt = new Plot(pictureBox.Width, pictureBox.Height);

                double[] xValues = DataGen.Range(a, b, 0.01);

                double[] yValues = new double[xValues.Length];
                for (int i = 0; i < xValues.Length; i++)
                {
                    expression.Parameters["x"] = xValues[i];
                    yValues[i] = Convert.ToDouble(expression.Evaluate());
                }

                plt.PlotScatter(xValues, yValues, label: "Función");

                // Cálculo de la regla de Simpson
                double h = (b - a) / n;
                double area = 0;

                for (int i = 1; i <= n; i++)
                {
                    double xi = a + (i - 1) * h;
                    double xi1 = a + i * h;
                    double xiMid = (xi + xi1) / 2;

                    expression.Parameters["x"] = xi;
                    double yi = Convert.ToDouble(expression.Evaluate());

                    expression.Parameters["x"] = xi1;
                    double yi1 = Convert.ToDouble(expression.Evaluate());

                    expression.Parameters["x"] = xiMid;
                    double yiMid = Convert.ToDouble(expression.Evaluate());

                    area += (h / 6) * (yi + 4 * yiMid + yi1);

                    double[] intervalX = { xi, xiMid, xi1 };
                    double[] intervalY = { yi, yiMid, yi1 };

                    plt.PlotPolygon(intervalX, intervalY, fillColor: System.Drawing.Color.FromArgb(100, System.Drawing.Color.Red));
                }

                //Si area es negativa convertirla a positiva
                if (area < 0)
                {
                    area *= -1;
                }

                // Mostrar el resultado de la regla de Simpson en el gráfico
                plt.Title($"Gráfico de la función\nÁrea (Regla de Simpson): {area}");
                resultado = area;
                // Configuración de las etiquetas del gráfico
                plt.XLabel("x");
                plt.YLabel("y");
                plt.Grid(true);
                plt.Legend(location: Alignment.UpperRight);

                // Mostrar el gráfico en el PictureBox
                pictureBox.Image = plt.GetBitmap();

                stopwatch.Stop();
                TimeSpan tiempo = stopwatch.Elapsed;
                label.Text=("Tiempo de ejecución: " + tiempo.ToString("s\\.ffffff") + " Segundos");
                tiempo1 = tiempo.ToString("s\\.ffffff") + " Segundos";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al evaluar la expresión matemática: " + ex.Message);
            }
        }

    }

}
    

