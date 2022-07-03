namespace Shapes
{
    internal abstract class Shape
    {
        public Shape(string name = "NoName")
        {
            PetName = name;
        }
        public string PetName { get; set; }

        public abstract void Draw();





    }
}
