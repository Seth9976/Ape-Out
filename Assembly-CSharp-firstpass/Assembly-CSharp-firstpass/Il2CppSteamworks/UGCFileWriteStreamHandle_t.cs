using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200016D RID: 365
	[Serializable]
	[StructLayout(2)]
	public struct UGCFileWriteStreamHandle_t
	{
		// Token: 0x06000FC8 RID: 4040 RVA: 0x0004DE74 File Offset: 0x0004C074
		// Note: this type is marked as 'beforefieldinit'.
		static UGCFileWriteStreamHandle_t()
		{
			Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UGCFileWriteStreamHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr);
			UGCFileWriteStreamHandle_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, "Invalid");
			UGCFileWriteStreamHandle_t.NativeFieldInfoPtr_m_UGCFileWriteStreamHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, "m_UGCFileWriteStreamHandle");
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100665559);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100665560);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100665561);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100665562);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100665563);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100665564);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCFileWriteStreamHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100665565);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100665566);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100665567);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100665568);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0004DF94 File Offset: 0x0004C194
		[CallerCount(0)]
		public unsafe UGCFileWriteStreamHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0004DFC8 File Offset: 0x0004C1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0004DFF4 File Offset: 0x0004C1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13431, XrefRangeEnd = 13435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0004E038 File Offset: 0x0004C238
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0004E068 File Offset: 0x0004C268
		[CallerCount(0)]
		public unsafe static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0004E0B4 File Offset: 0x0004C2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13435, XrefRangeEnd = 13438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0004E100 File Offset: 0x0004C300
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCFileWriteStreamHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0004E140 File Offset: 0x0004C340
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCFileWriteStreamHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0004E180 File Offset: 0x0004C380
		[CallerCount(0)]
		public unsafe bool Equals(UGCFileWriteStreamHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCFileWriteStreamHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0004E1C0 File Offset: 0x0004C3C0
		[CallerCount(0)]
		public unsafe int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCFileWriteStreamHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00006A8C File Offset: 0x00004C8C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0004E200 File Offset: 0x0004C400
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00006A9E File Offset: 0x00004C9E
		public unsafe static UGCFileWriteStreamHandle_t Invalid
		{
			get
			{
				UGCFileWriteStreamHandle_t ugcfileWriteStreamHandle_t;
				IL2CPP.il2cpp_field_static_get_value(UGCFileWriteStreamHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&ugcfileWriteStreamHandle_t));
				return ugcfileWriteStreamHandle_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UGCFileWriteStreamHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeFieldInfoPtr_m_UGCFileWriteStreamHandle;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UGCFileWriteStreamHandle_t_UInt64_0;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCFileWriteStreamHandle_t_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCFileWriteStreamHandle_t_0;

		// Token: 0x0400121B RID: 4635
		[FieldOffset(0)]
		public ulong m_UGCFileWriteStreamHandle;
	}
}
