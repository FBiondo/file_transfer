using Opc.Ua;
using Opc.Ua.Configuration;
using System;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Server {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //ApplicationInstance.MessageDlg = new ApplicationMessageDlg();
            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "Server";

            try {

                // process and command line arguments.
                if (application.ProcessCommandLine()) {
                    return;
                }

                // check if running as a service.
                if (!Environment.UserInteractive) {
                    application.StartAsService(new Server());
                    return;
                }

                // load the application configuration.
                application.LoadApplicationConfiguration(false).Wait();

                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // Create server, add additional node managers
                var server = new Server();

                // start the server.
                application.Start(new Server()).Wait();


                Application.Run(new ServerForm(application));
            }
            catch (Exception e) {
                string text = "Exception: " + e.Message;
                if (e.InnerException != null) {
                    text += "\r\nInner exception: Puzzi";
                    text += e.InnerException.Message;
                    text += "\r" + e.Source;
                }
                MessageBox.Show(text, application.ApplicationName);
            }
        }

    }
}
