using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x02000004 RID: 4
	public static class CertHelper : Object
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0001092C File Offset: 0x0000EB2C
		// Note: this type is marked as 'beforefieldinit'.
		static CertHelper()
		{
			Il2CppClassPointerStore<CertHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "CertHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CertHelper>.NativeClassPtr);
			CertHelper.NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertHelper>.NativeClassPtr, 100663302);
			CertHelper.NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertHelper>.NativeClassPtr, 100663303);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00010984 File Offset: 0x0000EB84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363842, RefRangeEnd = 363844, XrefRangeStart = 363817, XrefRangeEnd = 363842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = nativeCertificateChain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertHelper.NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000109D4 File Offset: 0x0000EBD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 363857, RefRangeEnd = 363860, XrefRangeStart = 363844, XrefRangeEnd = 363857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = nativeCertificateChain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertHelper.NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020B8 File Offset: 0x000002B8
		public CertHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0;
	}
}
