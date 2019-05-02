using EChartsNet.Option;
using EChartsNet.Option.SeriesType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EChartsNet.Charts.Pie
{
    public class BasicPie : BaseCharts
    {
        public BasicPie(DataTable dataTable, CompleteOption option, int categoryCol = 1)
        {

            if (option.title == null)
            {
                option.title = new Title()
                {
                    text = "'基础饼状图'",
                    left = "'center'"
                };

                if (!option.legend.FlagDic["orient"])
                {
                    option.legend.orient = Option.BaseOption.Orient.vertical;
                    option.legend.left = "'left'";
                }
                option.dataset = new DataSetSource()
                {
                    source = Common.GetDataSetSource(dataTable, categoryCol - 1),
                };
                option.series = new Series(
                    new ISeries[] {
                new SeriesPie() {
                    emphasis = new Option.SeriesType.SeriesBaseOption.Emphasis()
                    {
                        itemStyle = new Option.SeriesType.SeriesBaseOption.ItemStyle()
                        {
                            shadowBlur = 10,
                            shadowOffsetX = 0,
                            shadowColor = "'rgba(0, 0, 0, 0.5)'",
                        }
                    }

            }});
                _initScript = option.ToString();
            }
        }
    }
}