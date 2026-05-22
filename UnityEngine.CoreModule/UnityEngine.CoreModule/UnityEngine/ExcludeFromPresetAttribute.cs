using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000CE RID: 206
	public class ExcludeFromPresetAttribute : Attribute
	{
		// Token: 0x0600126B RID: 4715 RVA: 0x0000AA94 File Offset: 0x00008C94
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromPresetAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExcludeFromPresetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr);
			ExcludeFromPresetAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr, 100664833);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0004AF18 File Offset: 0x00049118
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromPresetAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromPresetAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0000AACD File Offset: 0x00008CCD
		public ExcludeFromPresetAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
