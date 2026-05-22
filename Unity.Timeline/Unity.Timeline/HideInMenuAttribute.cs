using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x02000042 RID: 66
	public class HideInMenuAttribute : Attribute
	{
		// Token: 0x060004AE RID: 1198 RVA: 0x0000386D File Offset: 0x00001A6D
		// Note: this type is marked as 'beforefieldinit'.
		static HideInMenuAttribute()
		{
			Il2CppClassPointerStore<HideInMenuAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "HideInMenuAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideInMenuAttribute>.NativeClassPtr);
			HideInMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideInMenuAttribute>.NativeClassPtr, 100664072);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00016DA4 File Offset: 0x00014FA4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HideInMenuAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideInMenuAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideInMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000038A6 File Offset: 0x00001AA6
		public HideInMenuAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
