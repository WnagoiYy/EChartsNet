using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType.LineBaseOption
{
    public class MarkAreaData : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public MarkAreaData()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
    }
}
