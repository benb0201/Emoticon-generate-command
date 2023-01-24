using System;
class Program
{
    public static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory(); //Used factory to create shapes where not visible by client. It is also more efficient
        Emoticon emo = new Emoticon(); //Create canvas object
        Invoker invoker = new Invoker();  //Create user object
        //first add default face
        Base face = new Base();
        emo.AddShape(face);
        bool exit = false;
        while (exit == false)
        {
            Console.Clear(); //clears whatever is in the console
            Console.WriteLine("Choose a command below");
            Console.WriteLine("----------------------");
            Console.WriteLine("1): add");//{ left-eye	|	right-eye	|	left-brow	|	right-brow	|	mouth}
            Console.WriteLine("2): remove");//{	left-eye	|	right-eye	|	left-brow	|	right-brow	|	mouth}
            Console.WriteLine("3): move");//{ left-eye	|	right-eye	|	left-brow	|	right-brow	|	mouth}	{up	|	down	|	left	|	right	}	value (units)
            Console.WriteLine("4): rotate");//{	left-eye	|	right-eye	|	left-brow	|	right-brow	|	mouth}	{	clockwise	|	anticlockwise	}	degrees
            Console.WriteLine("5): style");//{	left-eye	|	right-eye	|	left-brow	|	right-brow	|	mouth}	{	A	|	B	|	C}
            Console.WriteLine("6): save(svg)");//{	<file>		}
            Console.WriteLine("7): draw");
            Console.WriteLine("8): undo");
            Console.WriteLine("9): redo");
            Console.WriteLine("10): help");
            Console.WriteLine("0): quit");
            int choice = Int16.Parse(Console.ReadLine());
            //declaring outside if statement so we can change coordinate values for moving if(choice == 3).
            var lefteye = new Lefteye();
            var righteye = new Righteye();
            var leftbrow = new Leftbrow();
            var rightbrow = new Rightbrow();
            var mouth = new Mouth();
            if (choice == 0) exit = true;
            else if (choice == 1)
            {
                Console.WriteLine("Choose a feature to add below");
                Console.WriteLine("----------------------");
                Console.WriteLine("1): left-eye");
                Console.WriteLine("2): right-eye");
                Console.WriteLine("3): left-brow");
                Console.WriteLine("4): right-brow");
                Console.WriteLine("5): mouth");
                int add = Int16.Parse(Console.ReadLine());
                if (add == 1)
                {
                    if (emo.Contains(typeof(Lefteye)))
                    {
                        Console.WriteLine("Emoticon already contains identical feature");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        lefteye = factory.CreateShape("Lefteye") as Lefteye;
                        AddShapeCommand lefteyecommand = new AddShapeCommand(emo, lefteye); //create AddShapeCommand object with new shape
                        invoker.AddCommand(lefteyecommand); //Add command to command history stack
                        // emo.AddShape(lefteye);
                    }
                }
                else if (add == 2)
                {
                    if (emo.Contains(typeof(Righteye)))
                    {
                        Console.WriteLine("Emoticon already contains identical feature");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        righteye = factory.CreateShape("Righteye") as Righteye;
                        AddShapeCommand righteyecommand = new AddShapeCommand(emo, righteye); //create AddShapeCommand object with new shape
                        invoker.AddCommand(righteyecommand); //Add command to command history stack
                        // emo.AddShape(righteye);
                    }
                }
                else if (add == 3)
                {
                    if (emo.Contains(typeof(Leftbrow)))
                    {
                        Console.WriteLine("Emoticon already contains identical feature");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        leftbrow = factory.CreateShape("Leftbrow") as Leftbrow;
                        AddShapeCommand leftbrowcommand = new AddShapeCommand(emo, leftbrow); //create AddShapeCommand object with new shape
                        invoker.AddCommand(leftbrowcommand); //Add command to command history stack
                        // emo.AddShape(leftbrow);
                    }
                }
                else if (add == 4)
                {
                    if (emo.Contains(typeof(Rightbrow)))
                    {
                        Console.WriteLine("Emoticon already contains identical feature");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        rightbrow = factory.CreateShape("Rightbrow") as Rightbrow;
                        AddShapeCommand rightbrowcommand = new AddShapeCommand(emo, rightbrow); //create AddShapeCommand object with new shape
                        invoker.AddCommand(rightbrowcommand); //Add command to command history stack
                        // emo.AddShape(rightbrow);
                    }
                }
                else if (add == 5)
                {
                    if (emo.Contains(typeof(Mouth)))
                    {
                        Console.WriteLine("Emoticon already contains identical feature");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        mouth = factory.CreateShape("Mouth") as Mouth;
                        AddShapeCommand mouthcommand = new AddShapeCommand(emo, mouth); //create AddShapeCommand object with new shape
                        invoker.AddCommand(mouthcommand); //Add command to command history stack
                        // emo.AddShape(mouth);
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Choose a feature to remove below");
                Console.WriteLine("----------------------");
                Console.WriteLine("1): left-eye");
                Console.WriteLine("2): right-eye");
                Console.WriteLine("3): left-brow");
                Console.WriteLine("4): right-brow");
                Console.WriteLine("5): mouth");
                int remove = Int16.Parse(Console.ReadLine());
                if (remove == 1)
                {
                    emo.RemoveShape(typeof(Lefteye));
                    AddShapeCommand lefteyecommand = new AddShapeCommand(emo, lefteye);
                    lefteyecommand.UnExecute();
                }
                else if (remove == 2)
                {
                    emo.RemoveShape(typeof(Righteye));
                    AddShapeCommand righteyecommand = new AddShapeCommand(emo, lefteye);
                    righteyecommand.UnExecute();
                }
                else if (remove == 3)
                {
                    emo.RemoveShape(typeof(Leftbrow));
                    AddShapeCommand leftbrowcommand = new AddShapeCommand(emo, lefteye);
                    leftbrowcommand.UnExecute();
                }
                else if (remove == 4)
                {
                    emo.RemoveShape(typeof(Rightbrow));
                    AddShapeCommand rightbrowcommand = new AddShapeCommand(emo, lefteye);
                    rightbrowcommand.UnExecute();
                }
                else if (remove == 5)
                {
                    emo.RemoveShape(typeof(Mouth));
                    AddShapeCommand mouthcommand = new AddShapeCommand(emo, lefteye);
                    mouthcommand.UnExecute();
                }
            }

            else if (choice == 3)
            {
                //move
                Console.WriteLine("Choose a feature to move below");
                Console.WriteLine("----------------------");
                Console.WriteLine("1): left-eye");
                Console.WriteLine("2): right-eye");
                Console.WriteLine("3): left-brow");
                Console.WriteLine("4): right-brow");
                Console.WriteLine("5): mouth");
                int move = Int16.Parse(Console.ReadLine());

                if (move == 1)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): up");
                    Console.WriteLine("2): down");
                    Console.WriteLine("3): left");
                    Console.WriteLine("4): right");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int value = Int16.Parse(Console.ReadLine());

                    emo.Move(lefteye, direction, value);
                }
                if (move == 2)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): up");
                    Console.WriteLine("2): down");
                    Console.WriteLine("3): left");
                    Console.WriteLine("4): right");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int value = Int16.Parse(Console.ReadLine());

                    emo.Move(righteye, direction, value);
                }
                if (move == 3)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): up");
                    Console.WriteLine("2): down");
                    Console.WriteLine("3): left");
                    Console.WriteLine("4): right");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int value = Int16.Parse(Console.ReadLine());

                    emo.Move(leftbrow, direction, value);
                }
                if (move == 4)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): up");
                    Console.WriteLine("2): down");
                    Console.WriteLine("3): left");
                    Console.WriteLine("4): right");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int value = Int16.Parse(Console.ReadLine());

                    emo.Move(rightbrow, direction, value);
                }
                if (move == 5)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): up");
                    Console.WriteLine("2): down");
                    Console.WriteLine("3): left");
                    Console.WriteLine("4): right");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int value = Int16.Parse(Console.ReadLine());

                    emo.Move(mouth, direction, value);
                }
            }

            else if (choice == 4)
            {
                //rotate
                Console.WriteLine("Choose a feature to rotate below");
                Console.WriteLine("----------------------");
                Console.WriteLine("1): left-eye");
                Console.WriteLine("2): right-eye");
                Console.WriteLine("3): left-brow");
                Console.WriteLine("4): right-brow");
                Console.WriteLine("5): mouth");
                int rotate = Int16.Parse(Console.ReadLine());

                if (rotate == 1)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): clockwise");
                    Console.WriteLine("2): anticlockwise");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int degrees = Int16.Parse(Console.ReadLine());

                    emo.Rotate(lefteye, direction, degrees);
                }
                if (rotate == 2)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): clockwise");
                    Console.WriteLine("2): anticlockwise");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int degrees = Int16.Parse(Console.ReadLine());

                    emo.Rotate(righteye, direction, degrees);
                }
                if (rotate == 3)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): clockwise");
                    Console.WriteLine("2): anticlockwise");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int degrees = Int16.Parse(Console.ReadLine());

                    emo.Rotate(leftbrow, direction, degrees);
                }
                if (rotate == 4)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): clockwise");
                    Console.WriteLine("2): anticlockwise");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int degrees = Int16.Parse(Console.ReadLine());

                    emo.Rotate(rightbrow, direction, degrees);
                }
                if (rotate == 5)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): clockwise");
                    Console.WriteLine("2): anticlockwise");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int degrees = Int16.Parse(Console.ReadLine());

                    emo.Rotate(mouth, direction, degrees);
                }
            }

            else if (choice == 5)
            {
                //style
                Console.WriteLine("Choose a feature to change style below");
                Console.WriteLine("----------------------");
                Console.WriteLine("1): left-eye");
                Console.WriteLine("2): right-eye");
                Console.WriteLine("3): left-brow");
                Console.WriteLine("4): right-brow");
                Console.WriteLine("5): mouth");
                int change = Int16.Parse(Console.ReadLine());

                if (change == 1)
                {
                    Console.WriteLine("Select style from below");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): A");
                    Console.WriteLine("2): B");
                    Console.WriteLine("3): C");
                    int style = Int16.Parse(Console.ReadLine());

                    if (style == 1)
                    {
                        lefteye = factory.CreateShape("Lefteye", "A") as Lefteye;
                    }
                    else if (style == 2)
                    {
                        lefteye = factory.CreateShape("Lefteye", "B") as Lefteye;
                    }
                    else if (style == 3)
                    {
                        lefteye = factory.CreateShape("Lefteye", "C") as Lefteye;
                    }
                }
                else if (change == 2)
                {
                    Console.WriteLine("Select style from below");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): A");
                    Console.WriteLine("2): B");
                    Console.WriteLine("3): C");
                    int style = Int16.Parse(Console.ReadLine());

                    if (style == 1)
                    {
                        righteye = factory.CreateShape("Righteye", "A") as Righteye;
                    }
                    else if (style == 2)
                    {
                        righteye = factory.CreateShape("Righteye", "B") as Righteye;
                    }
                    else if (style == 3)
                    {
                        righteye = factory.CreateShape("Righteye", "C") as Righteye;
                    }
                }
                else if (change == 3)
                {
                    Console.WriteLine("Select style from below");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): A");
                    Console.WriteLine("2): B");
                    Console.WriteLine("3): C");
                    int style = Int16.Parse(Console.ReadLine());

                    if (style == 1)
                    {
                        leftbrow = factory.CreateShape("Leftbrow", "A") as Leftbrow;
                    }
                    else if (style == 2)
                    {
                        leftbrow = factory.CreateShape("Leftbrow", "B") as Leftbrow;
                    }
                    else if (style == 3)
                    {
                        leftbrow = factory.CreateShape("Leftbrow", "C") as Leftbrow;
                    }
                }
                else if (change == 4)
                {
                    Console.WriteLine("Select style from below");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): A");
                    Console.WriteLine("2): B");
                    Console.WriteLine("3): C");
                    int style = Int16.Parse(Console.ReadLine());

                    if (style == 1)
                    {
                        rightbrow = factory.CreateShape("Rightbrow", "A") as Rightbrow;
                    }
                    else if (style == 2)
                    {
                        rightbrow = factory.CreateShape("Rightbrow", "B") as Rightbrow;
                    }
                    else if (style == 3)
                    {
                        rightbrow = factory.CreateShape("Rightbrow", "C") as Rightbrow;
                    }
                }
                else if (change == 5)
                {
                    Console.WriteLine("Select style from below");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): A");
                    Console.WriteLine("2): B");
                    Console.WriteLine("3): C");
                    int style = Int16.Parse(Console.ReadLine());

                    if (style == 1)
                    {
                        mouth = factory.CreateShape("Mouth", "A") as Mouth;
                    }
                    else if (style == 2)
                    {
                        mouth = factory.CreateShape("Mouth", "B") as Mouth;
                    }
                    else if (style == 3)
                    {
                        mouth = factory.CreateShape("Mouth", "C") as Mouth;
                    }
                }
            }
            else if (choice == 6)
            {
                //save
                emo.ToSVG();
            }
            else if (choice == 7)
            {
                //draw
                emo.drawSVG();
            }
            else if (choice == 8)
            {
                //Undo
                invoker.Undo();
            }
            else if (choice == 9)
            {
                //Redo
                invoker.Redo();
            }
            else if (choice == 10)
            {
                //help
                Console.WriteLine("-----------------------------------------------Command-List--------------------------------------------------");
                Console.WriteLine(" 1. add	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }");
                Console.WriteLine(" 2. remove   { left-eye | right-eye	| left-brow	| right-brow | mouth }");
                Console.WriteLine(" 3. move	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }	{ up | down	| left | right } value");
                Console.WriteLine(" 4. rotate	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }");
                Console.WriteLine(" 5. style	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }	{ A	| B	| C }");
                Console.WriteLine(" 6. save	 <file>");
                Console.WriteLine(" 7. draw");
                Console.WriteLine(" 8. undo");
                Console.WriteLine(" 9 redo");
                Console.WriteLine(" 10. help");
                Console.WriteLine(" 0. quit");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            // else if (choice == 21)
            // {
            //     emo.Display();
            // }
        }
    }

}