using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000133 RID: 307
	public sealed class IPv6AddressFormatter : ValueType
	{
		// Token: 0x0600126B RID: 4715 RVA: 0x000558D0 File Offset: 0x00053AD0
		// Note: this type is marked as 'beforefieldinit'.
		static IPv6AddressFormatter()
		{
			Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPv6AddressFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr);
			IPv6AddressFormatter.NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, "address");
			IPv6AddressFormatter.NativeFieldInfoPtr_scopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, "scopeId");
			IPv6AddressFormatter.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt16_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665896);
			IPv6AddressFormatter.NativeMethodInfoPtr_SwapUShort_Private_Static_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665897);
			IPv6AddressFormatter.NativeMethodInfoPtr_AsIPv4Int_Private_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665898);
			IPv6AddressFormatter.NativeMethodInfoPtr_IsIPv4Compatible_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665899);
			IPv6AddressFormatter.NativeMethodInfoPtr_IsIPv4Mapped_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665900);
			IPv6AddressFormatter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665901);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x000559A0 File Offset: 0x00053BA0
		[CallerCount(0)]
		public unsafe IPv6AddressFormatter(Il2CppStructArray<ushort> addr, long scopeId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(addr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt16_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00055A00 File Offset: 0x00053C00
		[CallerCount(0)]
		public unsafe static ushort SwapUShort(ushort number)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr_SwapUShort_Private_Static_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00055A40 File Offset: 0x00053C40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383443, RefRangeEnd = 383444, XrefRangeStart = 383443, XrefRangeEnd = 383443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint AsIPv4Int()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr_AsIPv4Int_Private_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00055A84 File Offset: 0x00053C84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383445, RefRangeEnd = 383446, XrefRangeStart = 383444, XrefRangeEnd = 383445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIPv4Compatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr_IsIPv4Compatible_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00055AC8 File Offset: 0x00053CC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 383446, RefRangeEnd = 383448, XrefRangeStart = 383446, XrefRangeEnd = 383446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIPv4Mapped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr_IsIPv4Mapped_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00055B0C File Offset: 0x00053D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383499, RefRangeEnd = 383500, XrefRangeStart = 383448, XrefRangeEnd = 383499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00009719 File Offset: 0x00007919
		public IPv6AddressFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00009722 File Offset: 0x00007922
		public IPv6AddressFormatter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr))
		{
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x00055B48 File Offset: 0x00053D48
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x00009734 File Offset: 0x00007934
		public unsafe Il2CppStructArray<ushort> address
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPv6AddressFormatter.NativeFieldInfoPtr_address);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPv6AddressFormatter.NativeFieldInfoPtr_address), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00055B78 File Offset: 0x00053D78
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x00009753 File Offset: 0x00007953
		public unsafe long scopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPv6AddressFormatter.NativeFieldInfoPtr_scopeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPv6AddressFormatter.NativeFieldInfoPtr_scopeId)) = value;
			}
		}

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeFieldInfoPtr_address;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr_scopeId;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt16_Int64_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_SwapUShort_Private_Static_UInt16_UInt16_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_AsIPv4Int_Private_UInt32_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_IsIPv4Compatible_Private_Boolean_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr_IsIPv4Mapped_Private_Boolean_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
