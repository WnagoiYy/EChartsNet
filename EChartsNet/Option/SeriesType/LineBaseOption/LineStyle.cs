using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType.LineBaseOption
{
    public class LineStyle : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public LineStyle()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }

        public string color { get { return _color; } set { FlagDic["color"] = true; _color = value; } }
        public int width { get { return _width; } set { FlagDic["width"] = true; _width = value; } }
        public LineStyleType type { get { return _type; } set { FlagDic["type"] = true; _type = value; } }
        public int shadowBlur { get { return _shadowBlur; } set { FlagDic["shadowBlur"] = true; _shadowBlur = value; } }
        public string shadowColor { get { return _shadowColor; } set { FlagDic["shadowColor"] = true; _shadowColor = value; } }
        public int shadowOffsetX { get { return _shadowOffsetX; } set { FlagDic["shadowOffsetX"] = true; _shadowOffsetX = value; } }
        public int shadowOffsetY { get { return _shadowOffsetY; } set { FlagDic["shadowOffsetY"] = true; _shadowOffsetY = value; } }
        public double opacity { get { return _opacity; } set { FlagDic["opacity"] = true; _opacity = value; } }

        string _color;
        int _width;
        LineStyleType _type;
        int _shadowBlur;
        string _shadowColor;
        int _shadowOffsetX;
        int _shadowOffsetY;
        double _opacity;

    }
}
