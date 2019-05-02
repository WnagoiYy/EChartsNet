using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.BaseOption.ToolBoxBaseOption
{
    public class ToolboxEmphasis : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public ToolboxEmphasis()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
        public IconStyle iconStyle { get { return _iconStyle; } set { FlagDic["iconStyle"] = true; _iconStyle = value; } }
        IconStyle _iconStyle;

    }
}
