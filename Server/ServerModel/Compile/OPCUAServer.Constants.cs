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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OPCUAServer
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint FirmwareTransferRequest = 39;

        /// <remarks />
        public const uint OPCUAServerType_StartProcess = 83;

        /// <remarks />
        public const uint OPCUAServerType_StopProcess = 84;

        /// <remarks />
        public const uint OPCUAServerType_request = 109;

        /// <remarks />
        public const uint OPCUAServer1_StartProcess = 107;

        /// <remarks />
        public const uint OPCUAServer1_StopProcess = 108;

        /// <remarks />
        public const uint OPCUAServer1_request = 110;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint MachineType_Firmware1 = 41;

        /// <remarks />
        public const uint OPCUAServerType_Machine = 62;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Firmware1 = 63;

        /// <remarks />
        public const uint OPCUAServer1 = 85;

        /// <remarks />
        public const uint OPCUAServer1_Machine = 86;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Firmware1 = 87;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint GenericFirmwareType = 1;

        /// <remarks />
        public const uint Firmware1 = 20;

        /// <remarks />
        public const uint MachineType = 40;

        /// <remarks />
        public const uint OPCUAServerType = 61;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint GenericFirmwareType_FirmwareName = 2;

        /// <remarks />
        public const uint GenericFirmwareType_FirmwareName_EURange = 6;

        /// <remarks />
        public const uint GenericFirmwareType_FirmwareVersion = 8;

        /// <remarks />
        public const uint GenericFirmwareType_FirmwareVersion_EURange = 12;

        /// <remarks />
        public const uint GenericFirmwareType_FirmwareBuildTime = 14;

        /// <remarks />
        public const uint GenericFirmwareType_FirmwareBuildTime_EURange = 18;

        /// <remarks />
        public const uint Firmware1_FirmwareName_EURange = 25;

        /// <remarks />
        public const uint Firmware1_FirmwareVersion_EURange = 31;

        /// <remarks />
        public const uint Firmware1_FirmwareBuildTime_EURange = 37;

        /// <remarks />
        public const uint MachineType_Firmware1_FirmwareName = 42;

        /// <remarks />
        public const uint MachineType_Firmware1_FirmwareName_EURange = 46;

        /// <remarks />
        public const uint MachineType_Firmware1_FirmwareVersion = 48;

        /// <remarks />
        public const uint MachineType_Firmware1_FirmwareVersion_EURange = 52;

        /// <remarks />
        public const uint MachineType_Firmware1_FirmwareBuildTime = 54;

        /// <remarks />
        public const uint MachineType_Firmware1_FirmwareBuildTime_EURange = 58;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Firmware1_FirmwareName = 64;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Firmware1_FirmwareName_EURange = 68;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Firmware1_FirmwareVersion = 70;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Firmware1_FirmwareVersion_EURange = 74;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Firmware1_FirmwareBuildTime = 76;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Firmware1_FirmwareBuildTime_EURange = 80;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Firmware1_FirmwareName = 88;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Firmware1_FirmwareName_EURange = 92;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Firmware1_FirmwareVersion = 94;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Firmware1_FirmwareVersion_EURange = 98;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Firmware1_FirmwareBuildTime = 100;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Firmware1_FirmwareBuildTime_EURange = 104;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId FirmwareTransferRequest = new ExpandedNodeId(OPCUAServer.Methods.FirmwareTransferRequest, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_StartProcess = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServerType_StartProcess, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_StopProcess = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServerType_StopProcess, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_request = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServerType_request, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_StartProcess = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServer1_StartProcess, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_StopProcess = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServer1_StopProcess, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_request = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServer1_request, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Firmware1 = new ExpandedNodeId(OPCUAServer.Objects.MachineType_Firmware1, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServerType_Machine, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Firmware1 = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServerType_Machine_Firmware1, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1 = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1_Machine, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Firmware1 = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1_Machine_Firmware1, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericFirmwareType = new ExpandedNodeId(OPCUAServer.ObjectTypes.GenericFirmwareType, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Firmware1 = new ExpandedNodeId(OPCUAServer.ObjectTypes.Firmware1, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType = new ExpandedNodeId(OPCUAServer.ObjectTypes.MachineType, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType = new ExpandedNodeId(OPCUAServer.ObjectTypes.OPCUAServerType, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericFirmwareType_FirmwareName = new ExpandedNodeId(OPCUAServer.Variables.GenericFirmwareType_FirmwareName, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId GenericFirmwareType_FirmwareName_EURange = new ExpandedNodeId(OPCUAServer.Variables.GenericFirmwareType_FirmwareName_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId GenericFirmwareType_FirmwareVersion = new ExpandedNodeId(OPCUAServer.Variables.GenericFirmwareType_FirmwareVersion, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId GenericFirmwareType_FirmwareVersion_EURange = new ExpandedNodeId(OPCUAServer.Variables.GenericFirmwareType_FirmwareVersion_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId GenericFirmwareType_FirmwareBuildTime = new ExpandedNodeId(OPCUAServer.Variables.GenericFirmwareType_FirmwareBuildTime, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId GenericFirmwareType_FirmwareBuildTime_EURange = new ExpandedNodeId(OPCUAServer.Variables.GenericFirmwareType_FirmwareBuildTime_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Firmware1_FirmwareName_EURange = new ExpandedNodeId(OPCUAServer.Variables.Firmware1_FirmwareName_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Firmware1_FirmwareVersion_EURange = new ExpandedNodeId(OPCUAServer.Variables.Firmware1_FirmwareVersion_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Firmware1_FirmwareBuildTime_EURange = new ExpandedNodeId(OPCUAServer.Variables.Firmware1_FirmwareBuildTime_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Firmware1_FirmwareName = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Firmware1_FirmwareName, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Firmware1_FirmwareName_EURange = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Firmware1_FirmwareName_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Firmware1_FirmwareVersion = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Firmware1_FirmwareVersion, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Firmware1_FirmwareVersion_EURange = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Firmware1_FirmwareVersion_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Firmware1_FirmwareBuildTime = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Firmware1_FirmwareBuildTime, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Firmware1_FirmwareBuildTime_EURange = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Firmware1_FirmwareBuildTime_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Firmware1_FirmwareName = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Firmware1_FirmwareName, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Firmware1_FirmwareName_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Firmware1_FirmwareName_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Firmware1_FirmwareVersion = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Firmware1_FirmwareVersion, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Firmware1_FirmwareVersion_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Firmware1_FirmwareVersion_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Firmware1_FirmwareBuildTime = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Firmware1_FirmwareBuildTime, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Firmware1_FirmwareBuildTime_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Firmware1_FirmwareBuildTime_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Firmware1_FirmwareName = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Firmware1_FirmwareName, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Firmware1_FirmwareName_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Firmware1_FirmwareName_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Firmware1_FirmwareVersion = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Firmware1_FirmwareVersion, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Firmware1_FirmwareVersion_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Firmware1_FirmwareVersion_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Firmware1_FirmwareBuildTime = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Firmware1_FirmwareBuildTime, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Firmware1_FirmwareBuildTime_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Firmware1_FirmwareBuildTime_EURange, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Firmware1 = "Firmware1";

        /// <remarks />
        public const string FirmwareBuildTime = "FirmwareBuildTime";

        /// <remarks />
        public const string FirmwareName = "FirmwareName";

        /// <remarks />
        public const string FirmwareTransferRequest = "FirmwareTransferRequest";

        /// <remarks />
        public const string FirmwareVersion = "FirmwareVersion";

        /// <remarks />
        public const string GenericFirmwareType = "GenericFirmwareType";

        /// <remarks />
        public const string Machine = " Machine";

        /// <remarks />
        public const string MachineType = "MachineType";

        /// <remarks />
        public const string OPCUAServer1 = "Line";

        /// <remarks />
        public const string OPCUAServerType = "OPCUAServerType";

        /// <remarks />
        public const string request = "request";

        /// <remarks />
        public const string StartProcess = "StartProcess";

        /// <remarks />
        public const string StopProcess = "StopProcess";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OPCUAServer namespace (.NET code namespace is 'OPCUAServer').
        /// </summary>
        public const string OPCUAServer = "http://opcfoundation.org/OPCUAServer";
    }
    #endregion
}