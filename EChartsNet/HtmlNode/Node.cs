using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EChartsNet.HtmlNode
{
    public class Node
    {
        public string Tag { get; private set; }
        public string ID { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public string Content { get; set; }
        public object Parameters { get; set; }

        private List<Node> childNodes;
        public Node(string tag) : this(tag, "", "") { }
        public Node(string tag, string id) : this(tag, id, "") { }
        public Node(string tag, string id,string style)
        {
            Tag = tag;
            ID = id;
            Style = style;
            childNodes = new List<Node>();
        }
        Dictionary<string,string> GetKeyValues(object aa)
        {
            if (aa == null) return null;
            var ret = new Dictionary<string, string>();
            PropertyInfo[] properties = aa.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            if (properties.Length > 0)
                foreach (PropertyInfo item in properties)
                {
                    string name = item.Name;
                    object value = item.GetValue(aa, null);
                    if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                    {
                        ret.Add(name, value==null?"":value.ToString());
                    }
                }
            return ret;
        }
        string GetFontTag()
        {
            var paramstr = "";
            var dic = GetKeyValues(Parameters);
            if (dic != null && dic.Count > 0)
            {
                foreach(var d in dic)
                {
                    paramstr += " " + d.Key + "=\"" + d.Value+ "\"";
                }
            }
            return "<" + Tag +
                Common.GetPro(ID, " id=\"{$}\"") +
                Common.GetPro(Class, " class=\"{$}\"") +
                Common.GetPro(Style, " style=\"{$}\"") +
                paramstr + ">";
        }

        string GetEndTag()
        {
            return "</" + Tag + ">";
        }
        public Node AddChild(Node htmlNode)
        {
            if(htmlNode!=null) childNodes.Add(htmlNode);
            return this;
        }
        
        public string GetHtmlStr()
        {
            string s = "";
            if(childNodes!=null && childNodes.Count > 0)
            {
                foreach(var node in childNodes)
                    s += node.GetHtmlStr();
            }
            return GetFontTag() 
                 + (string.IsNullOrWhiteSpace(Content) ? "" : (Environment.NewLine+Content + Environment.NewLine))
                 + (string.IsNullOrWhiteSpace(s) ? "" : (Environment.NewLine + s)) + GetEndTag() + Environment.NewLine;
        }
    }
}
