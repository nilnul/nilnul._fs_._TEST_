using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Diagnostics;

namespace nilnul.fs._test.folders.documents.filter
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void folders_findPic()
		{

			var period = new nilnul.time.period_.closed_.Day2DayBothIncluded(2017, 4, 11, 2017, 5, 3);

			//var folderInfo = new DirectoryInfo(@"E:\170203");

			var logParent = Path.GetTempPath();

			var address4logParent = nilnul.fs.AddressA.Parse(logParent);
			address4logParent= nilnul.fs.address.op_.unary_.Shrink.Singleton.op(address4logParent);

			var logPrefix = "findPic";

			var logAddress =  nilnul.fs.folder.denote_.MainVered.OvAddress(address4logParent.ToString()).nextAddress(logPrefix, "txt");

			using (
				var log =nilnul.fs.file.blob.writer_._Ensure2AppendX.TxtStreamWriter( 

					logAddress
					
				)//nilnul.fs.File.AppendTxtEnsureFolder(@"c:\temp\a.txt")
			)
			{
				//log.AutoFlush = true;

				//log.WriteLine(folder.FullName);
				foreach (var document in nilnul.fs.folders._DocumentsX.Infos_ofAddresses(
					@"E:\170203",
					@"C:\Users\wyt\Desktop"
				))
				{
					if (
						nilnul.fs.file.be_.ext_._address_.doc_._dotted_._ext.txt.be_.XlsXlsx.Singleton.be(
							nilnul.fs.File.Parse(document.FullName).doc.ext
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
			Debug.WriteLine(logAddress);
			Process.Start(logAddress);


		}

	}
}
