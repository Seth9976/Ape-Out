using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200016B RID: 363
	[Serializable]
	[StructLayout(2)]
	public struct PublishedFileId_t
	{
		// Token: 0x06000FAC RID: 4012 RVA: 0x0004D724 File Offset: 0x0004B924
		// Note: this type is marked as 'beforefieldinit'.
		static PublishedFileId_t()
		{
			Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "PublishedFileId_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr);
			PublishedFileId_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, "Invalid");
			PublishedFileId_t.NativeFieldInfoPtr_m_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, "m_PublishedFileId");
			PublishedFileId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100665537);
			PublishedFileId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100665538);
			PublishedFileId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100665539);
			PublishedFileId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100665540);
			PublishedFileId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100665541);
			PublishedFileId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100665542);
			PublishedFileId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileId_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100665543);
			PublishedFileId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100665544);
			PublishedFileId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100665545);
			PublishedFileId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, 100665546);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0004D844 File Offset: 0x0004BA44
		[CallerCount(0)]
		public unsafe PublishedFileId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x0004D878 File Offset: 0x0004BA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0004D8A4 File Offset: 0x0004BAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13417, XrefRangeEnd = 13421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0004D8E8 File Offset: 0x0004BAE8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0004D918 File Offset: 0x0004BB18
		[CallerCount(0)]
		public unsafe static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0004D964 File Offset: 0x0004BB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13421, XrefRangeEnd = 13424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0004D9B0 File Offset: 0x0004BBB0
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator PublishedFileId_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileId_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0004D9F0 File Offset: 0x0004BBF0
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(PublishedFileId_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0004DA30 File Offset: 0x0004BC30
		[CallerCount(0)]
		public unsafe bool Equals(PublishedFileId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0004DA70 File Offset: 0x0004BC70
		[CallerCount(0)]
		public unsafe int CompareTo(PublishedFileId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00006A4C File Offset: 0x00004C4C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PublishedFileId_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x0004DAB0 File Offset: 0x0004BCB0
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00006A5E File Offset: 0x00004C5E
		public unsafe static PublishedFileId_t Invalid
		{
			get
			{
				PublishedFileId_t publishedFileId_t;
				IL2CPP.il2cpp_field_static_get_value(PublishedFileId_t.NativeFieldInfoPtr_Invalid, (void*)(&publishedFileId_t));
				return publishedFileId_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PublishedFileId_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeFieldInfoPtr_m_PublishedFileId;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileId_t_PublishedFileId_t_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileId_t_UInt64_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileId_t_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileId_t_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileId_t_0;

		// Token: 0x04001201 RID: 4609
		[FieldOffset(0)]
		public ulong m_PublishedFileId;
	}
}
