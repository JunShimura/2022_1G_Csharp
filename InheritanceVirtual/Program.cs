using System;
using System.Linq;

namespace InheritanceVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("しむら", 25);
            Student[] student1 = {
                new Student("anbo", 18, "デジタルアーツ仙台",10000),
                new Student("iizawa", 19, "デジタルアーツ仙台", 10001)
            };
            Worker worker1 = new Worker("seki", 22,"関らーめん");
            ElementarySchoolStudent iwamatsu
                = new ElementarySchoolStudent("いわまつ",8, "デジタルアーツ仙台",4,2);

            Member tempMemer = iwamatsu;
            Person[] persons = new Person[] { person1, student1[0], student1[1], worker1, iwamatsu };
            Console.WriteLine("全員をPersonで出す");
             foreach ( Person person in persons)
            {
                person.SelfIntroduction();
            }
        }
    }
}
