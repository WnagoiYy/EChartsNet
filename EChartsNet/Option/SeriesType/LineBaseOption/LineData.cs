using EChartsNet.Option.SeriesType.SeriesBaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType.LineBaseOption
{
    public class LineData : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public LineData()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
        public string name { get { return _name; } set { FlagDic["name"] = true; _name = value; } }
        public int value { get { return _value; } set { FlagDic["value"] = true; _value = value; } }
        public string symbol { get { return _symbol; } set { FlagDic["symbol"] = true; _symbol = value; } }
        public string symbolSize { get { return _symbolSize; } set { FlagDic["symbolSize"] = true; _symbolSize = value; } }
        public int symbolRotate { get { return _symbolRotate; } set { FlagDic["symbolRotate"] = true; _symbolRotate = value; } }
        public bool symbolKeepAspect { get { return _symbolKeepAspect; } set { FlagDic["symbolKeepAspect"] = true; _symbolKeepAspect = value; } }
        public string symbolOffset { get { return _symbolOffset; } set { FlagDic["symbolOffset"] = true; _symbolOffset = value; } }
        public Label label { get { return _label; } set { FlagDic["label"] = true; _label = value; } }
        public ItemStyle itemStyle { get { return _itemStyle; } set { FlagDic["itemStyle"] = true; _itemStyle = value; } }
        public Emphasis emphasis { get { return _emphasis; } set { FlagDic["emphasis"] = true; _emphasis = value; } }
        public Tooltip tooltip { get { return _tooltip; } set { FlagDic["tooltip"] = true; _tooltip = value; } }

        string _name;
        int _value;
        string _symbol;
        string _symbolSize;
        int _symbolRotate;
        bool _symbolKeepAspect;
        string _symbolOffset;
        Label _label;
        ItemStyle _itemStyle;
        Emphasis _emphasis;
        Tooltip _tooltip;

    }
}
