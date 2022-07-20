using InputUtilitys;
namespace Ex26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var width = InputUtility.InputFloat("幅");
            var height = InputUtility.InputFloat("高さ");
            var depth = InputUtility.InputFloat("奥行");
            Box box = new Box(width, height, depth);
            Console.WriteLine($"boxの表面積{box.GetSurface()}boxの体積={box.GetVolume()}");
        }
    }
    class Box
    {
        private float width;
        private float height;
        private float depth;
        public Box(float width, float height, float depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
        public float GetSurface()
        {
            return (width * height + depth * height + width * depth) * 2;
        }
        public float GetVolume()
        {
            return width * height * depth;
        }
    }
}