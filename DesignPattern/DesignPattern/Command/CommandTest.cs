using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DesignPatterns.Command
{
	[TestFixture]
	class CommandTest
	{
		[Test]
		public void Test()
		{
			var receiver = new Receiver();
			var commandManager = new CommandManager();

			// コマンドを順番に実行
			Command commandAAA = new ConcreateCommand(receiver, "aaa");
			commandManager.Execute(commandAAA);
			Command commandBBB = new ConcreateCommand(receiver, "bbb");
			commandManager.Execute(commandBBB);
			Command commandCCC = new ConcreateCommand(receiver, "ccc");
			commandManager.Execute(commandCCC);
			Command commandDDD = new ConcreateCommand(receiver, "ddd");
			commandManager.Execute(commandDDD);

			string result = receiver.Message;
			Assert.AreEqual("aaabbbcccddd", result);

			// コマンドを2回分戻す
			commandManager.Undo();
			commandManager.Undo();

			result = receiver.Message;
			Assert.AreEqual("aaabbb", result);
		}
	}
}
