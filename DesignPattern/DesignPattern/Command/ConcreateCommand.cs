using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command
{
	class ConcreateCommand : UndoCommand
	{
		private string previosMessage;

		public ConcreateCommand(Receiver receiver, string message)
			:base(receiver, message)
		{
			previosMessage = receiver.Message;
		}

		public override void Execute()
		{
			// 追加前のメッセージを記憶
			previosMessage = receiver.Message;

			// 自分のメッセージを追加
			receiver.Message += message;
		}

		public override void Undo() 
		{ 
			// 前回のメッセージに戻す
			receiver.Message = previosMessage;
		}
	}
}
