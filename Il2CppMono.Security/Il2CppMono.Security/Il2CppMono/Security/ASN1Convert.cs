using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security
{
	// Token: 0x02000004 RID: 4
	public static class ASN1Convert : Object
	{
		// Token: 0x0600001D RID: 29 RVA: 0x000040D8 File Offset: 0x000022D8
		// Note: this type is marked as 'beforefieldinit'.
		static ASN1Convert()
		{
			Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security", "ASN1Convert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr);
			ASN1Convert.NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663315);
			ASN1Convert.NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663316);
			ASN1Convert.NativeMethodInfoPtr_FromUnsignedBigInteger_Public_Static_ASN1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663317);
			ASN1Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663318);
			ASN1Convert.NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663319);
			ASN1Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663320);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004180 File Offset: 0x00002380
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126865, RefRangeEnd = 126868, XrefRangeStart = 126851, XrefRangeEnd = 126865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ASN1 FromInt32(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000041C0 File Offset: 0x000023C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126873, RefRangeEnd = 126874, XrefRangeStart = 126868, XrefRangeEnd = 126873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ASN1 FromOid(string oid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004204 File Offset: 0x00002404
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 126881, RefRangeEnd = 126891, XrefRangeStart = 126874, XrefRangeEnd = 126881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ASN1 FromUnsignedBigInteger(Il2CppStructArray<byte> big)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(big);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_FromUnsignedBigInteger_Public_Static_ASN1_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004248 File Offset: 0x00002448
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126894, RefRangeEnd = 126897, XrefRangeStart = 126891, XrefRangeEnd = 126894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(ASN1 asn1)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000428C File Offset: 0x0000248C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 126939, RefRangeEnd = 126953, XrefRangeStart = 126897, XrefRangeEnd = 126939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToOid(ASN1 asn1)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000042C8 File Offset: 0x000024C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126973, RefRangeEnd = 126975, XrefRangeStart = 126953, XrefRangeEnd = 126973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(ASN1 time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(time);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020F4 File Offset: 0x000002F4
		public ASN1Convert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_FromUnsignedBigInteger_Public_Static_ASN1_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0;
	}
}
