using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001BF RID: 447
	public class SwingyDoorMusicStarter : MonoBehaviour
	{
		// Token: 0x06003148 RID: 12616 RVA: 0x000BBEC4 File Offset: 0x000BA0C4
		// Note: this type is marked as 'beforefieldinit'.
		static SwingyDoorMusicStarter()
		{
			Il2CppClassPointerStore<SwingyDoorMusicStarter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SwingyDoorMusicStarter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwingyDoorMusicStarter>.NativeClassPtr);
			SwingyDoorMusicStarter.NativeFieldInfoPtr_door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoorMusicStarter>.NativeClassPtr, "door");
			SwingyDoorMusicStarter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingyDoorMusicStarter>.NativeClassPtr, 100667155);
			SwingyDoorMusicStarter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingyDoorMusicStarter>.NativeClassPtr, 100667156);
			SwingyDoorMusicStarter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingyDoorMusicStarter>.NativeClassPtr, 100667157);
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x000BBF44 File Offset: 0x000BA144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85197, XrefRangeEnd = 85200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingyDoorMusicStarter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x000BBF78 File Offset: 0x000BA178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85200, XrefRangeEnd = 85211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingyDoorMusicStarter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x000BBFAC File Offset: 0x000BA1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwingyDoorMusicStarter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwingyDoorMusicStarter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingyDoorMusicStarter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x00021CD5 File Offset: 0x0001FED5
		public SwingyDoorMusicStarter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x0600314D RID: 12621 RVA: 0x000BBFE8 File Offset: 0x000BA1E8
		// (set) Token: 0x0600314E RID: 12622 RVA: 0x00021CDE File Offset: 0x0001FEDE
		public unsafe SwingyDoor door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoorMusicStarter.NativeFieldInfoPtr_door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SwingyDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoorMusicStarter.NativeFieldInfoPtr_door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeFieldInfoPtr_door;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
