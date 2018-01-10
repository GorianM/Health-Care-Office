using ModelProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsProject
{
	public class ExpandableProdact
	{
		public int ID { get; set; }
		public string Description { get; set; }
		public int Quantity { get; set; }
		public int MinimumThreshold { get; set; }
		public Staff staff { get; set; }

		public override string ToString()
		{
			return "Description: " + Description + "Quantity: " + Quantity + " Minimum Threshold: " + MinimumThreshold; 
		}
	}
}
