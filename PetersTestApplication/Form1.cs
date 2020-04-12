using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text;

namespace PetersTestApplication
{
    public partial class Form1 : Form
    {
        string rxString;

        public Form1()
        {
            InitializeComponent();
            this.Load += GetAvaliablePorts;
            this.Closed += new EventHandler(ClosePort);
            lbl_status.Text = "Wait to Connnect";
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;     //--Very Important otherwise it wont let you add data via program

        }

        // -- Get the avaliable ports and add them to combo box for serial comms
        void GetAvaliablePorts(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            cmbx_ComPort.DataSource = ports;
            cmbx_BaudRate.SelectedIndex = 0;    //--Initialise with 9600
        }


        private void Bttn_UART_Open_Click(object sender, EventArgs e)
        {
            if (!UART.IsOpen) { UART.Open(); }   //-- Had to add this otherwise it crashes when the serial port tries to re-open

            if (UART.IsOpen)
            {
                sendMessage("R");   //--Send Reset Command to Sync Up (Reset LEDS, set DAC to 0V)
                MessageBox.Show("Serial Port Opened.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl_status.Text = "Serial Port Connected to Microcontroller";
            }
            else
            {
                MessageBox.Show("Serial Port Failed to Open, Check Settings and Physical Connection.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // -- Close the Serial Port
        void ClosePort(object sender, EventArgs e)
        {
            UART.Close();
            lbl_status.Text = "Serial Port Disconnected from Microcontroller";
        }

        // -- Recieved new Data from UART
        private void UART_NewData(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //-- Need todo this otherwise it cannot handle this throead writing to other
            this.Invoke(new EventHandler(displayText));
        }

        private void cmbx_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            UART.BaudRate = Int32.Parse(cmbx_BaudRate.SelectedItem.ToString());    //-- Convert string Value to int 
        }

        private void cmbx_ComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UART.PortName = cmbx_ComPort.SelectedItem.ToString();
        }


        // Function for Writing Message to UART
        void sendMessage(String message)
        {
            try
            {
                UART.WriteLine(message);
      
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Serial Port Error Check Physical Connection and Settings.", "Serial Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void displayText(object o, EventArgs e)
        {
            //--Either Debug message or data
            char indicator = (char)UART.ReadChar();
            
            if (indicator == 'a')
            {
                try
                {
                    //-- 
                    byte[] bytes = new byte[55];
                    for (int i = 0; i < 55; i++) bytes[i] = (byte)UART.ReadByte();

                    ushort co2 = (ushort)((rxString[1] << 8) & (rxString[2]));

                    float h1 = BitConverter.ToSingle(bytes, 2);

                    //-- Add Data to Table. First get index to new row 
                    int n = dataGridView1.Rows.Add();

                    //-- Columns are DateTime, Co2, TempA, HumidA, TempB, HumidB etc
                    dataGridView1.Rows[n].Cells[0].Value = (DateTime.Now).ToString();
                    dataGridView1.Rows[n].Cells[1].Value = BitConverter.ToUInt16(bytes, 0); //--Co2
                    dataGridView1.Rows[n].Cells[2].Value = BitConverter.ToSingle(bytes, 2); //--Temperature Dev A
                    dataGridView1.Rows[n].Cells[3].Value = BitConverter.ToSingle(bytes, 6); //--Humidity Dev A
                    dataGridView1.Rows[n].Cells[4].Value = BitConverter.ToSingle(bytes, 10); //-- Temperature Dev B
                    dataGridView1.Rows[n].Cells[5].Value = BitConverter.ToSingle(bytes, 14); //-- Humidity Dev B

                    dataGridView1.Rows[n].Cells[6].Value = BitConverter.ToUInt16(bytes, 18); //--Co2
                    dataGridView1.Rows[n].Cells[7].Value = BitConverter.ToSingle(bytes, 20); //--Temperature Dev A
                    dataGridView1.Rows[n].Cells[8].Value = BitConverter.ToSingle(bytes, 24); //--Humidity Dev A
                    dataGridView1.Rows[n].Cells[9].Value = BitConverter.ToSingle(bytes, 28); //-- Temperature Dev B
                    dataGridView1.Rows[n].Cells[10].Value = BitConverter.ToSingle(bytes, 32); //-- Humidity Dev B

                    dataGridView1.Rows[n].Cells[11].Value = BitConverter.ToUInt16(bytes, 36); //--Co2
                    dataGridView1.Rows[n].Cells[12].Value = BitConverter.ToSingle(bytes, 38); //--Temperature Dev A
                    dataGridView1.Rows[n].Cells[13].Value = BitConverter.ToSingle(bytes, 42); //--Humidity Dev A
                    dataGridView1.Rows[n].Cells[14].Value = BitConverter.ToSingle(bytes, 46); //-- Temperature Dev B
                    dataGridView1.Rows[n].Cells[15].Value = BitConverter.ToSingle(bytes, 50); //-- Humidity Dev B
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Apppending to datagrid view failed with exception: " + ex.ToString());
                }
            }
            else
            {
                rxString = UART.ReadLine();
                System.Diagnostics.Debug.WriteLine(indicator + rxString);
            }
        }

        private void SaveToCSV(DataGridView DGV)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Sensor Data.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Data will be exported and you will be notified when it is ready.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    }
                }

                try
                {
                    int columnCount = DGV.ColumnCount;
                    string columnNames = "";
                    string[] output = new string[DGV.RowCount + 1];
                    for (int i = 0; i < columnCount; i++)
                    {
                        columnNames += DGV.Columns[i].Name.ToString() + ",";
                    }
                    output[0] += columnNames;
                    for (int i = 1; i < DGV.RowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            output[i] += DGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                        }
                    }
                    System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                    MessageBox.Show("Your file was generated and its ready for use.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred when writing file: " + ex.Message);
                }
            }
        }

        private void dGrd_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void bttnWrite_Click(object sender, EventArgs e)
        {
            SaveToCSV(dataGridView1);
        }




    }
}
