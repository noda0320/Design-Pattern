﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Interpreter
{
	abstract class AbstractExpression
	{
		abstract public int Interpret(Context context);
	}
}
