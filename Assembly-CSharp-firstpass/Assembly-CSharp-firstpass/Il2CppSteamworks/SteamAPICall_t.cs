using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000175 RID: 373
	[Serializable]
	[StructLayout(2)]
	public struct SteamAPICall_t
	{
		// Token: 0x06001036 RID: 4150 RVA: 0x0004FB84 File Offset: 0x0004DD84
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAPICall_t()
		{
			Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAPICall_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr);
			SteamAPICall_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, "Invalid");
			SteamAPICall_t.NativeFieldInfoPtr_m_SteamAPICall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, "m_SteamAPICall");
			SteamAPICall_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100665646);
			SteamAPICall_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100665647);
			SteamAPICall_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100665648);
			SteamAPICall_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100665649);
			SteamAPICall_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100665650);
			SteamAPICall_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100665651);
			SteamAPICall_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamAPICall_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100665652);
			SteamAPICall_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100665653);
			SteamAPICall_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100665654);
			SteamAPICall_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, 100665655);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0004FCA4 File Offset: 0x0004DEA4
		[CallerCount(0)]
		public unsafe SteamAPICall_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0004FCD8 File Offset: 0x0004DED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0004FD04 File Offset: 0x0004DF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13482, XrefRangeEnd = 13486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0004FD48 File Offset: 0x0004DF48
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0004FD78 File Offset: 0x0004DF78
		[CallerCount(0)]
		public unsafe static bool operator ==(SteamAPICall_t x, SteamAPICall_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0004FDC4 File Offset: 0x0004DFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13486, XrefRangeEnd = 13489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamAPICall_t x, SteamAPICall_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0004FE10 File Offset: 0x0004E010
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamAPICall_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamAPICall_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0004FE50 File Offset: 0x0004E050
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(SteamAPICall_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0004FE90 File Offset: 0x0004E090
		[CallerCount(0)]
		public unsafe bool Equals(SteamAPICall_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamAPICall_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0004FED0 File Offset: 0x0004E0D0
		[CallerCount(0)]
		public unsafe int CompareTo(SteamAPICall_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICall_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamAPICall_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00006B7E File Offset: 0x00004D7E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAPICall_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0004FF10 File Offset: 0x0004E110
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00006B90 File Offset: 0x00004D90
		public unsafe static SteamAPICall_t Invalid
		{
			get
			{
				SteamAPICall_t steamAPICall_t;
				IL2CPP.il2cpp_field_static_get_value(SteamAPICall_t.NativeFieldInfoPtr_Invalid, (void*)(&steamAPICall_t));
				return steamAPICall_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamAPICall_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamAPICall;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamAPICall_t_SteamAPICall_t_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamAPICall_t_UInt64_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamAPICall_t_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamAPICall_t_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamAPICall_t_0;

		// Token: 0x04001282 RID: 4738
		[FieldOffset(0)]
		public ulong m_SteamAPICall;
	}
}
