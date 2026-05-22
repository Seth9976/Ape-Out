using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net
{
	// Token: 0x0200012D RID: 301
	public sealed class FtpWebRequest : WebRequest
	{
		// Token: 0x060010E5 RID: 4325 RVA: 0x00050350 File Offset: 0x0004E550
		// Note: this type is marked as 'beforefieldinit'.
		static FtpWebRequest()
		{
			Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpWebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr);
			FtpWebRequest.NativeFieldInfoPtr_requestUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "requestUri");
			FtpWebRequest.NativeFieldInfoPtr_file_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "file_name");
			FtpWebRequest.NativeFieldInfoPtr_servicePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "servicePoint");
			FtpWebRequest.NativeFieldInfoPtr_origDataStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "origDataStream");
			FtpWebRequest.NativeFieldInfoPtr_dataStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "dataStream");
			FtpWebRequest.NativeFieldInfoPtr_controlStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "controlStream");
			FtpWebRequest.NativeFieldInfoPtr_controlReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "controlReader");
			FtpWebRequest.NativeFieldInfoPtr_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "credentials");
			FtpWebRequest.NativeFieldInfoPtr_hostEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "hostEntry");
			FtpWebRequest.NativeFieldInfoPtr_localEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "localEndPoint");
			FtpWebRequest.NativeFieldInfoPtr_remoteEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "remoteEndPoint");
			FtpWebRequest.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "proxy");
			FtpWebRequest.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "timeout");
			FtpWebRequest.NativeFieldInfoPtr_rwTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "rwTimeout");
			FtpWebRequest.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "offset");
			FtpWebRequest.NativeFieldInfoPtr_binary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "binary");
			FtpWebRequest.NativeFieldInfoPtr_enableSsl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "enableSsl");
			FtpWebRequest.NativeFieldInfoPtr_usePassive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "usePassive");
			FtpWebRequest.NativeFieldInfoPtr_keepAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "keepAlive");
			FtpWebRequest.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "method");
			FtpWebRequest.NativeFieldInfoPtr_renameTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "renameTo");
			FtpWebRequest.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "locker");
			FtpWebRequest.NativeFieldInfoPtr_requestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "requestState");
			FtpWebRequest.NativeFieldInfoPtr_asyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "asyncResult");
			FtpWebRequest.NativeFieldInfoPtr_ftpResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "ftpResponse");
			FtpWebRequest.NativeFieldInfoPtr_requestStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "requestStream");
			FtpWebRequest.NativeFieldInfoPtr_initial_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "initial_path");
			FtpWebRequest.NativeFieldInfoPtr_supportedCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "supportedCommands");
			FtpWebRequest.NativeFieldInfoPtr_dataEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "dataEncoding");
			FtpWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665712);
			FtpWebRequest.NativeMethodInfoPtr_GetMustImplement_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665713);
			FtpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665714);
			FtpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665715);
			FtpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665716);
			FtpWebRequest.NativeMethodInfoPtr_get_EnableSsl_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665717);
			FtpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665718);
			FtpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665719);
			FtpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665720);
			FtpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665721);
			FtpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665722);
			FtpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665723);
			FtpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665724);
			FtpWebRequest.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665725);
			FtpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665726);
			FtpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665727);
			FtpWebRequest.NativeMethodInfoPtr_get_DataType_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665728);
			FtpWebRequest.NativeMethodInfoPtr_get_State_Private_get_RequestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665729);
			FtpWebRequest.NativeMethodInfoPtr_set_State_Private_set_Void_RequestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665730);
			FtpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665731);
			FtpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665732);
			FtpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665733);
			FtpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665734);
			FtpWebRequest.NativeMethodInfoPtr_GetServicePoint_Private_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665735);
			FtpWebRequest.NativeMethodInfoPtr_ResolveHost_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665736);
			FtpWebRequest.NativeMethodInfoPtr_ProcessRequest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665737);
			FtpWebRequest.NativeMethodInfoPtr_SetType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665738);
			FtpWebRequest.NativeMethodInfoPtr_GetRemoteFolderPath_Private_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665739);
			FtpWebRequest.NativeMethodInfoPtr_CWDAndSetFileName_Private_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665740);
			FtpWebRequest.NativeMethodInfoPtr_ProcessMethod_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665741);
			FtpWebRequest.NativeMethodInfoPtr_CloseControlConnection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665742);
			FtpWebRequest.NativeMethodInfoPtr_CloseDataConnection_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665743);
			FtpWebRequest.NativeMethodInfoPtr_CloseConnection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665744);
			FtpWebRequest.NativeMethodInfoPtr_ProcessSimpleMethod_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665745);
			FtpWebRequest.NativeMethodInfoPtr_UploadData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665746);
			FtpWebRequest.NativeMethodInfoPtr_DownloadData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665747);
			FtpWebRequest.NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665748);
			FtpWebRequest.NativeMethodInfoPtr_OpenControlConnection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665749);
			FtpWebRequest.NativeMethodInfoPtr_GetInitialPath_Private_Static_String_FtpStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665750);
			FtpWebRequest.NativeMethodInfoPtr_SetupPassiveConnection_Private_Socket_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665751);
			FtpWebRequest.NativeMethodInfoPtr_GetPortV4_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665752);
			FtpWebRequest.NativeMethodInfoPtr_GetPortV6_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665753);
			FtpWebRequest.NativeMethodInfoPtr_FormatAddress_Private_String_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665754);
			FtpWebRequest.NativeMethodInfoPtr_FormatAddressV6_Private_String_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665755);
			FtpWebRequest.NativeMethodInfoPtr_CreateExceptionFromResponse_Private_Exception_FtpStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665756);
			FtpWebRequest.NativeMethodInfoPtr_SetTransferCompleted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665757);
			FtpWebRequest.NativeMethodInfoPtr_OperationCompleted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665758);
			FtpWebRequest.NativeMethodInfoPtr_SetCompleteWithError_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665759);
			FtpWebRequest.NativeMethodInfoPtr_InitDataConnection_Private_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665760);
			FtpWebRequest.NativeMethodInfoPtr_OpenDataConnection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665761);
			FtpWebRequest.NativeMethodInfoPtr_Authenticate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665762);
			FtpWebRequest.NativeMethodInfoPtr_SendCommand_Private_FtpStatus_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665763);
			FtpWebRequest.NativeMethodInfoPtr_SendCommand_Private_FtpStatus_Boolean_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665764);
			FtpWebRequest.NativeMethodInfoPtr_ServiceNotAvailable_Internal_Static_FtpStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665765);
			FtpWebRequest.NativeMethodInfoPtr_GetResponseStatus_Internal_FtpStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665766);
			FtpWebRequest.NativeMethodInfoPtr_InitiateSecureConnection_Private_Void_byref_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665767);
			FtpWebRequest.NativeMethodInfoPtr_ChangeToSSLSocket_Internal_Boolean_byref_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665768);
			FtpWebRequest.NativeMethodInfoPtr_InFinalState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665769);
			FtpWebRequest.NativeMethodInfoPtr_InProgress_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665770);
			FtpWebRequest.NativeMethodInfoPtr_CheckIfAborted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665771);
			FtpWebRequest.NativeMethodInfoPtr_CheckFinalState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665772);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00050A88 File Offset: 0x0004EC88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380961, RefRangeEnd = 380962, XrefRangeStart = 380938, XrefRangeEnd = 380961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpWebRequest(Uri uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00050AD4 File Offset: 0x0004ECD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380968, RefRangeEnd = 380970, XrefRangeStart = 380962, XrefRangeEnd = 380968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetMustImplement()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetMustImplement_Private_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00050B08 File Offset: 0x0004ED08
		public unsafe override long ContentLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00050B44 File Offset: 0x0004ED44
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x00050B84 File Offset: 0x0004ED84
		public unsafe override ICredentials Credentials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380970, XrefRangeEnd = 380973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x00050BC8 File Offset: 0x0004EDC8
		public unsafe bool EnableSsl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_EnableSsl_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x00050C04 File Offset: 0x0004EE04
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380973, XrefRangeEnd = 380980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00050C44 File Offset: 0x0004EE44
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x00050C7C File Offset: 0x0004EE7C
		public unsafe override string Method
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380980, XrefRangeEnd = 381007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x00050CC0 File Offset: 0x0004EEC0
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x00050D00 File Offset: 0x0004EF00
		public unsafe override IWebProxy Proxy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381007, XrefRangeEnd = 381008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x00050D44 File Offset: 0x0004EF44
		public unsafe int ReadWriteTimeout
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89523, RefRangeEnd = 89524, XrefRangeStart = 89523, XrefRangeEnd = 89524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00050D80 File Offset: 0x0004EF80
		public unsafe override Uri RequestUri
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x00050DC0 File Offset: 0x0004EFC0
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381008, XrefRangeEnd = 381009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00050E00 File Offset: 0x0004F000
		public unsafe override bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381009, XrefRangeEnd = 381016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x00050E3C File Offset: 0x0004F03C
		public unsafe override int Timeout
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 381016, RefRangeEnd = 381017, XrefRangeStart = 381016, XrefRangeEnd = 381016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00050E78 File Offset: 0x0004F078
		public unsafe string DataType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381017, XrefRangeEnd = 381021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_DataType_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x00050EB0 File Offset: 0x0004F0B0
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x00050EEC File Offset: 0x0004F0EC
		public unsafe FtpWebRequest.RequestState State
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 381024, RefRangeEnd = 381055, XrefRangeStart = 381021, XrefRangeEnd = 381024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_State_Private_get_RequestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 381062, RefRangeEnd = 381078, XrefRangeStart = 381055, XrefRangeEnd = 381062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_State_Private_set_Void_RequestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00050F2C File Offset: 0x0004F12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381078, XrefRangeEnd = 381098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00050F60 File Offset: 0x0004F160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381098, XrefRangeEnd = 381127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginGetResponse(AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00050FC4 File Offset: 0x0004F1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381127, XrefRangeEnd = 381132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00051014 File Offset: 0x0004F214
		[CallerCount(0)]
		public unsafe override WebResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00051054 File Offset: 0x0004F254
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 381136, RefRangeEnd = 381141, XrefRangeStart = 381132, XrefRangeEnd = 381136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePoint GetServicePoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetServicePoint_Private_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00051094 File Offset: 0x0004F294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381141, XrefRangeEnd = 381144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveHost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ResolveHost_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x000510C8 File Offset: 0x0004F2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381144, XrefRangeEnd = 381153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ProcessRequest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x000510FC File Offset: 0x0004F2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381153, XrefRangeEnd = 381165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SetType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00051130 File Offset: 0x0004F330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381199, RefRangeEnd = 381200, XrefRangeStart = 381165, XrefRangeEnd = 381199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRemoteFolderPath(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetRemoteFolderPath_Private_String_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00051178 File Offset: 0x0004F378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381217, RefRangeEnd = 381218, XrefRangeStart = 381200, XrefRangeEnd = 381217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CWDAndSetFileName(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CWDAndSetFileName_Private_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x000511BC File Offset: 0x0004F3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381218, XrefRangeEnd = 381299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ProcessMethod_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x000511F0 File Offset: 0x0004F3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381299, XrefRangeEnd = 381305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseControlConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CloseControlConnection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00051224 File Offset: 0x0004F424
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 381305, RefRangeEnd = 381308, XrefRangeStart = 381305, XrefRangeEnd = 381305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseDataConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CloseDataConnection_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00051258 File Offset: 0x0004F458
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 381316, RefRangeEnd = 381319, XrefRangeStart = 381308, XrefRangeEnd = 381316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CloseConnection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0005128C File Offset: 0x0004F48C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381444, RefRangeEnd = 381445, XrefRangeStart = 381319, XrefRangeEnd = 381444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSimpleMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ProcessSimpleMethod_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x000512C0 File Offset: 0x0004F4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381445, XrefRangeEnd = 381452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UploadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_UploadData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x000512F4 File Offset: 0x0004F4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381452, XrefRangeEnd = 381459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DownloadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_DownloadData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00051328 File Offset: 0x0004F528
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 381460, RefRangeEnd = 381463, XrefRangeStart = 381459, XrefRangeEnd = 381460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRequestStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0005135C File Offset: 0x0004F55C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381524, RefRangeEnd = 381525, XrefRangeStart = 381463, XrefRangeEnd = 381524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenControlConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_OpenControlConnection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00051390 File Offset: 0x0004F590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381533, RefRangeEnd = 381534, XrefRangeStart = 381525, XrefRangeEnd = 381533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetInitialPath(FtpStatus status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(status);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetInitialPath_Private_Static_String_FtpStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x000513CC File Offset: 0x0004F5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381534, XrefRangeEnd = 381546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket SetupPassiveConnection(string statusDescription, bool ipv6)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(statusDescription);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ipv6;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SetupPassiveConnection_Private_Socket_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0005142C File Offset: 0x0004F62C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381569, RefRangeEnd = 381570, XrefRangeStart = 381546, XrefRangeEnd = 381569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPortV4(string responseString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(responseString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetPortV4_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0005147C File Offset: 0x0004F67C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381587, RefRangeEnd = 381588, XrefRangeStart = 381570, XrefRangeEnd = 381587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPortV6(string responseString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(responseString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetPortV6_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000514CC File Offset: 0x0004F6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381588, XrefRangeEnd = 381605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatAddress(IPAddress address, int Port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_FormatAddress_Private_String_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00051524 File Offset: 0x0004F724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381605, XrefRangeEnd = 381623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatAddressV6(IPAddress address, int port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_FormatAddressV6_Private_String_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0005157C File Offset: 0x0004F77C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 381634, RefRangeEnd = 381643, XrefRangeStart = 381623, XrefRangeEnd = 381634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateExceptionFromResponse(FtpStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(status);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CreateExceptionFromResponse_Private_Exception_FtpStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x000515CC File Offset: 0x0004F7CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381649, RefRangeEnd = 381651, XrefRangeStart = 381643, XrefRangeEnd = 381649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransferCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SetTransferCompleted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00051600 File Offset: 0x0004F800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381651, XrefRangeEnd = 381652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OperationCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_OperationCompleted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00051634 File Offset: 0x0004F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381652, XrefRangeEnd = 381653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompleteWithError(Exception exc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SetCompleteWithError_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00051678 File Offset: 0x0004F878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381714, RefRangeEnd = 381715, XrefRangeStart = 381653, XrefRangeEnd = 381714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket InitDataConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_InitDataConnection_Private_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x000516B8 File Offset: 0x0004F8B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 381766, RefRangeEnd = 381770, XrefRangeStart = 381715, XrefRangeEnd = 381766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenDataConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_OpenDataConnection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000516EC File Offset: 0x0004F8EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381837, RefRangeEnd = 381838, XrefRangeStart = 381770, XrefRangeEnd = 381837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Authenticate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_Authenticate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00051720 File Offset: 0x0004F920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381838, XrefRangeEnd = 381839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpStatus SendCommand(string command, [Optional] Il2CppStringArray parameters)
		{
			if (parameters == null)
			{
				parameters = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SendCommand_Private_FtpStatus_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpStatus>(intPtr3) : null;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00051790 File Offset: 0x0004F990
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 381848, RefRangeEnd = 381869, XrefRangeStart = 381839, XrefRangeEnd = 381848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpStatus SendCommand(bool waitResponse, string command, [Optional] Il2CppStringArray parameters)
		{
			if (parameters == null)
			{
				parameters = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref waitResponse;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(command);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SendCommand_Private_FtpStatus_Boolean_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpStatus>(intPtr3) : null;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00051810 File Offset: 0x0004FA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381869, XrefRangeEnd = 381874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FtpStatus ServiceNotAvailable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ServiceNotAvailable_Internal_Static_FtpStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpStatus>(intPtr3) : null;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00051844 File Offset: 0x0004FA44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 381893, RefRangeEnd = 381897, XrefRangeStart = 381874, XrefRangeEnd = 381893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpStatus GetResponseStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetResponseStatus_Internal_FtpStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpStatus>(intPtr3) : null;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00051884 File Offset: 0x0004FA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381897, XrefRangeEnd = 381915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitiateSecureConnection(ref Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_InitiateSecureConnection_Private_Void_byref_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stream = ((intPtr4 == 0) ? null : new Stream(intPtr4));
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x000518DC File Offset: 0x0004FADC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 381926, RefRangeEnd = 381929, XrefRangeStart = 381915, XrefRangeEnd = 381926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ChangeToSSLSocket(ref Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ChangeToSSLSocket_Internal_Boolean_byref_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stream = ((intPtr4 == 0) ? null : new Stream(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00051940 File Offset: 0x0004FB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381929, XrefRangeEnd = 381932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InFinalState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_InFinalState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0005197C File Offset: 0x0004FB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381932, XrefRangeEnd = 381936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_InProgress_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x000519B8 File Offset: 0x0004FBB8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 381937, RefRangeEnd = 381947, XrefRangeStart = 381936, XrefRangeEnd = 381937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIfAborted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CheckIfAborted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x000519EC File Offset: 0x0004FBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381947, XrefRangeEnd = 381950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckFinalState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CheckFinalState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00008A73 File Offset: 0x00006C73
		public FtpStatus SendCommand(string command, params string[] parameters)
		{
			return this.SendCommand(command, new Il2CppStringArray(parameters));
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00008A82 File Offset: 0x00006C82
		public FtpStatus SendCommand(bool waitResponse, string command, params string[] parameters)
		{
			return this.SendCommand(waitResponse, command, new Il2CppStringArray(parameters));
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00008A92 File Offset: 0x00006C92
		public FtpWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x00051A20 File Offset: 0x0004FC20
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x00008A9B File Offset: 0x00006C9B
		public unsafe Uri requestUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x00051A50 File Offset: 0x0004FC50
		// (set) Token: 0x06001129 RID: 4393 RVA: 0x00008ABA File Offset: 0x00006CBA
		public unsafe string file_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_file_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_file_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00051A78 File Offset: 0x0004FC78
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x00008AD9 File Offset: 0x00006CD9
		public unsafe ServicePoint servicePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_servicePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_servicePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x00051AA8 File Offset: 0x0004FCA8
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x00008AF8 File Offset: 0x00006CF8
		public unsafe Stream origDataStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_origDataStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_origDataStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x00051AD8 File Offset: 0x0004FCD8
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x00008B17 File Offset: 0x00006D17
		public unsafe Stream dataStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_dataStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_dataStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x00051B08 File Offset: 0x0004FD08
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x00008B36 File Offset: 0x00006D36
		public unsafe Stream controlStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_controlStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_controlStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00051B38 File Offset: 0x0004FD38
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x00008B55 File Offset: 0x00006D55
		public unsafe StreamReader controlReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_controlReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_controlReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x00051B68 File Offset: 0x0004FD68
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x00008B74 File Offset: 0x00006D74
		public unsafe NetworkCredential credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x00051B98 File Offset: 0x0004FD98
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x00008B93 File Offset: 0x00006D93
		public unsafe IPHostEntry hostEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_hostEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_hostEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x00051BC8 File Offset: 0x0004FDC8
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x00008BB2 File Offset: 0x00006DB2
		public unsafe IPEndPoint localEndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_localEndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_localEndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x00051BF8 File Offset: 0x0004FDF8
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x00008BD1 File Offset: 0x00006DD1
		public unsafe IPEndPoint remoteEndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_remoteEndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_remoteEndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x00051C28 File Offset: 0x0004FE28
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x00008BF0 File Offset: 0x00006DF0
		public unsafe IWebProxy proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x00051C58 File Offset: 0x0004FE58
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x00008C0F File Offset: 0x00006E0F
		public unsafe int timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x00051C80 File Offset: 0x0004FE80
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x00008C2A File Offset: 0x00006E2A
		public unsafe int rwTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_rwTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_rwTimeout)) = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x00051CA8 File Offset: 0x0004FEA8
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x00008C45 File Offset: 0x00006E45
		public unsafe long offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x00051CD0 File Offset: 0x0004FED0
		// (set) Token: 0x06001145 RID: 4421 RVA: 0x00008C60 File Offset: 0x00006E60
		public unsafe bool binary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_binary);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_binary)) = value;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x00051CF8 File Offset: 0x0004FEF8
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x00008C7B File Offset: 0x00006E7B
		public unsafe bool enableSsl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_enableSsl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_enableSsl)) = value;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x00051D20 File Offset: 0x0004FF20
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x00008C96 File Offset: 0x00006E96
		public unsafe bool usePassive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_usePassive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_usePassive)) = value;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00051D48 File Offset: 0x0004FF48
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x00008CB1 File Offset: 0x00006EB1
		public unsafe bool keepAlive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_keepAlive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_keepAlive)) = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00051D70 File Offset: 0x0004FF70
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x00008CCC File Offset: 0x00006ECC
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00051D98 File Offset: 0x0004FF98
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x00008CEB File Offset: 0x00006EEB
		public unsafe string renameTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_renameTo);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_renameTo), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00051DC0 File Offset: 0x0004FFC0
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x00008D0A File Offset: 0x00006F0A
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x00051DF0 File Offset: 0x0004FFF0
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x00008D29 File Offset: 0x00006F29
		public unsafe FtpWebRequest.RequestState requestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestState)) = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x00051E18 File Offset: 0x00050018
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x00008D44 File Offset: 0x00006F44
		public unsafe FtpAsyncResult asyncResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_asyncResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_asyncResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00051E48 File Offset: 0x00050048
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x00008D63 File Offset: 0x00006F63
		public unsafe FtpWebResponse ftpResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_ftpResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpWebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_ftpResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00051E78 File Offset: 0x00050078
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x00008D82 File Offset: 0x00006F82
		public unsafe Stream requestStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x00051EA8 File Offset: 0x000500A8
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x00008DA1 File Offset: 0x00006FA1
		public unsafe string initial_path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_initial_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_initial_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x00051ED0 File Offset: 0x000500D0
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x00008DC0 File Offset: 0x00006FC0
		public unsafe static Il2CppStringArray supportedCommands
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FtpWebRequest.NativeFieldInfoPtr_supportedCommands, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FtpWebRequest.NativeFieldInfoPtr_supportedCommands, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x00051EF8 File Offset: 0x000500F8
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x00008DD2 File Offset: 0x00006FD2
		public unsafe Encoding dataEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_dataEncoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_dataEncoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeFieldInfoPtr_requestUri;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeFieldInfoPtr_file_name;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeFieldInfoPtr_servicePoint;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeFieldInfoPtr_origDataStream;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeFieldInfoPtr_dataStream;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeFieldInfoPtr_controlStream;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeFieldInfoPtr_controlReader;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeFieldInfoPtr_credentials;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeFieldInfoPtr_hostEntry;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeFieldInfoPtr_localEndPoint;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeFieldInfoPtr_remoteEndPoint;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeFieldInfoPtr_proxy;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeFieldInfoPtr_rwTimeout;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeFieldInfoPtr_binary;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeFieldInfoPtr_enableSsl;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeFieldInfoPtr_usePassive;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeFieldInfoPtr_keepAlive;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeFieldInfoPtr_renameTo;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeFieldInfoPtr_requestState;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeFieldInfoPtr_asyncResult;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeFieldInfoPtr_ftpResponse;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeFieldInfoPtr_requestStream;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeFieldInfoPtr_initial_path;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeFieldInfoPtr_supportedCommands;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeFieldInfoPtr_dataEncoding;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_GetMustImplement_Private_Static_Exception_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableSsl_Public_get_Boolean_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Private_get_String_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Private_get_RequestState_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_RequestState_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Void_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_GetServicePoint_Private_ServicePoint_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_ResolveHost_Private_Void_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRequest_Private_Void_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Private_Void_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoteFolderPath_Private_String_Uri_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_CWDAndSetFileName_Private_Void_Uri_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMethod_Private_Void_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_CloseControlConnection_Private_Void_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_CloseDataConnection_Internal_Void_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_CloseConnection_Private_Void_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSimpleMethod_Private_Void_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_UploadData_Private_Void_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_DownloadData_Private_Void_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_OpenControlConnection_Private_Void_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_GetInitialPath_Private_Static_String_FtpStatus_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_SetupPassiveConnection_Private_Socket_String_Boolean_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_GetPortV4_Private_Int32_String_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_GetPortV6_Private_Int32_String_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_FormatAddress_Private_String_IPAddress_Int32_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_FormatAddressV6_Private_String_IPAddress_Int32_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_CreateExceptionFromResponse_Private_Exception_FtpStatus_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_SetTransferCompleted_Internal_Void_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompleted_Internal_Void_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_SetCompleteWithError_Private_Void_Exception_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_InitDataConnection_Private_Socket_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_OpenDataConnection_Private_Void_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Private_Void_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_SendCommand_Private_FtpStatus_String_Il2CppStringArray_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_SendCommand_Private_FtpStatus_Boolean_String_Il2CppStringArray_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_ServiceNotAvailable_Internal_Static_FtpStatus_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStatus_Internal_FtpStatus_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_InitiateSecureConnection_Private_Void_byref_Stream_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_ChangeToSSLSocket_Internal_Boolean_byref_Stream_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_InFinalState_Private_Boolean_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_InProgress_Private_Boolean_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfAborted_Internal_Void_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_CheckFinalState_Private_Void_0;

		// Token: 0x020001E3 RID: 483
		[OriginalName("System.dll", "", "RequestState")]
		public enum RequestState
		{
			// Token: 0x040014B2 RID: 5298
			Before,
			// Token: 0x040014B3 RID: 5299
			Scheduled,
			// Token: 0x040014B4 RID: 5300
			Connecting,
			// Token: 0x040014B5 RID: 5301
			Authenticating,
			// Token: 0x040014B6 RID: 5302
			OpeningData,
			// Token: 0x040014B7 RID: 5303
			TransferInProgress,
			// Token: 0x040014B8 RID: 5304
			Finished,
			// Token: 0x040014B9 RID: 5305
			Aborted,
			// Token: 0x040014BA RID: 5306
			Error
		}
	}
}
