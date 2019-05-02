using EChartsNet.Option.BaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option
{
    public class TextStyle : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public TextStyle()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }

        public string color { get { return _color; } set { FlagDic["color"] = true; _color = value; } }
        public FontStyle fontStyle { get { return _fontStyle; } set { FlagDic["fontStyle"] = true; _fontStyle = value; } }
        public FontWeight fontWeight { get { return _fontWeight; } set { FlagDic["fontWeight"] = true; _fontWeight = value; } }
        public FontFamily fontFamily { get { return _fontFamily; } set { FlagDic["fontFamily"] = true; _fontFamily = value; } }
        public int fontSize { get { return _fontSize; } set { FlagDic["fontSize"] = true; _fontSize = value; } }
        public int lineHeight { get { return _lineHeight; } set { FlagDic["lineHeight"] = true; _lineHeight = value; } }
        public string width { get { return _width; } set { FlagDic["width"] = true; _width = value; } }
        public string height { get { return _height; } set { FlagDic["height"] = true; _height = value; } }
        public string textBorderColor { get { return _textBorderColor; } set { FlagDic["textBorderColor"] = true; _textBorderColor = value; } }
        public int textBorderWidth { get { return _textBorderWidth; } set { FlagDic["textBorderWidth"] = true; _textBorderWidth = value; } }
        public string textShadowColor { get { return _textShadowColor; } set { FlagDic["textShadowColor"] = true; _textShadowColor = value; } }
        public int textShadowBlur { get { return _textShadowBlur; } set { FlagDic["textShadowBlur"] = true; _textShadowBlur = value; } }
        public int textShadowOffsetX { get { return _textShadowOffsetX; } set { FlagDic["textShadowOffsetX"] = true; _textShadowOffsetX = value; } }
        public int textShadowOffsetY { get { return _textShadowOffsetY; } set { FlagDic["textShadowOffsetY"] = true; _textShadowOffsetY = value; } }

        string _color;
        FontStyle _fontStyle;
        FontWeight _fontWeight;
        FontFamily _fontFamily;
        int _fontSize;
        int _lineHeight;
        string _width;
        string _height;
        string _textBorderColor;
        int _textBorderWidth;
        string _textShadowColor;
        int _textShadowBlur;
        int _textShadowOffsetX;
        int _textShadowOffsetY;
    }
}
