using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000161 RID: 353
	[Serializable]
	[StructLayout(2)]
	public struct HTTPCookieContainerHandle
	{
		// Token: 0x06000F28 RID: 3880 RVA: 0x0004B3C0 File Offset: 0x000495C0
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPCookieContainerHandle()
		{
			Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTTPCookieContainerHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr);
			HTTPCookieContainerHandle.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, "Invalid");
			HTTPCookieContainerHandle.NativeFieldInfoPtr_m_HTTPCookieContainerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, "m_HTTPCookieContainerHandle");
			HTTPCookieContainerHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100665431);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100665432);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100665433);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100665434);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100665435);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100665436);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPCookieContainerHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100665437);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100665438);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100665439);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100665440);
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0004B4E0 File Offset: 0x000496E0
		[CallerCount(0)]
		public unsafe HTTPCookieContainerHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0004B514 File Offset: 0x00049714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0004B540 File Offset: 0x00049740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13361, XrefRangeEnd = 13365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0004B584 File Offset: 0x00049784
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0004B5B4 File Offset: 0x000497B4
		[CallerCount(0)]
		public unsafe static bool operator ==(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0004B600 File Offset: 0x00049800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13365, XrefRangeEnd = 13368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0004B64C File Offset: 0x0004984C
		[CallerCount(0)]
		public unsafe static explicit operator HTTPCookieContainerHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPCookieContainerHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0004B68C File Offset: 0x0004988C
		[CallerCount(0)]
		public unsafe static explicit operator uint(HTTPCookieContainerHandle that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0004B6CC File Offset: 0x000498CC
		[CallerCount(0)]
		public unsafe bool Equals(HTTPCookieContainerHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPCookieContainerHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0004B70C File Offset: 0x0004990C
		[CallerCount(0)]
		public unsafe int CompareTo(HTTPCookieContainerHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPCookieContainerHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00006936 File Offset: 0x00004B36
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x0004B74C File Offset: 0x0004994C
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x00006948 File Offset: 0x00004B48
		public unsafe static HTTPCookieContainerHandle Invalid
		{
			get
			{
				HTTPCookieContainerHandle httpcookieContainerHandle;
				IL2CPP.il2cpp_field_static_get_value(HTTPCookieContainerHandle.NativeFieldInfoPtr_Invalid, (void*)(&httpcookieContainerHandle));
				return httpcookieContainerHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPCookieContainerHandle.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr_m_HTTPCookieContainerHandle;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPCookieContainerHandle_UInt32_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPCookieContainerHandle_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPCookieContainerHandle_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPCookieContainerHandle_0;

		// Token: 0x04001184 RID: 4484
		[FieldOffset(0)]
		public uint m_HTTPCookieContainerHandle;
	}
}
