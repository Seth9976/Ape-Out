using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200015F RID: 351
	[Serializable]
	[StructLayout(2)]
	public struct FriendsGroupID_t
	{
		// Token: 0x06000F0C RID: 3852 RVA: 0x0004AC70 File Offset: 0x00048E70
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsGroupID_t()
		{
			Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendsGroupID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr);
			FriendsGroupID_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, "Invalid");
			FriendsGroupID_t.NativeFieldInfoPtr_m_FriendsGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, "m_FriendsGroupID");
			FriendsGroupID_t.NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100665409);
			FriendsGroupID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100665410);
			FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100665411);
			FriendsGroupID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100665412);
			FriendsGroupID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100665413);
			FriendsGroupID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100665414);
			FriendsGroupID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_FriendsGroupID_t_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100665415);
			FriendsGroupID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100665416);
			FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100665417);
			FriendsGroupID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100665418);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0004AD90 File Offset: 0x00048F90
		[CallerCount(0)]
		public unsafe FriendsGroupID_t(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr__ctor_Public_Void_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0004ADC4 File Offset: 0x00048FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13345, XrefRangeEnd = 13347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0004ADF0 File Offset: 0x00048FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13347, XrefRangeEnd = 13351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0004AE34 File Offset: 0x00049034
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0004AE64 File Offset: 0x00049064
		[CallerCount(0)]
		public unsafe static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0004AEB0 File Offset: 0x000490B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13351, XrefRangeEnd = 13354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0004AEFC File Offset: 0x000490FC
		[CallerCount(0)]
		public unsafe static explicit operator FriendsGroupID_t(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_FriendsGroupID_t_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0004AF3C File Offset: 0x0004913C
		[CallerCount(0)]
		public unsafe static explicit operator short(FriendsGroupID_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0004AF7C File Offset: 0x0004917C
		[CallerCount(0)]
		public unsafe bool Equals(FriendsGroupID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FriendsGroupID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0004AFBC File Offset: 0x000491BC
		[CallerCount(0)]
		public unsafe int CompareTo(FriendsGroupID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FriendsGroupID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000068F6 File Offset: 0x00004AF6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x0004AFFC File Offset: 0x000491FC
		// (set) Token: 0x06000F19 RID: 3865 RVA: 0x00006908 File Offset: 0x00004B08
		public unsafe static FriendsGroupID_t Invalid
		{
			get
			{
				FriendsGroupID_t friendsGroupID_t;
				IL2CPP.il2cpp_field_static_get_value(FriendsGroupID_t.NativeFieldInfoPtr_Invalid, (void*)(&friendsGroupID_t));
				return friendsGroupID_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsGroupID_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeFieldInfoPtr_m_FriendsGroupID;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_FriendsGroupID_t_Int16_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_FriendsGroupID_t_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FriendsGroupID_t_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FriendsGroupID_t_0;

		// Token: 0x0400116A RID: 4458
		[FieldOffset(0)]
		public short m_FriendsGroupID;
	}
}
