using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command
{
	abstract class Command
	{
		protected Receiver receiver;
		protected string message;

		public Command(Receiver receiver, string message)
		{
			this.receiver = receiver;
			this.message = message;
		}

		abstract public void Execute();
	}
}
