using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStart
{
    public partial class Service1 : ServiceBase
    {
        Lib.Controller _controller;
        Main _mainControl;
        public Service1()
        {
            InitializeComponent();
            _mainControl = new Main();
        }

        protected override void OnStart(string[] args)
        {

            string csfile = ConfigurationManager.AppSettings["ColdStartFile"];
            if (File.Exists(csfile))
            {
                File.Delete(csfile);
                _controller = _mainControl.StartActivities(true);
            }
            else
            {
                _controller = _mainControl.StartActivities(false);
            }

        }

        protected override void OnStop()
        {
            _mainControl.StopActivities();
        }
    }
}
