using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SMSapplication.Classes;

namespace SMSapplication
{
     public class clsSMS
     {
         public clsWorker objclsWorker;

         public clsSMS(clsWorker objclsWorker = null)
        {
            this.objclsWorker = objclsWorker;
        }

        #region Open and Close Ports
        public SerialPort OpenPort(string p_strPortName, int p_uBaudRate, int p_uDataBits, int p_uReadTimeout, int p_uWriteTimeout)
        {
            receiveNow = new AutoResetEvent(false);
            SerialPort port = new SerialPort();
            try
            {           
                port.PortName = p_strPortName;
                port.BaudRate = p_uBaudRate;
                port.DataBits = p_uDataBits;
                port.StopBits = StopBits.One;
                port.Parity = Parity.None;
                port.ReadTimeout = p_uReadTimeout;
                port.WriteTimeout = p_uWriteTimeout;
                port.Encoding = Encoding.GetEncoding("iso-8859-1");
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                port.Open();
                port.DtrEnable = true;
                port.RtsEnable = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return port;
        }

        //Close Port
        public void ClosePort(SerialPort port)
        {
            try
            {
                port.Close();
                port.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
                port = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        //Execute AT Command
        public string ExecCommand(SerialPort port,string command, int responseTimeout, string errorMessage)
        {
            try
            {
                port.DiscardOutBuffer();
                port.DiscardInBuffer();
                receiveNow.Reset();
                port.Write(command + "\r");
                
                string input = ReadResponse(port, responseTimeout);

                return input;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
        
        //Receive data from port
        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                {
                    receiveNow.Set();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ReadResponse(SerialPort port,int timeout)
        {
            string buffer = string.Empty;
            try
            {    
                do
                {
                        string t = port.ReadExisting();
                        buffer += t;

                        if (buffer.Contains("+CMS ERROR: 38") || buffer.Contains("+CMS ERROR: 512"))
                            this.objclsWorker.operatorBlocageError38(port.PortName, true);

                        if (buffer.Contains("+CMS:") && buffer.Contains("www.")) {
                            this.objclsWorker.operatorBlocageError38(port.PortName, false);
                            this.objclsWorker.responseModem("Notification: " + buffer.Substring(159, buffer.Length).Replace("\n", ""));
                        }

                        if (buffer.Length >= 15 && buffer.Contains("www.website.com") && buffer.Contains("OK")) {
                            this.objclsWorker.operatorBlocageError38(port.PortName, false);
                            this.objclsWorker.responseModem(buffer);
                        }

                }
                while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n") && !buffer.Contains("OK") && !buffer.Contains("ERROR"));
            } catch (Exception ex) {
                throw ex;
            }
            return buffer;
        }

        #region Count SMS
        public int CountSMSmessages(SerialPort port)
        {
            int CountTotalMessages = 0;
            try
            {
                #region Execute Command
                string recievedData = ExecCommand(port, "AT", 300, "No phone connected at ");
                recievedData = ExecCommand(port, "AT+CMGF=1", 300, "Failed to set message format.");
                String command = "AT+CPMS?";
                recievedData = ExecCommand(port, command, 1000, "Failed to count SMS message");
                int uReceivedDataLength = recievedData.Length;

                #endregion

                #region If command is executed successfully
                if ((recievedData.Length >= 45) && (recievedData.StartsWith("AT+CPMS?")))
                {
                    #region Parsing SMS
                    string[] strSplit = recievedData.Split(',');
                    string strMessageStorageArea1 = strSplit[0];
                    string strMessageExist1 = strSplit[1];
                    #endregion

                    #region Count Total Number of SMS In SIM
                    CountTotalMessages = Convert.ToInt32(strMessageExist1);
                    #endregion

                }
                #endregion

                #region If command is not executed successfully
                else if (recievedData.Contains("ERROR"))
                {
                    #region Error in Counting total number of SMS
                    string recievedError = recievedData;
                    recievedError = recievedError.Trim();
                    recievedData = "Following error occured while counting the message" + recievedError;
                    #endregion

                }
                #endregion
                return CountTotalMessages;
            } catch (Exception ex) {
                throw ex;
            }
           
        }
        #endregion

        #region Read SMS

        public AutoResetEvent receiveNow = new AutoResetEvent(false);

        public ShortMessageCollection ReadSMS(SerialPort port, string p_strCommand)
        {
            // Set up the phone and read the messages
            ShortMessageCollection messages = null;
            try
            {
                #region Execute Command
                // Check connection
                ExecCommand(port,"AT", 300, "No phone connected");
                // Use message format "Text mode"
                ExecCommand(port,"AT+CMGF=1", 300, "Failed to set message format.");
                // Use character set "PCCP437"
                ExecCommand(port,"AT+CSCS=\"PCCP437\"", 300, "Failed to set character set.");
                // Select SIM storage
                ExecCommand(port,"AT+CPMS=\"SM\"", 300, "Failed to select message storage.");
                // Read the messages
                string input = ExecCommand(port, p_strCommand, 5000, "Failed to read the messages.");
                #endregion

                #region Parse messages
                messages = ParseMessages(input);
                #endregion

            }
            catch (Exception ex) {
                throw ex;
            }

            if (messages != null)
                return messages;
            else
                return null;
        }
        public ShortMessageCollection ParseMessages(string input)
        {
            ShortMessageCollection messages = new ShortMessageCollection();
            try
            {     
                Regex r = new Regex(@"\+CMGL: (\d+),""(.+)"",""(.+)"",(.*),""(.+)""\r\n(.+)\r\n");
                Match m = r.Match(input);
                while (m.Success)
                {
                    ShortMessage msg = new ShortMessage();
                    //msg.Index = int.Parse(m.Groups[1].Value);
                    msg.Index = m.Groups[1].Value;
                    msg.Status = m.Groups[2].Value;
                    msg.Sender = m.Groups[3].Value;
                    msg.Alphabet = m.Groups[4].Value;
                    msg.Sent = m.Groups[5].Value;
                    msg.Message = m.Groups[6].Value;
                    messages.Add(msg);

                    m = m.NextMatch();
                }

            } catch (Exception ex) {
                throw ex;
            }
            return messages;
        }

        #endregion

        #region Send SMS
       
        static AutoResetEvent readNow = new AutoResetEvent(false);

        public bool sendMsg(SerialPort port, string PhoneNo, string Message)
        {
            bool isSend = false;

            try {
                
                string recievedData = ExecCommand(port,"AT", 300, "No phone connected");
                recievedData = ExecCommand(port,"AT+CMGF=1", 300, "Failed to set message format.");
                String command = "AT+CMGS=\"" + PhoneNo + "\"";
                recievedData = ExecCommand(port,command, 300, "Failed to accept phoneNo");         
                command = Message + char.ConvertFromUtf32(26) + "\r";
                recievedData = ExecCommand(port,command, 3000, "Failed to send message"); //3 seconds
                if (recievedData.EndsWith("\r\nOK\r\n")) {
                    isSend = true;
                } else if (recievedData.Contains("ERROR")) {
                    isSend = false;
                }
                return isSend;
            } catch (Exception ex) {
                throw ex; 
            }
        }

        public bool setPinCode(SerialPort port, string PinCode)
        {
            bool isPin = false;
            try {
                string recievedData = ExecCommand(port, "AT+CPIN=\"" + PinCode + "\"", 6000, "Pin nok");

                if (recievedData.EndsWith("\r\nOK\r\n") || recievedData.Contains("OK")) {
                    isPin = true;
                } else if (recievedData.Contains("ERROR")) {
                    isPin = false;
                } else {
                    isPin = false;
                }
                return isPin;
            } catch (Exception ex) {
                throw ex;
            }

        }

        public bool setViewErrors(SerialPort port)
        {
            bool isCMEE = false;
            try {
                string recievedData = ExecCommand(port, "AT+CMEE=1", 300, "CMEE = 1 NOK");
                if (recievedData.EndsWith("\r\nOK\r\n")) {
                    isCMEE = true;
                } else if (recievedData.Contains("ERROR")) {
                    isCMEE = false;
                } else {
                    isCMEE = false;
                }
                return isCMEE;
            } catch (Exception ex) {
                throw ex;
            }
        }

        static void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try {
                if (e.EventType == SerialData.Chars)
                    readNow.Set();
            } catch (Exception ex) {
                throw ex;
            }
        }
        #endregion

        #region Delete SMS
        public bool DeleteMsg(SerialPort port , string p_strCommand)
        {
            bool isDeleted = false;
            try {

                #region Execute Command
                string recievedData = ExecCommand(port,"AT", 300, "No phone connected");
                recievedData = ExecCommand(port,"AT+CMGF=1", 300, "Failed to set message format.");
                String command = p_strCommand;
                recievedData = ExecCommand(port,command, 300, "Failed to delete message");
                #endregion

                if (recievedData.EndsWith("\r\nOK\r\n")) {
                    isDeleted = true;
                } if (recievedData.Contains("ERROR")) {
                    isDeleted = false;
                }
                return isDeleted;
            } catch (Exception ex) {
                throw ex; 
            }
        }
        #endregion

    }
}
