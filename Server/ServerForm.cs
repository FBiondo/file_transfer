using Opc.Ua.Configuration;
using Opc.Ua.Server;
using Opc.Ua;
using System.Windows.Forms;
using System.Reflection;
using System;
using System.Linq;
using System.Text;

namespace Server {
    public partial class ServerForm : Form {

        private ApplicationInstance m_application;
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        //private NotifyIcon TrayIcon;

        public ServerForm() {
            InitializeComponent();
        }

        public ServerForm(ApplicationInstance application) {
            InitializeComponent();

            m_application = application;
            m_server = application.Server as StandardServer;
            m_configuration = application.ApplicationConfiguration;

            // add the urls to the drop down.
            comboBox1.Items.Clear();

            foreach (EndpointDescription endpoint in m_server.GetEndpoints()) {
                if (comboBox1.FindStringExact(endpoint.EndpointUrl) == -1) {
                    comboBox1.Items.Add(endpoint.EndpointUrl);
                }
            }

            if (comboBox1.Items.Count > 0) {
                comboBox1.SelectedIndex = 0;
            }


        }
    }
}
