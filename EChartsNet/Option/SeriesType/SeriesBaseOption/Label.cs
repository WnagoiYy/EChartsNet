using EChartsNet.Option.BaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType.SeriesBaseOption
{
    public class Label : BaseEOption
    {

        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public Label()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }

        public bool show { get { return _show; } set { FlagDic["show"] = true; _show = value; } }
        public Position position { get { return _position; } set { FlagDic["position"] = true; _position = value; } }
        public int distance { get { return _distance; } set { FlagDic["distance"] = true; _distance = value; } }
        public int rotate { get { return _rotate; } set { FlagDic["rotate"] = true; _rotate = value; } }
        public string offset { get { return _offset; } set { FlagDic["offset"] = true; _offset = value; } }
        public string formatter { get { return _formatter; } set { FlagDic["formatter"] = true; _formatter = value; } }
        public string color { get { return _color; } set { FlagDic["color"] = true; _color = value; } }
        public FontStyle fontStyle { get { return _fontStyle; } set { FlagDic["fontStyle"] = true; _fontStyle = value; } }
        public FontWeight fontWeight { get { return _fontWeight; } set { FlagDic["fontWeight"] = true; _fontWeight = value; } }
        public FontFamily fontFamily { get { return _fontFamily; } set { FlagDic["fontFamily"] = true; _fontFamily = value; } }
        public int fontSize { get { return _fontSize; } set { FlagDic["fontSize"] = true; _fontSize = value; } }
        public TextAlign align { get { return _align; } set { FlagDic["align"] = true; _align = value; } }
        public TextVerticalAlign verticalAlign { get { return _verticalAlign; } set { FlagDic["verticalAlign"] = true; _verticalAlign = value; } }
        public int lineHeight { get { return _lineHeight; } set { FlagDic["lineHeight"] = true; _lineHeight = value; } }
        public string backgroundColor { get { return _backgroundColor; } set { FlagDic["backgroundColor"] = true; _backgroundColor = value; } }
        public string borderColor { get { return _borderColor; } set { FlagDic["borderColor"] = true; _borderColor = value; } }
        public int borderWidth { get { return _borderWidth; } set { FlagDic["borderWidth"] = true; _borderWidth = value; } }
        public string borderRadius { get { return _borderRadius; } set { FlagDic["borderRadius"] = true; _borderRadius = value; } }
        public string padding { get { return _padding; } set { FlagDic["padding"] = true; _padding = value; } }
        public string shadowColor { get { return _shadowColor; } set { FlagDic["shadowColor"] = true; _shadowColor = value; } }
        public int shadowBlur { get { return _shadowBlur; } set { FlagDic["shadowBlur"] = true; _shadowBlur = value; } }
        public int shadowOffsetX { get { return _shadowOffsetX; } set { FlagDic["shadowOffsetX"] = true; _shadowOffsetX = value; } }
        public int shadowOffsetY { get { return _shadowOffsetY; } set { FlagDic["shadowOffsetY"] = true; _shadowOffsetY = value; } }
        public string width { get { return _width; } set { FlagDic["width"] = true; _width = value; } }
        public string height { get { return _height; } set { FlagDic["height"] = true; _height = value; } }
        public string textBorderColor { get { return _textBorderColor; } set { FlagDic["textBorderColor"] = true; _textBorderColor = value; } }
        public int textBorderWidth { get { return _textBorderWidth; } set { FlagDic["textBorderWidth"] = true; _textBorderWidth = value; } }
        public string textShadowColor { get { return _textShadowColor; } set { FlagDic["textShadowColor"] = true; _textShadowColor = value; } }
        public int textShadowBlur { get { return _textShadowBlur; } set { FlagDic["textShadowBlur"] = true; _textShadowBlur = value; } }
        public int textShadowOffsetX { get { return _textShadowOffsetX; } set { FlagDic["textShadowOffsetX"] = true; _textShadowOffsetX = value; } }
        public int textShadowOffsetY { get { return _textShadowOffsetY; } set { FlagDic["textShadowOffsetY"] = true; _textShadowOffsetY = value; } }
        public string rich { get { return _rich; } set { FlagDic["rich"] = true; _rich = value; } }

        bool _show;
        Position _position;
        int _distance;
        int _rotate;
        string _offset;
        string _formatter;
        string _color;
        FontStyle _fontStyle;
        FontWeight _fontWeight;
        FontFamily _fontFamily;
        int _fontSize;
        TextAlign _align;
        TextVerticalAlign _verticalAlign;
        int _lineHeight;
        string _backgroundColor;
        string _borderColor;
        int _borderWidth;
        string _borderRadius;
        string _padding;
        string _shadowColor;
        int _shadowBlur;
        int _shadowOffsetX;
        int _shadowOffsetY;
        string _width;
        string _height;
        string _textBorderColor;
        int _textBorderWidth;
        string _textShadowColor;
        int _textShadowBlur;
        int _textShadowOffsetX;
        int _textShadowOffsetY;
        string _rich;

    }
}
