using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocumentFormat.OpenXml.Packaging;
using System.IO;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Linq;
using System.Diagnostics;

namespace nilnul.fs._test.excel.read.fileStream.sheetDataOther
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

				foreach (WorksheetPart worksheetPart in document.WorkbookPart.WorksheetParts)
				{


					string sheetArea =worksheetPart.Worksheet.SheetDimension.Reference.Value;
					Debug.WriteLine(sheetArea);

					foreach (SheetData sheetData in worksheetPart.Worksheet.Elements<SheetData>())
					{
						if (sheetData.HasChildren)
						{
							foreach (Row row in sheetData.Elements<Row>())
							{
								Debug.WriteLine(row.ToString());
								foreach (Cell cell in row.Elements<Cell>())
								{
									cellValue = cell.InnerText;

									if (cell.DataType != null && cell.DataType == CellValues.SharedString)
									{
										Debug.Write("cell val: " + sharedStringTable?.ElementAt(Int32.Parse(cellValue)).InnerText);
									}
									else
									{
										Debug.Write("cell val: " + cellValue);
									}
								}
							}
						}
					}
				}
				document.Close();
			}
		}
	}
}