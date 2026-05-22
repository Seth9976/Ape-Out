using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000182 RID: 386
	public sealed class ServicePointManagerElement : ConfigurationElement
	{
		// Token: 0x06001753 RID: 5971 RVA: 0x000676D8 File Offset: 0x000658D8
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePointManagerElement()
		{
			Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ServicePointManagerElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr);
			ServicePointManagerElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr, 100666549);
			ServicePointManagerElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr, 100666550);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00067730 File Offset: 0x00065930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388729, XrefRangeEnd = 388732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePointManagerElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManagerElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x0006776C File Offset: 0x0006596C
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388732, XrefRangeEnd = 388735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManagerElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0000BA38 File Offset: 0x00009C38
		public ServicePointManagerElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
