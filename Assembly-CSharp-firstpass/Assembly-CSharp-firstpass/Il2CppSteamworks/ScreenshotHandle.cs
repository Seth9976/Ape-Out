using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200016F RID: 367
	[Serializable]
	[StructLayout(2)]
	public struct ScreenshotHandle
	{
		// Token: 0x06000FE4 RID: 4068 RVA: 0x0004E5C4 File Offset: 0x0004C7C4
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotHandle()
		{
			Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ScreenshotHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr);
			ScreenshotHandle.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, "Invalid");
			ScreenshotHandle.NativeFieldInfoPtr_m_ScreenshotHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, "m_ScreenshotHandle");
			ScreenshotHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100665581);
			ScreenshotHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100665582);
			ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100665583);
			ScreenshotHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100665584);
			ScreenshotHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100665585);
			ScreenshotHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100665586);
			ScreenshotHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_ScreenshotHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100665587);
			ScreenshotHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100665588);
			ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100665589);
			ScreenshotHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100665590);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0004E6E4 File Offset: 0x0004C8E4
		[CallerCount(0)]
		public unsafe ScreenshotHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0004E718 File Offset: 0x0004C918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0004E744 File Offset: 0x0004C944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13445, XrefRangeEnd = 13449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0004E788 File Offset: 0x0004C988
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0004E7B8 File Offset: 0x0004C9B8
		[CallerCount(0)]
		public unsafe static bool operator ==(ScreenshotHandle x, ScreenshotHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0004E804 File Offset: 0x0004CA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13449, XrefRangeEnd = 13452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ScreenshotHandle x, ScreenshotHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0004E850 File Offset: 0x0004CA50
		[CallerCount(0)]
		public unsafe static explicit operator ScreenshotHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_ScreenshotHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0004E890 File Offset: 0x0004CA90
		[CallerCount(0)]
		public unsafe static explicit operator uint(ScreenshotHandle that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_ScreenshotHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0004E8D0 File Offset: 0x0004CAD0
		[CallerCount(0)]
		public unsafe bool Equals(ScreenshotHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenshotHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0004E910 File Offset: 0x0004CB10
		[CallerCount(0)]
		public unsafe int CompareTo(ScreenshotHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenshotHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00006ACC File Offset: 0x00004CCC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0004E950 File Offset: 0x0004CB50
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x00006ADE File Offset: 0x00004CDE
		public unsafe static ScreenshotHandle Invalid
		{
			get
			{
				ScreenshotHandle screenshotHandle;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotHandle.NativeFieldInfoPtr_Invalid, (void*)(&screenshotHandle));
				return screenshotHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotHandle.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenshotHandle;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ScreenshotHandle_UInt32_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_ScreenshotHandle_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenshotHandle_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenshotHandle_0;

		// Token: 0x04001235 RID: 4661
		[FieldOffset(0)]
		public uint m_ScreenshotHandle;
	}
}
