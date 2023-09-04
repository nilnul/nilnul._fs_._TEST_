using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.fs.address_.shield;

namespace nilnul._fs_._TEST_.address_.shield.be_.folder
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var tmp = nilnul.fs.folder_._TmpX.Ensure();

			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				nilnul.fs.address_.shield.be_.Folder.Singleton.be(tmp.address.en)
			) ;

			//create short path

			var short1 = nilnul.fs.folder_.tmp.denote_.ver_.next._CreateFolderX.Folder_ofVered("a");
			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				nilnul.fs.address_.shield.be_.Folder.Singleton.be(short1.address.en)
			) ;

			var shortNonExist = nilnul.fs.folder_.tmp.denote_.ver_._NextX.Address_ofDenote("a");

			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				nilnul.fs.address_.shield.be_.folder.Anto.Singleton.Be_ofAddress(shortNonExist)
			) ;

			nilnul.fs.folder._CreateX._Void_ofAddress(shortNonExist);

			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				nilnul.fs.address_.shield.be_.Folder.Singleton.be(shortNonExist)
			);

			GC.Collect();
			GC.WaitForPendingFinalizers();

			var len = shortNonExist.ToString().Length;

			nilnul.fs.folder._DropX.Vod_ofAddress(shortNonExist);



			var dirs = new List<string>();

			for (int i = 0; i < 50; i++)
			{
				dirs.Add( Guid.NewGuid().ToString());
			}

			var longShield = new nilnul.fs.address_.shield_.BaseDiv(
				tmp.address.en
				,

				dirs.Select(d=> nilnul.fs._address.Dir.OvDenote(d))
			);



			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				nilnul.fs.address_.shield.be_.folder.Anto.Singleton.be(longShield)
			) ;

			nilnul.fs.folder._CreateX.Void(longShield);

			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				nilnul.fs.address_.shield.be_.Folder.Singleton.be(longShield)
			) ;

			GC.Collect();
			GC.WaitForPendingFinalizers();

			var len1 = longShield.ToString().Length;

			nilnul.fs.folder._DropX.Vod(longShield);


			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				nilnul.fs.address_.shield.be_.folder.Anto.Singleton.be(longShield)
			) ;




		}
	}
}
