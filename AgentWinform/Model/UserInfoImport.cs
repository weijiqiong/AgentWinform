using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AgentWinform.Model
{
    public static class UserInfoImport<T> where T : new()
    {
        public static IList<T> ExcelImport(string FilePath, Dictionary<string, string> KeyTo, out string reusltString)
        {
            reusltString = string.Empty;
            List<T> resultList = new List<T>();
            FileInfo existingFile = new FileInfo(FilePath);

            Dictionary<string, int> dictHeader = new Dictionary<string, int>();

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                int colStart = worksheet.Dimension.Start.Column;  //工作区开始列
                int colEnd = worksheet.Dimension.End.Column;       //工作区结束列
                int rowStart = worksheet.Dimension.Start.Row;       //工作区开始行号
                int rowEnd = worksheet.Dimension.End.Row;       //工作区结束行号

                //将每列标题添加到字典中
                for (int i = colStart; i <= colEnd; i++)
                {
                    string headName = string.Empty;
                    if (!KeyTo.TryGetValue(worksheet.Cells[rowStart, i].Value.ToString(), out headName))
                    {
                        continue;
                    }

                    dictHeader[headName] = i;
                }

                List<PropertyInfo> propertyInfoList = new List<PropertyInfo>(typeof(T).GetProperties());

                for (int row = rowStart + 1; row <= rowEnd; row++)
                {
                    T result = new T();
                    //为对象T的各属性赋值
                    foreach (PropertyInfo p in propertyInfoList)
                    {
                        try
                        {
                            int intHeadName=0;
                            if (!dictHeader.TryGetValue(p.Name, out intHeadName))
                            {
                                continue;
                            }
                            ExcelRange cell = worksheet.Cells[row, intHeadName]; //与属性名对应的单元格
                            if (cell.Value == null)
                                continue;
                            switch (p.PropertyType.Name.ToLower())
                            {
                                case "string":
                                    p.SetValue(result, cell.GetValue<String>(), null);
                                    break;
                                case "int16":
                                    p.SetValue(result, cell.GetValue<Int16>(), null);
                                    break;
                                case "int32":
                                    p.SetValue(result, cell.GetValue<Int32>(), null);
                                    break;
                                case "int64":
                                    p.SetValue(result, cell.GetValue<Int64>(), null);
                                    break;
                                case "decimal":
                                    p.SetValue(result, cell.GetValue<Decimal>(), null);
                                    break;
                                case "double":
                                    p.SetValue(result, cell.GetValue<Double>(), null);
                                    break;
                                case "datetime":
                                    p.SetValue(result, cell.GetValue<DateTime>(), null);
                                    break;
                                case "boolean":
                                    p.SetValue(result, cell.GetValue<Boolean>(), null);
                                    break;
                                case "byte":
                                    p.SetValue(result, cell.GetValue<Byte>(), null);
                                    break;
                                case "char":
                                    p.SetValue(result, cell.GetValue<Char>(), null);
                                    break;
                                case "single":
                                    p.SetValue(result, cell.GetValue<Single>(), null);
                                    break;
                                case "enum":
                                    p.SetValue(result, cell.GetValue<string>(), null);
                                        break;
                                default:
                                    break;
                            }
                        }
                        catch (KeyNotFoundException ex)
                        {
                            reusltString += string.Format("第{0}行、第{1}列,出现错误：{2}/r/n", row.ToString(), dictHeader[p.Name].ToString(), ex.Message);
                            continue;
                        }
                    }
                    resultList.Add(result);
                }
            }
            return resultList;
        }



    }
}
