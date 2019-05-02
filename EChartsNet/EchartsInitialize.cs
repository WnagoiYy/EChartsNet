using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EChartsNet.HtmlNode;

namespace EChartsNet
{
    public class EchartsInitialize
    {
        public static bool SupportEchartsGL = false; //GL支持
        public static bool SupportJQuery = false;
        public static bool SupportBootstrap = false;
        public static bool UseTheme = true; //是否使用主题

        public static bool InitFlag = false;

        public static void Initialize(bool GL = false)
        {
            SupportEchartsGL = GL;
            InitFlag = true;
            /*// 使用 Canvas 渲染器（默认）
            var chart = echarts.init(containerDom, null, {renderer: 'canvas'});
            // 等价于：
            var chart = echarts.init(containerDom);
            // 使用 SVG 渲染器
            var chart = echarts.init(containerDom, null, {renderer: 'svg'});*/
            DirectoryInfo di = new DirectoryInfo("./ECharts");
            FileInfo[] fi = di.GetFiles();
            foreach (FileInfo f in fi)
            {
                if (f.Extension == ".html")
                {
                    try { File.Delete(f.FullName); } catch { }
                }
            }
        }
    }
}
