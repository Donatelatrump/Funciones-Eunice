﻿using System;
using System.Windows.Forms;
using NCalc;
using ScottPlot;

namespace Funciones_Eunice
{
    internal class ReglaTrapecio
    {
        [Obsolete]
        public static void CalcularYMostrarGrafico(string expresion, double a, double b, int n, PictureBox pictureBox)
        {
            try
            {
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

                // Mostrar el resultado de la regla del trapecio en el gráfico
                plt.Title($"Gráfico de la función\nÁrea: {area}");

                // Configuración de las etiquetas del gráfico
                plt.XLabel("x");
                plt.YLabel("y");
                plt.Grid(true);
                plt.Legend(location: Alignment.UpperRight);

                // Mostrar el gráfico en el PictureBox
                pictureBox.Image = plt.GetBitmap();
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
