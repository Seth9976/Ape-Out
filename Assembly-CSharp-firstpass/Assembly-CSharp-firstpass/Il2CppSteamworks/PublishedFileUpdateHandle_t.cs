using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200016C RID: 364
	[Serializable]
	[StructLayout(2)]
	public struct PublishedFileUpdateHandle_t
	{
		// Token: 0x06000FBA RID: 4026 RVA: 0x0004DACC File Offset: 0x0004BCCC
		// Note: this type is marked as 'beforefieldinit'.
		static PublishedFileUpdateHandle_t()
		{
			Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "PublishedFileUpdateHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr);
			PublishedFileUpdateHandle_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, "Invalid");
			PublishedFileUpdateHandle_t.NativeFieldInfoPtr_m_PublishedFileUpdateHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, "m_PublishedFileUpdateHandle");
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100665548);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100665549);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100665550);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100665551);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100665552);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100665553);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileUpdateHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100665554);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100665555);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100665556);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100665557);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0004DBEC File Offset: 0x0004BDEC
		[CallerCount(0)]
		public unsafe PublishedFileUpdateHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0004DC20 File Offset: 0x0004BE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0004DC4C File Offset: 0x0004BE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13424, XrefRangeEnd = 13428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0004DC90 File Offset: 0x0004BE90
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0004DCC0 File Offset: 0x0004BEC0
		[CallerCount(0)]
		public unsafe static bool operator ==(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0004DD0C File Offset: 0x0004BF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13428, XrefRangeEnd = 13431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0004DD58 File Offset: 0x0004BF58
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileUpdateHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0004DD98 File Offset: 0x0004BF98
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(PublishedFileUpdateHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0004DDD8 File Offset: 0x0004BFD8
		[CallerCount(0)]
		public unsafe bool Equals(PublishedFileUpdateHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0004DE18 File Offset: 0x0004C018
		[CallerCount(0)]
		public unsafe int CompareTo(PublishedFileUpdateHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00006A6C File Offset: 0x00004C6C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0004DE58 File Offset: 0x0004C058
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x00006A7E File Offset: 0x00004C7E
		public unsafe static PublishedFileUpdateHandle_t Invalid
		{
			get
			{
				PublishedFileUpdateHandle_t publishedFileUpdateHandle_t;
				IL2CPP.il2cpp_field_static_get_value(PublishedFileUpdateHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&publishedFileUpdateHandle_t));
				return publishedFileUpdateHandle_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PublishedFileUpdateHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeFieldInfoPtr_m_PublishedFileUpdateHandle;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_PublishedFileUpdateHandle_t_UInt64_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_PublishedFileUpdateHandle_t_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileUpdateHandle_t_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileUpdateHandle_t_0;

		// Token: 0x0400120E RID: 4622
		[FieldOffset(0)]
		public ulong m_PublishedFileUpdateHandle;
	}
}
