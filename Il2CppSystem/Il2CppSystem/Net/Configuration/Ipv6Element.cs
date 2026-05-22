using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200017E RID: 382
	public sealed class Ipv6Element : ConfigurationElement
	{
		// Token: 0x06001744 RID: 5956 RVA: 0x00067420 File Offset: 0x00065620
		// Note: this type is marked as 'beforefieldinit'.
		static Ipv6Element()
		{
			Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "Ipv6Element");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr);
			Ipv6Element.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr, 100666542);
			Ipv6Element.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr, 100666543);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00067478 File Offset: 0x00065678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388708, XrefRangeEnd = 388711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ipv6Element()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ipv6Element.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x000674B4 File Offset: 0x000656B4
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388711, XrefRangeEnd = 388714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ipv6Element.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0000B9DB File Offset: 0x00009BDB
		public Ipv6Element(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
