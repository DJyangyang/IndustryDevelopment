using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace ChartMenuBar
{
    class DataTableImp
    {
        /// <summary>
        /// 获取数据表指定行范围的数据，生成一个新表返回
        /// </summary>
        /// <param name="sourceDt"></param>
        /// <param name="startRowNum"></param>
        /// <param name="endRowNum"></param>
        /// <returns></returns>
        public static DataTable GetTableByRowNumRange(DataTable sourceDt, int startRowNum, int endRowNum)
        {
            try
            {
                if(startRowNum <0) return null;
                if (sourceDt.Rows.Count < endRowNum) endRowNum = sourceDt.Rows.Count;

                DataTable resultDt = sourceDt.Clone();
                DataRow[] rows = sourceDt.Select();
                for (int i = startRowNum; i <= endRowNum; i++)
                {
                    resultDt.ImportRow((DataRow)rows[i]);
                }
                return resultDt; 

            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取指定字段数据，生成新的表返回
        /// </summary>
        /// <param name="sourceDt"></param>
        /// <param name="fieldNames"></param>
        /// <returns></returns>
        public static DataTable GetTableByFieldNames(DataTable sourceDt, List<string> fieldNames,List<string>fieldNames1)
        {
            try
            {
                DataTable resultDt = sourceDt.Copy();
                foreach (DataColumn dc in sourceDt.Columns)
                {
                    if (fieldNames.Contains(dc.ColumnName)) continue; //保留指定列数据
                    if (fieldNames1.Contains(dc.ColumnName)) continue; //保留指定列数据
                    resultDt.Columns.Remove(resultDt.Columns[dc.ColumnName]);
                }
                return resultDt;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 根据指定列和行号范围生成新的表
        /// </summary>
        /// <param name="sourceDt"></param>
        /// <param name="fieldNames"></param>
        /// <param name="startRowNum"></param>
        /// <param name="endRowNum"></param>
        /// <returns></returns>
        public static DataTable GetTableByFieldNamesAndRowNumRange(DataTable sourceDt, List<string> fieldNames,List<string>fieldNames1, int startRowNum, int endRowNum)
        {
            DataTable tempDt = GetTableByFieldNames(sourceDt, fieldNames,fieldNames1); //筛选指定列
            DataTable resultDt = GetTableByRowNumRange(tempDt, startRowNum, endRowNum);//筛选指定行

            return resultDt;
        }

        public static DataTable ConvertFieldToType(DataTable sourceDt, string fieldName,string fieldName1, FieldValueType fieldType,FieldValueType fieldType1)

        {
            try
            {
                if (fieldType == FieldValueType.非值文本) return null;
                if (!sourceDt.Columns.Contains(fieldName))
                {
                    MessageBox.Show("源表中未找到名为：" + fieldName + "的列");
                    return null;
                }
                if (fieldType == FieldValueType.整数 || fieldType == FieldValueType.小数) return sourceDt;


                //当字段值是整数型文本或小数型文本时，执行字段值对应转换
                DataTable resultDt = sourceDt.Copy();
                resultDt.Columns.Remove(fieldName); //先删掉该列， 防止与新添加列同名冲突
                //根据待转换字段的类型，进行相应的转换
                if (fieldType == FieldValueType.整数文本)
                {
                    resultDt.Columns.Add(fieldName, typeof(int));
                    for (int i = 0; i < resultDt.Rows.Count;i++ )
                    {
                        try
                        {
                            resultDt.Rows[i][fieldName] = Convert.ToInt32(sourceDt.Rows[i][fieldName]);
                        }
                        catch (System.Exception ex)
                        {
                            continue;
                        }                      
                    }
                }
                else if (fieldType == FieldValueType.小数文本)
                {
                    resultDt.Columns.Add(fieldName, typeof(double));
                    for (int i = 0; i < resultDt.Rows.Count; i++)
                    {
                        try
                        {
                            //将对应字段从文本转换为值
                            resultDt.Rows[i][fieldName] = Convert.ToDouble(sourceDt.Rows[i][fieldName]);
                        }
                        catch (System.Exception ex)
                        {
                            continue;
                        }
                    }
                }
                else
                    return null;

                return resultDt;
                
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取指定字段的值类型
        /// </summary>
        /// <param name="sourceDt"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static FieldValueType GetFieldType(DataTable sourceDt, string fieldName)
        {
            try
            {
                if (sourceDt == null || sourceDt.Rows.Count == 0)
                    return FieldValueType.非值文本;

                //只需要判断第一行指定列是否为数值即可
                object oneValue = sourceDt.Rows[0][fieldName];
                if (oneValue is int)
                {
                    return FieldValueType.整数;
                }
                else if (oneValue is double)
                {
                    return FieldValueType.小数;
                }

                int outValue1;
                double outValue2;
                bool canParseToInt = int.TryParse(oneValue.ToString(), out outValue1);
                bool canParseToDouble = double.TryParse(oneValue.ToString(), out outValue2);

                if (canParseToInt)
                {
                    return FieldValueType.整数文本;
                }
                if (canParseToDouble)
                {
                    return FieldValueType.小数文本;
                }

                return FieldValueType.非值文本;
            }
            catch (System.Exception ex)
            {
                return FieldValueType.非值文本;
            }
        }
    }


    public enum FieldValueType
    {
        非值文本 = 0,
        整数文本 = 1,
        小数文本 = 2,
        整数 = 3,
        小数 = 4
    }
}
