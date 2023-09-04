using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace nilnul._fs_._TEST_.data.last
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
		}

		public static string Address()
		{
			var t=  nilnul.fs.address._UrlX.Unprefix(Assembly.GetExecutingAssembly().CodeBase );

			var appPath = nilnul.fs.address.op_.unary_._UpX._assumeUpNatural(t ,3);


			var div = @"_data(!Git\230226\";

			var shield = nilnul.fs.address_.shield_.baseDiv_.divInDivision_._BaseInAddressX.Create(
				appPath, div
			);

			var link = nilnul.obj.str.to_.scalar_._MaxOrDefaultX.Max(
				nilnul.fs.folder.docs_.ext_._LnkX.Dnts(shield)
				,
				d=>		nilnul.fs.file.attr_.CreateTime.Get(

					new nilnul.fs.address_.spear_.based_.Child(
						shield
						,d
					).ToString()
					
				)
						,
				System.Collections.Generic.Comparer<DateTime>.Default
			);

			if (link is null)
			{
				throw new NullReferenceException();

			}

			var linkAsAddress = new nilnul.fs.address_.spear_.based_.Child(
				shield
				,
				link
			);

			var tgt = nilnul.fs.file_.shortcut._VwX.Target(linkAsAddress);

			var path = tgt.ToString();// @"C:\Users\me\Desktop\Book1.xlsx";
			return path;

		}
	}
}
