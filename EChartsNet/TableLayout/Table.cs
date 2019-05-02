using EChartsNet.HtmlNode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.TableLayout
{
    public class Table
    {
        //01增加css
        Node TableNode;
        public Table(int rowNum=1,int colNum=1,int width=800,int height=600,string borderColor = "#add9c0")
        {
            
            var containerNode = new Node("div","container", GetSizeStyle(width * colNum, height * rowNum));
            var tableNode = new Node("table", "maintable", GetSizeStyle(width * colNum, height * rowNum) + 
                (string.IsNullOrWhiteSpace(borderColor)?"":$"border:solid {borderColor}; border-width:0px 1px 1px 0px;")) {
                Class = "mainTable",
                Parameters = new {
                    cellpadding = 0,
                    cellspacing = 0,
                }
            };
            var tbodyNode = new Node("tbody");
            for(int i = 0; i < rowNum; i++)
            {
                var trNode = new Node("tr");
                for(int j = 0; j < colNum; j++)
                {
                    var tdNode = new Node("td") { Style = GetSizeStyle(width, height) + (string.IsNullOrWhiteSpace(borderColor) ? "" : $"border:solid {borderColor}; border-width:1px 0px 0px 1px;") };
                    var conNode = new Node("div", "container" + (i + 1) + "_" + (j + 1), GetSizeStyle(width, height)){ Class = "container" + (i + 1), };
                    trNode.AddChild(tdNode.AddChild(conNode));
                }
                tbodyNode.AddChild(trNode);
            }
            TableNode = containerNode.AddChild(tableNode.AddChild(tbodyNode));
        }
        string GetSizeStyle(int width,int height)
        {
            return "width:" + width + "px;" + "height:" + height + "px;";
        }
        public string GetTableHtmlStr()
        {
            return TableNode.GetHtmlStr(); 
        }
        public Node GetTableNode()
        {
            return TableNode;
        }
    }
}
