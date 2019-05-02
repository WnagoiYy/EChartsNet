using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType.RadarBaseOption
{
    public class RadarData : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public RadarData()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
    }
}
