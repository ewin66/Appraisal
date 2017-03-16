using System;
using System.Collections.Generic;
using System.Data;
using Excel_VBA = Microsoft.Office.Interop.Excel;

namespace Appraisal.Module.Core
{
/// <summary>
/// Summary description for ExcelAPI
/// </summary>
    public class ExcelApi
    {
        public ExcelApi()
        {
            //
            // TODO: Add constructor logic here
            //
            
        }

        public static DataTable LoadExcelFile_VBA(string strFile, int sheetIndex, string columnsNames)
        {
            DataTable dt = new DataTable();
        
            try
            {
                Excel_VBA.Application xlApp;
                Excel_VBA.Workbook xlWorkBook;
                Excel_VBA.Worksheet xlWorkSheet;
                Excel_VBA.Range range;

                int rCnt;
                int cCnt;

                xlApp = new Excel_VBA.Application();
                xlWorkBook = xlApp.Workbooks.Open(strFile, 0, true, 5, "", "", true, Excel_VBA.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel_VBA.Worksheet)xlWorkBook.Worksheets.get_Item(sheetIndex);
                range = xlWorkSheet.UsedRange;
                int colCount = range.Columns.Count;
                int rowCount = range.Rows.Count;
                if (rowCount <= 1)
                    return dt;
                for (int colInx = 1; colInx <= colCount; colInx++)
                {
                    string colname = GetValidColumnName(Convert.ToString((range.Cells[1, colInx] as Excel_VBA.Range).Value), dt.Columns);
                    object TypeName = (object)(range.Cells[2, colInx] as Excel_VBA.Range).Value;
                    dt.Columns.Add(colname, TypeName == null ? typeof(string) : (TypeName).GetType());
                }
                string address = range.get_Address();
                string[] cells = address.Split(new char[] { ':' });
                string beginCell = cells[0].Replace("$", "");
                string endCell = cells[1].Replace("$", "");
            
                object[,] objectArray = (object[,])xlWorkSheet.get_Range(beginCell + ":" + endCell).Value;
                for (rCnt = 2; rCnt <= rowCount; rCnt++)
                {
                    DataRow row = dt.NewRow();
                    for (cCnt = 1; cCnt <= colCount; cCnt++)
                    {
                        string type2 = dt.Columns[cCnt - 1].DataType.ToString();
                        if (objectArray[rCnt, cCnt] != null && (objectArray[rCnt, cCnt].GetType() == dt.Columns[cCnt - 1].DataType || dt.Columns[cCnt - 1].DataType == typeof(string)))
                            row[cCnt - 1] = objectArray[rCnt, cCnt];
                    }
                    dt.Rows.Add(row);
                }
                objectArray = null;
                xlWorkBook.Close(true, null, null);
                xlApp.Quit();
                ReleaseObject(xlWorkSheet);
                ReleaseObject(xlWorkBook);
                ReleaseObject(xlApp);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return dt;
        }
        public static List<DataTable> LoadExcelFile_VBA(string strFile, int[] sheetIndex)
        {
            List<DataTable> dts = new List<DataTable>();

            try
            {
                Excel_VBA.Application xlApp;
                Excel_VBA.Workbook xlWorkBook;
                Excel_VBA.Worksheet xlWorkSheet = null;
                Excel_VBA.Range range;

                int rCnt;
                int cCnt;

                xlApp = new Excel_VBA.Application();
                xlWorkBook = xlApp.Workbooks.Open(strFile, 0, true, 5, "", "", true, Excel_VBA.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                foreach (int inx in sheetIndex)
                {
                    DataTable dt = new DataTable();
                    xlWorkSheet = (Excel_VBA.Worksheet)xlWorkBook.Worksheets.get_Item(inx);
                    range = xlWorkSheet.UsedRange;
                    int colCount = range.Columns.Count;
                    int rowCount = range.Rows.Count;
                    if (rowCount <= 1)
                    {
                        dts.Add(dt);
                        continue;
                    }
                    for (int colInx = 1; colInx <= colCount; colInx++)
                    {
                        string colname = GetValidColumnName(Convert.ToString((range.Cells[1, colInx] as Excel_VBA.Range).Value), dt.Columns);
                        object TypeName = (object)(range.Cells[2, colInx] as Excel_VBA.Range).Value;
                        dt.Columns.Add(colname, TypeName == null ? typeof(string) : (TypeName).GetType());
                    }
                    string address = range.get_Address();
                    string[] cells = address.Split(new char[] { ':' });
                    string beginCell = cells[0].Replace("$", "");
                    string endCell = cells[1].Replace("$", "");

                    object[,] objectArray = (object[,])xlWorkSheet.get_Range(beginCell + ":" + endCell).Value;
                    for (rCnt = 2; rCnt <= rowCount; rCnt++)
                    {
                        DataRow row = dt.NewRow();
                        for (cCnt = 1; cCnt <= colCount; cCnt++)
                        {
                            string type2 = dt.Columns[cCnt - 1].DataType.ToString();
                            if (objectArray[rCnt, cCnt] != null && (objectArray[rCnt, cCnt].GetType() == dt.Columns[cCnt - 1].DataType || dt.Columns[cCnt - 1].DataType == typeof(string)))
                                row[cCnt - 1] = objectArray[rCnt, cCnt];
                        }
                        dt.Rows.Add(row);
                    }
                    objectArray = null;
                    dts.Add(dt);
                }
                xlWorkBook.Close(true, null, null);
                xlApp.Quit();
                ReleaseObject(xlWorkSheet);
                ReleaseObject(xlWorkBook);
                ReleaseObject(xlApp);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return dts;
        }
        private static string GetValidColumnName(string colname, DataColumnCollection cols)
        {
            bool nameInUse = false;
            foreach (DataColumn col in cols)
            {
                if (col.ColumnName == colname)
                {
                    nameInUse = true;
                    break;
                }
            }
            if (!nameInUse)
                return colname;

            for (int i = 1; i < 255; i++)
            {
                bool nameExists = false;
                foreach (DataColumn col in cols)
                {
                    if (col.ColumnName == colname + i)
                    {
                        nameExists = true;
                        break;
                    }
                }
                if (!nameExists)
                {
                    colname = colname + i;
                    break;
                }
            }
            return colname;
        }
        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                obj = null;
                GC.Collect();
            }
        }


    }
}