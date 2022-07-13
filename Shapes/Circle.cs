namespace Shapes
{
    internal class Circle : Shape, IPointy
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        public byte Points
        {
            get { return 3; }
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Circle");
        }


    }
}
