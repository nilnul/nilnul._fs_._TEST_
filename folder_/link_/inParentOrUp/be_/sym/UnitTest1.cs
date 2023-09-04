using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._fs_._TEST_.folder_.link_.inParentOrUp.be_.sym
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var tmpSub = nilnul.fs.folder.denote_.vered_.next._CreateFolderX.CreateFolder_retInfo(nilnul.fs.folder_._TmpX.Get(), "a");

			nilnul.obj.vow_.True.Vow( nilnul.fs.folder.be_.Normal.Singleton.be(tmpSub));

			var realDir = nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(tmpSub, "b");

			nilnul.fs.folder._CreateX.Void(realDir);

			//nilnul.fs.folder.dir._CreateX.Void_ofAddressName(tmpSub, "b");



			var linkFolder =  nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(tmpSub, "link2b");

			nilnul.fs.folder_.link._CreateX.Void(linkFolder, realDir);

			////create link
			//nilnul.fs.folder.dir_.link_._SymX.Create__parentAddress_dirName(

			//	tmpSub
			//		, 
			//	"link2b"
			//	,
			//	realDir
			//);


			var f= nilnul.fs.folder.dir._CreateX.Folder_ofDirName(linkFolder, "c");

			Debug.WriteLine( 
				nilnul.fs.folder.be_._SymlinkX.Be(f)
				
			);

			Debug.WriteLine( 
				nilnul.fs.folder.dir.be_._SymlinkX.Be(f)
				
			);

			nilnul.fs.folder.explore_._ByExeSelfX.Exe(tmpSub);

		}
	}
}
