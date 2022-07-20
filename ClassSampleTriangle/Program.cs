using InputUtilitys;
namespace ClassSampleTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RightAngledTriangle raTriangle 
                = new RightAngledTriangle(
                    InputUtility.InputFloat("底辺の長さ：",0,100),
                    InputUtility.InputFloat("高さ：", 0, 100));
            Console.WriteLine($"面積は{raTriangle.GetArea()}");
        }
    }

    
    class RightAngledTriangle
    {
        private float bottom; //底辺
        private float height;   //高さ
        public RightAngledTriangle(float bottom, float height)
        {
            this.bottom = bottom;
            this.height = height;
        }
        public float GetArea()
        {
            return bottom * height / 2;
        }
    }
}