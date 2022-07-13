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

#endregion




Console.ReadLine();