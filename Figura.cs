using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

public abstract class Figura
{
  protected Color _color;
  public Figura(Color color)
  {
    this._color = color;
  }

  public abstract double GetArea();
  public override string ToString()
  {
    return $"Color: ({_color.Red}, {_color.Green}, {_color.Blue})";
  }

}