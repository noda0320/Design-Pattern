using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command
{
	class Receiver
	{
		private string message;

		public Receiver()
		{
			message = "";
		}

		public string Message {
			set { message = value; }
			get { return message; }
		}
	}
}
