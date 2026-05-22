using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.NetworkInformation;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x0200014B RID: 331
	public class Socket : Object
	{
		// Token: 0x060014CF RID: 5327 RVA: 0x0005E80C File Offset: 0x0005CA0C
		// Note: this type is marked as 'beforefieldinit'.
		static Socket()
		{
			Il2CppClassPointerStore<Socket>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "Socket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket>.NativeClassPtr);
			Socket.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_InternalSyncObject");
			Socket.NativeFieldInfoPtr_s_SupportsIPv4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_SupportsIPv4");
			Socket.NativeFieldInfoPtr_s_SupportsIPv6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_SupportsIPv6");
			Socket.NativeFieldInfoPtr_s_OSSupportsIPv6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_OSSupportsIPv6");
			Socket.NativeFieldInfoPtr_s_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_Initialized");
			Socket.NativeFieldInfoPtr_s_LoggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_LoggingEnabled");
			Socket.NativeFieldInfoPtr_s_PerfCountersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_PerfCountersEnabled");
			Socket.NativeFieldInfoPtr_DefaultCloseTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "DefaultCloseTimeout");
			Socket.NativeFieldInfoPtr_SOCKET_CLOSED_CODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "SOCKET_CLOSED_CODE");
			Socket.NativeFieldInfoPtr_TIMEOUT_EXCEPTION_MSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "TIMEOUT_EXCEPTION_MSG");
			Socket.NativeFieldInfoPtr_is_closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_closed");
			Socket.NativeFieldInfoPtr_is_listening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_listening");
			Socket.NativeFieldInfoPtr_useOverlappedIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "useOverlappedIO");
			Socket.NativeFieldInfoPtr_linger_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "linger_timeout");
			Socket.NativeFieldInfoPtr_addressFamily = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "addressFamily");
			Socket.NativeFieldInfoPtr_socketType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "socketType");
			Socket.NativeFieldInfoPtr_protocolType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "protocolType");
			Socket.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "m_Handle");
			Socket.NativeFieldInfoPtr_seed_endpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "seed_endpoint");
			Socket.NativeFieldInfoPtr_ReadSem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReadSem");
			Socket.NativeFieldInfoPtr_WriteSem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "WriteSem");
			Socket.NativeFieldInfoPtr_is_blocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_blocking");
			Socket.NativeFieldInfoPtr_is_bound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_bound");
			Socket.NativeFieldInfoPtr_is_connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_connected");
			Socket.NativeFieldInfoPtr_m_IntCleanedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "m_IntCleanedUp");
			Socket.NativeFieldInfoPtr_connect_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "connect_in_progress");
			Socket.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ID");
			Socket.NativeFieldInfoPtr_AcceptAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "AcceptAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginAcceptCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginAcceptCallback");
			Socket.NativeFieldInfoPtr_BeginAcceptReceiveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginAcceptReceiveCallback");
			Socket.NativeFieldInfoPtr_ConnectAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ConnectAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginConnectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginConnectCallback");
			Socket.NativeFieldInfoPtr_DisconnectAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "DisconnectAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginDisconnectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginDisconnectCallback");
			Socket.NativeFieldInfoPtr_ReceiveAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReceiveAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginReceiveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveCallback");
			Socket.NativeFieldInfoPtr_BeginReceiveGenericCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveGenericCallback");
			Socket.NativeFieldInfoPtr_ReceiveFromAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReceiveFromAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginReceiveFromCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveFromCallback");
			Socket.NativeFieldInfoPtr_SendAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "SendAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginSendGenericCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginSendGenericCallback");
			Socket.NativeFieldInfoPtr_SendToAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "SendToAsyncCallback");
			Socket.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666252);
			Socket.NativeMethodInfoPtr_get_SupportsIPv4_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666253);
			Socket.NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666254);
			Socket.NativeMethodInfoPtr_get_SupportsIPv6_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666255);
			Socket.NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666256);
			Socket.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666257);
			Socket.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666258);
			Socket.NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666259);
			Socket.NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666260);
			Socket.NativeMethodInfoPtr_set_ReceiveTimeout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666261);
			Socket.NativeMethodInfoPtr_set_SendTimeout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666262);
			Socket.NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666263);
			Socket.NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666264);
			Socket.NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666265);
			Socket.NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666266);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666267);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666268);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666269);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666270);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666271);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666272);
			Socket.NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666273);
			Socket.NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666274);
			Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666275);
			Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666276);
			Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666277);
			Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666278);
			Socket.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666279);
			Socket.NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666280);
			Socket.NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666281);
			Socket.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666282);
			Socket.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666283);
			Socket.NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666284);
			Socket.NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666285);
			Socket.NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666286);
			Socket.NativeMethodInfoPtr_SocketDefaults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666287);
			Socket.NativeMethodInfoPtr_Socket_internal_Private_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666288);
			Socket.NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666289);
			Socket.NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666290);
			Socket.NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666291);
			Socket.NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666292);
			Socket.NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666293);
			Socket.NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666294);
			Socket.NativeMethodInfoPtr_Blocking_internal_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666295);
			Socket.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666296);
			Socket.NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666297);
			Socket.NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666298);
			Socket.NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666299);
			Socket.NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666300);
			Socket.NativeMethodInfoPtr_Accept_Public_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666301);
			Socket.NativeMethodInfoPtr_Accept_Internal_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666302);
			Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666303);
			Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666304);
			Socket.NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666305);
			Socket.NativeMethodInfoPtr_Accept_internal_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666306);
			Socket.NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666307);
			Socket.NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666308);
			Socket.NativeMethodInfoPtr_Bind_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666309);
			Socket.NativeMethodInfoPtr_Listen_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666310);
			Socket.NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666311);
			Socket.NativeMethodInfoPtr_Listen_internal_Private_Static_Void_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666312);
			Socket.NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666313);
			Socket.NativeMethodInfoPtr_ConnectAsync_Public_Boolean_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666314);
			Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666315);
			Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_Il2CppReferenceArray_1_IPAddress_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666316);
			Socket.NativeMethodInfoPtr_BeginMConnect_Private_Static_Void_SocketAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666317);
			Socket.NativeMethodInfoPtr_BeginSConnect_Private_Static_Void_SocketAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666318);
			Socket.NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666319);
			Socket.NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666320);
			Socket.NativeMethodInfoPtr_Connect_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666321);
			Socket.NativeMethodInfoPtr_GetCheckedIPs_Private_Boolean_SocketAsyncEventArgs_byref_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666322);
			Socket.NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666323);
			Socket.NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666324);
			Socket.NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666325);
			Socket.NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_IntPtr_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666326);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666327);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666328);
			Socket.NativeMethodInfoPtr_ReceiveAsync_Public_Boolean_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666329);
			Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666330);
			Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666331);
			Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666332);
			Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666333);
			Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666334);
			Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666335);
			Socket.NativeMethodInfoPtr_ReceiveFrom_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666336);
			Socket.NativeMethodInfoPtr_EndReceiveFrom_Public_Int32_IAsyncResult_byref_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666337);
			Socket.NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666338);
			Socket.NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666339);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666340);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666341);
			Socket.NativeMethodInfoPtr_SendAsync_Public_Boolean_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666342);
			Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666343);
			Socket.NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666344);
			Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666345);
			Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666346);
			Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666347);
			Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666348);
			Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666349);
			Socket.NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666350);
			Socket.NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666351);
			Socket.NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666352);
			Socket.NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666353);
			Socket.NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666354);
			Socket.NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666355);
			Socket.NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666356);
			Socket.NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666357);
			Socket.NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666358);
			Socket.NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666359);
			Socket.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666360);
			Socket.NativeMethodInfoPtr_Close_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666361);
			Socket.NativeMethodInfoPtr_Close_internal_Internal_Static_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666362);
			Socket.NativeMethodInfoPtr_Shutdown_Public_Void_SocketShutdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666363);
			Socket.NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666364);
			Socket.NativeMethodInfoPtr_Shutdown_internal_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666365);
			Socket.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666366);
			Socket.NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666367);
			Socket.NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666368);
			Socket.NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666369);
			Socket.NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666370);
			Socket.NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666371);
			Socket.NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666372);
			Socket.NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666373);
			Socket.NativeMethodInfoPtr_InitSocketAsyncEventArgs_Private_Void_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666374);
			Socket.NativeMethodInfoPtr_SocketOperationToSocketAsyncOperation_Private_SocketAsyncOperation_SocketOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666375);
			Socket.NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666376);
			Socket.NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666377);
			Socket.NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666378);
			Socket.NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666379);
			Socket.NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666380);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0005F598 File Offset: 0x0005D798
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 386883, RefRangeEnd = 386888, XrefRangeStart = 386855, XrefRangeEnd = 386883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref addressFamily;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref protocolType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x0005F5FC File Offset: 0x0005D7FC
		public unsafe static bool SupportsIPv4
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 386893, RefRangeEnd = 386894, XrefRangeStart = 386888, XrefRangeEnd = 386893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_SupportsIPv4_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0005F62C File Offset: 0x0005D82C
		public unsafe static bool OSSupportsIPv4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386894, XrefRangeEnd = 386899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0005F65C File Offset: 0x0005D85C
		public unsafe static bool SupportsIPv6
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 386904, RefRangeEnd = 386905, XrefRangeStart = 386899, XrefRangeEnd = 386904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_SupportsIPv6_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x0005F68C File Offset: 0x0005D88C
		public unsafe static bool OSSupportsIPv6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386905, XrefRangeEnd = 386910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x0005F6BC File Offset: 0x0005D8BC
		public unsafe IntPtr Handle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x0005F6F8 File Offset: 0x0005D8F8
		public unsafe AddressFamily AddressFamily
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0005F734 File Offset: 0x0005D934
		public unsafe SocketType SocketType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0005F770 File Offset: 0x0005D970
		public unsafe ProtocolType ProtocolType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x0005F7AC File Offset: 0x0005D9AC
		public unsafe int ReceiveTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386910, XrefRangeEnd = 386911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_ReceiveTimeout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x0005F7EC File Offset: 0x0005D9EC
		public unsafe int SendTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386911, XrefRangeEnd = 386912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_SendTimeout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x0005F82C File Offset: 0x0005DA2C
		public unsafe bool DontFragment
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386912, XrefRangeEnd = 386913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x0005F86C File Offset: 0x0005DA6C
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x0005F8A8 File Offset: 0x0005DAA8
		public unsafe bool DualMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386913, XrefRangeEnd = 386916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386916, XrefRangeEnd = 386917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x0005F8E8 File Offset: 0x0005DAE8
		public unsafe bool IsDualMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0005F924 File Offset: 0x0005DB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386917, XrefRangeEnd = 386919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0005F974 File Offset: 0x0005DB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386919, XrefRangeEnd = 386920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0005F9D0 File Offset: 0x0005DBD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 386928, RefRangeEnd = 386931, XrefRangeStart = 386920, XrefRangeEnd = 386928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0005FA48 File Offset: 0x0005DC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386931, XrefRangeEnd = 386933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0005FA98 File Offset: 0x0005DC98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386934, RefRangeEnd = 386935, XrefRangeStart = 386933, XrefRangeEnd = 386934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0005FB10 File Offset: 0x0005DD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386935, XrefRangeEnd = 386936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0005FB6C File Offset: 0x0005DD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386936, XrefRangeEnd = 386940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IOControl(IOControlCode ioControlCode, Il2CppStructArray<byte> optionInValue, Il2CppStructArray<byte> optionOutValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ioControlCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionInValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionOutValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0005FBDC File Offset: 0x0005DDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386940, XrefRangeEnd = 386941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIPProtectionLevel(IPProtectionLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0005FC1C File Offset: 0x0005DE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386941, XrefRangeEnd = 386942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginSend(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0005FCBC File Offset: 0x0005DEBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 386951, RefRangeEnd = 386953, XrefRangeStart = 386942, XrefRangeEnd = 386951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndSend(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0005FD0C File Offset: 0x0005DF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386953, XrefRangeEnd = 386954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginReceive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0005FDAC File Offset: 0x0005DFAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 386963, RefRangeEnd = 386965, XrefRangeStart = 386954, XrefRangeEnd = 386963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndReceive(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x0005FDFC File Offset: 0x0005DFFC
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386965, XrefRangeEnd = 386978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x0005FE30 File Offset: 0x0005E030
		public unsafe bool CleanedUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0005FE6C File Offset: 0x0005E06C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 387026, RefRangeEnd = 387034, XrefRangeStart = 386978, XrefRangeEnd = 387026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeSockets()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0005FE94 File Offset: 0x0005E094
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 387038, RefRangeEnd = 387045, XrefRangeStart = 387034, XrefRangeEnd = 387038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0005FEC8 File Offset: 0x0005E0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Socket.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0005FF04 File Offset: 0x0005E104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387045, XrefRangeEnd = 387049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalShutdown(SocketShutdown how)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref how;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0005FF44 File Offset: 0x0005E144
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 387054, RefRangeEnd = 387057, XrefRangeStart = 387049, XrefRangeEnd = 387054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optionLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0005FFAC File Offset: 0x0005E1AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387068, RefRangeEnd = 387070, XrefRangeStart = 387057, XrefRangeEnd = 387068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref family;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proto;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(safe_handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00060024 File Offset: 0x0005E224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387075, RefRangeEnd = 387076, XrefRangeStart = 387070, XrefRangeEnd = 387075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SocketDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SocketDefaults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00060058 File Offset: 0x0005E258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387090, RefRangeEnd = 387092, XrefRangeStart = 387076, XrefRangeEnd = 387090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out int error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref family;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proto;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Socket_internal_Private_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x000600CC File Offset: 0x0005E2CC
		public unsafe EndPoint LocalEndPoint
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 387097, RefRangeEnd = 387099, XrefRangeStart = 387092, XrefRangeEnd = 387097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0006010C File Offset: 0x0005E30C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387106, RefRangeEnd = 387107, XrefRangeStart = 387099, XrefRangeEnd = 387106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref family;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0006016C File Offset: 0x0005E36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387107, XrefRangeEnd = 387108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketAddress LocalEndPoint_internal(IntPtr socket, int family, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref family;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000601C8 File Offset: 0x0005E3C8
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x00060204 File Offset: 0x0005E404
		public unsafe bool Blocking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 387113, RefRangeEnd = 387115, XrefRangeStart = 387108, XrefRangeEnd = 387113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00060244 File Offset: 0x0005E444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387122, RefRangeEnd = 387123, XrefRangeStart = 387115, XrefRangeEnd = 387122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref block;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00060298 File Offset: 0x0005E498
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387134, RefRangeEnd = 387136, XrefRangeStart = 387123, XrefRangeEnd = 387134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blocking_internal(IntPtr socket, bool block, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref block;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Blocking_internal_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x000602E8 File Offset: 0x0005E4E8
		public unsafe bool Connected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EE RID: 1774
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x00060324 File Offset: 0x0005E524
		public unsafe bool NoDelay
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 387138, RefRangeEnd = 387139, XrefRangeStart = 387136, XrefRangeEnd = 387138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00060364 File Offset: 0x0005E564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387139, XrefRangeEnd = 387147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Poll(int microSeconds, SelectMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref microSeconds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x000603BC File Offset: 0x0005E5BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 387154, RefRangeEnd = 387157, XrefRangeStart = 387147, XrefRangeEnd = 387154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00060428 File Offset: 0x0005E628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387157, XrefRangeEnd = 387158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Poll_internal(IntPtr socket, SelectMode mode, int timeout, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00060490 File Offset: 0x0005E690
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 387167, RefRangeEnd = 387170, XrefRangeStart = 387158, XrefRangeEnd = 387167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket Accept()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_Public_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x000604D0 File Offset: 0x0005E6D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387183, RefRangeEnd = 387185, XrefRangeStart = 387170, XrefRangeEnd = 387183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Accept(Socket acceptSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptSocket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_Internal_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00060514 File Offset: 0x0005E714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387185, XrefRangeEnd = 387193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket EndAccept(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
			}
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00060564 File Offset: 0x0005E764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387193, XrefRangeEnd = 387201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket EndAccept(out Il2CppStructArray<byte> buffer, out int bytesTransferred, IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesTransferred;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr5) : null;
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x000605E8 File Offset: 0x0005E7E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387217, RefRangeEnd = 387219, XrefRangeStart = 387201, XrefRangeEnd = 387217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeSocketHandle>(intPtr3) : null;
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00060648 File Offset: 0x0005E848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387219, XrefRangeEnd = 387224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Accept_internal(IntPtr sock, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_internal_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x000606A4 File Offset: 0x0005E8A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387246, RefRangeEnd = 387248, XrefRangeStart = 387224, XrefRangeEnd = 387246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(EndPoint localEP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localEP);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x000606E8 File Offset: 0x0005E8E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387255, RefRangeEnd = 387256, XrefRangeStart = 387248, XrefRangeEnd = 387255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00060740 File Offset: 0x0005E940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387256, XrefRangeEnd = 387257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Bind_internal(IntPtr sock, SocketAddress sa, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Bind_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00060794 File Offset: 0x0005E994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387257, XrefRangeEnd = 387262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Listen(int backlog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref backlog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Listen_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x000607D4 File Offset: 0x0005E9D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387279, RefRangeEnd = 387281, XrefRangeStart = 387262, XrefRangeEnd = 387279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backlog;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00060828 File Offset: 0x0005EA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387281, XrefRangeEnd = 387292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Listen_internal(IntPtr sock, int backlog, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backlog;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Listen_internal_Private_Static_Void_IntPtr_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00060878 File Offset: 0x0005EA78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 387316, RefRangeEnd = 387319, XrefRangeStart = 387292, XrefRangeEnd = 387316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Connect(EndPoint remoteEP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000608BC File Offset: 0x0005EABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387339, RefRangeEnd = 387340, XrefRangeStart = 387319, XrefRangeEnd = 387339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ConnectAsync(SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ConnectAsync_Public_Boolean_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0006090C File Offset: 0x0005EB0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387350, RefRangeEnd = 387352, XrefRangeStart = 387340, XrefRangeEnd = 387350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00060980 File Offset: 0x0005EB80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387362, RefRangeEnd = 387363, XrefRangeStart = 387352, XrefRangeEnd = 387362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginConnect(Il2CppReferenceArray<IPAddress> addresses, int port, AsyncCallback requestCallback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(addresses);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_Il2CppReferenceArray_1_IPAddress_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00060A04 File Offset: 0x0005EC04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387373, RefRangeEnd = 387375, XrefRangeStart = 387363, XrefRangeEnd = 387373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginMConnect(SocketAsyncResult sockares)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sockares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginMConnect_Private_Static_Void_SocketAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00060A3C File Offset: 0x0005EC3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387403, RefRangeEnd = 387405, XrefRangeStart = 387375, XrefRangeEnd = 387403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSConnect(SocketAsyncResult sockares)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sockares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSConnect_Private_Static_Void_SocketAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00060A74 File Offset: 0x0005EC74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387414, RefRangeEnd = 387416, XrefRangeStart = 387405, XrefRangeEnd = 387414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndConnect(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00060AB8 File Offset: 0x0005ECB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387424, RefRangeEnd = 387425, XrefRangeStart = 387416, XrefRangeEnd = 387424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00060B1C File Offset: 0x0005ED1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387425, XrefRangeEnd = 387426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Connect_internal(IntPtr sock, SocketAddress sa, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Connect_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00060B7C File Offset: 0x0005ED7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387440, RefRangeEnd = 387441, XrefRangeStart = 387426, XrefRangeEnd = 387440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCheckedIPs(SocketAsyncEventArgs e, out Il2CppReferenceArray<IPAddress> addresses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_GetCheckedIPs_Private_Boolean_SocketAsyncEventArgs_byref_Il2CppReferenceArray_1_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			addresses = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<IPAddress>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00060BEC File Offset: 0x0005EDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387441, XrefRangeEnd = 387446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disconnect(bool reuseSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reuseSocket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00060C2C File Offset: 0x0005EE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387446, XrefRangeEnd = 387455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDisconnect(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00060C70 File Offset: 0x0005EE70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387472, RefRangeEnd = 387474, XrefRangeStart = 387455, XrefRangeEnd = 387472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reuse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00060CC4 File Offset: 0x0005EEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387474, XrefRangeEnd = 387475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Disconnect_internal(IntPtr sock, bool reuse, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reuse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_IntPtr_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00060D14 File Offset: 0x0005EF14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 387482, RefRangeEnd = 387486, XrefRangeStart = 387475, XrefRangeEnd = 387482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00060D9C File Offset: 0x0005EF9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387520, RefRangeEnd = 387522, XrefRangeStart = 387486, XrefRangeEnd = 387520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00060E08 File Offset: 0x0005F008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387522, XrefRangeEnd = 387546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReceiveAsync(SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveAsync_Public_Boolean_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00060E58 File Offset: 0x0005F058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387563, RefRangeEnd = 387565, XrefRangeStart = 387546, XrefRangeEnd = 387563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginReceive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00060F08 File Offset: 0x0005F108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387565, XrefRangeEnd = 387574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00060F64 File Offset: 0x0005F164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387582, RefRangeEnd = 387583, XrefRangeStart = 387574, XrefRangeEnd = 387582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00060FEC File Offset: 0x0005F1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387583, XrefRangeEnd = 387584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00061070 File Offset: 0x0005F270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387592, RefRangeEnd = 387594, XrefRangeStart = 387584, XrefRangeEnd = 387592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000610F8 File Offset: 0x0005F2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387594, XrefRangeEnd = 387595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0006117C File Offset: 0x0005F37C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387600, RefRangeEnd = 387601, XrefRangeStart = 387595, XrefRangeEnd = 387600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReceiveFrom(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveFrom_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			remoteEP = ((intPtr4 == 0) ? null : new EndPoint(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00061230 File Offset: 0x0005F430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387601, XrefRangeEnd = 387609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndReceiveFrom_Public_Int32_IAsyncResult_byref_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			endPoint = ((intPtr4 == 0) ? null : new EndPoint(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000612A8 File Offset: 0x0005F4A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387617, RefRangeEnd = 387618, XrefRangeStart = 387609, XrefRangeEnd = 387617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sockaddr);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sockaddr = ((intPtr4 == 0) ? null : new SocketAddress(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0006135C File Offset: 0x0005F55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387618, XrefRangeEnd = 387619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReceiveFrom_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sockaddr);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sockaddr = ((intPtr4 == 0) ? null : new SocketAddress(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0006140C File Offset: 0x0005F60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387619, XrefRangeEnd = 387626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00061494 File Offset: 0x0005F694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387660, RefRangeEnd = 387662, XrefRangeStart = 387626, XrefRangeEnd = 387660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00061500 File Offset: 0x0005F700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387662, XrefRangeEnd = 387697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendAsync(SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SendAsync_Public_Boolean_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00061550 File Offset: 0x0005F750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387722, RefRangeEnd = 387724, XrefRangeStart = 387697, XrefRangeEnd = 387722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginSend(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00061600 File Offset: 0x0005F800
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 387736, RefRangeEnd = 387739, XrefRangeStart = 387724, XrefRangeEnd = 387736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sockares);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sent_so_far;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00061644 File Offset: 0x0005F844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387739, XrefRangeEnd = 387748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x000616A0 File Offset: 0x0005F8A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387756, RefRangeEnd = 387757, XrefRangeStart = 387748, XrefRangeEnd = 387756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00061728 File Offset: 0x0005F928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387757, XrefRangeEnd = 387758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000617AC File Offset: 0x0005F9AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 387776, RefRangeEnd = 387779, XrefRangeStart = 387758, XrefRangeEnd = 387776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00061834 File Offset: 0x0005FA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387779, XrefRangeEnd = 387790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x000618B8 File Offset: 0x0005FAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387790, XrefRangeEnd = 387798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndSendTo(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00061908 File Offset: 0x0005FB08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 387808, RefRangeEnd = 387814, XrefRangeStart = 387798, XrefRangeEnd = 387808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optionLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00061964 File Offset: 0x0005FB64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387821, RefRangeEnd = 387822, XrefRangeStart = 387814, XrefRangeEnd = 387821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out Object obj_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			obj_val = ((intPtr4 == 0) ? null : new Object(intPtr4));
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000619E8 File Offset: 0x0005FBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387822, XrefRangeEnd = 387823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSocketOption_obj_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out Object obj_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			obj_val = ((intPtr4 == 0) ? null : new Object(intPtr4));
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00061A68 File Offset: 0x0005FC68
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 387829, RefRangeEnd = 387841, XrefRangeStart = 387823, XrefRangeEnd = 387829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optionLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00061AC4 File Offset: 0x0005FCC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387848, RefRangeEnd = 387850, XrefRangeStart = 387841, XrefRangeEnd = 387848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, Object obj_val, Il2CppStructArray<byte> byte_val, int int_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj_val);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byte_val);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref int_val;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00061B58 File Offset: 0x0005FD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387850, XrefRangeEnd = 387851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSocketOption_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, Object obj_val, Il2CppStructArray<byte> byte_val, int int_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj_val);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byte_val);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref int_val;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00061BE8 File Offset: 0x0005FDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387851, XrefRangeEnd = 387855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IOControl(int ioControlCode, Il2CppStructArray<byte> optionInValue, Il2CppStructArray<byte> optionOutValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ioControlCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionInValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionOutValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00061C58 File Offset: 0x0005FE58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 387862, RefRangeEnd = 387865, XrefRangeStart = 387855, XrefRangeEnd = 387862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Il2CppStructArray<byte> input, Il2CppStructArray<byte> output, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ioctl_code;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00061CDC File Offset: 0x0005FEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387865, XrefRangeEnd = 387866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IOControl_internal(IntPtr sock, int ioctl_code, Il2CppStructArray<byte> input, Il2CppStructArray<byte> output, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ioctl_code;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00061D5C File Offset: 0x0005FF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387866, XrefRangeEnd = 387867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00061D90 File Offset: 0x0005FF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387867, XrefRangeEnd = 387868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(int timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Close_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00061DD0 File Offset: 0x0005FFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387868, XrefRangeEnd = 387869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Close_internal(IntPtr socket, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Close_internal_Internal_Static_Void_IntPtr_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00061E10 File Offset: 0x00060010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387869, XrefRangeEnd = 387874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Shutdown(SocketShutdown how)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref how;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Shutdown_Public_Void_SocketShutdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00061E50 File Offset: 0x00060050
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 387881, RefRangeEnd = 387885, XrefRangeStart = 387874, XrefRangeEnd = 387881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref how;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00061EA4 File Offset: 0x000600A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 387896, RefRangeEnd = 387900, XrefRangeStart = 387885, XrefRangeEnd = 387896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown_internal(IntPtr socket, SocketShutdown how, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref how;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Shutdown_internal_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00061EF4 File Offset: 0x000600F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387900, XrefRangeEnd = 387913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Socket.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00061F40 File Offset: 0x00060140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387913, XrefRangeEnd = 387926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Linger(IntPtr handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00061F80 File Offset: 0x00060180
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 387926, RefRangeEnd = 387970, XrefRangeStart = 387926, XrefRangeEnd = 387926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposedAndClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00061FB4 File Offset: 0x000601B4
		[CallerCount(0)]
		public unsafe void ThrowIfBufferNull(Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00061FF8 File Offset: 0x000601F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 387970, RefRangeEnd = 387975, XrefRangeStart = 387970, XrefRangeEnd = 387970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfBufferOutOfRange(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00062058 File Offset: 0x00060258
		[CallerCount(0)]
		public unsafe void ThrowIfUdp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0006208C File Offset: 0x0006028C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 387977, RefRangeEnd = 387991, XrefRangeStart = 387975, XrefRangeEnd = 387977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00062100 File Offset: 0x00060300
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 388005, RefRangeEnd = 388009, XrefRangeStart = 387991, XrefRangeEnd = 388005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(job);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00062164 File Offset: 0x00060364
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 388016, RefRangeEnd = 388019, XrefRangeStart = 388009, XrefRangeEnd = 388016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, Object state, SocketOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_InitSocketAsyncEventArgs_Private_Void_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000621D8 File Offset: 0x000603D8
		[CallerCount(0)]
		public unsafe SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SocketOperationToSocketAsyncOperation_Private_SocketAsyncOperation_SocketOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00062224 File Offset: 0x00060424
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 388033, RefRangeEnd = 388036, XrefRangeStart = 388019, XrefRangeEnd = 388033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPEndPoint RemapIPEndPoint(IPEndPoint input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00062274 File Offset: 0x00060474
		[CallerCount(0)]
		public unsafe static void cancel_blocking_socket_operation(Thread thread)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x000622AC File Offset: 0x000604AC
		public unsafe static int FamilyHint
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 388053, RefRangeEnd = 388055, XrefRangeStart = 388036, XrefRangeEnd = 388053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x000622DC File Offset: 0x000604DC
		[CallerCount(0)]
		public unsafe static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref networkInterface;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0006231C File Offset: 0x0006051C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388055, XrefRangeEnd = 388058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref networkInterface;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0000A82A File Offset: 0x00008A2A
		public Socket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x0006235C File Offset: 0x0006055C
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x0000A833 File Offset: 0x00008A33
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x00062384 File Offset: 0x00060584
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x0000A845 File Offset: 0x00008A45
		public unsafe static bool s_SupportsIPv4
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_SupportsIPv4, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_SupportsIPv4, (void*)(&value));
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x000623A0 File Offset: 0x000605A0
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x0000A853 File Offset: 0x00008A53
		public unsafe static bool s_SupportsIPv6
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_SupportsIPv6, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_SupportsIPv6, (void*)(&value));
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x000623BC File Offset: 0x000605BC
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x0000A861 File Offset: 0x00008A61
		public unsafe static bool s_OSSupportsIPv6
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_OSSupportsIPv6, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_OSSupportsIPv6, (void*)(&value));
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x000623D8 File Offset: 0x000605D8
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x0000A86F File Offset: 0x00008A6F
		public unsafe static bool s_Initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_Initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_Initialized, (void*)(&value));
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x000623F4 File Offset: 0x000605F4
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x0000A87D File Offset: 0x00008A7D
		public unsafe static bool s_LoggingEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_LoggingEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_LoggingEnabled, (void*)(&value));
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00062410 File Offset: 0x00060610
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x0000A88B File Offset: 0x00008A8B
		public unsafe static bool s_PerfCountersEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_PerfCountersEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_PerfCountersEnabled, (void*)(&value));
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x0006242C File Offset: 0x0006062C
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x0000A899 File Offset: 0x00008A99
		public unsafe static int DefaultCloseTimeout
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_DefaultCloseTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_DefaultCloseTimeout, (void*)(&value));
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x00062448 File Offset: 0x00060648
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x0000A8A7 File Offset: 0x00008AA7
		public unsafe static int SOCKET_CLOSED_CODE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_SOCKET_CLOSED_CODE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_SOCKET_CLOSED_CODE, (void*)(&value));
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x00062464 File Offset: 0x00060664
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x0000A8B5 File Offset: 0x00008AB5
		public unsafe static string TIMEOUT_EXCEPTION_MSG
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_TIMEOUT_EXCEPTION_MSG, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_TIMEOUT_EXCEPTION_MSG, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00062484 File Offset: 0x00060684
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x0000A8C7 File Offset: 0x00008AC7
		public unsafe bool is_closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_closed)) = value;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x000624AC File Offset: 0x000606AC
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x0000A8E2 File Offset: 0x00008AE2
		public unsafe bool is_listening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_listening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_listening)) = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x000624D4 File Offset: 0x000606D4
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x0000A8FD File Offset: 0x00008AFD
		public unsafe bool useOverlappedIO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_useOverlappedIO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_useOverlappedIO)) = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x000624FC File Offset: 0x000606FC
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x0000A918 File Offset: 0x00008B18
		public unsafe int linger_timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_linger_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_linger_timeout)) = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x00062524 File Offset: 0x00060724
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x0000A933 File Offset: 0x00008B33
		public unsafe AddressFamily addressFamily
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_addressFamily);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_addressFamily)) = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x0006254C File Offset: 0x0006074C
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x0000A94E File Offset: 0x00008B4E
		public unsafe SocketType socketType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_socketType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_socketType)) = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00062574 File Offset: 0x00060774
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x0000A969 File Offset: 0x00008B69
		public unsafe ProtocolType protocolType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_protocolType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_protocolType)) = value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x0006259C File Offset: 0x0006079C
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x0000A984 File Offset: 0x00008B84
		public unsafe SafeSocketHandle m_Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeSocketHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x000625CC File Offset: 0x000607CC
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x0000A9A3 File Offset: 0x00008BA3
		public unsafe EndPoint seed_endpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_seed_endpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_seed_endpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x000625FC File Offset: 0x000607FC
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x0000A9C2 File Offset: 0x00008BC2
		public unsafe SemaphoreSlim ReadSem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_ReadSem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_ReadSem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x0006262C File Offset: 0x0006082C
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x0000A9E1 File Offset: 0x00008BE1
		public unsafe SemaphoreSlim WriteSem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_WriteSem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_WriteSem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x0006265C File Offset: 0x0006085C
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x0000AA00 File Offset: 0x00008C00
		public unsafe bool is_blocking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_blocking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_blocking)) = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x00062684 File Offset: 0x00060884
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x0000AA1B File Offset: 0x00008C1B
		public unsafe bool is_bound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_bound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_bound)) = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x000626AC File Offset: 0x000608AC
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x0000AA36 File Offset: 0x00008C36
		public unsafe bool is_connected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_connected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_connected)) = value;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x000626D4 File Offset: 0x000608D4
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x0000AA51 File Offset: 0x00008C51
		public unsafe int m_IntCleanedUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_IntCleanedUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_IntCleanedUp)) = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x000626FC File Offset: 0x000608FC
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x0000AA6C File Offset: 0x00008C6C
		public unsafe bool connect_in_progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_connect_in_progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_connect_in_progress)) = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00062724 File Offset: 0x00060924
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x0000AA87 File Offset: 0x00008C87
		public unsafe int ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_ID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_ID)) = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x0006274C File Offset: 0x0006094C
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x0000AAA2 File Offset: 0x00008CA2
		public unsafe static AsyncCallback AcceptAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_AcceptAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_AcceptAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00062774 File Offset: 0x00060974
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		public unsafe static IOAsyncCallback BeginAcceptCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginAcceptCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginAcceptCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x0006279C File Offset: 0x0006099C
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x0000AAC6 File Offset: 0x00008CC6
		public unsafe static IOAsyncCallback BeginAcceptReceiveCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginAcceptReceiveCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginAcceptReceiveCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x000627C4 File Offset: 0x000609C4
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		public unsafe static AsyncCallback ConnectAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_ConnectAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_ConnectAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x000627EC File Offset: 0x000609EC
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x0000AAEA File Offset: 0x00008CEA
		public unsafe static IOAsyncCallback BeginConnectCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginConnectCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginConnectCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00062814 File Offset: 0x00060A14
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x0000AAFC File Offset: 0x00008CFC
		public unsafe static AsyncCallback DisconnectAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_DisconnectAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_DisconnectAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x0006283C File Offset: 0x00060A3C
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x0000AB0E File Offset: 0x00008D0E
		public unsafe static IOAsyncCallback BeginDisconnectCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginDisconnectCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginDisconnectCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00062864 File Offset: 0x00060A64
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x0000AB20 File Offset: 0x00008D20
		public unsafe static AsyncCallback ReceiveAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_ReceiveAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_ReceiveAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x0006288C File Offset: 0x00060A8C
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x0000AB32 File Offset: 0x00008D32
		public unsafe static IOAsyncCallback BeginReceiveCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginReceiveCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginReceiveCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x000628B4 File Offset: 0x00060AB4
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x0000AB44 File Offset: 0x00008D44
		public unsafe static IOAsyncCallback BeginReceiveGenericCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginReceiveGenericCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginReceiveGenericCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x000628DC File Offset: 0x00060ADC
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x0000AB56 File Offset: 0x00008D56
		public unsafe static AsyncCallback ReceiveFromAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_ReceiveFromAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_ReceiveFromAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00062904 File Offset: 0x00060B04
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x0000AB68 File Offset: 0x00008D68
		public unsafe static IOAsyncCallback BeginReceiveFromCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginReceiveFromCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginReceiveFromCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0006292C File Offset: 0x00060B2C
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x0000AB7A File Offset: 0x00008D7A
		public unsafe static AsyncCallback SendAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_SendAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_SendAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00062954 File Offset: 0x00060B54
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x0000AB8C File Offset: 0x00008D8C
		public unsafe static IOAsyncCallback BeginSendGenericCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginSendGenericCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginSendGenericCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x0006297C File Offset: 0x00060B7C
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x0000AB9E File Offset: 0x00008D9E
		public unsafe static AsyncCallback SendToAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_SendToAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_SendToAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeFieldInfoPtr_s_SupportsIPv4;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeFieldInfoPtr_s_SupportsIPv6;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeFieldInfoPtr_s_OSSupportsIPv6;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeFieldInfoPtr_s_Initialized;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeFieldInfoPtr_s_LoggingEnabled;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeFieldInfoPtr_s_PerfCountersEnabled;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCloseTimeout;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeFieldInfoPtr_SOCKET_CLOSED_CODE;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeFieldInfoPtr_TIMEOUT_EXCEPTION_MSG;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeFieldInfoPtr_is_closed;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeFieldInfoPtr_is_listening;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeFieldInfoPtr_useOverlappedIO;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeFieldInfoPtr_linger_timeout;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeFieldInfoPtr_addressFamily;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeFieldInfoPtr_socketType;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeFieldInfoPtr_protocolType;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeFieldInfoPtr_seed_endpoint;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeFieldInfoPtr_ReadSem;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeFieldInfoPtr_WriteSem;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeFieldInfoPtr_is_blocking;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeFieldInfoPtr_is_bound;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeFieldInfoPtr_is_connected;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeFieldInfoPtr_m_IntCleanedUp;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeFieldInfoPtr_connect_in_progress;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeFieldInfoPtr_AcceptAsyncCallback;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeFieldInfoPtr_BeginAcceptCallback;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeFieldInfoPtr_BeginAcceptReceiveCallback;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeFieldInfoPtr_ConnectAsyncCallback;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeFieldInfoPtr_BeginConnectCallback;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeFieldInfoPtr_DisconnectAsyncCallback;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeFieldInfoPtr_BeginDisconnectCallback;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeFieldInfoPtr_ReceiveAsyncCallback;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeFieldInfoPtr_BeginReceiveCallback;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeFieldInfoPtr_BeginReceiveGenericCallback;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeFieldInfoPtr_ReceiveFromAsyncCallback;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeFieldInfoPtr_BeginReceiveFromCallback;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeFieldInfoPtr_SendAsyncCallback;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeFieldInfoPtr_BeginSendGenericCallback;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeFieldInfoPtr_SendToAsyncCallback;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsIPv4_Public_Static_get_Boolean_0;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsIPv6_Public_Static_get_Boolean_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_set_ReceiveTimeout_Public_set_Void_Int32_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_set_SendTimeout_Public_set_Void_Int32_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr_SocketDefaults_Private_Void_0;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr_Socket_internal_Private_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_Blocking_internal_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr_Accept_Public_Socket_0;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeMethodInfoPtr_Accept_Internal_Void_Socket_0;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_Accept_internal_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_Bind_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_Listen_Public_Void_Int32_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_Listen_internal_Private_Static_Void_IntPtr_Int32_byref_Int32_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_ConnectAsync_Public_Boolean_SocketAsyncEventArgs_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_Il2CppReferenceArray_1_IPAddress_Int32_AsyncCallback_Object_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_BeginMConnect_Private_Static_Void_SocketAsyncResult_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_BeginSConnect_Private_Static_Void_SocketAsyncResult_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_Connect_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_GetCheckedIPs_Private_Boolean_SocketAsyncEventArgs_byref_Il2CppReferenceArray_1_IPAddress_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_IntPtr_Boolean_byref_Int32_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveAsync_Public_Boolean_SocketAsyncEventArgs_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFrom_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_EndReceiveFrom_Public_Int32_IAsyncResult_byref_EndPoint_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Boolean_SocketAsyncEventArgs_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Int32_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_Close_internal_Internal_Static_Void_IntPtr_byref_Int32_0;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Void_SocketShutdown_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_internal_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_InitSocketAsyncEventArgs_Private_Void_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_SocketOperationToSocketAsyncOperation_Private_SocketAsyncOperation_SocketOperation_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0;

		// Token: 0x0200020F RID: 527
		[StructLayout(2)]
		public struct WSABUF
		{
			// Token: 0x06001D4E RID: 7502 RVA: 0x00077354 File Offset: 0x00075554
			// Note: this type is marked as 'beforefieldinit'.
			static WSABUF()
			{
				Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "WSABUF");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr);
				Socket.WSABUF.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr, "len");
				Socket.WSABUF.NativeFieldInfoPtr_buf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr, "buf");
			}

			// Token: 0x06001D4F RID: 7503 RVA: 0x0001015A File Offset: 0x0000E35A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr, ref this));
			}

			// Token: 0x0400163B RID: 5691
			private static readonly IntPtr NativeFieldInfoPtr_len;

			// Token: 0x0400163C RID: 5692
			private static readonly IntPtr NativeFieldInfoPtr_buf;

			// Token: 0x0400163D RID: 5693
			[FieldOffset(0)]
			public int len;

			// Token: 0x0400163E RID: 5694
			[FieldOffset(8)]
			public IntPtr buf;
		}

		// Token: 0x02000210 RID: 528
		[ObfuscatedName("System.Net.Sockets.Socket+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D50 RID: 7504 RVA: 0x000773A8 File Offset: 0x000755A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Socket.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr);
				Socket.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9");
				Socket.__c.NativeFieldInfoPtr___9__240_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__240_0");
				Socket.__c.NativeFieldInfoPtr___9__242_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__242_0");
				Socket.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666383);
				Socket.__c.NativeMethodInfoPtr__SendAsync_b__240_0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666384);
				Socket.__c.NativeMethodInfoPtr__BeginSend_b__242_0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666385);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666386);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_1_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666387);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_2_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666388);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_3_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666389);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_4_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666390);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_5_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666391);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_6_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666392);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_7_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666393);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_8_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666394);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_9_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666395);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_10_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666396);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_11_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666397);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_12_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666398);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_13_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666399);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_14_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666400);
			}

			// Token: 0x06001D51 RID: 7505 RVA: 0x00077578 File Offset: 0x00075778
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D52 RID: 7506 RVA: 0x000775B4 File Offset: 0x000757B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386664, XrefRangeEnd = 386671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SendAsync_b__240_0(IOAsyncResult s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__SendAsync_b__240_0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D53 RID: 7507 RVA: 0x000775F8 File Offset: 0x000757F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386671, XrefRangeEnd = 386678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BeginSend_b__242_0(IOAsyncResult s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__BeginSend_b__242_0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D54 RID: 7508 RVA: 0x0007763C File Offset: 0x0007583C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386678, XrefRangeEnd = 386698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_0(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D55 RID: 7509 RVA: 0x00077680 File Offset: 0x00075880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386698, XrefRangeEnd = 386704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_1(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_1_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D56 RID: 7510 RVA: 0x000776C4 File Offset: 0x000758C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386704, XrefRangeEnd = 386718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_2(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_2_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D57 RID: 7511 RVA: 0x00077708 File Offset: 0x00075908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386718, XrefRangeEnd = 386726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_3(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_3_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D58 RID: 7512 RVA: 0x0007774C File Offset: 0x0007594C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386726, XrefRangeEnd = 386751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_4(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_4_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D59 RID: 7513 RVA: 0x00077790 File Offset: 0x00075990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386751, XrefRangeEnd = 386766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_5(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_5_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D5A RID: 7514 RVA: 0x000777D4 File Offset: 0x000759D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386766, XrefRangeEnd = 386774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_6(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_6_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D5B RID: 7515 RVA: 0x00077818 File Offset: 0x00075A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386774, XrefRangeEnd = 386782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_7(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_7_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D5C RID: 7516 RVA: 0x0007785C File Offset: 0x00075A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386782, XrefRangeEnd = 386791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_8(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_8_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D5D RID: 7517 RVA: 0x000778A0 File Offset: 0x00075AA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386791, XrefRangeEnd = 386795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_9(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_9_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D5E RID: 7518 RVA: 0x000778E4 File Offset: 0x00075AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386795, XrefRangeEnd = 386810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_10(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_10_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D5F RID: 7519 RVA: 0x00077928 File Offset: 0x00075B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386810, XrefRangeEnd = 386815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_11(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_11_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D60 RID: 7520 RVA: 0x0007796C File Offset: 0x00075B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386815, XrefRangeEnd = 386823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_12(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_12_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D61 RID: 7521 RVA: 0x000779B0 File Offset: 0x00075BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386823, XrefRangeEnd = 386827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_13(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_13_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D62 RID: 7522 RVA: 0x000779F4 File Offset: 0x00075BF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386827, XrefRangeEnd = 386842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_14(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_14_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D63 RID: 7523 RVA: 0x0001016C File Offset: 0x0000E36C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000977 RID: 2423
			// (get) Token: 0x06001D64 RID: 7524 RVA: 0x00077A38 File Offset: 0x00075C38
			// (set) Token: 0x06001D65 RID: 7525 RVA: 0x00010175 File Offset: 0x0000E375
			public unsafe static Socket.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000978 RID: 2424
			// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00077A60 File Offset: 0x00075C60
			// (set) Token: 0x06001D67 RID: 7527 RVA: 0x00010187 File Offset: 0x0000E387
			public unsafe static IOAsyncCallback __9__240_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__240_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__240_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000979 RID: 2425
			// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00077A88 File Offset: 0x00075C88
			// (set) Token: 0x06001D69 RID: 7529 RVA: 0x00010199 File Offset: 0x0000E399
			public unsafe static IOAsyncCallback __9__242_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__242_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__242_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400163F RID: 5695
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001640 RID: 5696
			private static readonly IntPtr NativeFieldInfoPtr___9__240_0;

			// Token: 0x04001641 RID: 5697
			private static readonly IntPtr NativeFieldInfoPtr___9__242_0;

			// Token: 0x04001642 RID: 5698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001643 RID: 5699
			private static readonly IntPtr NativeMethodInfoPtr__SendAsync_b__240_0_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001644 RID: 5700
			private static readonly IntPtr NativeMethodInfoPtr__BeginSend_b__242_0_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001645 RID: 5701
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_0_Internal_Void_IAsyncResult_0;

			// Token: 0x04001646 RID: 5702
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_1_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001647 RID: 5703
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_2_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001648 RID: 5704
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_3_Internal_Void_IAsyncResult_0;

			// Token: 0x04001649 RID: 5705
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_4_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400164A RID: 5706
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_5_Internal_Void_IAsyncResult_0;

			// Token: 0x0400164B RID: 5707
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_6_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400164C RID: 5708
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_7_Internal_Void_IAsyncResult_0;

			// Token: 0x0400164D RID: 5709
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_8_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400164E RID: 5710
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_9_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400164F RID: 5711
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_10_Internal_Void_IAsyncResult_0;

			// Token: 0x04001650 RID: 5712
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_11_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001651 RID: 5713
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_12_Internal_Void_IAsyncResult_0;

			// Token: 0x04001652 RID: 5714
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_13_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001653 RID: 5715
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_14_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x02000211 RID: 529
		[ObfuscatedName("System.Net.Sockets.Socket+<>c__DisplayClass243_0")]
		public sealed class __c__DisplayClass243_0 : Object
		{
			// Token: 0x06001D6A RID: 7530 RVA: 0x00077AB0 File Offset: 0x00075CB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass243_0()
			{
				Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c__DisplayClass243_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr);
				Socket.__c__DisplayClass243_0.NativeFieldInfoPtr_sent_so_far = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr, "sent_so_far");
				Socket.__c__DisplayClass243_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr, 100666401);
				Socket.__c__DisplayClass243_0.NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr, 100666402);
			}

			// Token: 0x06001D6B RID: 7531 RVA: 0x00077B18 File Offset: 0x00075D18
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass243_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass243_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D6C RID: 7532 RVA: 0x00077B54 File Offset: 0x00075D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386842, XrefRangeEnd = 386849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BeginSendCallback_b__0(IOAsyncResult s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass243_0.NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D6D RID: 7533 RVA: 0x000101AB File Offset: 0x0000E3AB
			public __c__DisplayClass243_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700097A RID: 2426
			// (get) Token: 0x06001D6E RID: 7534 RVA: 0x00077B98 File Offset: 0x00075D98
			// (set) Token: 0x06001D6F RID: 7535 RVA: 0x000101B4 File Offset: 0x0000E3B4
			public unsafe int sent_so_far
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass243_0.NativeFieldInfoPtr_sent_so_far);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass243_0.NativeFieldInfoPtr_sent_so_far)) = value;
				}
			}

			// Token: 0x04001654 RID: 5716
			private static readonly IntPtr NativeFieldInfoPtr_sent_so_far;

			// Token: 0x04001655 RID: 5717
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001656 RID: 5718
			private static readonly IntPtr NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0;
		}

		// Token: 0x02000212 RID: 530
		[ObfuscatedName("System.Net.Sockets.Socket+<>c__DisplayClass299_0")]
		public sealed class __c__DisplayClass299_0 : Object
		{
			// Token: 0x06001D70 RID: 7536 RVA: 0x00077BC0 File Offset: 0x00075DC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass299_0()
			{
				Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c__DisplayClass299_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr);
				Socket.__c__DisplayClass299_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr, "<>4__this");
				Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr, "job");
				Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr, "handle");
				Socket.__c__DisplayClass299_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr, 100666403);
				Socket.__c__DisplayClass299_0.NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr, 100666404);
			}

			// Token: 0x06001D71 RID: 7537 RVA: 0x00077C50 File Offset: 0x00075E50
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass299_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass299_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D72 RID: 7538 RVA: 0x00077C8C File Offset: 0x00075E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386849, XrefRangeEnd = 386855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _QueueIOSelectorJob_b__0(Task t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass299_0.NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D73 RID: 7539 RVA: 0x000101CF File Offset: 0x0000E3CF
			public __c__DisplayClass299_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700097B RID: 2427
			// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00077CD0 File Offset: 0x00075ED0
			// (set) Token: 0x06001D75 RID: 7541 RVA: 0x000101D8 File Offset: 0x0000E3D8
			public unsafe Socket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097C RID: 2428
			// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00077D00 File Offset: 0x00075F00
			// (set) Token: 0x06001D77 RID: 7543 RVA: 0x000101F7 File Offset: 0x0000E3F7
			public unsafe IOSelectorJob job
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_job);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOSelectorJob>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_job), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097D RID: 2429
			// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00077D30 File Offset: 0x00075F30
			// (set) Token: 0x06001D79 RID: 7545 RVA: 0x00010216 File Offset: 0x0000E416
			public unsafe IntPtr handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_handle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_handle)) = value;
				}
			}

			// Token: 0x04001657 RID: 5719
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001658 RID: 5720
			private static readonly IntPtr NativeFieldInfoPtr_job;

			// Token: 0x04001659 RID: 5721
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x0400165A RID: 5722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400165B RID: 5723
			private static readonly IntPtr NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0;
		}
	}
}
