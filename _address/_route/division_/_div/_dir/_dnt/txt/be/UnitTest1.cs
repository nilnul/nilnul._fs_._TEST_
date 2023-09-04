using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul._fs_._TEST_._address._route.division_._div._dir._dnt.txt.be
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var txt = "滩涂🐟";
			var valid=nilnul.fs._address._route.division_._div._dir._dnt.txt.be_.Valid.Singleton.be(txt);

			var txt1 = "滩涂";
			var valid1=nilnul.fs._address._route.division_._div._dir._dnt.txt.be_.Valid.Singleton.be(txt1);

			var txt11 = "🐟";
			var valid11=nilnul.fs._address._route.division_._div._dir._dnt.txt.be_.Valid.Singleton.be(txt11);

		}
	}
}
