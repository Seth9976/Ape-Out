using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000AB RID: 171
	public class HardwareControllerTemplateMap : ScriptableObject
	{
		// Token: 0x0600150F RID: 5391 RVA: 0x0007BC14 File Offset: 0x00079E14
		// Note: this type is marked as 'beforefieldinit'.
		static HardwareControllerTemplateMap()
		{
			Il2CppClassPointerStore<HardwareControllerTemplateMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "HardwareControllerTemplateMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareControllerTemplateMap>.NativeClassPtr);
			HardwareControllerTemplateMap.NativeMethodInfoPtr_get_Guid_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerTemplateMap>.NativeClassPtr, 100668294);
			HardwareControllerTemplateMap.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerTemplateMap>.NativeClassPtr, 100668295);
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x0007BC6C File Offset: 0x00079E6C
		public unsafe virtual Guid Guid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HardwareControllerTemplateMap.NativeMethodInfoPtr_get_Guid_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0007BCB4 File Offset: 0x00079EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareControllerTemplateMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareControllerTemplateMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerTemplateMap.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00009418 File Offset: 0x00007618
		public HardwareControllerTemplateMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_get_Guid_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
