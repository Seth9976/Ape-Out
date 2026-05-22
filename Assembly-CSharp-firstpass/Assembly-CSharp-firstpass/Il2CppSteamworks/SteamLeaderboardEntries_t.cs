using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000178 RID: 376
	[Serializable]
	[StructLayout(2)]
	public struct SteamLeaderboardEntries_t
	{
		// Token: 0x06001060 RID: 4192 RVA: 0x0005067C File Offset: 0x0004E87C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamLeaderboardEntries_t()
		{
			Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamLeaderboardEntries_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr);
			SteamLeaderboardEntries_t.NativeFieldInfoPtr_m_SteamLeaderboardEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, "m_SteamLeaderboardEntries");
			SteamLeaderboardEntries_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100665679);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100665680);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100665681);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100665682);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100665683);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100665684);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamLeaderboardEntries_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100665685);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100665686);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100665687);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100665688);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00050788 File Offset: 0x0004E988
		[CallerCount(0)]
		public unsafe SteamLeaderboardEntries_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x000507BC File Offset: 0x0004E9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x000507E8 File Offset: 0x0004E9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13503, XrefRangeEnd = 13505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0005082C File Offset: 0x0004EA2C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0005085C File Offset: 0x0004EA5C
		[CallerCount(0)]
		public unsafe static bool operator ==(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x000508A8 File Offset: 0x0004EAA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12921, RefRangeEnd = 12922, XrefRangeStart = 12921, XrefRangeEnd = 12922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x000508F4 File Offset: 0x0004EAF4
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamLeaderboardEntries_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamLeaderboardEntries_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00050934 File Offset: 0x0004EB34
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(SteamLeaderboardEntries_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamLeaderboardEntries_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00050974 File Offset: 0x0004EB74
		[CallerCount(0)]
		public unsafe bool Equals(SteamLeaderboardEntries_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboardEntries_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x000509B4 File Offset: 0x0004EBB4
		[CallerCount(0)]
		public unsafe int CompareTo(SteamLeaderboardEntries_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboardEntries_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00006BDE File Offset: 0x00004DDE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, ref this));
		}

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamLeaderboardEntries;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamLeaderboardEntries_t_UInt64_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamLeaderboardEntries_t_0;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboardEntries_t_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboardEntries_t_0;

		// Token: 0x040012A8 RID: 4776
		[FieldOffset(0)]
		public ulong m_SteamLeaderboardEntries;
	}
}
