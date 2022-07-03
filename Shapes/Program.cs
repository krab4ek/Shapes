﻿using Shapes;

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

Console.ReadLine();