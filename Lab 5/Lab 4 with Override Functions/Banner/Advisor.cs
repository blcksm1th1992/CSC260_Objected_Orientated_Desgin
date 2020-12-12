using System;
using System.Collections.Generic;
using System.Text;

namespace BannerDiagram.Banner
{
	public class Advisor : DSU_Person
	{
		private int AdvisorID { get; set; }
		const string role = "Advisor";

		private void listAdvisees()
		{
			throw new NotImplementedException();
		}
		public override void changeEmail()
		{
			Console.WriteLine("Enter Your New Address:");
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
		private void removeHold(string studentID, string holdID)
		{
			throw new NotImplementedException();
		}

		private void viewStudentProfile(string studentID)
		{
			throw new NotImplementedException();
		}

		private void DegreeProgress(string studentID)
		{
			throw new NotImplementedException();
		}

		private void viewRegistration(string studentID)
		{
			throw new NotImplementedException();
		}

		public Advisor()
		{

		}

		~Advisor()
		{

		}
	}
}
