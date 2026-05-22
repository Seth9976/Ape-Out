using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002D RID: 45
	public static class TrackAssetExtensions : Object
	{
		// Token: 0x060003FB RID: 1019 RVA: 0x00014254 File Offset: 0x00012454
		// Note: this type is marked as 'beforefieldinit'.
		static TrackAssetExtensions()
		{
			Il2CppClassPointerStore<TrackAssetExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TrackAssetExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackAssetExtensions>.NativeClassPtr);
			TrackAssetExtensions.NativeMethodInfoPtr_GetGroup_Public_Static_GroupTrack_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAssetExtensions>.NativeClassPtr, 100663977);
			TrackAssetExtensions.NativeMethodInfoPtr_SetGroup_Public_Static_Void_TrackAsset_GroupTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAssetExtensions>.NativeClassPtr, 100663978);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000142AC File Offset: 0x000124AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478290, XrefRangeEnd = 478304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GroupTrack GetGroup(this TrackAsset asset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAssetExtensions.NativeMethodInfoPtr_GetGroup_Public_Static_GroupTrack_TrackAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GroupTrack>(intPtr3) : null;
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000142F0 File Offset: 0x000124F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478304, XrefRangeEnd = 478434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGroup(this TrackAsset asset, GroupTrack group)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAssetExtensions.NativeMethodInfoPtr_SetGroup_Public_Static_Void_TrackAsset_GroupTrack_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000344C File Offset: 0x0000164C
		public TrackAssetExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_GetGroup_Public_Static_GroupTrack_TrackAsset_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_SetGroup_Public_Static_Void_TrackAsset_GroupTrack_0;
	}
}
