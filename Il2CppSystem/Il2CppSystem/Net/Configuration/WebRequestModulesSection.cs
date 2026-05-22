using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000185 RID: 389
	public sealed class WebRequestModulesSection : ConfigurationSection
	{
		// Token: 0x0600175F RID: 5983 RVA: 0x00067954 File Offset: 0x00065B54
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestModulesSection()
		{
			Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "WebRequestModulesSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr);
			WebRequestModulesSection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr, 100666555);
			WebRequestModulesSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr, 100666556);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000679AC File Offset: 0x00065BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388747, XrefRangeEnd = 388750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestModulesSection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestModulesSection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x000679E8 File Offset: 0x00065BE8
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388750, XrefRangeEnd = 388753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestModulesSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0000BA53 File Offset: 0x00009C53
		public WebRequestModulesSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
