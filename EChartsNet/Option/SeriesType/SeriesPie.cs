using EChartsNet.Option.SeriesType.LineBaseOption;
using EChartsNet.Option.SeriesType.PieBaseOption;
using EChartsNet.Option.SeriesType.SeriesBaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType
{
    public class SeriesPie : BaseEOption, ISeries
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic, "{}", "{type:'pie'}");
        }
        public string GetTypeStr()
        {
            return this.ToString();
        }
        public SeriesPie()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
            type = "'pie'";
        }
        public string type { get { return _type; } set { FlagDic["type"] = true; _type = value; } }
        public string id { get { return _id; } set { FlagDic["id"] = true; _id = value; } }
        public string name { get { return _name; } set { FlagDic["name"] = true; _name = value; } }
        public bool legendHoverLink { get { return _legendHoverLink; } set { FlagDic["legendHoverLink"] = true; _legendHoverLink = value; } }
        public bool hoverAnimation { get { return _hoverAnimation; } set { FlagDic["hoverAnimation"] = true; _hoverAnimation = value; } }
        public int hoverOffset { get { return _hoverOffset; } set { FlagDic["hoverOffset"] = true; _hoverOffset = value; } }
        public string selectedMode { get { return _selectedMode; } set { FlagDic["selectedMode"] = true; _selectedMode = value; } }
        public int selectedOffset { get { return _selectedOffset; } set { FlagDic["selectedOffset"] = true; _selectedOffset = value; } }
        public bool clockwise { get { return _clockwise; } set { FlagDic["clockwise"] = true; _clockwise = value; } }
        public int startAngle { get { return _startAngle; } set { FlagDic["startAngle"] = true; _startAngle = value; } }
        public int minAngle { get { return _minAngle; } set { FlagDic["minAngle"] = true; _minAngle = value; } }
        public string minShowLabelAngle { get { return _minShowLabelAngle; } set { FlagDic["minShowLabelAngle"] = true; _minShowLabelAngle = value; } }
        public string roseType { get { return _roseType; } set { FlagDic["roseType"] = true; _roseType = value; } }
        public bool avoidLabelOverlap { get { return _avoidLabelOverlap; } set { FlagDic["avoidLabelOverlap"] = true; _avoidLabelOverlap = value; } }
        public bool stillShowZeroSum { get { return _stillShowZeroSum; } set { FlagDic["stillShowZeroSum"] = true; _stillShowZeroSum = value; } }
        public string cursor { get { return _cursor; } set { FlagDic["cursor"] = true; _cursor = value; } }
        public Label label { get { return _label; } set { FlagDic["label"] = true; _label = value; } }
        public LabelLine labelLine { get { return _labelLine; } set { FlagDic["labelLine"] = true; _labelLine = value; } }
        public ItemStyle itemStyle { get { return _itemStyle; } set { FlagDic["itemStyle"] = true; _itemStyle = value; } }
        public Emphasis emphasis { get { return _emphasis; } set { FlagDic["emphasis"] = true; _emphasis = value; } }
        public int zlevel { get { return _zlevel; } set { FlagDic["zlevel"] = true; _zlevel = value; } }
        public int z { get { return _z; } set { FlagDic["z"] = true; _z = value; } }
        public string center { get { return _center; } set { FlagDic["center"] = true; _center = value; } }
        public string radius { get { return _radius; } set { FlagDic["radius"] = true; _radius = value; } }
        public string seriesLayoutBy { get { return _seriesLayoutBy; } set { FlagDic["seriesLayoutBy"] = true; _seriesLayoutBy = value; } }
        public int datasetIndex { get { return _datasetIndex; } set { FlagDic["datasetIndex"] = true; _datasetIndex = value; } }
        public PieData data { get { return _data; } set { FlagDic["data"] = true; _data = value; } }
        public MarkPoint markPoint { get { return _markPoint; } set { FlagDic["markPoint"] = true; _markPoint = value; } }
        public MarkLine markLine { get { return _markLine; } set { FlagDic["markLine"] = true; _markLine = value; } }
        public MarkArea markArea { get { return _markArea; } set { FlagDic["markArea"] = true; _markArea = value; } }

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
        bool _legendHoverLink;
        bool _hoverAnimation;
        int _hoverOffset;
        string _selectedMode;
        int _selectedOffset;
        bool _clockwise;
        int _startAngle;
        int _minAngle;
        string _minShowLabelAngle;
        string _roseType;
        bool _avoidLabelOverlap;
        bool _stillShowZeroSum;
        string _cursor;
        Label _label;
        ItemStyle _itemStyle;
        LabelLine _labelLine;
        Emphasis _emphasis;
        int _zlevel;
        int _z;
        string _center;
        string _radius;
        string _seriesLayoutBy;
        int _datasetIndex;
        PieData _data;
        MarkPoint _markPoint;
        MarkLine _markLine;
        MarkArea _markArea;
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
