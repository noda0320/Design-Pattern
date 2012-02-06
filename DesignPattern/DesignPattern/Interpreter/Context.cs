using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Interpreter
{
	class Context
	{
		private int index;
		private string[] token;

		public Context(string str)
		{ 
			token = str.Split(' ');
			index = 0;
		}

		public string GetToken()
		{
			return index < token.Length ? token[index++] : null;
		}
	}
}
