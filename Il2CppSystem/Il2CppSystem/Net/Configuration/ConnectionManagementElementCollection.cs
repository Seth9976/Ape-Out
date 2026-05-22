using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000179 RID: 377
	[DefaultMember("Item")]
	public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
	{
		// Token: 0x06001730 RID: 5936 RVA: 0x0000B975 File Offset: 0x00009B75
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionManagementElementCollection()
		{
			Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ConnectionManagementElementCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr);
			ConnectionManagementElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr, 100666532);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0006703C File Offset: 0x0006523C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388678, XrefRangeEnd = 388681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionManagementElementCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManagementElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0000B9AE File Offset: 0x00009BAE
		public ConnectionManagementElementCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
