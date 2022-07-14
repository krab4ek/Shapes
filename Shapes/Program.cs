using Shapes;
#region First lesson
Console.WriteLine("*******Fun with polymorhism*******\n");

Hexagon hex = new Hexagon("Beth");
hex.Draw();

Circle circle = new Circle("Cindy");
circle.Draw();

Console.WriteLine();

Shape[] myShapes = { new Hexagon(), new Circle(),
    new Hexagon("Lily"),new Circle("Alla"), new Hexagon("Tratra") };
foreach (Shape myShape in myShapes)
{
    myShape.Draw();
}

Console.WriteLine();

ThreeDCircle trid = new ThreeDCircle();
trid.Draw();
((Circle)trid).Draw();
#endregion


#region Second lesson: Interface
Console.WriteLine("\n****** Fun with Interface *****\n");

var hexagon = new Hexagon();
Console.WriteLine($"Points: {hexagon.Points}.");

Circle circle1 = new Circle("Lisa");
IPointy? ipoint = null;

try
{
    ipoint = (IPointy)circle1;
    Console.WriteLine($"Points: {ipoint.Points}");
}
catch (InvalidCastException e)
{
    Console.WriteLine(e.Message);
}

Hexagon hexagon2 = new Hexagon("Peter");
IPointy ipointy2 = hexagon2 as IPointy;

if (ipointy2 != null)
    Console.WriteLine($"Points: {ipointy2.Points}");
else
    Console.WriteLine("OOPs... Not pointy!");

Shape[] myShapes2 = { new Hexagon(),new Circle(),
    new Triangle("Joe"),new Circle("JoJo")};
for (int i = 0; i < myShapes2.Length; i++)
{
    myShapes2[i].Draw();

    if (myShapes2[i] is IPointy ip)
        Console.WriteLine($"-> Points: {ip.Points}");
    else
        Console.WriteLine($"{myShapes2[i].PetName}, is not pointy!");
    if (myShapes2[i] is IDraw3D)
        DrawIn3D((IDraw3D)myShapes2[i]);
    Console.WriteLine();
}


Shape[] myShapes3 = {new Hexagon(), new Circle("Krug"),
    new Triangle("Treug"),new Circle(),new Hexagon("Kvadrat")};

IPointy? firstPointyItem = FindFirstPointyShape(myShapes3);

Console.WriteLine($"The item has {firstPointyItem.Points} points.");


static void DrawIn3D(IDraw3D draw3d)
{
    Console.WriteLine("-> Drawing Idraw3D compatible type");
    draw3d.Draw3D();
}

static IPointy? FindFirstPointyShape(Shape[] shapes)
{
    foreach (Shape s in shapes)
    {
        if (s is IPointy ipointy)
            return ipointy;
    }
    return null;
}

#endregion




Console.ReadLine();