using System;
using System.Collections.Generic;
using System.Text;

namespace BannerDiagram.Banner
{
	public class StudentProfile
	{
		public class Student : DSU_Person
		{
			private static int student_id { get; set; }
			private int student_year { get; set; }

			const string role = "Student";

			public Student(string name, string email, string id)
			{
				DSU_Email = email;
				Name = name;
				ID = id;
			}
			public override void changeEmail()
			{
				Console.WriteLine("Please enter your desired email address");
				string new_email = Console.ReadLine();
				DSU_Email = new_email;
			}
			public void changeEmail(string new_email)
			{
				DSU_Email = new_email;
			}
			public override void changeAddress()
			{
				throw new NotImplementedException();
			}
			public override void viewSchedule()
			{
				throw new NotImplementedException();
			}
			~Student()
			{

			}

			public Student()
			{

			}

			public void ViewSchedule()
			{
				throw new NotImplementedException();
			}

			public void RegisterClass()
			{
				throw new NotImplementedException();
			}

			public void ViewAvailableClasses()
			{
				throw new NotImplementedException();
			}

			public string DropCource()
			{
				throw new NotImplementedException();
			}

			public void WaitlistCourse()
			{
				throw new NotImplementedException();
			}

			public void CreateSemesterPlan()
			{
				throw new NotImplementedException();
			}
		}

		private string StudentMajor;
		private int creditsEarned;

		public StudentProfile()
		{

		}

		~StudentProfile()
		{

		}

		private void DegreeWorks()
		{
			throw new NotImplementedException();
		}
	}
}
