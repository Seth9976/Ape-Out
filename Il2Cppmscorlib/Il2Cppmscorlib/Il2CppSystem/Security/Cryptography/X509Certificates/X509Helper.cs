using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000325 RID: 805
	public static class X509Helper : Object
	{
		// Token: 0x06003523 RID: 13603 RVA: 0x001061BC File Offset: 0x001043BC
		// Note: this type is marked as 'beforefieldinit'.
		static X509Helper()
		{
			Il2CppClassPointerStore<X509Helper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509Helper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Helper>.NativeClassPtr);
			X509Helper.NativeFieldInfoPtr_nativeHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, "nativeHelper");
			X509Helper.NativeMethodInfoPtr_InstallNativeHelper_Internal_Static_Void_INativeCertificateHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671588);
			X509Helper.NativeMethodInfoPtr_Import_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671589);
			X509Helper.NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671590);
			X509Helper.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671591);
			X509Helper.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671592);
			X509Helper.NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671593);
			X509Helper.NativeMethodInfoPtr_ImportPkcs12_Internal_Static_X509Certificate_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671594);
			X509Helper.NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671595);
			X509Helper.NativeMethodInfoPtr_ConvertData_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671596);
			X509Helper.NativeMethodInfoPtr_ImportCore_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671597);
			X509Helper.NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671598);
			X509Helper.NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671599);
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x001062F0 File Offset: 0x001044F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213110, XrefRangeEnd = 213112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallNativeHelper(INativeCertificateHelper helper)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(helper);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_InstallNativeHelper_Internal_Static_Void_INativeCertificateHelper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x00106328 File Offset: 0x00104528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213112, XrefRangeEnd = 213113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImpl Import(Il2CppStructArray<byte> rawData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_Import_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x0010636C File Offset: 0x0010456C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213113, XrefRangeEnd = 213121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x001063B0 File Offset: 0x001045B0
		[CallerCount(0)]
		public unsafe static bool IsValid(X509CertificateImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x001063F4 File Offset: 0x001045F4
		[CallerCount(0)]
		public unsafe static void ThrowIfContextInvalid(X509CertificateImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x0010642C File Offset: 0x0010462C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 213127, RefRangeEnd = 213141, XrefRangeStart = 213121, XrefRangeEnd = 213127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetInvalidContextException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00106460 File Offset: 0x00104660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213168, RefRangeEnd = 213170, XrefRangeStart = 213141, XrefRangeEnd = 213168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Certificate ImportPkcs12(Il2CppStructArray<byte> rawData, string password)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_ImportPkcs12_Internal_Static_X509Certificate_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x001064B8 File Offset: 0x001046B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213195, RefRangeEnd = 213196, XrefRangeStart = 213170, XrefRangeEnd = 213195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PEM(string type, Il2CppStructArray<byte> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x00106510 File Offset: 0x00104710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213196, XrefRangeEnd = 213199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ConvertData(Il2CppStructArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_ConvertData_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00106554 File Offset: 0x00104754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213208, RefRangeEnd = 213209, XrefRangeStart = 213199, XrefRangeEnd = 213208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImpl ImportCore(Il2CppStructArray<byte> rawData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_ImportCore_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x00106598 File Offset: 0x00104798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213217, RefRangeEnd = 213218, XrefRangeStart = 213209, XrefRangeEnd = 213217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImpl Import(Il2CppStructArray<byte> rawData, string password, X509KeyStorageFlags keyStorageFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x001065FC File Offset: 0x001047FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 213220, RefRangeEnd = 213225, XrefRangeStart = 213218, XrefRangeEnd = 213220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToHexString(Il2CppStructArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x00012C65 File Offset: 0x00010E65
		public X509Helper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06003531 RID: 13617 RVA: 0x00106638 File Offset: 0x00104838
		// (set) Token: 0x06003532 RID: 13618 RVA: 0x00012C6E File Offset: 0x00010E6E
		public unsafe static INativeCertificateHelper nativeHelper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Helper.NativeFieldInfoPtr_nativeHelper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<INativeCertificateHelper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Helper.NativeFieldInfoPtr_nativeHelper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D13 RID: 11539
		private static readonly IntPtr NativeFieldInfoPtr_nativeHelper;

		// Token: 0x04002D14 RID: 11540
		private static readonly IntPtr NativeMethodInfoPtr_InstallNativeHelper_Internal_Static_Void_INativeCertificateHelper_0;

		// Token: 0x04002D15 RID: 11541
		private static readonly IntPtr NativeMethodInfoPtr_Import_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002D16 RID: 11542
		private static readonly IntPtr NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0;

		// Token: 0x04002D17 RID: 11543
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0;

		// Token: 0x04002D18 RID: 11544
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0;

		// Token: 0x04002D19 RID: 11545
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0;

		// Token: 0x04002D1A RID: 11546
		private static readonly IntPtr NativeMethodInfoPtr_ImportPkcs12_Internal_Static_X509Certificate_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04002D1B RID: 11547
		private static readonly IntPtr NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002D1C RID: 11548
		private static readonly IntPtr NativeMethodInfoPtr_ConvertData_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002D1D RID: 11549
		private static readonly IntPtr NativeMethodInfoPtr_ImportCore_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002D1E RID: 11550
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0;

		// Token: 0x04002D1F RID: 11551
		private static readonly IntPtr NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0;
	}
}
