public class Rightbrow : Shape
{
    public int radius;

    public Rightbrow()
    {
        data = "<path d=\"M 130 45 Q 125 40 120 45\" stroke=" + "black" + " stroke-width=" + 2 + " fill=" + "black" + " />";
    }

    public Rightbrow(String style)
    {
        if (style == "A") data = "<path d=\"M 130 45 Q 125 40 120 45" + "stroke=" + "red" + "stroke-width=" + 4 + " fill=" + "blue" + " />";
        else if (style == "B") data = "<path d=\"M 130 45 Q 125 40 120 45" + "stroke=" + "green" + "stroke-width=" + 5 + " fill=" + "orange" + " />";
        else if (style == "C") data = "<path d=\"M 130 45 Q 125 40 120 45" + "stroke=" + "blue" + "stroke-width=" + 1 + " fill=" + "brown" + " />";
    }

    public override string getString()
    {
        return data;
    }
}