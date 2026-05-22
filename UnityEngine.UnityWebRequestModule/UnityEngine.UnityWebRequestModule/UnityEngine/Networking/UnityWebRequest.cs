using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngineInternal;

namespace UnityEngine.Networking
{
	// Token: 0x02000006 RID: 6
	public class UnityWebRequest : Object
	{
		// Token: 0x06000057 RID: 87 RVA: 0x000037A4 File Offset: 0x000019A4
		// Note: this type is marked as 'beforefieldinit'.
		static UnityWebRequest()
		{
			Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UnityWebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr);
			UnityWebRequest.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_Ptr");
			UnityWebRequest.NativeFieldInfoPtr_m_DownloadHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_DownloadHandler");
			UnityWebRequest.NativeFieldInfoPtr_m_UploadHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_UploadHandler");
			UnityWebRequest.NativeFieldInfoPtr_m_CertificateHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_CertificateHandler");
			UnityWebRequest.NativeFieldInfoPtr_m_Uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_Uri");
			UnityWebRequest.NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeCertificateHandlerOnDispose>k__BackingField");
			UnityWebRequest.NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeDownloadHandlerOnDispose>k__BackingField");
			UnityWebRequest.NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeUploadHandlerOnDispose>k__BackingField");
			UnityWebRequest.NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663322);
			UnityWebRequest.NativeMethodInfoPtr_GetHTTPStatusString_Internal_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663323);
			UnityWebRequest.NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663324);
			UnityWebRequest.NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663325);
			UnityWebRequest.NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663326);
			UnityWebRequest.NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663327);
			UnityWebRequest.NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663328);
			UnityWebRequest.NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663329);
			UnityWebRequest.NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663330);
			UnityWebRequest.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663331);
			UnityWebRequest.NativeMethodInfoPtr_InternalDestroy_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663332);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663333);
			UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663334);
			UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663335);
			UnityWebRequest.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663336);
			UnityWebRequest.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663337);
			UnityWebRequest.NativeMethodInfoPtr_DisposeHandlers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663338);
			UnityWebRequest.NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663339);
			UnityWebRequest.NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663340);
			UnityWebRequest.NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663341);
			UnityWebRequest.NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663342);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663343);
			UnityWebRequest.NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663344);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663345);
			UnityWebRequest.NativeMethodInfoPtr_set_method_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663346);
			UnityWebRequest.NativeMethodInfoPtr_GetError_Private_UnityWebRequestError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663347);
			UnityWebRequest.NativeMethodInfoPtr_get_error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663348);
			UnityWebRequest.NativeMethodInfoPtr_set_url_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663349);
			UnityWebRequest.NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663350);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663351);
			UnityWebRequest.NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663352);
			UnityWebRequest.NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663353);
			UnityWebRequest.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663354);
			UnityWebRequest.NativeMethodInfoPtr_get_result_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663355);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663356);
			UnityWebRequest.NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663357);
			UnityWebRequest.NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663358);
			UnityWebRequest.NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663359);
			UnityWebRequest.NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663360);
			UnityWebRequest.NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663361);
			UnityWebRequest.NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663362);
			UnityWebRequest.NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663363);
			UnityWebRequest.NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663364);
			UnityWebRequest.NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663365);
			UnityWebRequest.NativeMethodInfoPtr_Post_Public_Static_UnityWebRequest_String_WWWForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663366);
			UnityWebRequest.NativeMethodInfoPtr_SetupPost_Private_Static_Void_UnityWebRequest_WWWForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663367);
			UnityWebRequest.ClearCookieCacheDelegateField = IL2CPP.ResolveICall<UnityWebRequest.ClearCookieCacheDelegate>("UnityEngine.Networking.UnityWebRequest::ClearCookieCache");
			UnityWebRequest.GetMethodDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetMethodDelegate>("UnityEngine.Networking.UnityWebRequest::GetMethod");
			UnityWebRequest.GetCustomMethodDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetCustomMethodDelegate>("UnityEngine.Networking.UnityWebRequest::GetCustomMethod");
			UnityWebRequest.get_use100ContinueDelegateField = IL2CPP.ResolveICall<UnityWebRequest.get_use100ContinueDelegate>("UnityEngine.Networking.UnityWebRequest::get_use100Continue");
			UnityWebRequest.set_use100ContinueDelegateField = IL2CPP.ResolveICall<UnityWebRequest.set_use100ContinueDelegate>("UnityEngine.Networking.UnityWebRequest::set_use100Continue");
			UnityWebRequest.GetUrlDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetUrlDelegate>("UnityEngine.Networking.UnityWebRequest::GetUrl");
			UnityWebRequest.GetUploadProgressDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetUploadProgressDelegate>("UnityEngine.Networking.UnityWebRequest::GetUploadProgress");
			UnityWebRequest.IsExecutingDelegateField = IL2CPP.ResolveICall<UnityWebRequest.IsExecutingDelegate>("UnityEngine.Networking.UnityWebRequest::IsExecuting");
			UnityWebRequest.GetDownloadProgressDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetDownloadProgressDelegate>("UnityEngine.Networking.UnityWebRequest::GetDownloadProgress");
			UnityWebRequest.get_uploadedBytesDelegateField = IL2CPP.ResolveICall<UnityWebRequest.get_uploadedBytesDelegate>("UnityEngine.Networking.UnityWebRequest::get_uploadedBytes");
			UnityWebRequest.get_downloadedBytesDelegateField = IL2CPP.ResolveICall<UnityWebRequest.get_downloadedBytesDelegate>("UnityEngine.Networking.UnityWebRequest::get_downloadedBytes");
			UnityWebRequest.GetRedirectLimitDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetRedirectLimitDelegate>("UnityEngine.Networking.UnityWebRequest::GetRedirectLimit");
			UnityWebRequest.SetRedirectLimitFromScriptingDelegateField = IL2CPP.ResolveICall<UnityWebRequest.SetRedirectLimitFromScriptingDelegate>("UnityEngine.Networking.UnityWebRequest::SetRedirectLimitFromScripting");
			UnityWebRequest.GetChunkedDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetChunkedDelegate>("UnityEngine.Networking.UnityWebRequest::GetChunked");
			UnityWebRequest.SetChunkedDelegateField = IL2CPP.ResolveICall<UnityWebRequest.SetChunkedDelegate>("UnityEngine.Networking.UnityWebRequest::SetChunked");
			UnityWebRequest.GetRequestHeaderDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetRequestHeaderDelegate>("UnityEngine.Networking.UnityWebRequest::GetRequestHeader");
			UnityWebRequest.GetResponseHeaderDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetResponseHeaderDelegate>("UnityEngine.Networking.UnityWebRequest::GetResponseHeader");
			UnityWebRequest.GetResponseHeaderKeysDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetResponseHeaderKeysDelegate>("UnityEngine.Networking.UnityWebRequest::GetResponseHeaderKeys");
			UnityWebRequest.SetCertificateHandlerDelegateField = IL2CPP.ResolveICall<UnityWebRequest.SetCertificateHandlerDelegate>("UnityEngine.Networking.UnityWebRequest::SetCertificateHandler");
			UnityWebRequest.GetTimeoutMsecDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetTimeoutMsecDelegate>("UnityEngine.Networking.UnityWebRequest::GetTimeoutMsec");
			UnityWebRequest.SetTimeoutMsecDelegateField = IL2CPP.ResolveICall<UnityWebRequest.SetTimeoutMsecDelegate>("UnityEngine.Networking.UnityWebRequest::SetTimeoutMsec");
			UnityWebRequest.GetSuppressErrorsToConsoleDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetSuppressErrorsToConsoleDelegate>("UnityEngine.Networking.UnityWebRequest::GetSuppressErrorsToConsole");
			UnityWebRequest.SetSuppressErrorsToConsoleDelegateField = IL2CPP.ResolveICall<UnityWebRequest.SetSuppressErrorsToConsoleDelegate>("UnityEngine.Networking.UnityWebRequest::SetSuppressErrorsToConsole");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003D68 File Offset: 0x00001F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534599, XrefRangeEnd = 534603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref err;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003DA0 File Offset: 0x00001FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534603, XrefRangeEnd = 534607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHTTPStatusString(long responseCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref responseCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetHTTPStatusString_Internal_Static_String_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003DD8 File Offset: 0x00001FD8
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00003E14 File Offset: 0x00002014
		public unsafe bool disposeCertificateHandlerOnDispose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003E54 File Offset: 0x00002054
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00003E90 File Offset: 0x00002090
		public unsafe bool disposeDownloadHandlerOnDispose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003ED0 File Offset: 0x000020D0
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00003F0C File Offset: 0x0000210C
		public unsafe bool disposeUploadHandlerOnDispose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003F4C File Offset: 0x0000214C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534607, XrefRangeEnd = 534611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003F7C File Offset: 0x0000217C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534611, XrefRangeEnd = 534615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003FB0 File Offset: 0x000021B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534620, RefRangeEnd = 534622, XrefRangeStart = 534615, XrefRangeEnd = 534620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalDestroy_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003FE4 File Offset: 0x000021E4
		[CallerCount(0)]
		public unsafe void InternalSetDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004018 File Offset: 0x00002218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534622, XrefRangeEnd = 534628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest(string url, string method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004078 File Offset: 0x00002278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534628, XrefRangeEnd = 534636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downloadHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uploadHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000040FC File Offset: 0x000022FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534636, XrefRangeEnd = 534639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityWebRequest.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004138 File Offset: 0x00002338
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 534645, RefRangeEnd = 534649, XrefRangeStart = 534639, XrefRangeEnd = 534645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000416C File Offset: 0x0000236C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534654, RefRangeEnd = 534656, XrefRangeStart = 534649, XrefRangeEnd = 534654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeHandlers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_DisposeHandlers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000041A0 File Offset: 0x000023A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534656, XrefRangeEnd = 534660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestAsyncOperation BeginWebRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000041E0 File Offset: 0x000023E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534660, XrefRangeEnd = 534662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestAsyncOperation SendWebRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004220 File Offset: 0x00002420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534662, XrefRangeEnd = 534666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004254 File Offset: 0x00002454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534666, XrefRangeEnd = 534670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref methodType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000042A0 File Offset: 0x000024A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 534674, RefRangeEnd = 534675, XrefRangeStart = 534670, XrefRangeEnd = 534674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref methodType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000042E0 File Offset: 0x000024E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534675, XrefRangeEnd = 534679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(customMethodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004330 File Offset: 0x00002530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534679, XrefRangeEnd = 534683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetCustomMethod(string customMethodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(customMethodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00004B5C File Offset: 0x00002D5C
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00004374 File Offset: 0x00002574
		public unsafe string method
		{
			get
			{
				string text;
				switch (this.GetMethod())
				{
				case UnityWebRequest.UnityWebRequestMethod.Get:
					text = "GET";
					break;
				case UnityWebRequest.UnityWebRequestMethod.Post:
					text = "POST";
					break;
				case UnityWebRequest.UnityWebRequestMethod.Put:
					text = "PUT";
					break;
				case UnityWebRequest.UnityWebRequestMethod.Head:
					text = "HEAD";
					break;
				default:
					text = this.GetCustomMethod();
					break;
				}
				return text;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 534693, RefRangeEnd = 534697, XrefRangeStart = 534683, XrefRangeEnd = 534693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_method_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000043B8 File Offset: 0x000025B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534697, XrefRangeEnd = 534701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError GetError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetError_Private_UnityWebRequestError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000043F4 File Offset: 0x000025F4
		public unsafe string error
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 534705, RefRangeEnd = 534708, XrefRangeStart = 534701, XrefRangeEnd = 534705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004C00 File Offset: 0x00002E00
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000442C File Offset: 0x0000262C
		public unsafe string url
		{
			get
			{
				return this.GetUrl();
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 534718, RefRangeEnd = 534722, XrefRangeStart = 534708, XrefRangeEnd = 534718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_url_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004470 File Offset: 0x00002670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534722, XrefRangeEnd = 534726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetUrl(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000044C0 File Offset: 0x000026C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534726, XrefRangeEnd = 534730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetUrl(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00004504 File Offset: 0x00002704
		public unsafe long responseCode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534730, XrefRangeEnd = 534734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004540 File Offset: 0x00002740
		public unsafe bool isModifiable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534734, XrefRangeEnd = 534738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000457C File Offset: 0x0000277C
		public unsafe bool isDone
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534738, XrefRangeEnd = 534740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000045B8 File Offset: 0x000027B8
		public unsafe UnityWebRequest.Result result
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534740, XrefRangeEnd = 534744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_result_Public_get_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000045F4 File Offset: 0x000027F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534744, XrefRangeEnd = 534748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004654 File Offset: 0x00002854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 534752, RefRangeEnd = 534753, XrefRangeStart = 534748, XrefRangeEnd = 534752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRequestHeader(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000046A8 File Offset: 0x000028A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534753, XrefRangeEnd = 534757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000046F8 File Offset: 0x000028F8
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00004738 File Offset: 0x00002938
		public unsafe UploadHandler uploadHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UploadHandler>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 534761, RefRangeEnd = 534764, XrefRangeStart = 534757, XrefRangeEnd = 534761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000477C File Offset: 0x0000297C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534764, XrefRangeEnd = 534768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000047CC File Offset: 0x000029CC
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000480C File Offset: 0x00002A0C
		public unsafe DownloadHandler downloadHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DownloadHandler>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 534772, RefRangeEnd = 534775, XrefRangeStart = 534768, XrefRangeEnd = 534772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00004850 File Offset: 0x00002A50
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00004E40 File Offset: 0x00003040
		public unsafe CertificateHandler certificateHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CertificateHandler>(intPtr3) : null;
			}
			set
			{
				bool flag = !this.isModifiable;
				if (flag)
				{
					throw new InvalidOperationException("UnityWebRequest has already been sent; cannot modify the certificate handler");
				}
				UnityWebRequest.UnityWebRequestError unityWebRequestError = this.SetCertificateHandler(value);
				bool flag2 = unityWebRequestError > UnityWebRequest.UnityWebRequestError.OK;
				if (flag2)
				{
					throw new InvalidOperationException(UnityWebRequest.GetWebErrorString(unityWebRequestError));
				}
				this.m_CertificateHandler = value;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004890 File Offset: 0x00002A90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 534791, RefRangeEnd = 534795, XrefRangeStart = 534775, XrefRangeEnd = 534791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest Get(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000048D4 File Offset: 0x00002AD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534805, RefRangeEnd = 534807, XrefRangeStart = 534795, XrefRangeEnd = 534805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest Post(string uri, WWWForm formData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Post_Public_Static_UnityWebRequest_String_WWWForm_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000492C File Offset: 0x00002B2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 534851, RefRangeEnd = 534852, XrefRangeStart = 534807, XrefRangeEnd = 534851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupPost(UnityWebRequest request, WWWForm formData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetupPost_Private_Static_Void_UnityWebRequest_WWWForm_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002238 File Offset: 0x00000438
		public UnityWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00004974 File Offset: 0x00002B74
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002241 File Offset: 0x00000441
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000499C File Offset: 0x00002B9C
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000225C File Offset: 0x0000045C
		public unsafe DownloadHandler m_DownloadHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_DownloadHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DownloadHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_DownloadHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000049CC File Offset: 0x00002BCC
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000227B File Offset: 0x0000047B
		public unsafe UploadHandler m_UploadHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_UploadHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UploadHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_UploadHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000049FC File Offset: 0x00002BFC
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000229A File Offset: 0x0000049A
		public unsafe CertificateHandler m_CertificateHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_CertificateHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CertificateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_CertificateHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00004A2C File Offset: 0x00002C2C
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000022B9 File Offset: 0x000004B9
		public unsafe Uri m_Uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00004A5C File Offset: 0x00002C5C
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000022D8 File Offset: 0x000004D8
		public unsafe bool _disposeCertificateHandlerOnDispose_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00004A84 File Offset: 0x00002C84
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000022F3 File Offset: 0x000004F3
		public unsafe bool _disposeDownloadHandlerOnDispose_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00004AAC File Offset: 0x00002CAC
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000230E File Offset: 0x0000050E
		public unsafe bool _disposeUploadHandlerOnDispose_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField)) = value;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002329 File Offset: 0x00000529
		public static void ClearCookieCache()
		{
			UnityWebRequest.ClearCookieCache(null, null);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004AD4 File Offset: 0x00002CD4
		public static void ClearCookieCache(Uri uri)
		{
			bool flag = uri == null;
			if (flag)
			{
				UnityWebRequest.ClearCookieCache(null, null);
			}
			else
			{
				string host = uri.Host;
				string text = uri.AbsolutePath;
				bool flag2 = text == "/";
				if (flag2)
				{
					text = null;
				}
				UnityWebRequest.ClearCookieCache(host, text);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002334 File Offset: 0x00000534
		public static void ClearCookieCache(string domain, string path)
		{
			UnityWebRequest.ClearCookieCacheDelegateField(IL2CPP.ManagedStringToIl2Cpp(domain), IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004B20 File Offset: 0x00002D20
		public AsyncOperation Send()
		{
			return this.SendWebRequest();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000234C File Offset: 0x0000054C
		public UnityWebRequest.UnityWebRequestMethod GetMethod()
		{
			return UnityWebRequest.GetMethodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004B38 File Offset: 0x00002D38
		public string GetCustomMethod()
		{
			IntPtr intPtr = UnityWebRequest.GetCustomMethodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000235E File Offset: 0x0000055E
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002370 File Offset: 0x00000570
		public bool use100Continue
		{
			get
			{
				return UnityWebRequest.get_use100ContinueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				UnityWebRequest.set_use100ContinueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004BB8 File Offset: 0x00002DB8
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00004BD0 File Offset: 0x00002DD0
		public bool useHttpContinue
		{
			get
			{
				return this.use100Continue;
			}
			set
			{
				bool flag = !this.isModifiable;
				if (flag)
				{
					throw new InvalidOperationException("UnityWebRequest has already been sent and its 100-Continue setting cannot be altered");
				}
				this.use100Continue = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004C18 File Offset: 0x00002E18
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00004C38 File Offset: 0x00002E38
		public Uri uri
		{
			get
			{
				return new Uri(this.GetUrl());
			}
			set
			{
				bool flag = !value.IsAbsoluteUri;
				if (flag)
				{
					throw new ArgumentException("URI must be absolute");
				}
				this.InternalSetUrl(global::UnityEngineInternal.WebRequestUtils.MakeUriString(value, value.OriginalString, false));
				this.m_Uri = value;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004C7C File Offset: 0x00002E7C
		public string GetUrl()
		{
			IntPtr intPtr = UnityWebRequest.GetUrlDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002383 File Offset: 0x00000583
		public float GetUploadProgress()
		{
			return UnityWebRequest.GetUploadProgressDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002395 File Offset: 0x00000595
		public bool IsExecuting()
		{
			return UnityWebRequest.IsExecutingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004CA0 File Offset: 0x00002EA0
		public float uploadProgress
		{
			get
			{
				bool flag = !this.IsExecuting() && !this.isDone;
				float num;
				if (flag)
				{
					num = -1f;
				}
				else
				{
					num = this.GetUploadProgress();
				}
				return num;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00004CD8 File Offset: 0x00002ED8
		public bool isNetworkError
		{
			get
			{
				return this.result == UnityWebRequest.Result.ConnectionError;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00004CF4 File Offset: 0x00002EF4
		public bool isHttpError
		{
			get
			{
				return this.result == UnityWebRequest.Result.ProtocolError;
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000023A7 File Offset: 0x000005A7
		public float GetDownloadProgress()
		{
			return UnityWebRequest.GetDownloadProgressDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00004D10 File Offset: 0x00002F10
		public float downloadProgress
		{
			get
			{
				bool flag = !this.IsExecuting() && !this.isDone;
				float num;
				if (flag)
				{
					num = -1f;
				}
				else
				{
					num = this.GetDownloadProgress();
				}
				return num;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000023B9 File Offset: 0x000005B9
		public ulong uploadedBytes
		{
			get
			{
				return UnityWebRequest.get_uploadedBytesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000023CB File Offset: 0x000005CB
		public ulong downloadedBytes
		{
			get
			{
				return UnityWebRequest.get_downloadedBytesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000023DD File Offset: 0x000005DD
		public int GetRedirectLimit()
		{
			return UnityWebRequest.GetRedirectLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000023EF File Offset: 0x000005EF
		public void SetRedirectLimitFromScripting(int limit)
		{
			UnityWebRequest.SetRedirectLimitFromScriptingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), limit);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00004D48 File Offset: 0x00002F48
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002402 File Offset: 0x00000602
		public int redirectLimit
		{
			get
			{
				return this.GetRedirectLimit();
			}
			set
			{
				this.SetRedirectLimitFromScripting(value);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000240D File Offset: 0x0000060D
		public bool GetChunked()
		{
			return UnityWebRequest.GetChunkedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000241F File Offset: 0x0000061F
		public UnityWebRequest.UnityWebRequestError SetChunked(bool chunked)
		{
			return UnityWebRequest.SetChunkedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), chunked);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004D60 File Offset: 0x00002F60
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00004D78 File Offset: 0x00002F78
		public bool chunkedTransfer
		{
			get
			{
				return this.GetChunked();
			}
			set
			{
				bool flag = !this.isModifiable;
				if (flag)
				{
					throw new InvalidOperationException("UnityWebRequest has already been sent and its chunked transfer encoding setting cannot be altered");
				}
				UnityWebRequest.UnityWebRequestError unityWebRequestError = this.SetChunked(value);
				bool flag2 = unityWebRequestError > UnityWebRequest.UnityWebRequestError.OK;
				if (flag2)
				{
					throw new InvalidOperationException(UnityWebRequest.GetWebErrorString(unityWebRequestError));
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004DBC File Offset: 0x00002FBC
		public string GetRequestHeader(string name)
		{
			IntPtr intPtr = UnityWebRequest.GetRequestHeaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004DE8 File Offset: 0x00002FE8
		public string GetResponseHeader(string name)
		{
			IntPtr intPtr = UnityWebRequest.GetResponseHeaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004E14 File Offset: 0x00003014
		public Il2CppStringArray GetResponseHeaderKeys()
		{
			IntPtr intPtr = UnityWebRequest.GetResponseHeaderKeysDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002432 File Offset: 0x00000632
		public Dictionary<string, string> GetResponseHeaders()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000243F File Offset: 0x0000063F
		public UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch)
		{
			return UnityWebRequest.SetCertificateHandlerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(ch));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002457 File Offset: 0x00000657
		public int GetTimeoutMsec()
		{
			return UnityWebRequest.GetTimeoutMsecDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002469 File Offset: 0x00000669
		public UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout)
		{
			return UnityWebRequest.SetTimeoutMsecDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeout);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00004E8C File Offset: 0x0000308C
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00004EAC File Offset: 0x000030AC
		public int timeout
		{
			get
			{
				return this.GetTimeoutMsec() / 1000;
			}
			set
			{
				bool flag = !this.isModifiable;
				if (flag)
				{
					throw new InvalidOperationException("UnityWebRequest has already been sent; cannot modify the timeout");
				}
				value = Math.Max(value, 0);
				UnityWebRequest.UnityWebRequestError unityWebRequestError = this.SetTimeoutMsec(value * 1000);
				bool flag2 = unityWebRequestError > UnityWebRequest.UnityWebRequestError.OK;
				if (flag2)
				{
					throw new InvalidOperationException(UnityWebRequest.GetWebErrorString(unityWebRequestError));
				}
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000247C File Offset: 0x0000067C
		public bool GetSuppressErrorsToConsole()
		{
			return UnityWebRequest.GetSuppressErrorsToConsoleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000248E File Offset: 0x0000068E
		public UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsole(bool suppress)
		{
			return UnityWebRequest.SetSuppressErrorsToConsoleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), suppress);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00004F00 File Offset: 0x00003100
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00004F18 File Offset: 0x00003118
		public bool suppressErrorsToConsole
		{
			get
			{
				return this.GetSuppressErrorsToConsole();
			}
			set
			{
				bool flag = !this.isModifiable;
				if (flag)
				{
					throw new InvalidOperationException("UnityWebRequest has already been sent; cannot modify the timeout");
				}
				UnityWebRequest.UnityWebRequestError unityWebRequestError = this.SetSuppressErrorsToConsole(value);
				bool flag2 = unityWebRequestError > UnityWebRequest.UnityWebRequestError.OK;
				if (flag2)
				{
					throw new InvalidOperationException(UnityWebRequest.GetWebErrorString(unityWebRequestError));
				}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004F5C File Offset: 0x0000315C
		public static UnityWebRequest Get(Uri uri)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerBuffer(), null);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004F84 File Offset: 0x00003184
		public static UnityWebRequest Delete(string uri)
		{
			return new UnityWebRequest(uri, "DELETE");
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004FA4 File Offset: 0x000031A4
		public static UnityWebRequest Delete(Uri uri)
		{
			return new UnityWebRequest(uri, "DELETE");
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00004FC4 File Offset: 0x000031C4
		public static UnityWebRequest Head(string uri)
		{
			return new UnityWebRequest(uri, "HEAD");
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004FE4 File Offset: 0x000031E4
		public static UnityWebRequest Head(Uri uri)
		{
			return new UnityWebRequest(uri, "HEAD");
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000024A1 File Offset: 0x000006A1
		public static UnityWebRequest GetTexture(string uri)
		{
			throw new NotSupportedException("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead.");
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000024AE File Offset: 0x000006AE
		public static UnityWebRequest GetTexture(string uri, bool nonReadable)
		{
			throw new NotSupportedException("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead.");
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005004 File Offset: 0x00003204
		public static UnityWebRequest GetAudioClip(string uri, AudioType audioType)
		{
			return null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005018 File Offset: 0x00003218
		public static UnityWebRequest GetAssetBundle(string uri)
		{
			return null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000502C File Offset: 0x0000322C
		public static UnityWebRequest GetAssetBundle(string uri, uint crc)
		{
			return null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005040 File Offset: 0x00003240
		public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
		{
			return null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005054 File Offset: 0x00003254
		public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc)
		{
			return null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005068 File Offset: 0x00003268
		public static UnityWebRequest Put(string uri, Il2CppStructArray<byte> bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(bodyData));
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005094 File Offset: 0x00003294
		public static UnityWebRequest Put(Uri uri, Il2CppStructArray<byte> bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(bodyData));
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000050C0 File Offset: 0x000032C0
		public static UnityWebRequest Put(string uri, string bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(Encoding.UTF8.GetBytes(bodyData)));
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000050F4 File Offset: 0x000032F4
		public static UnityWebRequest Put(Uri uri, string bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(Encoding.UTF8.GetBytes(bodyData)));
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005128 File Offset: 0x00003328
		public static UnityWebRequest Post(string uri, string postData)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, postData);
			return unityWebRequest;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005150 File Offset: 0x00003350
		public static UnityWebRequest Post(Uri uri, string postData)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, postData);
			return unityWebRequest;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005178 File Offset: 0x00003378
		public static void SetupPost(UnityWebRequest request, string postData)
		{
			Il2CppStructArray<byte> il2CppStructArray = null;
			bool flag = !String.IsNullOrEmpty(postData);
			if (flag)
			{
				string text = WWWTranscoder.DataEncode(postData, Encoding.UTF8);
				il2CppStructArray = Encoding.UTF8.GetBytes(text);
			}
			request.uploadHandler = new UploadHandlerRaw(il2CppStructArray);
			request.uploadHandler.contentType = "application/x-www-form-urlencoded";
			request.downloadHandler = new DownloadHandlerBuffer();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000051DC File Offset: 0x000033DC
		public static UnityWebRequest Post(Uri uri, WWWForm formData)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, formData);
			return unityWebRequest;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005204 File Offset: 0x00003404
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections)
		{
			Il2CppStructArray<byte> il2CppStructArray = UnityWebRequest.GenerateBoundary();
			return UnityWebRequest.Post(uri, multipartFormSections, il2CppStructArray);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005224 File Offset: 0x00003424
		public static UnityWebRequest Post(Uri uri, List<IMultipartFormSection> multipartFormSections)
		{
			Il2CppStructArray<byte> il2CppStructArray = UnityWebRequest.GenerateBoundary();
			return UnityWebRequest.Post(uri, multipartFormSections, il2CppStructArray);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005244 File Offset: 0x00003444
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, multipartFormSections, boundary);
			return unityWebRequest;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000526C File Offset: 0x0000346C
		public static UnityWebRequest Post(Uri uri, List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, multipartFormSections, boundary);
			return unityWebRequest;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00005294 File Offset: 0x00003494
		public static void SetupPost(UnityWebRequest request, List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
		{
			Il2CppStructArray<byte> il2CppStructArray = null;
			bool flag = multipartFormSections != null && multipartFormSections.Count != 0;
			if (flag)
			{
				il2CppStructArray = UnityWebRequest.SerializeFormSections(multipartFormSections, boundary);
			}
			request.uploadHandler = new UploadHandlerRaw(il2CppStructArray)
			{
				contentType = String.Concat("multipart/form-data; boundary=", Encoding.UTF8.GetString(boundary, 0, boundary.Length))
			};
			request.downloadHandler = new DownloadHandlerBuffer();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005300 File Offset: 0x00003500
		public static UnityWebRequest Post(string uri, Dictionary<string, string> formFields)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, formFields);
			return unityWebRequest;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005328 File Offset: 0x00003528
		public static UnityWebRequest Post(Uri uri, Dictionary<string, string> formFields)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, formFields);
			return unityWebRequest;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005350 File Offset: 0x00003550
		public static void SetupPost(UnityWebRequest request, Dictionary<string, string> formFields)
		{
			Il2CppStructArray<byte> il2CppStructArray = null;
			bool flag = formFields != null && formFields.Count != 0;
			if (flag)
			{
				il2CppStructArray = UnityWebRequest.SerializeSimpleForm(formFields);
			}
			request.uploadHandler = new UploadHandlerRaw(il2CppStructArray)
			{
				contentType = "application/x-www-form-urlencoded"
			};
			request.downloadHandler = new DownloadHandlerBuffer();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000053A4 File Offset: 0x000035A4
		public static string EscapeURL(string s)
		{
			return UnityWebRequest.EscapeURL(s, Encoding.UTF8);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000053C4 File Offset: 0x000035C4
		public static string EscapeURL(string s, Encoding e)
		{
			bool flag = s == null;
			string text;
			if (flag)
			{
				text = null;
			}
			else
			{
				bool flag2 = s == "";
				if (flag2)
				{
					text = "";
				}
				else
				{
					bool flag3 = e == null;
					if (flag3)
					{
						text = null;
					}
					else
					{
						Il2CppStructArray<byte> bytes = e.GetBytes(s);
						Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.URLEncode(bytes);
						text = e.GetString(il2CppStructArray);
					}
				}
			}
			return text;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005420 File Offset: 0x00003620
		public static string UnEscapeURL(string s)
		{
			return UnityWebRequest.UnEscapeURL(s, Encoding.UTF8);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005440 File Offset: 0x00003640
		public static string UnEscapeURL(string s, Encoding e)
		{
			bool flag = s == null;
			string text;
			if (flag)
			{
				text = null;
			}
			else
			{
				bool flag2 = s.IndexOf('%') == -1 && s.IndexOf('+') == -1;
				if (flag2)
				{
					text = s;
				}
				else
				{
					Il2CppStructArray<byte> bytes = e.GetBytes(s);
					Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.URLDecode(bytes);
					text = e.GetString(il2CppStructArray);
				}
			}
			return text;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005498 File Offset: 0x00003698
		public static Il2CppStructArray<byte> SerializeFormSections(List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
		{
			bool flag = multipartFormSections == null || multipartFormSections.Count == 0;
			Il2CppStructArray<byte> il2CppStructArray;
			if (flag)
			{
				il2CppStructArray = null;
			}
			else
			{
				Il2CppStructArray<byte> bytes = Encoding.UTF8.GetBytes("\r\n");
				Il2CppStructArray<byte> bytes2 = WWWForm.DefaultEncoding.GetBytes("--");
				int num = 0;
				List<IMultipartFormSection>.Enumerator enumerator = multipartFormSections.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						IMultipartFormSection multipartFormSection = enumerator.Current;
						num += 64 + multipartFormSection.sectionData.Length;
					}
				}
				finally
				{
					enumerator.Dispose();
				}
				List<byte> list = new List<byte>(num);
				List<IMultipartFormSection>.Enumerator enumerator2 = multipartFormSections.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						IMultipartFormSection multipartFormSection2 = enumerator2.Current;
						string text = "form-data";
						string sectionName = multipartFormSection2.sectionName;
						string fileName = multipartFormSection2.fileName;
						string text2 = String.Concat("Content-Disposition: ", text);
						bool flag2 = !String.IsNullOrEmpty(sectionName);
						if (flag2)
						{
							text2 = String.Concat(text2, "; name=\"", sectionName, "\"");
						}
						bool flag3 = !String.IsNullOrEmpty(fileName);
						if (flag3)
						{
							text2 = String.Concat(text2, "; filename=\"", fileName, "\"");
						}
						text2 = String.Concat(text2, "\r\n");
						string contentType = multipartFormSection2.contentType;
						bool flag4 = !String.IsNullOrEmpty(contentType);
						if (flag4)
						{
							text2 = String.Concat(text2, "Content-Type: ", contentType, "\r\n");
						}
						list.AddRange(bytes);
						list.AddRange(bytes2);
						list.AddRange(boundary);
						list.AddRange(bytes);
						list.AddRange(Encoding.UTF8.GetBytes(text2));
						list.AddRange(bytes);
						list.AddRange(multipartFormSection2.sectionData);
					}
				}
				finally
				{
					enumerator2.Dispose();
				}
				list.AddRange(bytes);
				list.AddRange(bytes2);
				list.AddRange(boundary);
				list.AddRange(bytes2);
				list.AddRange(bytes);
				il2CppStructArray = list.ToArray();
			}
			return il2CppStructArray;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000024BB File Offset: 0x000006BB
		public static Il2CppStructArray<byte> GenerateBoundary()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000056CC File Offset: 0x000038CC
		public static Il2CppStructArray<byte> SerializeSimpleForm(Dictionary<string, string> formFields)
		{
			string text = "";
			Dictionary<string, string>.Enumerator enumerator = formFields.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					bool flag = text.Length > 0;
					if (flag)
					{
						text = String.Concat(text, "&");
					}
					text = String.Concat(text, WWWTranscoder.DataEncode(keyValuePair.Key), "=", WWWTranscoder.DataEncode(keyValuePair.Value));
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			return Encoding.UTF8.GetBytes(text);
		}

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_m_DownloadHandler;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_m_UploadHandler;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_m_CertificateHandler;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_m_Uri;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPStatusString_Internal_Static_String_Int64_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_InternalDestroy_Internal_Void_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_DisposeHandlers_Private_Void_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_set_method_Public_set_Void_String_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_GetError_Private_UnityWebRequestError_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_get_error_Public_get_String_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_set_url_Public_set_Void_String_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_result_Public_get_Result_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Static_UnityWebRequest_String_WWWForm_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_SetupPost_Private_Static_Void_UnityWebRequest_WWWForm_0;

		// Token: 0x0400005F RID: 95
		public const string kHttpVerbGET = "GET";

		// Token: 0x04000060 RID: 96
		public const string kHttpVerbHEAD = "HEAD";

		// Token: 0x04000061 RID: 97
		public const string kHttpVerbPOST = "POST";

		// Token: 0x04000062 RID: 98
		public const string kHttpVerbPUT = "PUT";

		// Token: 0x04000063 RID: 99
		public const string kHttpVerbCREATE = "CREATE";

		// Token: 0x04000064 RID: 100
		public const string kHttpVerbDELETE = "DELETE";

		// Token: 0x04000065 RID: 101
		private static readonly UnityWebRequest.ClearCookieCacheDelegate ClearCookieCacheDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly UnityWebRequest.GetMethodDelegate GetMethodDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly UnityWebRequest.GetCustomMethodDelegate GetCustomMethodDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly UnityWebRequest.get_use100ContinueDelegate get_use100ContinueDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly UnityWebRequest.set_use100ContinueDelegate set_use100ContinueDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly UnityWebRequest.GetUrlDelegate GetUrlDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly UnityWebRequest.GetUploadProgressDelegate GetUploadProgressDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly UnityWebRequest.IsExecutingDelegate IsExecutingDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly UnityWebRequest.GetDownloadProgressDelegate GetDownloadProgressDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly UnityWebRequest.get_uploadedBytesDelegate get_uploadedBytesDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly UnityWebRequest.get_downloadedBytesDelegate get_downloadedBytesDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly UnityWebRequest.GetRedirectLimitDelegate GetRedirectLimitDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly UnityWebRequest.SetRedirectLimitFromScriptingDelegate SetRedirectLimitFromScriptingDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly UnityWebRequest.GetChunkedDelegate GetChunkedDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly UnityWebRequest.SetChunkedDelegate SetChunkedDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly UnityWebRequest.GetRequestHeaderDelegate GetRequestHeaderDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly UnityWebRequest.GetResponseHeaderDelegate GetResponseHeaderDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly UnityWebRequest.GetResponseHeaderKeysDelegate GetResponseHeaderKeysDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly UnityWebRequest.SetCertificateHandlerDelegate SetCertificateHandlerDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly UnityWebRequest.GetTimeoutMsecDelegate GetTimeoutMsecDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly UnityWebRequest.SetTimeoutMsecDelegate SetTimeoutMsecDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly UnityWebRequest.GetSuppressErrorsToConsoleDelegate GetSuppressErrorsToConsoleDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly UnityWebRequest.SetSuppressErrorsToConsoleDelegate SetSuppressErrorsToConsoleDelegateField;

		// Token: 0x02000012 RID: 18
		[OriginalName("UnityEngine.UnityWebRequestModule.dll", "", "UnityWebRequestMethod")]
		public enum UnityWebRequestMethod
		{
			// Token: 0x040000A6 RID: 166
			Get,
			// Token: 0x040000A7 RID: 167
			Post,
			// Token: 0x040000A8 RID: 168
			Put,
			// Token: 0x040000A9 RID: 169
			Head,
			// Token: 0x040000AA RID: 170
			Custom
		}

		// Token: 0x02000013 RID: 19
		[OriginalName("UnityEngine.UnityWebRequestModule.dll", "", "UnityWebRequestError")]
		public enum UnityWebRequestError
		{
			// Token: 0x040000AC RID: 172
			OK,
			// Token: 0x040000AD RID: 173
			Unknown,
			// Token: 0x040000AE RID: 174
			SDKError,
			// Token: 0x040000AF RID: 175
			UnsupportedProtocol,
			// Token: 0x040000B0 RID: 176
			MalformattedUrl,
			// Token: 0x040000B1 RID: 177
			CannotResolveProxy,
			// Token: 0x040000B2 RID: 178
			CannotResolveHost,
			// Token: 0x040000B3 RID: 179
			CannotConnectToHost,
			// Token: 0x040000B4 RID: 180
			AccessDenied,
			// Token: 0x040000B5 RID: 181
			GenericHttpError,
			// Token: 0x040000B6 RID: 182
			WriteError,
			// Token: 0x040000B7 RID: 183
			ReadError,
			// Token: 0x040000B8 RID: 184
			OutOfMemory,
			// Token: 0x040000B9 RID: 185
			Timeout,
			// Token: 0x040000BA RID: 186
			HTTPPostError,
			// Token: 0x040000BB RID: 187
			SSLCannotConnect,
			// Token: 0x040000BC RID: 188
			Aborted,
			// Token: 0x040000BD RID: 189
			TooManyRedirects,
			// Token: 0x040000BE RID: 190
			ReceivedNoData,
			// Token: 0x040000BF RID: 191
			SSLNotSupported,
			// Token: 0x040000C0 RID: 192
			FailedToSendData,
			// Token: 0x040000C1 RID: 193
			FailedToReceiveData,
			// Token: 0x040000C2 RID: 194
			SSLCertificateError,
			// Token: 0x040000C3 RID: 195
			SSLCipherNotAvailable,
			// Token: 0x040000C4 RID: 196
			SSLCACertError,
			// Token: 0x040000C5 RID: 197
			UnrecognizedContentEncoding,
			// Token: 0x040000C6 RID: 198
			LoginFailed,
			// Token: 0x040000C7 RID: 199
			SSLShutdownFailed,
			// Token: 0x040000C8 RID: 200
			NoInternetConnection
		}

		// Token: 0x02000014 RID: 20
		[OriginalName("UnityEngine.UnityWebRequestModule.dll", "", "Result")]
		public enum Result
		{
			// Token: 0x040000CA RID: 202
			InProgress,
			// Token: 0x040000CB RID: 203
			Success,
			// Token: 0x040000CC RID: 204
			ConnectionError,
			// Token: 0x040000CD RID: 205
			ProtocolError,
			// Token: 0x040000CE RID: 206
			DataProcessingError
		}

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000144 RID: 324
		private delegate void ClearCookieCacheDelegate(IntPtr domain, IntPtr path);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000146 RID: 326
		private delegate UnityWebRequest.UnityWebRequestMethod GetMethodDelegate(IntPtr @this);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000148 RID: 328
		private delegate IntPtr GetCustomMethodDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600014A RID: 330
		private delegate bool get_use100ContinueDelegate(IntPtr @this);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600014C RID: 332
		private delegate void set_use100ContinueDelegate(IntPtr @this, bool value);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600014E RID: 334
		private delegate IntPtr GetUrlDelegate(IntPtr @this);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000150 RID: 336
		private delegate float GetUploadProgressDelegate(IntPtr @this);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000152 RID: 338
		private delegate bool IsExecutingDelegate(IntPtr @this);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000154 RID: 340
		private delegate float GetDownloadProgressDelegate(IntPtr @this);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000156 RID: 342
		private delegate ulong get_uploadedBytesDelegate(IntPtr @this);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x06000158 RID: 344
		private delegate ulong get_downloadedBytesDelegate(IntPtr @this);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x0600015A RID: 346
		private delegate int GetRedirectLimitDelegate(IntPtr @this);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600015C RID: 348
		private delegate void SetRedirectLimitFromScriptingDelegate(IntPtr @this, int limit);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x0600015E RID: 350
		private delegate bool GetChunkedDelegate(IntPtr @this);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000160 RID: 352
		private delegate UnityWebRequest.UnityWebRequestError SetChunkedDelegate(IntPtr @this, bool chunked);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000162 RID: 354
		private delegate IntPtr GetRequestHeaderDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000164 RID: 356
		private delegate IntPtr GetResponseHeaderDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000166 RID: 358
		private delegate IntPtr GetResponseHeaderKeysDelegate(IntPtr @this);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000168 RID: 360
		private delegate UnityWebRequest.UnityWebRequestError SetCertificateHandlerDelegate(IntPtr @this, IntPtr ch);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x0600016A RID: 362
		private delegate int GetTimeoutMsecDelegate(IntPtr @this);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600016C RID: 364
		private delegate UnityWebRequest.UnityWebRequestError SetTimeoutMsecDelegate(IntPtr @this, int timeout);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x0600016E RID: 366
		private delegate bool GetSuppressErrorsToConsoleDelegate(IntPtr @this);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000170 RID: 368
		private delegate UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsoleDelegate(IntPtr @this, bool suppress);
	}
}
