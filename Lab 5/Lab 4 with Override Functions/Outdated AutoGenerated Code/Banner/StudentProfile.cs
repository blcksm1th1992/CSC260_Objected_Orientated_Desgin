using System;
using System.Collections.Generic;
using System.Text;

namespace BannerDiagram.Banner
{
	public class StudentProfile
	{
		public class Student : DSU_Person
		{
			private static int student_id;
			private int student_year;
			const string role = Student;

			public Student(int student_id, string name)
			{
				throw new NotImplementedException();
			}

			~Student()
			{
				throw new NotImplementedException();
			}

			public Student()
			{
				throw new NotImplementedException();
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
			throw new NotImplementedException();
		}

		~StudentProfile()
		{
			throw new NotImplementedException();
		}

		private void DegreeWorks()
		{
			throw new NotImplementedException();
		}
	}
}
