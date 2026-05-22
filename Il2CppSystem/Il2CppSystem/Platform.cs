using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000044 RID: 68
	public static class Platform : Object
	{
		// Token: 0x060003E4 RID: 996 RVA: 0x000202B4 File Offset: 0x0001E4B4
		// Note: this type is marked as 'beforefieldinit'.
		static Platform()
		{
			Il2CppClassPointerStore<Platform>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "Platform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Platform>.NativeClassPtr);
			Platform.NativeFieldInfoPtr_checkedOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "checkedOS");
			Platform.NativeFieldInfoPtr_isMacOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "isMacOS");
			Platform.NativeFieldInfoPtr_isFreeBSD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "isFreeBSD");
			Platform.NativeMethodInfoPtr_uname_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Platform>.NativeClassPtr, 100663983);
			Platform.NativeMethodInfoPtr_CheckOS_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Platform>.NativeClassPtr, 100663984);
			Platform.NativeMethodInfoPtr_get_IsMacOS_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Platform>.NativeClassPtr, 100663985);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0002035C File Offset: 0x0001E55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369231, XrefRangeEnd = 369233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int uname(IntPtr buf)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buf;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Platform.NativeMethodInfoPtr_uname_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0002039C File Offset: 0x0001E59C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369267, RefRangeEnd = 369268, XrefRangeStart = 369233, XrefRangeEnd = 369267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckOS()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Platform.NativeMethodInfoPtr_CheckOS_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x000203C4 File Offset: 0x0001E5C4
		public unsafe static bool IsMacOS
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369268, XrefRangeEnd = 369274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Platform.NativeMethodInfoPtr_get_IsMacOS_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000359F File Offset: 0x0000179F
		public Platform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x000203F4 File Offset: 0x0001E5F4
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x000035A8 File Offset: 0x000017A8
		public unsafe static bool checkedOS
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Platform.NativeFieldInfoPtr_checkedOS, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Platform.NativeFieldInfoPtr_checkedOS, (void*)(&value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00020410 File Offset: 0x0001E610
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x000035B6 File Offset: 0x000017B6
		public unsafe static bool isMacOS
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Platform.NativeFieldInfoPtr_isMacOS, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Platform.NativeFieldInfoPtr_isMacOS, (void*)(&value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0002042C File Offset: 0x0001E62C
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x000035C4 File Offset: 0x000017C4
		public unsafe static bool isFreeBSD
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Platform.NativeFieldInfoPtr_isFreeBSD, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Platform.NativeFieldInfoPtr_isFreeBSD, (void*)(&value));
			}
		}

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_checkedOS;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_isMacOS;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_isFreeBSD;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_uname_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_CheckOS_Private_Static_Void_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMacOS_Public_Static_get_Boolean_0;
	}
}
