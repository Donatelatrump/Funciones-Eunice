using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NCalc;
using ScottPlot;

namespace Funciones_Eunice
{
    internal class ReglaTrapecio
    {
        public static double limitea = 0;
        public static double limiteb = 0;
        public static int limiten = 0;
        public static string expresion2 = "";
        public static double resultado = 0;
        public static string tiempo1 = "";
        [Obsolete]
        public static void Regla_Trapecio(string expresion, double a, double b, int n, PictureBox pictureBox,Label label)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            limitea = a;
            limiteb = b;
            limiten = n;
            expresion2 = expresion;
            try
            {
                expresion = Regex.Replace(expresion, @"x\^(\d+)", match =>
                {
                    int repeticiones = int.Parse(match.Groups[1].Value);
                    return "x" + string.Concat(Enumerable.Repeat("*x", repeticiones - 1));
                });

                // Creación de la función a partir de la expresión
                Func<double, double> funcion = x => EvaluateExpression(expresion, x);

                // Generación de los valores de x para graficar la función
                double[] xValues = DataGen.Range(a, b, 0.01);

                // Evaluación de la función en los valores de x
                double[] yValues = new double[xValues.Length];
                for (int i = 0; i < xValues.Length; i++)
                {
                    yValues[i] = funcion(xValues[i]);
                }

                // Creación del objeto Plot para graficar
                var plt = new Plot(pictureBox.Width, pictureBox.Height);

                // Graficar la función como puntos
                plt.PlotScatter(xValues, yValues, label: "Función");

                // Cálculo del área utilizando la regla del trapecio
                double h = (b - a) / n;
                double area = 0;

                for (int i = 1; i < n; i++)
                {
                    double xi = a + i * h;
                    area += funcion(xi);
                }

                area += (funcion(a) + funcion(b)) / 2;
                area *= h;

                // Graficar los puntos del trapecio
                for (int i = 0; i < n; i++)
                {
                    double xi = a + i * h;
                    double xi1 = xi + h;

                    double[] intervalX = { xi, xi, xi1, xi1 };
                    double[] intervalY = { 0, funcion(xi), funcion(xi1), 0 };

                    plt.PlotPolygon(intervalX, intervalY, fillColor: System.Drawing.Color.FromArgb(100, System.Drawing.Color.Red));
                }
                //Si area es negativa convertirla a positiva
                if (area < 0)
                {
                    area *= -1;
                }
                // Mostrar el resultado de la regla del trapecio en el gráfico
                plt.Title($"Gráfico de la función\nÁrea: {area}");
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
                label.Text =("Tiempo de ejecución: " + tiempo.ToString("s\\.ffffff") + " Segundos");
                tiempo1 =  tiempo.ToString("s\\.ffffff") + " Segundos";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al evaluar la expresión matemática: " + ex.Message);
            }
        }
        private static double EvaluateExpression(string expression, double x)
        {
            var eval = new NCalc.Expression(expression);
            eval.Parameters["x"] = x;
            return Convert.ToDouble(eval.Evaluate());

        }


    }
}
