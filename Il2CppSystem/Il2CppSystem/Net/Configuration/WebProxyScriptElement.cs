using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000184 RID: 388
	public sealed class WebProxyScriptElement : ConfigurationElement
	{
		// Token: 0x0600175B RID: 5979 RVA: 0x00067880 File Offset: 0x00065A80
		// Note: this type is marked as 'beforefieldinit'.
		static WebProxyScriptElement()
		{
			Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "WebProxyScriptElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr);
			WebProxyScriptElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr, 100666553);
			WebProxyScriptElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr, 100666554);
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x000678D8 File Offset: 0x00065AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388741, XrefRangeEnd = 388744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxyScriptElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxyScriptElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x00067914 File Offset: 0x00065B14
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388744, XrefRangeEnd = 388747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxyScriptElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0000BA4A File Offset: 0x00009C4A
		public WebProxyScriptElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
