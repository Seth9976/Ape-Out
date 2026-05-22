using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200017A RID: 378
	public sealed class ConnectionManagementSection : ConfigurationSection
	{
		// Token: 0x06001733 RID: 5939 RVA: 0x00067078 File Offset: 0x00065278
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionManagementSection()
		{
			Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ConnectionManagementSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr);
			ConnectionManagementSection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr, 100666533);
			ConnectionManagementSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr, 100666534);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x000670D0 File Offset: 0x000652D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388681, XrefRangeEnd = 388684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionManagementSection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManagementSection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x0006710C File Offset: 0x0006530C
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388684, XrefRangeEnd = 388687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManagementSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0000B9B7 File Offset: 0x00009BB7
		public ConnectionManagementSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
