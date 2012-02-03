using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.HainOfResponsibility
{
	class Dialog : Handler
	{
		public Dialog(Handler successor, int request)
			: base(successor, request)
		{ 	}

		public override string HandleRequest(int request)
		{
			string message = "";

			if (hasHandler(request)) {
				message = "Dialog で処理されました";
			} else {
				message = base.HandleRequest(request);
			}

			return message;
		}
	}
}
