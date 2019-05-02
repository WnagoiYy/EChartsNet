using EChartsNet.Option.BaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option
{
    /// <summary>
    /// 标题组件，包含主标题和副标题。
    /// </summary>
    public class Title: BaseEOption
    {
        //01.怎样设置到字符串的转换
        //02.怎样避开未设置的属性不显示
        //03.怎样生成完整的js字符串
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public Title()
        {
            Common.InitOptionFlag(this,FlagDic,TypeDic);
        }
        string _id;
        /// <summary>
        /// 组件 ID。默认不指定。指定则可用于在 option 或者 API 中引用组件。
        /// </summary>
        public string id { get { return _id; } set { FlagDic["id"] = true; _id = value; } }

        bool _show;
        /// <summary>
        /// 是否显示标题组件。[ default: true ]
        /// </summary>
        public bool show { get { return _show; } set { FlagDic["show"] = true; _show = value; } }

        string _text;
        /// <summary>
        /// 主标题文本，支持使用 \n 换行。
        /// </summary>
        public string text { get { return _text; } set { FlagDic["text"] = true; _text = value; } }

        string _link;
        /// <summary>
        /// 主标题文本超链接。[ default: '' ]
        /// </summary>
        public string link { get { return _link; } set { FlagDic["link"] = true; _link = value; } }

        Target _target;
        /// <summary>
        /// 指定窗口打开主标题超链接。[ default: 'blank' ]
        /// </summary>
        public Target target { get { return _target; } set { FlagDic["target"] = true; _target = value; } }

        TextStyle _textStyle;
        /// <summary>
        /// 主标题风格
        /// </summary>
        public TextStyle textStyle { get { return _textStyle; } set { FlagDic["textStyle"] = true; _textStyle = value; } }

        string _subtext;
        /// <summary>
        /// 副标题文本，支持使用 \n 换行
        /// </summary>
        public string subtextget { get { return _subtext; } set { FlagDic["subtextget"] = true; _subtext = value; } }

        string _sublink;
        /// <summary>
        /// 副标题文本超链接。[ default: '' ]
        /// </summary>
        public string sublink { get { return _sublink; } set { FlagDic["sublink"] = true; _sublink = value; } }

        Target _subtarget;
        /// <summary>
        /// 指定窗口打开副标题超链接。[ default: 'blank' ]
        /// </summary>
        public Target subtarget { get { return _subtarget; } set { FlagDic["subtarget"] = true; _subtarget = value; } }

        TextStyle _subtextStyle;
        /// <summary>
        /// 子标题风格
        /// </summary>
        public TextStyle subtextStyle { get { return _subtextStyle; } set { FlagDic["subtextStyle"] = true; _subtextStyle = value; } }

        TextAlign _textAlign;
        /// <summary>
        /// 整体（包括 text 和 subtext）的水平对齐。
        /// </summary>
        public TextAlign textAlign { get { return _textAlign; } set { FlagDic["textAlign"] = true; _textAlign = value; } }

        TextVerticalAlign _textVerticalAlign;
        /// <summary>
        /// 整体（包括 text 和 subtext）的垂直对齐。
        /// </summary>
        public TextVerticalAlign textVerticalAlign { get { return _textVerticalAlign; } set { FlagDic["textVerticalAlign"] = true; _textVerticalAlign = value; } }

        bool _triggerEvent;
        /// <summary>
        /// 是否触发事件。[ default: false ]
        /// </summary>
        public bool triggerEvent { get { return _triggerEvent; } set { FlagDic["triggerEvent"] = true; _triggerEvent = value; } }

        string _padding;
        /// <summary>
        /// 标题内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距。
        /// padding: 5// 设置内边距为 5
        /// padding: [5, 10]//设置上下的内边距为 5，左右的内边距为 10
        /// padding: [ 5, 10,  5, 10,]// 上 右下 左 分别设置四个方向的内边距
        /// </summary>
        public string padding { get { return _padding; } set { FlagDic["padding"] = true; _padding = value; } }

        int _itemGap;
        /// <summary>
        /// 主副标题之间的间距。[ default: 10 ]
        /// </summary>
        public int itemGap { get { return _itemGap; } set { FlagDic["itemGap"] = true; _itemGap = value; } }

        int _zlevel;
        /// <summary>
        /// 所有图形的 zlevel 值。[ default: 0 ]
        /// </summary>
        public int zlevel { get { return _zlevel; } set { FlagDic["zlevel"] = true; _zlevel = value; } }


        int _z;
        /// <summary>
        /// 组件的所有图形的z值。控制图形的前后顺序。z值小的图形会被z值大的图形覆盖。
        /// </summary>
        public int z { get { return _z; } set { FlagDic["z"] = true; _z = value; } }

        string _left;
        /// <summary>
        /// grid 组件离容器左侧的距离。[ default: 'auto' ]
        /// left 的值为'left', 'center', 'right'，组件会根据相应的位置自动对齐。
        /// </summary>
        public string left { get { return _left; } set { FlagDic["left"] = true; _left = value; } }

        string _top;
        /// <summary>
        /// grid 组件离容器上侧的距离。
        /// 如果 top 的值为'top', 'middle', 'bottom'，组件会根据相应的位置自动对齐。
        /// </summary>
        public string top { get { return _top; } set { FlagDic["top"] = true; _top = value; } }

        string _right;
        /// <summary>
        /// grid 组件离容器右侧的距离。默认自适应。
        /// </summary>
        public string right { get { return _right; } set { FlagDic["right"] = true; _right = value; } }

        string _bottom;
        /// <summary>
        /// grid 组件离容器右侧的距离。
        /// right 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        /// 默认自适应。
        /// </summary>
        public string bottom { get { return _bottom; } set { FlagDic["bottom"] = true; _bottom = value; } }

        string _backgroundColor;
        /// <summary>
        /// 标题背景色，默认透明。[ default: 'transparent' ]
        ///  RGB 表示，比如 'rgb(128, 128, 128)'
        ///  alpha 通道，可以使用 RGBA，比如 'rgba(128, 128, 128, 0.5)'
        ///  使用十六进制格式，比如 '#ccc'
        /// </summary>
        public string backgroundColor { get { return _backgroundColor; } set { FlagDic["backgroundColor"] = true; _backgroundColor = value; } }

        string _borderColor;
        /// <summary>
        /// 标题的边框颜色。支持的颜色格式同 backgroundColor。[ default: '#ccc' ]
        /// </summary>
        public string borderColor { get { return _borderColor; } set { FlagDic["borderColor"] = true; _borderColor = value; } }

        int _borderWidth;
        /// <summary>
        /// 标题的边框线宽。[ default: 0 ]
        /// </summary>
        public int borderWidth { get { return _borderWidth; } set { FlagDic["borderWidth"] = true; _borderWidth = value; } }

        string _borderRadius;
        /// <summary>
        /// 圆角半径，单位px，支持传入数组分别指定 4 个圆角半径。 如:
        /// </summary>
        public string borderRadius { get { return _borderRadius; } set { FlagDic["borderRadius"] = true; _borderRadius = value; } }

        int _shadowBlur;
        /// <summary>
        /// 图形阴影的模糊大小。该属性配合 shadowColor,shadowOffsetX, shadowOffsetY 一起设置图形的阴影效果。
        /// </summary>
        public int shadowBlur { get { return _shadowBlur; } set { FlagDic["shadowBlur"] = true; _shadowBlur = value; } }

        string _shadowColor;
        /// <summary>
        /// 阴影颜色。支持的格式同color。
        /// </summary>
        public string shadowColor { get { return _shadowColor; } set { FlagDic["shadowColor"] = true; _shadowColor = value; } }

        string _shadowOffsetX;
        /// <summary>
        /// 阴影水平方向上的偏移距离。[ default: 0 ]
        /// </summary>
        public string shadowOffsetX { get { return _shadowOffsetX; } set { FlagDic["shadowOffsetX"] = true; _shadowOffsetX = value; } }

        string _shadowOffsetY;
        /// <summary>
        /// //阴影垂直方向上的偏移距离。[ default: 0 ]
        /// </summary>
        public string shadowOffsetY { get { return _shadowOffsetY; } set { FlagDic["shadowOffsetY"] = true; _shadowOffsetY = value; } }

    }
}
