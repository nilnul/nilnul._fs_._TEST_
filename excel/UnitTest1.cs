using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace nilnul.fs._test.excel
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
				prjBase,"_data"
			);


			var xlsx = nilnul.fs.address_.volRoute_.container.to_.Element.JoinDoc(dataContainer,

				new nilnul.fs._address.doc_.Dotted("0", "xlsx")
				
			);



			//string docName = @"C:\Users\Public\Documents\MergeCellsEx.xlsx";
			//string sheetName = "mySheet";
			string cell1Name = "A2";
			string cell2Name = "B2";


			using (SpreadsheetDocument document = SpreadsheetDocument.Open(xlsx.ToString(), true))
			{
				Worksheet worksheet = GetWorksheet(document, "Sheet1");
				// Create Spreadsheet cells.
				CreateSpreadsheetCell(worksheet, cell1Name);
				CreateSpreadsheetCell(worksheet, cell2Name);
				MergeCells mergeCells;

				if (worksheet.Elements<MergeCells>().Count() > 0)
					mergeCells = worksheet.Elements<MergeCells>().First();
				else
				{
					mergeCells = new MergeCells();

					// Insert a MergeCells object into the specified position.
					if (worksheet.Elements<CustomSheetView>().Count() > 0)
						worksheet.InsertAfter(mergeCells, worksheet.Elements<CustomSheetView>().First());
					else
						worksheet.InsertAfter(mergeCells, worksheet.Elements<SheetData>().First());
				}

				// Create the merged cell and append it to the MergeCells collection.
				MergeCell mergeCell = new MergeCell()
				{
					Reference =
					new StringValue(cell1Name + ":" + cell2Name)
				};
				mergeCells.Append(mergeCell);
				worksheet.Save();
			}
			Debug.WriteLine("The two cells are now merged.\nPress a key.");
			//Console.ReadKey();
		}

		// Get the specified worksheet.
		private static Worksheet GetWorksheet(SpreadsheetDocument document, string worksheetName)
		{
			IEnumerable<Sheet> sheets = document.WorkbookPart.Workbook
				.Descendants<Sheet>().Where(s => s.Name == worksheetName);
			WorksheetPart worksheetPart = (WorksheetPart)document.WorkbookPart
				.GetPartById(sheets.First().Id);
			return worksheetPart.Worksheet;
		}

		private static Worksheet GetWorksheet(SpreadsheetDocument document)
		{
			IEnumerable<Sheet> sheets = document.WorkbookPart.Workbook
				.Descendants<Sheet>();
			WorksheetPart worksheetPart = (WorksheetPart)document.WorkbookPart
				.GetPartById(sheets.First().Id);
			return worksheetPart.Worksheet;
		}


		// Create a spreadsheet cell. 
		private static void CreateSpreadsheetCell(Worksheet worksheet, string cellName)
		{
			string columnName = GetColumnName(cellName);
			uint rowIndex = 2;
			IEnumerable<Row> rows = worksheet.Descendants<Row>().Where(r => r
				.RowIndex.Value == rowIndex);
			Row row = rows.First();
			IEnumerable<Cell> cells = row.Elements<Cell>().Where(c => c.CellReference
				.Value == cellName);
		}

		// Parse the cell name to get the column name.
		private static string GetColumnName(string cellName)
		{
			// Create a regular expression to match the column name portion of the cell name.
			Regex regex = new Regex("[A-Za-z]+");
			Match match = regex.Match(cellName);
			return match.Value;
		}
	}
}
