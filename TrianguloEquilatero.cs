
namespace P2_2_Figuras;
public class TrianguloEquilatero : Figura
{
    private double longitudLado;

    public TrianguloEquilatero(Color color, double longitudLado) : base(color)
    {
        this.longitudLado = longitudLado;
    }

    public override double GetArea()
    {
        return (Math.Sqrt(3) / 4) * longitudLado * longitudLado;
    }

    public double LongitudLado
    {
        get { return longitudLado; }
        set { longitudLado = value; }
    }
    public override string ToString()
    {
        return $"Triángulo Equilátero - Lado: {LongitudLado}, Área: {GetArea()}, {base.ToString()}";
    }
}