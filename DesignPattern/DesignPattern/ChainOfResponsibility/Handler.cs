using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.HainOfResponsibility
{
	abstract class Handler
	{
		protected Handler successor;
		private int requests;

		public Handler(Handler successor, int requests)
		{
			this.successor = successor;
			this.requests = requests;
		}

		protected virtual bool hasHandler(int request)
		{
			return request == requests;
		}

		public virtual string HandleRequest(int request)
		{
			string message = "";

			if (successor != null) {
				message = successor.HandleRequest(request);
			} else {
				message = "処理がみつかりませんでした。";
			}

			return message;
		}
	}

	class RequestNumber {
		public const int APP = 1;
		public const int DIALOG = 2;
		public const int BUTTON = 3;
	}

}
