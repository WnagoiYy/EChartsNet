using EChartsNet.Option.SeriesType.BarBaseOption;
using EChartsNet.Option.SeriesType.LineBaseOption;
using EChartsNet.Option.SeriesType.SeriesBaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType
{
    public class SeriesBar : BaseEOption , ISeries
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic,"{}","{type:'bar'}");
        }
        public string GetTypeStr()
        {
            return this.ToString();
        }
        public SeriesBar()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
            type = "'bar'";

        }
        public string type { get { return _type; } set { FlagDic["type"] = true; _type = value; } }
        public string id { get { return _id; } set { FlagDic["id"] = true; _id = value; } }
        public string name { get { return _name; } set { FlagDic["name"] = true; _name = value; } }
        public CoordinateSystem coordinateSystem { get { return _coordinateSystem; } set { FlagDic["coordinateSystem"] = true; _coordinateSystem = value; } }
        public int xAxisIndex { get { return _xAxisIndex; } set { FlagDic["xAxisIndex"] = true; _xAxisIndex = value; } }
        public int yAxisIndex { get { return _yAxisIndex; } set { FlagDic["yAxisIndex"] = true; _yAxisIndex = value; } }
        public Label label { get { return _label; } set { FlagDic["label"] = true; _label = value; } }
        public ItemStyle itemStyle { get { return _itemStyle; } set { FlagDic["itemStyle"] = true; _itemStyle = value; } }
        public Emphasis emphasis { get { return _emphasis; } set { FlagDic["emphasis"] = true; _emphasis = value; } }
        public string stack { get { return _stack; } set { FlagDic["stack"] = true; _stack = value; } }
        public string cursor { get { return _cursor; } set { FlagDic["cursor"] = true; _cursor = value; } }
        public string barWidth { get { return _barWidth; } set { FlagDic["barWidth"] = true; _barWidth = value; } }
        public string barMaxWidth { get { return _barMaxWidth; } set { FlagDic["barMaxWidth"] = true; _barMaxWidth = value; } }
        public int barMinHeight { get { return _barMinHeight; } set { FlagDic["barMinHeight"] = true; _barMinHeight = value; } }
        public string barGap { get { return _barGap; } set { FlagDic["barGap"] = true; _barGap = value; } }
        public string barCategoryGap { get { return _barCategoryGap; } set { FlagDic["barCategoryGap"] = true; _barCategoryGap = value; } }
        public bool large { get { return _large; } set { FlagDic["large"] = true; _large = value; } }
        public int largeThreshold { get { return _largeThreshold; } set { FlagDic["largeThreshold"] = true; _largeThreshold = value; } }
        public int progressive { get { return _progressive; } set { FlagDic["progressive"] = true; _progressive = value; } }
        public int progressiveThreshold { get { return _progressiveThreshold; } set { FlagDic["progressiveThreshold"] = true; _progressiveThreshold = value; } }
        public string progressiveChunkMode { get { return _progressiveChunkMode; } set { FlagDic["progressiveChunkMode"] = true; _progressiveChunkMode = value; } }

        //..
        public string dimensions { get { return _dimensions; } set { FlagDic["dimensions"] = true; _dimensions = value; } }
        public string encode { get { return _encode; } set { FlagDic["encode"] = true; _encode = value; } }
        public string seriesLayoutBy { get { return _seriesLayoutBy; } set { FlagDic["seriesLayoutBy"] = true; _seriesLayoutBy = value; } }
        public int datasetIndex { get { return _datasetIndex; } set { FlagDic["datasetIndex"] = true; _datasetIndex = value; } }
        public BarData data { get { return _data; } set { FlagDic["data"] = true; _data = value; } }
        public MarkPoint markPoint { get { return _markPoint; } set { FlagDic["markPoint"] = true; _markPoint = value; } }
        public MarkLine markLine { get { return _markLine; } set { FlagDic["markLine"] = true; _markLine = value; } }
        public MarkArea markArea { get { return _markArea; } set { FlagDic["markArea"] = true; _markArea = value; } }

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
        CoordinateSystem _coordinateSystem;
        int _xAxisIndex;
        int _yAxisIndex;
        Label _label;
        ItemStyle _itemStyle;
        Emphasis _emphasis;

        //..
        
        string _stack;
        string _cursor;
        string _barWidth;
        string _barMaxWidth;
        int _barMinHeight;
        string _barGap;
        string _barCategoryGap;
        bool _large;
        int _largeThreshold;
        int _progressive;
        int _progressiveThreshold;
        string _progressiveChunkMode;

        string _dimensions;
        string _encode;
        string _seriesLayoutBy;
        int _datasetIndex;
        BarData _data;
        MarkPoint _markPoint;
        MarkLine _markLine;
        MarkArea _markArea;
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
