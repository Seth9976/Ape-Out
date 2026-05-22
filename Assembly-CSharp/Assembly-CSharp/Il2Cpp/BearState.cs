using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000076 RID: 118
	public class BearState : State
	{
		// Token: 0x06000F18 RID: 3864 RVA: 0x000607FC File Offset: 0x0005E9FC
		// Note: this type is marked as 'beforefieldinit'.
		static BearState()
		{
			Il2CppClassPointerStore<BearState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BearState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BearState>.NativeClassPtr);
			BearState.NativeFieldInfoPtr_mad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "mad");
			BearState.NativeFieldInfoPtr_attacking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "attacking");
			BearState.NativeFieldInfoPtr_chasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "chasing");
			BearState.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "target");
			BearState.NativeFieldInfoPtr_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "legs");
			BearState.NativeFieldInfoPtr_caged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "caged");
			BearState.NativeFieldInfoPtr_uncaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "uncaged");
			BearState.NativeFieldInfoPtr_cageTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "cageTimer");
			BearState.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "tags");
			BearState.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "snd");
			BearState.NativeFieldInfoPtr_tranqed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "tranqed");
			BearState.NativeFieldInfoPtr_tranqTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "tranqTimer");
			BearState.NativeFieldInfoPtr_layerOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "layerOffset");
			BearState.NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "movement");
			BearState.NativeFieldInfoPtr_startRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "startRan");
			BearState.NativeFieldInfoPtr_mySounder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearState>.NativeClassPtr, "mySounder");
			BearState.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664590);
			BearState.NativeMethodInfoPtr_OnCaged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664591);
			BearState.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664592);
			BearState.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664593);
			BearState.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664594);
			BearState.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664595);
			BearState.NativeMethodInfoPtr_Roar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664596);
			BearState.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664597);
			BearState.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664598);
			BearState.NativeMethodInfoPtr_OnUncaged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664599);
			BearState.NativeMethodInfoPtr_OnTranq_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664600);
			BearState.NativeMethodInfoPtr_StartNavigation_Public_Virtual_Void_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664601);
			BearState.NativeMethodInfoPtr_PathFailed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664602);
			BearState.NativeMethodInfoPtr_OnSeen_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664603);
			BearState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearState>.NativeClassPtr, 100664604);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00060A98 File Offset: 0x0005EC98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46331, RefRangeEnd = 46332, XrefRangeStart = 46306, XrefRangeEnd = 46331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearState.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00060ACC File Offset: 0x0005ECCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46332, XrefRangeEnd = 46335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCaged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearState.NativeMethodInfoPtr_OnCaged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00060B00 File Offset: 0x0005ED00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46335, XrefRangeEnd = 46350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearState.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00060B34 File Offset: 0x0005ED34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46350, XrefRangeEnd = 46359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearState.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00060B68 File Offset: 0x0005ED68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46359, XrefRangeEnd = 46393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearState.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00060B9C File Offset: 0x0005ED9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46393, XrefRangeEnd = 46442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearState.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00060BD0 File Offset: 0x0005EDD0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 46469, RefRangeEnd = 46474, XrefRangeStart = 46442, XrefRangeEnd = 46469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Roar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearState.NativeMethodInfoPtr_Roar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00060C04 File Offset: 0x0005EE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46474, XrefRangeEnd = 46521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShot(Il2CppStructArray<Vector2> pose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pose);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BearState.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00060C54 File Offset: 0x0005EE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46521, XrefRangeEnd = 46538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBlown(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BearState.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00060CA0 File Offset: 0x0005EEA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46540, RefRangeEnd = 46541, XrefRangeStart = 46538, XrefRangeEnd = 46540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUncaged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearState.NativeMethodInfoPtr_OnUncaged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00060CD4 File Offset: 0x0005EED4
		[CallerCount(0)]
		public unsafe override void OnTranq()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BearState.NativeMethodInfoPtr_OnTranq_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00060D10 File Offset: 0x0005EF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46541, XrefRangeEnd = 46543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartNavigation(List<Vector2> path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BearState.NativeMethodInfoPtr_StartNavigation_Public_Virtual_Void_List_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00060D60 File Offset: 0x0005EF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46543, XrefRangeEnd = 46550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PathFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BearState.NativeMethodInfoPtr_PathFailed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00060D9C File Offset: 0x0005EF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46550, XrefRangeEnd = 46637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSeen(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BearState.NativeMethodInfoPtr_OnSeen_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00060DEC File Offset: 0x0005EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46637, XrefRangeEnd = 46638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BearState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BearState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0000B436 File Offset: 0x00009636
		public BearState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00060E28 File Offset: 0x0005F028
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x0000B43F File Offset: 0x0000963F
		public unsafe bool mad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_mad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_mad)) = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x00060E50 File Offset: 0x0005F050
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x0000B45A File Offset: 0x0000965A
		public unsafe bool attacking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_attacking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_attacking)) = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x00060E78 File Offset: 0x0005F078
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x0000B475 File Offset: 0x00009675
		public unsafe bool chasing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_chasing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_chasing)) = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x00060EA0 File Offset: 0x0005F0A0
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x0000B490 File Offset: 0x00009690
		public unsafe GameObject target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00060ED0 File Offset: 0x0005F0D0
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x0000B4AF File Offset: 0x000096AF
		public unsafe Legs legs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_legs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Legs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_legs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00060F00 File Offset: 0x0005F100
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x0000B4CE File Offset: 0x000096CE
		public unsafe bool caged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_caged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_caged)) = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00060F28 File Offset: 0x0005F128
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x0000B4E9 File Offset: 0x000096E9
		public unsafe bool uncaged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_uncaged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_uncaged)) = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00060F50 File Offset: 0x0005F150
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x0000B504 File Offset: 0x00009704
		public unsafe float cageTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_cageTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_cageTimer)) = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x00060F78 File Offset: 0x0005F178
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x0000B51F File Offset: 0x0000971F
		public unsafe Tags tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_tags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_tags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00060FA8 File Offset: 0x0005F1A8
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x0000B53E File Offset: 0x0000973E
		public unsafe GameObject snd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_snd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00060FD8 File Offset: 0x0005F1D8
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x0000B55D File Offset: 0x0000975D
		public unsafe bool tranqed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_tranqed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_tranqed)) = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00061000 File Offset: 0x0005F200
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x0000B578 File Offset: 0x00009778
		public unsafe float tranqTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_tranqTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_tranqTimer)) = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00061028 File Offset: 0x0005F228
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x0000B593 File Offset: 0x00009793
		public unsafe int layerOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_layerOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_layerOffset)) = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00061050 File Offset: 0x0005F250
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x0000B5AE File Offset: 0x000097AE
		public unsafe BearMovement movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_movement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BearMovement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_movement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00061080 File Offset: 0x0005F280
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x0000B5CD File Offset: 0x000097CD
		public unsafe bool startRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_startRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_startRan)) = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000610A8 File Offset: 0x0005F2A8
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x0000B5E8 File Offset: 0x000097E8
		public unsafe AnimalSounder mySounder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_mySounder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimalSounder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearState.NativeFieldInfoPtr_mySounder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_mad;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeFieldInfoPtr_attacking;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeFieldInfoPtr_chasing;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeFieldInfoPtr_legs;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeFieldInfoPtr_caged;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr_uncaged;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeFieldInfoPtr_cageTimer;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr_snd;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeFieldInfoPtr_tranqed;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr_tranqTimer;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr_layerOffset;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr_movement;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeFieldInfoPtr_startRan;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeFieldInfoPtr_mySounder;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_OnCaged_Public_Void_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_Roar_Public_Void_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_OnUncaged_Public_Void_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_OnTranq_Public_Virtual_Void_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_StartNavigation_Public_Virtual_Void_List_1_Vector2_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_PathFailed_Public_Virtual_Void_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_OnSeen_Public_Virtual_Void_GameObject_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
