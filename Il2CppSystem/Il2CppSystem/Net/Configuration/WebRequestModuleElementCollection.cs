using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000186 RID: 390
	[DefaultMember("Item")]
	public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
	{
		// Token: 0x06001763 RID: 5987 RVA: 0x0000BA5C File Offset: 0x00009C5C
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestModuleElementCollection()
		{
			Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "WebRequestModuleElementCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr);
			WebRequestModuleElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr, 100666557);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00067A28 File Offset: 0x00065C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388753, XrefRangeEnd = 388756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestModuleElementCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestModuleElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0000BA95 File Offset: 0x00009C95
		public WebRequestModuleElementCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
