using EChartsNet;
using EChartsNet.Charts.Bar;
using EChartsNet.Charts.Line;
using EChartsNet.Charts.Pie;
using EChartsNet.Charts.Scatter;
using EChartsNet.Option;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EChartsNetWpfDemo {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            //01.使用DataTable 承载映射数据
            DataTable dataTable = new DataTable("temp");
            dataTable.Columns.Add("产品", typeof(string));
            dataTable.Columns.Add("2015", typeof(float));
            dataTable.Columns.Add("2016", typeof(float));
            dataTable.Columns.Add("2017", typeof(float));
            dataTable.Rows.Add("中国", 43.3, 85.8, 93.7);
            dataTable.Rows.Add("美国", 83.1, 73.4, 55.1);
            dataTable.Rows.Add("日本", 86.4, 65.2, 82.5);
            dataTable.Rows.Add("英国", 72.4, 53.9, 39.1);
            //02.添加承载，调用显示
            Echarts echarts = new Echarts(browser);//新建 以browser承载
            echarts.AddTheme(Theme.roma);//增加主题
            //03.显示和添加浏览器大小更改自适应事件
            ShowCharts(dataTable, echarts);
            browser.SizeChanged += delegate { ShowCharts(dataTable, echarts); };
        }

        private void ShowCharts(DataTable dataTable ,Echarts echarts) {
            echarts.CreateTableLayout(2, 3, (browser.Width - 20) / 3, (browser.Height - 20) / 2);//创建布局
            echarts[1, 1] = new SimpleBar(dataTable, new CompleteOption() { title = new Title() { text = "'基础柱状图'", } }, 1);
            echarts[1, 2] = new BasicLineChart(dataTable, new CompleteOption() { title = new Title() { text = "'基础折线图'", } }, 1);
            echarts[1, 3] = new BasicScatter(dataTable, new CompleteOption() { title = new Title() { text = "'基础散点图'", } }, 1);
            echarts[2, 1] = new SmoothedLineChart(dataTable, new CompleteOption() { title = new Title() { text = "'基础曲线图'", } }, 1);
            echarts[2, 2] = new StackBar(dataTable, new CompleteOption() { title = new Title() { text = "'堆叠柱状图'", } }, 1);
            echarts[2, 3] = new BasicPie(dataTable, new CompleteOption() { title = new Title() { text = "'简单饼图'", } }, 1);
            echarts.Show();//显示
        }
    }
}
