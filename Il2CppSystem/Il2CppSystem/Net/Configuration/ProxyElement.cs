using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200017C RID: 380
	public sealed class ProxyElement : ConfigurationElement
	{
		// Token: 0x0600173C RID: 5948 RVA: 0x00067278 File Offset: 0x00065478
		// Note: this type is marked as 'beforefieldinit'.
		static ProxyElement()
		{
			Il2CppClassPointerStore<ProxyElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ProxyElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr);
			ProxyElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr, 100666538);
			ProxyElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr, 100666539);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x000672D0 File Offset: 0x000654D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388696, XrefRangeEnd = 388699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProxyElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x0006730C File Offset: 0x0006550C
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388699, XrefRangeEnd = 388702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0000B9C9 File Offset: 0x00009BC9
		public ProxyElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
