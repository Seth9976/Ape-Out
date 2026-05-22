using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000163 RID: 355
	[Serializable]
	[StructLayout(2)]
	public struct SteamInventoryResult_t
	{
		// Token: 0x06000F44 RID: 3908 RVA: 0x0004BB10 File Offset: 0x00049D10
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryResult_t()
		{
			Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr);
			SteamInventoryResult_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, "Invalid");
			SteamInventoryResult_t.NativeFieldInfoPtr_m_SteamInventoryResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, "m_SteamInventoryResult");
			SteamInventoryResult_t.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100665453);
			SteamInventoryResult_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100665454);
			SteamInventoryResult_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100665455);
			SteamInventoryResult_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100665456);
			SteamInventoryResult_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100665457);
			SteamInventoryResult_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100665458);
			SteamInventoryResult_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamInventoryResult_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100665459);
			SteamInventoryResult_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100665460);
			SteamInventoryResult_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100665461);
			SteamInventoryResult_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100665462);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0004BC30 File Offset: 0x00049E30
		[CallerCount(0)]
		public unsafe SteamInventoryResult_t(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0004BC64 File Offset: 0x00049E64
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 12865, RefRangeEnd = 12872, XrefRangeStart = 12865, XrefRangeEnd = 12872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0004BC90 File Offset: 0x00049E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13375, XrefRangeEnd = 13379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0004BCD4 File Offset: 0x00049ED4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0004BD04 File Offset: 0x00049F04
		[CallerCount(0)]
		public unsafe static bool operator ==(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0004BD50 File Offset: 0x00049F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13379, XrefRangeEnd = 13382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0004BD9C File Offset: 0x00049F9C
		[CallerCount(0)]
		public unsafe static explicit operator SteamInventoryResult_t(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamInventoryResult_t_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0004BDDC File Offset: 0x00049FDC
		[CallerCount(0)]
		public unsafe static explicit operator int(SteamInventoryResult_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0004BE1C File Offset: 0x0004A01C
		[CallerCount(0)]
		public unsafe bool Equals(SteamInventoryResult_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamInventoryResult_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0004BE5C File Offset: 0x0004A05C
		[CallerCount(0)]
		public unsafe int CompareTo(SteamInventoryResult_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamInventoryResult_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00006976 File Offset: 0x00004B76
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x0004BE9C File Offset: 0x0004A09C
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x00006988 File Offset: 0x00004B88
		public unsafe static SteamInventoryResult_t Invalid
		{
			get
			{
				SteamInventoryResult_t steamInventoryResult_t;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryResult_t.NativeFieldInfoPtr_Invalid, (void*)(&steamInventoryResult_t));
				return steamInventoryResult_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryResult_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamInventoryResult;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamInventoryResult_t_Int32_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamInventoryResult_t_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamInventoryResult_t_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamInventoryResult_t_0;

		// Token: 0x0400119E RID: 4510
		[FieldOffset(0)]
		public int m_SteamInventoryResult;
	}
}
