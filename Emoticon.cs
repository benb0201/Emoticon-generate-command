public class Emoticon //Reciever class
{
    List<Shape> emoticon; // List of Shape objects 
    // List<string> emoticonSVG = drawSVG(); // List of
    public Emoticon()
    {
        emoticon = new List<Shape>(); //resets canvas when created
    }

    //Adds a shape object to the canvas object list
    public void AddShape(Shape shape) //uses shape parameter from AddShapeCommand class
    {
        emoticon.Add(shape);
    }

    public void RemoveShape(Type type)
    {
        emoticon.RemoveAll(x => x.GetType() == type);
    }


    // .Contains constructor for helping make sure there are no duplicate features
    public bool Contains(Type type)
    {
        foreach (var shape in emoticon)
        {
            if ((shape.GetType()).Equals(type)) return true;
        }
        return false;
    }

    public void Move(Shape shape, int direction, int value)
    {
        if (direction == 1)
        {
            shape.data = shape.data.Replace(" />", " transform=\"translate(0, -" + value + ")\" >");
        }
        else if (direction == 2)
        {
            shape.data = shape.data.Replace(" />", " transform=\"translate(0, " + value + ")\" >");
        }
        else if (direction == 3)
        {
            shape.data = shape.data.Replace(" />", " transform=\"translate(-" + value + ", 0)\" >");
        }
        else if (direction == 4)
        {
            shape.data = shape.data.Replace(" />", " transform=\"translate(" + value + ", 0)\" >");
        }
    }

    public void Rotate(Shape shape, int direction, int degrees)
    {
        string transform = "";
        if (direction == 1)
        {
            transform = "rotate(" + degrees + " 0 0)";
        }
        else if (direction == 2)
        {
            transform = "rotate(" + -degrees + " 0 0)";
        }

        shape.data = shape.data.Replace(" />", " transform='" + transform + "' />");
    }


    public void Display() //Display canvas to terminal
    {
        int indx = 0;
        foreach (var shape in emoticon) //Prints out all strings in canvas with their index and shape name
        {
            Console.WriteLine(indx + ": " + shape + " [" + shape.getString() + "]");
            // int index = shape.data.IndexOf(">");
            // Console.WriteLine(shape.data.Substring(0, index - 1));
            indx++;
        }
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }

    public List<string> drawSVG()
    {
        List<string> emoticonSVG = new List<string>();
        emoticonSVG.Add("<svg viewBox=\"0 0 400 200\" xmlns=\"http://www.w3.org/2000/svg\">");
        foreach (var shape in emoticon)
        {
            emoticonSVG.Add(shape.getString());
        }
        emoticonSVG.Add("</svg>");
        return emoticonSVG;
    }

    public void ToSVG() //Makes an svg file
    {
        File.WriteAllLines("C:/Users/bened/OneDrive/Documents/CS264/coding-assignment-command/shapes.svg", drawSVG());
    }
}