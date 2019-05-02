初步计划：
	支持dataset系列图表Net版本
echarts 4+
jquery 3.3.1
bootstrap 4.3.1


--2019-04-28:0.1
计划支持三种基本图类型的部分延伸类型(line、pie、bar)
三种type(line、pie、bar)基础属性除
	MarkPointData MarkLineData MarkAreaData BarData已经全部支持
ToolBox除Feature以外支持

Line:
	BasicLineChart		基础折线图	√
	BasicAreachart		基础面积图	√
	SmoothedLineChart	基础曲线图	√

Bar:
	SimpleBar			基础柱状图	√
	StackBar			堆叠柱状图	√
Scatter:
	
	



属性映射支持(https://echarts.baidu.com/option.html)：
√	title
√	legend
√	grid
√	xAxis
√	yAxis
polar
radiusAxis
angleAxis
radar
dataZoom
visualMap
tooltip
axisPointer
toolbox
brush
geo
parallel
parallelAxis
singleAxis
timeline
graphic
calendar
dataset
aria
series
color
backgroundColor
√	textStyle
√	animation
√	animationThreshold
√	animationDuration
√	animationEasing
√	animationDelay
√	animationDurationUpdate
√	animationEasingUpdate
√	animationDelayUpdate
√	blendMode
√	hoverLayerThreshold
√	useUTC
