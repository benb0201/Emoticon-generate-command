public abstract class Shape //Parent class
{
    public int x;
    public int y;
    public string stroke;
    public int strokeW;
    public string fill;
    public string data;
    public string style;

    public int x1;
    public int x2;
    public int y1;
    public int y2;

    public virtual string getString()
    {
        // return "<rect width=\"" + this.x + "\" height=\"" + this.y + " />";
        return "Shape!";
    }
}