using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType.ScatterBaseOption
{
    public class ScatterData : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public ScatterData()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
    }
}
