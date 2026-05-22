using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000177 RID: 375
	[Serializable]
	[StructLayout(2)]
	public struct UGCUpdateHandle_t
	{
		// Token: 0x06001052 RID: 4178 RVA: 0x000502D4 File Offset: 0x0004E4D4
		// Note: this type is marked as 'beforefieldinit'.
		static UGCUpdateHandle_t()
		{
			Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UGCUpdateHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr);
			UGCUpdateHandle_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, "Invalid");
			UGCUpdateHandle_t.NativeFieldInfoPtr_m_UGCUpdateHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, "m_UGCUpdateHandle");
			UGCUpdateHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100665668);
			UGCUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100665669);
			UGCUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100665670);
			UGCUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100665671);
			UGCUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100665672);
			UGCUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100665673);
			UGCUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCUpdateHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100665674);
			UGCUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100665675);
			UGCUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100665676);
			UGCUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100665677);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x000503F4 File Offset: 0x0004E5F4
		[CallerCount(0)]
		public unsafe UGCUpdateHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00050428 File Offset: 0x0004E628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00050454 File Offset: 0x0004E654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13496, XrefRangeEnd = 13500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00050498 File Offset: 0x0004E698
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x000504C8 File Offset: 0x0004E6C8
		[CallerCount(0)]
		public unsafe static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00050514 File Offset: 0x0004E714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13500, XrefRangeEnd = 13503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00050560 File Offset: 0x0004E760
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator UGCUpdateHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCUpdateHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x000505A0 File Offset: 0x0004E7A0
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(UGCUpdateHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x000505E0 File Offset: 0x0004E7E0
		[CallerCount(0)]
		public unsafe bool Equals(UGCUpdateHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00050620 File Offset: 0x0004E820
		[CallerCount(0)]
		public unsafe int CompareTo(UGCUpdateHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00006BBE File Offset: 0x00004DBE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x00050660 File Offset: 0x0004E860
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x00006BD0 File Offset: 0x00004DD0
		public unsafe static UGCUpdateHandle_t Invalid
		{
			get
			{
				UGCUpdateHandle_t ugcupdateHandle_t;
				IL2CPP.il2cpp_field_static_get_value(UGCUpdateHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&ugcupdateHandle_t));
				return ugcupdateHandle_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UGCUpdateHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeFieldInfoPtr_m_UGCUpdateHandle;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UGCUpdateHandle_t_UInt64_0;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCUpdateHandle_t_0;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCUpdateHandle_t_0;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCUpdateHandle_t_0;

		// Token: 0x0400129C RID: 4764
		[FieldOffset(0)]
		public ulong m_UGCUpdateHandle;
	}
}
