using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option
{
    /// <summary>
    /// 直角坐标系内绘图网格
    /// 单个 grid 内最多可以放置上下两个 X 轴，左右两个 Y 轴
    /// 可以在网格上绘制折线图，柱状图，散点图（气泡图）
    /// </summary>
    public class Grid : BaseEOption
    {

        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public Grid()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
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
        public bool containLabel { get { return _containLabel; } set { FlagDic["containLabel"] = true; _containLabel = value; } }
        public string backgroundColor { get { return _backgroundColor; } set { FlagDic["backgroundColor"] = true; _backgroundColor = value; } }
        public string borderColor { get { return _borderColor; } set { FlagDic["borderColor"] = true; _borderColor = value; } }
        public int borderWidth { get { return _borderWidth; } set { FlagDic["borderWidth"] = true; _borderWidth = value; } }
        public int shadowBlur { get { return _shadowBlur; } set { FlagDic["shadowBlur"] = true; _shadowBlur = value; } }
        public string shadowColor { get { return _shadowColor; } set { FlagDic["shadowColor"] = true; _shadowColor = value; } }
        public int shadowOffsetX { get { return _shadowOffsetX; } set { FlagDic["shadowOffsetX"] = true; _shadowOffsetX = value; } }
        public int shadowOffsetY { get { return _shadowOffsetY; } set { FlagDic["shadowOffsetY"] = true; _shadowOffsetY = value; } }
        public Tooltip tooltip { get { return _tooltip; } set { FlagDic["tooltip"] = true; _tooltip = value; } }

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
        bool _containLabel;
        string _backgroundColor;
        string _borderColor;
        int _borderWidth;
        int _shadowBlur;
        string _shadowColor;
        int _shadowOffsetX;
        int _shadowOffsetY;
        Tooltip _tooltip;

    }
}
