using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.SeriesType.LineBaseOption
{
    public enum LineSampling
    {
        [Remark("'average'")]
        average = 1,
        [Remark("'dasmaxhed'")]
        max,
        [Remark("'min'")]
        min,
        [Remark("'sum'")]
        sum,
    }
}
