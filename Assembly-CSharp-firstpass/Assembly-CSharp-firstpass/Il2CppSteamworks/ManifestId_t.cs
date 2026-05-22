using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000173 RID: 371
	[Serializable]
	[StructLayout(2)]
	public struct ManifestId_t
	{
		// Token: 0x0600101A RID: 4122 RVA: 0x0004F434 File Offset: 0x0004D634
		// Note: this type is marked as 'beforefieldinit'.
		static ManifestId_t()
		{
			Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ManifestId_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr);
			ManifestId_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, "Invalid");
			ManifestId_t.NativeFieldInfoPtr_m_ManifestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, "m_ManifestId");
			ManifestId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100665624);
			ManifestId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100665625);
			ManifestId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100665626);
			ManifestId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100665627);
			ManifestId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100665628);
			ManifestId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100665629);
			ManifestId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ManifestId_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100665630);
			ManifestId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ManifestId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100665631);
			ManifestId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ManifestId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100665632);
			ManifestId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ManifestId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, 100665633);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0004F554 File Offset: 0x0004D754
		[CallerCount(0)]
		public unsafe ManifestId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0004F588 File Offset: 0x0004D788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0004F5B4 File Offset: 0x0004D7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13468, XrefRangeEnd = 13472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0004F5F8 File Offset: 0x0004D7F8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0004F628 File Offset: 0x0004D828
		[CallerCount(0)]
		public unsafe static bool operator ==(ManifestId_t x, ManifestId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0004F674 File Offset: 0x0004D874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13472, XrefRangeEnd = 13475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ManifestId_t x, ManifestId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0004F6C0 File Offset: 0x0004D8C0
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ManifestId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ManifestId_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0004F700 File Offset: 0x0004D900
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(ManifestId_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ManifestId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0004F740 File Offset: 0x0004D940
		[CallerCount(0)]
		public unsafe bool Equals(ManifestId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ManifestId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0004F780 File Offset: 0x0004D980
		[CallerCount(0)]
		public unsafe int CompareTo(ManifestId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ManifestId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00006B3E File Offset: 0x00004D3E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManifestId_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x0004F7C0 File Offset: 0x0004D9C0
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x00006B50 File Offset: 0x00004D50
		public unsafe static ManifestId_t Invalid
		{
			get
			{
				ManifestId_t manifestId_t;
				IL2CPP.il2cpp_field_static_get_value(ManifestId_t.NativeFieldInfoPtr_Invalid, (void*)(&manifestId_t));
				return manifestId_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManifestId_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeFieldInfoPtr_m_ManifestId;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ManifestId_t_ManifestId_t_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ManifestId_t_UInt64_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ManifestId_t_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ManifestId_t_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ManifestId_t_0;

		// Token: 0x04001268 RID: 4712
		[FieldOffset(0)]
		public ulong m_ManifestId;
	}
}
