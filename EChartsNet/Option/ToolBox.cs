using EChartsNet.Option.BaseOption.ToolBoxBaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option
{
    public class ToolBox : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public ToolBox()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
        public string id { get { return _id; } set { FlagDic["id"] = true; _id = value; } }
        public bool show { get { return _show; } set { FlagDic["show"] = true; _show = value; } }
        public ToolboxOrient orient { get { return _orient; } set { FlagDic["orient"] = true; _orient = value; } }
        public int itemSize { get { return _itemSize; } set { FlagDic["itemSize"] = true; _itemSize = value; } }
        public int itemGap { get { return _itemGap; } set { FlagDic["itemGap"] = true; _itemGap = value; } }
        public bool showTitle { get { return _showTitle; } set { FlagDic["showTitle"] = true; _showTitle = value; } }
        public Feature feature { get { return _feature; } set { FlagDic["feature"] = true; _feature = value; } }
        public IconStyle iconStyle { get { return _iconStyle; } set { FlagDic["iconStyle"] = true; _iconStyle = value; } }
        public ToolboxEmphasis emphasis { get { return _emphasis; } set { FlagDic["emphasis"] = true; _emphasis = value; } }
        public int zlevel { get { return _zlevel; } set { FlagDic["zlevel"] = true; _zlevel = value; } }
        public int z { get { return _z; } set { FlagDic["z"] = true; _z = value; } }
        public string left { get { return _left; } set { FlagDic["left"] = true; _left = value; } }
        public string top { get { return _top; } set { FlagDic["top"] = true; _top = value; } }
        public string right { get { return _right; } set { FlagDic["right"] = true; _right = value; } }
        public string bottom { get { return _bottom; } set { FlagDic["bottom"] = true; _bottom = value; } }
        public string width { get { return _width; } set { FlagDic["width"] = true; _width = value; } }
        public string height { get { return _height; } set { FlagDic["height"] = true; _height = value; } }

        string _id;
        bool _show;
        ToolboxOrient _orient;
        int _itemSize;
        int _itemGap;
        bool _showTitle;
        Feature _feature;
        IconStyle _iconStyle;
        ToolboxEmphasis _emphasis;
        int _zlevel;
        int _z;
        string _left;
        string _top;
        string _right;
        string _bottom;
        string _width;
        string _height;

    }
}
