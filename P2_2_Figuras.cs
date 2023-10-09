//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    Color Rojo = new Color(255, 0, 0, 0);

    Rectangulo rectangulo = new Rectangulo(Rojo, 8.0, 2.0);
    Circulo circulo = new Circulo(Rojo, 4.3);
    TrianguloEquilatero triangulo = new TrianguloEquilatero(Rojo, 6.8);
    Console.WriteLine(rectangulo.ToString());
    Console.WriteLine($"Área del rectángulo: {rectangulo.GetArea()}");

    Console.WriteLine(circulo.ToString());
    Console.WriteLine($"Área del círculo: {circulo.GetArea()}");

    Console.WriteLine(triangulo.ToString());
    Console.WriteLine($"Área del triángulo equilátero: {triangulo.GetArea()}");

    rectangulo.BaseRectangulo = 10.0;
    circulo.Radio = 5.0;
    triangulo.LongitudLado = 8.2;
    Console.WriteLine(rectangulo.ToString());
    Console.WriteLine($"Área del rectángulo: {rectangulo.GetArea()}");

    Console.WriteLine(circulo.ToString());
    Console.WriteLine($"Área del círculo: {circulo.GetArea()}");

    Console.WriteLine(triangulo.ToString());
    Console.WriteLine($"Área del triángulo equilátero: {triangulo.GetArea()}");


  }

}