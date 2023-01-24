public class ShapeFactory //Used factory to create shapes where not visible by client. It is also more efficient
{
    public Shape CreateShape(string shapeType)
    {
        if (shapeType == "Base")
        {
            return new Base();
        }
        else if (shapeType == "Lefteye")
        {
            return new Lefteye();
        }
        else if (shapeType == "Righteye")
        {
            return new Righteye();
        }
        else if (shapeType == "Leftbrow")
        {
            return new Leftbrow();
        }
        else if (shapeType == "Rightbrow")
        {
            return new Rightbrow();
        }
        else if (shapeType == "Mouth")
        {
            return new Mouth();
        }
        else
        {
            return null;
        }
    }
    public Shape CreateShape(string shapeType, string style)
    {
        if (shapeType == "Base")
        {
            return new Base();
        }
        else if (shapeType == "Lefteye")
        {
            return new Lefteye(style);
        }
        else if (shapeType == "Righteye")
        {
            return new Righteye(style);
        }
        else if (shapeType == "Leftbrow")
        {
            return new Leftbrow(style);
        }
        else if (shapeType == "Rightbrow")
        {
            return new Rightbrow(style);
        }
        else if (shapeType == "Mouth")
        {
            return new Mouth(style);
        }
        else
        {
            return null;
        }
    }
}