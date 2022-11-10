using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30
{
    /// <summary>
    /// 生き物
    /// </summary>
    class Life:Thing
    {
        // 平均寿命
        readonly public DateTime lifeSpan = new DateTime();
        // 誕生日
        readonly private DateTime _birthDay = new DateTime();
        public DateTime birthday
        {
            get { return _birthDay; }
        }
        public Life(DateTime lifeSpan, DateTime bd ,string n, float  w = 0, float h = 0, float d = 0, float weight = 0) : base(n, w, h, d, weight)
        {
            this.lifeSpan = lifeSpan;
            this._birthDay = bd;
        }
        public int GetAge()
        {
            var today = DateTime.Now;
            // 年の差を求める
            int age = today.Year - _birthDay.Year;

            // 誕生日より前の月日だったら年齢から1を引く
            // ここでは「age年を減算した日付を調べて、それが誕生日より前だったら
            // 年齢から1を引く」という処理をしている
            if (_birthDay > today.AddYears(-age))
                age--;
            return age;
        }
        public bool isBirthDay()
        {
            var now = DateTime.Now;
            return now.Month == _birthDay.Month && now.Day == _birthDay.Day;
        }
    }
}
