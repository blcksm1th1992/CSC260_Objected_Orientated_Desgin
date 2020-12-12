using System;
using System.Collections.Generic;
using System.Text;

namespace BannerDiagram.Banner
{
	public class Faculty : DSU_Person
	{
		private int facultyid { get; set; }
		const string role = "Faculty";

	public Faculty()
		{

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
		~Faculty()
		{

		}

		public void ViewSchedule()
		{
			throw new NotImplementedException();
		}

		public void BrowseAvailableCourses()
		{
			throw new NotImplementedException();
		}

		private void GradeCourse(string course, int grade, int student)
		{
			throw new NotImplementedException();
		}

		private void viewWaitlist(string course)
		{
			throw new NotImplementedException();
		}

		private void OverridePrereq(string course, int student_id)
		{
			throw new NotImplementedException();
		}
	}
}
