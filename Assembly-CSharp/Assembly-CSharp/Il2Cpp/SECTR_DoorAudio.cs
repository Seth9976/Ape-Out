using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000040 RID: 64
	public class SECTR_DoorAudio : MonoBehaviour
	{
		// Token: 0x06000A45 RID: 2629 RVA: 0x00052714 File Offset: 0x00050914
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_DoorAudio()
		{
			Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_DoorAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr);
			SECTR_DoorAudio.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, "instance");
			SECTR_DoorAudio.NativeFieldInfoPtr_OpenLoopCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, "OpenLoopCue");
			SECTR_DoorAudio.NativeFieldInfoPtr_ClosedLoopCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, "ClosedLoopCue");
			SECTR_DoorAudio.NativeFieldInfoPtr_OpeningCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, "OpeningCue");
			SECTR_DoorAudio.NativeFieldInfoPtr_ClosingCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, "ClosingCue");
			SECTR_DoorAudio.NativeFieldInfoPtr_WaitingCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, "WaitingCue");
			SECTR_DoorAudio.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, 100664141);
			SECTR_DoorAudio.NativeMethodInfoPtr_OnOpen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, 100664142);
			SECTR_DoorAudio.NativeMethodInfoPtr_OnOpening_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, 100664143);
			SECTR_DoorAudio.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, 100664144);
			SECTR_DoorAudio.NativeMethodInfoPtr_OnClosing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, 100664145);
			SECTR_DoorAudio.NativeMethodInfoPtr_OnWaiting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, 100664146);
			SECTR_DoorAudio.NativeMethodInfoPtr__Stop_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, 100664147);
			SECTR_DoorAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr, 100664148);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0005285C File Offset: 0x00050A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39857, XrefRangeEnd = 39861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DoorAudio.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00052890 File Offset: 0x00050A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39861, XrefRangeEnd = 39873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DoorAudio.NativeMethodInfoPtr_OnOpen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000528C4 File Offset: 0x00050AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39873, XrefRangeEnd = 39885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpening()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DoorAudio.NativeMethodInfoPtr_OnOpening_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000528F8 File Offset: 0x00050AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39885, XrefRangeEnd = 39897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DoorAudio.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0005292C File Offset: 0x00050B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39897, XrefRangeEnd = 39909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClosing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DoorAudio.NativeMethodInfoPtr_OnClosing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00052960 File Offset: 0x00050B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39909, XrefRangeEnd = 39921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWaiting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DoorAudio.NativeMethodInfoPtr_OnWaiting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00052994 File Offset: 0x00050B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39921, XrefRangeEnd = 39922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Stop(bool stopImmediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopImmediately;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DoorAudio.NativeMethodInfoPtr__Stop_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000529D4 File Offset: 0x00050BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_DoorAudio()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_DoorAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DoorAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000087D8 File Offset: 0x000069D8
		public SECTR_DoorAudio(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00052A10 File Offset: 0x00050C10
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x000087E1 File Offset: 0x000069E1
		public SECTR_AudioCueInstance instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_instance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_instance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00052A40 File Offset: 0x00050C40
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x0000880F File Offset: 0x00006A0F
		public unsafe SECTR_AudioCue OpenLoopCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_OpenLoopCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_OpenLoopCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00052A70 File Offset: 0x00050C70
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x0000882E File Offset: 0x00006A2E
		public unsafe SECTR_AudioCue ClosedLoopCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_ClosedLoopCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_ClosedLoopCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00052AA0 File Offset: 0x00050CA0
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x0000884D File Offset: 0x00006A4D
		public unsafe SECTR_AudioCue OpeningCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_OpeningCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_OpeningCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00052AD0 File Offset: 0x00050CD0
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0000886C File Offset: 0x00006A6C
		public unsafe SECTR_AudioCue ClosingCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_ClosingCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_ClosingCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00052B00 File Offset: 0x00050D00
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x0000888B File Offset: 0x00006A8B
		public unsafe SECTR_AudioCue WaitingCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_WaitingCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DoorAudio.NativeFieldInfoPtr_WaitingCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeFieldInfoPtr_OpenLoopCue;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeFieldInfoPtr_ClosedLoopCue;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeFieldInfoPtr_OpeningCue;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeFieldInfoPtr_ClosingCue;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeFieldInfoPtr_WaitingCue;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_OnOpen_Private_Void_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_OnOpening_Private_Void_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_OnClosing_Private_Void_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_OnWaiting_Private_Void_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr__Stop_Private_Void_Boolean_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
