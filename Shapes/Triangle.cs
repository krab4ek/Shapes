using Shapes;

internal class Triangle : Shape, IPointy
{
    public Triangle(string name = "NoName") : base(name)
    {
    }

    public byte Points
    {
        get { return 3; }
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing {PetName} the Triangle");
    }
}