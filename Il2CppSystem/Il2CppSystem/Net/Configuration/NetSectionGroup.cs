using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200017F RID: 383
	public sealed class NetSectionGroup : ConfigurationSectionGroup
	{
		// Token: 0x06001748 RID: 5960 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		// Note: this type is marked as 'beforefieldinit'.
		static NetSectionGroup()
		{
			Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "NetSectionGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr);
			NetSectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr, 100666544);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000674F4 File Offset: 0x000656F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388714, XrefRangeEnd = 388717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetSectionGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetSectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x0000BA1D File Offset: 0x00009C1D
		public NetSectionGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
