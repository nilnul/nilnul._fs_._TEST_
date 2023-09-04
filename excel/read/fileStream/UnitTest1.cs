using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using System.Linq;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Diagnostics;

namespace nilnul.fs._test.excel.read.fileStream
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
				using (SpreadsheetDocument doc = SpreadsheetDocument.Open(fs, false))
				{
					WorkbookPart workbookPart = doc.WorkbookPart;
					SharedStringTablePart sstpart = workbookPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();
					SharedStringTable sst = sstpart?.SharedStringTable;

					WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
					Worksheet sheet = worksheetPart.Worksheet;

					var cells = sheet.Descendants<Cell>();
					var rows = sheet.Descendants<Row>();

					Debug.WriteLine("Row count = {0}", rows.LongCount());
					Debug.WriteLine("Cell count = {0}", cells.LongCount());

					// One way: go through each cell in the sheet
					foreach (Cell cell in cells)
					{
						if ((cell.DataType != null) && (cell.DataType == CellValues.SharedString))
						{
							int ssid = int.Parse(cell.CellValue.Text);
							string str = sst?.ChildElements[ssid].InnerText;
							Debug.WriteLine("Shared string {0}: {1}", ssid, str);
						}
						else if (cell.CellValue != null)
						{
							Debug.WriteLine("Cell contents: {0}", cell.CellValue.Text);
						}
					}

					// Or... via each row
					foreach (Row row in rows)
					{
						foreach (Cell c in row.Elements<Cell>())
						{
							if ((c.DataType != null) && (c.DataType == CellValues.SharedString))
							{
								int ssid = int.Parse(c.CellValue.Text);
								string str = sst?.ChildElements[ssid].InnerText;
								Debug.WriteLine("Shared string {0}: {1}", ssid, str);
							}
							else if (c.CellValue != null)
							{
								Debug.WriteLine("Cell contents: {0}", c.CellValue.Text);
							}
						}
					}
				}
			}
		}
	}
}
