using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.OleDb;
using DocumentFormat.OpenXml.Office2010.Excel;
using ClosedXML.Excel;



namespace simp
{
    public partial class Form1 : Form
    {
        SerialPort port;
        Boolean isPortOpen = false;
        Boolean isSend = false;
        Boolean isReceived = false;
        String dataToSend = null;
        String receivedData = null;
        int maxAttempts = 15;
        public Form1()
        {
            InitializeComponent();
            port = new SerialPort();

            for (int row = 1; row <= 20; row++)
            {
                dataGridView.Rows.Add();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            PortSel.Items.AddRange(ports);
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            if (!isPortOpen)
            {
                string selectedPort = PortSel.SelectedItem as string;
                if (!string.IsNullOrEmpty(selectedPort))
                {
                    port.PortName = selectedPort;
                    try
                    {
                        port.BaudRate = 115200;
                        port.DataBits = 8;
                        port.Parity = Parity.None;
                        port.StopBits = StopBits.One;
                        port.Open();
                        ToggleButton.Text = "Close Port";
                        isPortOpen = true;
                        MessageBox.Show($"Port {port.PortName} opened successfully.", "Port Opened", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                port.Close();
                ToggleButton.Text = "Open Port";
                isPortOpen = false;
                MessageBox.Show($"Port {port.PortName} closed.", "Port Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private async Task BMCReceiveData()
        {
            if (isPortOpen)
            {
                try
                {
                    receivedData = await Task.Run(() => port.ReadLine());
                    isReceived = true;
                    //MessageBox.Show($"{receivedData}", "Received data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error receiving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isReceived = false;
                }
            }
            else
            {
                MessageBox.Show("Please open the COM port first.", "Port Not Open", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isReceived = false;
            }
        }

        private void BMCSendData()
        {
            if (isPortOpen)
            {
                try
                {
                    port.WriteLine(dataToSend);
                    isSend = true;
                    // MessageBox.Show($"{dataToSend} data send", "Sent data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isSend = false;
                }
            }
            else
            {
                MessageBox.Show("Please open the COM port first.", "Port Not Open", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSend = false;
            }
        }

        private async void received(System.Windows.Forms.TextBox t)
        {
            BMCSendData();

            if (isSend)
            {
                isSend = false;
                int attemptCount = 0;

                while (attemptCount < maxAttempts)
                {
                    await Task.Run(async () =>
                    {
                        await BMCReceiveData();
                    });

                    if (isReceived)
                    {
                        t.Text = receivedData;
                        isReceived = false;
                        break;
                    }
                    else
                    {
                        await Task.Delay(100);
                        MessageBox.Show($"No. of attempts: {attemptCount}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    attemptCount++;
                }

                if (attemptCount == maxAttempts)
                {
                    MessageBox.Show("Failed to receive data after multiple attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void receivedCombo(System.Windows.Forms.ComboBox t)
        {
            BMCSendData();

            if (isSend)
            {
                isSend = false;
                int attemptCount = 0;

                while (attemptCount < maxAttempts)
                {
                    await Task.Run(async () =>
                    {
                        await BMCReceiveData();
                    });

                    if (isReceived)
                    {
                        t.Text = receivedData;
                        isReceived = false;
                        break;
                    }
                    else
                    {
                        await Task.Delay(100);
                        MessageBox.Show($"No. of attempts: {attemptCount}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    attemptCount++;
                }

                if (attemptCount == maxAttempts)
                {
                    MessageBox.Show("Failed to receive data after multiple attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void send()
        {
            BMCSendData();

            if (isSend)
            {
                isSend = false;
                int attemptCount = 0;

                while (attemptCount < maxAttempts)
                {
                    await Task.Run(async () =>
                    {
                        await BMCReceiveData();
                    });

                    if (isReceived)
                    {
                        isReceived = false;
                        break;
                    }
                    else
                    {
                        await Task.Delay(100);
                        MessageBox.Show($"No. of attempts: {attemptCount}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    attemptCount++;
                }

                if (attemptCount == maxAttempts)
                {
                    MessageBox.Show("Failed to receive data after multiple attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Recbtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@BMCODE?" + "\r\n";
                received(bmcBox);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void sndBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@BMCODE " + bmcBox.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void devIdRecBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@DEVICEID?" + "\r\n";
                received(devBox);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void devIdSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@DEVICEID " + devBox.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void qaunRecBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@QUANTY?" + "\r\n";
                received(quanBox);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quanSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@QUANTY " + quanBox.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void partRecBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@PARTQTY?" + "\r\n";
                received(partQtyBox);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void partSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@PAETQTY " + partQtyBox.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dampRecBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@DAMPING?" + "\r\n";
                received(dampBox);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dampSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@DAMPING " + dampBox.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gravityRcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@SPECGRA?" + "\r\n";
                received(spcBox);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void graviySendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@SPECGRA " + spcBox.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numbPartsRcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@NOPART?" + "\r\n";
                received(numPartstxtBox);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numbPartsSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@NOPART " + numPartstxtBox.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RcdTmRcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@RECTIME?" + "\r\n";
                receivedCombo(RcdTmtxt);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RcdTmSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@RECTIME " + RcdTmtxt.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtdRcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@RTDSEL?" + "\r\n";
                receivedCombo(RTDSeltxt);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtdSelSendbtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@RTDSEL " + RTDSeltxt.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sensorrcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@SELINP?" + "\r\n";
                receivedCombo(sensortxt);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sensorSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@SELINP " + sensortxt.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtc1RcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@VDRTD1?" + "\r\n";
                receivedCombo(RTC1txt);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtc1SendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@VDRTD1 " + RTC1txt.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtc2RcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@VDRTD2?" + "\r\n";
                receivedCombo(rtc2txt);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtc2SendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@VDRTD2 " + rtc2txt.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minRcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@TIMEMIN?" + "\r\n";
                received(mintxt);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@TIMEMIN " + mintxt.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hrRcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@TIMEHRS?" + "\r\n";
                received(hrtxt);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hrSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@TIMEHRS " + hrtxt.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtRcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@TIMEDOM?" + "\r\n";
                received(dttxt);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@TIMEDOM " + dttxt.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void monRcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@TIMEMON?" + "\r\n";
                received(montxt);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void monSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@TIMEMON " + montxt.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yrRcvBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@TIMEYRS?" + "\r\n";
                received(yrtxt);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yrSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@TIMEYRS " + yrtxt.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s1minvoltRcv_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MINVLT1?" + "\r\n";
                received(s1minvoltTXT);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s1minvoltSend_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MINVLT1 " + s1minvoltTXT.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s2minvoltRcv_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MINVLT2?" + "\r\n";
                received(s2minvoltTXT);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s2minvoltSend_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MINVLT2 " + s2minvoltTXT.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s1maxvoltRcv_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MAXVLT1?" + "\r\n";
                received(s1maxvoltTXT);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s1maxvoltSend_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MAXVLT1 " + s1maxvoltTXT.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s2maxvoltRcv_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MAXVLT2?" + "\r\n";
                received(s2maxvoltTXT);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s2maxvoltSend_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MAXVLT2 " + s2maxvoltTXT.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s1minvalRcv_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MINVLU1?" + "\r\n";
                received(s1minvalTXT);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s1minvalSend_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MINVLU1 " + s1minvalTXT.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s2minvalRcv_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MINVLU2?" + "\r\n";
                received(s2minvalTXT);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s2minvalSend_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MINVLU2 " + s2minvalTXT.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s1maxvalRcv_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MAXVLU1?" + "\r\n";
                received(s1maxvalTXT);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s1maxvalSend_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MAXVLU1 " + s1maxvalTXT.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s2maxvalRcv_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MAXVLU2?" + "\r\n";
                received(s2maxvalTXT);
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s2maxvalSend_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                dataToSend = "@MAXVLU2 " + s2maxvalTXT.Text + "\r\n";
                send();
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            OpenFileDialog dilg = new OpenFileDialog();
            dilg.Filter = "Excel Sheet(*.xlsx | *.xlsx | All Files(*.*) | *.*";
            if (dilg.ShowDialog() == DialogResult.OK)
            {

                string filepath = dilg.FileName;
                filepathText.Text = filepath;
                string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties='Excel 8.0;HDR={1}'";
                conn = string.Format(conn, filepath, "yes");
                OleDbConnection excelconnection = new OleDbConnection(conn);
                excelconnection.Open();
                DataTable dtexcel = excelconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string excelsheet = dtexcel.Rows[0]["TABLE_NAME"].ToString();
                OleDbCommand command = new OleDbCommand("Select * from [" + excelsheet + "]", excelconnection);
                OleDbDataAdapter oda = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                excelconnection.Close();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        dataGridView.Rows[i].Cells[j].Value = dt.Rows[i][j];
                    }
                }

            }
        }


        private async void tblRecBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                for (int i = 0; i <= 19; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        int k = i * 10 + j + 1;
                        String formattedk = k.ToString("D3");
                        dataToSend = "@TBL" + formattedk + "?" + "\r\n";
                        BMCSendData();

                        if (isSend)
                        {
                            isSend = false;
                            int attemptCount = 0;

                            while (attemptCount < maxAttempts)
                            {
                                await Task.Run(async () =>
                                {
                                    await BMCReceiveData();
                                });

                                if (isReceived)
                                {
                                    string[] parts = receivedData.Split(',');
                                    if (parts.Length >= 2)
                                    {
                                        string n2Value = parts[1];
                                        dataGridView.Rows[i].Cells[j].Value = n2Value;
                                        isReceived = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    await Task.Delay(100);
                                    MessageBox.Show($"No. of attempts: {attemptCount}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                attemptCount++;
                            }

                            if (attemptCount == maxAttempts)
                            {
                                MessageBox.Show("Failed to receive data after multiple attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void tblSendBtn_Click(object sender, EventArgs e)
        {
            if (isPortOpen)
            {
                for (int i = 0; i <= 19; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        int k = i * 10 + j + 1;
                        String formattedk = k.ToString("D3");
                        dataToSend = "@TBL" + formattedk + " " + dataGridView.Rows[i].Cells[j].Value + "\r\n";
                        BMCSendData();

                        if (isSend == true)
                        {
                            isSend = false;
                            int attemptCount = 0;


                            while (attemptCount < maxAttempts)
                            {
                                await Task.Run(async () =>
                                {
                                    await BMCReceiveData();
                                });


                                if (isReceived)
                                {
                                    isReceived = false;
                                    break;
                                }
                                else
                                {
                                    await Task.Delay(100);
                                    MessageBox.Show($"No. of attempts: {attemptCount}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                attemptCount++;
                            }
                            if (attemptCount == maxAttempts)
                            {
                                MessageBox.Show("Failed to receive data after multiple attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Open COM PORT first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var worksheet = wb.Worksheets.Add("BMC");

                            // Header row
                            for (int i = 0; i <= 9; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataGridView.Columns[i].HeaderText;
                            }

                            // Data rows
                            for (int i = 0; i <= 19; i++)
                            {
                                for (int j = 0; j <= 9; j++)
                                {
                                    if (dataGridView.Rows[i].Cells[j].Value != null)
                                    {
                                        worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value.ToString();
                                    }
                                }
                            }

                            wb.SaveAs(sfd.FileName);
                            MessageBox.Show("Data exported to XLSX successfully!", "Export to XLSX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
