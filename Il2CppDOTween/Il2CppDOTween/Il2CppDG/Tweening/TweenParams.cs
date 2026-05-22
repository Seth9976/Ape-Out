using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x02000016 RID: 22
	public class TweenParams : global::Il2CppSystem.Object
	{
		// Token: 0x06000159 RID: 345 RVA: 0x0000CE44 File Offset: 0x0000B044
		// Note: this type is marked as 'beforefieldinit'.
		static TweenParams()
		{
			Il2CppClassPointerStore<TweenParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "TweenParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenParams>.NativeClassPtr);
			TweenParams.NativeFieldInfoPtr_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "Params");
			TweenParams.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "id");
			TweenParams.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "target");
			TweenParams.NativeFieldInfoPtr_updateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "updateType");
			TweenParams.NativeFieldInfoPtr_isIndependentUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "isIndependentUpdate");
			TweenParams.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "onStart");
			TweenParams.NativeFieldInfoPtr_onPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "onPlay");
			TweenParams.NativeFieldInfoPtr_onRewind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "onRewind");
			TweenParams.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "onUpdate");
			TweenParams.NativeFieldInfoPtr_onStepComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "onStepComplete");
			TweenParams.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "onComplete");
			TweenParams.NativeFieldInfoPtr_onKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "onKill");
			TweenParams.NativeFieldInfoPtr_onWaypointChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "onWaypointChange");
			TweenParams.NativeFieldInfoPtr_isRecyclable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "isRecyclable");
			TweenParams.NativeFieldInfoPtr_isSpeedBased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "isSpeedBased");
			TweenParams.NativeFieldInfoPtr_autoKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "autoKill");
			TweenParams.NativeFieldInfoPtr_loops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "loops");
			TweenParams.NativeFieldInfoPtr_loopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "loopType");
			TweenParams.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "delay");
			TweenParams.NativeFieldInfoPtr_isRelative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "isRelative");
			TweenParams.NativeFieldInfoPtr_easeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "easeType");
			TweenParams.NativeFieldInfoPtr_customEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "customEase");
			TweenParams.NativeFieldInfoPtr_easeOvershootOrAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "easeOvershootOrAmplitude");
			TweenParams.NativeFieldInfoPtr_easePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, "easePeriod");
			TweenParams.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663801);
			TweenParams.NativeMethodInfoPtr_Clear_Public_TweenParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663802);
			TweenParams.NativeMethodInfoPtr_SetAutoKill_Public_TweenParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663803);
			TweenParams.NativeMethodInfoPtr_SetId_Public_TweenParams_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663804);
			TweenParams.NativeMethodInfoPtr_SetTarget_Public_TweenParams_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663805);
			TweenParams.NativeMethodInfoPtr_SetLoops_Public_TweenParams_Int32_Nullable_1_LoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663806);
			TweenParams.NativeMethodInfoPtr_SetEase_Public_TweenParams_Ease_Nullable_1_Single_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663807);
			TweenParams.NativeMethodInfoPtr_SetEase_Public_TweenParams_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663808);
			TweenParams.NativeMethodInfoPtr_SetEase_Public_TweenParams_EaseFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663809);
			TweenParams.NativeMethodInfoPtr_SetRecyclable_Public_TweenParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663810);
			TweenParams.NativeMethodInfoPtr_SetUpdate_Public_TweenParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663811);
			TweenParams.NativeMethodInfoPtr_SetUpdate_Public_TweenParams_UpdateType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663812);
			TweenParams.NativeMethodInfoPtr_OnStart_Public_TweenParams_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663813);
			TweenParams.NativeMethodInfoPtr_OnPlay_Public_TweenParams_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663814);
			TweenParams.NativeMethodInfoPtr_OnRewind_Public_TweenParams_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663815);
			TweenParams.NativeMethodInfoPtr_OnUpdate_Public_TweenParams_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663816);
			TweenParams.NativeMethodInfoPtr_OnStepComplete_Public_TweenParams_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663817);
			TweenParams.NativeMethodInfoPtr_OnComplete_Public_TweenParams_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663818);
			TweenParams.NativeMethodInfoPtr_OnKill_Public_TweenParams_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663819);
			TweenParams.NativeMethodInfoPtr_OnWaypointChange_Public_TweenParams_TweenCallback_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663820);
			TweenParams.NativeMethodInfoPtr_SetDelay_Public_TweenParams_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663821);
			TweenParams.NativeMethodInfoPtr_SetRelative_Public_TweenParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663822);
			TweenParams.NativeMethodInfoPtr_SetSpeedBased_Public_TweenParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenParams>.NativeClassPtr, 100663823);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000D220 File Offset: 0x0000B420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121969, XrefRangeEnd = 121970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenParams()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenParams>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000D25C File Offset: 0x0000B45C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121980, RefRangeEnd = 121981, XrefRangeStart = 121970, XrefRangeEnd = 121980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenParams Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_Clear_Public_TweenParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000D29C File Offset: 0x0000B49C
		[CallerCount(0)]
		public unsafe TweenParams SetAutoKill(bool autoKillOnCompletion = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoKillOnCompletion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetAutoKill_Public_TweenParams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
		[CallerCount(0)]
		public unsafe TweenParams SetId(global::Il2CppSystem.Object id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetId_Public_TweenParams_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000D338 File Offset: 0x0000B538
		[CallerCount(0)]
		public unsafe TweenParams SetTarget(global::Il2CppSystem.Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetTarget_Public_TweenParams_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000D388 File Offset: 0x0000B588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121981, XrefRangeEnd = 121984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenParams SetLoops(int loops, Nullable<LoopType> loopType = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loops;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loopType));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetLoops_Public_TweenParams_Int32_Nullable_1_LoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000D3EC File Offset: 0x0000B5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121984, XrefRangeEnd = 121995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenParams SetEase(Ease ease, Nullable<float> overshootOrAmplitude = null, Nullable<float> period = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ease;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overshootOrAmplitude));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(period));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetEase_Public_TweenParams_Ease_Nullable_1_Single_Nullable_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000D468 File Offset: 0x0000B668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121995, XrefRangeEnd = 122003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenParams SetEase(AnimationCurve animCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animCurve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetEase_Public_TweenParams_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[CallerCount(0)]
		public unsafe TweenParams SetEase(EaseFunction customEase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customEase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetEase_Public_TweenParams_EaseFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000D508 File Offset: 0x0000B708
		[CallerCount(0)]
		public unsafe TweenParams SetRecyclable(bool recyclable = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recyclable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetRecyclable_Public_TweenParams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000D554 File Offset: 0x0000B754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122003, XrefRangeEnd = 122007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenParams SetUpdate(bool isIndependentUpdate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isIndependentUpdate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetUpdate_Public_TweenParams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
		[CallerCount(0)]
		public unsafe TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isIndependentUpdate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetUpdate_Public_TweenParams_UpdateType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		[CallerCount(0)]
		public unsafe TweenParams OnStart(TweenCallback action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_OnStart_Public_TweenParams_TweenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000D64C File Offset: 0x0000B84C
		[CallerCount(0)]
		public unsafe TweenParams OnPlay(TweenCallback action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_OnPlay_Public_TweenParams_TweenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000D69C File Offset: 0x0000B89C
		[CallerCount(0)]
		public unsafe TweenParams OnRewind(TweenCallback action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_OnRewind_Public_TweenParams_TweenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000D6EC File Offset: 0x0000B8EC
		[CallerCount(0)]
		public unsafe TweenParams OnUpdate(TweenCallback action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_OnUpdate_Public_TweenParams_TweenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000D73C File Offset: 0x0000B93C
		[CallerCount(0)]
		public unsafe TweenParams OnStepComplete(TweenCallback action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_OnStepComplete_Public_TweenParams_TweenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000D78C File Offset: 0x0000B98C
		[CallerCount(0)]
		public unsafe TweenParams OnComplete(TweenCallback action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_OnComplete_Public_TweenParams_TweenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		[CallerCount(0)]
		public unsafe TweenParams OnKill(TweenCallback action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_OnKill_Public_TweenParams_TweenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000D82C File Offset: 0x0000BA2C
		[CallerCount(0)]
		public unsafe TweenParams OnWaypointChange(TweenCallback<int> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_OnWaypointChange_Public_TweenParams_TweenCallback_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000D87C File Offset: 0x0000BA7C
		[CallerCount(0)]
		public unsafe TweenParams SetDelay(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetDelay_Public_TweenParams_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000D8C8 File Offset: 0x0000BAC8
		[CallerCount(0)]
		public unsafe TweenParams SetRelative(bool isRelative = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isRelative;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetRelative_Public_TweenParams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000D914 File Offset: 0x0000BB14
		[CallerCount(0)]
		public unsafe TweenParams SetSpeedBased(bool isSpeedBased = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSpeedBased;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenParams.NativeMethodInfoPtr_SetSpeedBased_Public_TweenParams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr3) : null;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000233E File Offset: 0x0000053E
		public TweenParams(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000D960 File Offset: 0x0000BB60
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002347 File Offset: 0x00000547
		public unsafe static TweenParams Params
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenParams.NativeFieldInfoPtr_Params, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenParams>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenParams.NativeFieldInfoPtr_Params, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000D988 File Offset: 0x0000BB88
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00002359 File Offset: 0x00000559
		public unsafe global::Il2CppSystem.Object id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_id);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002378 File Offset: 0x00000578
		public unsafe global::Il2CppSystem.Object target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002397 File Offset: 0x00000597
		public unsafe UpdateType updateType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_updateType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_updateType)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000DA10 File Offset: 0x0000BC10
		// (set) Token: 0x0600017B RID: 379 RVA: 0x000023B2 File Offset: 0x000005B2
		public unsafe bool isIndependentUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_isIndependentUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_isIndependentUpdate)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000DA38 File Offset: 0x0000BC38
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000023CD File Offset: 0x000005CD
		public unsafe TweenCallback onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000DA68 File Offset: 0x0000BC68
		// (set) Token: 0x0600017F RID: 383 RVA: 0x000023EC File Offset: 0x000005EC
		public unsafe TweenCallback onPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onPlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onPlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000DA98 File Offset: 0x0000BC98
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0000240B File Offset: 0x0000060B
		public unsafe TweenCallback onRewind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onRewind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onRewind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000DAC8 File Offset: 0x0000BCC8
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0000242A File Offset: 0x0000062A
		public unsafe TweenCallback onUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00002449 File Offset: 0x00000649
		public unsafe TweenCallback onStepComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onStepComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onStepComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0000DB28 File Offset: 0x0000BD28
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00002468 File Offset: 0x00000668
		public unsafe TweenCallback onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000DB58 File Offset: 0x0000BD58
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002487 File Offset: 0x00000687
		public unsafe TweenCallback onKill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onKill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onKill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000DB88 File Offset: 0x0000BD88
		// (set) Token: 0x0600018B RID: 395 RVA: 0x000024A6 File Offset: 0x000006A6
		public unsafe TweenCallback<int> onWaypointChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onWaypointChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_onWaypointChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000DBB8 File Offset: 0x0000BDB8
		// (set) Token: 0x0600018D RID: 397 RVA: 0x000024C5 File Offset: 0x000006C5
		public unsafe bool isRecyclable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_isRecyclable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_isRecyclable)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
		// (set) Token: 0x0600018F RID: 399 RVA: 0x000024E0 File Offset: 0x000006E0
		public unsafe bool isSpeedBased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_isSpeedBased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_isSpeedBased)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000DC08 File Offset: 0x0000BE08
		// (set) Token: 0x06000191 RID: 401 RVA: 0x000024FB File Offset: 0x000006FB
		public unsafe bool autoKill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_autoKill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_autoKill)) = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000DC30 File Offset: 0x0000BE30
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002516 File Offset: 0x00000716
		public unsafe int loops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_loops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_loops)) = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000DC58 File Offset: 0x0000BE58
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00002531 File Offset: 0x00000731
		public unsafe LoopType loopType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_loopType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_loopType)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000DC80 File Offset: 0x0000BE80
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0000254C File Offset: 0x0000074C
		public unsafe float delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000DCA8 File Offset: 0x0000BEA8
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002567 File Offset: 0x00000767
		public unsafe bool isRelative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_isRelative);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_isRelative)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002582 File Offset: 0x00000782
		public unsafe Ease easeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_easeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_easeType)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0000259D File Offset: 0x0000079D
		public unsafe EaseFunction customEase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_customEase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_customEase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000DD28 File Offset: 0x0000BF28
		// (set) Token: 0x0600019F RID: 415 RVA: 0x000025BC File Offset: 0x000007BC
		public unsafe float easeOvershootOrAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_easeOvershootOrAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_easeOvershootOrAmplitude)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000DD50 File Offset: 0x0000BF50
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x000025D7 File Offset: 0x000007D7
		public unsafe float easePeriod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_easePeriod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenParams.NativeFieldInfoPtr_easePeriod)) = value;
			}
		}

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_Params;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_updateType;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_isIndependentUpdate;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_onPlay;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_onRewind;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_onStepComplete;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_onKill;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_onWaypointChange;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_isRecyclable;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_isSpeedBased;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_autoKill;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_loops;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_loopType;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_isRelative;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_easeType;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_customEase;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_easeOvershootOrAmplitude;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_easePeriod;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_TweenParams_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_SetAutoKill_Public_TweenParams_Boolean_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_SetId_Public_TweenParams_Object_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_TweenParams_Object_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_SetLoops_Public_TweenParams_Int32_Nullable_1_LoopType_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_TweenParams_Ease_Nullable_1_Single_Nullable_1_Single_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_TweenParams_AnimationCurve_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_TweenParams_EaseFunction_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_SetRecyclable_Public_TweenParams_Boolean_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdate_Public_TweenParams_Boolean_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdate_Public_TweenParams_UpdateType_Boolean_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_OnStart_Public_TweenParams_TweenCallback_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_OnPlay_Public_TweenParams_TweenCallback_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_OnRewind_Public_TweenParams_TweenCallback_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_TweenParams_TweenCallback_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_OnStepComplete_Public_TweenParams_TweenCallback_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_OnComplete_Public_TweenParams_TweenCallback_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_OnKill_Public_TweenParams_TweenCallback_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_OnWaypointChange_Public_TweenParams_TweenCallback_1_Int32_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_SetDelay_Public_TweenParams_Single_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_SetRelative_Public_TweenParams_Boolean_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeedBased_Public_TweenParams_Boolean_0;
	}
}
