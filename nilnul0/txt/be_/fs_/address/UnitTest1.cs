using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.txt.be_.fs_.address
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			//Debug.WriteLine(

			//	nilnul.txt.be_.fs_.Address.Singleton.be_ifArgTrimmed(null)
			//);

			

			Debug.WriteLine(
				nilnul.txt.be_.fs_.Address.Singleton.be_ifArgTrimmed(null ?? "")
			);


			Debug.WriteLine(
						nilnul.txt.be_.fs_.Address.Singleton.be_ifArgTrimmed("c:")
					);

			Debug.WriteLine(
						nilnul.txt.be_.fs_.Address.Singleton.be_ifArgTrimmed(@"c:\")
					);

		}

	}
}
