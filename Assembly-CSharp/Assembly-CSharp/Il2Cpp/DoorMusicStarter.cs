using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000B8 RID: 184
	public class DoorMusicStarter : MonoBehaviour
	{
		// Token: 0x06001650 RID: 5712 RVA: 0x000732B4 File Offset: 0x000714B4
		// Note: this type is marked as 'beforefieldinit'.
		static DoorMusicStarter()
		{
			Il2CppClassPointerStore<DoorMusicStarter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DoorMusicStarter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorMusicStarter>.NativeClassPtr);
			DoorMusicStarter.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorMusicStarter>.NativeClassPtr, 100665165);
			DoorMusicStarter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorMusicStarter>.NativeClassPtr, 100665166);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0007330C File Offset: 0x0007150C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55529, XrefRangeEnd = 55538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorMusicStarter.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00073340 File Offset: 0x00071540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorMusicStarter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorMusicStarter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorMusicStarter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00010235 File Offset: 0x0000E435
		public DoorMusicStarter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
