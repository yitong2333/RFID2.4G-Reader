
namespace RFID2._4G
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPortInfo = new System.Windows.Forms.TextBox();
            this.btnStopTag = new System.Windows.Forms.Button();
            this.btnStartTag = new System.Windows.Forms.Button();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTagID = new System.Windows.Forms.TextBox();
            this.txtReaderID = new System.Windows.Forms.TextBox();
            this.btnSetTagperiod = new System.Windows.Forms.Button();
            this.btnSetSignalStrength = new System.Windows.Forms.Button();
            this.btnSetTagID = new System.Windows.Forms.Button();
            this.btnSetReaderID = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTagperiod = new System.Windows.Forms.ComboBox();
            this.cmbSignalStrength = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTagInfo = new System.Windows.Forms.DataGridView();
            this.tagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbjs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTagInfo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPortInfo);
            this.groupBox1.Controls.Add(this.btnStopTag);
            this.groupBox1.Controls.Add(this.btnStartTag);
            this.groupBox1.Controls.Add(this.btnClosePort);
            this.groupBox1.Controls.Add(this.btnOpenPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPorts);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(379, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // txtPortInfo
            // 
            this.txtPortInfo.Location = new System.Drawing.Point(103, 66);
            this.txtPortInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPortInfo.Name = "txtPortInfo";
            this.txtPortInfo.Size = new System.Drawing.Size(160, 25);
            this.txtPortInfo.TabIndex = 18;
            // 
            // btnStopTag
            // 
            this.btnStopTag.Location = new System.Drawing.Point(225, 179);
            this.btnStopTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStopTag.Name = "btnStopTag";
            this.btnStopTag.Size = new System.Drawing.Size(145, 45);
            this.btnStopTag.TabIndex = 7;
            this.btnStopTag.Text = "停止寻卡";
            this.btnStopTag.UseVisualStyleBackColor = true;
            this.btnStopTag.Click += new System.EventHandler(this.btnStopTag_Click);
            // 
            // btnStartTag
            // 
            this.btnStartTag.Location = new System.Drawing.Point(11, 179);
            this.btnStartTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartTag.Name = "btnStartTag";
            this.btnStartTag.Size = new System.Drawing.Size(145, 45);
            this.btnStartTag.TabIndex = 6;
            this.btnStartTag.Text = "开始寻卡";
            this.btnStartTag.UseVisualStyleBackColor = true;
            this.btnStartTag.Click += new System.EventHandler(this.btnStartTag_Click);
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(225, 111);
            this.btnClosePort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(145, 45);
            this.btnClosePort.TabIndex = 5;
            this.btnClosePort.Text = "关闭串口";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(11, 111);
            this.btnOpenPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(145, 45);
            this.btnOpenPort.TabIndex = 4;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "串口设置：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口号：";
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(103, 34);
            this.cmbPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(160, 23);
            this.cmbPorts.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTagID);
            this.groupBox2.Controls.Add(this.txtReaderID);
            this.groupBox2.Controls.Add(this.btnSetTagperiod);
            this.groupBox2.Controls.Add(this.btnSetSignalStrength);
            this.groupBox2.Controls.Add(this.btnSetTagID);
            this.groupBox2.Controls.Add(this.btnSetReaderID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbTagperiod);
            this.groupBox2.Controls.Add(this.cmbSignalStrength);
            this.groupBox2.Location = new System.Drawing.Point(16, 268);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(379, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数设置";
            // 
            // txtTagID
            // 
            this.txtTagID.Location = new System.Drawing.Point(103, 106);
            this.txtTagID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTagID.Name = "txtTagID";
            this.txtTagID.Size = new System.Drawing.Size(160, 25);
            this.txtTagID.TabIndex = 16;
            // 
            // txtReaderID
            // 
            this.txtReaderID.Location = new System.Drawing.Point(103, 55);
            this.txtReaderID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReaderID.Name = "txtReaderID";
            this.txtReaderID.Size = new System.Drawing.Size(160, 25);
            this.txtReaderID.TabIndex = 15;
            // 
            // btnSetTagperiod
            // 
            this.btnSetTagperiod.Location = new System.Drawing.Point(272, 212);
            this.btnSetTagperiod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetTagperiod.Name = "btnSetTagperiod";
            this.btnSetTagperiod.Size = new System.Drawing.Size(100, 29);
            this.btnSetTagperiod.TabIndex = 14;
            this.btnSetTagperiod.Text = "设置";
            this.btnSetTagperiod.UseVisualStyleBackColor = true;
            this.btnSetTagperiod.Click += new System.EventHandler(this.btnSetTagperiod_Click);
            // 
            // btnSetSignalStrength
            // 
            this.btnSetSignalStrength.Location = new System.Drawing.Point(272, 162);
            this.btnSetSignalStrength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetSignalStrength.Name = "btnSetSignalStrength";
            this.btnSetSignalStrength.Size = new System.Drawing.Size(100, 29);
            this.btnSetSignalStrength.TabIndex = 13;
            this.btnSetSignalStrength.Text = "设置";
            this.btnSetSignalStrength.UseVisualStyleBackColor = true;
            this.btnSetSignalStrength.Click += new System.EventHandler(this.btnSetSignalStrength_Click);
            // 
            // btnSetTagID
            // 
            this.btnSetTagID.Location = new System.Drawing.Point(272, 106);
            this.btnSetTagID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetTagID.Name = "btnSetTagID";
            this.btnSetTagID.Size = new System.Drawing.Size(100, 28);
            this.btnSetTagID.TabIndex = 12;
            this.btnSetTagID.Text = "设置";
            this.btnSetTagID.UseVisualStyleBackColor = true;
            this.btnSetTagID.Click += new System.EventHandler(this.btnSetTagID_Click);
            // 
            // btnSetReaderID
            // 
            this.btnSetReaderID.Location = new System.Drawing.Point(272, 51);
            this.btnSetReaderID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetReaderID.Name = "btnSetReaderID";
            this.btnSetReaderID.Size = new System.Drawing.Size(100, 29);
            this.btnSetReaderID.TabIndex = 11;
            this.btnSetReaderID.Text = "设置";
            this.btnSetReaderID.UseVisualStyleBackColor = true;
            this.btnSetReaderID.Click += new System.EventHandler(this.btnSetReaderID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "标签周期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "标签ID：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "信号强度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "读写器ID：";
            // 
            // cmbTagperiod
            // 
            this.cmbTagperiod.FormattingEnabled = true;
            this.cmbTagperiod.Location = new System.Drawing.Point(103, 216);
            this.cmbTagperiod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTagperiod.Name = "cmbTagperiod";
            this.cmbTagperiod.Size = new System.Drawing.Size(160, 23);
            this.cmbTagperiod.TabIndex = 4;
            // 
            // cmbSignalStrength
            // 
            this.cmbSignalStrength.FormattingEnabled = true;
            this.cmbSignalStrength.Location = new System.Drawing.Point(103, 162);
            this.cmbSignalStrength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSignalStrength.Name = "cmbSignalStrength";
            this.cmbSignalStrength.Size = new System.Drawing.Size(160, 23);
            this.cmbSignalStrength.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTagInfo);
            this.groupBox3.Location = new System.Drawing.Point(403, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(504, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "标签信息";
            // 
            // dgvTagInfo
            // 
            this.dgvTagInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTagInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagID,
            this.sbjs,
            this.Dgvinfo});
            this.dgvTagInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTagInfo.Location = new System.Drawing.Point(4, 22);
            this.dgvTagInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTagInfo.Name = "dgvTagInfo";
            this.dgvTagInfo.RowHeadersWidth = 51;
            this.dgvTagInfo.RowTemplate.Height = 23;
            this.dgvTagInfo.Size = new System.Drawing.Size(496, 218);
            this.dgvTagInfo.TabIndex = 0;
            // 
            // tagID
            // 
            this.tagID.HeaderText = "标签ID";
            this.tagID.MinimumWidth = 6;
            this.tagID.Name = "tagID";
            this.tagID.Width = 125;
            // 
            // sbjs
            // 
            this.sbjs.HeaderText = "识别计数";
            this.sbjs.MinimumWidth = 6;
            this.sbjs.Name = "sbjs";
            this.sbjs.Width = 125;
            // 
            // Dgvinfo
            // 
            this.Dgvinfo.HeaderText = "实时信息";
            this.Dgvinfo.MinimumWidth = 6;
            this.Dgvinfo.Name = "Dgvinfo";
            this.Dgvinfo.Width = 125;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(403, 269);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(504, 282);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "标签数据帧";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(8, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(489, 244);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 566);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "2.4G \"寻\" 卡";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTagInfo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStopTag;
        private System.Windows.Forms.Button btnStartTag;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTagperiod;
        private System.Windows.Forms.ComboBox cmbSignalStrength;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTagID;
        private System.Windows.Forms.TextBox txtReaderID;
        private System.Windows.Forms.Button btnSetTagperiod;
        private System.Windows.Forms.Button btnSetSignalStrength;
        private System.Windows.Forms.Button btnSetTagID;
        private System.Windows.Forms.Button btnSetReaderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTagInfo;
        private System.Windows.Forms.TextBox txtPortInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbjs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvinfo;
        private System.Windows.Forms.ListBox listBox1;
    }
}

