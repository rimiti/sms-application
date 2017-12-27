using System;
using System.Threading;
using System.Net;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO.Ports;
using Newtonsoft.Json.Serialization;
using System.Collections.Specialized;

namespace SMSapplication.Classes
{
    public class clsWorker
    {
        #region attribus
        public SerialPort port1;
        public SerialPort port2;
        public SerialPort port3;
        public SerialPort port4;
        public int operator_bloc_port1 = 0;
        public int operator_bloc_port2 = 0;
        public int operator_bloc_port3 = 0;
        public int operator_bloc_port4 = 0;
        public int ErreurLimiteAvantBlocage;
        public String url;
        public String lastPortUsed;
        public Thread t;
        public Thread t2;
        public clsSMS clsobjSMS;
        public SMSapplication clsobjAPP = null;
        public int multiSim = 0;
        public int numIterations = 0;
        public int nb_sim = 0;
        public int intervalSendSMS;
        public bool siwtchPort = true;
        public bool siwtchPort4 = false;
        public bool timer = true;
        public DateTime compareDate;
        public DateTime systemDate;
        public DateTime razErreur;
        public DateTime dateThreadBorn;
        public OrderedDictionary arrayPortState = new OrderedDictionary();
        public OrderedDictionary arrayPort = new OrderedDictionary();
        #endregion

        public clsWorker(SMSapplication app, String urlChamp, int intervalSendSMS, int ErreurLimiteAvantBlocage, SerialPort serialPort1 = null, SerialPort serialPort2 = null, SerialPort serialPort3 = null, SerialPort serialPort4 = null)
        {
            this.port1 = serialPort1;
            this.port2 = serialPort2;
            this.port3 = serialPort3;
            this.port4 = serialPort4;
            this.url = urlChamp;
            this.intervalSendSMS = intervalSendSMS;
            this.clsobjSMS = new clsSMS(objclsWorker: this);
            this.clsobjAPP = app;
            this.dateThreadBorn = DateTime.Now;
            this.razErreur = DateTime.Now.Date.AddDays(1).AddHours(7).AddMinutes(30);
            this.nb_sim = (this.port1 == null) ? this.nb_sim + 0 : this.nb_sim + 1;
            this.nb_sim = (this.port2 == null) ? this.nb_sim + 0 : this.nb_sim + 1;
            this.nb_sim = (this.port3 == null) ? this.nb_sim + 0 : this.nb_sim + 1;
            this.nb_sim = (this.port4 == null) ? this.nb_sim + 0 : this.nb_sim + 1;

            if (this.nb_sim == 1)
                this.multiSim = 1;
            else if (this.nb_sim == 2)
                this.multiSim = 2;
            else if (this.nb_sim == 4)
            {
                this.multiSim = 4;
                arrayPortState.Add("port1", "OK");
                arrayPortState.Add("port2", "OK");
                arrayPortState.Add("port3", "OK");
                arrayPortState.Add("port4", "OK");
            }
            this.ErreurLimiteAvantBlocage = ErreurLimiteAvantBlocage;
        }

