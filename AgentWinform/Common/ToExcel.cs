using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AgentWinform.Common
{
    public static class ToExcel<T>
    {

        public static byte[] ToExcelFile(string FilePath, IList<T> dataSoure)
        {
            FileInfo fi = new FileInfo(FilePath);

            using (ExcelPackage p = new ExcelPackage(fi, true))
            {

                ExcelWorksheet ws = p.Workbook.Worksheets[1];

                for (int i = 1; i <= 26; i++)
                {

                    for (int j = 1; j <= 50; j++)//表格循环
                    {

                        if (ws.Cells[i, j].Value == null)
                        {

                            continue;

                        }

                        string str = ws.Cells[i, j].Value.ToString().Trim();

                        if (str.IndexOf('{') >= 0 && str.IndexOf('}') > 0)//查找标签
                        {

                            var style = ws.Cells[i, j].Style;

                            var Todata = System.Activator.CreateInstance<T>();

                            var name = str.Replace("{", "").Replace("}", "");

                            var resault = new List<string>();

                            bool isFind = false;

                            foreach (var item in Todata.GetType().GetProperties())//获取数据源属性匹配
                            {

                                if (item.Name==name)
                                {

                                    foreach (var it in dataSoure)//匹配后复制到数组
                                    {

                                        var value = item.GetValue(it, null);

                                        if (value == null)
                                        {

                                            resault.Add(string.Empty);

                                        }

                                        else
                                        {



                                            resault.Add(value.ToString());

                                        }

                                    }

                                    isFind = true;

                                    break;

                                }

                            }

                            if (!isFind)//如果没有找到该标签则把标签清除
                            {

                                for (int k = 0; k < dataSoure.Count; k++)
                                {

                                    resault.Add(string.Empty);

                                }

                            }





                            int rowIndex = i;

                            foreach (var item in resault)//渲染
                            {

                                ws.Cells[rowIndex, j].Value = item;

                                ws.Cells[rowIndex, j].Style.Border.Top.Style = style.Border.Top.Style;

                                ws.Cells[rowIndex, j].Style.Border.Bottom.Style = style.Border.Bottom.Style;

                                ws.Cells[rowIndex, j].Style.Border.Right.Style = style.Border.Right.Style;

                                ws.Cells[rowIndex, j].Style.Border.Left.Style = style.Border.Left.Style;

                                rowIndex++;

                            }

                        }

                    }

                }

                return p.GetAsByteArray();

            }

        }
    }




}

