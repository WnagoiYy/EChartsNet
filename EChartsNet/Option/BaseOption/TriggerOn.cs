using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option.BaseOption
{
    /// <summary>
    /// tooltip 提示框触发的条件
    /// [ default: 'mousemove|click' ]
    /// </summary>
    public enum TriggerOn
    {
        /// <summary>
        /// 鼠标移动时触发
        /// </summary>
        [Remark("'mousemove'")]
        mousemove = 1,
        /// <summary>
        /// 鼠标点击时触发
        /// </summary>
        [Remark("'click'")]
        click,
        /// <summary>
        /// 同时鼠标移动和点击时触发
        /// </summary>
        [Remark("'mousemove|click'")]
        mousemove_click,
        /// <summary>
        /// 不在 'mousemove' 或 'click' 时触发
        /// </summary>
        [Remark("'none'")]
        none
    }
}
