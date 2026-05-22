using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000042 RID: 66
	public class SECTR_MusicTrigger : MonoBehaviour
	{
		// Token: 0x06000A6D RID: 2669 RVA: 0x00052E18 File Offset: 0x00051018
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_MusicTrigger()
		{
			Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_MusicTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr);
			SECTR_MusicTrigger.NativeFieldInfoPtr_activator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, "activator");
			SECTR_MusicTrigger.NativeFieldInfoPtr_Cue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, "Cue");
			SECTR_MusicTrigger.NativeFieldInfoPtr_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, "Loop");
			SECTR_MusicTrigger.NativeFieldInfoPtr_StopOnExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, "StopOnExit");
			SECTR_MusicTrigger.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, 100664154);
			SECTR_MusicTrigger.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, 100664155);
			SECTR_MusicTrigger.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, 100664156);
			SECTR_MusicTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, 100664157);
			SECTR_MusicTrigger.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, 100664158);
			SECTR_MusicTrigger.NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, 100664159);
			SECTR_MusicTrigger.NativeMethodInfoPtr__Play_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, 100664160);
			SECTR_MusicTrigger.NativeMethodInfoPtr__Stop_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, 100664161);
			SECTR_MusicTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr, 100664162);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00052F4C File Offset: 0x0005114C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39994, XrefRangeEnd = 39999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_MusicTrigger.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00052F80 File Offset: 0x00051180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39999, XrefRangeEnd = 40000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_MusicTrigger.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00052FB4 File Offset: 0x000511B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40000, XrefRangeEnd = 40029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_MusicTrigger.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00052FF8 File Offset: 0x000511F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40029, XrefRangeEnd = 40058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_MusicTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0005303C File Offset: 0x0005123C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40058, XrefRangeEnd = 40076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_MusicTrigger.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00053080 File Offset: 0x00051280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40076, XrefRangeEnd = 40096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit2D(Collider2D other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_MusicTrigger.NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x000530C4 File Offset: 0x000512C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40112, RefRangeEnd = 40115, XrefRangeStart = 40096, XrefRangeEnd = 40112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_MusicTrigger.NativeMethodInfoPtr__Play_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x000530F8 File Offset: 0x000512F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 40128, RefRangeEnd = 40133, XrefRangeStart = 40115, XrefRangeEnd = 40128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Stop(bool stopImmediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopImmediately;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_MusicTrigger.NativeMethodInfoPtr__Stop_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00053138 File Offset: 0x00051338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40133, XrefRangeEnd = 40136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_MusicTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_MusicTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_MusicTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00008961 File Offset: 0x00006B61
		public SECTR_MusicTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00053174 File Offset: 0x00051374
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x0000896A File Offset: 0x00006B6A
		public unsafe GameObject activator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_MusicTrigger.NativeFieldInfoPtr_activator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_MusicTrigger.NativeFieldInfoPtr_activator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x000531A4 File Offset: 0x000513A4
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00008989 File Offset: 0x00006B89
		public unsafe SECTR_AudioCue Cue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_MusicTrigger.NativeFieldInfoPtr_Cue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_MusicTrigger.NativeFieldInfoPtr_Cue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x000531D4 File Offset: 0x000513D4
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x000089A8 File Offset: 0x00006BA8
		public unsafe bool Loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_MusicTrigger.NativeFieldInfoPtr_Loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_MusicTrigger.NativeFieldInfoPtr_Loop)) = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x000531FC File Offset: 0x000513FC
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x000089C3 File Offset: 0x00006BC3
		public unsafe bool StopOnExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_MusicTrigger.NativeFieldInfoPtr_StopOnExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_MusicTrigger.NativeFieldInfoPtr_StopOnExit)) = value;
			}
		}

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeFieldInfoPtr_activator;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeFieldInfoPtr_Cue;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeFieldInfoPtr_Loop;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeFieldInfoPtr_StopOnExit;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr__Play_Private_Void_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr__Stop_Private_Void_Boolean_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
