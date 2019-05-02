using EChartsNet.Option.BaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option
{
    /// <summary>
    /// 图例组件展现了不同系列的标记(symbol)，颜色和名字。可以通过点击图例控制哪些系列不显示。
    /// ECharts 3 中单个 echarts 实例中可以存在多个图例组件，会方便多个图例的布局。
    /// 当图例数量过多时，可以使用 滚动图例（垂直） 或 滚动图例（水平），参见：legend.type
    /// </summary>
    public class Legend : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public Legend()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }

       
        public LegendType type { get { return _type; } set { FlagDic["type"] = true; _type = value; } }
        public string id { get { return _id; } set { FlagDic["id"] = true; _id = value; } }
        public bool show { get { return _show; } set { FlagDic["show"] = true; _show = value; } }
        public int zlevel { get { return _zlevel; } set { FlagDic["zlevel"] = true; _zlevel = value; } }
        public int z { get { return _z; } set { FlagDic["z"] = true; _z = value; } }
        public string left { get { return _left; } set { FlagDic["left"] = true; _left = value; } }
        public string top { get { return _top; } set { FlagDic["top"] = true; _top = value; } }
        public string right { get { return _right; } set { FlagDic["right"] = true; _right = value; } }
        public string bottom { get { return _bottom; } set { FlagDic["bottom"] = true; _bottom = value; } }
        public string width { get { return _width; } set { FlagDic["width"] = true; _width = value; } }
        public string height { get { return _height; } set { FlagDic["height"] = true; _height = value; } }
        public Orient orient { get { return _orient; } set { FlagDic["orient"] = true; _orient = value; } }
        public TextAlign align { get { return _align; } set { FlagDic["align"] = true; _align = value; } }
        public string padding { get { return _padding; } set { FlagDic["padding"] = true; _padding = value; } }
        public int itemGap { get { return _itemGap; } set { FlagDic["itemGap"] = true; _itemGap = value; } }
        public int itemWidth { get { return _itemWidth; } set { FlagDic["itemWidth"] = true; _itemWidth = value; } }
        public int itemHeight { get { return _itemHeight; } set { FlagDic["itemHeight"] = true; _itemHeight = value; } }
        public bool symbolKeepAspect { get { return _symbolKeepAspect; } set { FlagDic["symbolKeepAspect"] = true; _symbolKeepAspect = value; } }
        public string formatter { get { return _formatter; } set { FlagDic["formatter"] = true; _formatter = value; } }
        public bool selectedMode { get { return _selectedMode; } set { FlagDic["selectedMode"] = true; _selectedMode = value; } }
        public string inactiveColor { get { return _inactiveColor; } set { FlagDic["inactiveColor"] = true; _inactiveColor = value; } }
        public string selected { get { return _selected; } set { FlagDic["selected"] = true; _selected = value; } }
        public TextStyle textStyle { get { return _textStyle; } set { FlagDic["textStyle"] = true; _textStyle = value; } }
        public string tooltip { get { return _tooltip; } set { FlagDic["tooltip"] = true; _tooltip = value; } }
        public string data { get { return _data; } set { FlagDic["data"] = true; _data = value; } }
        public string backgroundColor { get { return _backgroundColor; } set { FlagDic["backgroundColor"] = true; _backgroundColor = value; } }
        public string borderColor { get { return _borderColor; } set { FlagDic["borderColor"] = true; _borderColor = value; } }
        public int borderWidth { get { return _borderWidth; } set { FlagDic["borderWidth"] = true; _borderWidth = value; } }
        public string borderRadius { get { return _borderRadius; } set { FlagDic["borderRadius"] = true; _borderRadius = value; } }
        public int shadowBlur { get { return _shadowBlur; } set { FlagDic["shadowBlur"] = true; _shadowBlur = value; } }
        public string shadowColor { get { return _shadowColor; } set { FlagDic["shadowColor"] = true; _shadowColor = value; } }
        public int shadowOffsetX { get { return _shadowOffsetX; } set { FlagDic["shadowOffsetX"] = true; _shadowOffsetX = value; } }
        public int shadowOffsetY { get { return _shadowOffsetY; } set { FlagDic["shadowOffsetY"] = true; _shadowOffsetY = value; } }
        public int scrollDataIndex { get { return _scrollDataIndex; } set { FlagDic["scrollDataIndex"] = true; _scrollDataIndex = value; } }
        
        
        //当使用 'scroll' 时，这些使用这些设置进行细节配置：

        public int pageButtonItemGap { get { return _pageButtonItemGap; } set { FlagDic["pageButtonItemGap"] = true; _pageButtonItemGap = value; } }
        public int pageButtonGap { get { return _pageButtonGap; } set { FlagDic["pageButtonGap"] = true; _pageButtonGap = value; } }
        public string pageButtonPosition { get { return _pageButtonPosition; } set { FlagDic["pageButtonPosition"] = true; _pageButtonPosition = value; } }
        public string pageFormatter { get { return _pageFormatter; } set { FlagDic["pageFormatter"] = true; _pageFormatter = value; } }
        public string pageIcons { get { return _pageIcons; } set { FlagDic["pageIcons"] = true; _pageIcons = value; } }
        public string pageIconColor { get { return _pageIconColor; } set { FlagDic["pageIconColor"] = true; _pageIconColor = value; } }
        public string pageIconInactiveColor { get { return _pageIconInactiveColor; } set { FlagDic["pageIconInactiveColor"] = true; _pageIconInactiveColor = value; } }
        public string pageIconSize { get { return _pageIconSize; } set { FlagDic["pageIconSize"] = true; _pageIconSize = value; } }
        public SubtextStyle pageTextStyle { get { return _pageTextStyle; } set { FlagDic["pageTextStyle"] = true; _pageTextStyle = value; } }
        public bool animation { get { return _animation; } set { FlagDic["animation"] = true; _animation = value; } }
        public int animationDurationUpdate { get { return _animationDurationUpdate; } set { FlagDic["animationDurationUpdate"] = true; _animationDurationUpdate = value; } }

        LegendType _type;
        string _id;
        bool _show;
        int _zlevel;
        int _z;
        string _left;
        string _top;
        string _right;
        string _bottom;
        string _width;
        string _height;
        Orient _orient;
        TextAlign _align;
        string _padding;
        int _itemGap;
        int _itemWidth;
        int _itemHeight;
        bool _symbolKeepAspect;
        string _formatter;
        bool _selectedMode;
        string _inactiveColor;
        string _selected;
        TextStyle _textStyle;
        string _tooltip;
        string _data;
        string _backgroundColor;
        string _borderColor;
        int _borderWidth;
        string _borderRadius;
        int _shadowBlur;
        string _shadowColor;
        int _shadowOffsetX;
        int _shadowOffsetY;
        int _scrollDataIndex;
        int _pageButtonItemGap;
        int _pageButtonGap;
        string _pageButtonPosition;
        string _pageFormatter;
        string _pageIcons;
        string _pageIconColor;
        string _pageIconInactiveColor;
        string _pageIconSize;
        SubtextStyle _pageTextStyle;
        bool _animation;
        int _animationDurationUpdate;
        
    }
}
