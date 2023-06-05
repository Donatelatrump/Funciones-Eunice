using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using MathNet.Numerics;
using ScottPlot;

namespace Funciones_Eunice
{
    internal class ReglaSimpsons
    {
        static double Funcion(double x)
        {
            return Math.Pow(x, 2);
        }

        static double ReglaSimpson(double a, double b, int n)
        {
            // Implementa la regla de Simpson para aproximar la integral definida.
            double h = (b - a) / n;
            double[] x = MathNet.Numerics.Generate.LinearSpaced(n + 1, a, b);
            double[] y = x.Select(Funcion).ToArray();
            double suma = y[0] + y[n];
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    suma += 2 * y[i];
                }
                else
                {
                    suma += 4 * y[i];
                }
            }

            double integral = (h / 3) * suma;
            return integral;
        }
        public static string name = "ReglaSimpson.png";
        [Obsolete]
        public static string Calcular(double a, double b, int n)
        {
 

            // Aproximación de la integral utilizando la regla de Simpson
            double aproximacion = ReglaSimpson(a, b, n);
            MessageBox.Show("Aproximación de la integral: " + aproximacion);

            // Graficar la función y la aproximación
            var plt = new ScottPlot.Plot(800, 600);
            double[] x = ScottPlot.DataGen.Range(a, b, 0.01);
            double[] y = x.Select(Funcion).ToArray();

            plt.PlotScatter(x, y, label: "Función");

            // Agregar los puntos de los intervalos
            double[] intervalX = new double[n + 1];
            double[] intervalY = new double[n + 1];
            for (int i = 0; i <= n; i++)
            {
                intervalX[i] = a + i * ((b - a) / n);
                intervalY[i] = Funcion(intervalX[i]);
            }
            plt.PlotScatter(intervalX, intervalY, markerShape: MarkerShape.filledCircle, color: System.Drawing.Color.Red, markerSize: 5);

            plt.PlotFill(x, y, fillColor: System.Drawing.Color.Blue, fillAlpha: 0.2, label: "Área bajo la curva");

            plt.Title("Regla de Simpson - Aproximación de la Integral");
            plt.XLabel("x");
            plt.YLabel("y");
            plt.Grid(true);

            plt.Legend(location: ScottPlot.Alignment.UpperRight);

            // Mostrar el gráfico
            plt.SaveFig("ReglaSimpson.png");
            return "ReglaSimpson.png";
        }
    }
    }

