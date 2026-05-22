using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000177 RID: 375
	[DefaultMember("Item")]
	public sealed class BypassElementCollection : ConfigurationElementCollection
	{
		// Token: 0x0600172B RID: 5931 RVA: 0x0000B905 File Offset: 0x00009B05
		// Note: this type is marked as 'beforefieldinit'.
		static BypassElementCollection()
		{
			Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "BypassElementCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr);
			BypassElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr, 100666531);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00067000 File Offset: 0x00065200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388675, XrefRangeEnd = 388678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BypassElementCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0000B93E File Offset: 0x00009B3E
		public BypassElementCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
