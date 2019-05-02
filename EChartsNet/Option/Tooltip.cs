using EChartsNet.Option.BaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option
{
    public class Tooltip : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public Tooltip()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }

        public bool show { get { return _show; } set { FlagDic["show"] = true; _show = value; } }
        public string trigger { get { return _trigger; } set { FlagDic["trigger"] = true; _trigger = value; } }
        public AxisPointer axisPointer { get { return _axisPointer; } set { FlagDic["axisPointer"] = true; _axisPointer = value; } }
        public bool showContent { get { return _showContent; } set { FlagDic["showContent"] = true; _showContent = value; } }
        public bool alwaysShowContent { get { return _alwaysShowContent; } set { FlagDic["alwaysShowContent"] = true; _alwaysShowContent = value; } }
        public TriggerOn triggerOn { get { return _triggerOn; } set { FlagDic["triggerOn"] = true; _triggerOn = value; } }
        public int showDelay { get { return _showDelay; } set { FlagDic["showDelay"] = true; _showDelay = value; } }
        public int hideDelay { get { return _hideDelay; } set { FlagDic["hideDelay"] = true; _hideDelay = value; } }
        public bool enterable { get { return _enterable; } set { FlagDic["enterable"] = true; _enterable = value; } }
        public string renderMode { get { return _renderMode; } set { FlagDic["renderMode"] = true; _renderMode = value; } }
        public bool confine { get { return _confine; } set { FlagDic["confine"] = true; _confine = value; } }
        public double transitionDuration { get { return _transitionDuration; } set { FlagDic["transitionDuration"] = true; _transitionDuration = value; } }
        public string position { get { return _position; } set { FlagDic["position"] = true; _position = value; } }
        public string formatter { get { return _formatter; } set { FlagDic["formatter"] = true; _formatter = value; } }
        public string backgroundColor { get { return _backgroundColor; } set { FlagDic["backgroundColor"] = true; _backgroundColor = value; } }
        public string borderColor { get { return _borderColor; } set { FlagDic["borderColor"] = true; _borderColor = value; } }
        public int borderWidth { get { return _borderWidth; } set { FlagDic["borderWidth"] = true; _borderWidth = value; } }
        public string padding { get { return _padding; } set { FlagDic["padding"] = true; _padding = value; } }
        public TextStyle textStyle { get { return _textStyle; } set { FlagDic["textStyle"] = true; _textStyle = value; } }
        public string extraCssText { get { return _extraCssText; } set { FlagDic["extraCssText"] = true; _extraCssText = value; } }

        bool _show;
        string _trigger;
        AxisPointer _axisPointer;
        bool _showContent;
        bool _alwaysShowContent;
        TriggerOn _triggerOn;
        int _showDelay;
        int _hideDelay;
        bool _enterable;
        string _renderMode;
        bool _confine;
        double _transitionDuration;
        string _position;
        string _formatter;
        string _backgroundColor;
        string _borderColor;
        int _borderWidth;
        string _padding;
        TextStyle _textStyle;
        string _extraCssText;

    }
}
