using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.fs.address_.spear;

namespace nilnul._fs_._TEST_.address_.spear.be_.file.overlong
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			/*
			var p = @"D:\170203\data\nilnul._web_\aspNet\_KEN_(Git\_app_\_structure_\handler_\_webForm\ctr_\tmpltCtr_\usrCtr_\_master\_myMaster\masterLayout\testSubInheritsSuperFolderMaster~theSubApps\obj\Debug\testSubInheritsSuperFolderMaster~theSubApps.csproj.FileListAbsolute.txt"


;

			var b = nilnul.fs.address_.spear.be_.File.Singleton.Be_ofAddress(p);

			///  // Summary:
			//     Checks for a condition; if the condition is false, displays a message box that
			//     shows the call stack.

			//Debug.Assert(b);
			nilnul.bit.vow_.True1.Vow(b);
		*/

			var file2be = new nilnul.fs.address_.spear_.ParentDocument(
						nilnul.fs.folder_._TmpX.Get().address.en
						,
						@"170203\data\nilnul._web_\aspNet\_KEN_(Git\_app_\_structure_\handler_\_webForm\ctr_\tmpltCtr_\usrCtr_\_master\_myMaster\masterLayout\testSubInheritsSuperFolderMaster~theSubApps\obj\Debug\testSubInheritsSuperFolderMaster~theSubApps.csproj.FileListAbsolute.txt"
						);

			nilnul.fs._file._EnsureX.Ensure(file2be);
			//nilnul.fs._file._EnsureX.Ensure(folder2be.ToString());

			var b1 = nilnul.fs.address_.spear.be_.File.Singleton.be(file2be);

			//Debug.Assert(b1);
			nilnul.bit.vow_.True1.Vow(b1);


		}
	}
}
