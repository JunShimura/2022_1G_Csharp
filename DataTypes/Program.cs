namespace DataTypes
{
    internal class Program
    {
        enum Weapon { knife=0, handGun=1, rifle=2 };
        static void Main(string[] args)
        {
            int[] intsDim = { 1, 2, 3 };
            List<int> ints = new List<int>(intsDim);
            ints.Add(4);    //最後にデータを付けられる
            //intsDim[4] = 4; //例外で終わる
            intsDim = new int[4] { 1, 2, 3, 4 }; //作り直すなら同じインスタンスの名前で作れる
            TestFunc(intsDim);  //値渡し
            TestFunc(ints); //参照渡し

            //Dictionaryのサンプル
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("araki", 1);
            dic.Add("ito", 2);
            dic.Add("ogata", 3);
            dic.Add("sasaki", 4);
            dic.Remove("araki");
            dic.Add("araki", 0);
            Dictionary<Weapon,Action>attackTable= new Dictionary<Weapon,Action>();
            attackTable.Add(Weapon.knife, KnifeAttack);

            Weapon weapon = new Weapon();
            weapon = Weapon.knife;
            attackTable[weapon]();
        }

        static void KnifeAttack()
        {
            Console.WriteLine("ナイフを一振り");
        }

        static void TestFunc(int[] ints)
        {
            ints[0] = 5;
            return;
        }
        static void TestFunc(IReadOnlyList<int> ints)   //受け取ったListの中身を変更不可
        {
            //ints[0] = 5;    //　中身の書き換え不可
            return;
        }
        static void TestFunc(in List<int> ints) //受け取ったインスタンスの指す先を変更不可
        {
            ints[0] = 5;    //中身は書き換え可能
                            //ints = new List<int>( 5);   //初期化して別の配列にはできない
            return;
        }
    }



