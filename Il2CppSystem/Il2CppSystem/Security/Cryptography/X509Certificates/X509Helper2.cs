using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C5 RID: 197
	public static class X509Helper2 : Object
	{
		// Token: 0x06000AA7 RID: 2727 RVA: 0x00037CC4 File Offset: 0x00035EC4
		// Note: this type is marked as 'beforefieldinit'.
		static X509Helper2()
		{
			Il2CppClassPointerStore<X509Helper2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Helper2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr);
			X509Helper2.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664778);
			X509Helper2.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664779);
			X509Helper2.NativeMethodInfoPtr_Import_Internal_Static_X509Certificate2Impl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664780);
			X509Helper2.NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664781);
			X509Helper2.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664782);
			X509Helper2.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664783);
			X509Helper2.NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664784);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00037D80 File Offset: 0x00035F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374589, XrefRangeEnd = 374594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00037DA8 File Offset: 0x00035FA8
		[CallerCount(0)]
		public unsafe static void ThrowIfContextInvalid(X509CertificateImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00037DE0 File Offset: 0x00035FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374594, XrefRangeEnd = 374597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Certificate2Impl Import(Il2CppStructArray<byte> rawData, string password, X509KeyStorageFlags keyStorageFlags, bool disableProvider = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disableProvider;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_Import_Internal_Static_X509Certificate2Impl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00037E54 File Offset: 0x00036054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374597, XrefRangeEnd = 374608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509ChainImpl CreateChainImpl(bool useMachineContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMachineContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00037E94 File Offset: 0x00036094
		[CallerCount(0)]
		public unsafe static bool IsValid(X509ChainImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00037ED8 File Offset: 0x000360D8
		[CallerCount(0)]
		public unsafe static void ThrowIfContextInvalid(X509ChainImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00037F10 File Offset: 0x00036110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 374614, RefRangeEnd = 374616, XrefRangeStart = 374608, XrefRangeEnd = 374614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetInvalidChainContextException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00006572 File Offset: 0x00004772
		public X509Helper2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_Import_Internal_Static_X509Certificate2Impl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_Boolean_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0;

		// Token: 0x020001BE RID: 446
		public class MyNativeHelper : Object
		{
			// Token: 0x06001927 RID: 6439 RVA: 0x0000CF9A File Offset: 0x0000B19A
			// Note: this type is marked as 'beforefieldinit'.
			static MyNativeHelper()
			{
				Il2CppClassPointerStore<X509Helper2.MyNativeHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, "MyNativeHelper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Helper2.MyNativeHelper>.NativeClassPtr);
				X509Helper2.MyNativeHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2.MyNativeHelper>.NativeClassPtr, 100664785);
			}

			// Token: 0x06001928 RID: 6440 RVA: 0x0006C5D0 File Offset: 0x0006A7D0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MyNativeHelper()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Helper2.MyNativeHelper>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.MyNativeHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001929 RID: 6441 RVA: 0x0000CFCE File Offset: 0x0000B1CE
			public MyNativeHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040013F4 RID: 5108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
