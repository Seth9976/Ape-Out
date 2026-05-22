using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x02000084 RID: 132
	[Serializable]
	public class ControllerTemplateSpecialElementMapping : Object
	{
		// Token: 0x060010BA RID: 4282 RVA: 0x000075E5 File Offset: 0x000057E5
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateSpecialElementMapping()
		{
			Il2CppClassPointerStore<ControllerTemplateSpecialElementMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "ControllerTemplateSpecialElementMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateSpecialElementMapping>.NativeClassPtr);
			ControllerTemplateSpecialElementMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateSpecialElementMapping>.NativeClassPtr, 100666089);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0006C27C File Offset: 0x0006A47C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateSpecialElementMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateSpecialElementMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateSpecialElementMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0000761E File Offset: 0x0000581E
		public ControllerTemplateSpecialElementMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
