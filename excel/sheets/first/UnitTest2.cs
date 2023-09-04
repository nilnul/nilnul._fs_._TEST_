using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs._test.excel.sheets.first
{
	[TestClass]
	public class UnitTest2
	{
		[TestMethod]
		public void TestMethod1()
		{/*

			As far as I know, something like:
Sheet firstSheet = wbPart.Workbook.Descendants<Sheet>().First();
			Worksheet firstWorksheet = ((WorksheetPart)wbPart.GetPartById(firstSheet.Id)).Worksheet;

			Should return the first worksheet. The workbook Sheet descendants should always be sorted based on the order they appear in the workbook, at least in my experience.
*/




			/*

If you wish to get the first visible, use:
Sheet firstSheet = wbPart.Workbook.Descendants<Sheet>()
						 .First(s => s.State == SheetStateValues.Visible);
						 */
		}
	}
}
