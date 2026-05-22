using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000095 RID: 149
	public class BunkerIntro : MonoBehaviour
	{
		// Token: 0x060011D8 RID: 4568 RVA: 0x00067924 File Offset: 0x00065B24
		// Note: this type is marked as 'beforefieldinit'.
		static BunkerIntro()
		{
			Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BunkerIntro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr);
			BunkerIntro.NativeFieldInfoPtr_introObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "introObj");
			BunkerIntro.NativeFieldInfoPtr_clouds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "clouds");
			BunkerIntro.NativeFieldInfoPtr_dropped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "dropped");
			BunkerIntro.NativeFieldInfoPtr_bombFall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "bombFall");
			BunkerIntro.NativeFieldInfoPtr_moveLeftTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "moveLeftTimer");
			BunkerIntro.NativeFieldInfoPtr_lockPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "lockPos");
			BunkerIntro.NativeFieldInfoPtr_destPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "destPos");
			BunkerIntro.NativeFieldInfoPtr_animTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "animTimer");
			BunkerIntro.NativeFieldInfoPtr_camCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "camCurve");
			BunkerIntro.NativeFieldInfoPtr_grimeScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "grimeScroll");
			BunkerIntro.NativeFieldInfoPtr_skyMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "skyMat");
			BunkerIntro.NativeFieldInfoPtr_cloudMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "cloudMat");
			BunkerIntro.NativeFieldInfoPtr_fakeCamY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "fakeCamY");
			BunkerIntro.NativeFieldInfoPtr_blip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "blip");
			BunkerIntro.NativeFieldInfoPtr_camSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "camSpd");
			BunkerIntro.NativeFieldInfoPtr_blownUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "blownUp");
			BunkerIntro.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "started");
			BunkerIntro.NativeFieldInfoPtr_curPathPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "curPathPt");
			BunkerIntro.NativeFieldInfoPtr_squadMover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "squadMover");
			BunkerIntro.NativeFieldInfoPtr_leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "leader");
			BunkerIntro.NativeFieldInfoPtr_prevShad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "prevShad");
			BunkerIntro.NativeFieldInfoPtr_blackScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "blackScreen");
			BunkerIntro.NativeFieldInfoPtr_addedToSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "addedToSearch");
			BunkerIntro.NativeFieldInfoPtr_delay13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "delay13");
			BunkerIntro.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, 100664798);
			BunkerIntro.NativeMethodInfoPtr_DoShit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, 100664799);
			BunkerIntro.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, 100664800);
			BunkerIntro.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, 100664801);
			BunkerIntro.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, 100664802);
			BunkerIntro.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, 100664803);
			BunkerIntro.NativeMethodInfoPtr_DroppedBomb_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, 100664804);
			BunkerIntro.NativeMethodInfoPtr_DropBombInASec_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, 100664805);
			BunkerIntro.NativeMethodInfoPtr_BlownUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, 100664806);
			BunkerIntro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, 100664807);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00067BFC File Offset: 0x00065DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49307, XrefRangeEnd = 49316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00067C30 File Offset: 0x00065E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49316, XrefRangeEnd = 49319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro.NativeMethodInfoPtr_DoShit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00067C70 File Offset: 0x00065E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49319, XrefRangeEnd = 49334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00067CA4 File Offset: 0x00065EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49334, XrefRangeEnd = 49343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00067CD8 File Offset: 0x00065ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49343, XrefRangeEnd = 49432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00067D0C File Offset: 0x00065F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49432, XrefRangeEnd = 49534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00067D40 File Offset: 0x00065F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49534, XrefRangeEnd = 49542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DroppedBomb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro.NativeMethodInfoPtr_DroppedBomb_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00067D74 File Offset: 0x00065F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49542, XrefRangeEnd = 49545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DropBombInASec()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro.NativeMethodInfoPtr_DropBombInASec_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00067DB4 File Offset: 0x00065FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49545, XrefRangeEnd = 49621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlownUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro.NativeMethodInfoPtr_BlownUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00067DE8 File Offset: 0x00065FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49621, XrefRangeEnd = 49627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BunkerIntro()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0000D19C File Offset: 0x0000B39C
		public BunkerIntro(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00067E24 File Offset: 0x00066024
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x0000D1A5 File Offset: 0x0000B3A5
		public unsafe GameObject introObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_introObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_introObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00067E54 File Offset: 0x00066054
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x0000D1C4 File Offset: 0x0000B3C4
		public unsafe Il2CppReferenceArray<Cloud> clouds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_clouds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Cloud>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_clouds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00067E84 File Offset: 0x00066084
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x0000D1E3 File Offset: 0x0000B3E3
		public unsafe bool dropped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_dropped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_dropped)) = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x00067EAC File Offset: 0x000660AC
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x0000D1FE File Offset: 0x0000B3FE
		public unsafe AudioSource bombFall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_bombFall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_bombFall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x00067EDC File Offset: 0x000660DC
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x0000D21D File Offset: 0x0000B41D
		public unsafe float moveLeftTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_moveLeftTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_moveLeftTimer)) = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00067F04 File Offset: 0x00066104
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x0000D238 File Offset: 0x0000B438
		public unsafe Vector2 lockPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_lockPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_lockPos)) = value;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00067F2C File Offset: 0x0006612C
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x0000D253 File Offset: 0x0000B453
		public unsafe Vector2 destPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_destPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_destPos)) = value;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x00067F54 File Offset: 0x00066154
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0000D26E File Offset: 0x0000B46E
		public unsafe float animTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_animTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_animTimer)) = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00067F7C File Offset: 0x0006617C
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0000D289 File Offset: 0x0000B489
		public unsafe AnimationCurve camCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_camCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_camCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00067FAC File Offset: 0x000661AC
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		public unsafe bool grimeScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_grimeScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_grimeScroll)) = value;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x00067FD4 File Offset: 0x000661D4
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x0000D2C3 File Offset: 0x0000B4C3
		public unsafe Material skyMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_skyMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_skyMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x00068004 File Offset: 0x00066204
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x0000D2E2 File Offset: 0x0000B4E2
		public unsafe Material cloudMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_cloudMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_cloudMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x00068034 File Offset: 0x00066234
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x0000D301 File Offset: 0x0000B501
		public unsafe float fakeCamY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_fakeCamY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_fakeCamY)) = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0006805C File Offset: 0x0006625C
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0000D31C File Offset: 0x0000B51C
		public unsafe int blip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_blip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_blip)) = value;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x00068084 File Offset: 0x00066284
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x0000D337 File Offset: 0x0000B537
		public unsafe float camSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_camSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_camSpd)) = value;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x000680AC File Offset: 0x000662AC
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x0000D352 File Offset: 0x0000B552
		public unsafe bool blownUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_blownUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_blownUp)) = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000680D4 File Offset: 0x000662D4
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x0000D36D File Offset: 0x0000B56D
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x000680FC File Offset: 0x000662FC
		// (set) Token: 0x06001207 RID: 4615 RVA: 0x0000D388 File Offset: 0x0000B588
		public unsafe int curPathPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_curPathPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_curPathPt)) = value;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x00068124 File Offset: 0x00066324
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x0000D3A3 File Offset: 0x0000B5A3
		public unsafe Mover squadMover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_squadMover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mover>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_squadMover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x00068154 File Offset: 0x00066354
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x0000D3C2 File Offset: 0x0000B5C2
		public unsafe GuardState leader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_leader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_leader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x00068184 File Offset: 0x00066384
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x0000D3E1 File Offset: 0x0000B5E1
		public unsafe Vector2 prevShad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_prevShad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_prevShad)) = value;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000681AC File Offset: 0x000663AC
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		public unsafe GameObject blackScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_blackScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_blackScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x000681DC File Offset: 0x000663DC
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x0000D41B File Offset: 0x0000B61B
		public unsafe bool addedToSearch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_addedToSearch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_addedToSearch)) = value;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x00068204 File Offset: 0x00066404
		// (set) Token: 0x06001213 RID: 4627 RVA: 0x0000D436 File Offset: 0x0000B636
		public unsafe WaitForSeconds delay13
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_delay13);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro.NativeFieldInfoPtr_delay13), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr_introObj;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeFieldInfoPtr_clouds;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeFieldInfoPtr_dropped;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeFieldInfoPtr_bombFall;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeFieldInfoPtr_moveLeftTimer;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeFieldInfoPtr_lockPos;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr_destPos;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeFieldInfoPtr_animTimer;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_camCurve;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr_grimeScroll;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_skyMat;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_cloudMat;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr_fakeCamY;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeFieldInfoPtr_blip;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr_camSpd;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeFieldInfoPtr_blownUp;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_curPathPt;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_squadMover;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr_leader;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_prevShad;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr_blackScreen;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_addedToSearch;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr_delay13;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr_DoShit_Private_IEnumerator_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_DroppedBomb_Public_Void_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_DropBombInASec_Private_IEnumerator_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_BlownUp_Public_Void_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002DE RID: 734
		[ObfuscatedName("BunkerIntro+<DoShit>d__25")]
		public sealed class _DoShit_d__25 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D86 RID: 19846 RVA: 0x0011CB64 File Offset: 0x0011AD64
			// Note: this type is marked as 'beforefieldinit'.
			static _DoShit_d__25()
			{
				Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "<DoShit>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr);
				BunkerIntro._DoShit_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr, "<>1__state");
				BunkerIntro._DoShit_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr, "<>2__current");
				BunkerIntro._DoShit_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr, "<>4__this");
				BunkerIntro._DoShit_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr, 100664808);
				BunkerIntro._DoShit_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr, 100664809);
				BunkerIntro._DoShit_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr, 100664810);
				BunkerIntro._DoShit_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr, 100664811);
				BunkerIntro._DoShit_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr, 100664812);
				BunkerIntro._DoShit_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr, 100664813);
			}

			// Token: 0x06004D87 RID: 19847 RVA: 0x0011CC44 File Offset: 0x0011AE44
			[CallerCount(0)]
			public unsafe _DoShit_d__25(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerIntro._DoShit_d__25>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DoShit_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D88 RID: 19848 RVA: 0x0011CC8C File Offset: 0x0011AE8C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DoShit_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D89 RID: 19849 RVA: 0x0011CCC0 File Offset: 0x0011AEC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49271, XrefRangeEnd = 49293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DoShit_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C40 RID: 7232
			// (get) Token: 0x06004D8A RID: 19850 RVA: 0x0011CCFC File Offset: 0x0011AEFC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DoShit_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D8B RID: 19851 RVA: 0x0011CD3C File Offset: 0x0011AF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49293, XrefRangeEnd = 49298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DoShit_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C41 RID: 7233
			// (get) Token: 0x06004D8C RID: 19852 RVA: 0x0011CD70 File Offset: 0x0011AF70
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DoShit_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D8D RID: 19853 RVA: 0x0002D8D3 File Offset: 0x0002BAD3
			public _DoShit_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C3D RID: 7229
			// (get) Token: 0x06004D8E RID: 19854 RVA: 0x0011CDB0 File Offset: 0x0011AFB0
			// (set) Token: 0x06004D8F RID: 19855 RVA: 0x0002D8DC File Offset: 0x0002BADC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro._DoShit_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro._DoShit_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C3E RID: 7230
			// (get) Token: 0x06004D90 RID: 19856 RVA: 0x0011CDD8 File Offset: 0x0011AFD8
			// (set) Token: 0x06004D91 RID: 19857 RVA: 0x0002D8F7 File Offset: 0x0002BAF7
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro._DoShit_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro._DoShit_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C3F RID: 7231
			// (get) Token: 0x06004D92 RID: 19858 RVA: 0x0011CE08 File Offset: 0x0011B008
			// (set) Token: 0x06004D93 RID: 19859 RVA: 0x0002D916 File Offset: 0x0002BB16
			public unsafe BunkerIntro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro._DoShit_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BunkerIntro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro._DoShit_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032C1 RID: 12993
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032C2 RID: 12994
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032C3 RID: 12995
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040032C4 RID: 12996
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032C5 RID: 12997
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032C6 RID: 12998
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032C7 RID: 12999
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032C8 RID: 13000
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032C9 RID: 13001
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002DF RID: 735
		[ObfuscatedName("BunkerIntro+<DropBombInASec>d__31")]
		public sealed class _DropBombInASec_d__31 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D94 RID: 19860 RVA: 0x0011CE38 File Offset: 0x0011B038
			// Note: this type is marked as 'beforefieldinit'.
			static _DropBombInASec_d__31()
			{
				Il2CppClassPointerStore<BunkerIntro._DropBombInASec_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BunkerIntro>.NativeClassPtr, "<DropBombInASec>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerIntro._DropBombInASec_d__31>.NativeClassPtr);
				BunkerIntro._DropBombInASec_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro._DropBombInASec_d__31>.NativeClassPtr, "<>1__state");
				BunkerIntro._DropBombInASec_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntro._DropBombInASec_d__31>.NativeClassPtr, "<>2__current");
				BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DropBombInASec_d__31>.NativeClassPtr, 100664814);
				BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DropBombInASec_d__31>.NativeClassPtr, 100664815);
				BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DropBombInASec_d__31>.NativeClassPtr, 100664816);
				BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DropBombInASec_d__31>.NativeClassPtr, 100664817);
				BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DropBombInASec_d__31>.NativeClassPtr, 100664818);
				BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntro._DropBombInASec_d__31>.NativeClassPtr, 100664819);
			}

			// Token: 0x06004D95 RID: 19861 RVA: 0x0011CF04 File Offset: 0x0011B104
			[CallerCount(0)]
			public unsafe _DropBombInASec_d__31(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerIntro._DropBombInASec_d__31>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D96 RID: 19862 RVA: 0x0011CF4C File Offset: 0x0011B14C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D97 RID: 19863 RVA: 0x0011CF80 File Offset: 0x0011B180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49298, XrefRangeEnd = 49302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C44 RID: 7236
			// (get) Token: 0x06004D98 RID: 19864 RVA: 0x0011CFBC File Offset: 0x0011B1BC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D99 RID: 19865 RVA: 0x0011CFFC File Offset: 0x0011B1FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49302, XrefRangeEnd = 49307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C45 RID: 7237
			// (get) Token: 0x06004D9A RID: 19866 RVA: 0x0011D030 File Offset: 0x0011B230
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntro._DropBombInASec_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D9B RID: 19867 RVA: 0x0002D935 File Offset: 0x0002BB35
			public _DropBombInASec_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C42 RID: 7234
			// (get) Token: 0x06004D9C RID: 19868 RVA: 0x0011D070 File Offset: 0x0011B270
			// (set) Token: 0x06004D9D RID: 19869 RVA: 0x0002D93E File Offset: 0x0002BB3E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro._DropBombInASec_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro._DropBombInASec_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C43 RID: 7235
			// (get) Token: 0x06004D9E RID: 19870 RVA: 0x0011D098 File Offset: 0x0011B298
			// (set) Token: 0x06004D9F RID: 19871 RVA: 0x0002D959 File Offset: 0x0002BB59
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro._DropBombInASec_d__31.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntro._DropBombInASec_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032CA RID: 13002
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032CB RID: 13003
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032CC RID: 13004
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032CD RID: 13005
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032CE RID: 13006
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032CF RID: 13007
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032D0 RID: 13008
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032D1 RID: 13009
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
