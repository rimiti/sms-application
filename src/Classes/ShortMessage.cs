using System;
using System.Collections.Generic;
using System.Text;

namespace SMSapplication
{
	public class ShortMessage
    {

        #region Private Variables
        private string index;
		private string status;
		private string sender;
		private string alphabet;
		private string sent;
		private string message;
        #endregion

        #region Public Properties
        public string Index
		{
			get { return index;}
			set { index = value;}
		}
		public string Status
		{
			get { return status;}
			set { status = value;}
		}
		public string Sender
		{
			get { return sender;}
			set { sender = value;}
		}
		public string Alphabet
		{
			get { return alphabet;}
			set { alphabet = value;}
		}
		public string Sent
		{
			get { return sent;}
			set { sent = value;}
		}
		public string Message
		{
			get { return message;}
			set { message = value;}
        }
        #endregion

    }

    public class ShortMessageCollection : List<ShortMessage>
    {
    }
}
