using System;

namespace Ex32
{
    class Circle : Surface
    {
        readonly public float radius;
        public Circle(float radius = 0)
        {
            this.radius = radius;
        }
        public override float GetSurface()
        {
            return (float)(radius * radius * Math.PI);//longで計算してからfloatに変換、桁落ちしにくい
        }
        public override float GetCircumference()
        {
            //return radius * 2 * Math.PI;              //Error
            return (float)(radius * 2 * Math.PI); //①longで計算してからfloatに変換、桁落ちしにくい
            //return radius * 2 * (float)Math.PI;   //② 円周率をfloatに変換して計算、①より演算精度は少し下がる
            //return radius * 2 * MathF.PI;           //③ floatで用意された円周率で計算、ほぼ②と同じ
            //return radius * 2 * Mathf.PI;           //Mathfは存在しない(UnityEngine内にある)のでエラー
        }
        public override void GetBounds(out float width, out float height)
        {
            width = this.radius*2;
            height = this.radius*2;
        }
    }
}
