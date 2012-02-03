using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DesignPatterns.HainOfResponsibility
{
	[TestFixture]
	class ChainOfResponsibility
	{
		[Test]
		public void FullTest()
		{
			// ChainOfResponsibilityの作成
			var button = new Button(null, RequestNumber.BUTTON);
			var dialog = new Dialog(button, RequestNumber.DIALOG);
			var app = new App(dialog, RequestNumber.APP);
			Handler handler = app;

			string result = "";

			// ボタン処理
			result = handler.HandleRequest(RequestNumber.BUTTON);
			Assert.AreEqual("Button で処理されました", result);

			// ダイアログ処理
			result = handler.HandleRequest(RequestNumber.DIALOG);
			Assert.AreEqual("Dialog で処理されました", result);

			// アプリ処理
			result = handler.HandleRequest(RequestNumber.APP);
			Assert.AreEqual("App で処理されました", result);

			// 何も処理がない
			result = handler.HandleRequest(-1);
			Assert.AreEqual("処理がみつかりませんでした。", result);
		}

		[Test]
		public void NotOne()
		{
			// ChainOfResponsibilityの作成
			var button = new Button(null, RequestNumber.BUTTON);
			var dialog = new Dialog(button, RequestNumber.DIALOG);
			Handler handler = dialog;

			string result = "";

			// ボタン処理
			result = handler.HandleRequest(RequestNumber.BUTTON);
			Assert.AreEqual("Button で処理されました", result);

			// ダイアログ処理
			result = handler.HandleRequest(RequestNumber.DIALOG);
			Assert.AreEqual("Dialog で処理されました", result);

			// アプリ処理
			result = handler.HandleRequest(RequestNumber.APP);
			Assert.AreEqual("処理がみつかりませんでした。", result);

			// 何も処理がない
			result = handler.HandleRequest(-1);
			Assert.AreEqual("処理がみつかりませんでした。", result);
		}

		[Test]
		public void NotTwo()
		{
			// ChainOfResponsibilityの作成
			var dialog = new Dialog(null, RequestNumber.DIALOG);
			Handler handler = dialog;

			string result = "";

			// ボタン処理
			result = handler.HandleRequest(RequestNumber.BUTTON);
			Assert.AreEqual("処理がみつかりませんでした。", result);

			// ダイアログ処理
			result = handler.HandleRequest(RequestNumber.DIALOG);
			Assert.AreEqual("Dialog で処理されました", result);

			// アプリ処理
			result = handler.HandleRequest(RequestNumber.APP);
			Assert.AreEqual("処理がみつかりませんでした。", result);

			// 何も処理がない
			result = handler.HandleRequest(-1);
			Assert.AreEqual("処理がみつかりませんでした。", result);
		}
	}
}
