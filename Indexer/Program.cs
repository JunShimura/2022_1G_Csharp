namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle= new Triangle(3,5,7);
            Triangle[] triangles = {new Triangle(1,3,4),new Triangle(4,5,2) };
            float x = triangles[0][0];  //x=1になる
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i}番目={triangle[i]}");
            }
            //Console.WriteLine($"一番長い辺は{triangle.Max()}"); //エラーになる
            Console.WriteLine($"一番長い辺は{triangle.lengths.Max()}"); 
            int[] table = { 1,2,3};
            Console.WriteLine($"tableの最大値は{table.Max()}");
        }
    }
}