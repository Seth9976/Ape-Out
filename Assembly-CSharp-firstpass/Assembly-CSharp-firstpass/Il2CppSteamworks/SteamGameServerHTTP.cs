using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200013C RID: 316
	public static class SteamGameServerHTTP : Object
	{
		// Token: 0x06000B4E RID: 2894 RVA: 0x000369C4 File Offset: 0x00034BC4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerHTTP()
		{
			Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerHTTP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr);
			SteamGameServerHTTP.NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664573);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664574);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664575);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664576);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664577);
			SteamGameServerHTTP.NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664578);
			SteamGameServerHTTP.NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664579);
			SteamGameServerHTTP.NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664580);
			SteamGameServerHTTP.NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664581);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664582);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664583);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664584);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664585);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664586);
			SteamGameServerHTTP.NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664587);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664588);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664589);
			SteamGameServerHTTP.NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664590);
			SteamGameServerHTTP.NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664591);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664592);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664593);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664594);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664595);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664596);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100664597);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00036BE8 File Offset: 0x00034DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7567, XrefRangeEnd = 7582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eHTTPRequestMethod;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchAbsoluteURL);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00036C38 File Offset: 0x00034E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7582, XrefRangeEnd = 7586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulContextValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00036C84 File Offset: 0x00034E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7586, XrefRangeEnd = 7590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unTimeoutSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00036CD0 File Offset: 0x00034ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7590, XrefRangeEnd = 7609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00036D34 File Offset: 0x00034F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7609, XrefRangeEnd = 7628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchParamName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchParamValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00036D98 File Offset: 0x00034F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7628, XrefRangeEnd = 7632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pCallHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00036DE4 File Offset: 0x00034FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7632, XrefRangeEnd = 7636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pCallHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00036E30 File Offset: 0x00035030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7636, XrefRangeEnd = 7640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00036E70 File Offset: 0x00035070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7640, XrefRangeEnd = 7644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00036EB0 File Offset: 0x000350B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7644, XrefRangeEnd = 7656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &unResponseHeaderSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00036F10 File Offset: 0x00035110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7656, XrefRangeEnd = 7668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, Il2CppStructArray<byte> pHeaderValueBuffer, uint unBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pHeaderValueBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00036F80 File Offset: 0x00035180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7668, XrefRangeEnd = 7672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &unBodySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00036FCC File Offset: 0x000351CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7672, XrefRangeEnd = 7676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, Il2CppStructArray<byte> pBodyDataBuffer, uint unBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pBodyDataBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0003702C File Offset: 0x0003522C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7676, XrefRangeEnd = 7680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, Il2CppStructArray<byte> pBodyDataBuffer, uint unBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pBodyDataBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00037098 File Offset: 0x00035298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7680, XrefRangeEnd = 7684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000370D8 File Offset: 0x000352D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7684, XrefRangeEnd = 7688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercentOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00037124 File Offset: 0x00035324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7688, XrefRangeEnd = 7700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, Il2CppStructArray<byte> pubBody, uint unBodyLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchContentType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pubBody);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBodyLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00037194 File Offset: 0x00035394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7700, XrefRangeEnd = 7707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bAllowResponsesToModify;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x000371D4 File Offset: 0x000353D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7707, XrefRangeEnd = 7711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hCookieContainer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00037214 File Offset: 0x00035414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7711, XrefRangeEnd = 7737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hCookieContainer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUrl);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchCookie);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00037288 File Offset: 0x00035488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7737, XrefRangeEnd = 7741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hCookieContainer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x000372D4 File Offset: 0x000354D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7741, XrefRangeEnd = 7753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUserAgentInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00037324 File Offset: 0x00035524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7753, XrefRangeEnd = 7757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRequireVerifiedCertificate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00037370 File Offset: 0x00035570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7757, XrefRangeEnd = 7761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unMilliseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x000373BC File Offset: 0x000355BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7761, XrefRangeEnd = 7765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbWasTimedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x000064C5 File Offset: 0x000046C5
		public SteamGameServerHTTP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0;
	}
}
