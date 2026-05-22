using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000143 RID: 323
	public class OfficeViewManager : MonoBehaviour
	{
		// Token: 0x06002705 RID: 9989 RVA: 0x000A0B78 File Offset: 0x0009ED78
		// Note: this type is marked as 'beforefieldinit'.
		static OfficeViewManager()
		{
			Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OfficeViewManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr);
			OfficeViewManager.NativeFieldInfoPtr_street = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "street");
			OfficeViewManager.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "defPos");
			OfficeViewManager.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "startFlag");
			OfficeViewManager.NativeFieldInfoPtr_paramount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "paramount");
			OfficeViewManager.NativeFieldInfoPtr_buildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "buildings");
			OfficeViewManager.NativeFieldInfoPtr_skybridges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "skybridges");
			OfficeViewManager.NativeFieldInfoPtr_streetDad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "streetDad");
			OfficeViewManager.NativeFieldInfoPtr_visRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "visRange");
			OfficeViewManager.NativeFieldInfoPtr_streetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "streetOffset");
			OfficeViewManager.NativeFieldInfoPtr_redPosArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "redPosArr");
			OfficeViewManager.NativeFieldInfoPtr_bluePosArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "bluePosArr");
			OfficeViewManager.NativeFieldInfoPtr_redPosID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "redPosID");
			OfficeViewManager.NativeFieldInfoPtr_bluePosID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "bluePosID");
			OfficeViewManager.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "on");
			OfficeViewManager.NativeFieldInfoPtr_prevFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, "prevFloor");
			OfficeViewManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, 100666444);
			OfficeViewManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, 100666445);
			OfficeViewManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, 100666446);
			OfficeViewManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, 100666447);
			OfficeViewManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr, 100666448);
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000A0D38 File Offset: 0x0009EF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75334, XrefRangeEnd = 75377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeViewManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000A0D6C File Offset: 0x0009EF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75377, XrefRangeEnd = 75431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeViewManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x000A0DA0 File Offset: 0x0009EFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75431, XrefRangeEnd = 75433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeViewManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x000A0DD4 File Offset: 0x0009EFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75433, XrefRangeEnd = 75453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeViewManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x000A0E08 File Offset: 0x0009F008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75453, XrefRangeEnd = 75469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfficeViewManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfficeViewManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeViewManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x0001B261 File Offset: 0x00019461
		public OfficeViewManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x000A0E44 File Offset: 0x0009F044
		// (set) Token: 0x0600270D RID: 9997 RVA: 0x0001B26A File Offset: 0x0001946A
		public unsafe GameObject street
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_street);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_street), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x000A0E74 File Offset: 0x0009F074
		// (set) Token: 0x0600270F RID: 9999 RVA: 0x0001B289 File Offset: 0x00019489
		public unsafe Vector2 defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_defPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_defPos)) = value;
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x000A0E9C File Offset: 0x0009F09C
		// (set) Token: 0x06002711 RID: 10001 RVA: 0x0001B2A4 File Offset: 0x000194A4
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x000A0EC4 File Offset: 0x0009F0C4
		// (set) Token: 0x06002713 RID: 10003 RVA: 0x0001B2BF File Offset: 0x000194BF
		public unsafe float paramount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_paramount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_paramount)) = value;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x000A0EEC File Offset: 0x0009F0EC
		// (set) Token: 0x06002715 RID: 10005 RVA: 0x0001B2DA File Offset: 0x000194DA
		public unsafe Il2CppReferenceArray<BuildingDrawer> buildings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_buildings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BuildingDrawer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_buildings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x000A0F1C File Offset: 0x0009F11C
		// (set) Token: 0x06002717 RID: 10007 RVA: 0x0001B2F9 File Offset: 0x000194F9
		public unsafe Il2CppReferenceArray<SkyBridgeDrawer> skybridges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_skybridges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkyBridgeDrawer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_skybridges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x000A0F4C File Offset: 0x0009F14C
		// (set) Token: 0x06002719 RID: 10009 RVA: 0x0001B318 File Offset: 0x00019518
		public unsafe Transform streetDad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_streetDad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_streetDad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x000A0F7C File Offset: 0x0009F17C
		// (set) Token: 0x0600271B RID: 10011 RVA: 0x0001B337 File Offset: 0x00019537
		public unsafe Il2CppStructArray<float> visRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_visRange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_visRange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x000A0FAC File Offset: 0x0009F1AC
		// (set) Token: 0x0600271D RID: 10013 RVA: 0x0001B356 File Offset: 0x00019556
		public unsafe float streetOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_streetOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_streetOffset)) = value;
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x000A0FD4 File Offset: 0x0009F1D4
		// (set) Token: 0x0600271F RID: 10015 RVA: 0x0001B371 File Offset: 0x00019571
		public unsafe Il2CppStructArray<float> redPosArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_redPosArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_redPosArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06002720 RID: 10016 RVA: 0x000A1004 File Offset: 0x0009F204
		// (set) Token: 0x06002721 RID: 10017 RVA: 0x0001B390 File Offset: 0x00019590
		public unsafe Il2CppStructArray<float> bluePosArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_bluePosArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_bluePosArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x000A1034 File Offset: 0x0009F234
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x0001B3AF File Offset: 0x000195AF
		public unsafe int redPosID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_redPosID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_redPosID)) = value;
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x000A105C File Offset: 0x0009F25C
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x0001B3CA File Offset: 0x000195CA
		public unsafe int bluePosID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_bluePosID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_bluePosID)) = value;
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x000A1084 File Offset: 0x0009F284
		// (set) Token: 0x06002727 RID: 10023 RVA: 0x0001B3E5 File Offset: 0x000195E5
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x000A10AC File Offset: 0x0009F2AC
		// (set) Token: 0x06002729 RID: 10025 RVA: 0x0001B400 File Offset: 0x00019600
		public unsafe int prevFloor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_prevFloor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeViewManager.NativeFieldInfoPtr_prevFloor)) = value;
			}
		}

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeFieldInfoPtr_street;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeFieldInfoPtr_paramount;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeFieldInfoPtr_buildings;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeFieldInfoPtr_skybridges;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeFieldInfoPtr_streetDad;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeFieldInfoPtr_visRange;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeFieldInfoPtr_streetOffset;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeFieldInfoPtr_redPosArr;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeFieldInfoPtr_bluePosArr;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeFieldInfoPtr_redPosID;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeFieldInfoPtr_bluePosID;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeFieldInfoPtr_prevFloor;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
