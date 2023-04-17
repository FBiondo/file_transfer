/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OPCUAServer
{
    #region GenericFirmwareState Class
    #if (!OPCUA_EXCLUDE_GenericFirmwareState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericFirmwareState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericFirmwareState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.GenericFirmwareType, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABsA" +
           "AABHZW5lcmljRmlybXdhcmVUeXBlSW5zdGFuY2UBAQEAAQEBAAEAAAD/////AwAAABVgiQoCAAAAAQAM" +
           "AAAARmlybXdhcmVOYW1lAQECAAAvAQBACQIAAAAADP////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQEGAAAuAEQGAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA8AAABGaXJtd2FyZVZl" +
           "cnNpb24BAQgAAC8BAEAJCAAAAAAM/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAQwA" +
           "AC4ARAwAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEQAAAEZpcm13YXJlQnVpbGRUaW1lAQEO" +
           "AAAvAQBACQ4AAAAADf////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQESAAAuAEQSAAAA" +
           "AQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<string> FirmwareName
        {
            get
            {
                return m_firmwareName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_firmwareName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_firmwareName = value;
            }
        }

        /// <remarks />
        public AnalogItemState<string> FirmwareVersion
        {
            get
            {
                return m_firmwareVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_firmwareVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_firmwareVersion = value;
            }
        }

        /// <remarks />
        public AnalogItemState<DateTime> FirmwareBuildTime
        {
            get
            {
                return m_firmwareBuildTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_firmwareBuildTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_firmwareBuildTime = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_firmwareName != null)
            {
                children.Add(m_firmwareName);
            }

            if (m_firmwareVersion != null)
            {
                children.Add(m_firmwareVersion);
            }

            if (m_firmwareBuildTime != null)
            {
                children.Add(m_firmwareBuildTime);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OPCUAServer.BrowseNames.FirmwareName:
                {
                    if (createOrReplace)
                    {
                        if (FirmwareName == null)
                        {
                            if (replacement == null)
                            {
                                FirmwareName = new AnalogItemState<string>(this);
                            }
                            else
                            {
                                FirmwareName = (AnalogItemState<string>)replacement;
                            }
                        }
                    }

                    instance = FirmwareName;
                    break;
                }

                case OPCUAServer.BrowseNames.FirmwareVersion:
                {
                    if (createOrReplace)
                    {
                        if (FirmwareVersion == null)
                        {
                            if (replacement == null)
                            {
                                FirmwareVersion = new AnalogItemState<string>(this);
                            }
                            else
                            {
                                FirmwareVersion = (AnalogItemState<string>)replacement;
                            }
                        }
                    }

                    instance = FirmwareVersion;
                    break;
                }

                case OPCUAServer.BrowseNames.FirmwareBuildTime:
                {
                    if (createOrReplace)
                    {
                        if (FirmwareBuildTime == null)
                        {
                            if (replacement == null)
                            {
                                FirmwareBuildTime = new AnalogItemState<DateTime>(this);
                            }
                            else
                            {
                                FirmwareBuildTime = (AnalogItemState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = FirmwareBuildTime;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<string> m_firmwareName;
        private AnalogItemState<string> m_firmwareVersion;
        private AnalogItemState<DateTime> m_firmwareBuildTime;
        #endregion
    }
    #endif
    #endregion

    #region Firmware1State Class
    #if (!OPCUA_EXCLUDE_Firmware1State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Firmware1State : GenericFirmwareState
    {
        #region Constructors
        /// <remarks />
        public Firmware1State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.Firmware1, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABEA" +
           "AABGaXJtd2FyZTFJbnN0YW5jZQEBFAABARQAFAAAAP////8DAAAAFWCJCgIAAAABAAwAAABGaXJtd2Fy" +
           "ZU5hbWUBARUAAC8BAEAJFQAAAAAM/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBARkA" +
           "AC4ARBkAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAEZpcm13YXJlVmVyc2lvbgEBGwAA" +
           "LwEAQAkbAAAAAAz/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBHwAALgBEHwAAAAEA" +
           "dAP/////AQH/////AAAAABVgiQoCAAAAAQARAAAARmlybXdhcmVCdWlsZFRpbWUBASEAAC8BAEAJIQAA" +
           "AAAN/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBASUAAC4ARCUAAAABAHQD/////wEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MachineState Class
    #if (!OPCUA_EXCLUDE_MachineState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineState : FolderState
    {
        #region Constructors
        /// <remarks />
        public MachineState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.MachineType, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABMA" +
           "AABNYWNoaW5lVHlwZUluc3RhbmNlAQEoAAEBKAAoAAAA/////wEAAAAEYIAKAQAAAAEACQAAAEZpcm13" +
           "YXJlMQEBKQAALwEBFAApAAAA/////wMAAAAVYIkKAgAAAAEADAAAAEZpcm13YXJlTmFtZQEBKgAALwEA" +
           "QAkqAAAAAAz/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBLgAALgBELgAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAPAAAARmlybXdhcmVWZXJzaW9uAQEwAAAvAQBACTAAAAAADP//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQE0AAAuAEQ0AAAAAQB0A/////8BAf////8A" +
           "AAAAFWCJCgIAAAABABEAAABGaXJtd2FyZUJ1aWxkVGltZQEBNgAALwEAQAk2AAAAAA3/////AQH/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBOgAALgBEOgAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public Firmware1State Firmware1
        {
            get
            {
                return m_firmware1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_firmware1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_firmware1 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_firmware1 != null)
            {
                children.Add(m_firmware1);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OPCUAServer.BrowseNames.Firmware1:
                {
                    if (createOrReplace)
                    {
                        if (Firmware1 == null)
                        {
                            if (replacement == null)
                            {
                                Firmware1 = new Firmware1State(this);
                            }
                            else
                            {
                                Firmware1 = (Firmware1State)replacement;
                            }
                        }
                    }

                    instance = Firmware1;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private Firmware1State m_firmware1;
        #endregion
    }
    #endif
    #endregion

    #region OPCUAServerState Class
    #if (!OPCUA_EXCLUDE_OPCUAServerState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OPCUAServerState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public OPCUAServerState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.OPCUAServerType, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////hGCAAgEAAAABABcA" +
           "AABPUENVQVNlcnZlclR5cGVJbnN0YW5jZQEBPQABAT0APQAAAAH/////BAAAAIRgwAoBAAAABwAAAE1h" +
           "Y2hpbmUBAAgAAAAgTWFjaGluZQEBPgAALwEBKAA+AAAAAf////8BAAAABGCACgEAAAABAAkAAABGaXJt" +
           "d2FyZTEBAT8AAC8BARQAPwAAAP////8DAAAAFWCJCgIAAAABAAwAAABGaXJtd2FyZU5hbWUBAUAAAC8B" +
           "AEAJQAAAAAAM/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAUQAAC4AREQAAAABAHQD" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAEZpcm13YXJlVmVyc2lvbgEBRgAALwEAQAlGAAAAAAz/" +
           "////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBSgAALgBESgAAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQARAAAARmlybXdhcmVCdWlsZFRpbWUBAUwAAC8BAEAJTAAAAAAN/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAVAAAC4ARFAAAAABAHQD/////wEB/////wAAAAAEYYIK" +
           "BAAAAAEADAAAAFN0YXJ0UHJvY2VzcwEBUwAALwEBUwBTAAAAAQH/////AAAAAARhggoEAAAAAQALAAAA" +
           "U3RvcFByb2Nlc3MBAVQAAC8BAVQAVAAAAAEB/////wAAAAAkYYIKBAAAAAEABwAAAHJlcXVlc3QBAW0A" +
           "AwAAAAAXAAAARmlybXdhcmVUcmFuc2ZlclJlcXVlc3QALwEBbQBtAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MachineState Machine
        {
            get
            {
                return m_machine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machine = value;
            }
        }

        /// <remarks />
        public MethodState StartProcess
        {
            get
            {
                return m_startProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopProcess
        {
            get
            {
                return m_stopProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState request
        {
            get
            {
                return m_requestMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_requestMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_requestMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_machine != null)
            {
                children.Add(m_machine);
            }

            if (m_startProcessMethod != null)
            {
                children.Add(m_startProcessMethod);
            }

            if (m_stopProcessMethod != null)
            {
                children.Add(m_stopProcessMethod);
            }

            if (m_requestMethod != null)
            {
                children.Add(m_requestMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OPCUAServer.BrowseNames.Machine:
                {
                    if (createOrReplace)
                    {
                        if (Machine == null)
                        {
                            if (replacement == null)
                            {
                                Machine = new MachineState(this);
                            }
                            else
                            {
                                Machine = (MachineState)replacement;
                            }
                        }
                    }

                    instance = Machine;
                    break;
                }

                case OPCUAServer.BrowseNames.StartProcess:
                {
                    if (createOrReplace)
                    {
                        if (StartProcess == null)
                        {
                            if (replacement == null)
                            {
                                StartProcess = new MethodState(this);
                            }
                            else
                            {
                                StartProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartProcess;
                    break;
                }

                case OPCUAServer.BrowseNames.StopProcess:
                {
                    if (createOrReplace)
                    {
                        if (StopProcess == null)
                        {
                            if (replacement == null)
                            {
                                StopProcess = new MethodState(this);
                            }
                            else
                            {
                                StopProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopProcess;
                    break;
                }

                case OPCUAServer.BrowseNames.request:
                {
                    if (createOrReplace)
                    {
                        if (request == null)
                        {
                            if (replacement == null)
                            {
                                request = new MethodState(this);
                            }
                            else
                            {
                                request = (MethodState)replacement;
                            }
                        }
                    }

                    instance = request;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MachineState m_machine;
        private MethodState m_startProcessMethod;
        private MethodState m_stopProcessMethod;
        private MethodState m_requestMethod;
        #endregion
    }
    #endif
    #endregion
}