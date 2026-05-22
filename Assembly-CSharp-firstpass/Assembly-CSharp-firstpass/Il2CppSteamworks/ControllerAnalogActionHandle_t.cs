using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200015C RID: 348
	[Serializable]
	[StructLayout(2)]
	public struct ControllerAnalogActionHandle_t
	{
		// Token: 0x06000EE8 RID: 3816 RVA: 0x0004A208 File Offset: 0x00048408
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerAnalogActionHandle_t()
		{
			Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ControllerAnalogActionHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr);
			ControllerAnalogActionHandle_t.NativeFieldInfoPtr_m_ControllerAnalogActionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, "m_ControllerAnalogActionHandle");
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100665379);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100665380);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100665381);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100665382);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100665383);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100665384);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerAnalogActionHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100665385);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100665386);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100665387);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100665388);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0004A314 File Offset: 0x00048514
		[CallerCount(0)]
		public unsafe ControllerAnalogActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0004A348 File Offset: 0x00048548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0004A374 File Offset: 0x00048574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13339, XrefRangeEnd = 13341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0004A3B8 File Offset: 0x000485B8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0004A3E8 File Offset: 0x000485E8
		[CallerCount(0)]
		public unsafe static bool operator ==(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0004A434 File Offset: 0x00048634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12921, RefRangeEnd = 12922, XrefRangeStart = 12921, XrefRangeEnd = 12922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0004A480 File Offset: 0x00048680
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ControllerAnalogActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerAnalogActionHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0004A4C0 File Offset: 0x000486C0
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(ControllerAnalogActionHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0004A500 File Offset: 0x00048700
		[CallerCount(0)]
		public unsafe bool Equals(ControllerAnalogActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerAnalogActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0004A540 File Offset: 0x00048740
		[CallerCount(0)]
		public unsafe int CompareTo(ControllerAnalogActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerAnalogActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000068C0 File Offset: 0x00004AC0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeFieldInfoPtr_m_ControllerAnalogActionHandle;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerAnalogActionHandle_t_UInt64_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerAnalogActionHandle_t_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerAnalogActionHandle_t_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerAnalogActionHandle_t_0;

		// Token: 0x04001145 RID: 4421
		[FieldOffset(0)]
		public ulong m_ControllerAnalogActionHandle;
	}
}
