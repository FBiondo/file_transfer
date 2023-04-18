using System.Runtime.Serialization;
using OPCUAServer;

namespace Server {

    [DataContract(Namespace = Namespaces.OPCUAServer)]
    class MServerConfiguration {
        public MServerConfiguration() {
            Initialize();
        }

        [OnDeserializing()]
        private void Initialize(StreamingContext context) {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize() {
        }
    }
}
