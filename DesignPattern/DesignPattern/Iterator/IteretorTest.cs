using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DesignPatterns.Iterator
{
	[TestFixture]
	class IteretorTest
	{
		private int[] data;

		[SetUp]
		public void SetUp()
		{
			// イテレータ用のデータ
			data = new int[10];
			for (int i = 0; i < data.Length; i++) {
				data[i] = i;
			}
		}

		[Test]
		public void PreorderTest()
		{
			// 先頭から取得していくタイプ
			var iterator = new PreIterator<int>(data);

			for (int i = 0; iterator.IsDone(); i++, iterator.Next()) {
				Assert.AreEqual(i, iterator.Current());
			}
		}
		
		[Test]
		public void PostorderTest()
		{
			// 最後から取得していくタイプ
			var iterator = new PostIterator<int>(data);

			for (int i = data.Length - 1; iterator.IsDone(); i--, iterator.Next()) {
				Assert.AreEqual(i, iterator.Current());
			}		
		}
	}
}
