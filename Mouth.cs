public class Mouth : Shape
{


    public Mouth()
    {
        x1 = 75;
        x2 = 125;
        y1 = 130;
        y2 = 130;
        stroke = "black";
        strokeW = 2;
        data = "<line x1=" + x1 + " y1=" + y1 + " x2=" + x2 + " y2=" + y2 + " style=stroke:" + stroke + ";" + "stroke-width:" + strokeW + ";" + " />";
    }

    public Mouth(String style)
    {
        x1 = 75;
        x2 = 125;
        y1 = 130;
        y2 = 130;
        stroke = "black";
        strokeW = 2;
        if (style == "A") data = "<line x1=" + x1 + 2 + " y1=" + y1 + " x2=" + x2 + " y2=" + y2 + " style=stroke:" + "red" + ";" + "stroke-width:" + (strokeW + 2) + ";" + " />";
        else if (style == "B") data = "<line x1=" + (x1 + 5) + " y1=" + y1 + " x2=" + x2 + " y2=" + y2 + " style=stroke:" + "blue" + ";" + "stroke-width:" + strokeW + ";" + " />";
        else if (style == "C") data = "<line x1=" + (x1 - 5) + " y1=" + y1 + " x2=" + x2 + " y2=" + y2 + " style=stroke:" + "green" + ";" + "stroke-width:" + strokeW + ";" + " />";
    }

    public override string getString()
    {
        return data;
    }
}