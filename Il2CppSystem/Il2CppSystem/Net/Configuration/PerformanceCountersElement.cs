using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000181 RID: 385
	public sealed class PerformanceCountersElement : ConfigurationElement
	{
		// Token: 0x0600174F RID: 5967 RVA: 0x00067604 File Offset: 0x00065804
		// Note: this type is marked as 'beforefieldinit'.
		static PerformanceCountersElement()
		{
			Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "PerformanceCountersElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr);
			PerformanceCountersElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr, 100666547);
			PerformanceCountersElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr, 100666548);
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x0006765C File Offset: 0x0006585C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388723, XrefRangeEnd = 388726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerformanceCountersElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceCountersElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x00067698 File Offset: 0x00065898
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388726, XrefRangeEnd = 388729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceCountersElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0000BA2F File Offset: 0x00009C2F
		public PerformanceCountersElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
