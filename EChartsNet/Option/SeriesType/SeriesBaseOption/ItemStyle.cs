using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType.SeriesBaseOption
{
    public class ItemStyle : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public ItemStyle()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
        public string color { get { return _color; } set { FlagDic["color"] = true; _color = value; } }
        public string borderColor { get { return _borderColor; } set { FlagDic["borderColor"] = true; _borderColor = value; } }
        public int borderWidth { get { return _borderWidth; } set { FlagDic["borderWidth"] = true; _borderWidth = value; } }
        public string borderType { get { return _borderType; } set { FlagDic["borderType"] = true; _borderType = value; } }
        public string barBorderRadius { get { return _barBorderRadius; } set { FlagDic["barBorderRadius"] = true; _barBorderRadius = value; } }
        public int shadowBlur { get { return _shadowBlur; } set { FlagDic["shadowBlur"] = true; _shadowBlur = value; } }
        public string shadowColor { get { return _shadowColor; } set { FlagDic["shadowColor"] = true; _shadowColor = value; } }
        public int shadowOffsetX { get { return _shadowOffsetX; } set { FlagDic["shadowOffsetX"] = true; _shadowOffsetX = value; } }
        public int shadowOffsetY { get { return _shadowOffsetY; } set { FlagDic["shadowOffsetY"] = true; _shadowOffsetY = value; } }
        public double opcity { get { return _opcity; } set { FlagDic["opcity"] = true; _opcity = value; } }

        string _color;
        string _borderColor;
        int _borderWidth;
        string _borderType;
        string _barBorderRadius;
        int _shadowBlur;
        string _shadowColor;
        int _shadowOffsetX;
        int _shadowOffsetY;
        double _opcity;

    }
}
