using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace nilnul.fs._test.location_.folder.andDestinations.search.documents
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void findPic()
		{

			var period = new nilnul.time.period_.closed_.Day2DayBothIncluded(2017, 4, 11, 2017, 5, 20);
			var folderInfo = new DirectoryInfo(@"E:\170203");

			var logParent = Path.GetTempPath();

			var address4parent = nilnul.fs.Address.Parse(logParent);
			address4parent.tryMakeFileLike();

			var logPrefix = "findPic";



			using (
				var log =nilnul.fs.File.EnsureFolderFile2AppendTxt( 


					new nilnul.fs.folder.dsts.Ver(address4parent.ToString()).getNextAddress(logPrefix, "txt") 
				)//nilnul.fs.File.AppendTxtEnsureFolder(@"c:\temp\a.txt")
			)
			{
				//log.AutoFlush = true;

				//log.WriteLine(folder.FullName);
				foreach (var document in nilnul.fs.folder.Documents.Enumerate(folderInfo))
				{
					if (
						nilnul.fs.file._address_.doc_._dotted_._ext.txt.be_.Pic.Singleton.be(
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


		}






	}
}
