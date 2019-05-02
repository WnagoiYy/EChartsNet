using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.BaseOption.ToolBoxBaseOption
{
    public class Feature : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public Feature()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
    }
}
