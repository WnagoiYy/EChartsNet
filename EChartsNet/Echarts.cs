using EChartsNet.Charts;
using EChartsNet.HtmlNode;
using EChartsNet.TableLayout;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EChartsNet
{
    public class Echarts
    {    
        Table table;//添加布局支持
        string BackGroundColor;//背景色
        Dictionary<string, Theme> themes;//支持主题 
        Dictionary<string, string> optionScript;//所有增加的图表
        List<string> CssScriptSrcList;//自定义增加css文件
        List<string> JsScriptSrcList;//自定义增加js文件
        List<Node> NodeList; //添加自定义节点

        System.Windows.Forms.WebBrowser webBrowser;
        
        public Echarts(System.Windows.Forms.WebBrowser webBrowser)
        {
            #region 设置webbrowser
            this.webBrowser = webBrowser;
            WebBrowserConfig.SetWebBrowserFeatures(11);
            this.webBrowser.ScriptErrorsSuppressed = true;//脚本
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;//禁用右键菜单
            this.webBrowser.WebBrowserShortcutsEnabled = false;//禁用快捷键
            this.webBrowser.AllowWebBrowserDrop = false;//禁用Drop
            this.webBrowser.AllowNavigation = false;//禁用超链接 
            /*Type type = webBrowser.GetType();
            switch (type.FullName)
            {
                case "WebKit.WebKitBrowser":
                    //(webBrowser as WebKit.WebKitBrowser).AllowNavigation = false;
                    //(webBrowser as WebKit.WebKitBrowser).AllowDrop = false;
                    //(webBrowser as WebKit.WebKitBrowser).AllowNewWindows = false;
                    break;
                case "Gecko.GeckoWebBrowser":
                    (webBrowser as Gecko.GeckoWebBrowser).NoDefaultContextMenu = true; //禁用右键菜单
                    (webBrowser as Gecko.GeckoWebBrowser).AllowDrop = false;
                    break;
                case "System.Windows.Forms.WebBrowser":
                    WebBrowserConfig.SetWebBrowserFeatures(11);
                    (webBrowser as System.Windows.Forms.WebBrowser).ScriptErrorsSuppressed = true;//脚本
                    (webBrowser as System.Windows.Forms.WebBrowser).IsWebBrowserContextMenuEnabled = false;//禁用右键菜单
                    (webBrowser as System.Windows.Forms.WebBrowser).WebBrowserShortcutsEnabled = false;//禁用快捷键
                    (webBrowser as System.Windows.Forms.WebBrowser).AllowWebBrowserDrop = false;//禁用Drop
                    (webBrowser as System.Windows.Forms.WebBrowser).AllowNavigation = false;//禁用超链接 
                    break;
                case "System.Windows.Controls.WebBrowser":
                    (webBrowser as System.Windows.Controls.WebBrowser).AllowDrop= false;
                    WebBrowserConfig.SetWebBrowserFeatures(11);
                    break;
            }*/

            #endregion 设置webbrowser
            themes = new Dictionary<string, Theme>();
            optionScript = new Dictionary<string, string>();
            CssScriptSrcList = new List<string>();
            JsScriptSrcList = new List<string>();
            NodeList = new  List<Node>();

            if (!EchartsInitialize.InitFlag)
            {
                EchartsInitialize.Initialize();//初始化基本配置
            }
        }

        public BaseCharts this[int row, int col] {//添加图的索引器
            set {
                AddChart(row, col, value);
            }
        }
        /// <summary>
        /// 创建表格布局
        /// </summary>
        /// <param name="rowNum">行数</param>
        /// <param name="colNum">列数</param>
        /// <param name="width">每行宽度</param>
        /// <param name="height">每行高度</param>
        public void CreateTableLayout(int rowNum = 1, int colNum = 1, int width = 800, int height = 600, string borderColor = "#add9c0")
        {
            table = new Table(rowNum, colNum, width, height, borderColor);
        }
        /// <summary>
        /// 增加表到相应的行列
        /// </summary>
        public void AddChart(int row, int col, BaseCharts baseCharts)
        {
            if (optionScript.ContainsKey("container" + row + "_" + col))
                optionScript["container" + row + "_" + col] = baseCharts._initScript;
            else
                optionScript.Add("container" + row + "_" + col, baseCharts._initScript);
        }

        /// <summary>
        /// 显示已经添加的所有图
        /// </summary>
        public void Show()
        {
            if (table == null) return;

            //添加布局和初始化脚本
            var bodyNode = new Node("body").AddChild(table.GetTableNode());
            foreach (var option in optionScript)
            {
                if (option.Value != null)
                {
                    bodyNode.AddChild(GetScriptNode(option.Key, option.Value));
                }
            }
            //<meta http-equiv = \"X-UA-Compatible\" content = \"IE=edge,chrome=1\" charset=\"utf-8\" />
            var titleNode = new Node("title") { Content = "ECharts" };
            var headNode = new Node("head") { Content = "<meta http-equiv = \"X-UA-Compatible\" content = \"IE=edge,chrome=1\" charset=\"utf-8\" />"};
            headNode.AddChild(titleNode);
            //支持echarts
            headNode.AddChild(new Node("script") { Parameters = new { src = "./echarts.min.js", }, });
            //支持GL
            if (EchartsInitialize.SupportEchartsGL)
                headNode.AddChild(new Node("script")
                {
                    Parameters = new { src = "./echarts.min.js", }
                });
            bool haveJq=false;
            //支持bootstrap
            if (EchartsInitialize.SupportBootstrap)
            {
                headNode.AddChild(new Node("link")
                {
                    Parameters = new
                    {
                        rel = "stylesheet",
                        href = "./bootstrap/css/bootstrap.min.css"
                    }
                });
                headNode.AddChild(new Node("script")
                {
                    Parameters = new
                    {
                        src = "./jquery.min.js",
                    }
                });
                headNode.AddChild(new Node("script")
                {
                    Parameters = new
                    {
                        src = "./popper.min.js",
                    }
                });
                headNode.AddChild(new Node("script")
                {
                    Parameters = new
                    {
                        src = "./bootstrap/js/bootstrap.min.js",
                    }
                });
                haveJq = true;
            };
            //支持Jquery
            if (EchartsInitialize.SupportJQuery && !haveJq) {
                headNode.AddChild(new Node("script")
                {
                    Parameters = new
                    {
                        src = "./jquery.min.js",
                    }
                });
            }            
            //支持theme
            if (themes!=null && themes.Count>0)
            {
                foreach (var di in themes)
                {
                    headNode.AddChild(new Node("script") {
                        Parameters = new { src = di.Value.ScriptPath },});
                }
            }
            var htmlNode = new Node("html");
            htmlNode.AddChild(headNode).AddChild(bodyNode);

            string tempName = "Echarts/" + DateTime.Now.Ticks + ".html";
            File.WriteAllText(tempName, @"<!DOCTYPE html>" + Environment.NewLine + htmlNode.GetHtmlStr());
            webBrowser.Navigate(new Uri(Environment.CurrentDirectory) + "/" + tempName);
        }

        public void SaveAsHtml(string fileName)
        {
            File.WriteAllText(fileName,webBrowser.DocumentText);
        }

        //--------------------------------增加主题 CSS JS 自定义节点
        public void AddTheme(string themeName, Theme theme)
        {
            if (themes.ContainsKey(themeName))
                themes[themeName] = theme;
            else
                themes.Add(themeName, theme);
        }
        public void AddTheme(Theme theme)
        {
            AddTheme(theme.Name, theme);
        }
        public void AddCssScriptSrc(string cssSrc)
        {
            CssScriptSrcList.Add(cssSrc);
        }
        public void AddJsScriptSrc(string jssSrc)
        {
            JsScriptSrcList.Add(jssSrc);
        }
        public void AddCustomNode(Node node)
        {
            NodeList.Add(node);
        }
        //-------------------------------------------------------------------//
        Node GetScriptNode(string containerId, string script)
        {
            return new HtmlNode.Node("script")
            {
                Parameters = new { type = "text/javascript" },
                Content = new JSBeautify(
                    InitID(containerId) + Environment.NewLine +
                        $"var {containerId}option = " + script + ";" +
                        SetOption(containerId),
                    new JSBeautifyOptions()).GetResult(),
            };
        }
        string InitID(string ContanerID)
        {
            return $@"var my{ContanerID}Chart = echarts.init("+
                $@"document.getElementById('{ContanerID}')" + GetTheme ()+ ");";
        }
        string SetOption(string ContanerID)
        {
            return $@"my{ContanerID}Chart.setOption({ContanerID}option);";
        }
        string GetTheme(string theme = null)
        {
            if (!EchartsInitialize.UseTheme || (themes == null || themes.Count <= 0))
                return "";
            if (string.IsNullOrWhiteSpace(theme))
                return ",'" + themes.First().Value.Name+"'";
            if(!themes.ContainsKey(theme))
                return ",'" + themes.First().Value.Name + "'";
            else
                return ",'" + themes[theme].Name + "'";
        }
    }
}
