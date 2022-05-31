using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//IO is needed to use the COM-port
using System.IO.Ports;
using System.IO;



namespace Motor_pid_GUI_V2
{
    public partial class Form1 : Form
    {
       
        //this variables are used on the real time graphing
        //Variable to hold position values received from esp32
        string[] position = new string[100];
        //Variable to hold control values received from mc
        string[] controlValue = new string[100];
        //Variable that is not used atm
        string[] time = new string[100];
        //Setpoints received from esp32 generated from potmeter
        int[] setPoint = new int[100];

        //This values are used for textboxes in gui
        string setPointInMicroController; 
        //Setpoint
        string Sp = "0";
        //integral constant
        string Pi = "0";
        //derivative constant
        string Pd = "0";
        //constant 
        string Pk = "0";
        //Sampling frequency
        string Fs = "0";
        
        
        //String to hold incoming data from COM-port
        string incomingData;
        //Create handling event when data is available on COM-port
        private delegate void LineReceivedEvent(string line);

        public Form1()
        {

            InitializeComponent();
            getAvailablePorts();
            setupChart();
        }

        //Setup of graph
        private void setupChart()
        {
            pidChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Green;
            pidChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = true;
            pidChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.Green;
            pidChart.ChartAreas["ChartArea1"].AxisX.InterlacedColor = Color.YellowGreen;
            pidChart.ChartAreas["ChartArea1"].AxisX.LineColor = Color.YellowGreen;
            pidChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 1;
            pidChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Interval = 10;

            pidChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Green;
            pidChart.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = true;
            pidChart.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineColor = Color.Green;
            pidChart.ChartAreas["ChartArea1"].AxisY.LineColor = Color.YellowGreen;
            pidChart.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.Green;
            pidChart.ChartAreas["ChartArea1"].AxisY.InterlacedColor = Color.YellowGreen;
            pidChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.Interval = 20;
            pidChart.ChartAreas["ChartArea1"].AxisY.MinorGrid.Interval = 10;
            pidChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 1;
            pidChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.Interval = 10;
            pidChart.ChartAreas["ChartArea1"].AxisY.Minimum = -120;
            pidChart.ChartAreas["ChartArea1"].AxisY.Maximum = 120;

            pidChart.ChartAreas["ChartArea1"].AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            pidChart.ChartAreas["ChartArea1"].AxisY2.Minimum = -1100;
            pidChart.ChartAreas["ChartArea1"].AxisY2.Maximum = 1100;
            pidChart.ChartAreas["ChartArea1"].AxisY2.LabelStyle.ForeColor = Color.Green;
            pidChart.ChartAreas["ChartArea1"].AxisY2.MajorGrid.Interval = 16;
            pidChart.Series["Control Value"].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            pidChart.ChartAreas["ChartArea1"].BackColor = Color.Black;
            pidChart.BackColor = Color.Black;

            
        }

        private void getAvailablePorts()
        {
            //Get avilable ports and display them in combobox
            String[] ports = SerialPort.GetPortNames();
            comboBoxCOM.Items.AddRange(ports);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCOM.Text == "")
                {
                    textBoxWarning.Text = "Please select port settings";
                }
                else
                {
                    //Get selected portname
                    serialPort1.PortName = comboBoxCOM.Text;
                    //Set baudrate to 115200
                    serialPort1.BaudRate = 115200;
                    //Set data terminal ready
                    serialPort1.DtrEnable = true;
                    //Open com port
                    serialPort1.Open();
                    //get data when it comes in on port
                    serialPort1.DataReceived += getSerialData;
                    //Hardcode what is the newline character
                    serialPort1.NewLine = "\n";

                    progressBar.Value = 100;
                    buttonConnect.Enabled = false;
                    buttonDisconnect.Enabled = true;
                    textBoxSetpoint.Enabled = true;
                    textBoxWarning.Text = "";
                    
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBoxWarning.Text = "Unauthorized access";
            }
        }

