using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000027 RID: 39
	[Serializable]
	public class MarkerTrack : TrackAsset
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x00013604 File Offset: 0x00011804
		// Note: this type is marked as 'beforefieldinit'.
		static MarkerTrack()
		{
			Il2CppClassPointerStore<MarkerTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "MarkerTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkerTrack>.NativeClassPtr);
			MarkerTrack.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerTrack>.NativeClassPtr, 100663939);
			MarkerTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerTrack>.NativeClassPtr, 100663940);
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0001365C File Offset: 0x0001185C
		public unsafe override IEnumerable<PlayableBinding> outputs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478017, XrefRangeEnd = 478044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarkerTrack.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayableBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000136A8 File Offset: 0x000118A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478044, XrefRangeEnd = 478048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarkerTrack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarkerTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000331E File Offset: 0x0000151E
		public MarkerTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
