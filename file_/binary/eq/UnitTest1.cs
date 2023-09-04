using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs._test.file_.binary.eq
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			nilnul.fs.folder_.tmp._LogAndShowX.LogTimedAndShow(
				nilnul.fs.file_.binary.Eq.EqOfDoc(

					@"E:\170203\data\nilnul.web\aspNet\_Ken\handler_\svc"
					,
					"svcLabSample (2).rar"
					,
					"svcLabSample (2).rar"

				)
			);
		}
	}
}
