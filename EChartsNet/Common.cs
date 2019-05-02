using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EChartsNet
{
    public class Common
    {
        
        
        public static string GetPro(string str, string repalce = null)
        {
            if (String.IsNullOrWhiteSpace(str)) return "";
            if (String.IsNullOrWhiteSpace(repalce)) return str;
            return repalce.Replace("{$}", str);

        }
        public static string GetEnumPro(Enum value)
        {
            return GetPro(Remark.GetRemark(value), null);
        }
        public static string GetEnumPro(Type type, string value)
        {
            return GetPro(Remark.GetRemark(type, value), null);
        }
        public static string Join(string[] data, string quoteStr = "'", char splitStr = ',', string includeStr = "[]", bool HaveNewLine = false)
        {
            var header = String.IsNullOrWhiteSpace(includeStr) ? "" : includeStr[0] + "";
            var end = String.IsNullOrWhiteSpace(includeStr) ? "" : includeStr[1] + "";

            return header + string.Join(splitStr.ToString() + (HaveNewLine ? Environment.NewLine : " "),
                data.Select(x => quoteStr + x + quoteStr).ToArray()).TrimEnd(splitStr) + end;
        }
        //01 {...,...,...,}
        //02 option:{},
        //03 ['','','']
        //04 ["","",""]

        //反射
        public static void InitOptionFlag(object obj, Dictionary<string, bool> FlagDic, Dictionary<string, Type> TypeDic)
        {
            Type t = obj.GetType();//typeof(EChartsNet.Option.Title);
            //获取所有属性 
            System.Reflection.PropertyInfo[] properties = t.GetProperties();
            foreach (System.Reflection.PropertyInfo property in properties)
            {
                TypeDic.Add(property.Name, property.PropertyType);
                FlagDic.Add(property.Name, false);
            }

        }
        public static string GetPropertyValue(object obj, string FieldName)
        {
            try
            {
                Type Ts = obj.GetType();
                object o = Ts.GetProperty(FieldName).GetValue(obj, null);
                //panduanleixing
                string Value = Convert.ToString(o);
                if (string.IsNullOrEmpty(Value)) return null;
                return Value;
            }
            catch
            {
                return null;
            }
        }

        public static string GetOptionValue(object obj, Dictionary<string, bool> FlagDic, Dictionary<string, Type> TypeDic, string includeStr = "{}", string defaultStr = "{}")
        {
            List<string> list = null;
            foreach (var di in FlagDic)
            {
                if (di.Value)
                {
                    var type = TypeDic[di.Key];
                    if (list == null) list = new List<string>();

                    list.Add(di.Key + ":" +
                        (type.IsEnum ? GetEnumPro(obj.GetType().GetProperty(di.Key).PropertyType, Common.GetPropertyValue(obj, di.Key))
                        : Common.GetPropertyValue(obj, di.Key)));
                }
            }
            return (list == null || list.Count <= 0) ? defaultStr : Join(list.ToArray(), "", ',', includeStr, true);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable">数据源表</param>
        /// <param name="categoryCol">标签列-X轴对应列</param>
        public static string GetDataSetSource(DataTable dataTable, int categoryCol)
        {
            string[] data = new string[dataTable.Rows.Count + 1];
            string[] header = new string[dataTable.Columns.Count];
            header[0] = dataTable.Columns[categoryCol].ColumnName;
            for (int i = 0, cou = 1; i < dataTable.Columns.Count; i++)
            {
                if (i != categoryCol)
                {
                    header[cou] = dataTable.Columns[i].ColumnName;
                    cou++;
                }
            }
            data[0] = Common.Join(header);
            int rowCou = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                string[] rowData = new string[dataTable.Columns.Count];
                rowData[0] = row[categoryCol].ToString();
                for (int i = 0, cou = 1; i < dataTable.Columns.Count; i++)
                {
                    if (i != categoryCol)
                    {
                        rowData[cou] = row[i].ToString();
                        cou++;
                    }
                }
                data[rowCou] = Common.Join(rowData);
                rowCou++;
            }

            return Common.Join(data, "", ',', "[]", true);
        }
    }
}
