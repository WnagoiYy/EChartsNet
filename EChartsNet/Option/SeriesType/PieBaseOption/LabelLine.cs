using EChartsNet.Option.SeriesType.LineBaseOption;
using EChartsNet.Option.SeriesType.SeriesBaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType.PieBaseOption
{
    public class LabelLine : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public LabelLine()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
        public bool show { get { return _show; } set { FlagDic["show"] = true; _show = value; } }
        public int length { get { return _length; } set { FlagDic["length"] = true; _length = value; } }
        public int length2 { get { return _length2; } set { FlagDic["length2"] = true; _length2 = value; } }
        public string smooth { get { return _smooth; } set { FlagDic["smooth"] = true; _smooth = value; } }
        public LineStyle lineStyle { get { return _lineStyle; } set { FlagDic["lineStyle"] = true; _lineStyle = value; } }
        public Emphasis emphasis { get { return _emphasis; } set { FlagDic["emphasis"] = true; _emphasis = value; } }

        bool _show;
        int _length;
        int _length2;
        string _smooth;
        LineStyle _lineStyle;
        Emphasis _emphasis;
    }
}
