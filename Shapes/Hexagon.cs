namespace Shapes
{
    internal class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }

        public Hexagon(string name) : base(name) { }

        public byte Points
        {
            get { return 6; }
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Hexagon");

        }

        public void Draw3D()
        {
            Console.WriteLine($"Drawing Hexagon in 3D!");
        }
    }
}
