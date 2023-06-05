using NCalc;
using ScottPlot;

namespace Funciones_Eunice
{
    internal class ReglaSimpsons
    {
        [Obsolete]
        public static void CalcularYMostrarGrafico(string expresion, double a, double b, int n, PictureBox pictureBox)
        {
            try
            {
                Expression expression = new Expression(expresion);

                var plt = new Plot(pictureBox.Width, pictureBox.Height); // Crea un objeto Plot de ScottPlot con el tamaño del PictureBox
                double[] xValues = DataGen.Range(a, b, 0.01); // Genera un rango de valores x para graficar la función

                double[] yValues = new double[xValues.Length];
                for (int i = 0; i < xValues.Length; i++)
                {
                    expression.Parameters["x"] = xValues[i];
                    yValues[i] = Convert.ToDouble(expression.Evaluate());
                }

                plt.PlotScatter(xValues, yValues, label: "Función"); // Grafica la función como puntos

                // Graficar los intervalos
                double intervalSize = (b - a) / n; // Tamaño de cada intervalo
                for (int i = 0; i < n; i++)
                {
                    double intervalStart = a + i * intervalSize; // Inicio del intervalo
                    double intervalEnd = intervalStart + intervalSize; // Fin del intervalo

                    // Evaluar la función en los puntos del intervalo
                    double[] intervalX = { intervalStart, intervalEnd };
                    double[] intervalY = new double[intervalX.Length];
                    for (int j = 0; j < intervalX.Length; j++)
                    {
                        expression.Parameters["x"] = intervalX[j];
                        intervalY[j] = Convert.ToDouble(expression.Evaluate());
                    }

                    plt.PlotScatter(intervalX, intervalY, markerShape: MarkerShape.filledCircle, color: System.Drawing.Color.Red, markerSize: 10); // Grafica los puntos del intervalo en rojo
                }

                // Configurar título y etiquetas
                plt.Title("Gráfico de la función");
                plt.XLabel("x");
                plt.YLabel("y");
                plt.Grid(true);

                plt.Legend(location: Alignment.UpperRight);

                // Mostrar el gráfico
                pictureBox.Image = plt.GetBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al evaluar la expresión matemática: " + ex.Message);
            }
        }
        static double ReglaSimpson(double a, double b, int n, Expression expression)
    {
        double h = (b - a) / n;
        double suma = 0;

        for (int i = 0; i <= n; i++)
        {
            double x = a + i * h;
            expression.Parameters["x"] = x;

            double y = (double)expression.Evaluate();
            if (i == 0 || i == n)
            {
                suma += y;
            }
            else if (i % 2 == 0)
            {
                suma += 2 * y;
            }
            else
            {
                suma += 4 * y;
            }
        }

        return (h / 3) * suma;
    }


}

}
    

