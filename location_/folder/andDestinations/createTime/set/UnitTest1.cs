using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.fs._test.location_.folder.andDestinations.createTime.set
{
	[TestClass]
	public class UnitTest1
	{
		//[TestMethod]
		public void location__folder_andDestinations_createTime_set()
		{
			var dir = "_4test";


			string applicationDirectory ;
			applicationDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetNam‌​e().CodeBase);
			applicationDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

			applicationDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

			/*
			 public static string AssemblyDirectory
{
    get
    {
        string codeBase = Assembly.GetExecutingAssembly().CodeBase;
        UriBuilder uri = new UriBuilder(codeBase);
        string path = Uri.UnescapeDataString(uri.Path);
        return Path.GetDirectoryName(path);
    }
}
The Assembly.Location property sometimes gives you some funny results when using NUnit (where assemblies run from a temporary folder), so I prefer to use CodeBase which gives you the path in URI format, then UriBuild.UnescapeDataString removes the File:// at the beginning, and GetDirectoryName changes it to the normal windows format.

			 */


			var folder = System.IO.Path.Combine(
				applicationDirectory
				,
				dir
				
			);

			folder = @"C:\Users\w\Desktop\out\f";
			nilnul.fs.location_.folder.andDestinations.SetCreateTime._Exec(
				folder
				,
				new DateTime(2014, 9, 27, 0, 51, 28)
			);

		}
	}
}