        private void textBoxSetpoint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {
                    if (comboBoxCOM.Text == "")
                    {
                        textBoxWarning.Text = "Please select port settings";
                    }
                    else
                    {

                        Sp = textBoxSetpoint.Text;
                        textBoxSPAdd.Text = Sp;
                        textBoxSetpoint.Text = "";
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    textBoxWarning.Text = "Unauthorized access";
                }
            }

        }

        private void textboxKp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                try
                {
                    if (comboBoxCOM.Text == "")
                    {
                        textBoxWarning.Text = "Please select port settings";
                    }
                    else
                    {

                        Pk = textBoxKp.Text;
                        textBoxKpAdd.Text = Pk;
                        textBoxKp.Text = "";
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    textBoxWarning.Text = "Unauthorized access";
                }
            }
        }

        private void textBoxKi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {
                    if (comboBoxCOM.Text == "")
                    {
                        textBoxWarning.Text = "Please select port settings";
                    }
                    else
                    {
                        Pi = textBoxKi.Text;
                        textBoxKiAdd.Text = Pi;
                        textBoxKi.Text = "";
                    }

                }
                catch (UnauthorizedAccessException)
                {
                    textBoxWarning.Text = "Unauthorized access";
                }
            }
        }

        private void textBoxKd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {
                    if (comboBoxCOM.Text == "")
                    {
                        textBoxWarning.Text = "Please select port settings";
                    }
                    else
                    {
                        Pd = textBoxKd.Text;
                        textBoxKdAdd.Text = textBoxKd.Text;
                        textBoxKd.Text = "";
                        
                    }
                }

                catch (UnauthorizedAccessException)
                {
                    textBoxWarning.Text = "Unauthorized access";
                }
            }
        }

        private void textBoxFs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {
                    if (comboBoxCOM.Text == "")
                    {
                        textBoxWarning.Text = "Please select port settings";
                    }
                    else
                    {
                        Fs = textBoxFs.Text;
                        textBoxFsAdd.Text = Fs;
                        textBoxFs.Text = "";
                    }
                }

                catch (UnauthorizedAccessException)
                {
                    textBoxWarning.Text = "Unauthorized access";
                }
            }
        }
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar.Value = 0;
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
            textBoxSetpoint.Enabled = false;
            timer1.Enabled = false;
        }

   

        private void getSerialData(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Get data from serial port
            incomingData = serialPort1.ReadExisting();
            //Trigger event handler to treat data
            this.BeginInvoke(new LineReceivedEvent(LineReceived), incomingData);

        }


       
        private void LineReceived(string line)
        {

    
            try
            {
              
                if (line.Contains("o") == true && line.Contains("i") && line.Contains("l") == true)
                {
                    //empty serial buffer
                    serialPort1.DiscardInBuffer();

                   //Parse string to Int32 and save it in array
                    Int32.TryParse(Sp, out setPoint[setPoint.Length - 1]);
                    //Shift array to the lefte, throw out oldest datapoint
                    Array.Copy(setPoint, 1, setPoint, 0, setPoint.Length - 1);

                   
                    //Get number that is in between o and i(the number after o) in the string received from esp32
                    //and save it in the last place in the position array
                    position[position.Length - 1] = line.Substring(1, line.IndexOf("i") - 1);
                    //Shift array to the lefte, throw out oldest datapoint
                    Array.Copy(position, 1, position, 0, position.Length - 1);

                    //Get number that is in between i and l(the number after i) in the string received from esp32
                    //and save it in the last place in the controlValue array
                    controlValue[controlValue.Length - 1] = line.Substring(line.IndexOf("i") + 1, line.Length - line.IndexOf("l") + 1);
                    //Shift array to the lefte, throw out oldest datapoint
                    Array.Copy(controlValue, 1, controlValue, 0, controlValue.Length - 1);
                    //get setpoint from the number after l in the string coming from the esp32
                    setPointInMicroController = line.Substring(line.IndexOf("l") + 1, line.Length - line.IndexOf("l") - 1);

                 //   Console.WriteLine(position[position.Length - 1] + "  " + controlValue[controlValue.Length - 1] + "  " + setPointInMicroController);

                }
            }
            catch (InvalidOperationException)
            {
                textBoxWarning.Text = "Serial port closed";
            }

        }
        //This function triggers at 25Hz
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Clear the graph
            pidChart.Series["Position"].Points.Clear();
            pidChart.Series["Control Value"].Points.Clear();
            pidChart.Series["SetPoint"].Points.Clear();

            //If the user has chosen to use potmeter, get value from esp32
            if (checkBoxPotOrPC.Checked)
            {
                textBoxSPAdd.Text = setPointInMicroController;
                Sp = setPointInMicroController;
            }


            //Add points to graph
            for (int i = 0; i < position.Length - 1; i++)
            {
                if (position[i] != null)
                {
                    pidChart.Series["SetPoint"].Points.AddY(setPoint[i]);
                    pidChart.Series["Position"].Points.AddY(position[i]);
                    pidChart.Series["Control Value"].Points.AddY(controlValue[i]);
              

                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

     

        private void buttonUpdatePID_Click(object sender, EventArgs e)
        {
            //Send PID constants to esp32 if update is pressed
            serialPort1.WriteLine("p" + Pk);
           
            Task.Delay(20);
            serialPort1.WriteLine("i" + Pi);
           
            Task.Delay(20);
            serialPort1.WriteLine("d" + Pd);
 
            Task.Delay(20);
            
        }

        private void buttonUpdateFs_Click(object sender, EventArgs e)
        {
            //Send sampling frequency to esp32 if update is pushed
            serialPort1.WriteLine("f" + textBoxFsAdd.Text);
            
           
        }

        private void buttonUpdateSp_Click(object sender, EventArgs e)
        {
            //Send setpoint to esp32
            serialPort1.WriteLine("s" + Sp);


            //checbox for setpoint via potmeter is checked, send variable to
            //esp32 so it toggles to use potmetervalues
            if (checkBoxPotOrPC.Checked) {
                serialPort1.WriteLine("t1");
            }
            else
            {
                //use setpoint value sent from PC. 
                serialPort1.WriteLine("t0");
            }
            
            Int32.TryParse(Sp, out setPoint[setPoint.Length - 1]);
            Array.Copy(setPoint, 1, setPoint, 0, setPoint.Length - 1);
            
        }
    }
}
