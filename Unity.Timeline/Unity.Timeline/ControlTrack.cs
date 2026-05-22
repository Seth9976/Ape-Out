using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Timeline
{
	// Token: 0x02000019 RID: 25
	public class ControlTrack : TrackAsset
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x00002F88 File Offset: 0x00001188
		// Note: this type is marked as 'beforefieldinit'.
		static ControlTrack()
		{
			Il2CppClassPointerStore<ControlTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ControlTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlTrack>.NativeClassPtr);
			ControlTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlTrack>.NativeClassPtr, 100663813);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00010150 File Offset: 0x0000E350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477510, XrefRangeEnd = 477514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlTrack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002FC1 File Offset: 0x000011C1
		public ControlTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
