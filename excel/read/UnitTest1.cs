using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Linq;
using System.Diagnostics;

namespace nilnul.fs._test.excel.read
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
			ReadExcelFileDOM(xlsx.ToString());

		}

		// The DOM approach.
		// Note that the code below works only for cells that contain numeric values.
		// 
		static void ReadExcelFileDOM(string fileName)
		{
			using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(fileName, false))
			{
				WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
				WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
				SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();
				string text;
				foreach (Row r in sheetData.Elements<Row>())
				{
					foreach (Cell c in r.Elements<Cell>())
					{
						text = c.CellValue.Text;
						Debug.Write(text + " ");
					}
				}
				Debug.WriteLine("");
				//Console.ReadKey();
			}
		}

		// The SAX approach.
		static void ReadExcelFileSAX(string fileName)
		{
			using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(fileName, false))
			{
				WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
				WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();

				OpenXmlReader reader = OpenXmlReader.Create(worksheetPart);
				string text;
				while (reader.Read())
				{
					if (reader.ElementType == typeof(CellValue))
					{
						text = reader.GetText();
						Console.Write(text + " ");
					}
				}
				Console.WriteLine();
				Console.ReadKey();
			}
		}
	}
}
