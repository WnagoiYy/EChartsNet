using EChartsNet.Option.SeriesType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option
{
    public class Series : BaseEOption
    {
        public override string ToString()
        {
            List<string> list = new List<string>();
            foreach(var str in seriesType)
            {
                list.Add(str);
            }
            foreach (var di in FlagDic)
            {
                if (di.Value)
                {
                    var type = TypeDic[di.Key];
                    list.Add(di.Key + ":" +
                        (type.IsEnum ? Common.GetEnumPro(this.GetType().GetProperty(di.Key).PropertyType, Common.GetPropertyValue(this, di.Key))
                        : Common.GetPropertyValue(this, di.Key)));
                }
            }
            return (list == null || list.Count <= 0) ? "[]" : Common.Join(list.ToArray(), "", ',', "[]", true);
            //return Common.GetOptionValue(this, this.FlagDic, this.TypeDic, "[]", "["+ seriesType + "]");
        }
        public Series(ISeries[] series)
        {
            string[] str = new string[series.Length];
            for(int i = 0; i < series.Length; i++)
            {
                str[i] = series[i].GetTypeStr();
            }
            seriesType = str;// Common.Join(str,"",',',"",true);
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }

        string[] seriesType;
    }
}
