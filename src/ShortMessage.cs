using System;
using System.Collections.Generic;
using System.Text;

namespace MY_SMS_Application
{
	public class ShortMessage
	{
		private int index;
		private string status;
		private string sender;
		private string alphabet;
		private string sent;
		private string message;

		public int Index
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
	}

    public class ShortMessageCollection : List<ShortMessage>
    {
    }
}
