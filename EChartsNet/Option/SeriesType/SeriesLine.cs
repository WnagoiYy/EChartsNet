using EChartsNet.Option.SeriesType.LineBaseOption;
using EChartsNet.Option.SeriesType.SeriesBaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType
{
    class SeriesLine : BaseEOption, ISeries
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic, "{}", "{type:'line'}");
        }
        public string GetTypeStr()
        {
            return this.ToString();
        }
        public SeriesLine()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
            type = "'line'";
        }
        public string type { get { return _type; } set { FlagDic["type"] = true; _type = value; } }
        public string id { get { return _id; } set { FlagDic["id"] = true; _id = value; } }
        public string name { get { return _name; } set { FlagDic["name"] = true; _name = value; } }
        public CoordinateSystem coordinateSystem { get { return _coordinateSystem; } set { FlagDic["coordinateSystem"] = true; _coordinateSystem = value; } }
        public int xAxisIndex { get { return _xAxisIndex; } set { FlagDic["xAxisIndex"] = true; _xAxisIndex = value; } }
        public int yAxisIndex { get { return _yAxisIndex; } set { FlagDic["yAxisIndex"] = true; _yAxisIndex = value; } }
        public int polarIndex { get { return _polarIndex; } set { FlagDic["polarIndex"] = true; _polarIndex = value; } }
        public string symbol { get { return _symbol; } set { FlagDic["symbol"] = true; _symbol = value; } }
        public string symbolSize { get { return _symbolSize; } set { FlagDic["symbolSize"] = true; _symbolSize = value; } }
        public int symbolRotate { get { return _symbolRotate; } set { FlagDic["symbolRotate"] = true; _symbolRotate = value; } }
        public bool symbolKeepAspect { get { return _symbolKeepAspect; } set { FlagDic["symbolKeepAspect"] = true; _symbolKeepAspect = value; } }
        public string symbolOffset { get { return _symbolOffset; } set { FlagDic["symbolOffset"] = true; _symbolOffset = value; } }
        public bool showSymbol { get { return _showSymbol; } set { FlagDic["showSymbol"] = true; _showSymbol = value; } }
        public bool showAllSymbol { get { return _showAllSymbol; } set { FlagDic["showAllSymbol"] = true; _showAllSymbol = value; } }
        public bool hoverAnimation { get { return _hoverAnimation; } set { FlagDic["hoverAnimation"] = true; _hoverAnimation = value; } }
        public bool legendHoverLink { get { return _legendHoverLink; } set { FlagDic["legendHoverLink"] = true; _legendHoverLink = value; } }
        public string stack { get { return _stack; } set { FlagDic["stack"] = true; _stack = value; } }
        public string cursor { get { return _cursor; } set { FlagDic["cursor"] = true; _cursor = value; } }
        public bool connectNulls { get { return _connectNulls; } set { FlagDic["connectNulls"] = true; _connectNulls = value; } }
        public bool clipOverflow { get { return _clipOverflow; } set { FlagDic["clipOverflow"] = true; _clipOverflow = value; } }
        public string step { get { return _step; } set { FlagDic["step"] = true; _step = value; } }
        public Label label { get { return _label; } set { FlagDic["label"] = true; _label = value; } }
        public ItemStyle itemStyle { get { return _itemStyle; } set { FlagDic["itemStyle"] = true; _itemStyle = value; } }
        public LineStyle lineStyle { get { return _lineStyle; } set { FlagDic["lineStyle"] = true; _lineStyle = value; } }
        public AreaStyle areaStyle { get { return _areaStyle; } set { FlagDic["areaStyle"] = true; _areaStyle = value; } }
        public Emphasis emphasis { get { return _emphasis; } set { FlagDic["emphasis"] = true; _emphasis = value; } }
        public string smooth { get { return _smooth; } set { FlagDic["smooth"] = true; _smooth = value; } }
        public LineSampling sampling { get { return _sampling; } set { FlagDic["sampling"] = true; _sampling = value; } }
        public string dimensions { get { return _dimensions; } set { FlagDic["dimensions"] = true; _dimensions = value; } }
        public string encode { get { return _encode; } set { FlagDic["encode"] = true; _encode = value; } }
        public string seriesLayoutBy { get { return _seriesLayoutBy; } set { FlagDic["seriesLayoutBy"] = true; _seriesLayoutBy = value; } }
        public int datasetIndex { get { return _datasetIndex; } set { FlagDic["datasetIndex"] = true; _datasetIndex = value; } }
        public LineData data { get { return _data; } set { FlagDic["data"] = true; _data = value; } }
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
        int _polarIndex;
        string _symbol;
        string _symbolSize;
        int _symbolRotate;
        bool _symbolKeepAspect;
        string _symbolOffset;
        bool _showSymbol;
        bool _showAllSymbol;
        bool _hoverAnimation;
        bool _legendHoverLink;
        string _stack;
        string _cursor;
        bool _connectNulls;
        bool _clipOverflow;
        string _step;
        Label _label;
        ItemStyle _itemStyle;
        LineStyle _lineStyle;
        AreaStyle _areaStyle;
        Emphasis _emphasis;
        string _smooth;
        LineSampling _sampling;
        string _dimensions;
        string _encode;
        string _seriesLayoutBy;
        int _datasetIndex;
        LineData _data;
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
