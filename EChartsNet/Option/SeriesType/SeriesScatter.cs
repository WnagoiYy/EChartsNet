using EChartsNet.Option.SeriesType.LineBaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType
{
    public class SeriesScatter : BaseEOption, ISeries
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic, "{}", "{type:'scatter'}");
        }
        public string GetTypeStr()
        {
            return this.ToString();
        }
        public SeriesScatter()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
            type = "'scatter'";
        }

        public string type { get { return _type; } set { FlagDic["type"] = true; _type = value; } }
        public string id { get { return _id; } set { FlagDic["id"] = true; _id = value; } }
        public string name { get { return _name; } set { FlagDic["name"] = true; _name = value; } }
        public CoordinateSystem coordinateSystem { get { return _coordinateSystem; } set { FlagDic["coordinateSystem"] = true; _coordinateSystem = value; } }
        public int xAxisIndex { get { return _xAxisIndex; } set { FlagDic["xAxisIndex"] = true; _xAxisIndex = value; } }
        public int yAxisIndex { get { return _yAxisIndex; } set { FlagDic["yAxisIndex"] = true; _yAxisIndex = value; } }
        public int polarIndex { get { return _polarIndex; } set { FlagDic["polarIndex"] = true; _polarIndex = value; } }
        public int geoIndex { get { return _geoIndex; } set { FlagDic["geoIndex"] = true; _geoIndex = value; } }
        public int calendarIndex { get { return _calendarIndex; } set { FlagDic["calendarIndex"] = true; _calendarIndex = value; } }
        public bool hoverAnimation { get { return _hoverAnimation; } set { FlagDic["hoverAnimation"] = true; _hoverAnimation = value; } }
        public bool legendHoverLink { get { return _legendHoverLink; } set { FlagDic["legendHoverLink"] = true; _legendHoverLink = value; } }
        public string symbol { get { return _symbol; } set { FlagDic["symbol"] = true; _symbol = value; } }
        public string symbolSize { get { return _symbolSize; } set { FlagDic["symbolSize"] = true; _symbolSize = value; } }
        public int symbolRotate { get { return _symbolRotate; } set { FlagDic["symbolRotate"] = true; _symbolRotate = value; } }
        public bool symbolKeepAspect { get { return _symbolKeepAspect; } set { FlagDic["symbolKeepAspect"] = true; _symbolKeepAspect = value; } }
        public string symbolOffset { get { return _symbolOffset; } set { FlagDic["symbolOffset"] = true; _symbolOffset = value; } }
        public bool large { get { return _large; } set { FlagDic["large"] = true; _large = value; } }
        public bool largeThreshold { get { return _largeThreshold; } set { FlagDic["largeThreshold"] = true; _largeThreshold = value; } }
        public string cursor { get { return _cursor; } set { FlagDic["cursor"] = true; _cursor = value; } }
        public int progressive { get { return _progressive; } set { FlagDic["progressive"] = true; _progressive = value; } }
        public int progressiveThreshold { get { return _progressiveThreshold; } set { FlagDic["progressiveThreshold"] = true; _progressiveThreshold = value; } }
        public string dimensions { get { return _dimensions; } set { FlagDic["dimensions"] = true; _dimensions = value; } }
        public string encode { get { return _encode; } set { FlagDic["encode"] = true; _encode = value; } }
        public string seriesLayoutBy { get { return _seriesLayoutBy; } set { FlagDic["seriesLayoutBy"] = true; _seriesLayoutBy = value; } }
        public int datasetIndex { get { return _datasetIndex; } set { FlagDic["datasetIndex"] = true; _datasetIndex = value; } }
        public ScatterBaseOption.ScatterData data { get { return _data; } set { FlagDic["data"] = true; _data = value; } }
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
        int _geoIndex;
        int _calendarIndex;
        bool _hoverAnimation;
        bool _legendHoverLink;
        string _symbol;
        string _symbolSize;
        int _symbolRotate;
        bool _symbolKeepAspect;
        string _symbolOffset;
        bool _large;
        bool _largeThreshold;
        string _cursor;
        int _progressive;
        int _progressiveThreshold;
        string _dimensions;
        string _encode;
        string _seriesLayoutBy;
        int _datasetIndex;
        ScatterBaseOption.ScatterData _data;
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