        public void operatorBlocageError38(String port_concerne, bool erreur38)
        {
            if (port_concerne == this.port1.PortName) {
                this.operator_bloc_port1 = (erreur38 == true) ? this.operator_bloc_port1 + 1 : this.operator_bloc_port1 - 1;
                this.operator_bloc_port1 = (erreur38 == false) ? 0 : this.operator_bloc_port1;
                this.operator_bloc_port1 = (this.operator_bloc_port1 < 0) ? 0 : this.operator_bloc_port1;
                if (this.operator_bloc_port1 >= this.ErreurLimiteAvantBlocage)
                    this.arrayPortState["port1"] = "NOK";
            }
            if (port_concerne == this.port2.PortName) {
                this.operator_bloc_port2 = (erreur38 == true) ? this.operator_bloc_port2 + 1 : this.operator_bloc_port2 - 1;
                this.operator_bloc_port2 = (erreur38 == false) ? 0 : this.operator_bloc_port2;
                this.operator_bloc_port2 = (this.operator_bloc_port2 < 0) ? 0 : this.operator_bloc_port2;
                if (this.operator_bloc_port2 >= this.ErreurLimiteAvantBlocage)
                    this.arrayPortState["port2"] = "NOK";
            }
            if (port_concerne == this.port3.PortName) {
                this.operator_bloc_port3 = (erreur38 == true) ? this.operator_bloc_port3 + 1 : this.operator_bloc_port3 - 1;
                this.operator_bloc_port3 = (erreur38 == false) ? 0 : this.operator_bloc_port3;
                this.operator_bloc_port3 = (this.operator_bloc_port3 < 0) ? 0 : this.operator_bloc_port3;
                // Si on a plus de 3 erreurs 38 d'affilé
                if (this.operator_bloc_port3 >= this.ErreurLimiteAvantBlocage)
                    this.arrayPortState["port3"] = "NOK";
            }
            if (port_concerne == this.port4.PortName) {
                this.operator_bloc_port4 = (erreur38 == true) ? this.operator_bloc_port4 + 1 : this.operator_bloc_port4 - 1;
                this.operator_bloc_port4 = (erreur38 == false) ? 0 : this.operator_bloc_port4;
                this.operator_bloc_port4 = (this.operator_bloc_port4 < 0) ? 0 : this.operator_bloc_port4;
                if (this.operator_bloc_port4 >= this.ErreurLimiteAvantBlocage)
                    this.arrayPortState["port4"] = "NOK";
            }
        }

        public void responseModem(String response)
        {
            clsobjAPP.updateNotification(response.Replace("\r\n", " ").Substring(response.IndexOf("www.Texto-SMS-Gratuit.com") + 29) + "\n" + DateTime.Now);
            String msg = response.Substring(0, response.IndexOf("www.Texto-SMS-Gratuit.com"));
            clsobjAPP.updateMessageView(msg);
        }

        public void StartThread()
        {
            t = new Thread(new ThreadStart(ThreadLoop));
            t.Start();
        }

        public void StopThread()
        {
            t.Abort();
        }

        public void StartThreadTimer()
        {
            t2 = new Thread(new ThreadStart(ThreadTimer));
            t2.Start();
        }

        public void StopThreadTimer()
        {
            t2.Abort();
            this.StopThread();
        }

        public void ThreadTimer()
        {
            t = new Thread(new ThreadStart(ThreadTimer));
            compareDate = DateTime.Now.AddMinutes(2);
            systemDate = DateTime.Now;

            while (true) {
                if (this.compareDate < DateTime.Now) {
                    this.StopThread();
                    this.systemDate = DateTime.Now;
                    this.compareDate = DateTime.Now.AddMinutes(2);
                    
                        if ( DateTime.Now > this.razErreur  || DateTime.Now > this.dateThreadBorn.AddHours(1).AddMinutes(10)) {
                            WebClient myWebClient = new WebClient();
                            myWebClient.DownloadString("http://mywebsite.com/notification.php");
                            this.operator_bloc_port1 = 0;
                            this.operator_bloc_port2 = 0;
                            this.operator_bloc_port3 = 0;
                            this.operator_bloc_port4 = 0;
                            this.arrayPortState["port1"] = "OK";
                            this.arrayPortState["port2"] = "OK";
                            this.arrayPortState["port3"] = "OK";
                            this.arrayPortState["port4"] = "OK";
                            clsobjSMS.DeleteMsg(port1, "AT+CMGD=1,4");
                            clsobjSMS.DeleteMsg(port2, "AT+CMGD=1,4");
                            clsobjSMS.DeleteMsg(port3, "AT+CMGD=1,4");
                            clsobjSMS.DeleteMsg(port4, "AT+CMGD=1,4");
                            this.razErreur = DateTime.Now.Date.AddDays(1).AddHours(6).AddMinutes(30);
                            this.dateThreadBorn = DateTime.Now;
                        }

                        if (this.multiSim == 4) {
                            clsobjSMS.setPinCode(this.port1, "1234");
                            clsobjSMS.setPinCode(this.port2, "1234");
                            clsobjSMS.setPinCode(this.port3, "1234");
                            clsobjSMS.setPinCode(this.port4, "1234");
                        }
                } else {
                    if (!t.IsAlive)
                        this.StartThread();
                }
            }
        }

