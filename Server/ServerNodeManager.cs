using Microsoft.Extensions.Configuration;
using Opc.Ua.Server;
using Opc.Ua;
using System.Collections.Generic;
using OPCUAServer;
using System.Reflection;
using System;

namespace Server {
    class ServerNodeManager : CustomNodeManager2 {

        private MServerConfiguration m_configuration;
        private static OPCUAServerState m_server1;
        private System.Threading.Timer m_simulationTimer;

        public ServerNodeManager(IServerInternal server, ApplicationConfiguration configuration) : base(server, configuration) {
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
            predefinedNodes.LoadFromBinaryResource(context, "..\\..\\ServerModel/Compile/OPCUAServer.PredefinedNodes.uanodes", typeof(ServerNodeManager).GetTypeInfo().Assembly, true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences) {
            lock (Lock) {
                LoadPredefinedNodes(SystemContext, externalReferences);

                // find the untyped Batch Plant 1 node that was created when the model was loaded.
                BaseObjectState passiveNode = (BaseObjectState) FindPredefinedNode(new NodeId(OPCUAServer.Objects.OPCUAServer1, NamespaceIndexes[0]), typeof(BaseObjectState));

                // convert the untyped node to a typed node that can be manipulated within the server.
                m_server1 = new OPCUAServerState(null);
                m_server1.Create(SystemContext, passiveNode);

                // replaces the untyped predefined nodes with their strongly typed versions.
                AddPredefinedNode(SystemContext, m_server1);

                m_server1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                m_server1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);
                m_server1.request.OnCallMethod = new GenericMethodCalledEventHandler(Request);

                m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);

            }
        }

        public void DoSimulation(object state) {
            //m_server1.Machine.Firmware1.FirmwareName = (AnalogItemState<string>) "Prova";
            BaseObjectState passiveNode = (BaseObjectState) FindPredefinedNode(new NodeId(OPCUAServer.Objects.OPCUAServer1, NamespaceIndexes[0]), typeof(BaseObjectState));
            //m_server1.request.Call(SystemContext, passiveNode, )
        }

        private ServiceResult OnStartProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments) {

            return ServiceResult.Good;
        }

        private ServiceResult OnStopProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments) {

            return ServiceResult.Good;
        }


        private ServiceResult Request(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments) {
            String c = (string) inputArguments[0];
            return ServiceResult.Good;
        }
    }
}
