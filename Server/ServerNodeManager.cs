using Microsoft.Extensions.Configuration;
using Opc.Ua.Server;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server {
    class ServerNodeManager : CustomNodeManager2 {

        private MServerConfiguration m_configuration;
        private static BatchPlantState m_batchPlant1;
        private System.Threading.Timer m_simulationTimer;

        public ServerNodeManager(IServerInternal server, ApplicationConfiguration configuration) : base (server, configuration) {
            SystemContext.NodeIdFactory = this;

            // set one namespace for the type model and one names for dynamically created nodes.
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = OPCUAServer.Namespaces.OPCUAServer;
            namespaceUrls[1] = OPCUAServer.Namespaces.OPCUAServer + "/Instance";
            SetNamespaces(namespaceUrls);

            // get the configuration for the node manager.
            m_configuration = configuration.ParseExtension<MServerConfiguration>();

            // use suitable defaults if no configuration exists.
            if (m_configuration == null) {
                m_configuration = new MServerConfiguration();
            }
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context) {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "C:/Users/Kudzai/source/repos/BatchPlant/BatchPlant/BatchPlant.PredefinedNodes.uanodes",
                typeof(ServerNodeManager).GetTypeInfo().Assembly,
                true);

            return predefinedNodes;
        }
    }
}
