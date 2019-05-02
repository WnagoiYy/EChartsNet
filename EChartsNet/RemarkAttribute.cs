using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet
{
    public class RemarkAttribute : Attribute
    {
        public RemarkAttribute(string remark)
        {
            _remark = remark;
        }
        private string _remark;
        public string GetRemark()
        {
            return _remark;
        }
    }
    public static class Remark
    {
        //扩展方法：静态类里面的静态方法 用this修饰
        public static string GetRemark(Enum value)
        {//this Enum value
            
            Type type = value.GetType();//一定要使用GetType
            var field = type.GetField(value.ToString());
            if (field.IsDefined(typeof(RemarkAttribute), true))
            {
                var RemarkAttr = (RemarkAttribute)field.GetCustomAttributes(typeof(RemarkAttribute), true)[0];
                return RemarkAttr.GetRemark();
            }
            return null;
        }
        public static string GetRemark(Type type,string value)
        {//this Enum value

            var field = type.GetField(value.ToString());
            if (field.IsDefined(typeof(RemarkAttribute), true))
            {
                var RemarkAttr = (RemarkAttribute)field.GetCustomAttributes(typeof(RemarkAttribute), true)[0];
                return RemarkAttr.GetRemark();
            }
            return null;
        }
    }
}
