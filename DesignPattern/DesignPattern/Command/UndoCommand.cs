using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command
{
	abstract class UndoCommand : Command
	{
		public UndoCommand(Receiver receiver, string message)
			: base(receiver, message)
		{ }

		abstract public void Undo();
	}
}
