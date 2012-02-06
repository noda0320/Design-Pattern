using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DesignPatterns.Interpreter
{
	[TestFixture]
	class InterpreterTest
	{
		[Test]
		public void Test()
		{
			string str = "10 + 2 - 5 + 4 + 9";
			Context context = new Context(str);

			AbstractExpression expression = new NonterminalExpression();

			int result = expression.Interpret(context);
			Assert.AreEqual(30, result);
		}
	}
}
