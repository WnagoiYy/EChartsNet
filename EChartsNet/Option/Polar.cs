using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet.Option
{
    public class Polar : BaseEOption
    {

        public override string ToString()
        {
            return Common.GetOptionValue(this, this.FlagDic, this.TypeDic);
        }
        public Polar()
        {
            Common.InitOptionFlag(this, FlagDic, TypeDic);
        }

        public string id { get { return _id; } set { FlagDic["id"] = true; _id = value; } }
        public int zlevel { get { return _zlevel; } set { FlagDic["zlevel"] = true; _zlevel = value; } }
        public int z { get { return _z; } set { FlagDic["z"] = true; _z = value; } }
        public string center { get { return _center; } set { FlagDic["center"] = true; _center = value; } }
        public string radius { get { return _radius; } set { FlagDic["radius"] = true; _radius = value; } }
        public Tooltip tooltip { get { return _tooltip; } set { FlagDic["tooltip"] = true; _tooltip = value; } }

        string _id;
        int _zlevel;
        int _z;
        string _center;
        string _radius;
        Tooltip _tooltip;

    }
}
