namespace Motor_pid_GUI_V2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWarning = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxKd = new System.Windows.Forms.TextBox();
            this.textBoxKi = new System.Windows.Forms.TextBox();
            this.textBoxKp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonUpdateFs = new System.Windows.Forms.Button();
            this.textBoxFsAdd = new System.Windows.Forms.TextBox();
            this.textBoxFs = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxPotOrPC = new System.Windows.Forms.CheckBox();
            this.buttonUpdateSp = new System.Windows.Forms.Button();
            this.textBoxSPAdd = new System.Windows.Forms.TextBox();
            this.textBoxSetpoint = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonUpdatePID = new System.Windows.Forms.Button();
            this.textBoxKpAdd = new System.Windows.Forms.TextBox();
            this.textBoxKdAdd = new System.Windows.Forms.TextBox();
            this.textBoxKiAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pidChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pidChart)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(63, 9);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(190, 9);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(121, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(317, 9);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(120, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(63, 53);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(90, 20);
            this.progressBar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Warnings";
            // 
            // textBoxWarning
            // 
            this.textBoxWarning.Location = new System.Drawing.Point(217, 53);
            this.textBoxWarning.Name = "textBoxWarning";
            this.textBoxWarning.ReadOnly = true;
            this.textBoxWarning.Size = new System.Drawing.Size(220, 20);
            this.textBoxWarning.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxWarning);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxCOM);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 84);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // textBoxKd
            // 
            this.textBoxKd.Location = new System.Drawing.Point(53, 83);
            this.textBoxKd.Name = "textBoxKd";
            this.textBoxKd.Size = new System.Drawing.Size(48, 20);
            this.textBoxKd.TabIndex = 10;
            this.textBoxKd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKd_KeyDown);
            // 
            // textBoxKi
            // 
            this.textBoxKi.Location = new System.Drawing.Point(53, 57);
            this.textBoxKi.Name = "textBoxKi";
            this.textBoxKi.Size = new System.Drawing.Size(48, 20);
            this.textBoxKi.TabIndex = 11;
            this.textBoxKi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKi_KeyDown);
            // 
            // textBoxKp
            // 
            this.textBoxKp.Location = new System.Drawing.Point(54, 31);
            this.textBoxKp.Name = "textBoxKp";
            this.textBoxKp.Size = new System.Drawing.Size(48, 20);
            this.textBoxKp.TabIndex = 12;
            this.textBoxKp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxKp_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 540);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonStart);
            this.groupBox6.Controls.Add(this.buttonStop);
            this.groupBox6.Location = new System.Drawing.Point(5, 471);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(168, 63);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Graph";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(8, 28);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(48, 23);
            this.buttonStart.TabIndex = 25;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(98, 28);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(49, 23);
            this.buttonStop.TabIndex = 26;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonUpdateFs);
            this.groupBox5.Controls.Add(this.textBoxFsAdd);
            this.groupBox5.Controls.Add(this.textBoxFs);
            this.groupBox5.Location = new System.Drawing.Point(7, 379);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(167, 86);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PID Sampling frequency";
            // 
            // buttonUpdateFs
            // 
            this.buttonUpdateFs.Location = new System.Drawing.Point(54, 48);
            this.buttonUpdateFs.Name = "buttonUpdateFs";
            this.buttonUpdateFs.Size = new System.Drawing.Size(102, 23);
            this.buttonUpdateFs.TabIndex = 25;
            this.buttonUpdateFs.Text = "Update";
            this.buttonUpdateFs.UseVisualStyleBackColor = true;
            this.buttonUpdateFs.Click += new System.EventHandler(this.buttonUpdateFs_Click);
            // 
            // textBoxFsAdd
            // 
            this.textBoxFsAdd.Location = new System.Drawing.Point(106, 22);
            this.textBoxFsAdd.Name = "textBoxFsAdd";
            this.textBoxFsAdd.ReadOnly = true;
            this.textBoxFsAdd.Size = new System.Drawing.Size(48, 20);
            this.textBoxFsAdd.TabIndex = 24;
            // 
            // textBoxFs
            // 
            this.textBoxFs.Location = new System.Drawing.Point(54, 22);
            this.textBoxFs.Name = "textBoxFs";
            this.textBoxFs.Size = new System.Drawing.Size(48, 20);
            this.textBoxFs.TabIndex = 22;
            this.textBoxFs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFs_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxPotOrPC);
            this.groupBox4.Controls.Add(this.buttonUpdateSp);
            this.groupBox4.Controls.Add(this.textBoxSPAdd);
            this.groupBox4.Controls.Add(this.textBoxSetpoint);
            this.groupBox4.Location = new System.Drawing.Point(11, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 122);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Setpoint";
            // 
            // checkBoxPotOrPC
            // 
            this.checkBoxPotOrPC.AutoSize = true;
            this.checkBoxPotOrPC.Location = new System.Drawing.Point(50, 54);
            this.checkBoxPotOrPC.Name = "checkBoxPotOrPC";
            this.checkBoxPotOrPC.Size = new System.Drawing.Size(89, 17);
            this.checkBoxPotOrPC.TabIndex = 30;
            this.checkBoxPotOrPC.Text = "Use potmeter";
            this.checkBoxPotOrPC.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateSp
            // 
            this.buttonUpdateSp.Location = new System.Drawing.Point(48, 93);
            this.buttonUpdateSp.Name = "buttonUpdateSp";
            this.buttonUpdateSp.Size = new System.Drawing.Size(101, 23);
            this.buttonUpdateSp.TabIndex = 29;
            this.buttonUpdateSp.Text = "Update";
            this.buttonUpdateSp.UseVisualStyleBackColor = true;
            this.buttonUpdateSp.Click += new System.EventHandler(this.buttonUpdateSp_Click);
            // 
            // textBoxSPAdd
            // 
            this.textBoxSPAdd.Location = new System.Drawing.Point(102, 17);
            this.textBoxSPAdd.Name = "textBoxSPAdd";
            this.textBoxSPAdd.ReadOnly = true;
            this.textBoxSPAdd.Size = new System.Drawing.Size(49, 20);
            this.textBoxSPAdd.TabIndex = 18;
            // 
            // textBoxSetpoint
            // 
            this.textBoxSetpoint.Location = new System.Drawing.Point(48, 17);
            this.textBoxSetpoint.Name = "textBoxSetpoint";
            this.textBoxSetpoint.Size = new System.Drawing.Size(48, 20);
            this.textBoxSetpoint.TabIndex = 17;
            this.textBoxSetpoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSetpoint_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonUpdatePID);
            this.groupBox3.Controls.Add(this.textBoxKpAdd);
            this.groupBox3.Controls.Add(this.textBoxKdAdd);
            this.groupBox3.Controls.Add(this.textBoxKiAdd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxKp);
            this.groupBox3.Controls.Add(this.textBoxKi);
            this.groupBox3.Controls.Add(this.textBoxKd);
            this.groupBox3.Location = new System.Drawing.Point(5, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 150);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PID-constants";
            // 
            // buttonUpdatePID
            // 
            this.buttonUpdatePID.Location = new System.Drawing.Point(52, 109);
            this.buttonUpdatePID.Name = "buttonUpdatePID";
            this.buttonUpdatePID.Size = new System.Drawing.Size(103, 23);
            this.buttonUpdatePID.TabIndex = 28;
            this.buttonUpdatePID.Text = "Update";
            this.buttonUpdatePID.UseVisualStyleBackColor = true;
            this.buttonUpdatePID.Click += new System.EventHandler(this.buttonUpdatePID_Click);
            // 
            // textBoxKpAdd
            // 
            this.textBoxKpAdd.Location = new System.Drawing.Point(106, 31);
            this.textBoxKpAdd.Name = "textBoxKpAdd";
            this.textBoxKpAdd.ReadOnly = true;
            this.textBoxKpAdd.Size = new System.Drawing.Size(49, 20);
            this.textBoxKpAdd.TabIndex = 21;
            // 
            // textBoxKdAdd
            // 
            this.textBoxKdAdd.Location = new System.Drawing.Point(106, 83);
            this.textBoxKdAdd.Name = "textBoxKdAdd";
            this.textBoxKdAdd.ReadOnly = true;
            this.textBoxKdAdd.Size = new System.Drawing.Size(49, 20);
            this.textBoxKdAdd.TabIndex = 20;
            // 
            // textBoxKiAdd
            // 
            this.textBoxKiAdd.Location = new System.Drawing.Point(106, 57);
            this.textBoxKiAdd.Name = "textBoxKiAdd";
            this.textBoxKiAdd.ReadOnly = true;
            this.textBoxKiAdd.Size = new System.Drawing.Size(49, 20);
            this.textBoxKiAdd.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ki";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Setpoint";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pidChart
            // 
            this.pidChart.BackColor = System.Drawing.Color.DimGray;
            this.pidChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.pidChart.ChartAreas.Add(chartArea1);
            this.pidChart.Cursor = System.Windows.Forms.Cursors.Cross;
            legend1.Name = "Legend1";
            this.pidChart.Legends.Add(legend1);
            this.pidChart.Location = new System.Drawing.Point(202, 91);
            this.pidChart.Name = "pidChart";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Position";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Control Value";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "SetPoint";
            this.pidChart.Series.Add(series1);
            this.pidChart.Series.Add(series2);
            this.pidChart.Series.Add(series3);
            this.pidChart.Size = new System.Drawing.Size(1600, 717);
            this.pidChart.TabIndex = 14;
            this.pidChart.Text = "chart1";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 820);
            this.Controls.Add(this.pidChart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pidChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWarning;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxKd;
        private System.Windows.Forms.TextBox textBoxKi;
        private System.Windows.Forms.TextBox textBoxKp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSetpoint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pidChart;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBoxKpAdd;
        private System.Windows.Forms.TextBox textBoxKdAdd;
        private System.Windows.Forms.TextBox textBoxKiAdd;
        private System.Windows.Forms.TextBox textBoxSPAdd;
        private System.Windows.Forms.TextBox textBoxFsAdd;
        private System.Windows.Forms.TextBox textBoxFs;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonUpdatePID;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonUpdateFs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonUpdateSp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxPotOrPC;
    }
}

