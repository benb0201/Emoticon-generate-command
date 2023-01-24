public class Base : Shape
{
    public int radius;

    public Base()
    {
        data = "<circle cx=\"" + 100 + "\" cy=\"" + 100 + "\" r=" + 75 + " stroke=" + "black" + " stroke-width=" + 2 + " fill=" + "yellow" + " />";
    }

    public Base(int x, int y, int radius, String stroke, int strokeW, String fill)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
        this.stroke = stroke;
        this.strokeW = strokeW;
        this.fill = fill;
    }

    public override string getString()
    {
        if (data != "") return data;
        else data = "<circle cx=\"" + this.x + "\" cy=\"" + this.y + "\" r=" + this.radius + " stroke=" + this.stroke + " stroke-width=" + this.strokeW + " fill=" + this.fill + " />";
        return data;
    }
}