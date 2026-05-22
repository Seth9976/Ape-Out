using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x02000130 RID: 304
	[Serializable]
	public class HttpWebRequest : WebRequest
	{
		// Token: 0x0600118D RID: 4493 RVA: 0x00052904 File Offset: 0x00050B04
		// Note: this type is marked as 'beforefieldinit'.
		static HttpWebRequest()
		{
			Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpWebRequest");
			HttpWebRequest.NativeFieldInfoPtr_requestUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "requestUri");
			HttpWebRequest.NativeFieldInfoPtr_actualUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "actualUri");
			HttpWebRequest.NativeFieldInfoPtr_hostChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "hostChanged");
			HttpWebRequest.NativeFieldInfoPtr_allowAutoRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "allowAutoRedirect");
			HttpWebRequest.NativeFieldInfoPtr_allowBuffering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "allowBuffering");
			HttpWebRequest.NativeFieldInfoPtr_certificates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "certificates");
			HttpWebRequest.NativeFieldInfoPtr_connectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "connectionGroup");
			HttpWebRequest.NativeFieldInfoPtr_haveContentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "haveContentLength");
			HttpWebRequest.NativeFieldInfoPtr_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "contentLength");
			HttpWebRequest.NativeFieldInfoPtr_continueDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "continueDelegate");
			HttpWebRequest.NativeFieldInfoPtr_cookieContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "cookieContainer");
			HttpWebRequest.NativeFieldInfoPtr_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "credentials");
			HttpWebRequest.NativeFieldInfoPtr_haveResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "haveResponse");
			HttpWebRequest.NativeFieldInfoPtr_requestSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "requestSent");
			HttpWebRequest.NativeFieldInfoPtr_webHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "webHeaders");
			HttpWebRequest.NativeFieldInfoPtr_keepAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "keepAlive");
			HttpWebRequest.NativeFieldInfoPtr_maxAutoRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "maxAutoRedirect");
			HttpWebRequest.NativeFieldInfoPtr_mediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "mediaType");
			HttpWebRequest.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "method");
			HttpWebRequest.NativeFieldInfoPtr_initialMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "initialMethod");
			HttpWebRequest.NativeFieldInfoPtr_pipelined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "pipelined");
			HttpWebRequest.NativeFieldInfoPtr_preAuthenticate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "preAuthenticate");
			HttpWebRequest.NativeFieldInfoPtr_usedPreAuth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "usedPreAuth");
			HttpWebRequest.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "version");
			HttpWebRequest.NativeFieldInfoPtr_force_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "force_version");
			HttpWebRequest.NativeFieldInfoPtr_actualVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "actualVersion");
			HttpWebRequest.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "proxy");
			HttpWebRequest.NativeFieldInfoPtr_sendChunked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "sendChunked");
			HttpWebRequest.NativeFieldInfoPtr_servicePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "servicePoint");
			HttpWebRequest.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "timeout");
			HttpWebRequest.NativeFieldInfoPtr_writeStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "writeStream");
			HttpWebRequest.NativeFieldInfoPtr_webResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "webResponse");
			HttpWebRequest.NativeFieldInfoPtr_responseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "responseTask");
			HttpWebRequest.NativeFieldInfoPtr_currentOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "currentOperation");
			HttpWebRequest.NativeFieldInfoPtr_aborted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "aborted");
			HttpWebRequest.NativeFieldInfoPtr_gotRequestStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "gotRequestStream");
			HttpWebRequest.NativeFieldInfoPtr_redirects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "redirects");
			HttpWebRequest.NativeFieldInfoPtr_expectContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "expectContinue");
			HttpWebRequest.NativeFieldInfoPtr_getResponseCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "getResponseCalled");
			HttpWebRequest.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "locker");
			HttpWebRequest.NativeFieldInfoPtr_finished_reading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "finished_reading");
			HttpWebRequest.NativeFieldInfoPtr_auto_decomp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "auto_decomp");
			HttpWebRequest.NativeFieldInfoPtr_defaultMaxResponseHeadersLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "defaultMaxResponseHeadersLength");
			HttpWebRequest.NativeFieldInfoPtr_readWriteTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "readWriteTimeout");
			HttpWebRequest.NativeFieldInfoPtr_tlsProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "tlsProvider");
			HttpWebRequest.NativeFieldInfoPtr_tlsSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "tlsSettings");
			HttpWebRequest.NativeFieldInfoPtr_certValidationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "certValidationCallback");
			HttpWebRequest.NativeFieldInfoPtr_auth_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "auth_state");
			HttpWebRequest.NativeFieldInfoPtr_proxy_auth_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "proxy_auth_state");
			HttpWebRequest.NativeFieldInfoPtr_host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "host");
			HttpWebRequest.NativeFieldInfoPtr_ResendContentFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "ResendContentFactory");
			HttpWebRequest.NativeFieldInfoPtr__ThrowOnError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<ThrowOnError>k__BackingField");
			HttpWebRequest.NativeFieldInfoPtr_unsafe_auth_blah = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "unsafe_auth_blah");
			HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665792);
			HttpWebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665793);
			HttpWebRequest.NativeMethodInfoPtr_ResetAuthorization_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665794);
			HttpWebRequest.NativeMethodInfoPtr_get_Address_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665795);
			HttpWebRequest.NativeMethodInfoPtr_set_Address_Internal_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665796);
			HttpWebRequest.NativeMethodInfoPtr_get_AllowWriteStreamBuffering_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665797);
			HttpWebRequest.NativeMethodInfoPtr_get_AutomaticDecompression_Public_get_DecompressionMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665798);
			HttpWebRequest.NativeMethodInfoPtr_get_InternalAllowBuffering_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665799);
			HttpWebRequest.NativeMethodInfoPtr_get_MethodWithBuffer_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665800);
			HttpWebRequest.NativeMethodInfoPtr_get_TlsProvider_Internal_get_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665801);
			HttpWebRequest.NativeMethodInfoPtr_get_TlsSettings_Internal_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665802);
			HttpWebRequest.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665803);
			HttpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665804);
			HttpWebRequest.NativeMethodInfoPtr_set_InternalContentLength_Internal_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665805);
			HttpWebRequest.NativeMethodInfoPtr_get_ThrowOnError_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665806);
			HttpWebRequest.NativeMethodInfoPtr_set_ThrowOnError_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665807);
			HttpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665808);
			HttpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665809);
			HttpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665810);
			HttpWebRequest.NativeMethodInfoPtr_get_Host_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665811);
			HttpWebRequest.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665812);
			HttpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665813);
			HttpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665814);
			HttpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665815);
			HttpWebRequest.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665816);
			HttpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665817);
			HttpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665818);
			HttpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665819);
			HttpWebRequest.NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665820);
			HttpWebRequest.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665821);
			HttpWebRequest.NativeMethodInfoPtr_get_ServicePointNoLock_Internal_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665822);
			HttpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665823);
			HttpWebRequest.NativeMethodInfoPtr_get_TransferEncoding_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665824);
			HttpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665825);
			HttpWebRequest.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665826);
			HttpWebRequest.NativeMethodInfoPtr_get_ExpectContinue_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665827);
			HttpWebRequest.NativeMethodInfoPtr_set_ExpectContinue_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665828);
			HttpWebRequest.NativeMethodInfoPtr_get_AuthUri_Internal_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665829);
			HttpWebRequest.NativeMethodInfoPtr_get_ProxyQuery_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665830);
			HttpWebRequest.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_get_ServerCertValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665831);
			HttpWebRequest.NativeMethodInfoPtr_GetServicePoint_Internal_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665832);
			HttpWebRequest.NativeMethodInfoPtr_SendRequest_Private_WebOperation_Boolean_BufferOffsetSize_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665833);
			HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665834);
			HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665835);
			HttpWebRequest.NativeMethodInfoPtr_MyGetResponseAsync_Private_Task_1_HttpWebResponse_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665836);
			HttpWebRequest.NativeMethodInfoPtr_GetResponseFromData_Private_Task_1_ValueTuple_5_HttpWebResponse_Boolean_Boolean_BufferOffsetSize_WebOperation_WebResponseStream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665837);
			HttpWebRequest.NativeMethodInfoPtr_FlattenException_Internal_Static_Exception_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665838);
			HttpWebRequest.NativeMethodInfoPtr_GetWebException_Private_WebException_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665839);
			HttpWebRequest.NativeMethodInfoPtr_CreateRequestAbortedException_Internal_Static_WebException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665840);
			HttpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665841);
			HttpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665842);
			HttpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665843);
			HttpWebRequest.NativeMethodInfoPtr_set_FinishedReading_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665844);
			HttpWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665845);
			HttpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665846);
			HttpWebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665847);
			HttpWebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665848);
			HttpWebRequest.NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665849);
			HttpWebRequest.NativeMethodInfoPtr_DoContinueDelegate_Internal_Void_Int32_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665850);
			HttpWebRequest.NativeMethodInfoPtr_RewriteRedirectToGet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665851);
			HttpWebRequest.NativeMethodInfoPtr_Redirect_Private_Boolean_HttpStatusCode_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665852);
			HttpWebRequest.NativeMethodInfoPtr_GetHeaders_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665853);
			HttpWebRequest.NativeMethodInfoPtr_DoPreAuthenticate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665854);
			HttpWebRequest.NativeMethodInfoPtr_GetRequestHeaders_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665855);
			HttpWebRequest.NativeMethodInfoPtr_HandleNtlmAuth_Private_ValueTuple_2_WebOperation_Boolean_WebResponseStream_HttpWebResponse_BufferOffsetSize_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665856);
			HttpWebRequest.NativeMethodInfoPtr_CheckAuthorization_Private_Boolean_WebResponse_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665857);
			HttpWebRequest.NativeMethodInfoPtr_GetRewriteHandler_Private_ValueTuple_2_Task_1_BufferOffsetSize_WebException_HttpWebResponse_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665858);
			HttpWebRequest.NativeMethodInfoPtr_CheckFinalStatus_Private_ValueTuple_4_Boolean_Boolean_Task_1_BufferOffsetSize_WebException_HttpWebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665859);
			HttpWebRequest.NativeMethodInfoPtr__GetRewriteHandler_b__263_0_Private_Task_1_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665860);
			HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665861);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x000532C8 File Offset: 0x000514C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 382422, RefRangeEnd = 382423, XrefRangeStart = 382394, XrefRangeEnd = 382422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequest(Uri uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00053314 File Offset: 0x00051514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382423, XrefRangeEnd = 382542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00053378 File Offset: 0x00051578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 382542, RefRangeEnd = 382544, XrefRangeStart = 382542, XrefRangeEnd = 382542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAuthorization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_ResetAuthorization_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x000533AC File Offset: 0x000515AC
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x000533EC File Offset: 0x000515EC
		public unsafe Uri Address
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_Address_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_Address_Internal_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00053430 File Offset: 0x00051630
		public unsafe virtual bool AllowWriteStreamBuffering
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_AllowWriteStreamBuffering_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00053478 File Offset: 0x00051678
		public unsafe DecompressionMethods AutomaticDecompression
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_AutomaticDecompression_Public_get_DecompressionMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x000534B4 File Offset: 0x000516B4
		public unsafe bool InternalAllowBuffering
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_InternalAllowBuffering_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x000534F0 File Offset: 0x000516F0
		public unsafe bool MethodWithBuffer
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 382554, RefRangeEnd = 382557, XrefRangeStart = 382544, XrefRangeEnd = 382554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_MethodWithBuffer_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x0005352C File Offset: 0x0005172C
		public unsafe MonoTlsProvider TlsProvider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_TlsProvider_Internal_get_MonoTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x0005356C File Offset: 0x0005176C
		public unsafe MonoTlsSettings TlsSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_TlsSettings_Internal_get_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x000535AC File Offset: 0x000517AC
		public unsafe X509CertificateCollection ClientCertificates
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382557, XrefRangeEnd = 382561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x000535EC File Offset: 0x000517EC
		public unsafe override long ContentLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x00053634 File Offset: 0x00051834
		public unsafe long InternalContentLength
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_InternalContentLength_Internal_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x00053674 File Offset: 0x00051874
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x000536B0 File Offset: 0x000518B0
		public unsafe bool ThrowOnError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ThrowOnError_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_ThrowOnError_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x000536F0 File Offset: 0x000518F0
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x0005373C File Offset: 0x0005193C
		public unsafe override ICredentials Credentials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 382561, RefRangeEnd = 382571, XrefRangeStart = 382561, XrefRangeEnd = 382561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0005378C File Offset: 0x0005198C
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x000537D8 File Offset: 0x000519D8
		public unsafe string Host
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382571, XrefRangeEnd = 382572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_Host_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x00053810 File Offset: 0x00051A10
		public unsafe bool KeepAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0005384C File Offset: 0x00051A4C
		public unsafe int ReadWriteTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00053888 File Offset: 0x00051A88
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x000538CC File Offset: 0x00051ACC
		public unsafe override string Method
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382572, XrefRangeEnd = 382596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0005391C File Offset: 0x00051B1C
		public unsafe Version ProtocolVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x0005395C File Offset: 0x00051B5C
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x000539A8 File Offset: 0x00051BA8
		public unsafe override IWebProxy Proxy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382596, XrefRangeEnd = 382603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000539F8 File Offset: 0x00051BF8
		public unsafe override Uri RequestUri
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00053A44 File Offset: 0x00051C44
		public unsafe bool SendChunked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00053A80 File Offset: 0x00051C80
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382603, XrefRangeEnd = 382604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00053AC0 File Offset: 0x00051CC0
		public unsafe ServicePoint ServicePointNoLock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ServicePointNoLock_Internal_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x00053B00 File Offset: 0x00051D00
		public unsafe override int Timeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x00053B48 File Offset: 0x00051D48
		public unsafe string TransferEncoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382604, XrefRangeEnd = 382607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_TransferEncoding_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x00053B80 File Offset: 0x00051D80
		public unsafe override bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382607, XrefRangeEnd = 382608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x00053BC8 File Offset: 0x00051DC8
		public unsafe bool UnsafeAuthenticatedConnectionSharing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x00053C04 File Offset: 0x00051E04
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x00053C40 File Offset: 0x00051E40
		public unsafe bool ExpectContinue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ExpectContinue_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_ExpectContinue_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00053C80 File Offset: 0x00051E80
		public unsafe Uri AuthUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_AuthUri_Internal_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00053CC0 File Offset: 0x00051EC0
		public unsafe bool ProxyQuery
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ProxyQuery_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00053CFC File Offset: 0x00051EFC
		public unsafe ServerCertValidationCallback ServerCertValidationCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_get_ServerCertValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00053D3C File Offset: 0x00051F3C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 382615, RefRangeEnd = 382623, XrefRangeStart = 382608, XrefRangeEnd = 382615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePoint GetServicePoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetServicePoint_Internal_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00053D7C File Offset: 0x00051F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 382634, RefRangeEnd = 382635, XrefRangeStart = 382623, XrefRangeEnd = 382634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref redirecting;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_SendRequest_Private_WebOperation_Boolean_BufferOffsetSize_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr3) : null;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00053DF4 File Offset: 0x00051FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 382641, RefRangeEnd = 382642, XrefRangeStart = 382635, XrefRangeEnd = 382641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abort);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.MethodInfoStoreGeneric_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00053E58 File Offset: 0x00052058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382642, XrefRangeEnd = 382648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.MethodInfoStoreGeneric_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00053EA8 File Offset: 0x000520A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382648, XrefRangeEnd = 382659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_MyGetResponseAsync_Private_Task_1_HttpWebResponse_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpWebResponse>>(intPtr3) : null;
			}
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00053F00 File Offset: 0x00052100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 382669, RefRangeEnd = 382670, XrefRangeStart = 382659, XrefRangeEnd = 382669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetResponseFromData_Private_Task_1_ValueTuple_5_HttpWebResponse_Boolean_Boolean_BufferOffsetSize_WebOperation_WebResponseStream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>>(intPtr3) : null;
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00053F68 File Offset: 0x00052168
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 382675, RefRangeEnd = 382678, XrefRangeStart = 382670, XrefRangeEnd = 382675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception FlattenException(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_FlattenException_Internal_Static_Exception_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00053FAC File Offset: 0x000521AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 382696, RefRangeEnd = 382697, XrefRangeStart = 382678, XrefRangeEnd = 382696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException GetWebException(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetWebException_Private_WebException_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00053FFC File Offset: 0x000521FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 382715, RefRangeEnd = 382718, XrefRangeStart = 382697, XrefRangeEnd = 382715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebException CreateRequestAbortedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CreateRequestAbortedException_Internal_Static_WebException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00054030 File Offset: 0x00052230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382718, XrefRangeEnd = 382742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000540A0 File Offset: 0x000522A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382742, XrefRangeEnd = 382753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000540FC File Offset: 0x000522FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382753, XrefRangeEnd = 382756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
		}

		// Token: 0x170005B4 RID: 1460
		// (set) Token: 0x060011C2 RID: 4546 RVA: 0x00054148 File Offset: 0x00052348
		public unsafe bool FinishedReading
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_FinishedReading_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x00054188 File Offset: 0x00052388
		public unsafe bool Aborted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000541C4 File Offset: 0x000523C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382756, XrefRangeEnd = 382775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00054200 File Offset: 0x00052400
		[CallerCount(0)]
		public new unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0005425C File Offset: 0x0005245C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382775, XrefRangeEnd = 382890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x000542C0 File Offset: 0x000524C0
		[CallerCount(0)]
		public unsafe void CheckRequestStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x000542F4 File Offset: 0x000524F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382890, XrefRangeEnd = 382891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoContinueDelegate(int statusCode, WebHeaderCollection headers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref statusCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_DoContinueDelegate_Internal_Void_Int32_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00054344 File Offset: 0x00052544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 382897, RefRangeEnd = 382898, XrefRangeStart = 382891, XrefRangeEnd = 382897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RewriteRedirectToGet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_RewriteRedirectToGet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00054378 File Offset: 0x00052578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382898, XrefRangeEnd = 382918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Redirect(HttpStatusCode code, WebResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_Redirect_Private_Boolean_HttpStatusCode_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x000543D4 File Offset: 0x000525D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383094, RefRangeEnd = 383095, XrefRangeStart = 382918, XrefRangeEnd = 383094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetHeaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetHeaders_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0005440C File Offset: 0x0005260C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383115, RefRangeEnd = 383116, XrefRangeStart = 383095, XrefRangeEnd = 383115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoPreAuthenticate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_DoPreAuthenticate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00054440 File Offset: 0x00052640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383181, RefRangeEnd = 383182, XrefRangeStart = 383116, XrefRangeEnd = 383181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetRequestHeaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetRequestHeaders_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00054480 File Offset: 0x00052680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383199, RefRangeEnd = 383200, XrefRangeStart = 383182, XrefRangeEnd = 383199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_HandleNtlmAuth_Private_ValueTuple_2_WebOperation_Boolean_WebResponseStream_HttpWebResponse_BufferOffsetSize_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<WebOperation, bool>(intPtr);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00054504 File Offset: 0x00052704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383200, XrefRangeEnd = 383202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckAuthorization(WebResponse response, HttpStatusCode code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CheckAuthorization_Private_Boolean_WebResponse_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00054560 File Offset: 0x00052760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383215, RefRangeEnd = 383216, XrefRangeStart = 383202, XrefRangeEnd = 383215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref redirect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetRewriteHandler_Private_ValueTuple_2_Task_1_BufferOffsetSize_WebException_HttpWebResponse_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<Task<BufferOffsetSize>, WebException>(intPtr);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x000545B8 File Offset: 0x000527B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383233, RefRangeEnd = 383234, XrefRangeStart = 383216, XrefRangeEnd = 383233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CheckFinalStatus_Private_ValueTuple_4_Boolean_Boolean_Task_1_BufferOffsetSize_WebException_HttpWebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(intPtr);
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00054600 File Offset: 0x00052800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383234, XrefRangeEnd = 383244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<BufferOffsetSize> _GetRewriteHandler_b__263_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__GetRewriteHandler_b__263_0_Private_Task_1_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<BufferOffsetSize>>(intPtr3) : null;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00054640 File Offset: 0x00052840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383244, XrefRangeEnd = 383247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00008F67 File Offset: 0x00007167
		public HttpWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0005467C File Offset: 0x0005287C
		// (set) Token: 0x060011D6 RID: 4566 RVA: 0x00008F70 File Offset: 0x00007170
		public unsafe Uri requestUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x000546AC File Offset: 0x000528AC
		// (set) Token: 0x060011D8 RID: 4568 RVA: 0x00008F8F File Offset: 0x0000718F
		public unsafe Uri actualUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x000546DC File Offset: 0x000528DC
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x00008FAE File Offset: 0x000071AE
		public unsafe bool hostChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_hostChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_hostChanged)) = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x00054704 File Offset: 0x00052904
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x00008FC9 File Offset: 0x000071C9
		public unsafe bool allowAutoRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowAutoRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowAutoRedirect)) = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x0005472C File Offset: 0x0005292C
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x00008FE4 File Offset: 0x000071E4
		public unsafe bool allowBuffering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowBuffering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowBuffering)) = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x00054754 File Offset: 0x00052954
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x00008FFF File Offset: 0x000071FF
		public unsafe X509CertificateCollection certificates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certificates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certificates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x00054784 File Offset: 0x00052984
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x0000901E File Offset: 0x0000721E
		public unsafe string connectionGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_connectionGroup);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_connectionGroup), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x000547AC File Offset: 0x000529AC
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x0000903D File Offset: 0x0000723D
		public unsafe bool haveContentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveContentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveContentLength)) = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000547D4 File Offset: 0x000529D4
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x00009058 File Offset: 0x00007258
		public unsafe long contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_contentLength)) = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x000547FC File Offset: 0x000529FC
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x00009073 File Offset: 0x00007273
		public unsafe HttpContinueDelegate continueDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_continueDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContinueDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_continueDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0005482C File Offset: 0x00052A2C
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x00009092 File Offset: 0x00007292
		public unsafe CookieContainer cookieContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_cookieContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_cookieContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x0005485C File Offset: 0x00052A5C
		// (set) Token: 0x060011EC RID: 4588 RVA: 0x000090B1 File Offset: 0x000072B1
		public unsafe ICredentials credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x0005488C File Offset: 0x00052A8C
		// (set) Token: 0x060011EE RID: 4590 RVA: 0x000090D0 File Offset: 0x000072D0
		public unsafe bool haveResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveResponse)) = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x000548B4 File Offset: 0x00052AB4
		// (set) Token: 0x060011F0 RID: 4592 RVA: 0x000090EB File Offset: 0x000072EB
		public unsafe bool requestSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestSent)) = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x000548DC File Offset: 0x00052ADC
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x00009106 File Offset: 0x00007306
		public unsafe WebHeaderCollection webHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0005490C File Offset: 0x00052B0C
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x00009125 File Offset: 0x00007325
		public unsafe bool keepAlive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_keepAlive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_keepAlive)) = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00054934 File Offset: 0x00052B34
		// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00009140 File Offset: 0x00007340
		public unsafe int maxAutoRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_maxAutoRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_maxAutoRedirect)) = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x0005495C File Offset: 0x00052B5C
		// (set) Token: 0x060011F8 RID: 4600 RVA: 0x0000915B File Offset: 0x0000735B
		public unsafe string mediaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_mediaType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_mediaType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00054984 File Offset: 0x00052B84
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x0000917A File Offset: 0x0000737A
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x000549AC File Offset: 0x00052BAC
		// (set) Token: 0x060011FC RID: 4604 RVA: 0x00009199 File Offset: 0x00007399
		public unsafe string initialMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_initialMethod);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_initialMethod), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x000549D4 File Offset: 0x00052BD4
		// (set) Token: 0x060011FE RID: 4606 RVA: 0x000091B8 File Offset: 0x000073B8
		public unsafe bool pipelined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_pipelined);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_pipelined)) = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x000549FC File Offset: 0x00052BFC
		// (set) Token: 0x06001200 RID: 4608 RVA: 0x000091D3 File Offset: 0x000073D3
		public unsafe bool preAuthenticate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_preAuthenticate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_preAuthenticate)) = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x00054A24 File Offset: 0x00052C24
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x000091EE File Offset: 0x000073EE
		public unsafe bool usedPreAuth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_usedPreAuth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_usedPreAuth)) = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x00054A4C File Offset: 0x00052C4C
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x00009209 File Offset: 0x00007409
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x00054A7C File Offset: 0x00052C7C
		// (set) Token: 0x06001206 RID: 4614 RVA: 0x00009228 File Offset: 0x00007428
		public unsafe bool force_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_force_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_force_version)) = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x00054AA4 File Offset: 0x00052CA4
		// (set) Token: 0x06001208 RID: 4616 RVA: 0x00009243 File Offset: 0x00007443
		public unsafe Version actualVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00054AD4 File Offset: 0x00052CD4
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x00009262 File Offset: 0x00007462
		public unsafe IWebProxy proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x00054B04 File Offset: 0x00052D04
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x00009281 File Offset: 0x00007481
		public unsafe bool sendChunked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_sendChunked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_sendChunked)) = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x00054B2C File Offset: 0x00052D2C
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x0000929C File Offset: 0x0000749C
		public unsafe ServicePoint servicePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_servicePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_servicePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x00054B5C File Offset: 0x00052D5C
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x000092BB File Offset: 0x000074BB
		public unsafe int timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x00054B84 File Offset: 0x00052D84
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x000092D6 File Offset: 0x000074D6
		public unsafe WebRequestStream writeStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_writeStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_writeStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x00054BB4 File Offset: 0x00052DB4
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x000092F5 File Offset: 0x000074F5
		public unsafe HttpWebResponse webResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00054BE4 File Offset: 0x00052DE4
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x00009314 File Offset: 0x00007514
		public unsafe WebCompletionSource responseTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_responseTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_responseTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x00054C14 File Offset: 0x00052E14
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x00009333 File Offset: 0x00007533
		public unsafe WebOperation currentOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_currentOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_currentOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x00054C44 File Offset: 0x00052E44
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x00009352 File Offset: 0x00007552
		public unsafe int aborted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_aborted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_aborted)) = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x00054C6C File Offset: 0x00052E6C
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x0000936D File Offset: 0x0000756D
		public unsafe bool gotRequestStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_gotRequestStream);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_gotRequestStream)) = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x00054C94 File Offset: 0x00052E94
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x00009388 File Offset: 0x00007588
		public unsafe int redirects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_redirects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_redirects)) = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x00054CBC File Offset: 0x00052EBC
		// (set) Token: 0x06001220 RID: 4640 RVA: 0x000093A3 File Offset: 0x000075A3
		public unsafe bool expectContinue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_expectContinue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_expectContinue)) = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x00054CE4 File Offset: 0x00052EE4
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x000093BE File Offset: 0x000075BE
		public unsafe bool getResponseCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_getResponseCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_getResponseCalled)) = value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00054D0C File Offset: 0x00052F0C
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x000093D9 File Offset: 0x000075D9
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x00054D3C File Offset: 0x00052F3C
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x000093F8 File Offset: 0x000075F8
		public unsafe bool finished_reading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_finished_reading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_finished_reading)) = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x00054D64 File Offset: 0x00052F64
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x00009413 File Offset: 0x00007613
		public unsafe DecompressionMethods auto_decomp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auto_decomp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auto_decomp)) = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x00054D8C File Offset: 0x00052F8C
		// (set) Token: 0x0600122A RID: 4650 RVA: 0x0000942E File Offset: 0x0000762E
		public unsafe static int defaultMaxResponseHeadersLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HttpWebRequest.NativeFieldInfoPtr_defaultMaxResponseHeadersLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpWebRequest.NativeFieldInfoPtr_defaultMaxResponseHeadersLength, (void*)(&value));
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x00054DA8 File Offset: 0x00052FA8
		// (set) Token: 0x0600122C RID: 4652 RVA: 0x0000943C File Offset: 0x0000763C
		public unsafe int readWriteTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_readWriteTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_readWriteTimeout)) = value;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x00054DD0 File Offset: 0x00052FD0
		// (set) Token: 0x0600122E RID: 4654 RVA: 0x00009457 File Offset: 0x00007657
		public unsafe MonoTlsProvider tlsProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00054E00 File Offset: 0x00053000
		// (set) Token: 0x06001230 RID: 4656 RVA: 0x00009476 File Offset: 0x00007676
		public unsafe MonoTlsSettings tlsSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x00054E30 File Offset: 0x00053030
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x00009495 File Offset: 0x00007695
		public unsafe ServerCertValidationCallback certValidationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certValidationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certValidationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00054E60 File Offset: 0x00053060
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x000094B4 File Offset: 0x000076B4
		public HttpWebRequest.AuthorizationState auth_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auth_state);
				return new HttpWebRequest.AuthorizationState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auth_state), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00054E90 File Offset: 0x00053090
		// (set) Token: 0x06001236 RID: 4662 RVA: 0x000094E2 File Offset: 0x000076E2
		public HttpWebRequest.AuthorizationState proxy_auth_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy_auth_state);
				return new HttpWebRequest.AuthorizationState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy_auth_state), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x00054EC0 File Offset: 0x000530C0
		// (set) Token: 0x06001238 RID: 4664 RVA: 0x00009510 File Offset: 0x00007710
		public unsafe string host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00054EE8 File Offset: 0x000530E8
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x0000952F File Offset: 0x0000772F
		public unsafe Func<Stream, Task> ResendContentFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_ResendContentFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_ResendContentFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00054F18 File Offset: 0x00053118
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x0000954E File Offset: 0x0000774E
		public unsafe bool _ThrowOnError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr__ThrowOnError_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr__ThrowOnError_k__BackingField)) = value;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x00054F40 File Offset: 0x00053140
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x00009569 File Offset: 0x00007769
		public unsafe bool unsafe_auth_blah
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_unsafe_auth_blah);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_unsafe_auth_blah)) = value;
			}
		}

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeFieldInfoPtr_requestUri;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeFieldInfoPtr_actualUri;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeFieldInfoPtr_hostChanged;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeFieldInfoPtr_allowAutoRedirect;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeFieldInfoPtr_allowBuffering;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeFieldInfoPtr_certificates;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeFieldInfoPtr_connectionGroup;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeFieldInfoPtr_haveContentLength;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeFieldInfoPtr_contentLength;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeFieldInfoPtr_continueDelegate;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeFieldInfoPtr_cookieContainer;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeFieldInfoPtr_credentials;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeFieldInfoPtr_haveResponse;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeFieldInfoPtr_requestSent;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeFieldInfoPtr_webHeaders;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeFieldInfoPtr_keepAlive;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr_maxAutoRedirect;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeFieldInfoPtr_mediaType;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeFieldInfoPtr_initialMethod;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeFieldInfoPtr_pipelined;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeFieldInfoPtr_preAuthenticate;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeFieldInfoPtr_usedPreAuth;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeFieldInfoPtr_force_version;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeFieldInfoPtr_actualVersion;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeFieldInfoPtr_proxy;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeFieldInfoPtr_sendChunked;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeFieldInfoPtr_servicePoint;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeFieldInfoPtr_writeStream;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeFieldInfoPtr_webResponse;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeFieldInfoPtr_responseTask;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeFieldInfoPtr_currentOperation;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeFieldInfoPtr_aborted;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeFieldInfoPtr_gotRequestStream;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeFieldInfoPtr_redirects;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeFieldInfoPtr_expectContinue;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeFieldInfoPtr_getResponseCalled;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeFieldInfoPtr_finished_reading;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeFieldInfoPtr_auto_decomp;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeFieldInfoPtr_defaultMaxResponseHeadersLength;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeFieldInfoPtr_readWriteTimeout;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeFieldInfoPtr_tlsProvider;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeFieldInfoPtr_tlsSettings;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeFieldInfoPtr_certValidationCallback;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeFieldInfoPtr_auth_state;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeFieldInfoPtr_proxy_auth_state;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeFieldInfoPtr_host;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeFieldInfoPtr_ResendContentFactory;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeFieldInfoPtr__ThrowOnError_k__BackingField;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeFieldInfoPtr_unsafe_auth_blah;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_ResetAuthorization_Private_Void_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_Uri_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_set_Address_Internal_set_Void_Uri_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowWriteStreamBuffering_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_get_AutomaticDecompression_Public_get_DecompressionMethods_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalAllowBuffering_Internal_get_Boolean_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodWithBuffer_Private_get_Boolean_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_get_TlsProvider_Internal_get_MonoTlsProvider_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_get_TlsSettings_Internal_get_MonoTlsSettings_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalContentLength_Internal_set_Void_Int64_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_get_ThrowOnError_Internal_get_Boolean_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr_set_ThrowOnError_Internal_set_Void_Boolean_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_get_Host_Public_get_String_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePointNoLock_Internal_get_ServicePoint_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_get_TransferEncoding_Public_get_String_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Public_get_Boolean_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpectContinue_Internal_get_Boolean_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_set_ExpectContinue_Internal_set_Void_Boolean_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthUri_Internal_get_Uri_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyQuery_Internal_get_Boolean_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_get_ServerCertValidationCallback_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_GetServicePoint_Internal_ServicePoint_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_SendRequest_Private_WebOperation_Boolean_BufferOffsetSize_CancellationToken_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_MyGetResponseAsync_Private_Task_1_HttpWebResponse_CancellationToken_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseFromData_Private_Task_1_ValueTuple_5_HttpWebResponse_Boolean_Boolean_BufferOffsetSize_WebOperation_WebResponseStream_CancellationToken_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_FlattenException_Internal_Static_Exception_Exception_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_GetWebException_Private_WebException_Exception_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_CreateRequestAbortedException_Internal_Static_WebException_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_set_FinishedReading_Internal_set_Void_Boolean_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Void_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_DoContinueDelegate_Internal_Void_Int32_WebHeaderCollection_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_RewriteRedirectToGet_Private_Void_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_Redirect_Private_Boolean_HttpStatusCode_WebResponse_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_GetHeaders_Private_String_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_DoPreAuthenticate_Private_Void_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestHeaders_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_HandleNtlmAuth_Private_ValueTuple_2_WebOperation_Boolean_WebResponseStream_HttpWebResponse_BufferOffsetSize_CancellationToken_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorization_Private_Boolean_WebResponse_HttpStatusCode_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_GetRewriteHandler_Private_ValueTuple_2_Task_1_BufferOffsetSize_WebException_HttpWebResponse_Boolean_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr_CheckFinalStatus_Private_ValueTuple_4_Boolean_Boolean_Task_1_BufferOffsetSize_WebException_HttpWebResponse_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr__GetRewriteHandler_b__263_0_Private_Task_1_BufferOffsetSize_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001E4 RID: 484
		[OriginalName("System.dll", "", "NtlmAuthState")]
		public enum NtlmAuthState
		{
			// Token: 0x040014BC RID: 5308
			None,
			// Token: 0x040014BD RID: 5309
			Challenge,
			// Token: 0x040014BE RID: 5310
			Response
		}

		// Token: 0x020001E5 RID: 485
		public sealed class AuthorizationState : ValueType
		{
			// Token: 0x06001A6A RID: 6762 RVA: 0x00070728 File Offset: 0x0006E928
			// Note: this type is marked as 'beforefieldinit'.
			static AuthorizationState()
			{
				Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "AuthorizationState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr);
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "request");
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "isProxy");
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "isCompleted");
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_ntlm_auth_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "ntlm_auth_state");
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665862);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_NtlmAuthState_Public_get_NtlmAuthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665863);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsNtlmAuthenticated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665864);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665865);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_CheckAuthorization_Public_Boolean_WebResponse_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665866);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665867);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665868);
			}

			// Token: 0x17000865 RID: 2149
			// (get) Token: 0x06001A6B RID: 6763 RVA: 0x00070830 File Offset: 0x0006EA30
			public unsafe bool IsCompleted
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000866 RID: 2150
			// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00070874 File Offset: 0x0006EA74
			public unsafe HttpWebRequest.NtlmAuthState NtlmAuthState
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_NtlmAuthState_Public_get_NtlmAuthState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000867 RID: 2151
			// (get) Token: 0x06001A6D RID: 6765 RVA: 0x000708B8 File Offset: 0x0006EAB8
			public unsafe bool IsNtlmAuthenticated
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsNtlmAuthenticated_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A6E RID: 6766 RVA: 0x000708FC File Offset: 0x0006EAFC
			[CallerCount(0)]
			public unsafe AuthorizationState(HttpWebRequest request, bool isProxy)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isProxy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A6F RID: 6767 RVA: 0x0007095C File Offset: 0x0006EB5C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 382014, RefRangeEnd = 382017, XrefRangeStart = 381988, XrefRangeEnd = 382014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool CheckAuthorization(WebResponse response, HttpStatusCode code)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_CheckAuthorization_Public_Boolean_WebResponse_HttpStatusCode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001A70 RID: 6768 RVA: 0x000709BC File Offset: 0x0006EBBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382017, XrefRangeEnd = 382023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A71 RID: 6769 RVA: 0x000709F4 File Offset: 0x0006EBF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382023, XrefRangeEnd = 382036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06001A72 RID: 6770 RVA: 0x0000D8FD File Offset: 0x0000BAFD
			public AuthorizationState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A73 RID: 6771 RVA: 0x0000D906 File Offset: 0x0000BB06
			public AuthorizationState()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr))
			{
			}

			// Token: 0x17000861 RID: 2145
			// (get) Token: 0x06001A74 RID: 6772 RVA: 0x00070A30 File Offset: 0x0006EC30
			// (set) Token: 0x06001A75 RID: 6773 RVA: 0x0000D918 File Offset: 0x0000BB18
			public unsafe HttpWebRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000862 RID: 2146
			// (get) Token: 0x06001A76 RID: 6774 RVA: 0x00070A60 File Offset: 0x0006EC60
			// (set) Token: 0x06001A77 RID: 6775 RVA: 0x0000D937 File Offset: 0x0000BB37
			public unsafe bool isProxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isProxy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isProxy)) = value;
				}
			}

			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x06001A78 RID: 6776 RVA: 0x00070A88 File Offset: 0x0006EC88
			// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0000D952 File Offset: 0x0000BB52
			public unsafe bool isCompleted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isCompleted);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isCompleted)) = value;
				}
			}

			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x06001A7A RID: 6778 RVA: 0x00070AB0 File Offset: 0x0006ECB0
			// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0000D96D File Offset: 0x0000BB6D
			public unsafe HttpWebRequest.NtlmAuthState ntlm_auth_state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_ntlm_auth_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_ntlm_auth_state)) = value;
				}
			}

			// Token: 0x040014BF RID: 5311
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040014C0 RID: 5312
			private static readonly IntPtr NativeFieldInfoPtr_isProxy;

			// Token: 0x040014C1 RID: 5313
			private static readonly IntPtr NativeFieldInfoPtr_isCompleted;

			// Token: 0x040014C2 RID: 5314
			private static readonly IntPtr NativeFieldInfoPtr_ntlm_auth_state;

			// Token: 0x040014C3 RID: 5315
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x040014C4 RID: 5316
			private static readonly IntPtr NativeMethodInfoPtr_get_NtlmAuthState_Public_get_NtlmAuthState_0;

			// Token: 0x040014C5 RID: 5317
			private static readonly IntPtr NativeMethodInfoPtr_get_IsNtlmAuthenticated_Public_get_Boolean_0;

			// Token: 0x040014C6 RID: 5318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Boolean_0;

			// Token: 0x040014C7 RID: 5319
			private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorization_Public_Boolean_WebResponse_HttpStatusCode_0;

			// Token: 0x040014C8 RID: 5320
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

			// Token: 0x040014C9 RID: 5321
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x020001E6 RID: 486
		[ObfuscatedName("System.Net.HttpWebRequest+<>c__234`1")]
		[Serializable]
		public sealed class __c__234<T> : Object
		{
			// Token: 0x06001A7C RID: 6780 RVA: 0x00070AD8 File Offset: 0x0006ECD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__234()
			{
				Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<>c__234`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr);
				HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr, "<>9");
				HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9__234_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr, "<>9__234_0");
				HttpWebRequest.__c__234<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr, 100665870);
				HttpWebRequest.__c__234<T>.NativeMethodInfoPtr__RunWithTimeout_b__234_0_Internal_Nullable_1_Int32_Task_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr, 100665871);
			}

			// Token: 0x06001A7D RID: 6781 RVA: 0x00070B90 File Offset: 0x0006ED90
			[CallerCount(0)]
			public unsafe __c__234()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__c__234<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A7E RID: 6782 RVA: 0x00070BCC File Offset: 0x0006EDCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382036, XrefRangeEnd = 382038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> _RunWithTimeout_b__234_0(Task<T> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__c__234<T>.NativeMethodInfoPtr__RunWithTimeout_b__234_0_Internal_Nullable_1_Int32_Task_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<int>(intPtr);
				}
			}

			// Token: 0x06001A7F RID: 6783 RVA: 0x0000D988 File Offset: 0x0000BB88
			public __c__234(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000868 RID: 2152
			// (get) Token: 0x06001A80 RID: 6784 RVA: 0x00070C14 File Offset: 0x0006EE14
			// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0000D991 File Offset: 0x0000BB91
			public unsafe static HttpWebRequest.__c__234<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest.__c__234<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000869 RID: 2153
			// (get) Token: 0x06001A82 RID: 6786 RVA: 0x00070C3C File Offset: 0x0006EE3C
			// (set) Token: 0x06001A83 RID: 6787 RVA: 0x0000D9A3 File Offset: 0x0000BBA3
			public unsafe static Func<Task<T>, Nullable<int>> __9__234_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9__234_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task<T>, Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9__234_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014CA RID: 5322
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040014CB RID: 5323
			private static readonly IntPtr NativeFieldInfoPtr___9__234_0;

			// Token: 0x040014CC RID: 5324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014CD RID: 5325
			private static readonly IntPtr NativeMethodInfoPtr__RunWithTimeout_b__234_0_Internal_Nullable_1_Int32_Task_1_T_0;
		}

		// Token: 0x020001E7 RID: 487
		[ObfuscatedName("System.Net.HttpWebRequest+<RunWithTimeout>d__234`1")]
		public sealed class _RunWithTimeout_d__234<T> : ValueType
		{
			// Token: 0x06001A84 RID: 6788 RVA: 0x00070C64 File Offset: 0x0006EE64
			// Note: this type is marked as 'beforefieldinit'.
			static _RunWithTimeout_d__234()
			{
				Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<RunWithTimeout>d__234`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr);
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<>1__state");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<>t__builder");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "timeout");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_func = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "func");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__timeoutTask_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<timeoutTask>5__1");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__cts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<cts>5__2");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_abort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "abort");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__workerTask_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<workerTask>5__3");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<>u__1");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, 100665872);
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, 100665873);
			}

			// Token: 0x06001A85 RID: 6789 RVA: 0x00070DA8 File Offset: 0x0006EFA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382038, XrefRangeEnd = 382085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._RunWithTimeout_d__234<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A86 RID: 6790 RVA: 0x00070DE0 File Offset: 0x0006EFE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382085, XrefRangeEnd = 382147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._RunWithTimeout_d__234<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A87 RID: 6791 RVA: 0x0000D9B5 File Offset: 0x0000BBB5
			public _RunWithTimeout_d__234(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A88 RID: 6792 RVA: 0x0000D9BE File Offset: 0x0000BBBE
			public _RunWithTimeout_d__234()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x06001A89 RID: 6793 RVA: 0x00070E28 File Offset: 0x0006F028
			// (set) Token: 0x06001A8A RID: 6794 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x06001A8B RID: 6795 RVA: 0x00070E50 File Offset: 0x0006F050
			// (set) Token: 0x06001A8C RID: 6796 RVA: 0x0000D9EB File Offset: 0x0000BBEB
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x06001A8D RID: 6797 RVA: 0x00070E80 File Offset: 0x0006F080
			// (set) Token: 0x06001A8E RID: 6798 RVA: 0x0000DA19 File Offset: 0x0000BC19
			public unsafe int timeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_timeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_timeout)) = value;
				}
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x06001A8F RID: 6799 RVA: 0x00070EA8 File Offset: 0x0006F0A8
			// (set) Token: 0x06001A90 RID: 6800 RVA: 0x0000DA34 File Offset: 0x0000BC34
			public unsafe Func<CancellationToken, Task<T>> func
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_func);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CancellationToken, Task<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_func), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086E RID: 2158
			// (get) Token: 0x06001A91 RID: 6801 RVA: 0x00070ED8 File Offset: 0x0006F0D8
			// (set) Token: 0x06001A92 RID: 6802 RVA: 0x0000DA53 File Offset: 0x0000BC53
			public unsafe Task _timeoutTask_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__timeoutTask_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__timeoutTask_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086F RID: 2159
			// (get) Token: 0x06001A93 RID: 6803 RVA: 0x00070F08 File Offset: 0x0006F108
			// (set) Token: 0x06001A94 RID: 6804 RVA: 0x0000DA72 File Offset: 0x0000BC72
			public unsafe CancellationTokenSource _cts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__cts_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__cts_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000870 RID: 2160
			// (get) Token: 0x06001A95 RID: 6805 RVA: 0x00070F38 File Offset: 0x0006F138
			// (set) Token: 0x06001A96 RID: 6806 RVA: 0x0000DA91 File Offset: 0x0000BC91
			public unsafe Action abort
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_abort);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_abort), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000871 RID: 2161
			// (get) Token: 0x06001A97 RID: 6807 RVA: 0x00070F68 File Offset: 0x0006F168
			// (set) Token: 0x06001A98 RID: 6808 RVA: 0x0000DAB0 File Offset: 0x0000BCB0
			public unsafe Task<T> _workerTask_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__workerTask_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__workerTask_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x06001A99 RID: 6809 RVA: 0x00070F98 File Offset: 0x0006F198
			// (set) Token: 0x06001A9A RID: 6810 RVA: 0x0000DACF File Offset: 0x0000BCCF
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014CE RID: 5326
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014CF RID: 5327
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014D0 RID: 5328
			private static readonly IntPtr NativeFieldInfoPtr_timeout;

			// Token: 0x040014D1 RID: 5329
			private static readonly IntPtr NativeFieldInfoPtr_func;

			// Token: 0x040014D2 RID: 5330
			private static readonly IntPtr NativeFieldInfoPtr__timeoutTask_5__1;

			// Token: 0x040014D3 RID: 5331
			private static readonly IntPtr NativeFieldInfoPtr__cts_5__2;

			// Token: 0x040014D4 RID: 5332
			private static readonly IntPtr NativeFieldInfoPtr_abort;

			// Token: 0x040014D5 RID: 5333
			private static readonly IntPtr NativeFieldInfoPtr__workerTask_5__3;

			// Token: 0x040014D6 RID: 5334
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014D7 RID: 5335
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014D8 RID: 5336
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001E8 RID: 488
		[ObfuscatedName("System.Net.HttpWebRequest+<MyGetResponseAsync>d__236")]
		public sealed class _MyGetResponseAsync_d__236 : ValueType
		{
			// Token: 0x06001A9B RID: 6811 RVA: 0x00070FC8 File Offset: 0x0006F1C8
			// Note: this type is marked as 'beforefieldinit'.
			static _MyGetResponseAsync_d__236()
			{
				Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<MyGetResponseAsync>d__236");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr);
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>1__state");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>t__builder");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>4__this");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "cancellationToken");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__operation_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<operation>5__1");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__throwMe_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<throwMe>5__2");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__completion_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<completion>5__3");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__redirect_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<redirect>5__4");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__response_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<response>5__5");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__ntlm_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<ntlm>5__6");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__mustReadAll_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<mustReadAll>5__7");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__stream_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<stream>5__8");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__writeBuffer_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<writeBuffer>5__9");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>u__1");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>u__2");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>u__3");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>u__4");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, 100665874);
				HttpWebRequest._MyGetResponseAsync_d__236.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, 100665875);
			}

			// Token: 0x06001A9C RID: 6812 RVA: 0x00071170 File Offset: 0x0006F370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382147, XrefRangeEnd = 382260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._MyGetResponseAsync_d__236.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A9D RID: 6813 RVA: 0x000711A8 File Offset: 0x0006F3A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382260, XrefRangeEnd = 382275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._MyGetResponseAsync_d__236.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A9E RID: 6814 RVA: 0x0000DAFD File Offset: 0x0000BCFD
			public _MyGetResponseAsync_d__236(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A9F RID: 6815 RVA: 0x0000DB06 File Offset: 0x0000BD06
			public _MyGetResponseAsync_d__236()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr))
			{
			}

			// Token: 0x17000873 RID: 2163
			// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x000711F0 File Offset: 0x0006F3F0
			// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0000DB18 File Offset: 0x0000BD18
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000874 RID: 2164
			// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x00071218 File Offset: 0x0006F418
			// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x0000DB33 File Offset: 0x0000BD33
			public AsyncTaskMethodBuilder<HttpWebResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<HttpWebResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpWebResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpWebResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000875 RID: 2165
			// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x00071248 File Offset: 0x0006F448
			// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x0000DB61 File Offset: 0x0000BD61
			public unsafe HttpWebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000876 RID: 2166
			// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x00071278 File Offset: 0x0006F478
			// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x0000DB80 File Offset: 0x0000BD80
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000877 RID: 2167
			// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x000712A8 File Offset: 0x0006F4A8
			// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x0000DBAE File Offset: 0x0000BDAE
			public unsafe WebOperation _operation_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__operation_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__operation_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000878 RID: 2168
			// (get) Token: 0x06001AAA RID: 6826 RVA: 0x000712D8 File Offset: 0x0006F4D8
			// (set) Token: 0x06001AAB RID: 6827 RVA: 0x0000DBCD File Offset: 0x0000BDCD
			public unsafe WebException _throwMe_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__throwMe_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__throwMe_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000879 RID: 2169
			// (get) Token: 0x06001AAC RID: 6828 RVA: 0x00071308 File Offset: 0x0006F508
			// (set) Token: 0x06001AAD RID: 6829 RVA: 0x0000DBEC File Offset: 0x0000BDEC
			public unsafe WebCompletionSource _completion_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__completion_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__completion_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087A RID: 2170
			// (get) Token: 0x06001AAE RID: 6830 RVA: 0x00071338 File Offset: 0x0006F538
			// (set) Token: 0x06001AAF RID: 6831 RVA: 0x0000DC0B File Offset: 0x0000BE0B
			public unsafe bool _redirect_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__redirect_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__redirect_5__4)) = value;
				}
			}

			// Token: 0x1700087B RID: 2171
			// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x00071360 File Offset: 0x0006F560
			// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0000DC26 File Offset: 0x0000BE26
			public unsafe HttpWebResponse _response_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__response_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__response_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087C RID: 2172
			// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00071390 File Offset: 0x0006F590
			// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x0000DC45 File Offset: 0x0000BE45
			public unsafe WebOperation _ntlm_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__ntlm_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__ntlm_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087D RID: 2173
			// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x000713C0 File Offset: 0x0006F5C0
			// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x0000DC64 File Offset: 0x0000BE64
			public unsafe bool _mustReadAll_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__mustReadAll_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__mustReadAll_5__7)) = value;
				}
			}

			// Token: 0x1700087E RID: 2174
			// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x000713E8 File Offset: 0x0006F5E8
			// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x0000DC7F File Offset: 0x0000BE7F
			public unsafe WebResponseStream _stream_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__stream_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__stream_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087F RID: 2175
			// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x00071418 File Offset: 0x0006F618
			// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x0000DC9E File Offset: 0x0000BE9E
			public unsafe BufferOffsetSize _writeBuffer_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__writeBuffer_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__writeBuffer_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000880 RID: 2176
			// (get) Token: 0x06001ABA RID: 6842 RVA: 0x00071448 File Offset: 0x0006F648
			// (set) Token: 0x06001ABB RID: 6843 RVA: 0x0000DCBD File Offset: 0x0000BEBD
			public TaskAwaiter<WebRequestStream> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<WebRequestStream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<WebRequestStream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<WebRequestStream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000881 RID: 2177
			// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00071478 File Offset: 0x0006F678
			// (set) Token: 0x06001ABD RID: 6845 RVA: 0x0000DCEB File Offset: 0x0000BEEB
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000882 RID: 2178
			// (get) Token: 0x06001ABE RID: 6846 RVA: 0x000714A8 File Offset: 0x0006F6A8
			// (set) Token: 0x06001ABF RID: 6847 RVA: 0x0000DD19 File Offset: 0x0000BF19
			public TaskAwaiter<WebResponseStream> __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__3);
					return new TaskAwaiter<WebResponseStream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<WebResponseStream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<WebResponseStream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000883 RID: 2179
			// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x000714D8 File Offset: 0x0006F6D8
			// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x0000DD47 File Offset: 0x0000BF47
			public ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__4);
					return new ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014D9 RID: 5337
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014DA RID: 5338
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014DB RID: 5339
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014DC RID: 5340
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014DD RID: 5341
			private static readonly IntPtr NativeFieldInfoPtr__operation_5__1;

			// Token: 0x040014DE RID: 5342
			private static readonly IntPtr NativeFieldInfoPtr__throwMe_5__2;

			// Token: 0x040014DF RID: 5343
			private static readonly IntPtr NativeFieldInfoPtr__completion_5__3;

			// Token: 0x040014E0 RID: 5344
			private static readonly IntPtr NativeFieldInfoPtr__redirect_5__4;

			// Token: 0x040014E1 RID: 5345
			private static readonly IntPtr NativeFieldInfoPtr__response_5__5;

			// Token: 0x040014E2 RID: 5346
			private static readonly IntPtr NativeFieldInfoPtr__ntlm_5__6;

			// Token: 0x040014E3 RID: 5347
			private static readonly IntPtr NativeFieldInfoPtr__mustReadAll_5__7;

			// Token: 0x040014E4 RID: 5348
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__8;

			// Token: 0x040014E5 RID: 5349
			private static readonly IntPtr NativeFieldInfoPtr__writeBuffer_5__9;

			// Token: 0x040014E6 RID: 5350
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014E7 RID: 5351
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040014E8 RID: 5352
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x040014E9 RID: 5353
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x040014EA RID: 5354
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014EB RID: 5355
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001E9 RID: 489
		[ObfuscatedName("System.Net.HttpWebRequest+<GetResponseFromData>d__237")]
		public sealed class _GetResponseFromData_d__237 : ValueType
		{
			// Token: 0x06001AC2 RID: 6850 RVA: 0x00071508 File Offset: 0x0006F708
			// Note: this type is marked as 'beforefieldinit'.
			static _GetResponseFromData_d__237()
			{
				Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<GetResponseFromData>d__237");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr);
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<>1__state");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<>t__builder");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<>4__this");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "stream");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "cancellationToken");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__throwMe_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<throwMe>5__1");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__rewriteHandler_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<rewriteHandler>5__2");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__redirect_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<redirect>5__3");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__response_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<response>5__4");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__writeBuffer_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<writeBuffer>5__5");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__mustReadAll_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<mustReadAll>5__6");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<>u__1");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<>u__2");
				HttpWebRequest._GetResponseFromData_d__237.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, 100665876);
				HttpWebRequest._GetResponseFromData_d__237.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, 100665877);
			}

			// Token: 0x06001AC3 RID: 6851 RVA: 0x00071660 File Offset: 0x0006F860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382275, XrefRangeEnd = 382334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._GetResponseFromData_d__237.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AC4 RID: 6852 RVA: 0x00071698 File Offset: 0x0006F898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382334, XrefRangeEnd = 382349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._GetResponseFromData_d__237.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AC5 RID: 6853 RVA: 0x0000DD75 File Offset: 0x0000BF75
			public _GetResponseFromData_d__237(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AC6 RID: 6854 RVA: 0x0000DD7E File Offset: 0x0000BF7E
			public _GetResponseFromData_d__237()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr))
			{
			}

			// Token: 0x17000884 RID: 2180
			// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x000716E0 File Offset: 0x0006F8E0
			// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x0000DD90 File Offset: 0x0000BF90
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x00071708 File Offset: 0x0006F908
			// (set) Token: 0x06001ACA RID: 6858 RVA: 0x0000DDAB File Offset: 0x0000BFAB
			public AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06001ACB RID: 6859 RVA: 0x00071738 File Offset: 0x0006F938
			// (set) Token: 0x06001ACC RID: 6860 RVA: 0x0000DDD9 File Offset: 0x0000BFD9
			public unsafe HttpWebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06001ACD RID: 6861 RVA: 0x00071768 File Offset: 0x0006F968
			// (set) Token: 0x06001ACE RID: 6862 RVA: 0x0000DDF8 File Offset: 0x0000BFF8
			public unsafe WebResponseStream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x06001ACF RID: 6863 RVA: 0x00071798 File Offset: 0x0006F998
			// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x0000DE17 File Offset: 0x0000C017
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x000717C8 File Offset: 0x0006F9C8
			// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x0000DE45 File Offset: 0x0000C045
			public unsafe WebException _throwMe_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__throwMe_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__throwMe_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088A RID: 2186
			// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x000717F8 File Offset: 0x0006F9F8
			// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x0000DE64 File Offset: 0x0000C064
			public unsafe Task<BufferOffsetSize> _rewriteHandler_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__rewriteHandler_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<BufferOffsetSize>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__rewriteHandler_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088B RID: 2187
			// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x00071828 File Offset: 0x0006FA28
			// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x0000DE83 File Offset: 0x0000C083
			public unsafe bool _redirect_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__redirect_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__redirect_5__3)) = value;
				}
			}

			// Token: 0x1700088C RID: 2188
			// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x00071850 File Offset: 0x0006FA50
			// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x0000DE9E File Offset: 0x0000C09E
			public unsafe HttpWebResponse _response_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__response_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__response_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088D RID: 2189
			// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x00071880 File Offset: 0x0006FA80
			// (set) Token: 0x06001ADA RID: 6874 RVA: 0x0000DEBD File Offset: 0x0000C0BD
			public unsafe BufferOffsetSize _writeBuffer_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__writeBuffer_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__writeBuffer_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088E RID: 2190
			// (get) Token: 0x06001ADB RID: 6875 RVA: 0x000718B0 File Offset: 0x0006FAB0
			// (set) Token: 0x06001ADC RID: 6876 RVA: 0x0000DEDC File Offset: 0x0000C0DC
			public unsafe bool _mustReadAll_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__mustReadAll_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__mustReadAll_5__6)) = value;
				}
			}

			// Token: 0x1700088F RID: 2191
			// (get) Token: 0x06001ADD RID: 6877 RVA: 0x000718D8 File Offset: 0x0006FAD8
			// (set) Token: 0x06001ADE RID: 6878 RVA: 0x0000DEF7 File Offset: 0x0000C0F7
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000890 RID: 2192
			// (get) Token: 0x06001ADF RID: 6879 RVA: 0x00071908 File Offset: 0x0006FB08
			// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x0000DF25 File Offset: 0x0000C125
			public ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014EC RID: 5356
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014ED RID: 5357
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014EE RID: 5358
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014EF RID: 5359
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x040014F0 RID: 5360
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014F1 RID: 5361
			private static readonly IntPtr NativeFieldInfoPtr__throwMe_5__1;

			// Token: 0x040014F2 RID: 5362
			private static readonly IntPtr NativeFieldInfoPtr__rewriteHandler_5__2;

			// Token: 0x040014F3 RID: 5363
			private static readonly IntPtr NativeFieldInfoPtr__redirect_5__3;

			// Token: 0x040014F4 RID: 5364
			private static readonly IntPtr NativeFieldInfoPtr__response_5__4;

			// Token: 0x040014F5 RID: 5365
			private static readonly IntPtr NativeFieldInfoPtr__writeBuffer_5__5;

			// Token: 0x040014F6 RID: 5366
			private static readonly IntPtr NativeFieldInfoPtr__mustReadAll_5__6;

			// Token: 0x040014F7 RID: 5367
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014F8 RID: 5368
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040014F9 RID: 5369
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014FA RID: 5370
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001EA RID: 490
		[ObfuscatedName("System.Net.HttpWebRequest+<<GetRewriteHandler>b__263_0>d")]
		public sealed class __GetRewriteHandler_b__263_0_d : ValueType
		{
			// Token: 0x06001AE1 RID: 6881 RVA: 0x00071938 File Offset: 0x0006FB38
			// Note: this type is marked as 'beforefieldinit'.
			static __GetRewriteHandler_b__263_0_d()
			{
				Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<<GetRewriteHandler>b__263_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr);
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, "<>1__state");
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, "<>t__builder");
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, "<>4__this");
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr__ms_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, "<ms>5__1");
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, "<>u__1");
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, 100665878);
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, 100665879);
			}

			// Token: 0x06001AE2 RID: 6882 RVA: 0x000719F0 File Offset: 0x0006FBF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382349, XrefRangeEnd = 382379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AE3 RID: 6883 RVA: 0x00071A28 File Offset: 0x0006FC28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382379, XrefRangeEnd = 382394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AE4 RID: 6884 RVA: 0x0000DF53 File Offset: 0x0000C153
			public __GetRewriteHandler_b__263_0_d(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AE5 RID: 6885 RVA: 0x0000DF5C File Offset: 0x0000C15C
			public __GetRewriteHandler_b__263_0_d()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr))
			{
			}

			// Token: 0x17000891 RID: 2193
			// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x00071A70 File Offset: 0x0006FC70
			// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x0000DF6E File Offset: 0x0000C16E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x00071A98 File Offset: 0x0006FC98
			// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x0000DF89 File Offset: 0x0000C189
			public AsyncTaskMethodBuilder<BufferOffsetSize> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<BufferOffsetSize>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<BufferOffsetSize>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<BufferOffsetSize>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000893 RID: 2195
			// (get) Token: 0x06001AEA RID: 6890 RVA: 0x00071AC8 File Offset: 0x0006FCC8
			// (set) Token: 0x06001AEB RID: 6891 RVA: 0x0000DFB7 File Offset: 0x0000C1B7
			public unsafe HttpWebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000894 RID: 2196
			// (get) Token: 0x06001AEC RID: 6892 RVA: 0x00071AF8 File Offset: 0x0006FCF8
			// (set) Token: 0x06001AED RID: 6893 RVA: 0x0000DFD6 File Offset: 0x0000C1D6
			public unsafe MemoryStream _ms_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr__ms_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr__ms_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000895 RID: 2197
			// (get) Token: 0x06001AEE RID: 6894 RVA: 0x00071B28 File Offset: 0x0006FD28
			// (set) Token: 0x06001AEF RID: 6895 RVA: 0x0000DFF5 File Offset: 0x0000C1F5
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014FB RID: 5371
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014FC RID: 5372
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014FD RID: 5373
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014FE RID: 5374
			private static readonly IntPtr NativeFieldInfoPtr__ms_5__1;

			// Token: 0x040014FF RID: 5375
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001500 RID: 5376
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001501 RID: 5377
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001EB RID: 491
		private sealed class MethodInfoStoreGeneric_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_0<T>
		{
			// Token: 0x04001502 RID: 5378
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_0, Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001EC RID: 492
		private sealed class MethodInfoStoreGeneric_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0<T>
		{
			// Token: 0x04001503 RID: 5379
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0, Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
