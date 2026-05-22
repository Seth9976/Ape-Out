using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000143 RID: 323
	public static class SteamHTTP : Object
	{
		// Token: 0x06000C45 RID: 3141 RVA: 0x0003C658 File Offset: 0x0003A858
		// Note: this type is marked as 'beforefieldinit'.
		static SteamHTTP()
		{
			Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamHTTP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr);
			SteamHTTP.NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664806);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664807);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664808);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664809);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664810);
			SteamHTTP.NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664811);
			SteamHTTP.NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664812);
			SteamHTTP.NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664813);
			SteamHTTP.NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664814);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664815);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664816);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664817);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664818);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664819);
			SteamHTTP.NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664820);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664821);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664822);
			SteamHTTP.NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664823);
			SteamHTTP.NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664824);
			SteamHTTP.NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664825);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664826);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664827);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664828);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664829);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100664830);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0003C87C File Offset: 0x0003AA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9285, XrefRangeEnd = 9300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0003C8CC File Offset: 0x0003AACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9300, XrefRangeEnd = 9304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0003C918 File Offset: 0x0003AB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9304, XrefRangeEnd = 9308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0003C964 File Offset: 0x0003AB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9308, XrefRangeEnd = 9327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0003C9C8 File Offset: 0x0003ABC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9327, XrefRangeEnd = 9346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0003CA2C File Offset: 0x0003AC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9346, XrefRangeEnd = 9350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0003CA78 File Offset: 0x0003AC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9350, XrefRangeEnd = 9354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0003CAC4 File Offset: 0x0003ACC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9354, XrefRangeEnd = 9358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0003CB04 File Offset: 0x0003AD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9358, XrefRangeEnd = 9362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0003CB44 File Offset: 0x0003AD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9362, XrefRangeEnd = 9374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0003CBA4 File Offset: 0x0003ADA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9374, XrefRangeEnd = 9386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0003CC14 File Offset: 0x0003AE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9386, XrefRangeEnd = 9390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0003CC60 File Offset: 0x0003AE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9390, XrefRangeEnd = 9394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0003CCC0 File Offset: 0x0003AEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9394, XrefRangeEnd = 9398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0003CD2C File Offset: 0x0003AF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9398, XrefRangeEnd = 9402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0003CD6C File Offset: 0x0003AF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9402, XrefRangeEnd = 9406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0003CDB8 File Offset: 0x0003AFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9406, XrefRangeEnd = 9418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0003CE28 File Offset: 0x0003B028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9418, XrefRangeEnd = 9425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bAllowResponsesToModify;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0003CE68 File Offset: 0x0003B068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9425, XrefRangeEnd = 9429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hCookieContainer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0003CEA8 File Offset: 0x0003B0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9429, XrefRangeEnd = 9455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0003CF1C File Offset: 0x0003B11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9455, XrefRangeEnd = 9459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0003CF68 File Offset: 0x0003B168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9459, XrefRangeEnd = 9471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0003CFB8 File Offset: 0x0003B1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9471, XrefRangeEnd = 9475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0003D004 File Offset: 0x0003B204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9475, XrefRangeEnd = 9479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0003D050 File Offset: 0x0003B250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9479, XrefRangeEnd = 9483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00006504 File Offset: 0x00004704
		public SteamHTTP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0;
	}
}
