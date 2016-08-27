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

        public static DataTable GetTableByFieldNamesAndRowNumRange1(DataTable sourceDt, List<string> fieldNames, int startRowNum, int endRowNum)
        {
            DataTable tempDt = GetTableByFieldNames1(sourceDt, fieldNames); //筛选指定列
            DataTable resultDt = GetTableByRowNumRange1(tempDt, startRowNum, endRowNum);//筛选指定行

            return resultDt;
        }

       public static DataTable GetTableByRowNumRange1(DataTable sourceDt1, int startRowNum1, int endRowNum1)
        {
            try
            {
                if (startRowNum1 < 0) return null;
                if (sourceDt1.Rows.Count < endRowNum1) endRowNum1 = sourceDt1.Rows.Count;

                DataTable resultDt = sourceDt1.Clone();
                DataRow[] rows = sourceDt1.Select();
                for (int i = startRowNum1; i <= endRowNum1; i++)
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

       public static DataTable GetTableByFieldNames1(DataTable sourceDt, List<string> fieldNames)
        {
            try
            {
                DataTable resultDt = sourceDt.Copy();
                foreach (DataColumn dc in sourceDt.Columns)
                {
                    if (fieldNames.Contains(dc.ColumnName)) continue; //保留指定列数据
                  
                    resultDt.Columns.Remove(resultDt.Columns[dc.ColumnName]);
                }
                return resultDt;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
       public static DataTable ConvertFieldToType2(DataTable sourceDt2, string fieldName1, string fieldName2, string fieldName3, FieldValueType fieldType1, FieldValueType fieldType2, FieldValueType fieldType3)
       {
           try
           {
               if (fieldType1 == FieldValueType.非值文本 || fieldType2 == FieldValueType.非值文本 || fieldType3 == FieldValueType.非值文本) return null;
               if (!sourceDt2.Columns.Contains(fieldName1) || !sourceDt2.Columns.Contains(fieldName2) || !sourceDt2.Columns.Contains(fieldName3))
               {
                   MessageBox.Show("源表中未找到该列");
                   return null;
               }
               if (fieldType1 == FieldValueType.整数 || fieldType1 == FieldValueType.小数) return sourceDt2;
               if (fieldType2 == FieldValueType.整数 || fieldType2 == FieldValueType.小数) return sourceDt2;
               if (fieldType3 == FieldValueType.整数 || fieldType3 == FieldValueType.小数) return sourceDt2;

               //当字段值是整数型文本或小数型文本时，执行字段值对应转换
               DataTable resultDt = sourceDt2.Copy();
               resultDt.Columns.Remove(fieldName1); //先删掉该列， 防止与新添加列同名冲突
               resultDt.Columns.Remove(fieldName2);
               resultDt.Columns.Remove(fieldName3);
               //根据待转换字段的类型，进行相应的转换
               if (fieldType1 == FieldValueType.整数文本 || fieldType2 == FieldValueType.整数文本 || fieldType3 == FieldValueType.整数文本)
               {
                   resultDt.Columns.Add(fieldName1, typeof(int));
                   resultDt.Columns.Add(fieldName2, typeof(int));
                   resultDt.Columns.Add(fieldName3, typeof(int));
                   for (int i = 0; i < resultDt.Rows.Count; i++)
                   {
                       try
                       {
                           resultDt.Rows[i][fieldName1] = Convert.ToInt32(sourceDt2.Rows[i][fieldName1]);
                           resultDt.Rows[i][fieldName2] = Convert.ToInt32(sourceDt2.Rows[i][fieldName2]);
                           resultDt.Rows[i][fieldName2] = Convert.ToInt32(sourceDt2.Rows[i][fieldName2]);
                       }
                       catch (System.Exception ex)
                       {
                           continue;
                       }
                   }
               }
               else if (fieldType1 == FieldValueType.小数文本 || fieldType2 == FieldValueType.小数文本 || fieldType3 == FieldValueType.小数文本)
               {
                   resultDt.Columns.Add(fieldName1, typeof(double));
                   resultDt.Columns.Add(fieldName2, typeof(double));
                   resultDt.Columns.Add(fieldName2, typeof(double));
                   for (int i = 0; i < resultDt.Rows.Count; i++)
                   {
                       try
                       {
                           //将对应字段从文本转换为值
                           resultDt.Rows[i][fieldName1] = Convert.ToDouble(sourceDt2.Rows[i][fieldName1]);
                           resultDt.Rows[i][fieldName2] = Convert.ToDouble(sourceDt2.Rows[i][fieldName2]);
                           resultDt.Rows[i][fieldName3] = Convert.ToDouble(sourceDt2.Rows[i][fieldName3]);
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
       public static DataTable ConvertFieldToType1(DataTable sourceDt1, string fieldName, FieldValueType fieldType)
        {
            try
            {
                if (fieldType == FieldValueType.非值文本) return null;
                if (!sourceDt1.Columns.Contains(fieldName))
                {
                    MessageBox.Show("源表中未找到名为：" + fieldName + "的列");
                    return null;
                }
                if (fieldType == FieldValueType.整数 || fieldType == FieldValueType.小数) return sourceDt1;


                //当字段值是整数型文本或小数型文本时，执行字段值对应转换
                DataTable resultDt = sourceDt1.Copy();
                resultDt.Columns.Remove(fieldName); //先删掉该列， 防止与新添加列同名冲突
                //根据待转换字段的类型，进行相应的转换
                if (fieldType == FieldValueType.整数文本)
                {
                    resultDt.Columns.Add(fieldName, typeof(int));
                    for (int i = 0; i < resultDt.Rows.Count; i++)
                    {
                        try
                        {
                            resultDt.Rows[i][fieldName] = Convert.ToInt32(sourceDt1.Rows[i][fieldName]);
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
                            resultDt.Rows[i][fieldName] = Convert.ToDouble(sourceDt1.Rows[i][fieldName]);
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

      public static FieldValueType GetFieldType2(DataTable sourceDt, string fieldName1, string fieldName2, string fieldName3)
       {
           try
           {
               if (sourceDt == null || sourceDt.Rows.Count == 0)
                   return FieldValueType.非值文本;

               //只需要判断第一行指定列是否为数值即可
               object oneValue = sourceDt.Rows[0][fieldName1];
                oneValue = sourceDt.Rows[0][fieldName2];
                oneValue = sourceDt.Rows[0][fieldName3];
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

      public static DataTable GetTableByFieldNamesAndRowNumRange2(DataTable sourceDt, List<string> fieldNames1, List<string> fieldNames2, List<string> fieldNames3, int startRowNum, int endRowNum)
      {
          DataTable tempDt = GetTableByFieldNames2(sourceDt, fieldNames1,fieldNames2,fieldNames3); //筛选指定列
          DataTable resultDt = GetTableByRowNumRange1(tempDt, startRowNum, endRowNum);//筛选指定行

          return resultDt;
      }

   public static DataTable GetTableByFieldNames2(DataTable sourceDt, List<string> fieldNames1, List<string> fieldNames2, List<string> fieldNames3)
      {
          try
          {
              DataTable resultDt = sourceDt.Copy();
              foreach (DataColumn dc in sourceDt.Columns)
              {
                  if (fieldNames1.Contains(dc.ColumnName) || fieldNames2.Contains(dc.ColumnName) || fieldNames3.Contains(dc.ColumnName)) continue; //保留指定列数据

                  resultDt.Columns.Remove(resultDt.Columns[dc.ColumnName]);
              }
              return resultDt;
          }
          catch (System.Exception ex)
          {
              return null;
          }
      }

   public static DataTable GetTableByFieldNamesAndRowNumRange3(DataTable sourceDt, List<string> fieldNames31, List<string> fieldNames32, List<string> fieldNames33, List<string> fieldNames34, int startRowNum3, int endRowNum3)
   {
      DataTable tempDt = GetTableByFieldNames3(sourceDt, fieldNames31, fieldNames32, fieldNames33,fieldNames34); //筛选指定列
       DataTable resultDt = GetTableByRowNumRange1(tempDt, startRowNum3, endRowNum3);//筛选指定行

       return resultDt;
   }

   public static DataTable GetTableByFieldNames3(DataTable sourceDt, List<string> fieldNames31, List<string> fieldNames32, List<string> fieldNames33, List<string> fieldNames34)
   {
         try
          {
              DataTable resultDt = sourceDt.Copy();
              foreach (DataColumn dc in sourceDt.Columns)
              {
                  if (fieldNames31.Contains(dc.ColumnName) || fieldNames32.Contains(dc.ColumnName) || fieldNames33.Contains(dc.ColumnName) || fieldNames34.Contains(dc.ColumnName)) continue; //保留指定列数据

                  resultDt.Columns.Remove(resultDt.Columns[dc.ColumnName]);
              }
              return resultDt;
          }
          catch (System.Exception ex)
          {
              return null;
          }
   }

   public static DataTable ConvertFieldToType3(DataTable sourceDt2, string fieldName31, string fieldName32, string fieldName33,string fieldName34, FieldValueType fieldType1, FieldValueType fieldType2, FieldValueType fieldType3,FieldValueType fieldType4)
   {
       try
       {
           if (fieldType1 == FieldValueType.非值文本 || fieldType2 == FieldValueType.非值文本 || fieldType3 == FieldValueType.非值文本 || fieldType4 == FieldValueType.非值文本) return null;
           if (!sourceDt2.Columns.Contains(fieldName31) || !sourceDt2.Columns.Contains(fieldName32) || !sourceDt2.Columns.Contains(fieldName33) || !sourceDt2.Columns.Contains(fieldName34))
           {
               MessageBox.Show("源表中未找到该列");
               return null;
           }
           if (fieldType1 == FieldValueType.整数 || fieldType1 == FieldValueType.小数) return sourceDt2;
           if (fieldType2 == FieldValueType.整数 || fieldType2 == FieldValueType.小数) return sourceDt2;
           if (fieldType3 == FieldValueType.整数 || fieldType3 == FieldValueType.小数) return sourceDt2;
           if (fieldType4 == FieldValueType.整数 || fieldType4 == FieldValueType.小数) return sourceDt2;

           //当字段值是整数型文本或小数型文本时，执行字段值对应转换
           DataTable resultDt = sourceDt2.Copy();
           resultDt.Columns.Remove(fieldName31); //先删掉该列， 防止与新添加列同名冲突
           resultDt.Columns.Remove(fieldName32);
           resultDt.Columns.Remove(fieldName33);
           resultDt.Columns.Remove(fieldName34);
           //根据待转换字段的类型，进行相应的转换
           if (fieldType1 == FieldValueType.整数文本 || fieldType2 == FieldValueType.整数文本 || fieldType3 == FieldValueType.整数文本)
           {
               resultDt.Columns.Add(fieldName31, typeof(int));
               resultDt.Columns.Add(fieldName32, typeof(int));
               resultDt.Columns.Add(fieldName33, typeof(int));
               resultDt.Columns.Add(fieldName34, typeof(int));
               for (int i = 0; i < resultDt.Rows.Count; i++)
               {
                   try
                   {
                       resultDt.Rows[i][fieldName31] = Convert.ToInt32(sourceDt2.Rows[i][fieldName31]);
                       resultDt.Rows[i][fieldName32] = Convert.ToInt32(sourceDt2.Rows[i][fieldName32]);
                       resultDt.Rows[i][fieldName33] = Convert.ToInt32(sourceDt2.Rows[i][fieldName33]);
                       resultDt.Rows[i][fieldName34] = Convert.ToInt32(sourceDt2.Rows[i][fieldName34]);
                   }
                   catch (System.Exception ex)
                   {
                       continue;
                   }
               }
           }
           else if (fieldType1 == FieldValueType.小数文本 || fieldType2 == FieldValueType.小数文本 || fieldType3 == FieldValueType.小数文本 || fieldType4 == FieldValueType.小数文本)
           {
               resultDt.Columns.Add(fieldName31, typeof(double));
               resultDt.Columns.Add(fieldName32, typeof(double));
               resultDt.Columns.Add(fieldName33, typeof(double));
               resultDt.Columns.Add(fieldName34, typeof(double));
               for (int i = 0; i < resultDt.Rows.Count; i++)
               {
                   try
                   {
                       //将对应字段从文本转换为值
                       resultDt.Rows[i][fieldName31] = Convert.ToDouble(sourceDt2.Rows[i][fieldName31]);
                       resultDt.Rows[i][fieldName32] = Convert.ToDouble(sourceDt2.Rows[i][fieldName32]);
                       resultDt.Rows[i][fieldName33] = Convert.ToDouble(sourceDt2.Rows[i][fieldName33]);
                       resultDt.Rows[i][fieldName34] = Convert.ToDouble(sourceDt2.Rows[i][fieldName34]);
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
