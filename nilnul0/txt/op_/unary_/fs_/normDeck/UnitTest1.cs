using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj;
using System;

namespace nilnul._fs_._TEST_.nilnul0.txt.op_.unary_.fs_.normDeck
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var t=new[]{
				(
					@"c:\asb\asfas" , @"c:\asb\asfas"
				)
				,
				(
					@"c:/asb\asfas" , @"c:\asb\asfas"
				)
				,
				(
					@"\asb\asfas" , @"\asb\asfas"
				)
				,
				(
					@"/asb\asfas" , @"\asb\asfas"
				)
				,
				(
					@"/asb/asfas" , @"\asb\asfas"
				)
				,
				(
					@"asb/asfas" , @"asb\asfas"
				)
			};

			t.Each(
				a=>Vs(a)
			);


		}


		static void Vs((string,string) input) {
			Vs(input.Item1, input.Item2);
		}

		static void Vs(string input, string output) {


			Assert.IsTrue(
				nilnul.txt.op_.unary_.fs_.NormalizeDeck.Singleton.op(
					input
				)
				== output
			);
		}


	}
}
