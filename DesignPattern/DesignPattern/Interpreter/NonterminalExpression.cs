using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Interpreter
{
	class NonterminalExpression : AbstractExpression
	{
		public override int Interpret(Context context)
		{
			int result = 0;
			string token;

			while ((token = context.GetToken()) != null) {
				int val;
				if (int.TryParse(token, out val)) {
					// 数字
					result += val;
				} else { 
					// その他
				}
			}

			return result;
		}
	}
}
