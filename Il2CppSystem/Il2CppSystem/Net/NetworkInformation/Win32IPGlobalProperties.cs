using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000168 RID: 360
	public class Win32IPGlobalProperties : IPGlobalProperties
	{
		// Token: 0x060016AA RID: 5802 RVA: 0x00065FB8 File Offset: 0x000641B8
		// Note: this type is marked as 'beforefieldinit'.
		static Win32IPGlobalProperties()
		{
			Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32IPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr);
			Win32IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr, 100666510);
			Win32IPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr, 100666511);
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x00066010 File Offset: 0x00064210
		public unsafe override string DomainName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388600, XrefRangeEnd = 388601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Win32IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00066054 File Offset: 0x00064254
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32IPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32IPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0000B409 File Offset: 0x00009609
		public Win32IPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
