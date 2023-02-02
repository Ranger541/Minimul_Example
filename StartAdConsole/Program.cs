using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;


namespace StartAsConsole
{
    internal class Program
    {
        
        static Lib.Controller _controller;
        static Main _mainControl;
        static void Main(string[] args)
        {

            _controller = new Lib.Controller();

            _controller.Start(false);
        }
    }
}

