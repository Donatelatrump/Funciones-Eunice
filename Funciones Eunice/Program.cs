/*
 
   ===> Materia <===
   PROGRAMACION CIENTIFICA   (4-A)

   ===> Integrantes <===
​   Kandy Fabiola López Flores 		326912 
   Miguel Ángel Durón Láriz 			331992 
​   César Donnet Hernández Gastelum 		283189 
​   Ramón Alejandro Alonso Hernández 	334052 
   
   ===> Metodos <===
   Regla de Simpson
   Regla de Trapecio

    ===> Descripción <===
*  Regla de Simpson
    La regla de Simpson es un método numérico utilizado para aproximar la integral de una función.
    Se basa en la idea de dividir el intervalo de integración en subintervalos y aproximar la función en 
    cada uno de ellos por medio de un polinomio de segundo grado. Luego, se calcula el área bajo cada 
    polinomio y se suma para obtener la aproximación de la integral total. La regla de Simpson ofrece una mayor
    precisión que otros métodos, ya que tiene en cuenta tanto el valor de la función en los extremos del intervalo como en su punto medio.

*   Regla del trapecio
    La regla del trapecio es otro método numérico utilizado para aproximar la integral de una función. Al igual que la regla 
    de Simpson, se divide el intervalo de integración en subintervalos, pero en este caso, se aproxima la función linealmente 
    en cada subintervalo mediante una recta. Luego, se calcula el área bajo cada recta y se suma para obtener la aproximación 
    de la integral total. Aunque la regla del trapecio es menos precisa que la regla de Simpson, sigue siendo un método ampliamente 
    utilizado debido a su simplicidad y facilidad de implementación.
   
   ===>Fecha de última actualización del código <===
    06/06/2023
*/
namespace Funciones_Eunice
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}