using EChartsNet.Option.SeriesType.SeriesBaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType.LineBaseOption
{
    public class MarkArea : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public MarkArea()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
        public bool silent { get { return _silent; } set { FlagDic["silent"] = true; _silent = value; } }
        public Label label { get { return _label; } set { FlagDic["label"] = true; _label = value; } }
        public ItemStyle itemStyle { get { return _itemStyle; } set { FlagDic["itemStyle"] = true; _itemStyle = value; } }
        public Emphasis emphasis { get { return _emphasis; } set { FlagDic["emphasis"] = true; _emphasis = value; } }
        public MarkAreaData data { get { return _data; } set { FlagDic["data"] = true; _data = value; } }
        public bool animation { get { return _animation; } set { FlagDic["animation"] = true; _animation = value; } }
        public int animationThreshold { get { return _animationThreshold; } set { FlagDic["animationThreshold"] = true; _animationThreshold = value; } }
        public int animationDuration { get { return _animationDuration; } set { FlagDic["animationDuration"] = true; _animationDuration = value; } }
        public string animationEasing { get { return _animationEasing; } set { FlagDic["animationEasing"] = true; _animationEasing = value; } }
        public string animationDelay { get { return _animationDelay; } set { FlagDic["animationDelay"] = true; _animationDelay = value; } }
        public int animationDurationUpdate { get { return _animationDurationUpdate; } set { FlagDic["animationDurationUpdate"] = true; _animationDurationUpdate = value; } }
        public string animationEasingUpdate { get { return _animationEasingUpdate; } set { FlagDic["animationEasingUpdate"] = true; _animationEasingUpdate = value; } }
        public string animationDelayUpdate { get { return _animationDelayUpdate; } set { FlagDic["animationDelayUpdate"] = true; _animationDelayUpdate = value; } }

        bool _silent;
        Label _label;
        ItemStyle _itemStyle;
        Emphasis _emphasis;
        MarkAreaData _data;
        bool _animation;
        int _animationThreshold;
        int _animationDuration;
        string _animationEasing;
        string _animationDelay;
        int _animationDurationUpdate;
        string _animationEasingUpdate;
        string _animationDelayUpdate;
    }
}
