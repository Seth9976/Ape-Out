using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000172 RID: 370
	[Serializable]
	[StructLayout(2)]
	public struct DepotId_t
	{
		// Token: 0x0600100C RID: 4108 RVA: 0x0004F08C File Offset: 0x0004D28C
		// Note: this type is marked as 'beforefieldinit'.
		static DepotId_t()
		{
			Il2CppClassPointerStore<DepotId_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DepotId_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr);
			DepotId_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, "Invalid");
			DepotId_t.NativeFieldInfoPtr_m_DepotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, "m_DepotId");
			DepotId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100665613);
			DepotId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100665614);
			DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100665615);
			DepotId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100665616);
			DepotId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DepotId_t_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100665617);
			DepotId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DepotId_t_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100665618);
			DepotId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_DepotId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100665619);
			DepotId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100665620);
			DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100665621);
			DepotId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100665622);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0004F1AC File Offset: 0x0004D3AC
		[CallerCount(0)]
		public unsafe DepotId_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0004F1E0 File Offset: 0x0004D3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0004F20C File Offset: 0x0004D40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13461, XrefRangeEnd = 13465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0004F250 File Offset: 0x0004D450
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0004F280 File Offset: 0x0004D480
		[CallerCount(0)]
		public unsafe static bool operator ==(DepotId_t x, DepotId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DepotId_t_DepotId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0004F2CC File Offset: 0x0004D4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13465, XrefRangeEnd = 13468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(DepotId_t x, DepotId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DepotId_t_DepotId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0004F318 File Offset: 0x0004D518
		[CallerCount(0)]
		public unsafe static explicit operator DepotId_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_DepotId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0004F358 File Offset: 0x0004D558
		[CallerCount(0)]
		public unsafe static explicit operator uint(DepotId_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_DepotId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0004F398 File Offset: 0x0004D598
		[CallerCount(0)]
		public unsafe bool Equals(DepotId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepotId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0004F3D8 File Offset: 0x0004D5D8
		[CallerCount(0)]
		public unsafe int CompareTo(DepotId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DepotId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00006B1E File Offset: 0x00004D1E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0004F418 File Offset: 0x0004D618
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x00006B30 File Offset: 0x00004D30
		public unsafe static DepotId_t Invalid
		{
			get
			{
				DepotId_t depotId_t;
				IL2CPP.il2cpp_field_static_get_value(DepotId_t.NativeFieldInfoPtr_Invalid, (void*)(&depotId_t));
				return depotId_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepotId_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeFieldInfoPtr_m_DepotId;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DepotId_t_DepotId_t_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DepotId_t_DepotId_t_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DepotId_t_UInt32_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_DepotId_t_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepotId_t_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DepotId_t_0;

		// Token: 0x0400125B RID: 4699
		[FieldOffset(0)]
		public uint m_DepotId;
	}
}
