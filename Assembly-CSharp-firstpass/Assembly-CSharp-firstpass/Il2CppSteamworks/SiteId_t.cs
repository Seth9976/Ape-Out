using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000174 RID: 372
	[Serializable]
	[StructLayout(2)]
	public struct SiteId_t
	{
		// Token: 0x06001028 RID: 4136 RVA: 0x0004F7DC File Offset: 0x0004D9DC
		// Note: this type is marked as 'beforefieldinit'.
		static SiteId_t()
		{
			Il2CppClassPointerStore<SiteId_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SiteId_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr);
			SiteId_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, "Invalid");
			SiteId_t.NativeFieldInfoPtr_m_SiteId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, "m_SiteId");
			SiteId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100665635);
			SiteId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100665636);
			SiteId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100665637);
			SiteId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100665638);
			SiteId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SiteId_t_SiteId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100665639);
			SiteId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SiteId_t_SiteId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100665640);
			SiteId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SiteId_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100665641);
			SiteId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SiteId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100665642);
			SiteId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SiteId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100665643);
			SiteId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SiteId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, 100665644);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0004F8FC File Offset: 0x0004DAFC
		[CallerCount(0)]
		public unsafe SiteId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0004F930 File Offset: 0x0004DB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0004F95C File Offset: 0x0004DB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13475, XrefRangeEnd = 13479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0004F9A0 File Offset: 0x0004DBA0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0004F9D0 File Offset: 0x0004DBD0
		[CallerCount(0)]
		public unsafe static bool operator ==(SiteId_t x, SiteId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SiteId_t_SiteId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0004FA1C File Offset: 0x0004DC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13479, XrefRangeEnd = 13482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SiteId_t x, SiteId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SiteId_t_SiteId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0004FA68 File Offset: 0x0004DC68
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SiteId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SiteId_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0004FAA8 File Offset: 0x0004DCA8
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(SiteId_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SiteId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0004FAE8 File Offset: 0x0004DCE8
		[CallerCount(0)]
		public unsafe bool Equals(SiteId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SiteId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0004FB28 File Offset: 0x0004DD28
		[CallerCount(0)]
		public unsafe int CompareTo(SiteId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiteId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SiteId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00006B5E File Offset: 0x00004D5E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SiteId_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0004FB68 File Offset: 0x0004DD68
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x00006B70 File Offset: 0x00004D70
		public unsafe static SiteId_t Invalid
		{
			get
			{
				SiteId_t siteId_t;
				IL2CPP.il2cpp_field_static_get_value(SiteId_t.NativeFieldInfoPtr_Invalid, (void*)(&siteId_t));
				return siteId_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SiteId_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeFieldInfoPtr_m_SiteId;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SiteId_t_SiteId_t_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SiteId_t_SiteId_t_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SiteId_t_UInt64_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SiteId_t_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SiteId_t_0;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SiteId_t_0;

		// Token: 0x04001275 RID: 4725
		[FieldOffset(0)]
		public ulong m_SiteId;
	}
}
