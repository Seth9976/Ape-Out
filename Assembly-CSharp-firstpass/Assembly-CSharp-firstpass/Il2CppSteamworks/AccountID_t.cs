using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000170 RID: 368
	[Serializable]
	[StructLayout(2)]
	public struct AccountID_t
	{
		// Token: 0x06000FF2 RID: 4082 RVA: 0x0004E96C File Offset: 0x0004CB6C
		// Note: this type is marked as 'beforefieldinit'.
		static AccountID_t()
		{
			Il2CppClassPointerStore<AccountID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AccountID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr);
			AccountID_t.NativeFieldInfoPtr_m_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, "m_AccountID");
			AccountID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100665592);
			AccountID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100665593);
			AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100665594);
			AccountID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100665595);
			AccountID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AccountID_t_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100665596);
			AccountID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AccountID_t_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100665597);
			AccountID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_AccountID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100665598);
			AccountID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100665599);
			AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100665600);
			AccountID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100665601);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0004EA78 File Offset: 0x0004CC78
		[CallerCount(0)]
		public unsafe AccountID_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0004EAAC File Offset: 0x0004CCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0004EAD8 File Offset: 0x0004CCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13452, XrefRangeEnd = 13454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0004EB1C File Offset: 0x0004CD1C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0004EB4C File Offset: 0x0004CD4C
		[CallerCount(0)]
		public unsafe static bool operator ==(AccountID_t x, AccountID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AccountID_t_AccountID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0004EB98 File Offset: 0x0004CD98
		[CallerCount(0)]
		public unsafe static bool operator !=(AccountID_t x, AccountID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AccountID_t_AccountID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0004EBE4 File Offset: 0x0004CDE4
		[CallerCount(0)]
		public unsafe static explicit operator AccountID_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_AccountID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0004EC24 File Offset: 0x0004CE24
		[CallerCount(0)]
		public unsafe static explicit operator uint(AccountID_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AccountID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0004EC64 File Offset: 0x0004CE64
		[CallerCount(0)]
		public unsafe bool Equals(AccountID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AccountID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0004ECA4 File Offset: 0x0004CEA4
		[CallerCount(0)]
		public unsafe int CompareTo(AccountID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AccountID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00006AEC File Offset: 0x00004CEC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeFieldInfoPtr_m_AccountID;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AccountID_t_AccountID_t_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AccountID_t_AccountID_t_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AccountID_t_UInt32_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AccountID_t_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AccountID_t_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AccountID_t_0;

		// Token: 0x04001241 RID: 4673
		[FieldOffset(0)]
		public uint m_AccountID;
	}
}