        public void ThreadLoop()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                string number = "";
                string message = "";
                string id = "";
                string send_date = "";
                string hash = "";
                string ip = "";
                string lcHtml = "";

                Thread.Sleep(this.intervalSendSMS*1000);

                try
                {
                    HttpWebRequest loHttp = (HttpWebRequest)WebRequest.Create(this.url);
                    loHttp.Timeout = 6000;
                    loHttp.UserAgent = "SMS Application";
                    HttpWebResponse loWebResponse = (HttpWebResponse)loHttp.GetResponse();
                    Encoding enc = Encoding.GetEncoding(1252);
                    StreamReader loResponseStream = new StreamReader(loWebResponse.GetResponseStream(), enc);

                    lcHtml = loResponseStream.ReadToEnd();

                    if (lcHtml == "null" || lcHtml.Length < 10 || lcHtml == "")
                        continue;

                    if (lcHtml == "<meta http-equiv=\"Refresh\" content=\"0\">")
                        continue;

                    JArray ja = JArray.Parse(lcHtml);

                    id = ja[0]["id"].ToString();

                    WebClient myWebClient = new WebClient();
                    myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=att");

                    number = ja[0]["number"].ToString();
                    message = ja[0]["message"].ToString().Replace("OK", "Ok").Replace("ERROR", "Error");
                    send_date = ja[0]["send_date"].ToString();
                    hash = ja[0]["hash"].ToString();
                    ip = ja[0]["ip"].ToString();
                    
                    loWebResponse.Close();
                    loResponseStream.Close();

                    if (number != "" && message != "" && id != "") {
                        if (message.Length >= 159)
                            message = message.Substring(0, 159);

                        if (number.Length >= 159)
                            number = number.Substring(0, 12);

                        if (number[3].ToString() == "6" || number[3].ToString() == "7") {
                            
                            if (this.multiSim == 4) {
                                if (this.arrayPortState["port1"] == "NOK" && this.arrayPortState["port2"] == "NOK" && this.arrayPortState["port3"] == "NOK" && this.arrayPortState["port4"] == "NOK") {
                                    this.operator_bloc_port1 = 0;
                                    this.operator_bloc_port2 = 0;
                                    this.operator_bloc_port3 = 0;
                                    this.operator_bloc_port4 = 0;
                                    this.arrayPortState["port1"] = "OK";
                                    this.arrayPortState["port2"] = "OK";
                                    this.arrayPortState["port3"] = "OK";
                                    this.arrayPortState["port4"] = "OK";
                                    clsobjSMS.DeleteMsg(port1, "AT+CMGD=1,4");
                                    clsobjSMS.DeleteMsg(port2, "AT+CMGD=1,4");
                                    clsobjSMS.DeleteMsg(port3, "AT+CMGD=1,4");
                                    clsobjSMS.DeleteMsg(port4, "AT+CMGD=1,4");
                                }  

                                if (this.arrayPortState["port1"].ToString() == "OK") {
                                    if (clsobjSMS.sendMsg(this.port1, number, message)) {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=ok");
                                        this.lastPortUsed = this.port1.PortName;
                                        clsobjAPP.updateCurrentPort(this.port1.PortName);
                                        clsobjAPP.updateCountSMS("countSMSok");
                                    } else {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=nok");
                                        this.lastPortUsed = this.port1.PortName;
                                        clsobjAPP.updateCountSMS("countSMSnok");
                                        clsobjAPP.updateCurrentPort(this.port1.PortName);
                                    }
                                } else if (this.arrayPortState["port2"].ToString() == "OK") {
                                    if (clsobjSMS.sendMsg(this.port2, number, message)) {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=ok");
                                        this.lastPortUsed = this.port2.PortName;
                                        clsobjAPP.updateCountSMS("countSMSok");
                                        clsobjAPP.updateCurrentPort(this.port2.PortName);
                                    } else {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=nok");
                                        this.lastPortUsed = this.port2.PortName;
                                        clsobjAPP.updateCountSMS("countSMSnok");
                                        clsobjAPP.updateCurrentPort(this.port2.PortName);
                                    }
                                } else if (this.arrayPortState["port3"].ToString() == "OK") {
                                    if (clsobjSMS.sendMsg(this.port3, number, message)) {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=ok");
                                        this.lastPortUsed = this.port3.PortName;
                                        clsobjAPP.updateCountSMS("countSMSok");
                                        clsobjAPP.updateCurrentPort(this.port3.PortName);
                                    } else {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=nok");
                                        this.lastPortUsed = this.port3.PortName;
                                        clsobjAPP.updateCountSMS("countSMSnok");
                                        clsobjAPP.updateCurrentPort(this.port3.PortName);
                                    }
                                } else if (this.arrayPortState["port4"].ToString() == "OK") {
                                    if (clsobjSMS.sendMsg(this.port4, number, message)) {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=ok");
                                        this.lastPortUsed = this.port4.PortName;
                                        clsobjAPP.updateCountSMS("countSMSok");
                                        clsobjAPP.updateCurrentPort(this.port4.PortName);
                                    } else {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=nok");
                                        this.lastPortUsed = this.port4.PortName;
                                        clsobjAPP.updateCountSMS("countSMSnok");
                                        clsobjAPP.updateCurrentPort(this.port4.PortName);
                                    }
                                }

                                clsobjAPP.simStatusView(this.port1.PortName + "-" + this.arrayPortState["port1"] + "-" + this.operator_bloc_port1 + "-"
                                                      + this.port2.PortName + "-" + this.arrayPortState["port2"] + "-" + this.operator_bloc_port2 + "-"
                                                      + this.port3.PortName + "-" + this.arrayPortState["port3"] + "-" + this.operator_bloc_port3 + "-"
                                                      + this.port4.PortName + "-" + this.arrayPortState["port4"] + "-" + this.operator_bloc_port4);
                            } else if (this.multiSim == 2) {
                                if (this.siwtchPort == true) {
                                    if (clsobjSMS.sendMsg(this.port1, number, message)) {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=ok");
                                        clsobjAPP.updateCountSMS("countSMSok");
                                    } else {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=nok");
                                        this.siwtchPort = false;
                                        clsobjAPP.updateCountSMS("countSMSnok");
                                    }
                                } else {
                                    if (clsobjSMS.sendMsg(this.port2, number, message)) {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=ok");
                                        clsobjAPP.updateCountSMS("countSMSok");
                                    } else {
                                        myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=nok");
                                        this.siwtchPort = true;
                                        clsobjAPP.updateCountSMS("countSMSnok");
                                    }
                                }
                            } else if (this.multiSim == 1) {
                                if (clsobjSMS.sendMsg(this.port1, number, message)) {
                                    myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=ok");
                                    clsobjAPP.updateCountSMS("countSMSok");
                                } else {
                                    myWebClient.DownloadString("http://mywebsite.com/api/sms.php?id=" + id + "&state=nok");
                                    clsobjAPP.updateCountSMS("countSMSnok");
                                }
                            } else {
                                MessageBox.Show("Error, the software don't know the multiSim value.\n multiSim = " + this.multiSim);
                            }
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    // Handle errors
                    DialogResult dr = MessageBox.Show("Erreur: " + ex.Message);
                }
            }
        }
    }
}