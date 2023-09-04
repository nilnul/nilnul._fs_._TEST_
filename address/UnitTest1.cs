using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.fs;

namespace nilnul._fs_._TEST_.address
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
	//	[ExpectedException(typeof(nilnul.obj.vow_._none.UnacceptableException),
	//": is not allowed")]
		[ExpectedException(typeof(nilnul.obj_.xpn_.parse_.scan_.CharException),
	": is not allowed")]


		public void TestMethod1()
		{
			//var address = nilnul.fs.AddressIX.Parse(@"c:\a\b\\");

			AddressI address;
			address= nilnul.fs.AddressA.Parse(@"c:\a\b\:");
			// address = nilnul.fs.AddressIX.Parse(@"c:\a\b\:\");

		}
	}
}
