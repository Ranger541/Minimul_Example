using System;
using System.Windows.Forms;
using Lib;


namespace Simulation
{
    public partial class Form1 : Form
    {
        cAgvMgr _agvMgr;    
        
        public Form1()
        {
            InitializeComponent();
            _agvMgr = (cAgvMgr)Utils.AgvMgrInterface.Instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_agvMgr == null)
            {
                textBox1.Text = "Null";
            }
            else
            {
                textBox1.Text = _agvMgr.Name + "/b/r" + _agvMgr.NumberVeh;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
