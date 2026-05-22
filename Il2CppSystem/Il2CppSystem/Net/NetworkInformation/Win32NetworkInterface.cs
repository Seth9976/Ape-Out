using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000169 RID: 361
	public class Win32NetworkInterface : Object
	{
		// Token: 0x060016AE RID: 5806 RVA: 0x00066090 File Offset: 0x00064290
		// Note: this type is marked as 'beforefieldinit'.
		static Win32NetworkInterface()
		{
			Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32NetworkInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr);
			Win32NetworkInterface.NativeFieldInfoPtr_fixedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, "fixedInfo");
			Win32NetworkInterface.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, "initialized");
			Win32NetworkInterface.NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100666512);
			Win32NetworkInterface.NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100666513);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00066110 File Offset: 0x00064310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388601, XrefRangeEnd = 388604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNetworkParams(IntPtr ptr, ref int size)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32NetworkInterface.NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x0006615C File Offset: 0x0006435C
		public unsafe static Win32_FIXED_INFO FixedInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 388634, RefRangeEnd = 388635, XrefRangeStart = 388604, XrefRangeEnd = 388634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32NetworkInterface.NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Win32_FIXED_INFO(intPtr);
			}
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0000B412 File Offset: 0x00009612
		public Win32NetworkInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00066188 File Offset: 0x00064388
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x0000B41B File Offset: 0x0000961B
		public unsafe static Win32_FIXED_INFO fixedInfo
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Win32NetworkInterface.NativeFieldInfoPtr_fixedInfo, intPtr);
				return new Win32_FIXED_INFO(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Win32NetworkInterface.NativeFieldInfoPtr_fixedInfo, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x000661C4 File Offset: 0x000643C4
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x0000B432 File Offset: 0x00009632
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Win32NetworkInterface.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Win32NetworkInterface.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeFieldInfoPtr_fixedInfo;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0;
	}
}
