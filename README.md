# EChartsNet
ECharts的Net版本映射，可用于Winform、Wpf，更方便的显示各类图表

net framework >= 4.0

echarts > 4

# 使用
新建控制台程序(winform和wpf均可，不过都以winform版本的webbrowser作为承载):
1. init data: 初始化数据(DataTable映射为echarts中的dataset)，默认列名作标签轴
```
DataTable dataTable = new DataTable("temp");
dataTable.Columns.Add("产品", typeof(string));
dataTable.Columns.Add("2015", typeof(float));
dataTable.Columns.Add("2016", typeof(float));
dataTable.Columns.Add("2017", typeof(float));
dataTable.Rows.Add("中国", 43.3, 85.8, 93.7);
dataTable.Rows.Add("美国", 83.1, 73.4, 55.1);
dataTable.Rows.Add("日本", 86.4, 65.2, 82.5);
dataTable.Rows.Add("英国", 72.4, 53.9, 39.1);
```
2. add browser: 增加浏览器承载 winfrom和wpf的webbrowser均可
```
int row = 2, col = 3, width = 500, height = 370;
WebBrowser browser = new WebBrowser();
browser.Dock = DockStyle.Fill;
browser.TabIndex = 0;
browser.Size = new Size(col * width, row * height);
```

3. add layout and charts, then show :创建布局，增加图表，Show()显示
```
Echarts echarts = new Echarts(browser);//新建 以browser承载
echarts.AddTheme(Theme.roma);//增加主题
echarts.CreateTableLayout(row, col, width, height);//创建布局

echarts[1, 1] = new SimpleBar(dataTable,new CompleteOption() { title = new Title() { text = "'基础柱状图'", } }, 1);
echarts[1, 2] = new BasicLineChart(dataTable,new CompleteOption() { title = new Title() { text = "'基础折线图'", } }, 1);
echarts[1, 3] = new BasicScatter(dataTable, new CompleteOption() { title = new Title() { text = "'基础散点图'", } }, 1);
echarts[2, 1] = new SmoothedLineChart(dataTable,new CompleteOption() { title = new Title() { text = "'基础曲线图'", }}, 1);
echarts[2, 2] = new StackBar(dataTable,new CompleteOption() { title = new Title() { text = "'堆叠柱状图'", } }, 1);
echarts[2, 3] = new BasicPie(dataTable,new CompleteOption(), 1);
echarts.Show();//显示
```
4. 关于控制台显示form和webbrowser见**EChartsNetDemo项目**
```
Form form = new Form();
form.FormClosing += delegate { browser.Dispose(); Environment.Exit(0); };
form.Size = new Size(col * width + 45, row * height + 60);
form.Controls.Add(browser);
form.StartPosition = FormStartPosition.CenterScreen;
Application.Run(form);
```

5. 效果图：
![图片名称](https://github.com/WnagoiYy/EChartsNet/blob/master/20190502141413.png)  

# 目前支持
基础柱状图、基础折线图、基础散点图、基础面积图、基础曲线图、堆叠柱状图。

其他图也可以根据echarts的配置方法硬配置(因部分option未完整支持)，理论上支持所有图形-_-!

# 其他
水平有限，指教

