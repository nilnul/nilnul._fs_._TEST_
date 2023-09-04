using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs._test.address_.volRoute_.container.parse
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			nilnul.fs.address_.Shield.Parse(
				@"c:\"
			);

			nilnul.fs.address_.Shield.Parse(
				@"c:\a\"
			);

			nilnul.fs.address_.Shield.Parse(
				@"c:\a\b\"
			);
			nilnul.fs.address_.Shield.Parse(
				@"c:\a\b\c\"
			);




		}
	}
}
