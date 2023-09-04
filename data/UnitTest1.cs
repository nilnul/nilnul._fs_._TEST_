﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul._fs_._TEST_.data
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var appPath = nilnul.app_.dotnet_.dev._PathX.PrjBaseAsAddress_ofCalling();

			var div = @"_data(!Git\211122\";

			var shield = nilnul.fs.address_.shield_.baseDiv_.divInDivision_._BaseInAddressX.Create(
				appPath, div
			);

			var link = nilnul.fs.folder.docs_.ext_._LnkX.Dnts(shield).Single();

			var linkAsAddress = new nilnul.fs.address_.spear_.based_.Child(
				shield
				,
				link
			);

			var tgt = nilnul.fs.file_.shortcut._VwX.Target(linkAsAddress);

			var path = tgt.ToString();// @"C:\Users\me\Desktop\Book1.xlsx";
		}
	}
}
