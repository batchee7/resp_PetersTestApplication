namespace PetersTestApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttn_UART_Disconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_BaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_UART_Open = new System.Windows.Forms.Button();
            this.cmbx_ComPort = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sensorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bttnWrite = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UART = new System.IO.Ports.SerialPort(this.components);
            this.colDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ACo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colATmpA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAHumA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colATmpB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAHumB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBCo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBTmpA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBHumA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBTmpB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBHumB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTmpA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCHumA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTmpB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCHumB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttn_UART_Disconnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbx_BaudRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_UART_Open);
            this.groupBox1.Controls.Add(this.cmbx_ComPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Controls";
            // 
            // bttn_UART_Disconnect
            // 
            this.bttn_UART_Disconnect.Location = new System.Drawing.Point(20, 57);
            this.bttn_UART_Disconnect.Name = "bttn_UART_Disconnect";
            this.bttn_UART_Disconnect.Size = new System.Drawing.Size(95, 23);
            this.bttn_UART_Disconnect.TabIndex = 6;
            this.bttn_UART_Disconnect.Text = "Disconnect";
            this.bttn_UART_Disconnect.UseVisualStyleBackColor = true;
            this.bttn_UART_Disconnect.Click += new System.EventHandler(this.ClosePort);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud Rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbx_BaudRate
            // 
            this.cmbx_BaudRate.FormattingEnabled = true;
            this.cmbx_BaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbx_BaudRate.Location = new System.Drawing.Point(236, 59);
            this.cmbx_BaudRate.Name = "cmbx_BaudRate";
            this.cmbx_BaudRate.Size = new System.Drawing.Size(170, 21);
            this.cmbx_BaudRate.TabIndex = 4;
            this.cmbx_BaudRate.SelectedIndexChanged += new System.EventHandler(this.cmbx_BaudRate_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Com Port:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_UART_Open
            // 
            this.btn_UART_Open.Location = new System.Drawing.Point(20, 28);
            this.btn_UART_Open.Name = "btn_UART_Open";
            this.btn_UART_Open.Size = new System.Drawing.Size(95, 23);
            this.btn_UART_Open.TabIndex = 1;
            this.btn_UART_Open.Text = "Connect";
            this.btn_UART_Open.UseVisualStyleBackColor = true;
            this.btn_UART_Open.Click += new System.EventHandler(this.Bttn_UART_Open_Click);
            // 
            // cmbx_ComPort
            // 
            this.cmbx_ComPort.FormattingEnabled = true;
            this.cmbx_ComPort.Location = new System.Drawing.Point(236, 30);
            this.cmbx_ComPort.Name = "cmbx_ComPort";
            this.cmbx_ComPort.Size = new System.Drawing.Size(170, 21);
            this.cmbx_ComPort.TabIndex = 0;
            this.cmbx_ComPort.SelectedIndexChanged += new System.EventHandler(this.cmbx_ComPort_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDt,
            this.col_ACo2,
            this.colATmpA,
            this.colAHumA,
            this.colATmpB,
            this.colAHumB,
            this.colBCo2,
            this.colBTmpA,
            this.colBHumA,
            this.colBTmpB,
            this.colBHumB,
            this.colCCo2,
            this.colCTmpA,
            this.colCHumA,
            this.colCTmpB,
            this.colCHumB});
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1189, 415);
            this.dataGridView1.TabIndex = 4;
            // 
            // sensorDataBindingSource
            // 
            this.sensorDataBindingSource.DataSource = typeof(PetersTestApplication.SensorData);
            // 
            // bttnWrite
            // 
            this.bttnWrite.Location = new System.Drawing.Point(430, 22);
            this.bttnWrite.Name = "bttnWrite";
            this.bttnWrite.Size = new System.Drawing.Size(771, 65);
            this.bttnWrite.TabIndex = 7;
            this.bttnWrite.Text = "Write To File";
            this.bttnWrite.UseVisualStyleBackColor = true;
            this.bttnWrite.Click += new System.EventHandler(this.bttnWrite_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(496, 90);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(69, 20);
            this.lbl_status.TabIndex = 9;
            this.lbl_status.Text = "Running";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status:";
            // 
            // UART
            // 
            this.UART.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.UART_NewData);
            // 
            // colDt
            // 
            this.colDt.HeaderText = "Date/ Time";
            this.colDt.Name = "colDt";
            // 
            // col_ACo2
            // 
            this.col_ACo2.HeaderText = "A: Co2";
            this.col_ACo2.Name = "col_ACo2";
            // 
            // colATmpA
            // 
            this.colATmpA.HeaderText = "A: Temp1";
            this.colATmpA.Name = "colATmpA";
            // 
            // colAHumA
            // 
            this.colAHumA.HeaderText = "A: Hum1";
            this.colAHumA.Name = "colAHumA";
            // 
            // colATmpB
            // 
            this.colATmpB.HeaderText = "A: Temp2";
            this.colATmpB.Name = "colATmpB";
            // 
            // colAHumB
            // 
            this.colAHumB.HeaderText = "A: Hum2";
            this.colAHumB.Name = "colAHumB";
            // 
            // colBCo2
            // 
            this.colBCo2.HeaderText = "B: Co2";
            this.colBCo2.Name = "colBCo2";
            // 
            // colBTmpA
            // 
            this.colBTmpA.HeaderText = "B: Temp1";
            this.colBTmpA.Name = "colBTmpA";
            // 
            // colBHumA
            // 
            this.colBHumA.HeaderText = "B: Hum1";
            this.colBHumA.Name = "colBHumA";
            // 
            // colBTmpB
            // 
            this.colBTmpB.HeaderText = "B: Temp2";
            this.colBTmpB.Name = "colBTmpB";
            // 
            // colBHumB
            // 
            this.colBHumB.HeaderText = "B: Hum2";
            this.colBHumB.Name = "colBHumB";
            // 
            // colCCo2
            // 
            this.colCCo2.HeaderText = "C: Co2";
            this.colCCo2.Name = "colCCo2";
            // 
            // colCTmpA
            // 
            this.colCTmpA.HeaderText = "C: Temp1";
            this.colCTmpA.Name = "colCTmpA";
            // 
            // colCHumA
            // 
            this.colCHumA.HeaderText = "C: Hum1";
            this.colCHumA.Name = "colCHumA";
            // 
            // colCTmpB
            // 
            this.colCTmpB.HeaderText = "C: Temp2";
            this.colCTmpB.Name = "colCTmpB";
            // 
            // colCHumB
            // 
            this.colCHumB.HeaderText = "C: Hum2";
            this.colCHumB.Name = "colCHumB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1223, 549);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnWrite);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Peter\'s Data Collector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttn_UART_Disconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_BaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_UART_Open;
        private System.Windows.Forms.ComboBox cmbx_ComPort;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sensorDataBindingSource;
        private System.Windows.Forms.Button bttnWrite;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort UART;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ACo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colATmpA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAHumA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colATmpB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAHumB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBTmpA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBHumA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBTmpB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBHumB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTmpA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCHumA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTmpB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCHumB;
    }
}

