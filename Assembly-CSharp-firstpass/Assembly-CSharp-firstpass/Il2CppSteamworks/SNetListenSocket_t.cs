using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000169 RID: 361
	[Serializable]
	[StructLayout(2)]
	public struct SNetListenSocket_t
	{
		// Token: 0x06000F94 RID: 3988 RVA: 0x0004D034 File Offset: 0x0004B234
		// Note: this type is marked as 'beforefieldinit'.
		static SNetListenSocket_t()
		{
			Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SNetListenSocket_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr);
			SNetListenSocket_t.NativeFieldInfoPtr_m_SNetListenSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, "m_SNetListenSocket");
			SNetListenSocket_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100665517);
			SNetListenSocket_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100665518);
			SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100665519);
			SNetListenSocket_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100665520);
			SNetListenSocket_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100665521);
			SNetListenSocket_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100665522);
			SNetListenSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SNetListenSocket_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100665523);
			SNetListenSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100665524);
			SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100665525);
			SNetListenSocket_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100665526);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0004D140 File Offset: 0x0004B340
		[CallerCount(0)]
		public unsafe SNetListenSocket_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0004D174 File Offset: 0x0004B374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0004D1A0 File Offset: 0x0004B3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13413, XrefRangeEnd = 13415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0004D1E4 File Offset: 0x0004B3E4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0004D214 File Offset: 0x0004B414
		[CallerCount(0)]
		public unsafe static bool operator ==(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0004D260 File Offset: 0x0004B460
		[CallerCount(0)]
		public unsafe static bool operator !=(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x0004D2AC File Offset: 0x0004B4AC
		[CallerCount(0)]
		public unsafe static explicit operator SNetListenSocket_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SNetListenSocket_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0004D2EC File Offset: 0x0004B4EC
		[CallerCount(0)]
		public unsafe static explicit operator uint(SNetListenSocket_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SNetListenSocket_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0004D32C File Offset: 0x0004B52C
		[CallerCount(0)]
		public unsafe bool Equals(SNetListenSocket_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetListenSocket_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0004D36C File Offset: 0x0004B56C
		[CallerCount(0)]
		public unsafe int CompareTo(SNetListenSocket_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetListenSocket_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00006A28 File Offset: 0x00004C28
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, ref this));
		}

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeFieldInfoPtr_m_SNetListenSocket;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SNetListenSocket_t_UInt32_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_SNetListenSocket_t_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetListenSocket_t_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetListenSocket_t_0;

		// Token: 0x040011E8 RID: 4584
		[FieldOffset(0)]
		public uint m_SNetListenSocket;
	}
}
