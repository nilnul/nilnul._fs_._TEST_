using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul._fs_._TEST_.folder.dst_.cfg_.nn_.extsed
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var folder = @"D:\170203\data\wangyouwei.house_._cPark_";

			var t = nilnul.fs.folder.dst_.cfg_.nn_._ExtedsX._Active0default_addressAssumeFolder(folder);

			Debug.WriteLine(t);

		}
	}
}
