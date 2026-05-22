using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000176 RID: 374
	[Serializable]
	[StructLayout(2)]
	public struct UGCQueryHandle_t
	{
		// Token: 0x06001044 RID: 4164 RVA: 0x0004FF2C File Offset: 0x0004E12C
		// Note: this type is marked as 'beforefieldinit'.
		static UGCQueryHandle_t()
		{
			Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UGCQueryHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr);
			UGCQueryHandle_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, "Invalid");
			UGCQueryHandle_t.NativeFieldInfoPtr_m_UGCQueryHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, "m_UGCQueryHandle");
			UGCQueryHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100665657);
			UGCQueryHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100665658);
			UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100665659);
			UGCQueryHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100665660);
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100665661);
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100665662);
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCQueryHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100665663);
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100665664);
			UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100665665);
			UGCQueryHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100665666);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0005004C File Offset: 0x0004E24C
		[CallerCount(0)]
		public unsafe UGCQueryHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00050080 File Offset: 0x0004E280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x000500AC File Offset: 0x0004E2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13489, XrefRangeEnd = 13493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x000500F0 File Offset: 0x0004E2F0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00050120 File Offset: 0x0004E320
		[CallerCount(0)]
		public unsafe static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0005016C File Offset: 0x0004E36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13493, XrefRangeEnd = 13496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x000501B8 File Offset: 0x0004E3B8
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator UGCQueryHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCQueryHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x000501F8 File Offset: 0x0004E3F8
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(UGCQueryHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00050238 File Offset: 0x0004E438
		[CallerCount(0)]
		public unsafe bool Equals(UGCQueryHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCQueryHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00050278 File Offset: 0x0004E478
		[CallerCount(0)]
		public unsafe int CompareTo(UGCQueryHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCQueryHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00006B9E File Offset: 0x00004D9E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x000502B8 File Offset: 0x0004E4B8
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x00006BB0 File Offset: 0x00004DB0
		public unsafe static UGCQueryHandle_t Invalid
		{
			get
			{
				UGCQueryHandle_t ugcqueryHandle_t;
				IL2CPP.il2cpp_field_static_get_value(UGCQueryHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&ugcqueryHandle_t));
				return ugcqueryHandle_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UGCQueryHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeFieldInfoPtr_m_UGCQueryHandle;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UGCQueryHandle_t_UInt64_0;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCQueryHandle_t_0;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCQueryHandle_t_0;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCQueryHandle_t_0;

		// Token: 0x0400128F RID: 4751
		[FieldOffset(0)]
		public ulong m_UGCQueryHandle;
	}
}
