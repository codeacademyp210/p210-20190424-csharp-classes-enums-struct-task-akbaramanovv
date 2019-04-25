using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Group
        {
            private string Name;

            public void setName( string ad)
            {
                Name = ad;
            }
            public string getGroupName()
            {
                return Name;
            }
        }
        class student
        {
            private string Sname;
            public void setStudentName(string sad)
            {
                Sname = sad;
            }
            private string Ssurname;
            public void setStudentSurname(string soyad)
            {
                Ssurname = soyad;
            }

             public string getSinfo()
            {
                return Sname + " " + Ssurname;
            }
        }
        static void Main(string[] args)
        {
            Group Sgroup = new Group();
            student Sinfo = new student();
            string StudentfullInfo , groupName;

            Console.WriteLine("Adinizi daxil edin: ");
            Sinfo.setStudentName(Console.ReadLine());

            Console.WriteLine("Soyadinizi daxil edin: ");
            Sinfo.setStudentSurname(Console.ReadLine());

            Console.WriteLine("Qrupunuzu daxil edin: ");
            Sgroup.setName(Console.ReadLine());

            StudentfullInfo = Sinfo.getSinfo();
            groupName = Sgroup.getGroupName();

            Console.WriteLine("salam " + StudentfullInfo + ".Sizin qrupunuz: " + groupName);


            Console.ReadKey();

        }
}
}
