using EChartsNet;
using EChartsNet.Charts.Bar;
using EChartsNet.Charts.Line;
using EChartsNet.Charts.Pie;
using EChartsNet.Charts.Scatter;
using EChartsNet.Option;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EChartsNetDemo
{
    class Program
    {

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


        [STAThread]
        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, 0); //  hide console window (ShowWindow(handle, 5);//show)

            System.Threading.Thread t = new System.Threading.Thread(ThreadStart);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
        }

        private static void ThreadStart()
        {
            //01 初始化数据，默认列名作标签轴
            DataTable dataTable = new DataTable("temp");
            dataTable.Columns.Add("产品", typeof(string));
            dataTable.Columns.Add("2015", typeof(float));
            dataTable.Columns.Add("2016", typeof(float));
            dataTable.Columns.Add("2017", typeof(float));
            dataTable.Rows.Add("中国", 43.3, 85.8, 93.7);
            dataTable.Rows.Add("美国", 83.1, 73.4, 55.1);
            dataTable.Rows.Add("日本", 86.4, 65.2, 82.5);
            dataTable.Rows.Add("英国", 72.4, 53.9, 39.1);

            //02.add browser
            int row = 2, col = 3, width = 500, height = 370;
            WebBrowser browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.TabIndex = 0;
            browser.Size = new Size(col * width, row * height);

            //EchartsInitialize.SupportEchartsGL = true;
            //EchartsInitialize.SupportBootstrap = true;
            //03.创建布局，增加图，Show()显示图 
            Echarts echarts = new Echarts(browser);
            echarts.AddTheme(Theme.roma);
            echarts.CreateTableLayout(row, col, width, height);

            echarts[1, 1] = new SimpleBar(dataTable,new CompleteOption() { title = new Title() { text = "'基础柱状图'", } }, 1);
            echarts[1, 2] = new BasicLineChart(dataTable,new CompleteOption() { title = new Title() { text = "'基础折线图'", } }, 1);
            echarts[1, 3] = new BasicScatter(dataTable, new CompleteOption() { title = new Title() { text = "'基础散点图'", } }, 1);
            //echarts[1, 3] = new BasicAreachart(dataTable,new CompleteOption() { title = new Title() { text = "'基础面积图'", } }, 1);
            echarts[2, 1] = new SmoothedLineChart(dataTable,new CompleteOption() { title = new Title() { text = "'基础曲线图'", } }, 1);
            echarts[2, 2] = new StackBar(dataTable,new CompleteOption() { title = new Title() { text = "'堆叠柱状图'", } }, 1);
            echarts[2, 3] = new BasicPie(dataTable,new CompleteOption(), 1);
            echarts.Show();

            //04 - -
            Form form = new Form();
            form.FormClosing += delegate { browser.Dispose(); Environment.Exit(0); };
            form.Size = new Size(col * width + 45, row * height + 60);
            form.Controls.Add(browser);
            form.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form);

            
        }
    }
}
