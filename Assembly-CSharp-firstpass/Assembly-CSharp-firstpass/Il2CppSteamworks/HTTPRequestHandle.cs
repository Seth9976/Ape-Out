using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000162 RID: 354
	[Serializable]
	[StructLayout(2)]
	public struct HTTPRequestHandle
	{
		// Token: 0x06000F36 RID: 3894 RVA: 0x0004B768 File Offset: 0x00049968
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestHandle()
		{
			Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTTPRequestHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr);
			HTTPRequestHandle.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, "Invalid");
			HTTPRequestHandle.NativeFieldInfoPtr_m_HTTPRequestHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, "m_HTTPRequestHandle");
			HTTPRequestHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100665442);
			HTTPRequestHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100665443);
			HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100665444);
			HTTPRequestHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100665445);
			HTTPRequestHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100665446);
			HTTPRequestHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100665447);
			HTTPRequestHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100665448);
			HTTPRequestHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100665449);
			HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100665450);
			HTTPRequestHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100665451);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0004B888 File Offset: 0x00049A88
		[CallerCount(0)]
		public unsafe HTTPRequestHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0004B8BC File Offset: 0x00049ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0004B8E8 File Offset: 0x00049AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13368, XrefRangeEnd = 13372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0004B92C File Offset: 0x00049B2C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0004B95C File Offset: 0x00049B5C
		[CallerCount(0)]
		public unsafe static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0004B9A8 File Offset: 0x00049BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13372, XrefRangeEnd = 13375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0004B9F4 File Offset: 0x00049BF4
		[CallerCount(0)]
		public unsafe static explicit operator HTTPRequestHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0004BA34 File Offset: 0x00049C34
		[CallerCount(0)]
		public unsafe static explicit operator uint(HTTPRequestHandle that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0004BA74 File Offset: 0x00049C74
		[CallerCount(0)]
		public unsafe bool Equals(HTTPRequestHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPRequestHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0004BAB4 File Offset: 0x00049CB4
		[CallerCount(0)]
		public unsafe int CompareTo(HTTPRequestHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPRequestHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00006956 File Offset: 0x00004B56
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0004BAF4 File Offset: 0x00049CF4
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x00006968 File Offset: 0x00004B68
		public unsafe static HTTPRequestHandle Invalid
		{
			get
			{
				HTTPRequestHandle httprequestHandle;
				IL2CPP.il2cpp_field_static_get_value(HTTPRequestHandle.NativeFieldInfoPtr_Invalid, (void*)(&httprequestHandle));
				return httprequestHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPRequestHandle.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeFieldInfoPtr_m_HTTPRequestHandle;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPRequestHandle_UInt32_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPRequestHandle_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPRequestHandle_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPRequestHandle_0;

		// Token: 0x04001191 RID: 4497
		[FieldOffset(0)]
		public uint m_HTTPRequestHandle;
	}
}
