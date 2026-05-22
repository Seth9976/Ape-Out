using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000165 RID: 357
	[Serializable]
	[StructLayout(2)]
	public struct SteamItemDef_t
	{
		// Token: 0x06000F60 RID: 3936 RVA: 0x0004C260 File Offset: 0x0004A460
		// Note: this type is marked as 'beforefieldinit'.
		static SteamItemDef_t()
		{
			Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamItemDef_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr);
			SteamItemDef_t.NativeFieldInfoPtr_m_SteamItemDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, "m_SteamItemDef");
			SteamItemDef_t.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100665475);
			SteamItemDef_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100665476);
			SteamItemDef_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100665477);
			SteamItemDef_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100665478);
			SteamItemDef_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100665479);
			SteamItemDef_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100665480);
			SteamItemDef_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemDef_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100665481);
			SteamItemDef_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100665482);
			SteamItemDef_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100665483);
			SteamItemDef_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100665484);
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0004C36C File Offset: 0x0004A56C
		[CallerCount(0)]
		public unsafe SteamItemDef_t(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0004C3A0 File Offset: 0x0004A5A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 12865, RefRangeEnd = 12872, XrefRangeStart = 12865, XrefRangeEnd = 12872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0004C3CC File Offset: 0x0004A5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13389, XrefRangeEnd = 13391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0004C410 File Offset: 0x0004A610
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0004C440 File Offset: 0x0004A640
		[CallerCount(0)]
		public unsafe static bool operator ==(SteamItemDef_t x, SteamItemDef_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0004C48C File Offset: 0x0004A68C
		[CallerCount(0)]
		public unsafe static bool operator !=(SteamItemDef_t x, SteamItemDef_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0004C4D8 File Offset: 0x0004A6D8
		[CallerCount(0)]
		public unsafe static explicit operator SteamItemDef_t(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemDef_t_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0004C518 File Offset: 0x0004A718
		[CallerCount(0)]
		public unsafe static explicit operator int(SteamItemDef_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0004C558 File Offset: 0x0004A758
		[CallerCount(0)]
		public unsafe bool Equals(SteamItemDef_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemDef_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0004C598 File Offset: 0x0004A798
		[CallerCount(0)]
		public unsafe int CompareTo(SteamItemDef_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemDef_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x000069B6 File Offset: 0x00004BB6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, ref this));
		}

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamItemDef;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemDef_t_Int32_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamItemDef_t_0;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemDef_t_0;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemDef_t_0;

		// Token: 0x040011B7 RID: 4535
		[FieldOffset(0)]
		public int m_SteamItemDef;
	}
}
