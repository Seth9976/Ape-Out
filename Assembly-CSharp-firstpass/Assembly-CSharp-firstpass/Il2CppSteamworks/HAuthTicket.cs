using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200015A RID: 346
	[Serializable]
	[StructLayout(2)]
	public struct HAuthTicket
	{
		// Token: 0x06000ECE RID: 3790 RVA: 0x00049AE8 File Offset: 0x00047CE8
		// Note: this type is marked as 'beforefieldinit'.
		static HAuthTicket()
		{
			Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HAuthTicket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr);
			HAuthTicket.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, "Invalid");
			HAuthTicket.NativeFieldInfoPtr_m_HAuthTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, "m_HAuthTicket");
			HAuthTicket.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100665358);
			HAuthTicket.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100665359);
			HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100665360);
			HAuthTicket.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100665361);
			HAuthTicket.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100665362);
			HAuthTicket.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100665363);
			HAuthTicket.NativeMethodInfoPtr_op_Explicit_Public_Static_HAuthTicket_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100665364);
			HAuthTicket.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100665365);
			HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100665366);
			HAuthTicket.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100665367);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00049C08 File Offset: 0x00047E08
		[CallerCount(0)]
		public unsafe HAuthTicket(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00049C3C File Offset: 0x00047E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13328, XrefRangeEnd = 13330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00049C68 File Offset: 0x00047E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13330, XrefRangeEnd = 13334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00049CAC File Offset: 0x00047EAC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00049CDC File Offset: 0x00047EDC
		[CallerCount(0)]
		public unsafe static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00049D28 File Offset: 0x00047F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13334, XrefRangeEnd = 13337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00049D74 File Offset: 0x00047F74
		[CallerCount(0)]
		public unsafe static explicit operator HAuthTicket(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Explicit_Public_Static_HAuthTicket_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00049DB4 File Offset: 0x00047FB4
		[CallerCount(0)]
		public unsafe static explicit operator uint(HAuthTicket that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00049DF4 File Offset: 0x00047FF4
		[CallerCount(0)]
		public unsafe bool Equals(HAuthTicket other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HAuthTicket_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00049E34 File Offset: 0x00048034
		[CallerCount(0)]
		public unsafe int CompareTo(HAuthTicket other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HAuthTicket_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0000688E File Offset: 0x00004A8E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, ref this));
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00049E74 File Offset: 0x00048074
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x000068A0 File Offset: 0x00004AA0
		public unsafe static HAuthTicket Invalid
		{
			get
			{
				HAuthTicket hauthTicket;
				IL2CPP.il2cpp_field_static_get_value(HAuthTicket.NativeFieldInfoPtr_Invalid, (void*)(&hauthTicket));
				return hauthTicket;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HAuthTicket.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeFieldInfoPtr_m_HAuthTicket;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HAuthTicket_UInt32_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HAuthTicket_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HAuthTicket_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HAuthTicket_0;

		// Token: 0x0400112D RID: 4397
		[FieldOffset(0)]
		public uint m_HAuthTicket;
	}
}
