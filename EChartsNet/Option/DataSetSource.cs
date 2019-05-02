using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EChartsNet.Option
{
    /// <summary>
    /// 属性完成 --
    /// ECharts 4 开始支持了 数据集（dataset）组件用于单独的数据集声明，
    /// 从而数据可以单独管理，被多个组件复用，并且可以自由指定数据到视觉的映射。这在不少场景下能带来使用上的方便。
    /// line、bar、pie、scatter、effectScatter、parallel、candlestick、map、funnel、custom
    /// </summary>
    public class DataSetSource : BaseEOption
    {
        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public DataSetSource()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }
        string _id;
        /// <summary>
        /// 组件 ID。默认不指定。指定则可用于在 option 或者 API 中引用组件。
        /// </summary>
        public string id { get => _id; set { FlagDic["id"] = true; _id = value; } }
        string _source;
        /// <summary>
        /// 原始数据。一般来说，原始数据表达的是二维表。可以用如下这些格式表达二维表：
        /// </summary>
        public string source { get => _source; set { FlagDic["source"] = true; _source = value; } }
        string _dimensions;
        /// <summary>
        /// 使用 dimensions 定义 series.data 或者 dataset.source 的每个维度的信息。
        /// 如果使用了 dataset，那么可以在 dataset.source 的第一行/列中给出 dimension 名称。于是就不用在这里指定 dimension
        /// 如果在这里指定了 dimensions，那么 ECharts 不再会自动从 dataset.source 的第一行/列中获取维度信息
        /// </summary>
        public string dimensions { get => _dimensions; set { FlagDic["dimensions"] = true; _dimensions = value; } }
        bool _sourceHeader;
        /// <summary>
        /// dataset.source 第一行/列是否是 维度名 信息。可选值：
        /// null/undefine：默认，自动探测。
        /// true：第一行/列是维度名信息。
        /// false：第一行/列直接开始是数据。
        /// </summary>
        public bool sourceHeader { get => _sourceHeader; set { FlagDic["sourceHeader"] = true; _sourceHeader = value; } }

       
    }
}
