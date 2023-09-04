using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._fs_._TEST_.folder.be_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var f = @"E:\170203\data(readonly\_wangYouzhi_\贵州\";

			var t=
			nilnul.fs.folder._DocsX.Docs_ofAddress(f).Any(doc => new nilnul.fs._address.doc.be_.Ext1("sln").be(doc));
		}
	}
}
