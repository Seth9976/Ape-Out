using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x02000008 RID: 8
	public static class UnityTlsConversions : Object
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000119CC File Offset: 0x0000FBCC
		// Note: this type is marked as 'beforefieldinit'.
		static UnityTlsConversions()
		{
			Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTlsConversions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr);
			UnityTlsConversions.NativeMethodInfoPtr_GetMinProtocol_Public_Static_unitytls_protocol_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663473);
			UnityTlsConversions.NativeMethodInfoPtr_GetMaxProtocol_Public_Static_unitytls_protocol_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663474);
			UnityTlsConversions.NativeMethodInfoPtr_ConvertProtocolVersion_Public_Static_TlsProtocols_unitytls_protocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663475);
			UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToAlertDescription_Public_Static_AlertDescription_unitytls_x509verify_result_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663476);
			UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToPolicyErrror_Public_Static_MonoSslPolicyErrors_unitytls_x509verify_result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663477);
			UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToChainStatus_Public_Static_X509ChainStatusFlags_unitytls_x509verify_result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663478);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00011A74 File Offset: 0x0000FC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364495, XrefRangeEnd = 364511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref protocols;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_GetMinProtocol_Public_Static_unitytls_protocol_SslProtocols_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00011AB4 File Offset: 0x0000FCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364511, XrefRangeEnd = 364527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref protocols;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_GetMaxProtocol_Public_Static_unitytls_protocol_SslProtocols_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00011AF4 File Offset: 0x0000FCF4
		[CallerCount(0)]
		public unsafe static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref protocol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_ConvertProtocolVersion_Public_Static_TlsProtocols_unitytls_protocol_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00011B34 File Offset: 0x0000FD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364527, XrefRangeEnd = 364598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref verifyResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultAlert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToAlertDescription_Public_Static_AlertDescription_unitytls_x509verify_result_AlertDescription_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00011B80 File Offset: 0x0000FD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364598, XrefRangeEnd = 364604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoSslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref verifyResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToPolicyErrror_Public_Static_MonoSslPolicyErrors_unitytls_x509verify_result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00011BC0 File Offset: 0x0000FDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364604, XrefRangeEnd = 364625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref verifyResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToChainStatus_Public_Static_X509ChainStatusFlags_unitytls_x509verify_result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022E1 File Offset: 0x000004E1
		public UnityTlsConversions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetMinProtocol_Public_Static_unitytls_protocol_SslProtocols_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxProtocol_Public_Static_unitytls_protocol_SslProtocols_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_ConvertProtocolVersion_Public_Static_TlsProtocols_unitytls_protocol_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_VerifyResultToAlertDescription_Public_Static_AlertDescription_unitytls_x509verify_result_AlertDescription_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_VerifyResultToPolicyErrror_Public_Static_MonoSslPolicyErrors_unitytls_x509verify_result_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_VerifyResultToChainStatus_Public_Static_X509ChainStatusFlags_unitytls_x509verify_result_0;
	}
}
