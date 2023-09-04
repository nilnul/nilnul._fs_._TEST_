using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs._test.folder_.tmp.explore
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void test()
		{
			nilnul.fs.folder._ExploreX.Explore(
				nilnul.fs.folder_._TmpX.Get()
			);

		}
	}
}
