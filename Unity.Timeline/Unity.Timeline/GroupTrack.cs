using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002E RID: 46
	[Serializable]
	public class GroupTrack : TrackAsset
	{
		// Token: 0x060003FF RID: 1023 RVA: 0x00014338 File Offset: 0x00012538
		// Note: this type is marked as 'beforefieldinit'.
		static GroupTrack()
		{
			Il2CppClassPointerStore<GroupTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "GroupTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupTrack>.NativeClassPtr);
			GroupTrack.NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupTrack>.NativeClassPtr, 100663979);
			GroupTrack.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupTrack>.NativeClassPtr, 100663980);
			GroupTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupTrack>.NativeClassPtr, 100663981);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000143A4 File Offset: 0x000125A4
		[CallerCount(0)]
		public unsafe override bool CanCompileClips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GroupTrack.NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x000143EC File Offset: 0x000125EC
		public unsafe override IEnumerable<PlayableBinding> outputs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478434, XrefRangeEnd = 478438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GroupTrack.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayableBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00014438 File Offset: 0x00012638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478438, XrefRangeEnd = 478442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupTrack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00003455 File Offset: 0x00001655
		public GroupTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
