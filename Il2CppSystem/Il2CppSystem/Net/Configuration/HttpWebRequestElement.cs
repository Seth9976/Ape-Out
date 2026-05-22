using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200017D RID: 381
	public sealed class HttpWebRequestElement : ConfigurationElement
	{
		// Token: 0x06001740 RID: 5952 RVA: 0x0006734C File Offset: 0x0006554C
		// Note: this type is marked as 'beforefieldinit'.
		static HttpWebRequestElement()
		{
			Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "HttpWebRequestElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr);
			HttpWebRequestElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr, 100666540);
			HttpWebRequestElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr, 100666541);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x000673A4 File Offset: 0x000655A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388702, XrefRangeEnd = 388705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequestElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequestElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x000673E0 File Offset: 0x000655E0
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388705, XrefRangeEnd = 388708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequestElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0000B9D2 File Offset: 0x00009BD2
		public HttpWebRequestElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
