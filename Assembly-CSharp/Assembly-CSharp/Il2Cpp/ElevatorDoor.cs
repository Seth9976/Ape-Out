using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000C0 RID: 192
	public class ElevatorDoor : Door
	{
		// Token: 0x060016AC RID: 5804 RVA: 0x00074454 File Offset: 0x00072654
		// Note: this type is marked as 'beforefieldinit'.
		static ElevatorDoor()
		{
			Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ElevatorDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr);
			ElevatorDoor.NativeFieldInfoPtr_lightSprs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "lightSprs");
			ElevatorDoor.NativeFieldInfoPtr_onMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "onMat");
			ElevatorDoor.NativeFieldInfoPtr_offMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "offMat");
			ElevatorDoor.NativeFieldInfoPtr_beams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "beams");
			ElevatorDoor.NativeFieldInfoPtr_spawns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "spawns");
			ElevatorDoor.NativeFieldInfoPtr_opening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "opening");
			ElevatorDoor.NativeFieldInfoPtr_openTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "openTimer");
			ElevatorDoor.NativeFieldInfoPtr_permOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "permOpen");
			ElevatorDoor.NativeFieldInfoPtr_dister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "dister");
			ElevatorDoor.NativeFieldInfoPtr_triggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "triggered");
			ElevatorDoor.NativeFieldInfoPtr_closeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "closeTimer");
			ElevatorDoor.NativeFieldInfoPtr_spawnTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "spawnTimer");
			ElevatorDoor.NativeFieldInfoPtr_guardsOnTheWay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "guardsOnTheWay");
			ElevatorDoor.NativeFieldInfoPtr_corner1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "corner1");
			ElevatorDoor.NativeFieldInfoPtr_corner2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "corner2");
			ElevatorDoor.NativeFieldInfoPtr_spawnedGuardArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "spawnedGuardArr");
			ElevatorDoor.NativeFieldInfoPtr_guardList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "guardList");
			ElevatorDoor.NativeFieldInfoPtr_closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "closed");
			ElevatorDoor.NativeFieldInfoPtr_totalSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "totalSpawned");
			ElevatorDoor.NativeFieldInfoPtr_doorwayBnds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "doorwayBnds");
			ElevatorDoor.NativeFieldInfoPtr_guardIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "guardIndex");
			ElevatorDoor.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, "pos");
			ElevatorDoor.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, 100665199);
			ElevatorDoor.NativeMethodInfoPtr_GrabMasterList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, 100665200);
			ElevatorDoor.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, 100665201);
			ElevatorDoor.NativeMethodInfoPtr_GuardsInElevator_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, 100665202);
			ElevatorDoor.NativeMethodInfoPtr_ResetOpen_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, 100665203);
			ElevatorDoor.NativeMethodInfoPtr_SetTriggerSize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, 100665204);
			ElevatorDoor.NativeMethodInfoPtr_OnTrigStay2D_Public_Virtual_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, 100665205);
			ElevatorDoor.NativeMethodInfoPtr_SpawnGuards_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, 100665206);
			ElevatorDoor.NativeMethodInfoPtr_GetGuard_Private_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, 100665207);
			ElevatorDoor.NativeMethodInfoPtr_SpawnGuard_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, 100665208);
			ElevatorDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr, 100665209);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00074718 File Offset: 0x00072918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56087, XrefRangeEnd = 56141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ElevatorDoor.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00074754 File Offset: 0x00072954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56151, RefRangeEnd = 56153, XrefRangeStart = 56141, XrefRangeEnd = 56151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabMasterList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElevatorDoor.NativeMethodInfoPtr_GrabMasterList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00074788 File Offset: 0x00072988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56153, XrefRangeEnd = 56206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ElevatorDoor.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x000747C4 File Offset: 0x000729C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56206, XrefRangeEnd = 56208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GuardsInElevator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElevatorDoor.NativeMethodInfoPtr_GuardsInElevator_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00074800 File Offset: 0x00072A00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ElevatorDoor.NativeMethodInfoPtr_ResetOpen_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0007483C File Offset: 0x00072A3C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetTriggerSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ElevatorDoor.NativeMethodInfoPtr_SetTriggerSize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00074878 File Offset: 0x00072A78
		[CallerCount(0)]
		public unsafe override void OnTrigStay2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ElevatorDoor.NativeMethodInfoPtr_OnTrigStay2D_Public_Virtual_Void_Collider2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000748C8 File Offset: 0x00072AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56213, RefRangeEnd = 56214, XrefRangeStart = 56208, XrefRangeEnd = 56213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnGuards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElevatorDoor.NativeMethodInfoPtr_SpawnGuards_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000748FC File Offset: 0x00072AFC
		[CallerCount(0)]
		public unsafe GuardState GetGuard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElevatorDoor.NativeMethodInfoPtr_GetGuard_Private_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr3) : null;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x0007493C File Offset: 0x00072B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56256, RefRangeEnd = 56257, XrefRangeStart = 56214, XrefRangeEnd = 56256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnGuard(Vector2 pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElevatorDoor.NativeMethodInfoPtr_SpawnGuard_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0007497C File Offset: 0x00072B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElevatorDoor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElevatorDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElevatorDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00010511 File Offset: 0x0000E711
		public ElevatorDoor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x000749B8 File Offset: 0x00072BB8
		// (set) Token: 0x060016BA RID: 5818 RVA: 0x0001051A File Offset: 0x0000E71A
		public unsafe Il2CppReferenceArray<SpriteRenderer> lightSprs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_lightSprs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_lightSprs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x000749E8 File Offset: 0x00072BE8
		// (set) Token: 0x060016BC RID: 5820 RVA: 0x00010539 File Offset: 0x0000E739
		public unsafe Material onMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_onMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_onMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x00074A18 File Offset: 0x00072C18
		// (set) Token: 0x060016BE RID: 5822 RVA: 0x00010558 File Offset: 0x0000E758
		public unsafe Material offMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_offMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_offMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x00074A48 File Offset: 0x00072C48
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x00010577 File Offset: 0x0000E777
		public unsafe Il2CppReferenceArray<FlashLight> beams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_beams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FlashLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_beams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00074A78 File Offset: 0x00072C78
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x00010596 File Offset: 0x0000E796
		public unsafe Il2CppReferenceArray<Transform> spawns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_spawns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_spawns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00074AA8 File Offset: 0x00072CA8
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x000105B5 File Offset: 0x0000E7B5
		public unsafe bool opening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_opening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_opening)) = value;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00074AD0 File Offset: 0x00072CD0
		// (set) Token: 0x060016C6 RID: 5830 RVA: 0x000105D0 File Offset: 0x0000E7D0
		public unsafe int openTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_openTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_openTimer)) = value;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x00074AF8 File Offset: 0x00072CF8
		// (set) Token: 0x060016C8 RID: 5832 RVA: 0x000105EB File Offset: 0x0000E7EB
		public unsafe bool permOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_permOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_permOpen)) = value;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060016C9 RID: 5833 RVA: 0x00074B20 File Offset: 0x00072D20
		// (set) Token: 0x060016CA RID: 5834 RVA: 0x00010606 File Offset: 0x0000E806
		public unsafe DistDisabler dister
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_dister);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DistDisabler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_dister), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x00074B50 File Offset: 0x00072D50
		// (set) Token: 0x060016CC RID: 5836 RVA: 0x00010625 File Offset: 0x0000E825
		public unsafe bool triggered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_triggered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_triggered)) = value;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x00074B78 File Offset: 0x00072D78
		// (set) Token: 0x060016CE RID: 5838 RVA: 0x00010640 File Offset: 0x0000E840
		public unsafe float closeTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_closeTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_closeTimer)) = value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x00074BA0 File Offset: 0x00072DA0
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0001065B File Offset: 0x0000E85B
		public unsafe int spawnTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_spawnTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_spawnTimer)) = value;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00074BC8 File Offset: 0x00072DC8
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x00010676 File Offset: 0x0000E876
		public unsafe bool guardsOnTheWay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_guardsOnTheWay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_guardsOnTheWay)) = value;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x00074BF0 File Offset: 0x00072DF0
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x00010691 File Offset: 0x0000E891
		public unsafe Transform corner1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_corner1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_corner1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00074C20 File Offset: 0x00072E20
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x000106B0 File Offset: 0x0000E8B0
		public unsafe Transform corner2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_corner2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_corner2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00074C50 File Offset: 0x00072E50
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x000106CF File Offset: 0x0000E8CF
		public unsafe Il2CppReferenceArray<GuardState> spawnedGuardArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_spawnedGuardArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GuardState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_spawnedGuardArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00074C80 File Offset: 0x00072E80
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x000106EE File Offset: 0x0000E8EE
		public unsafe List<MapGenerator.GuardType> guardList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_guardList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MapGenerator.GuardType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_guardList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00074CB0 File Offset: 0x00072EB0
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x0001070D File Offset: 0x0000E90D
		public unsafe bool closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_closed)) = value;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00074CD8 File Offset: 0x00072ED8
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x00010728 File Offset: 0x0000E928
		public unsafe int totalSpawned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_totalSpawned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_totalSpawned)) = value;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x00074D00 File Offset: 0x00072F00
		// (set) Token: 0x060016E0 RID: 5856 RVA: 0x00010743 File Offset: 0x0000E943
		public unsafe Bounds doorwayBnds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_doorwayBnds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_doorwayBnds)) = value;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00074D28 File Offset: 0x00072F28
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x0001075E File Offset: 0x0000E95E
		public unsafe int guardIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_guardIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_guardIndex)) = value;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00074D50 File Offset: 0x00072F50
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x00010779 File Offset: 0x0000E979
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElevatorDoor.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeFieldInfoPtr_lightSprs;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeFieldInfoPtr_onMat;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeFieldInfoPtr_offMat;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeFieldInfoPtr_beams;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeFieldInfoPtr_spawns;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeFieldInfoPtr_opening;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeFieldInfoPtr_openTimer;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeFieldInfoPtr_permOpen;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeFieldInfoPtr_dister;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeFieldInfoPtr_triggered;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeFieldInfoPtr_closeTimer;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeFieldInfoPtr_spawnTimer;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeFieldInfoPtr_guardsOnTheWay;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeFieldInfoPtr_corner1;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr_corner2;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeFieldInfoPtr_spawnedGuardArr;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeFieldInfoPtr_guardList;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeFieldInfoPtr_closed;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeFieldInfoPtr_totalSpawned;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeFieldInfoPtr_doorwayBnds;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeFieldInfoPtr_guardIndex;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_GrabMasterList_Public_Void_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_GuardsInElevator_Private_Boolean_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_ResetOpen_Public_Virtual_Void_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_SetTriggerSize_Public_Virtual_Void_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_OnTrigStay2D_Public_Virtual_Void_Collider2D_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_SpawnGuards_Public_Void_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_GetGuard_Private_GuardState_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_SpawnGuard_Public_Void_Vector2_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
