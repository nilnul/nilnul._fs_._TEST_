﻿using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs.location_.link_.sym.tgt.create_.inNonExistDir
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var tmp = nilnul.fs.folder_._TmpX.Get();


			 string realPrefix = "r";
			var nextDenote = nilnul.fs.folder.denote_.vered_._NextX.Name(tmp, realPrefix);



			var real = nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(tmp.address.en, nextDenote);

			nilnul.fs.folder._CreateX.Void(
				real
				
				
			);


			 string linkPrefix1 = "l";
			var nextDenote1 = nilnul.fs.folder.denote_.vered_._NextX.Name(tmp, linkPrefix1);



			var link = nilnul.fs.address_.shield_.based_.BasedDiv.Of_baseOfAddress_divOfDnts(tmp.address.en.ToString(), nextDenote1,"another");

			nilnul.fs.folder_.link_.sym.create_._DllImportX.Vod_linkOfAddress(
				link.ToString()
				,
				real.ToString()
				
				
			);

			 string linkPrefix11 = "l2_";
			var nextDenote11 = nilnul.fs.folder.denote_.vered_._NextX.Name(tmp, linkPrefix11);



			var link11 = nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(tmp.address.en, nextDenote11);

			nilnul.fs.folder_.link._CreateX.Vod_ofAddresses(
				link11.ToString()
				,
				link.ToString()
				
				
			);








			var location = nilnul.fs.LocationA.Location(link11);

			var tgt = nilnul.fs.location_.link_.sym._TgtX.Path(location);

			Debug.Assert(

				nilnul.fs.address.EqX.Eq (
					nilnul.fs.address.eq_.AsShield.Singleton
					,tgt
					,real
				)
			);

			Debug.WriteLine(tgt);

			nilnul.fs.folder.explore_._ByExeSelfX.OfAddress(tgt);
		}
	}
}
