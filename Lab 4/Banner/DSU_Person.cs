using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Xml.Serialization;

namespace BannerDiagram.Banner
{
	public abstract class DSU_Person
	{
		public string DSU_Email { get; set; }
		public string Name { get; set; }
		public string Role { get; set; }
		public string ID { get; set; }
		public DSU_Person()
		{

		}
		~DSU_Person()
		{

		}
		abstract public void changeEmail();
		abstract public void viewSchedule();
		abstract public void changeAddress();
	}
}
