public class Righteye : Shape
{
    public int radius;

    public Righteye()
    {
        x = 125;
        y = 60;
        radius = 10;
        stroke = "black";
        strokeW = 2;
        fill = "black";
        data = "<circle cx=\"" + x + "\" cy=\"" + y + "\" r=" + radius + " stroke=" + stroke + " stroke-width=" + strokeW + " fill=" + fill + " />";
    }

    public Righteye(String style)
    {
        x = 125;
        y = 60;
        radius = 10;
        stroke = "black";
        strokeW = 2;
        fill = "black";
        if (style == "A") data = "<circle cx=\"" + x + "\" cy=\"" + y + "\" r=" + radius + " stroke=" + "pink" + " stroke-width=" + (strokeW = 2) + " fill=" + "green" + " />";
        else if (style == "B")
        {
            radius = radius - 5;
            data = "<circle cx=\"" + x + "\" cy=\"" + y + "\" r=" + radius + " stroke=" + "blue" + " stroke-width=" + strokeW + " fill=" + fill + " />"; //Skinny variant
        }
        else if (style == "C")
        {
            radius = radius + 5;
            data = "<circle cx=\"" + x + "\" cy=\"" + y + "\" r=" + radius + " stroke=" + "red" + " stroke-width=" + strokeW + " fill=" + fill + " />";//Wide variant
        }
    }

    public override string getString()
    {
        return data;
    }
}