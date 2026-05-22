using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000168 RID: 360
	[Serializable]
	[StructLayout(2)]
	public struct HServerQuery
	{
		// Token: 0x06000F86 RID: 3974 RVA: 0x0004CC8C File Offset: 0x0004AE8C
		// Note: this type is marked as 'beforefieldinit'.
		static HServerQuery()
		{
			Il2CppClassPointerStore<HServerQuery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HServerQuery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr);
			HServerQuery.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, "Invalid");
			HServerQuery.NativeFieldInfoPtr_m_HServerQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, "m_HServerQuery");
			HServerQuery.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100665506);
			HServerQuery.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100665507);
			HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100665508);
			HServerQuery.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100665509);
			HServerQuery.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerQuery_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100665510);
			HServerQuery.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerQuery_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100665511);
			HServerQuery.NativeMethodInfoPtr_op_Explicit_Public_Static_HServerQuery_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100665512);
			HServerQuery.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100665513);
			HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100665514);
			HServerQuery.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100665515);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0004CDAC File Offset: 0x0004AFAC
		[CallerCount(0)]
		public unsafe HServerQuery(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0004CDE0 File Offset: 0x0004AFE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 12865, RefRangeEnd = 12872, XrefRangeStart = 12865, XrefRangeEnd = 12872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0004CE0C File Offset: 0x0004B00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13406, XrefRangeEnd = 13410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0004CE50 File Offset: 0x0004B050
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0004CE80 File Offset: 0x0004B080
		[CallerCount(0)]
		public unsafe static bool operator ==(HServerQuery x, HServerQuery y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerQuery_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0004CECC File Offset: 0x0004B0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13410, XrefRangeEnd = 13413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HServerQuery x, HServerQuery y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerQuery_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0004CF18 File Offset: 0x0004B118
		[CallerCount(0)]
		public unsafe static explicit operator HServerQuery(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Explicit_Public_Static_HServerQuery_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0004CF58 File Offset: 0x0004B158
		[CallerCount(0)]
		public unsafe static explicit operator int(HServerQuery that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0004CF98 File Offset: 0x0004B198
		[CallerCount(0)]
		public unsafe bool Equals(HServerQuery other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerQuery_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0004CFD8 File Offset: 0x0004B1D8
		[CallerCount(0)]
		public unsafe int CompareTo(HServerQuery other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerQuery_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00006A08 File Offset: 0x00004C08
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, ref this));
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0004D018 File Offset: 0x0004B218
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00006A1A File Offset: 0x00004C1A
		public unsafe static HServerQuery Invalid
		{
			get
			{
				HServerQuery hserverQuery;
				IL2CPP.il2cpp_field_static_get_value(HServerQuery.NativeFieldInfoPtr_Invalid, (void*)(&hserverQuery));
				return hserverQuery;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HServerQuery.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeFieldInfoPtr_m_HServerQuery;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerQuery_HServerQuery_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerQuery_HServerQuery_0;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HServerQuery_Int32_0;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HServerQuery_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerQuery_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerQuery_0;

		// Token: 0x040011DC RID: 4572
		[FieldOffset(0)]
		public int m_HServerQuery;
	}
}
