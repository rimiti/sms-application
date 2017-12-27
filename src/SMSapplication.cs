using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SMSapplication.Classes;
using System.Threading;

namespace SMSapplication
{
    public partial class SMSapplication : Form
    {
        private SynchronizationContext context = null;

        #region Constructor
        public SMSapplication()
        {
            InitializeComponent();
            this.countSMSok.Text = "0";
            this.context = WindowsFormsSynchronizationContext.Current;
        }
        #endregion

        #region Private Variables
        SerialPort port1 = new SerialPort();
        SerialPort port2 = new SerialPort();
        SerialPort port3 = new SerialPort();
        SerialPort port4 = new SerialPort();
        int multiSim;
        clsSMS objclsSMS = new clsSMS();
        Thread t;
        clsWorker objclsWorker;
        ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();
        #endregion

        #region Private Methods

        #region Write StatusBar
        private void WriteStatusBar(string status)
        {
            try
            {
                statusBar1.Text = "Message: " + status;
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }
        #endregion
        
        #endregion

        #region Private Events

        private void SMSapplication_Load(object sender, EventArgs e)
        {
            try
            {
                #region Display all available COM Ports
                string[] ports = SerialPort.GetPortNames();

                // Add all port names to the combo box:
                foreach (string port in ports)
                {
                    this.cboPortName.Items.Add(port);

                    // Multi Sim 2 ports
                    this.cboPortName2P1.Items.Add(port);
                    this.cboPortName2P2.Items.Add(port);

                    // Multi Sim 4 ports
                    this.cboPortName4P1.Items.Add(port);
                    this.cboPortName4P2.Items.Add(port);
                    this.cboPortName4P3.Items.Add(port);
                    this.cboPortName4P4.Items.Add(port);
                }
                #endregion

                //Remove tab pages
                this.tabSMSapplication.TabPages.Remove(tbSendSMS);
                this.tabSMSapplication.TabPages.Remove(tbReadSMS);
                this.tabSMSapplication.TabPages.Remove(tbDeleteSMS);
                this.tabSMSapplication.TabPages.Remove(tbRequestSMS);

                // Set enabled the button
                this.btnRequestStop.Enabled = false;

                this.btnDisconnect.Enabled = false;
            }
            catch(Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        #region Display initialization of the port will be use
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {

                // Si on utilise 4 Sim
                if (this.checkBPort4.Checked)
                {

                    // On d�finit les 4 ports
                    this.port1 = objclsSMS.OpenPort(this.cboPortName4P1.Text, Convert.ToInt32(this.cboBaudRate.Text), Convert.ToInt32(this.cboDataBits.Text), Convert.ToInt32(this.txtReadTimeOut.Text), Convert.ToInt32(this.txtWriteTimeOut.Text));
                    this.port2 = objclsSMS.OpenPort(this.cboPortName4P2.Text, Convert.ToInt32(this.cboBaudRate.Text), Convert.ToInt32(this.cboDataBits.Text), Convert.ToInt32(this.txtReadTimeOut.Text), Convert.ToInt32(this.txtWriteTimeOut.Text));
                    this.port3 = objclsSMS.OpenPort(this.cboPortName4P3.Text, Convert.ToInt32(this.cboBaudRate.Text), Convert.ToInt32(this.cboDataBits.Text), Convert.ToInt32(this.txtReadTimeOut.Text), Convert.ToInt32(this.txtWriteTimeOut.Text));
                    this.port4 = objclsSMS.OpenPort(this.cboPortName4P4.Text, Convert.ToInt32(this.cboBaudRate.Text), Convert.ToInt32(this.cboDataBits.Text), Convert.ToInt32(this.txtReadTimeOut.Text), Convert.ToInt32(this.txtWriteTimeOut.Text));

                    if (this.port1 != null || this.port2 != null || this.port3 != null || this.port4 != null)
                    {
                        this.gboPortSettings.Enabled = false;

                        // Modem connect� aux 4 ports
                        this.statusBar1.Text = "Modem is connected at PORT " + this.cboPortName4P1.Text + " & " + this.cboPortName4P2.Text + " & " + this.cboPortName4P3.Text + " & " + this.cboPortName4P4.Text;

                        //Add tab pages
                        this.tabSMSapplication.TabPages.Add(tbSendSMS);
                        this.tabSMSapplication.TabPages.Add(tbReadSMS);
                        this.tabSMSapplication.TabPages.Add(tbDeleteSMS);
                        this.tabSMSapplication.TabPages.Add(tbRequestSMS);

                        this.lblConnectionStatus.Text = "Connected at " + this.cboPortName4P1.Text + " & " + this.cboPortName4P2.Text + " & " + this.cboPortName4P3.Text + " & " + this.cboPortName4P4.Text;

                        this.btnDisconnect.Enabled = true;
                    }
                    else
                    {
                        if (this.port1 == null)
                            MessageBox.Show("Port " + this.port1.PortName + " verrouill�.");

                        if (this.port2 == null)
                            MessageBox.Show("Port " + this.port2.PortName + " verrouill�.");

                        if (this.port3 == null)
                            MessageBox.Show("Port " + this.port3.PortName + " verrouill�.");

                        if (this.port4 == null)
                            MessageBox.Show("Port " + this.port4.PortName + " verrouill�.");

                        this.statusBar1.Text = "Invalid port settings";
                    }

                }
                // Si on utilise 2 Sim
                else if (this.checkBPort2.Checked)
                {

                    this.port1 = objclsSMS.OpenPort(this.cboPortName2P1.Text, Convert.ToInt32(this.cboBaudRate.Text), Convert.ToInt32(this.cboDataBits.Text), Convert.ToInt32(this.txtReadTimeOut.Text), Convert.ToInt32(this.txtWriteTimeOut.Text));
                    this.port2 = objclsSMS.OpenPort(this.cboPortName2P2.Text, Convert.ToInt32(this.cboBaudRate.Text), Convert.ToInt32(this.cboDataBits.Text), Convert.ToInt32(this.txtReadTimeOut.Text), Convert.ToInt32(this.txtWriteTimeOut.Text));


                    if (this.port1 != null || this.port2 != null)
                    {
                        this.gboPortSettings.Enabled = false;

                        // Modem connect� aux 2 ports
                        this.statusBar1.Text = "Modem is connected at PORT " + this.cboPortName2P1.Text + " & " + this.cboPortName2P2.Text;

                        //Add tab pages
                        this.tabSMSapplication.TabPages.Add(tbSendSMS);
                        this.tabSMSapplication.TabPages.Add(tbReadSMS);
                        this.tabSMSapplication.TabPages.Add(tbDeleteSMS);
                        this.tabSMSapplication.TabPages.Add(tbRequestSMS);

                        this.lblConnectionStatus.Text = "Connected at " + this.cboPortName2P1.Text + " & " + this.cboPortName2P2.Text;

                        this.btnDisconnect.Enabled = true;
                    }

                    else
                    {
                        if (this.port1 == null)
                            MessageBox.Show("Port " + this.port1.PortName + " verrouill�.");

                        if (this.port2 == null)
                            MessageBox.Show("Port " + this.port2.PortName + " verrouill�.");

                        this.statusBar1.Text = "Invalid port settings";
                    }

                }
                else if (this.checkBPort1.Checked)
                {

                    // On d�finit le port
                    this.port1 = objclsSMS.OpenPort(this.cboPortName.Text, Convert.ToInt32(this.cboBaudRate.Text), Convert.ToInt32(this.cboDataBits.Text), Convert.ToInt32(this.txtReadTimeOut.Text), Convert.ToInt32(this.txtWriteTimeOut.Text));

                    if (this.port1 != null)
                    {
                        this.gboPortSettings.Enabled = false;

                        //MessageBox.Show("Modem is connected at PORT " + this.cboPortName.Text);
                        this.statusBar1.Text = "Modem is connected at PORT " + this.cboPortName.Text;

                        //Add tab pages
                        this.tabSMSapplication.TabPages.Add(tbSendSMS);
                        this.tabSMSapplication.TabPages.Add(tbReadSMS);
                        this.tabSMSapplication.TabPages.Add(tbDeleteSMS);
                        this.tabSMSapplication.TabPages.Add(tbRequestSMS);

                        this.lblConnectionStatus.Text = "Connected at " + this.cboPortName.Text;

                        this.btnDisconnect.Enabled = true;
                    }
                    else
                    {
                        if (this.port1 == null)
                            MessageBox.Show("Port " + this.port1.PortName + " verrouill�.");

                        this.statusBar1.Text = "Invalid port settings";
                    }

                }
                else if (!this.checkBPort1.Checked && !this.checkBPort4.Checked && !this.checkBPort2.Checked)
                    MessageBox.Show("How many Sim do you want to use ?");

            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }

        }
        #endregion

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            
            if (this.multiSim == 4)
            {
                objclsSMS.ClosePort(this.port1);
                objclsSMS.ClosePort(this.port2);
                objclsSMS.ClosePort(this.port3);
                objclsSMS.ClosePort(this.port4);
            }
        


            try
            {
                this.gboPortSettings.Enabled = true;
                objclsSMS.ClosePort(this.port1);

                //Remove tab pages
                this.tabSMSapplication.TabPages.Remove(tbSendSMS);
                this.tabSMSapplication.TabPages.Remove(tbReadSMS);
                this.tabSMSapplication.TabPages.Remove(tbDeleteSMS);
                this.tabSMSapplication.TabPages.Remove(tbRequestSMS);

                this.lblConnectionStatus.Text = "Not Connected";
                this.btnDisconnect.Enabled = false;

            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        private void btnSendSMS_Click(object sender, EventArgs e)
        {

            //.............................................. Send SMS ....................................................
            try
            {

                if (objclsSMS.sendMsg(this.port1, this.txtSIM.Text, this.txtMessage.Text))
                {
                    //MessageBox.Show("Message has sent successfully");
                    this.statusBar1.Text = "Message has sent successfully";
                }
                else
                {
                    //MessageBox.Show("Failed to send message");
                    this.statusBar1.Text = "Failed to send message";
                }
                
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }
        private void btnReadSMS_Click(object sender, EventArgs e)
        {
            try
            {
               

                //count SMS 
                int uCountSMS = objclsSMS.CountSMSmessages(this.port1);
                if (uCountSMS > 0)
                {

                    #region Command
                    string strCommand = "AT+CMGL=\"ALL\"";

                    if (this.rbReadAll.Checked)
                    {
                        strCommand = "AT+CMGL=\"ALL\"";
                    }
                    else if (this.rbReadUnRead.Checked)
                    {
                        strCommand = "AT+CMGL=\"REC UNREAD\"";
                    }
                    else if (this.rbReadStoreSent.Checked)
                    {
                        strCommand = "AT+CMGL=\"STO SENT\"";
                    }
                    else if (this.rbReadStoreUnSent.Checked)
                    {
                        strCommand = "AT+CMGL=\"STO UNSENT\"";
                    }
                    #endregion

                    // If SMS exist then read SMS
                    #region Read SMS
                    //.............................................. Read all SMS ....................................................
                    objShortMessageCollection = objclsSMS.ReadSMS(this.port1, strCommand);
                    foreach (ShortMessage msg in objShortMessageCollection)
                    {
                        
                        ListViewItem item = new ListViewItem(new string[] { msg.Index, msg.Sent, msg.Sender, msg.Message });
                        item.Tag = msg;
                        lvwMessages.Items.Add(item);

                    }
                    #endregion

                }
                else
                {
                    lvwMessages.Clear();
                    //MessageBox.Show("There is no message in SIM");
                    this.statusBar1.Text = "There is no message in SIM";
                    
                }
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }
        private void btnDeleteSMS_Click(object sender, EventArgs e)
        {
            try
            {
                //Count SMS 
                int uCountSMS = objclsSMS.CountSMSmessages(this.port1);
                if (uCountSMS > 0)
                {
                    DialogResult dr = MessageBox.Show("Are u sure u want to delete the SMS?", "Delete confirmation", MessageBoxButtons.YesNo);

                    if (dr.ToString() == "Yes")
                    {
                        #region Delete SMS

                        if (this.rbDeleteAllSMS.Checked)
                        {                           
                            //...............................................Delete all SMS ....................................................

                            #region Delete all SMS
                            string strCommand = "AT+CMGD=1,4";
                            if (objclsSMS.DeleteMsg(this.port1, strCommand))
                            {
                                //MessageBox.Show("Messages has deleted successfuly ");
                                this.statusBar1.Text = "Messages has deleted successfuly";
                            }
                            else
                            {
                                //MessageBox.Show("Failed to delete messages ");
                                this.statusBar1.Text = "Failed to delete messages";
                            }
                            #endregion
                            
                        }
                        else if (this.rbDeleteReadSMS.Checked)
                        {                          
                            //...............................................Delete Read SMS ....................................................

                            #region Delete Read SMS
                            string strCommand = "AT+CMGD=1,3";
                            if (objclsSMS.DeleteMsg(this.port1, strCommand))
                            {
                                //MessageBox.Show("Messages has deleted successfuly");
                                this.statusBar1.Text = "Messages has deleted successfuly";
                            }
                            else
                            {
                                //MessageBox.Show("Failed to delete messages ");
                                this.statusBar1.Text = "Failed to delete messages";
                            }
                            #endregion

                        }

                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }

        }
        private void btnCountSMS_Click(object sender, EventArgs e)
        {
            try
            {
                //Count SMS
                int uCountSMS = objclsSMS.CountSMSmessages(this.port1);
                this.txtCountSMS.Text = uCountSMS.ToString();
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        #endregion

        #region Error Log
        public void ErrorLog(string Message)
        {
            StreamWriter sw = null;

            try
            {
                WriteStatusBar(Message);

                string sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";
                //string sPathName = @"E:\";
                string sPathName = @"SMSapplicationErrorLog_";

                string sYear = DateTime.Now.Year.ToString();
                string sMonth = DateTime.Now.Month.ToString();
                string sDay = DateTime.Now.Day.ToString();

                string sErrorTime = sDay + "-" + sMonth + "-" + sYear;

                sw = new StreamWriter(sPathName + sErrorTime + ".txt", true);

                sw.WriteLine(sLogFormat + Message);
                sw.Flush();

            }
            catch (Exception ex)
            {
                ErrorLog(ex.ToString());
            }
            finally
            {
                if (sw != null)
                {
                    sw.Dispose();
                    sw.Close();
                }
            }
            
        }
        #endregion 


        // Print message: Permet des modification sur UI via le thread
        private void updateMessageViewSync(object o)
        {
            string label = o as string;
            this.lblMsgView.Text = label;
        }

        // Print message: Affiche la derni�re r�ponse du modem
        public void updateMessageView(String msg)
        {
            this.context.Post(new SendOrPostCallback(updateMessageViewSync), msg);
        }

        // Compte le nombre de SMS envoy� et non-envoy�
        public void updateCountSMS(String label)
        {
            this.context.Post(new SendOrPostCallback(updateCountSMSSync), label);
        }

        // Count SMS : Permet des modification sur UI via le thread
        private void updateCountSMSSync(object o)
        {
            string label = o as string;
            int num;

            if (label == this.countSMSok.Name.ToString())
            {
                if (int.TryParse(this.countSMSok.Text.ToString(), out num))
                {
                    this.countSMSok.Text = (++num).ToString();
                }
            }
            else if (label == this.countSMSnok.Name.ToString())
            {
                if (int.TryParse(this.countSMSnok.Text.ToString(), out num))
                {
                    this.countSMSnok.Text = (++num).ToString();
                }
            }
        }

        public void simStatusView(string simStatus)
        {
            this.context.Post(new SendOrPostCallback(simStatusViewSync), simStatus);
        }

        private void simStatusViewSync(object o)
        {
            string simStatus = o as string;
            string[] data = simStatus.Split(new string[] { "-" }, StringSplitOptions.None);
            //MessageBox.Show(simStatus);
            this.lblSimStatusErrors.Text = data[2] + "\n" + data[5] + "\n" + data[8] + "\n" + data[11];
            this.lblSimStatus.Text = data[1] + "\n" + data[4] + "\n" + data[7] + "\n" + data[10];
            this.lblSimStatusName.Text = data[0] + "\n" + data[3] + "\n" + data[6] + "\n" + data[9];

            
        }

        // Error notification: Permet des modification sur UI via le thread
        private void updateNotificationSync(object o)
        {
            string label = o as string;
            this.labelCurrentPortError.Text = label;
        }

        // Error notification: Affiche la derni�re r�ponse du modem
        public void updateNotification(String error)
        {
            this.context.Post(new SendOrPostCallback(updateNotificationSync), error);
        }

        // Current port : Permet des modification sur UI via le thread
        private void updateCurrentPortSync(object o)
        {
            string label = o as string;
            this.labelCurrentPort.Text = label;     
        }

        // Affiche le port courrant
        public void updateCurrentPort(String portName)
        {
            this.context.Post(new SendOrPostCallback(updateCurrentPortSync), portName);
        }

        // Lancement du thread
        private void btnRequestStart_Click(object sender, EventArgs e)
        {
            this.btnRequestStart.Enabled = false;
            this.btnRequestStop.Enabled = true;

            if(this.multiSim == 1)
                objclsWorker = new clsWorker(app: this, urlChamp: this.urlChecker.Text, intervalSendSMS: Convert.ToInt32(this.intervalSendSMS.Value), ErreurLimiteAvantBlocage: Convert.ToInt32(this.nbErrorToSwitch.Value), serialPort1: this.port1);
            else if(this.multiSim == 2)
                objclsWorker = new clsWorker(app: this, urlChamp: this.urlChecker.Text, intervalSendSMS: Convert.ToInt32(this.intervalSendSMS.Value), ErreurLimiteAvantBlocage: Convert.ToInt32(this.nbErrorToSwitch.Value), serialPort1: this.port1, serialPort2: this.port2);
            else if(this.multiSim == 4)
                objclsWorker = new clsWorker(app: this, urlChamp:this.urlChecker.Text, intervalSendSMS: Convert.ToInt32(this.intervalSendSMS.Value), ErreurLimiteAvantBlocage: Convert.ToInt32(this.nbErrorToSwitch.Value),  serialPort1: this.port1, serialPort2: this.port2, serialPort3: this.port3, serialPort4: this.port4);
            
            this.objclsWorker.StartThreadTimer();
            
        }

        // Arret du thread
        private void btnRequestStop_Click(object sender, EventArgs e)
        {
            this.btnRequestStart.Enabled = true;
            this.btnRequestStop.Enabled = false;
            this.objclsWorker.StopThreadTimer();
        }

        // CheckBox : Si on utilise 1 Sim
        private void checkBPort2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBPort1.Checked)
            {
                this.checkBPort2.Checked = false;
                this.checkBPort4.Checked = false;
                this.checkBPort2.Enabled = false;
                this.checkBPort4.Enabled = false;
                this.cboPortName.Enabled = true;
                this.cboPortName2P1.Enabled = false;
                this.cboPortName2P2.Enabled = false;
                this.cboPortName4P1.Enabled = false;
                this.cboPortName4P2.Enabled = false;
                this.cboPortName4P3.Enabled = false;
                this.cboPortName4P4.Enabled = false;
                this.multiSim = 1;
            }
            else if (!this.checkBPort1.Checked)
            {

                this.checkBPort2.Enabled = true;
                this.checkBPort4.Enabled = true;
                this.cboPortName.Enabled = true;
                this.cboPortName2P1.Enabled = true;
                this.cboPortName2P2.Enabled = true;
                this.cboPortName4P1.Enabled = true;
                this.cboPortName4P2.Enabled = true;
                this.cboPortName4P3.Enabled = true;
                this.cboPortName4P4.Enabled = true;
                this.multiSim = 0;

            }
        }
  
        // CheckBox : Si on utilise 2 Sim
        private void checkBPort2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.checkBPort2.Checked)
            {
                this.checkBPort1.Enabled = false;
                this.checkBPort4.Enabled = false;
                this.cboPortName.Enabled = false;
                this.cboPortName2P1.Enabled = true;
                this.cboPortName2P2.Enabled = true;
                this.cboPortName4P1.Enabled = false;
                this.cboPortName4P2.Enabled = false;
                this.cboPortName4P3.Enabled = false;
                this.cboPortName4P4.Enabled = false;
                this.multiSim = 2;
            }
            else if (!this.checkBPort2.Checked)
            {
                this.checkBPort1.Enabled = true;
                this.checkBPort4.Enabled = true;
                this.cboPortName.Enabled = true;
                this.cboPortName2P1.Enabled = true;
                this.cboPortName2P2.Enabled = true;
                this.cboPortName4P1.Enabled = true;
                this.cboPortName4P2.Enabled = true;
                this.cboPortName4P3.Enabled = true;
                this.cboPortName4P4.Enabled = true;
                this.multiSim = 0;

            }
        }

        // CheckBox : Si on utilise 4 Sim
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBPort4.Checked)
            {
                this.checkBPort1.Checked = false;
                this.checkBPort2.Checked = false;
                this.checkBPort1.Enabled = false;
                this.checkBPort2.Enabled = false;
                this.cboPortName.Enabled = false;
                this.cboPortName2P1.Enabled = false;
                this.cboPortName2P2.Enabled = false;
                this.cboPortName4P1.Enabled = true;
                this.cboPortName4P2.Enabled = true;
                this.cboPortName4P3.Enabled = true;
                this.cboPortName4P4.Enabled = true;
                this.multiSim = 4;
            }
            else if (!this.checkBPort4.Checked)
            {
                this.checkBPort1.Enabled = true;
                this.checkBPort2.Enabled = true;
                this.cboPortName.Enabled = true;
                this.cboPortName2P1.Enabled = true;
                this.cboPortName2P2.Enabled = true;
                this.cboPortName4P1.Enabled = true;
                this.cboPortName4P2.Enabled = true;
                this.cboPortName4P3.Enabled = true;
                this.cboPortName4P4.Enabled = true;
                this.multiSim = 0;

            }
        }

        // multisim 4: Si on click sur le premier com on coche la checkbox
        private void cboPortName4P1_Click(object sender, EventArgs e)
        {
            this.checkBPort4.Checked = true;
        }

        // multisim 2: Si on click sur le premier com on coche la checkbox
        private void cboPortName2P1_Click(object sender, EventArgs e)
        {
            this.checkBPort2.Checked = true;
        }

        // multisim 1: Si on click sur le premier com on coche la checkbox
        private void cboPortName_Click(object sender, EventArgs e)
        {
            this.checkBPort1.Checked = true;
        }
        

    }
}