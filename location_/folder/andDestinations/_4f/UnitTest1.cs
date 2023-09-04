using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs._test.location_.folder.andDestinations._4f
{
	[TestClass]
	public class UnitTest1
	{
		//[TestMethod]
		public void _4f()
		{

			var folder = @"";

			var software = "";

			var softFolder = System.IO.Path.Combine(folder, software);


			var src = "";

			var srcFolder = System.IO.Path.Combine(folder, src);


			nilnul.fs.location_.folder.andDestinations.SetCreateTime._Exec(
				softFolder
				,
				new DateTime(2014, 9, 27, 0, 51, 28)
			);
			nilnul.fs.location_.folder.andDestinations.SetLastAccessTime._Exec(
				softFolder
				,
				new DateTime(2014, 9, 27, 0, 51, 28)
			);
			nilnul.fs.location_.folder.andDestinations.SetLastWriteTime._Exec(
				softFolder
				,
				new DateTime(2014, 9, 26, 23, 36, 7)
			);

			nilnul.fs.location_.folder.andDestinations.SetCreateTime._Exec(
				srcFolder
				,
				new DateTime(2014, 9, 27, 0, 53, 34)
			);
			nilnul.fs.location_.folder.andDestinations.SetLastAccessTime._Exec(
				srcFolder
				,
				new DateTime(2014, 9, 27, 0, 53, 34)
			);
			nilnul.fs.location_.folder.andDestinations.SetLastWriteTime._Exec(
				srcFolder
				,
				new DateTime(2014, 9, 26, 23, 12, 05)
			);



			nilnul.fs.location_.folder.attr_.CreateTime.ChangeCreateTime(
				folder,
					new DateTime(2014, 9, 27, 0, 53, 39)

			);


			nilnul.fs.location_.folder.attr_.AccessTime.SetLastAccessTime(
				folder,
					new DateTime(2014, 9, 27, 0, 53, 39)

			);

			nilnul.fs.location_.folder.attr_.WriteTime.SetLastModifyTime(
				folder,
					new DateTime(2014, 9, 27, 0, 53, 39)

			);



		}
	}
}
