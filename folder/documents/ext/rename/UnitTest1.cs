using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace nilnul.fs._test.folder.documents.ext.rename
{
	[TestClass]
	public class UnitTest1
	{
	//	[TestMethod]
		public void renExt()
		{

			renameRecur(
				@"C:\16003\data(yt\w.ax\_win\_data\fort_"
,
				"target"
				,
				"fort"
			);


		}

		void renameRecur(string folder,string oldExt, string newExt) {

			foreach (var dir in Directory.EnumerateDirectories(folder))
			{
				renameRecur(dir,oldExt,newExt);
			}

			renameThis(folder, oldExt,newExt );

		}

		void renameThis(string folder, string extOld,string extNew) {
			foreach (string f in Directory.GetFiles(folder, "*." + extOld))
			{

				System.IO.File.Move(f, Path.ChangeExtension(f,extNew));
			}


		}
	}
}
