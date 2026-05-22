using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000097 RID: 151
	public class BunkerLightsUpper : MonoBehaviour
	{
		// Token: 0x0600121E RID: 4638 RVA: 0x000683C0 File Offset: 0x000665C0
		// Note: this type is marked as 'beforefieldinit'.
		static BunkerLightsUpper()
		{
			Il2CppClassPointerStore<BunkerLightsUpper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BunkerLightsUpper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerLightsUpper>.NativeClassPtr);
			BunkerLightsUpper.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerLightsUpper>.NativeClassPtr, "done");
			BunkerLightsUpper.NativeFieldInfoPtr_myLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerLightsUpper>.NativeClassPtr, "myLight");
			BunkerLightsUpper.NativeFieldInfoPtr_door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerLightsUpper>.NativeClassPtr, "door");
			BunkerLightsUpper.NativeFieldInfoPtr_outdoorShadowTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerLightsUpper>.NativeClassPtr, "outdoorShadowTex");
			BunkerLightsUpper.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerLightsUpper>.NativeClassPtr, 100664822);
			BunkerLightsUpper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerLightsUpper>.NativeClassPtr, 100664823);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00068468 File Offset: 0x00066668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49629, XrefRangeEnd = 49663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerLightsUpper.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0006849C File Offset: 0x0006669C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BunkerLightsUpper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerLightsUpper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerLightsUpper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0000D4AE File Offset: 0x0000B6AE
		public BunkerLightsUpper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x000684D8 File Offset: 0x000666D8
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x0000D4B7 File Offset: 0x0000B6B7
		public unsafe bool done
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerLightsUpper.NativeFieldInfoPtr_done);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerLightsUpper.NativeFieldInfoPtr_done)) = value;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00068500 File Offset: 0x00066700
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x0000D4D2 File Offset: 0x0000B6D2
		public unsafe GameObject myLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerLightsUpper.NativeFieldInfoPtr_myLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerLightsUpper.NativeFieldInfoPtr_myLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x00068530 File Offset: 0x00066730
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x0000D4F1 File Offset: 0x0000B6F1
		public unsafe BigDoor door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerLightsUpper.NativeFieldInfoPtr_door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerLightsUpper.NativeFieldInfoPtr_door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00068560 File Offset: 0x00066760
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x0000D510 File Offset: 0x0000B710
		public unsafe Texture outdoorShadowTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerLightsUpper.NativeFieldInfoPtr_outdoorShadowTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerLightsUpper.NativeFieldInfoPtr_outdoorShadowTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeFieldInfoPtr_done;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeFieldInfoPtr_myLight;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeFieldInfoPtr_door;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeFieldInfoPtr_outdoorShadowTex;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
