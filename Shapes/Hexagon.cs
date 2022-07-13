namespace Shapes
{
    internal class Hexagon : Shape, IPointy
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



    }
}
