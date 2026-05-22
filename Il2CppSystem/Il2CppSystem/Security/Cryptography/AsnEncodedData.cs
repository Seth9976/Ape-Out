using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020000A8 RID: 168
	public class AsnEncodedData : Object
	{
		// Token: 0x06000966 RID: 2406 RVA: 0x0003346C File Offset: 0x0003166C
		// Note: this type is marked as 'beforefieldinit'.
		static AsnEncodedData()
		{
			Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "AsnEncodedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr);
			AsnEncodedData.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, "_oid");
			AsnEncodedData.NativeFieldInfoPtr__raw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, "_raw");
			AsnEncodedData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664616);
			AsnEncodedData.NativeMethodInfoPtr__ctor_Public_Void_Oid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664617);
			AsnEncodedData.NativeMethodInfoPtr_set_Oid_Public_set_Void_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664618);
			AsnEncodedData.NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664619);
			AsnEncodedData.NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664620);
			AsnEncodedData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_New_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664621);
			AsnEncodedData.NativeMethodInfoPtr_ToString_Internal_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664622);
			AsnEncodedData.NativeMethodInfoPtr_Default_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664623);
			AsnEncodedData.NativeMethodInfoPtr_BasicConstraintsExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664624);
			AsnEncodedData.NativeMethodInfoPtr_EnhancedKeyUsageExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664625);
			AsnEncodedData.NativeMethodInfoPtr_KeyUsageExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664626);
			AsnEncodedData.NativeMethodInfoPtr_SubjectKeyIdentifierExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664627);
			AsnEncodedData.NativeMethodInfoPtr_SubjectAltName_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664628);
			AsnEncodedData.NativeMethodInfoPtr_NetscapeCertType_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664629);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000335DC File Offset: 0x000317DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnEncodedData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00033618 File Offset: 0x00031818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373327, XrefRangeEnd = 373329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnEncodedData(Oid oid, Il2CppStructArray<byte> rawData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr__ctor_Public_Void_Oid_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002B2 RID: 690
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00033678 File Offset: 0x00031878
		public unsafe Oid Oid
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 373333, RefRangeEnd = 373338, XrefRangeStart = 373329, XrefRangeEnd = 373333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_set_Oid_Public_set_Void_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x000336BC File Offset: 0x000318BC
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x000336FC File Offset: 0x000318FC
		public unsafe Il2CppStructArray<byte> RawData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 373342, RefRangeEnd = 373356, XrefRangeStart = 373338, XrefRangeEnd = 373342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00033740 File Offset: 0x00031940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373356, XrefRangeEnd = 373369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsnEncodedData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_New_Void_AsnEncodedData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00033790 File Offset: 0x00031990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373369, XrefRangeEnd = 373389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsnEncodedData.NativeMethodInfoPtr_ToString_Internal_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000337E0 File Offset: 0x000319E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373408, RefRangeEnd = 373409, XrefRangeStart = 373389, XrefRangeEnd = 373408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Default(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_Default_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00033824 File Offset: 0x00031A24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373423, RefRangeEnd = 373424, XrefRangeStart = 373409, XrefRangeEnd = 373423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BasicConstraintsExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_BasicConstraintsExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00033868 File Offset: 0x00031A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373438, RefRangeEnd = 373439, XrefRangeStart = 373424, XrefRangeEnd = 373438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EnhancedKeyUsageExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_EnhancedKeyUsageExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000338AC File Offset: 0x00031AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373453, RefRangeEnd = 373454, XrefRangeStart = 373439, XrefRangeEnd = 373453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string KeyUsageExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_KeyUsageExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000338F0 File Offset: 0x00031AF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373468, RefRangeEnd = 373469, XrefRangeStart = 373454, XrefRangeEnd = 373468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SubjectKeyIdentifierExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_SubjectKeyIdentifierExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00033934 File Offset: 0x00031B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373513, RefRangeEnd = 373514, XrefRangeStart = 373469, XrefRangeEnd = 373513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SubjectAltName(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_SubjectAltName_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00033978 File Offset: 0x00031B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373569, RefRangeEnd = 373570, XrefRangeStart = 373514, XrefRangeEnd = 373569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NetscapeCertType(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_NetscapeCertType_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00005D29 File Offset: 0x00003F29
		public AsnEncodedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x000339BC File Offset: 0x00031BBC
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x00005D32 File Offset: 0x00003F32
		public unsafe Oid _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__oid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__oid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x000339EC File Offset: 0x00031BEC
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00005D51 File Offset: 0x00003F51
		public unsafe Il2CppStructArray<byte> _raw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__raw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__raw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr__raw;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Oid_Il2CppStructArray_1_Byte_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_set_Oid_Public_set_Void_Oid_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_New_Void_AsnEncodedData_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_New_String_Boolean_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_Default_Internal_String_Boolean_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_BasicConstraintsExtension_Internal_String_Boolean_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_EnhancedKeyUsageExtension_Internal_String_Boolean_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_KeyUsageExtension_Internal_String_Boolean_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_SubjectKeyIdentifierExtension_Internal_String_Boolean_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_SubjectAltName_Internal_String_Boolean_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_NetscapeCertType_Internal_String_Boolean_0;
	}
}
