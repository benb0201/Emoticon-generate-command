public class Leftbrow : Shape
{
    public int radius;

    public Leftbrow()
    {
        data = "<path d=\"M" + 70 + " " + 45 + " " + "Q" + 75 + " " + 40 + " " + 80 + " " + 45 + "\" stroke=" + "black" + " stroke-width=" + 2 + " fill=" + "black" + " />";
    }

    public Leftbrow(String style)
    {
        if (style == "A") data = "<path d=\"M 70 45 Q 75 40 80 45" + "stroke=" + "red" + "stroke-width=" + 4 + " fill=" + "green" + " />";
        else if (style == "B") data = "<path d=\"M 75 45 Q 80 40 80 45" + "stroke=" + "purple" + "stroke-width=" + 4 + " fill=" + "red" + " />";
        else if (style == "C") data = "<path d=\"M 65 45 Q 70 40 80 45" + "stroke=" + "orange" + "stroke-width=" + 4 + " fill=" + "blue" + " />";
    }

    public override string getString()
    {
        return data;
    }
}