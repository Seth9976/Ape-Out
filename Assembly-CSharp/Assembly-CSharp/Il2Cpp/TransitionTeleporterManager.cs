using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001CC RID: 460
	public class TransitionTeleporterManager : MonoBehaviour
	{
		// Token: 0x06003271 RID: 12913 RVA: 0x000BED50 File Offset: 0x000BCF50
		// Note: this type is marked as 'beforefieldinit'.
		static TransitionTeleporterManager()
		{
			Il2CppClassPointerStore<TransitionTeleporterManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TransitionTeleporterManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionTeleporterManager>.NativeClassPtr);
			TransitionTeleporterManager.NativeFieldInfoPtr_dum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionTeleporterManager>.NativeClassPtr, "dum");
			TransitionTeleporterManager.NativeFieldInfoPtr_stair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionTeleporterManager>.NativeClassPtr, "stair");
			TransitionTeleporterManager.NativeFieldInfoPtr_loopSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionTeleporterManager>.NativeClassPtr, "loopSpot");
			TransitionTeleporterManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTeleporterManager>.NativeClassPtr, 100667220);
			TransitionTeleporterManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTeleporterManager>.NativeClassPtr, 100667221);
			TransitionTeleporterManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTeleporterManager>.NativeClassPtr, 100667222);
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x000BEDF8 File Offset: 0x000BCFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85794, XrefRangeEnd = 85797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionTeleporterManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x000BEE2C File Offset: 0x000BD02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85797, XrefRangeEnd = 85825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionTeleporterManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x000BEE60 File Offset: 0x000BD060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitionTeleporterManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionTeleporterManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionTeleporterManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00022991 File Offset: 0x00020B91
		public TransitionTeleporterManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06003276 RID: 12918 RVA: 0x000BEE9C File Offset: 0x000BD09C
		// (set) Token: 0x06003277 RID: 12919 RVA: 0x0002299A File Offset: 0x00020B9A
		public unsafe bool dum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionTeleporterManager.NativeFieldInfoPtr_dum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionTeleporterManager.NativeFieldInfoPtr_dum)) = value;
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x000BEEC4 File Offset: 0x000BD0C4
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x000229B5 File Offset: 0x00020BB5
		public unsafe Stairs stair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionTeleporterManager.NativeFieldInfoPtr_stair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stairs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionTeleporterManager.NativeFieldInfoPtr_stair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x000BEEF4 File Offset: 0x000BD0F4
		// (set) Token: 0x0600327B RID: 12923 RVA: 0x000229D4 File Offset: 0x00020BD4
		public unsafe Vector2 loopSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionTeleporterManager.NativeFieldInfoPtr_loopSpot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionTeleporterManager.NativeFieldInfoPtr_loopSpot)) = value;
			}
		}

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeFieldInfoPtr_dum;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeFieldInfoPtr_stair;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeFieldInfoPtr_loopSpot;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
