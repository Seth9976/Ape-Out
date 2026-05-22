using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Il2CppKlak.Timeline
{
	// Token: 0x020001E9 RID: 489
	[Serializable]
	public class AudioPreview : PlayableAsset
	{
		// Token: 0x0600191C RID: 6428 RVA: 0x000710A0 File Offset: 0x0006F2A0
		// Note: this type is marked as 'beforefieldinit'.
		static AudioPreview()
		{
			Il2CppClassPointerStore<AudioPreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Klak.Timeline", "AudioPreview");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPreview>.NativeClassPtr);
			AudioPreview.NativeFieldInfoPtr_template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioPreview>.NativeClassPtr, "template");
			AudioPreview.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreview>.NativeClassPtr, 100667027);
			AudioPreview.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreview>.NativeClassPtr, 100667028);
			AudioPreview.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreview>.NativeClassPtr, 100667029);
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x00071120 File Offset: 0x0006F320
		public unsafe virtual ClipCaps clipCaps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreview.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0007115C File Offset: 0x0006F35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20613, XrefRangeEnd = 20622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioPreview.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x000711C4 File Offset: 0x0006F3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20622, XrefRangeEnd = 20626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioPreview()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioPreview>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreview.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00009E51 File Offset: 0x00008051
		public AudioPreview(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x00071200 File Offset: 0x0006F400
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x00009E5A File Offset: 0x0000805A
		public unsafe AudioPreviewPlayable template
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreview.NativeFieldInfoPtr_template);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioPreviewPlayable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreview.NativeFieldInfoPtr_template), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeFieldInfoPtr_template;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
