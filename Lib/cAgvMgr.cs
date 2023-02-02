using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Lib
{
    public class cAgvMgr
    {

        public int NumberVeh { get; set; }
        public String Name { get; set; }

        public cAgvMgr()
        {
            NumberVeh = 1;
            Name = " test";
            AgvMgrInterface.SetAgvInstance(this);
        }


    }
}
