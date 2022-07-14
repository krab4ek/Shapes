namespace Shapes
{
    internal class Circle : Shape, IDraw3D
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

        public void Draw3D()
        {
            Console.WriteLine("Drawing Circle in 3D!");
        }
    }
}
