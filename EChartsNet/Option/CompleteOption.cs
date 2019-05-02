using EChartsNet.Option.BaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option
{
    public class CompleteOption : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public CompleteOption()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
            
            legend = new Legend();
            tooltip = new Tooltip();
        }
        /// <summary>
        /// [已完成]标题组件，包含主标题和副标题
        /// </summary>
        public Title title { get { return _title; } set { FlagDic["title"] = true; _title = value; } }
        /// <summary>
        /// [已完成]图例组件
        /// </summary>
        public Legend legend { get { return _legend; } set { FlagDic["legend"] = true; _legend = value; } }
        /// <summary>
        /// [已完成]直角坐标系内绘图网格，单个 grid 内最多可以放置上下两个 X 轴，左右两个 Y 轴。
        /// 可以在网格上绘制折线图，柱状图，散点图（气泡图）。
        /// </summary>
        public Grid grid { get { return _grid; } set { FlagDic["grid"] = true; _grid = value; } }
        /// <summary>
        /// 直角坐标系 grid 中的 x 轴，一般单个 grid 最多放上下两个 x 轴
        /// </summary>
        public XAxis xAxis { get { return _xAxis; } set { FlagDic["xAxis"] = true; _xAxis = value; } }
        /// <summary>
        /// 直角坐标系 grid 中的 y 轴，一般情况下单个 grid 组件最多只能放左右两个 y 轴
        /// </summary>
        public YAxis yAxis { get { return _yAxis; } set { FlagDic["yAxis"] = true; _yAxis = value; } }
        /// <summary>
        /// [已完成]极坐标系，可以用于散点图和折线图。每个极坐标系拥有一个角度轴和一个半径轴。
        /// 以下相邻搭配属性未完成
        /// </summary>
        public Polar polar { get { return _polar; } set { FlagDic["polar"] = true; _polar = value; } }
        public string radiusAxis { get { return _radiusAxis; } set { FlagDic["radiusAxis"] = true; _radiusAxis = value; } }
        public string angleAxis { get { return _angleAxis; } set { FlagDic["angleAxis"] = true; _angleAxis = value; } }
        public string radar { get { return _radar; } set { FlagDic["radar"] = true; _radar = value; } }
        public string dataZoom { get { return _dataZoom; } set { FlagDic["dataZoom"] = true; _dataZoom = value; } }
        public string visualMap { get { return _visualMap; } set { FlagDic["visualMap"] = true; _visualMap = value; } }
        /// <summary>
        /// [已完成] 提示框组件。
        /// </summary>
        public Tooltip tooltip { get { return _tooltip; } set { FlagDic["tooltip"] = true; _tooltip = value; } }
        public string axisPointer { get { return _axisPointer; } set { FlagDic["axisPointer"] = true; _axisPointer = value; } }
        /// <summary>
        /// [已完成] 工具栏。内置有导出图片，数据视图，动态类型切换，数据区域缩放，重置五个工具
        /// </summary>
        public ToolBox toolbox { get { return _toolbox; } set { FlagDic["toolbox"] = true; _toolbox = value; } }
        public string brush { get { return _brush; } set { FlagDic["brush"] = true; _brush = value; } }
        public string geo { get { return _geo; } set { FlagDic["geo"] = true; _geo = value; } }
        public string parallel { get { return _parallel; } set { FlagDic["parallel"] = true; _parallel = value; } }
        public string parallelAxis { get { return _parallelAxis; } set { FlagDic["parallelAxis"] = true; _parallelAxis = value; } }
        public string singleAxis { get { return _singleAxis; } set { FlagDic["singleAxis"] = true; _singleAxis = value; } }
        public string timeline { get { return _timeline; } set { FlagDic["timeline"] = true; _timeline = value; } }
        public string graphic { get { return _graphic; } set { FlagDic["graphic"] = true; _graphic = value; } }
        public string calendar { get { return _calendar; } set { FlagDic["calendar"] = true; _calendar = value; } }
        /// <summary>
        /// 数据集（dataset）组件用于单独的数据集声明
        /// 教程：https://echarts.baidu.com/tutorial.html#%E4%BD%BF%E7%94%A8%20dataset%20%E7%AE%A1%E7%90%86%E6%95%B0%E6%8D%AE
        /// </summary>
        public DataSetSource dataset { get { return _dataset; } set { FlagDic["dataset"] = true; _dataset = value; } }
        /// <summary>
        /// [不支持]无障碍富互联网应用规范集
        /// </summary>
        public string aria { get { return _aria; } set { FlagDic["aria"] = true; _aria = value; } }
        /// <summary>
        /// [支持line、pie、bar]系列列表。每个系列通过 type 决定自己的图表类型
        /// </summary>
        public Series series { get { return _series; } set { FlagDic["series"] = true; _series = value; } }
        /// <summary>
        /// [已完成]调色盘颜色列表。如果系列没有设置颜色，则会依次循环从该列表中取颜色作为系列颜色
        /// 默认：['#c23531','#2f4554', '#61a0a8', '#d48265', '#91c7ae','#749f83',  '#ca8622', '#bda29a','#6e7074', '#546570', '#c4ccd3']
        /// </summary>
        public string color { get { return _color; } set { FlagDic["color"] = true; _color = value; } }
        /// <summary>
        /// [已完成]背景色，默认无背景。
        /// </summary>
        public string backgroundColor { get { return _backgroundColor; } set { FlagDic["backgroundColor"] = true; _backgroundColor = value; } }
        /// <summary>
        /// [已完成]全局的字体样式
        /// </summary>
        public TextStyle textStyle { get { return _textStyle; } set { FlagDic["textStyle"] = true; _textStyle = value; } }
        /// <summary>
        /// [已完成]是否开启动画。
        /// </summary>
        public bool animation { get { return _animation; } set { FlagDic["animation"] = true; _animation = value; } }
        public string animationThreshold { get { return _animationThreshold; } set { FlagDic["animationThreshold"] = true; _animationThreshold = value; } }
        public string animationDuration { get { return _animationDuration; } set { FlagDic["animationDuration"] = true; _animationDuration = value; } }
        public string animationEasing { get { return _animationEasing; } set { FlagDic["animationEasing"] = true; _animationEasing = value; } }
        public string animationDelay { get { return _animationDelay; } set { FlagDic["animationDelay"] = true; _animationDelay = value; } }
        public string animationDurationUpdate { get { return _animationDurationUpdate; } set { FlagDic["animationDurationUpdate"] = true; _animationDurationUpdate = value; } }
        public string animationEasingUpdate { get { return _animationEasingUpdate; } set { FlagDic["animationEasingUpdate"] = true; _animationEasingUpdate = value; } }
        public string animationDelayUpdate { get { return _animationDelayUpdate; } set { FlagDic["animationDelayUpdate"] = true; _animationDelayUpdate = value; } }
        public string blendMode { get { return _blendMode; } set { FlagDic["blendMode"] = true; _blendMode = value; } }
        public string hoverLayerThreshold { get { return _hoverLayerThreshold; } set { FlagDic["hoverLayerThreshold"] = true; _hoverLayerThreshold = value; } }
        public bool useUTC { get { return _useUTC; } set { FlagDic["useUTC"] = true; _useUTC = value; } }

        Title _title;
        Legend _legend;
        Grid _grid;
        XAxis _xAxis;
        YAxis _yAxis;
        Polar _polar;
        string _radiusAxis;
        string _angleAxis;
        string _radar;
        string _dataZoom;
        string _visualMap;
        Tooltip _tooltip;
        string _axisPointer;
        ToolBox _toolbox;
        string _brush;
        string _geo;
        string _parallel;
        string _parallelAxis;
        string _singleAxis;
        string _timeline;
        string _graphic;
        string _calendar;
        DataSetSource _dataset;
        string _aria;
        Series _series;
        string _color;
        string _backgroundColor;
        TextStyle _textStyle;
        bool _animation;
        string _animationThreshold;
        string _animationDuration;
        string _animationEasing;
        string _animationDelay;
        string _animationDurationUpdate;
        string _animationEasingUpdate;
        string _animationDelayUpdate;
        string _blendMode;
        string _hoverLayerThreshold;
        bool _useUTC;


    }
}
