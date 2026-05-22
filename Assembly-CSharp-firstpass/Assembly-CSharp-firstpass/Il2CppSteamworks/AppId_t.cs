using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000171 RID: 369
	[Serializable]
	[StructLayout(2)]
	public struct AppId_t
	{
		// Token: 0x06000FFE RID: 4094 RVA: 0x0004ECE4 File Offset: 0x0004CEE4
		// Note: this type is marked as 'beforefieldinit'.
		static AppId_t()
		{
			Il2CppClassPointerStore<AppId_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AppId_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppId_t>.NativeClassPtr);
			AppId_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, "Invalid");
			AppId_t.NativeFieldInfoPtr_m_AppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, "m_AppId");
			AppId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100665602);
			AppId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100665603);
			AppId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100665604);
			AppId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100665605);
			AppId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AppId_t_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100665606);
			AppId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AppId_t_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100665607);
			AppId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_AppId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100665608);
			AppId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100665609);
			AppId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100665610);
			AppId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100665611);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0004EE04 File Offset: 0x0004D004
		[CallerCount(0)]
		public unsafe AppId_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0004EE38 File Offset: 0x0004D038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0004EE64 File Offset: 0x0004D064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13454, XrefRangeEnd = 13458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0004EEA8 File Offset: 0x0004D0A8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0004EED8 File Offset: 0x0004D0D8
		[CallerCount(0)]
		public unsafe static bool operator ==(AppId_t x, AppId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AppId_t_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0004EF24 File Offset: 0x0004D124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13458, XrefRangeEnd = 13461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(AppId_t x, AppId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AppId_t_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0004EF70 File Offset: 0x0004D170
		[CallerCount(0)]
		public unsafe static explicit operator AppId_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_AppId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0004EFB0 File Offset: 0x0004D1B0
		[CallerCount(0)]
		public unsafe static explicit operator uint(AppId_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0004EFF0 File Offset: 0x0004D1F0
		[CallerCount(0)]
		public unsafe bool Equals(AppId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AppId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0004F030 File Offset: 0x0004D230
		[CallerCount(0)]
		public unsafe int CompareTo(AppId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AppId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00006AFE File Offset: 0x00004CFE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x0004F070 File Offset: 0x0004D270
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x00006B10 File Offset: 0x00004D10
		public unsafe static AppId_t Invalid
		{
			get
			{
				AppId_t appId_t;
				IL2CPP.il2cpp_field_static_get_value(AppId_t.NativeFieldInfoPtr_Invalid, (void*)(&appId_t));
				return appId_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppId_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeFieldInfoPtr_m_AppId;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AppId_t_AppId_t_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AppId_t_AppId_t_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AppId_t_UInt32_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AppId_t_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AppId_t_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AppId_t_0;

		// Token: 0x0400124E RID: 4686
		[FieldOffset(0)]
		public uint m_AppId;
	}
}
