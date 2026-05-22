using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000B0 RID: 176
	public class CorpseHips : Throwable
	{
		// Token: 0x06001560 RID: 5472 RVA: 0x00070B80 File Offset: 0x0006ED80
		// Note: this type is marked as 'beforefieldinit'.
		static CorpseHips()
		{
			Il2CppClassPointerStore<CorpseHips>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CorpseHips");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr);
			CorpseHips.NativeFieldInfoPtr_uLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "uLeg");
			CorpseHips.NativeFieldInfoPtr_lLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "lLeg");
			CorpseHips.NativeFieldInfoPtr_uLegTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "uLegTrans");
			CorpseHips.NativeFieldInfoPtr_lLegTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "lLegTrans");
			CorpseHips.NativeFieldInfoPtr_foot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "foot");
			CorpseHips.NativeFieldInfoPtr_knee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "knee");
			CorpseHips.NativeFieldInfoPtr_hipPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "hipPos");
			CorpseHips.NativeFieldInfoPtr_truePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "truePos");
			CorpseHips.NativeFieldInfoPtr_back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "back");
			CorpseHips.NativeFieldInfoPtr_ready = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "ready");
			CorpseHips.NativeFieldInfoPtr_hipWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "hipWidth");
			CorpseHips.NativeFieldInfoPtr_onScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "onScreen");
			CorpseHips.NativeFieldInfoPtr_off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "off");
			CorpseHips.NativeFieldInfoPtr_footDefPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "footDefPos");
			CorpseHips.NativeFieldInfoPtr_kneeDefPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "kneeDefPos");
			CorpseHips.NativeFieldInfoPtr_footDefAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "footDefAng");
			CorpseHips.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "startFlag");
			CorpseHips.NativeFieldInfoPtr_wallOnlyLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "wallOnlyLayer");
			CorpseHips.NativeFieldInfoPtr_prevAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, "prevAng");
			CorpseHips.NativeMethodInfoPtr_MyStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665089);
			CorpseHips.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665090);
			CorpseHips.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665091);
			CorpseHips.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665092);
			CorpseHips.NativeMethodInfoPtr_SetLayer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665093);
			CorpseHips.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665094);
			CorpseHips.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665095);
			CorpseHips.NativeMethodInfoPtr_DrawLegs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665096);
			CorpseHips.NativeMethodInfoPtr_MoveFoot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665097);
			CorpseHips.NativeMethodInfoPtr_Break_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665098);
			CorpseHips.NativeMethodInfoPtr_PlaySound_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665099);
			CorpseHips.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr, 100665100);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00070E1C File Offset: 0x0006F01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53991, RefRangeEnd = 53992, XrefRangeStart = 53940, XrefRangeEnd = 53991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorpseHips.NativeMethodInfoPtr_MyStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00070E50 File Offset: 0x0006F050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53992, XrefRangeEnd = 54062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorpseHips.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00070E84 File Offset: 0x0006F084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54062, XrefRangeEnd = 54099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CorpseHips.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00070EC0 File Offset: 0x0006F0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54099, XrefRangeEnd = 54147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CorpseHips.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00070EFC File Offset: 0x0006F0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54147, XrefRangeEnd = 54148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CorpseHips.NativeMethodInfoPtr_SetLayer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00070F38 File Offset: 0x0006F138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54148, XrefRangeEnd = 54178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CorpseHips.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00070F74 File Offset: 0x0006F174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54178, XrefRangeEnd = 54179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorpseHips.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00070FA8 File Offset: 0x0006F1A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54191, RefRangeEnd = 54193, XrefRangeStart = 54179, XrefRangeEnd = 54191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawLegs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorpseHips.NativeMethodInfoPtr_DrawLegs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00070FDC File Offset: 0x0006F1DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54219, RefRangeEnd = 54220, XrefRangeStart = 54193, XrefRangeEnd = 54219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveFoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorpseHips.NativeMethodInfoPtr_MoveFoot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00071010 File Offset: 0x0006F210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54220, XrefRangeEnd = 54243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CorpseHips.NativeMethodInfoPtr_Break_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0007104C File Offset: 0x0006F24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54243, XrefRangeEnd = 54250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlaySound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CorpseHips.NativeMethodInfoPtr_PlaySound_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00071088 File Offset: 0x0006F288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CorpseHips()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CorpseHips>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorpseHips.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0000F83D File Offset: 0x0000DA3D
		public CorpseHips(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x000710C4 File Offset: 0x0006F2C4
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x0000F846 File Offset: 0x0000DA46
		public unsafe Il2CppReferenceArray<MeshFilter> uLeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_uLeg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_uLeg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x000710F4 File Offset: 0x0006F2F4
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x0000F865 File Offset: 0x0000DA65
		public unsafe Il2CppReferenceArray<MeshFilter> lLeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_lLeg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_lLeg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00071124 File Offset: 0x0006F324
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x0000F884 File Offset: 0x0000DA84
		public unsafe Il2CppReferenceArray<Transform> uLegTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_uLegTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_uLegTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x00071154 File Offset: 0x0006F354
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x0000F8A3 File Offset: 0x0000DAA3
		public unsafe Il2CppReferenceArray<Transform> lLegTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_lLegTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_lLegTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00071184 File Offset: 0x0006F384
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x0000F8C2 File Offset: 0x0000DAC2
		public unsafe Il2CppReferenceArray<Transform> foot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_foot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_foot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x000711B4 File Offset: 0x0006F3B4
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x0000F8E1 File Offset: 0x0000DAE1
		public unsafe Il2CppReferenceArray<Transform> knee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_knee);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_knee), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x000711E4 File Offset: 0x0006F3E4
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x0000F900 File Offset: 0x0000DB00
		public unsafe Il2CppStructArray<Vector2> hipPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_hipPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_hipPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00071214 File Offset: 0x0006F414
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x0000F91F File Offset: 0x0000DB1F
		public unsafe Il2CppStructArray<Vector2> truePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_truePos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_truePos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x00071244 File Offset: 0x0006F444
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x0000F93E File Offset: 0x0000DB3E
		public unsafe bool back
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_back);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_back)) = value;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x0007126C File Offset: 0x0006F46C
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x0000F959 File Offset: 0x0000DB59
		public unsafe bool ready
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_ready);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_ready)) = value;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x00071294 File Offset: 0x0006F494
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x0000F974 File Offset: 0x0000DB74
		public unsafe float hipWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_hipWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_hipWidth)) = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x000712BC File Offset: 0x0006F4BC
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x0000F98F File Offset: 0x0000DB8F
		public unsafe bool onScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_onScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_onScreen)) = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x000712E4 File Offset: 0x0006F4E4
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x0000F9AA File Offset: 0x0000DBAA
		public unsafe bool off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_off);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_off)) = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x0007130C File Offset: 0x0006F50C
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x0000F9C5 File Offset: 0x0000DBC5
		public unsafe Il2CppStructArray<Vector3> footDefPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_footDefPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_footDefPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x0007133C File Offset: 0x0006F53C
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x0000F9E4 File Offset: 0x0000DBE4
		public unsafe Il2CppStructArray<Vector3> kneeDefPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_kneeDefPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_kneeDefPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x0007136C File Offset: 0x0006F56C
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x0000FA03 File Offset: 0x0000DC03
		public unsafe Il2CppStructArray<float> footDefAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_footDefAng);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_footDefAng), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x0007139C File Offset: 0x0006F59C
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x0000FA22 File Offset: 0x0000DC22
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x000713C4 File Offset: 0x0006F5C4
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x0000FA3D File Offset: 0x0000DC3D
		public unsafe int wallOnlyLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_wallOnlyLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_wallOnlyLayer)) = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x000713EC File Offset: 0x0006F5EC
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x0000FA58 File Offset: 0x0000DC58
		public unsafe float prevAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_prevAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CorpseHips.NativeFieldInfoPtr_prevAng)) = value;
			}
		}

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeFieldInfoPtr_uLeg;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeFieldInfoPtr_lLeg;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeFieldInfoPtr_uLegTrans;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeFieldInfoPtr_lLegTrans;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeFieldInfoPtr_foot;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeFieldInfoPtr_knee;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeFieldInfoPtr_hipPos;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeFieldInfoPtr_truePos;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeFieldInfoPtr_back;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeFieldInfoPtr_ready;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeFieldInfoPtr_hipWidth;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeFieldInfoPtr_onScreen;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeFieldInfoPtr_off;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeFieldInfoPtr_footDefPos;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr_kneeDefPos;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeFieldInfoPtr_footDefAng;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeFieldInfoPtr_wallOnlyLayer;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeFieldInfoPtr_prevAng;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_MyStart_Public_Void_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_SetLayer_Public_Virtual_Void_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_DrawLegs_Public_Void_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_MoveFoot_Public_Void_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Virtual_Void_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
