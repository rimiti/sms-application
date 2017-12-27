using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

namespace MY_SMS_Application
{
    public class clsSMS
    {
        //Open Port
        public SerialPort OpenPort(string strPortName, string strBaudRate)
        {
            receiveNow = new AutoResetEvent(false);
            SerialPort port = new SerialPort();
            port.PortName = strPortName;
            port.BaudRate = Convert.ToInt32(strBaudRate);               //updated by Anila (9600)
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            port.Parity = Parity.None;
            port.ReadTimeout = 300;
            port.WriteTimeout = 300;
            port.Encoding = Encoding.GetEncoding("iso-8859-1");
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.Open();
            port.DtrEnable = true;
            port.RtsEnable = true;
            return port;
        }

        //Close Port
        public void ClosePort(SerialPort port)
        {
            port.Close();
            port.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
            port = null;
        }

        //Execute AT Command
        public string ExecCommand(SerialPort port,string command, int responseTimeout, string errorMessage)
        {
            try
            {
                // receiveNow = new AutoResetEvent();
                port.DiscardOutBuffer();
                port.DiscardInBuffer();
                receiveNow.Reset();
                port.Write(command + "\r");

                //Thread.Sleep(3000); //3 seconds
                string input = ReadResponse(port, responseTimeout);
                if ((input.Length == 0) || ((!input.EndsWith("\r\n> ")) && (!input.EndsWith("\r\nOK\r\n"))))
                    throw new ApplicationException("No success message was received.");
                return input;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(errorMessage, ex);
            }
        }   

        //Receive data from port
        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (e.EventType == SerialData.Chars)
                receiveNow.Set();
        }
        public string ReadResponse(SerialPort port,int timeout)
        {
            string buffer = string.Empty;
            do
            {
                if (receiveNow.WaitOne(timeout, false))
                {
                    string t = port.ReadExisting();
                    buffer += t;
                }
                else
                {
                    if (buffer.Length > 0)
                        throw new ApplicationException("Response received is incomplete.");
                    else
                        throw new ApplicationException("No data received from phone.");
                }
            }
            while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n"));
            return buffer;
        }
     

        #region Read SMS
        
        public AutoResetEvent receiveNow;

        public ShortMessageCollection ReadSMS(SerialPort port,string strPortName,string strBaudRate)
        {

            //lvwMessages.Items.Clear();
            //Update();

            // Set up the phone and read the messages
            ShortMessageCollection messages = null;
            try
            {
                #region Open Port
                //this.port = OpenPort(strPortName, strBaudRate);
                #endregion

                #region Execute Command
                // Check connection
                ExecCommand(port,"AT", 300, "No phone connected at " + strPortName + ".");
                // Use message format "Text mode"
                ExecCommand(port,"AT+CMGF=1", 300, "Failed to set message format.");
                // Use character set "ISO 8859-1"
                //ExecCommand("AT+CSCS=\"8859-1\"", 300, "Failed to set character set."); //error
                ExecCommand(port,"AT+CSCS=\"PCCP437\"", 300, "Failed to set character set.");
                // Select SIM storage
                ExecCommand(port,"AT+CPMS=\"SM\"", 300, "Failed to select message storage.");
                // Read the messages
                string input = ExecCommand(port,"AT+CMGL=\"ALL\"", 5000, "Failed to read the messages.");
                #endregion

                #region Parse messages
                messages = ParseMessages(input);
                #endregion

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (port != null)
                {
                    #region Close Port
                    //ClosePort(this.port);
                    //port.Close();
                    //port.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
                    //this.port = null;
                    #endregion
                }
            }

            if (messages != null)
                return messages;
            else
                return null;
            //DisplayMessages(messages);
        }
        public ShortMessageCollection ParseMessages(string input)
        {
            ShortMessageCollection messages = new ShortMessageCollection();
            Regex r = new Regex(@"\+CMGL: (\d+),""(.+)"",""(.+)"",(.*),""(.+)""\r\n(.+)\r\n");
            Match m = r.Match(input);
            while (m.Success)
            {
                ShortMessage msg = new ShortMessage();
                msg.Index = int.Parse(m.Groups[1].Value);
                msg.Status = m.Groups[2].Value;
                msg.Sender = m.Groups[3].Value;
                msg.Alphabet = m.Groups[4].Value;
                msg.Sent = m.Groups[5].Value;
                msg.Message = m.Groups[6].Value;
                messages.Add(msg);

                m = m.NextMatch();
            }

            return messages;
        }

        #endregion

        #region Send SMS
       
        static AutoResetEvent readNow = new AutoResetEvent(false);

        public bool sendMsg(SerialPort port,string strPortName, string strBaudRate, string PhoneNo, string Message)
        {
            bool isSend = false;
            try
            {
                
                //this.port = OpenPort(strPortName,strBaudRate);
                string recievedData = ExecCommand(port,"AT", 300, "No phone connected at " + strPortName + ".");
                recievedData = ExecCommand(port,"AT+CMGF=1", 300, "Failed to set message format.");
                String command = "AT+CMGS=\"" + PhoneNo + "\"";
                recievedData = ExecCommand(port,command, 300, "Failed to accept phoneNo");         
                command = Message + char.ConvertFromUtf32(26) + "\r";
                recievedData = ExecCommand(port,command, 3000, "Failed to send message"); //3 seconds
                if (recievedData.EndsWith("\r\nOK\r\n"))
                {
                    recievedData = "Message sent successfully";
                    isSend = true;
                }
                else if (recievedData.Contains("ERROR"))
                {
                    string recievedError = recievedData;
                    recievedError = recievedError.Trim();
                    recievedData = "Following error occured while sending the message" + recievedError;
                    isSend = false;
                }
                return isSend;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (port != null)
                {
                    //port.Close();
                    //port.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
                    //port = null;
                }
            }
        }     
        static void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (e.EventType == SerialData.Chars)
                readNow.Set();
        }

        #endregion

        #region Delete SMS
        public void DeleteMsg(SerialPort port,string strPortName, string strBaudRate)
        {
            try
            {
                #region Open Port
                //this.port = OpenPort(strPortName,strBaudRate);
                #endregion

                #region Execute Command
                string recievedData = ExecCommand(port,"AT", 300, "No phone connected at " + strPortName + ".");
                recievedData = ExecCommand(port,"AT+CMGF=1", 300, "Failed to set message format.");              
                String command = "AT+CMGD=1,3";
                recievedData = ExecCommand(port,command, 300, "Failed to delete message");
                #endregion

                if (recievedData.EndsWith("\r\nOK\r\n"))
                    recievedData = "Message delete successfully";
                if (recievedData.Contains("ERROR"))
                {
                    string recievedError = recievedData;
                    recievedError = recievedError.Trim();
                    recievedData = "Following error occured while sending the message" + recievedError;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (port != null)
                {
                    #region Close Port
                    //port.Close();
                    //port.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
                    //port = null;
                    #endregion
                }
            }
        }  
        #endregion

    }
}
