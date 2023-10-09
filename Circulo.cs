namespace P2_2_Figuras;
public class Circulo : Figura
{
    private double radio;

    public Circulo(Color color, double radio) : base(color)
    {
        this.radio = radio;
    }

    public override double GetArea()
    {
        return Math.PI * radio * radio;
    }

    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }
    public override string ToString()
    {
        return $"Círculo - Radio: {Radio}, Área: {GetArea()}, {base.ToString()}";
    }
}