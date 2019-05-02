using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType.PieBaseOption
{
    public class PieData : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public PieData()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
    }
}
