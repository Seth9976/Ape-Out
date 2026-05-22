using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000165 RID: 357
	public class UnixIPGlobalProperties : CommonUnixIPGlobalProperties
	{
		// Token: 0x06001692 RID: 5778 RVA: 0x0000B2E9 File Offset: 0x000094E9
		// Note: this type is marked as 'beforefieldinit'.
		static UnixIPGlobalProperties()
		{
			Il2CppClassPointerStore<UnixIPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "UnixIPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnixIPGlobalProperties>.NativeClassPtr);
			UnixIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixIPGlobalProperties>.NativeClassPtr, 100666505);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00065C7C File Offset: 0x00063E7C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnixIPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnixIPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0000B322 File Offset: 0x00009522
		public UnixIPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
