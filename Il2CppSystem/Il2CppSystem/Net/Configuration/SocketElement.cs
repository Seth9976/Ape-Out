using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000183 RID: 387
	public sealed class SocketElement : ConfigurationElement
	{
		// Token: 0x06001757 RID: 5975 RVA: 0x000677AC File Offset: 0x000659AC
		// Note: this type is marked as 'beforefieldinit'.
		static SocketElement()
		{
			Il2CppClassPointerStore<SocketElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "SocketElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketElement>.NativeClassPtr);
			SocketElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketElement>.NativeClassPtr, 100666551);
			SocketElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketElement>.NativeClassPtr, 100666552);
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00067804 File Offset: 0x00065A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388735, XrefRangeEnd = 388738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x00067840 File Offset: 0x00065A40
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388738, XrefRangeEnd = 388741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0000BA41 File Offset: 0x00009C41
		public SocketElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
