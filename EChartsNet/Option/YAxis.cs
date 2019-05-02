using EChartsNet.Option.BaseOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option
{
    /// <summary>
    /// 直角坐标系 grid 中的 y 轴，一般情况下单个 grid 组件最多只能放左右两个 y 轴，
    /// 多于两个 y 轴需要通过配置 offset 属性防止同个位置多个 Y 轴的重叠。
    /// 尚未添加复合属性 ：axisLine 、axisTick、axisLabel、splitLine、splitArea 、data[i]、axisPointer 
    /// </summary>
    public class YAxis : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public YAxis()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
        string _id;
        public string id { get => _id; set { FlagDic["id"] = true; _id = value; } }
        bool _show;
        public bool show { get => _show; set { FlagDic["show"] = true; _show = value; } }
        string _gridIndex;
        public string gridIndex { get => _gridIndex; set { FlagDic["gridIndex"] = true; _gridIndex = value; } }
        Position _position;
        /// <summary>
        /// //y 轴的位置。
        /// </summary>
        public Position position { get => _position; set { FlagDic["position"] = true; _position = value; } }
        int _offset;
        public int offset { get => _offset; set { FlagDic["offset"] = true; _offset = value; } }
        xAxisType _type;
        /// <summary>
        /// 坐标轴类型
        /// 'value' 数值轴，适用于连续数据。
        /// 'category' 类目轴，适用于离散的类目数据，为该类型时必须通过 data 设置类目数据。
        /// 'time' 时间轴，适用于连续的时序数据，与数值轴相比时间轴带有时间的格式化，在刻度计算上也有所不同，例如会根据跨度的范围来决定使用月，星期，日还是小时范围的刻度。
        /// 'log' 对数轴。适用于对数数据。
        /// </summary>
        public xAxisType type { get => _type; set { FlagDic["type"] = true; _type = value; } }
        string _name;
        public string name { get => _name; set { FlagDic["name"] = true; _name = value; } }
        string _nameLocation;
        public string nameLocation { get => _nameLocation; set { FlagDic["nameLocation"] = true; _nameLocation = value; } }
        SubtextStyle _nameTextStyle;
        public SubtextStyle nameTextStyle { get => _nameTextStyle; set { FlagDic["nameTextStyle"] = true; _nameTextStyle = value; } }
        int _nameGap;
        public int nameGap { get => _nameGap; set { FlagDic["nameGap"] = true; _nameGap = value; } }
        int _nameRotate;
        public int nameRotate { get => _nameRotate; set { FlagDic["nameRotate"] = true; _nameRotate = value; } }

        bool _inverse;
        public bool inverse { get => _inverse; set { FlagDic["inverse"] = true; _inverse = value; } }

        string _boundaryGap;
        public string boundaryGap { get => _boundaryGap; set { FlagDic["boundaryGap"] = true; _boundaryGap = value; } }
        string _min;
        public string min { get => _min; set { FlagDic["min"] = true; _min = value; } }
        string _max;
        public string max { get => _max; set { FlagDic["max"] = true; _max = value; } }
        bool _scale;
        public bool scale { get => _scale; set { FlagDic["scale"] = true; _scale = value; } }
        int _splitNumber;
        public int splitNumber { get => _splitNumber; set { FlagDic["splitNumber"] = true; _splitNumber = value; } }
        int _minInterval;
        public int minInterval { get => _minInterval; set { FlagDic["minInterval"] = true; _minInterval = value; } }
        int _maxInterval;
        public int maxInterval { get => _maxInterval; set { FlagDic["maxInterval"] = true; _maxInterval = value; } }
        int _interval;
        public int interval { get => _interval; set { FlagDic["interval"] = true; _interval = value; } }
        int _logBase;
        public int logBase { get => _logBase; set { FlagDic["logBase"] = true; _logBase = value; } }
        int _silent;
        public int silent { get => _silent; set { FlagDic["silent"] = true; _silent = value; } }
        bool _triggerEvent;
        public bool triggerEvent { get => _triggerEvent; set { FlagDic["triggerEvent"] = true; _triggerEvent = value; } }

        //........

        int _zlevel;
        public int zlevel { get => _zlevel; set { FlagDic["zlevel"] = true; _zlevel = value; } }
        int _z;
        public int z { get => _z; set { FlagDic["z"] = true; _z = value; } }
    }
}
