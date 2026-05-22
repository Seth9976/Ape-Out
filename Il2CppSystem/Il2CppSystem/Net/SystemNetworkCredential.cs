using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E0 RID: 224
	public class SystemNetworkCredential : NetworkCredential
	{
		// Token: 0x06000C9E RID: 3230 RVA: 0x000405FC File Offset: 0x0003E7FC
		// Note: this type is marked as 'beforefieldinit'.
		static SystemNetworkCredential()
		{
			Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "SystemNetworkCredential");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr);
			SystemNetworkCredential.NativeFieldInfoPtr_defaultCredential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr, "defaultCredential");
			SystemNetworkCredential.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr, 100665147);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00040654 File Offset: 0x0003E854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376593, XrefRangeEnd = 376596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemNetworkCredential()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemNetworkCredential.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00006F57 File Offset: 0x00005157
		public SystemNetworkCredential(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00040690 File Offset: 0x0003E890
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x00006F60 File Offset: 0x00005160
		public unsafe static SystemNetworkCredential defaultCredential
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SystemNetworkCredential.NativeFieldInfoPtr_defaultCredential, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemNetworkCredential>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemNetworkCredential.NativeFieldInfoPtr_defaultCredential, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeFieldInfoPtr_defaultCredential;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
	}
}
