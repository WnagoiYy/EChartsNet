using EChartsNet.Option.SeriesType.LineBaseOption;
using EChartsNet.Option.SeriesType.RadarBaseOption;
using EChartsNet.Option.SeriesType.SeriesBaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType
{
    public class SeriesRadar : BaseEOption, ISeries
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic, "{}", "{type:'radar'}");
        }
        public string GetTypeStr()
        {
            return this.ToString();
        }
        public SeriesRadar()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
            type = "'radar'";
        }
        public string type { get { return _type; } set { FlagDic["type"] = true; _type = value; } }
        public string id { get { return _id; } set { FlagDic["id"] = true; _id = value; } }
        public string name { get { return _name; } set { FlagDic["name"] = true; _name = value; } }
        public int radarIndex { get { return _radarIndex; } set { FlagDic["radarIndex"] = true; _radarIndex = value; } }
        public string symbol { get { return _symbol; } set { FlagDic["symbol"] = true; _symbol = value; } }
        public string symbolSize { get { return _symbolSize; } set { FlagDic["symbolSize"] = true; _symbolSize = value; } }
        public int symbolRotate { get { return _symbolRotate; } set { FlagDic["symbolRotate"] = true; _symbolRotate = value; } }
        public bool symbolKeepAspect { get { return _symbolKeepAspect; } set { FlagDic["symbolKeepAspect"] = true; _symbolKeepAspect = value; } }
        public string symbolOffset { get { return _symbolOffset; } set { FlagDic["symbolOffset"] = true; _symbolOffset = value; } }
        public Label label { get { return _label; } set { FlagDic["label"] = true; _label = value; } }
        public ItemStyle itemStyle { get { return _itemStyle; } set { FlagDic["itemStyle"] = true; _itemStyle = value; } }
        public LineStyle lineStyle { get { return _lineStyle; } set { FlagDic["lineStyle"] = true; _lineStyle = value; } }
        public AreaStyle areaStyle { get { return _areaStyle; } set { FlagDic["areaStyle"] = true; _areaStyle = value; } }
        public Emphasis emphasis { get { return _emphasis; } set { FlagDic["emphasis"] = true; _emphasis = value; } }
        public RadarData data { get { return _data; } set { FlagDic["data"] = true; _data = value; } }
        public int zlevel { get { return _zlevel; } set { FlagDic["zlevel"] = true; _zlevel = value; } }
        public int z { get { return _z; } set { FlagDic["z"] = true; _z = value; } }
        public bool silent { get { return _silent; } set { FlagDic["silent"] = true; _silent = value; } }
        public bool animation { get { return _animation; } set { FlagDic["animation"] = true; _animation = value; } }
        public int animationThreshold { get { return _animationThreshold; } set { FlagDic["animationThreshold"] = true; _animationThreshold = value; } }
        public int animationDuration { get { return _animationDuration; } set { FlagDic["animationDuration"] = true; _animationDuration = value; } }
        public string animationEasing { get { return _animationEasing; } set { FlagDic["animationEasing"] = true; _animationEasing = value; } }
        public string animationDelay { get { return _animationDelay; } set { FlagDic["animationDelay"] = true; _animationDelay = value; } }
        public int animationDurationUpdate { get { return _animationDurationUpdate; } set { FlagDic["animationDurationUpdate"] = true; _animationDurationUpdate = value; } }
        public string animationEasingUpdate { get { return _animationEasingUpdate; } set { FlagDic["animationEasingUpdate"] = true; _animationEasingUpdate = value; } }
        public string animationDelayUpdate { get { return _animationDelayUpdate; } set { FlagDic["animationDelayUpdate"] = true; _animationDelayUpdate = value; } }
        public Tooltip tooltip { get { return _tooltip; } set { FlagDic["tooltip"] = true; _tooltip = value; } }


        string _type;
        string _id;
        string _name;
        int _radarIndex;
        string _symbol;
        string _symbolSize;
        int _symbolRotate;
        bool _symbolKeepAspect;
        string _symbolOffset;
        Label _label;
        ItemStyle _itemStyle;
        LineStyle _lineStyle;
        AreaStyle _areaStyle;
        Emphasis _emphasis;
        RadarData _data;
        int _zlevel;
        int _z;
        bool _silent;
        bool _animation;
        int _animationThreshold;
        int _animationDuration;
        string _animationEasing;
        string _animationDelay;
        int _animationDurationUpdate;
        string _animationEasingUpdate;
        string _animationDelayUpdate;
        Tooltip _tooltip;
    }
}
