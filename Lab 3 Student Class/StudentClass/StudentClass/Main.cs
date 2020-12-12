namespace StudentClass
{

    public class StudentClass
    {
      
       static void Main(string[] args)
        {
            
            
            //Student 1
            Student Stud1 = new Student(123352989, "Bergen Marshall", "Cyber Operations", "bergen.marshall@trojans.dsu.edu", "USA", "SD", "Fall 2020", "Spring 2021", "555-555-555", "Street Address", true);
            Stud1.printStudentInfo();

            //Student 2
            Student Stud2 = new Student("Miles", 253989);
            Stud2.EmailAddress = "Miles.Livermont@trojans.dsu.edu";
            Stud2.Major = "Computer Science";
            Stud2.Country = "USA";
            Stud2.GradDate = "2021";
            Stud2.StartDate = "2019";
            Stud2.PhoneNumber = "205-555-5555";
            Stud2.MailingAddress = "820 N Washington Ave, Madison, SD, 59032";
            Stud2.printStudentInfo();

            //Student 3
            Student Stud3 = new Student("Mark", 989352321);
            Stud3.EmailAddress = "Mark.Hamill@trojans.dsu.edu";
            Stud3.Major = "Computer Science";
            Stud3.Country = "USA";
            Stud3.GradDate = "2021";
            Stud3.StartDate = "2019";
            Stud3.PhoneNumber = "205-555-5555";
            Stud3.MailingAddress = "820 N Washington Ave, Madison, SD, 59032";
            Stud3.printStudentInfo();
            //Student 4
            Student Stud4 = new Student("Leto", 253989);
            Stud3.EmailAddress = "Leto.Jared@trojans.dsu.edu";
            Stud3.Major = "Computer Science";
            Stud3.Country = "USA";
            Stud3.GradDate = "2021";
            Stud3.StartDate = "2019";
            Stud3.PhoneNumber = "205-555-5555";
            Stud3.MailingAddress = "820 N Washington Ave, Madison, SD, 59032";
            Stud3.printStudentInfo();
            //Student 5
            Student Stud5 = new Student("Heath", 123298539);
            Stud5.EmailAddress = "Heath.Ledger@trojans.dsu.edu";
            Stud5.Major = "Computer Science";
            Stud5.Country = "USA";
            Stud5.GradDate = "2021";
            Stud5.StartDate = "2019";
            Stud5.PhoneNumber = "205-555-5555";
            Stud5.MailingAddress = "820 N Washington Ave, Madison, SD, 59032";
            Stud5.printStudentInfo();
            //Student 6
            Student Stud6 = new Student("Sam", 352321989);
            Stud2.EmailAddress = "Sam.Smith@trojans.dsu.edu";
            Stud2.Major = "Computer Science";
            Stud2.Country = "USA";
            Stud2.GradDate = "2021";
            Stud2.StartDate = "2019";
            Stud2.PhoneNumber = "205-555-5555";
            Stud2.MailingAddress = "820 N Washington Ave, Madison, SD, 59032";
            Stud2.printStudentInfo();
            //Student 7
            Student Stud7 = new Student("Carl", 11);
            Stud7.EmailAddress = "Carl.Petersen@trojans.dsu.edu";
            Stud7.Major = "Computer Science";
            Stud7.Country = "USA";
            Stud7.GradDate = "2021";
            Stud7.StartDate = "2019";
            Stud7.PhoneNumber = "205-555-5555";
            Stud7.MailingAddress = "820 N Washington Ave, Madison, SD, 59032";
            Stud7.printStudentInfo();
            //Student 8
            Student Stud8 = new Student("Gavin", 888988);
            Stud8.EmailAddress = "Gavin.DuBray@trojans.dsu.edu";
            Stud8.Major = "Computer Science";
            Stud8.Country = "USA";
            Stud8.GradDate = "2021";
            Stud8.StartDate = "2019";
            Stud8.PhoneNumber = "205-555-5555";
            Stud8.MailingAddress = "820 N Washington Ave, Madison, SD, 59032";
            Stud8.printStudentInfo();
            //Student 9
            Student Stud9 = new Student("Cook", 999999);
            Stud9.EmailAddress = "Cook.Livermont@trojans.dsu.edu";
            Stud9.Major = "Computer Science";
            Stud9.Country = "USA";
            Stud9.GradDate = "2021";
            Stud9.StartDate = "2019";
            Stud9.PhoneNumber = "205-555-5555";
            Stud9.MailingAddress = "820 N Washington Ave, Madison, SD, 59032";
            Stud9.printStudentInfo();
            //Student 10
            Student Stud10 = new Student("Tom", 101010101010);
            Stud10.EmailAddress = "Tom.Brady@trojans.dsu.edu";
            Stud10.Major = "Computer Science";
            Stud10.Country = "USA";
            Stud10.GradDate = "2021";
            Stud10.StartDate = "2019";
            Stud10.PhoneNumber = "101010-101010-10101010";
            Stud10.MailingAddress = "820 N Washington Ave, Madison, SD, 59032";
            Stud10.printStudentInfo();
            //Output change logs for all students
            Stud1.printLog();
            Stud2.printLog();
            Stud3.printLog();
            Stud3.printLog();
            Stud5.printLog();
            Stud2.printLog();
            Stud9.printLog();
            Stud8.printLog();
            Stud9.printLog();
            Stud10.printLog();

        }
    }
}
