using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj;
using System;

namespace nilnul._fs_._TEST_.nilnul0.txt.op_.unary_.fs_.normDeck.linux
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var t=new[]{
				(
					@"c:\asb\asfas" , @"c:/asb/asfas"
				)
				,
				(
					@"c:/asb\asfas" , @"c:/asb/asfas"
				)
				,
				(
					@"\asb\asfas" , @"/asb/asfas"
				)
				,
				(
					@"/asb\asfas" , @"/asb/asfas"
				)
				,
				(
					@"/asb/asfas" , @"/asb/asfas"
				)
				,
				(
					@"asb/asfas" , @"asb/asfas"
				)
				,
				(
					@"asb/" , @"asb/"
				)
				,
				(
					@"asb\" , @"asb/"
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
			var op =  nilnul.txt.op_.unary_.fs_.NormalizeDeck.ForLinux;

			Assert.IsTrue(
				op.op(
					input
				)
				== output
			);
		}


	}
}
