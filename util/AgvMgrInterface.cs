using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class AgvMgrInterface
    {

        private static object _agvMgr;
        public static object Instance { get { return _agvMgr; } }

        public static void SetAgvInstance(Object Mgr)
        {
            _agvMgr = Mgr;
        }


    }
}