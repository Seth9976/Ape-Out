using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000D0 RID: 208
	public class FatState : GuardState
	{
		// Token: 0x060018AC RID: 6316 RVA: 0x0007997C File Offset: 0x00077B7C
		// Note: this type is marked as 'beforefieldinit'.
		static FatState()
		{
			Il2CppClassPointerStore<FatState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FatState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FatState>.NativeClassPtr);
			FatState.NativeFieldInfoPtr_vestHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FatState>.NativeClassPtr, "vestHp");
			FatState.NativeFieldInfoPtr_vest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FatState>.NativeClassPtr, "vest");
			FatState.NativeFieldInfoPtr_outererVest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FatState>.NativeClassPtr, "outererVest");
			FatState.NativeFieldInfoPtr_outerVest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FatState>.NativeClassPtr, "outerVest");
			FatState.NativeFieldInfoPtr_outerVestArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FatState>.NativeClassPtr, "outerVestArr");
			FatState.NativeFieldInfoPtr_innerVest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FatState>.NativeClassPtr, "innerVest");
			FatState.NativeFieldInfoPtr_innerVestArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FatState>.NativeClassPtr, "innerVestArr");
			FatState.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FatState>.NativeClassPtr, 100665325);
			FatState.NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FatState>.NativeClassPtr, 100665326);
			FatState.NativeMethodInfoPtr_GetSpeeds_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FatState>.NativeClassPtr, 100665327);
			FatState.NativeMethodInfoPtr_ResetAllMyShit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FatState>.NativeClassPtr, 100665328);
			FatState.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FatState>.NativeClassPtr, 100665329);
			FatState.NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FatState>.NativeClassPtr, 100665330);
			FatState.NativeMethodInfoPtr_KillVestBit_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FatState>.NativeClassPtr, 100665331);
			FatState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FatState>.NativeClassPtr, 100665332);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00079AD8 File Offset: 0x00077CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58091, XrefRangeEnd = 58092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FatState.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00079B14 File Offset: 0x00077D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58092, XrefRangeEnd = 58095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitModes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FatState.NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00079B50 File Offset: 0x00077D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58095, XrefRangeEnd = 58101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetSpeeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FatState.NativeMethodInfoPtr_GetSpeeds_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00079B8C File Offset: 0x00077D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58135, RefRangeEnd = 58136, XrefRangeStart = 58101, XrefRangeEnd = 58135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetAllMyShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FatState.NativeMethodInfoPtr_ResetAllMyShit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00079BC8 File Offset: 0x00077DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58136, XrefRangeEnd = 58160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShot(Il2CppStructArray<Vector2> pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FatState.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00079C18 File Offset: 0x00077E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58160, XrefRangeEnd = 58167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSlammed(Il2CppStructArray<Vector2> pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FatState.NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00079C68 File Offset: 0x00077E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58167, XrefRangeEnd = 58180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void KillVestBit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FatState.NativeMethodInfoPtr_KillVestBit_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00079CA4 File Offset: 0x00077EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FatState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FatState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FatState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00011B2F File Offset: 0x0000FD2F
		public FatState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x00079CE0 File Offset: 0x00077EE0
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x00011B38 File Offset: 0x0000FD38
		public unsafe int vestHp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_vestHp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_vestHp)) = value;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x00079D08 File Offset: 0x00077F08
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x00011B53 File Offset: 0x0000FD53
		public unsafe bool vest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_vest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_vest)) = value;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x00079D30 File Offset: 0x00077F30
		// (set) Token: 0x060018BB RID: 6331 RVA: 0x00011B6E File Offset: 0x0000FD6E
		public unsafe GameObject outererVest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_outererVest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_outererVest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x00079D60 File Offset: 0x00077F60
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x00011B8D File Offset: 0x0000FD8D
		public unsafe GameObject outerVest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_outerVest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_outerVest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x00079D90 File Offset: 0x00077F90
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x00011BAC File Offset: 0x0000FDAC
		public unsafe Il2CppReferenceArray<GameObject> outerVestArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_outerVestArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_outerVestArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x00079DC0 File Offset: 0x00077FC0
		// (set) Token: 0x060018C1 RID: 6337 RVA: 0x00011BCB File Offset: 0x0000FDCB
		public unsafe GameObject innerVest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_innerVest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_innerVest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x00079DF0 File Offset: 0x00077FF0
		// (set) Token: 0x060018C3 RID: 6339 RVA: 0x00011BEA File Offset: 0x0000FDEA
		public unsafe Il2CppReferenceArray<GameObject> innerVestArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_innerVestArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FatState.NativeFieldInfoPtr_innerVestArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeFieldInfoPtr_vestHp;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeFieldInfoPtr_vest;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeFieldInfoPtr_outererVest;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeFieldInfoPtr_outerVest;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeFieldInfoPtr_outerVestArr;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeFieldInfoPtr_innerVest;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeFieldInfoPtr_innerVestArr;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeeds_Public_Virtual_Void_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllMyShit_Public_Virtual_Void_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_KillVestBit_Public_Virtual_New_Void_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
