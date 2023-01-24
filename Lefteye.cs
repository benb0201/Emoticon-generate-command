public class Lefteye : Shape
{
    public int radius;

    public Lefteye()
    {
        data = "<circle cx=\"" + 75 + "\" cy=\"" + 60 + "\" r=" + 10 + " stroke=" + "black" + " stroke-width=" + 2 + " fill=" + "black" + " />";
    }
    //overide polymorphism
    public Lefteye(string style)
    {
        x = 75;
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