using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul._fs_._TEST_._address._route.division_._div._dir.dnt_._exted.ext.set
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			//var t = T.Singleton;
			////var s1 = new Set();
			var s = Set.Singleton;


		}
	}

	public class T
	{

		static public T Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<T>.Instance;
			}
		}


	}
	public class Set : nilnul.fs._address.doc_._exted.ext.Set
	{
		public Set() : base(".com", "exe", "bat")
		{

		}


		static public Set Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Set>.Instance;
			}
		}

	}
}
