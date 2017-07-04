using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOS_LeadMobile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartHome_Click(object sender, EventArgs e)
        {
            //MobileOS.Wiper wipe = new MobileOS.Wiper("192.168.11.109", "alpine", "com.be.koko");
            // wipe.Application();
            sshNet sshNet = new sshNet("192.168.11.133");
            sshNet.backUpApp("com.netease.ic","_10-10-2015_10101");
            //sshNet.RestoreApp("com.netease.ic_10-10-2015_1010", "com.netease.ic")
            //MobileOS.ExtensionOS extens = new MobileOS.ExtensionOS("192.168.11.109", "alpine");
            //extens.setFilepath("./");
            //extens.ProxyAdd("163.172.110.215", "1232");
            //extens.BackupRRS("quy", "_" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year+"_"+new Random().Next(1,99999));

        }
    }
}
