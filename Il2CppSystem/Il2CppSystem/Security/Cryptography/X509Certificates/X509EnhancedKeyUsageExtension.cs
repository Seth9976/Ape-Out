using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C2 RID: 194
	public sealed class X509EnhancedKeyUsageExtension : X509Extension
	{
		// Token: 0x06000A90 RID: 2704 RVA: 0x00037848 File Offset: 0x00035A48
		// Note: this type is marked as 'beforefieldinit'.
		static X509EnhancedKeyUsageExtension()
		{
			Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509EnhancedKeyUsageExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr);
			X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__enhKeyUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, "_enhKeyUsage");
			X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, "_status");
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100664768);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100664769);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100664770);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100664771);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000378F0 File Offset: 0x00035AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374508, XrefRangeEnd = 374517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedEnhancedKeyUsages);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0003794C File Offset: 0x00035B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374517, XrefRangeEnd = 374532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00037990 File Offset: 0x00035B90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 374549, RefRangeEnd = 374552, XrefRangeStart = 374532, XrefRangeEnd = 374549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000379E0 File Offset: 0x00035BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374552, XrefRangeEnd = 374565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000064B7 File Offset: 0x000046B7
		public X509EnhancedKeyUsageExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00037A24 File Offset: 0x00035C24
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x000064C0 File Offset: 0x000046C0
		public unsafe OidCollection _enhKeyUsage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__enhKeyUsage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__enhKeyUsage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00037A54 File Offset: 0x00035C54
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x000064DF File Offset: 0x000046DF
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeFieldInfoPtr__enhKeyUsage;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
