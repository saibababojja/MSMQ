using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Message = System.Messaging.Message;
using System.Messaging;
using System.IO;
using System.Xml;

namespace MSMQOperationsTest
{
    public partial class frmMSMQ : Form
    {
        public frmMSMQ()
        {
            InitializeComponent();
        }

        private readonly string _messageQueueName = @".\Private$\";
        MessageQueue _inputMessageQueue;
        private void PushBtn_Click(object sender, EventArgs e)
        {
            if (MessageQueue.Exists(_messageQueueName + txtMSMQName.Text))
            {
                _inputMessageQueue = new MessageQueue(_messageQueueName + txtMSMQName.Text)
                {
                    //Formatter = new XmlMessageFormatter(new[] { typeof(Message) }),
                    DefaultPropertiesToSend = { Recoverable = true }
                };
                var message = new Message
                {
                    Body = txtInputData.Text
                };
                _inputMessageQueue.Send(message);
                MessageBox.Show("Message pushed");
            }
        }

        private void PopBtn_Click(object sender, EventArgs e)
        {
            var message = _inputMessageQueue.Receive(new TimeSpan(0, 0, 5));
            if (message == null)
                MessageBox.Show("No new Messages in Queue");
            else
            {
                var reader = new StreamReader(message.BodyStream);
                var doc = new XmlDocument { XmlResolver = null };
                doc.Load(reader);
                var zipfile = doc["string"];
                MessageBox.Show(zipfile.InnerText);
            }
        }
    }
}
