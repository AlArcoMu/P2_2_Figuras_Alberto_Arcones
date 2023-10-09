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
    Console.WriteLine(rectangulo);
    Console.WriteLine($"Área del rectángulo: {rectangulo.GetArea()}");

    Console.WriteLine(circulo);
    Console.WriteLine($"Área del círculo: {circulo.GetArea()}");

    Console.WriteLine(triangulo);
    Console.WriteLine($"Área del triángulo equilátero: {triangulo.GetArea()}");

    rectangulo.BaseRectangulo = 10.0;
    circulo.Radio = 5.0;
    triangulo.LongitudLado = 8.2;
    Console.WriteLine(rectangulo);
    Console.WriteLine($"Área del rectángulo: {rectangulo.GetArea()}");

    Console.WriteLine(circulo);
    Console.WriteLine($"Área del círculo: {circulo.GetArea()}");

    Console.WriteLine(triangulo);
    Console.WriteLine($"Área del triángulo equilátero: {triangulo.GetArea()}");

    /*
    Crear La lista para añadir las figuras
    */
    List<Figura> lista_figuras = new List<Figura>();
    Color colorRojo = new Color(255, 0, 0, 0);
    Color colorVerde = new Color(0, 255, 0, 0);

    Rectangulo rectangulo1 = new Rectangulo(colorRojo, 5.0, 3.0);
    Circulo circulo1 = new Circulo(colorVerde, 4.0);
    TrianguloEquilatero triangulo1 = new TrianguloEquilatero(colorRojo, 6.0);

    Rectangulo rectangulo2 = new Rectangulo(colorVerde, 4.0, 2.0);
    Circulo circulo2 = new Circulo(colorRojo, 3.0);
    TrianguloEquilatero triangulo2 = new TrianguloEquilatero(colorVerde, 5.0);

    lista_figuras.Add(rectangulo1);
    lista_figuras.Add(circulo1);
    lista_figuras.Add(triangulo1);
    lista_figuras.Add(triangulo2);
    lista_figuras.Add(circulo2);
    lista_figuras.Add(triangulo2);


    foreach (Figura figura in lista_figuras)
    {
      Console.WriteLine(figura);
      Console.WriteLine($"Área: {figura.GetArea()}");
      Console.WriteLine();
    }

    //Cambio color 
    Color nuevoColor = new Color(245, 40, 145, 200);

    foreach (Figura figura in lista_figuras)
    {
      figura.CambiarColor(nuevoColor);
    }
    foreach (Figura figura in lista_figuras)
    {
      Console.WriteLine(figura);
      Console.WriteLine($"Área: {figura.GetArea()}");
      Console.WriteLine();
    }

    //Suma de las areas totales
    double AreaTotal = 0;

    foreach (Figura figura in lista_figuras)
    {
      AreaTotal += figura.GetArea();
    }
    Console.WriteLine($"ÁreaTotal: {AreaTotal}");

  }
}