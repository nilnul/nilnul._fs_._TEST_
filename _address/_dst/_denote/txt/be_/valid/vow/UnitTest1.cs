using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._fs_._TEST_._address._dst._denote.txt.be_.valid.vow
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
#pragma warning disable CS0219 // The variable 'x' is assigned but its value is never used
			var x= @"æ¯ä¸è®ºææå
³èµæï¼å¼ éªå¦ï¼";
#pragma warning restore CS0219 // The variable 'x' is assigned but its value is never used
			nilnul.fs._address._dst._denote.txt.be_.valid.Vow.Singleton.vow(
				"æ¯\u0095ä¸\u009aè®ºæ\u0096\u0087æ\u009c\u0089å\u0085³èµ\u0084æ\u0096\u0099ï¼\u0088å¼ é\u009bªå¦\u008dï¼\u0089"
			);
		}
	}
}
