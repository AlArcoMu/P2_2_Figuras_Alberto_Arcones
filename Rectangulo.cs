namespace P2_2_Figuras;
public class Rectangulo : Figura
{
    private double baseRectangulo;
    private double altura;

    public Rectangulo(Color color, double baseRectangulo, double altura) : base(color)
    {
        this.baseRectangulo = baseRectangulo;
        this.altura = altura;
    }

    public override double GetArea()
    {
        return baseRectangulo * altura;
    }

    public double BaseRectangulo
    {
        get { return baseRectangulo; }
        set { baseRectangulo = value; }
    }

    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }
    public override string ToString()
    {
        return $"Rectángulo - Base: {BaseRectangulo}, Altura: {Altura}, Área: {GetArea()}, {base.ToString()}";
    }
}