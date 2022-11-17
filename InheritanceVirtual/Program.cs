using System;
using System.Linq;

namespace InheritanceVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("しむら", 25);
            Member member1 = new Member("イーロン.マスク", 51, "Twitter");

            Student[] student1 = {
                            new Student("aota", 18, "デジタルアーツ仙台",10000),
                            new Student("iida", 19, "デジタルアーツ仙台", 10001)
                        };
            Worker worker1 = new Worker("seki", 22, "関らーめん");
            ElementarySchoolStudent iwamatsu
                = new ElementarySchoolStudent("いわまつ", 8, "デジタルアーツ仙台", 4, 2);
            Member tempMemer = iwamatsu;
            
            Console.WriteLine("全員をそれぞれで出す");
            person1.SelfIntroduction();
            member1.SelfIntroduction();
            Person[] persons = new Person[] { person1, member1,student1[0], student1[1], worker1, iwamatsu };
            Console.WriteLine("全員をPersonで出す");
            foreach (Person person in persons)
            {
                person.SelfIntroduction();
            }
        }
    }
}
