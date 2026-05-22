using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000166 RID: 358
	[Serializable]
	[StructLayout(2)]
	public struct SteamItemInstanceID_t
	{
		// Token: 0x06000F6C RID: 3948 RVA: 0x0004C5D8 File Offset: 0x0004A7D8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamItemInstanceID_t()
		{
			Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamItemInstanceID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr);
			SteamItemInstanceID_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, "Invalid");
			SteamItemInstanceID_t.NativeFieldInfoPtr_m_SteamItemInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, "m_SteamItemInstanceID");
			SteamItemInstanceID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100665485);
			SteamItemInstanceID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100665486);
			SteamItemInstanceID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100665487);
			SteamItemInstanceID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100665488);
			SteamItemInstanceID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100665489);
			SteamItemInstanceID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100665490);
			SteamItemInstanceID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemInstanceID_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100665491);
			SteamItemInstanceID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100665492);
			SteamItemInstanceID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100665493);
			SteamItemInstanceID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, 100665494);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0004C6F8 File Offset: 0x0004A8F8
		[CallerCount(0)]
		public unsafe SteamItemInstanceID_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0004C72C File Offset: 0x0004A92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0004C758 File Offset: 0x0004A958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13391, XrefRangeEnd = 13395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0004C79C File Offset: 0x0004A99C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0004C7CC File Offset: 0x0004A9CC
		[CallerCount(0)]
		public unsafe static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0004C818 File Offset: 0x0004AA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13395, XrefRangeEnd = 13398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0004C864 File Offset: 0x0004AA64
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamItemInstanceID_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemInstanceID_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0004C8A4 File Offset: 0x0004AAA4
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(SteamItemInstanceID_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamItemInstanceID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0004C8E4 File Offset: 0x0004AAE4
		[CallerCount(0)]
		public unsafe bool Equals(SteamItemInstanceID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemInstanceID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0004C924 File Offset: 0x0004AB24
		[CallerCount(0)]
		public unsafe int CompareTo(SteamItemInstanceID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemInstanceID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemInstanceID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x000069C8 File Offset: 0x00004BC8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamItemInstanceID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x0004C964 File Offset: 0x0004AB64
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x000069DA File Offset: 0x00004BDA
		public unsafe static SteamItemInstanceID_t Invalid
		{
			get
			{
				SteamItemInstanceID_t steamItemInstanceID_t;
				IL2CPP.il2cpp_field_static_get_value(SteamItemInstanceID_t.NativeFieldInfoPtr_Invalid, (void*)(&steamItemInstanceID_t));
				return steamItemInstanceID_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamItemInstanceID_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamItemInstanceID;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemInstanceID_t_SteamItemInstanceID_t_0;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemInstanceID_t_UInt64_0;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamItemInstanceID_t_0;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemInstanceID_t_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemInstanceID_t_0;

		// Token: 0x040011C4 RID: 4548
		[FieldOffset(0)]
		public ulong m_SteamItemInstanceID;
	}
}
