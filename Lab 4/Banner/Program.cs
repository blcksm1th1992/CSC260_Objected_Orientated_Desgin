using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BannerDiagram.Banner
{
    class Program
    {

        static void Main(string[] args)
        {
            Advisor advisor = new Advisor();
            StudentProfile.Student student = new StudentProfile.Student("Gavin DuBray", "gavin.dubray@trojans.dsu.edu", "A123456789");
            Console.WriteLine(student.Name);
            Console.WriteLine(student.DSU_Email);
            student.changeEmail();
            Console.WriteLine(student.DSU_Email);
            student.changeEmail("Caedmon.Dubray@trojans.dsu.edu");
            Console.WriteLine(student.DSU_Email);
            Console.ReadLine();
        }
    }
}
