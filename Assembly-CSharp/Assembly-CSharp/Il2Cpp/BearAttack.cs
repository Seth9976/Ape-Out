using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000073 RID: 115
	public class BearAttack : MonoBehaviour
	{
		// Token: 0x06000EBD RID: 3773 RVA: 0x0005F7A4 File Offset: 0x0005D9A4
		// Note: this type is marked as 'beforefieldinit'.
		static BearAttack()
		{
			Il2CppClassPointerStore<BearAttack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BearAttack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BearAttack>.NativeClassPtr);
			BearAttack.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearAttack>.NativeClassPtr, "state");
			BearAttack.NativeFieldInfoPtr_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearAttack>.NativeClassPtr, "legs");
			BearAttack.NativeFieldInfoPtr_attackDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearAttack>.NativeClassPtr, "attackDist");
			BearAttack.NativeFieldInfoPtr_hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearAttack>.NativeClassPtr, "hand");
			BearAttack.NativeFieldInfoPtr_swipeHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearAttack>.NativeClassPtr, "swipeHand");
			BearAttack.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearAttack>.NativeClassPtr, 100664559);
			BearAttack.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearAttack>.NativeClassPtr, 100664560);
			BearAttack.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearAttack>.NativeClassPtr, 100664561);
			BearAttack.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearAttack>.NativeClassPtr, 100664562);
			BearAttack.NativeMethodInfoPtr_Swipe_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearAttack>.NativeClassPtr, 100664563);
			BearAttack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearAttack>.NativeClassPtr, 100664564);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0005F8B0 File Offset: 0x0005DAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45656, XrefRangeEnd = 45662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearAttack.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0005F8E4 File Offset: 0x0005DAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45662, XrefRangeEnd = 45677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearAttack.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0005F918 File Offset: 0x0005DB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45677, XrefRangeEnd = 45686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearAttack.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0005F94C File Offset: 0x0005DB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45686, XrefRangeEnd = 45708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearAttack.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0005F980 File Offset: 0x0005DB80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45749, RefRangeEnd = 45750, XrefRangeStart = 45708, XrefRangeEnd = 45749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Swipe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearAttack.NativeMethodInfoPtr_Swipe_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0005F9B4 File Offset: 0x0005DBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BearAttack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BearAttack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearAttack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0000B11E File Offset: 0x0000931E
		public BearAttack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x0005F9F0 File Offset: 0x0005DBF0
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x0000B127 File Offset: 0x00009327
		public unsafe BearState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearAttack.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BearState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearAttack.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0005FA20 File Offset: 0x0005DC20
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x0000B146 File Offset: 0x00009346
		public unsafe Legs legs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearAttack.NativeFieldInfoPtr_legs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Legs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearAttack.NativeFieldInfoPtr_legs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0005FA50 File Offset: 0x0005DC50
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x0000B165 File Offset: 0x00009365
		public unsafe float attackDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearAttack.NativeFieldInfoPtr_attackDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearAttack.NativeFieldInfoPtr_attackDist)) = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x0005FA78 File Offset: 0x0005DC78
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x0000B180 File Offset: 0x00009380
		public unsafe Il2CppReferenceArray<GameObject> hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearAttack.NativeFieldInfoPtr_hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearAttack.NativeFieldInfoPtr_hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x0005FAA8 File Offset: 0x0005DCA8
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x0000B19F File Offset: 0x0000939F
		public unsafe int swipeHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearAttack.NativeFieldInfoPtr_swipeHand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearAttack.NativeFieldInfoPtr_swipeHand)) = value;
			}
		}

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeFieldInfoPtr_legs;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeFieldInfoPtr_attackDist;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeFieldInfoPtr_hand;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr_swipeHand;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_Swipe_Public_Void_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
