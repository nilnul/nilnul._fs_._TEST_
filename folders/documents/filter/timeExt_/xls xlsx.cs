using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Diagnostics;

namespace nilnul.fs._test.folders.documents.filter.timeExt
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void folders_findXlsXlsx_inPeriod()
		{

			var period = new nilnul.time.period_.closed_.Day2DayBothIncluded(2017, 4, 11, 2017, 5, 12);


			//var folderInfo = new DirectoryInfo(@"E:\170203");

			var logParent = Path.GetTempPath();

			var address4logParent = nilnul.fs.Address.Parse(logParent);
			address4logParent.tryMakeFileLike();

			var logPrefix = "findPic";

			var logAddress = new nilnul.fs.folder.dsts.Ver(address4logParent.ToString()).getNextAddress(logPrefix, "txt");

			using (
				var log =nilnul.fs.File.EnsureFolderFile2AppendTxt( 

					logAddress
					
				)//nilnul.fs.File.AppendTxtEnsureFolder(@"c:\temp\a.txt")
			)
			{
				//log.AutoFlush = true;

				//log.WriteLine(folder.FullName);
				foreach (var document in nilnul.fs.folders.Documents.Enumerate_retFileInfos(
					@"E:\170203",
					@"C:\Users\wyt\Desktop"
				))
				{
					if (
						nilnul.fs.file._address_.doc_._dotted_._ext.txt.be_.XlsXlsx.Singleton.be(
							nilnul.fs.address_.File.Parse(document.FullName).doc.ext
						)
					)
					{
						//log.WriteLine("-----"+document.FullName);
						if (
							period.contain(document.CreationTime)
							||
							period.contain(document.LastAccessTime)
							||
							period.contain(document.LastWriteTime)
						)
						{
							log.WriteLine(document.FullName);

						}
					}

				}
				log.Flush();
				log.Close();

			}

			Process.Start(logAddress);


		}

	}
}
