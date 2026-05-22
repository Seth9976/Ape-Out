using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000160 RID: 352
	[Serializable]
	[StructLayout(2)]
	public struct HHTMLBrowser
	{
		// Token: 0x06000F1A RID: 3866 RVA: 0x0004B018 File Offset: 0x00049218
		// Note: this type is marked as 'beforefieldinit'.
		static HHTMLBrowser()
		{
			Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HHTMLBrowser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr);
			HHTMLBrowser.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, "Invalid");
			HHTMLBrowser.NativeFieldInfoPtr_m_HHTMLBrowser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, "m_HHTMLBrowser");
			HHTMLBrowser.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100665420);
			HHTMLBrowser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100665421);
			HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100665422);
			HHTMLBrowser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100665423);
			HHTMLBrowser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100665424);
			HHTMLBrowser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100665425);
			HHTMLBrowser.NativeMethodInfoPtr_op_Explicit_Public_Static_HHTMLBrowser_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100665426);
			HHTMLBrowser.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100665427);
			HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100665428);
			HHTMLBrowser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100665429);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0004B138 File Offset: 0x00049338
		[CallerCount(0)]
		public unsafe HHTMLBrowser(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0004B16C File Offset: 0x0004936C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0004B198 File Offset: 0x00049398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13354, XrefRangeEnd = 13358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0004B1DC File Offset: 0x000493DC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0004B20C File Offset: 0x0004940C
		[CallerCount(0)]
		public unsafe static bool operator ==(HHTMLBrowser x, HHTMLBrowser y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0004B258 File Offset: 0x00049458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13358, XrefRangeEnd = 13361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HHTMLBrowser x, HHTMLBrowser y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0004B2A4 File Offset: 0x000494A4
		[CallerCount(0)]
		public unsafe static explicit operator HHTMLBrowser(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Explicit_Public_Static_HHTMLBrowser_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0004B2E4 File Offset: 0x000494E4
		[CallerCount(0)]
		public unsafe static explicit operator uint(HHTMLBrowser that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0004B324 File Offset: 0x00049524
		[CallerCount(0)]
		public unsafe bool Equals(HHTMLBrowser other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HHTMLBrowser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0004B364 File Offset: 0x00049564
		[CallerCount(0)]
		public unsafe int CompareTo(HHTMLBrowser other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HHTMLBrowser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00006916 File Offset: 0x00004B16
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, ref this));
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x0004B3A4 File Offset: 0x000495A4
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x00006928 File Offset: 0x00004B28
		public unsafe static HHTMLBrowser Invalid
		{
			get
			{
				HHTMLBrowser hhtmlbrowser;
				IL2CPP.il2cpp_field_static_get_value(HHTMLBrowser.NativeFieldInfoPtr_Invalid, (void*)(&hhtmlbrowser));
				return hhtmlbrowser;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HHTMLBrowser.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeFieldInfoPtr_m_HHTMLBrowser;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HHTMLBrowser_UInt32_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HHTMLBrowser_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HHTMLBrowser_0;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HHTMLBrowser_0;

		// Token: 0x04001177 RID: 4471
		[FieldOffset(0)]
		public uint m_HHTMLBrowser;
	}
}
