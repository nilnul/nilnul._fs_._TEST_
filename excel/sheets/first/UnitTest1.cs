using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Linq;
using System.Diagnostics;

namespace nilnul.fs._test.excel.read.sheets.first
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var processBase = nilnul.win.process_.dotNet.Addresses.container_AppDomainBase;


			var prjBase = nilnul.fs.address_.volRoute_.container.convert_.UpN._Eval(processBase, 2u);

			var dataContainer = nilnul.fs.address_.volRoute_.container.convert_.join_._DirX.Eval_ofContainerDst(
				prjBase, "_data"
			);


			var xlsx = nilnul.fs.address_.volRoute_.container.to_.Element.JoinDoc(dataContainer,

				new nilnul.fs._address.doc_.Dotted("0", "xlsx")

			);


			var fileName = xlsx.ToString();
			using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				// open the document read-only
				SpreadsheetDocument document = SpreadsheetDocument.Open(fs, false);
				SharedStringTable sharedStringTable = document.WorkbookPart.SharedStringTablePart?.SharedStringTable;
				string cellValue = null;


				var wbPart = document.WorkbookPart;
				Debug.WriteLine(

					
						
								wbPart.Workbook.Sheets.Elements<Sheet>().First().Id.Value

								+ 
								wbPart.Workbook.Sheets.Elements<Sheet>().First().Name.Value

							   
					
					
					//.SheetDimension.Reference.Value	//the cells
				);

				Debug.WriteLine(

					(
						wbPart.GetPartById(
							wbPart.Workbook.Sheets.Elements<Sheet>().First().Id.Value
						) as WorksheetPart
					).Worksheet.SheetDimension.Reference.Value	//the cells
				);

			}
		}
	}
}
