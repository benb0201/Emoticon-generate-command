// Concrete Command
// Connects Invoker to Canvas
public class AddShapeCommand : ICommand //Inherits from Command interface
{
    private Emoticon emoticon;
    private Shape shape;

    public AddShapeCommand(Emoticon emoticon, Shape shape)
    {
        this.emoticon = emoticon;
        this.shape = shape;
    }

    public override void Execute()
    {
        this.emoticon.AddShape(shape);
    }

    public override void UnExecute()
    {
        // this.emoticon.RemoveShape(typeof(Shape));
        this.emoticon.RemoveShape(shape.GetType());
    }
}
