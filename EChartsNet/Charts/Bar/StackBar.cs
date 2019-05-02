using EChartsNet.Option;
using EChartsNet.Option.BaseOption;
using EChartsNet.Option.SeriesType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EChartsNet.Charts.Bar
{
    /// <summary>
    /// 堆叠柱状图
    /// </summary>
    public class StackBar : BaseCharts
    {
        public StackBar(DataTable dataTable, CompleteOption option, int categoryCol = 1, string stack="'汇总'")
        {
            option.xAxis = new XAxis()
            {
                type = xAxisType.category
            };
            option.yAxis = new YAxis();
            option.dataset = new DataSetSource()
            {
                source = Common.GetDataSetSource(dataTable, categoryCol - 1),

            };
            List<ISeries> series = new List<ISeries>();
            //series.Add(new SeriesBar());
            foreach (var ser in Enumerable.Repeat(new SeriesBar() { stack = stack }, dataTable.Columns.Count - 1).ToArray())
            {
                series.Add(ser);
            }
            option.series = new Series(series.ToArray());
            _initScript = option.ToString();
        }
    }
}
