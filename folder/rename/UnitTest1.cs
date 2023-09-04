using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._fs_._TEST_.folder.rename
{
	[TestClass]
	public class UnitTest1
	{
		private TestContext testContextInstance;
		public TestContext TestContext
		{
			get { return testContextInstance; }
			set { testContextInstance = value; }
		}
		[TestMethod]
		public void TestMethod1()
		{
			var testDir=(System.IO.Path.GetDirectoryName(this.TestContext.TestRunResultsDirectory));

			var oldName = "abc";
			var b4change = System.IO.Path.Combine(testDir,oldName);
			var newName = "def";
			var aftChange = System.IO.Path.Combine(testDir, newName);

			System.IO.Directory.CreateDirectory(b4change);



			nilnul.fs.folder_.baseDir._RenameX.FolderInAddress(
				b4change
				,
				newName

				
			);
			nilnul.fs.folder._OpenX.Open(testDir);
		}
	}
}
