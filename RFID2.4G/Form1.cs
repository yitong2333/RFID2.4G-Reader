using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KV_SHF;
using System.IO.Ports;

namespace RFID2._4G
{
    
    public partial class Form1 : Form
    {
        SHFDLL sHFDLL = new SHFDLL();
        private delegate void AddRowDel(Int32[] myDataRow);
        private delegate void 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnClosePort.Enabled = false;
            btnSetReaderID.Enabled = false;
            btnSetTagID.Enabled = false;
            btnSetReaderID.Enabled = false;
            btnSetSignalStrength.Enabled = false;
            btnSetTagperiod.Enabled = false;
            cmbSignalStrength.Enabled = false;
            cmbTagperiod.Enabled = false;
            string[] portName = SerialPort.GetPortNames();
            if (portName.Length>0)
            {
                foreach (string s in portName)
                {
                    cmbPorts.Items.Add(s);
                }
                cmbPorts.SelectedIndex = 0;
            }
            txtPortInfo.Text = "9600,N,8,1";
            string[] signalStrength = { "9", "11", "13", "15" };
            foreach (string s in signalStrength)
            {
                cmbSignalStrength.Items.Add(s);
            }
            cmbSignalStrength.SelectedIndex = 0;
            string[] tagPeroid = { "100", "150", "200", "225" };
            foreach (string s in tagPeroid)
            {
                cmbTagperiod.Items.Add(s);
            }
            cmbTagperiod.SelectedIndex = 0;

        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (!sHFDLL.IsOpen)
            {
                try
                {
                    sHFDLL.OpenSerial(cmbPorts.Text);
                    btnOpenPort.Enabled = false;
                    btnClosePort.Enabled = true;
                    btnSetReaderID.Enabled = true;
                    btnSetTagID.Enabled = true;
                    btnSetReaderID.Enabled = true;
                    btnSetSignalStrength.Enabled = true;
                    btnSetTagperiod.Enabled = true;
                    cmbSignalStrength.Enabled = true;
                    cmbTagperiod.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误" + ex.ToString());
                }
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            if (sHFDLL.IsOpen) 
            {
                sHFDLL.StopInventory();//停止寻卡
                sHFDLL.CloseSerial();//关闭串口
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
                btnSetReaderID.Enabled = false;
                btnSetTagID.Enabled = false;
                btnSetReaderID.Enabled = false;
                btnSetSignalStrength.Enabled = false;
                btnSetTagperiod.Enabled = false;
                cmbSignalStrength.Enabled = false;
                cmbTagperiod.Enabled = false;
            }
        }

        private void btnStartTag_Click(object sender, EventArgs e)
        {
            if (sHFDLL.IsOpen)
            {
                sHFDLL.Inventory();//寻卡


            }
        }

        private void btnStopTag_Click(object sender, EventArgs e)
        {
            if (sHFDLL.IsOpen)
            {
                sHFDLL.StopInventory();//stop寻卡


            }
        }

        private void btnSetReaderID_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(txtReaderID.Text);
                if (temp >=0&&temp<=255)
                {
                    sHFDLL.SetReadID(byte.Parse(txtReaderID.Text));
                }
                else
                {
                    MessageBox.Show("0-255之间！");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("错误\n"+ex.Message);
            }
        }

        private void btnSetTagID_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(txtReaderID.Text);
                if (temp >= 0 && temp <= 255)
                {
                    if (MessageBox.Show(this.Owner,"此功能会把天线的有效读写距离内的所有标签的ID都设置成您输入的数值. \n建议您让天线的有效读写距离内，只有一个可被识别的电子标签，以免造成多个电子标签的ID号都相同\n点击确定，继续设置标签的ID.点击取消，则放弃操作","提示" ,MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                    }
                    sHFDLL.SetTagID(byte.Parse(txtTagID.Text));
                }
                else
                {
                    MessageBox.Show("0-255之间！");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("错误\n" + ex.Message);
            }
        }

        private void btnSetSignalStrength_Click(object sender, EventArgs e)
        {
            if (cmbSignalStrength.Text!="")
            {
                sHFDLL.SetTagPower(byte.Parse(cmbSignalStrength.Text));
            }
        }

        private void btnSetTagperiod_Click(object sender, EventArgs e)
        {
            if (cmbTagperiod.Text != "")
            {
                sHFDLL.SetTagPeriod(byte.Parse(cmbTagperiod.Text));
            }
        }
        private void AddRow(int[] data)
        {

        }
        private void AddUII(int[] data)
        {

        }
    }
}
