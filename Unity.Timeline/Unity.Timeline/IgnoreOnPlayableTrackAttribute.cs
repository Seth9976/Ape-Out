using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x02000040 RID: 64
	public class IgnoreOnPlayableTrackAttribute : Attribute
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x00003807 File Offset: 0x00001A07
		// Note: this type is marked as 'beforefieldinit'.
		static IgnoreOnPlayableTrackAttribute()
		{
			Il2CppClassPointerStore<IgnoreOnPlayableTrackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "IgnoreOnPlayableTrackAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnoreOnPlayableTrackAttribute>.NativeClassPtr);
			IgnoreOnPlayableTrackAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreOnPlayableTrackAttribute>.NativeClassPtr, 100664069);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00016C50 File Offset: 0x00014E50
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IgnoreOnPlayableTrackAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgnoreOnPlayableTrackAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreOnPlayableTrackAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00003840 File Offset: 0x00001A40
		public IgnoreOnPlayableTrackAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
