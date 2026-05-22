using System;
using Il2CppDG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppDG.Tweening.Core
{
	// Token: 0x02000052 RID: 82
	public static class TweenManager : Object
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x0001C9B8 File Offset: 0x0001ABB8
		// Note: this type is marked as 'beforefieldinit'.
		static TweenManager()
		{
			Il2CppClassPointerStore<TweenManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "TweenManager");
			TweenManager.NativeFieldInfoPtr__DefaultMaxTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_DefaultMaxTweeners");
			TweenManager.NativeFieldInfoPtr__DefaultMaxSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_DefaultMaxSequences");
			TweenManager.NativeFieldInfoPtr__MaxTweensReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_MaxTweensReached");
			TweenManager.NativeFieldInfoPtr__EpsilonVsTimeCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_EpsilonVsTimeCheck");
			TweenManager.NativeFieldInfoPtr_isUnityEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "isUnityEditor");
			TweenManager.NativeFieldInfoPtr_isDebugBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "isDebugBuild");
			TweenManager.NativeFieldInfoPtr_maxActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "maxActive");
			TweenManager.NativeFieldInfoPtr_maxTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "maxTweeners");
			TweenManager.NativeFieldInfoPtr_maxSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "maxSequences");
			TweenManager.NativeFieldInfoPtr_hasActiveTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "hasActiveTweens");
			TweenManager.NativeFieldInfoPtr_hasActiveDefaultTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "hasActiveDefaultTweens");
			TweenManager.NativeFieldInfoPtr_hasActiveLateTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "hasActiveLateTweens");
			TweenManager.NativeFieldInfoPtr_hasActiveFixedTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "hasActiveFixedTweens");
			TweenManager.NativeFieldInfoPtr_hasActiveManualTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "hasActiveManualTweens");
			TweenManager.NativeFieldInfoPtr_totActiveTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveTweens");
			TweenManager.NativeFieldInfoPtr_totActiveDefaultTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveDefaultTweens");
			TweenManager.NativeFieldInfoPtr_totActiveLateTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveLateTweens");
			TweenManager.NativeFieldInfoPtr_totActiveFixedTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveFixedTweens");
			TweenManager.NativeFieldInfoPtr_totActiveManualTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveManualTweens");
			TweenManager.NativeFieldInfoPtr_totActiveTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveTweeners");
			TweenManager.NativeFieldInfoPtr_totActiveSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveSequences");
			TweenManager.NativeFieldInfoPtr_totPooledTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totPooledTweeners");
			TweenManager.NativeFieldInfoPtr_totPooledSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totPooledSequences");
			TweenManager.NativeFieldInfoPtr_totTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totTweeners");
			TweenManager.NativeFieldInfoPtr_totSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totSequences");
			TweenManager.NativeFieldInfoPtr_isUpdateLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "isUpdateLoop");
			TweenManager.NativeFieldInfoPtr__activeTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_activeTweens");
			TweenManager.NativeFieldInfoPtr__pooledTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_pooledTweeners");
			TweenManager.NativeFieldInfoPtr__PooledSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_PooledSequences");
			TweenManager.NativeFieldInfoPtr__KillList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_KillList");
			TweenManager.NativeFieldInfoPtr__TweenLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_TweenLinks");
			TweenManager.NativeFieldInfoPtr__totTweenLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_totTweenLinks");
			TweenManager.NativeFieldInfoPtr__maxActiveLookupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_maxActiveLookupId");
			TweenManager.NativeFieldInfoPtr__requiresActiveReorganization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_requiresActiveReorganization");
			TweenManager.NativeFieldInfoPtr__reorganizeFromId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_reorganizeFromId");
			TweenManager.NativeFieldInfoPtr__minPooledTweenerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_minPooledTweenerId");
			TweenManager.NativeFieldInfoPtr__maxPooledTweenerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_maxPooledTweenerId");
			TweenManager.NativeFieldInfoPtr__despawnAllCalledFromUpdateLoopCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_despawnAllCalledFromUpdateLoopCallback");
			TweenManager.NativeMethodInfoPtr_GetTweener_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664256);
			TweenManager.NativeMethodInfoPtr_GetSequence_Internal_Static_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664257);
			TweenManager.NativeMethodInfoPtr_SetUpdateType_Internal_Static_Void_Tween_UpdateType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664258);
			TweenManager.NativeMethodInfoPtr_AddActiveTweenToSequence_Internal_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664259);
			TweenManager.NativeMethodInfoPtr_DespawnAll_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664260);
			TweenManager.NativeMethodInfoPtr_Despawn_Internal_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664261);
			TweenManager.NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664262);
			TweenManager.NativeMethodInfoPtr_PurgePools_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664263);
			TweenManager.NativeMethodInfoPtr_AddTweenLink_Internal_Static_Void_Tween_TweenLink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664264);
			TweenManager.NativeMethodInfoPtr_RemoveTweenLink_Private_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664265);
			TweenManager.NativeMethodInfoPtr_ResetCapacities_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664266);
			TweenManager.NativeMethodInfoPtr_SetCapacities_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664267);
			TweenManager.NativeMethodInfoPtr_Validate_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664268);
			TweenManager.NativeMethodInfoPtr_Update_Internal_Static_Void_UpdateType_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664269);
			TweenManager.NativeMethodInfoPtr_FilteredOperation_Internal_Static_Int32_OperationType_FilterType_Object_Boolean_Single_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664270);
			TweenManager.NativeMethodInfoPtr_Complete_Internal_Static_Boolean_Tween_Boolean_UpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664271);
			TweenManager.NativeMethodInfoPtr_Flip_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664272);
			TweenManager.NativeMethodInfoPtr_ForceInit_Internal_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664273);
			TweenManager.NativeMethodInfoPtr_Goto_Internal_Static_Boolean_Tween_Single_Boolean_UpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664274);
			TweenManager.NativeMethodInfoPtr_Pause_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664275);
			TweenManager.NativeMethodInfoPtr_Play_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664276);
			TweenManager.NativeMethodInfoPtr_PlayBackwards_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664277);
			TweenManager.NativeMethodInfoPtr_PlayForward_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664278);
			TweenManager.NativeMethodInfoPtr_Restart_Internal_Static_Boolean_Tween_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664279);
			TweenManager.NativeMethodInfoPtr_Rewind_Internal_Static_Boolean_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664280);
			TweenManager.NativeMethodInfoPtr_SmoothRewind_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664281);
			TweenManager.NativeMethodInfoPtr_TogglePause_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664282);
			TweenManager.NativeMethodInfoPtr_TotalPooledTweens_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664283);
			TweenManager.NativeMethodInfoPtr_TotalPlayingTweens_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664284);
			TweenManager.NativeMethodInfoPtr_GetActiveTweens_Internal_Static_List_1_Tween_Boolean_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664285);
			TweenManager.NativeMethodInfoPtr_GetTweensById_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664286);
			TweenManager.NativeMethodInfoPtr_GetTweensByTarget_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664287);
			TweenManager.NativeMethodInfoPtr_MarkForKilling_Private_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664288);
			TweenManager.NativeMethodInfoPtr_EvaluateTweenLink_Private_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664289);
			TweenManager.NativeMethodInfoPtr_AddActiveTween_Private_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664290);
			TweenManager.NativeMethodInfoPtr_ReorganizeActiveTweens_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664291);
			TweenManager.NativeMethodInfoPtr_DespawnActiveTweens_Private_Static_Void_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664292);
			TweenManager.NativeMethodInfoPtr_RemoveActiveTween_Private_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664293);
			TweenManager.NativeMethodInfoPtr_ClearTweenArray_Private_Static_Void_Il2CppReferenceArray_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664294);
			TweenManager.NativeMethodInfoPtr_IncreaseCapacities_Private_Static_Void_CapacityIncreaseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664295);
			TweenManager.NativeMethodInfoPtr_ManageOnRewindCallbackWhenAlreadyRewinded_Private_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664296);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001D00C File Offset: 0x0001B20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124724, XrefRangeEnd = 124773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>() where TPlugOptions : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.MethodInfoStoreGeneric_GetTweener_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001D040 File Offset: 0x0001B240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124835, RefRangeEnd = 124836, XrefRangeStart = 124773, XrefRangeEnd = 124835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence GetSequence()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_GetSequence_Internal_Static_Sequence_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001D074 File Offset: 0x0001B274
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 124859, RefRangeEnd = 124887, XrefRangeStart = 124836, XrefRangeEnd = 124859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isIndependentUpdate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_SetUpdateType_Internal_Static_Void_Tween_UpdateType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001D0C8 File Offset: 0x0001B2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124887, XrefRangeEnd = 124891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddActiveTweenToSequence(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_AddActiveTweenToSequence_Internal_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001D100 File Offset: 0x0001B300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124929, RefRangeEnd = 124930, XrefRangeStart = 124891, XrefRangeEnd = 124929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DespawnAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_DespawnAll_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001D130 File Offset: 0x0001B330
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 125010, RefRangeEnd = 125035, XrefRangeStart = 124930, XrefRangeEnd = 125010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Despawn(Tween t, bool modifyActiveLists = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifyActiveLists;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Despawn_Internal_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0001D174 File Offset: 0x0001B374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125069, RefRangeEnd = 125070, XrefRangeStart = 125035, XrefRangeEnd = 125069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PurgeAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001D19C File Offset: 0x0001B39C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125084, RefRangeEnd = 125086, XrefRangeStart = 125070, XrefRangeEnd = 125084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PurgePools()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_PurgePools_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001D1C4 File Offset: 0x0001B3C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125106, RefRangeEnd = 125108, XrefRangeStart = 125086, XrefRangeEnd = 125106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddTweenLink(Tween t, TweenLink tweenLink)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tweenLink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_AddTweenLink_Internal_Static_Void_Tween_TweenLink_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001D20C File Offset: 0x0001B40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125108, XrefRangeEnd = 125121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveTweenLink(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_RemoveTweenLink_Private_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001D244 File Offset: 0x0001B444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125121, XrefRangeEnd = 125125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetCapacities()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_ResetCapacities_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001D26C File Offset: 0x0001B46C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 125143, RefRangeEnd = 125147, XrefRangeStart = 125125, XrefRangeEnd = 125143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCapacities(int tweenersCapacity, int sequencesCapacity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tweenersCapacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequencesCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_SetCapacities_Internal_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001D2AC File Offset: 0x0001B4AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125169, RefRangeEnd = 125170, XrefRangeStart = 125147, XrefRangeEnd = 125169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Validate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Validate_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001D2DC File Offset: 0x0001B4DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 125213, RefRangeEnd = 125217, XrefRangeStart = 125170, XrefRangeEnd = 125213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Update(UpdateType updateType, float deltaTime, float independentTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref independentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Update_Internal_Static_Void_UpdateType_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001D32C File Offset: 0x0001B52C
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 125314, RefRangeEnd = 125384, XrefRangeStart = 125217, XrefRangeEnd = 125314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FilteredOperation(OperationType operationType, FilterType filterType, Object id, bool optionalBool, float optionalFloat, Object optionalObj = null, Il2CppReferenceArray<Object> optionalArray = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref operationType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionalBool;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionalFloat;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionalObj);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionalArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_FilteredOperation_Internal_Static_Int32_OperationType_FilterType_Object_Boolean_Single_Object_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 125391, RefRangeEnd = 125395, XrefRangeStart = 125384, XrefRangeEnd = 125391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Complete(Tween t, bool modifyActiveLists = true, UpdateMode updateMode = UpdateMode.Goto)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifyActiveLists;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Complete_Internal_Static_Boolean_Tween_Boolean_UpdateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001D42C File Offset: 0x0001B62C
		[CallerCount(0)]
		public unsafe static bool Flip(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Flip_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0001D470 File Offset: 0x0001B670
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125401, RefRangeEnd = 125403, XrefRangeStart = 125395, XrefRangeEnd = 125401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceInit(Tween t, bool isSequenced = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSequenced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_ForceInit_Internal_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0001D4B4 File Offset: 0x0001B6B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 125409, RefRangeEnd = 125412, XrefRangeStart = 125403, XrefRangeEnd = 125409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Goto(Tween t, float to, bool andPlay = false, UpdateMode updateMode = UpdateMode.Goto)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Goto_Internal_Static_Boolean_Tween_Single_Boolean_UpdateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0001D520 File Offset: 0x0001B720
		[CallerCount(0)]
		public unsafe static bool Pause(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Pause_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0001D564 File Offset: 0x0001B764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125412, RefRangeEnd = 125413, XrefRangeStart = 125412, XrefRangeEnd = 125412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Play(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Play_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0001D5A8 File Offset: 0x0001B7A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125426, RefRangeEnd = 125428, XrefRangeStart = 125413, XrefRangeEnd = 125426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PlayBackwards(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_PlayBackwards_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0001D5EC File Offset: 0x0001B7EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125431, RefRangeEnd = 125433, XrefRangeStart = 125428, XrefRangeEnd = 125431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PlayForward(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_PlayForward_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001D630 File Offset: 0x0001B830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125438, RefRangeEnd = 125440, XrefRangeStart = 125433, XrefRangeEnd = 125438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Restart(Tween t, bool includeDelay = true, float changeDelayTo = -1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeDelayTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Restart_Internal_Static_Boolean_Tween_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0001D690 File Offset: 0x0001B890
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 125452, RefRangeEnd = 125455, XrefRangeStart = 125440, XrefRangeEnd = 125452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Rewind(Tween t, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Rewind_Internal_Static_Boolean_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0001D6E0 File Offset: 0x0001B8E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125463, RefRangeEnd = 125465, XrefRangeStart = 125455, XrefRangeEnd = 125463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SmoothRewind(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_SmoothRewind_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001D724 File Offset: 0x0001B924
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125469, RefRangeEnd = 125471, XrefRangeStart = 125465, XrefRangeEnd = 125469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TogglePause(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_TogglePause_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0001D768 File Offset: 0x0001B968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125471, XrefRangeEnd = 125475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TotalPooledTweens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_TotalPooledTweens_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001D798 File Offset: 0x0001B998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125475, XrefRangeEnd = 125489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TotalPlayingTweens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_TotalPlayingTweens_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125514, RefRangeEnd = 125516, XrefRangeStart = 125489, XrefRangeEnd = 125514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> GetActiveTweens(bool playing, List<Tween> fillableList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playing;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_GetActiveTweens_Internal_Static_List_1_Tween_Boolean_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0001D81C File Offset: 0x0001BA1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125549, RefRangeEnd = 125550, XrefRangeStart = 125516, XrefRangeEnd = 125549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> GetTweensById(Object id, bool playingOnly, List<Tween> fillableList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playingOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_GetTweensById_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001D880 File Offset: 0x0001BA80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125575, RefRangeEnd = 125576, XrefRangeStart = 125550, XrefRangeEnd = 125575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> GetTweensByTarget(Object target, bool playingOnly, List<Tween> fillableList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playingOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_GetTweensByTarget_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0001D8E4 File Offset: 0x0001BAE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125584, RefRangeEnd = 125586, XrefRangeStart = 125576, XrefRangeEnd = 125584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkForKilling(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_MarkForKilling_Private_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0001D91C File Offset: 0x0001BB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125610, RefRangeEnd = 125611, XrefRangeStart = 125586, XrefRangeEnd = 125610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EvaluateTweenLink(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_EvaluateTweenLink_Private_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0001D954 File Offset: 0x0001BB54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125670, RefRangeEnd = 125672, XrefRangeStart = 125611, XrefRangeEnd = 125670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddActiveTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_AddActiveTween_Private_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001D98C File Offset: 0x0001BB8C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 125695, RefRangeEnd = 125703, XrefRangeStart = 125672, XrefRangeEnd = 125695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReorganizeActiveTweens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_ReorganizeActiveTweens_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001D9B4 File Offset: 0x0001BBB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125709, RefRangeEnd = 125711, XrefRangeStart = 125703, XrefRangeEnd = 125709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DespawnActiveTweens(List<Tween> tweens)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tweens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_DespawnActiveTweens_Private_Static_Void_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001D9EC File Offset: 0x0001BBEC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 125828, RefRangeEnd = 125833, XrefRangeStart = 125711, XrefRangeEnd = 125828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveActiveTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_RemoveActiveTween_Private_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001DA24 File Offset: 0x0001BC24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 125833, RefRangeEnd = 125836, XrefRangeStart = 125833, XrefRangeEnd = 125833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearTweenArray(Il2CppReferenceArray<Tween> tweens)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tweens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_ClearTweenArray_Private_Static_Void_Il2CppReferenceArray_1_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001DA5C File Offset: 0x0001BC5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125866, RefRangeEnd = 125868, XrefRangeStart = 125836, XrefRangeEnd = 125866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IncreaseCapacities(TweenManager.CapacityIncreaseMode increaseMode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref increaseMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_IncreaseCapacities_Private_Static_Void_CapacityIncreaseMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001DA90 File Offset: 0x0001BC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125868, XrefRangeEnd = 125873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManageOnRewindCallbackWhenAlreadyRewinded(Tween t, bool isPlayBackwardsOrSmoothRewind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPlayBackwardsOrSmoothRewind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_ManageOnRewindCallbackWhenAlreadyRewinded_Private_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public TweenManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0001DAD4 File Offset: 0x0001BCD4
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00003AB1 File Offset: 0x00001CB1
		public unsafe static int _DefaultMaxTweeners
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__DefaultMaxTweeners, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__DefaultMaxTweeners, (void*)(&value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00003ABF File Offset: 0x00001CBF
		public unsafe static int _DefaultMaxSequences
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__DefaultMaxSequences, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__DefaultMaxSequences, (void*)(&value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0001DB0C File Offset: 0x0001BD0C
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00003ACD File Offset: 0x00001CCD
		public unsafe static string _MaxTweensReached
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__MaxTweensReached, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__MaxTweensReached, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001DB2C File Offset: 0x0001BD2C
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00003ADF File Offset: 0x00001CDF
		public unsafe static float _EpsilonVsTimeCheck
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__EpsilonVsTimeCheck, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__EpsilonVsTimeCheck, (void*)(&value));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001DB48 File Offset: 0x0001BD48
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00003AED File Offset: 0x00001CED
		public unsafe static bool isUnityEditor
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_isUnityEditor, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_isUnityEditor, (void*)(&value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0001DB64 File Offset: 0x0001BD64
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00003AFB File Offset: 0x00001CFB
		public unsafe static bool isDebugBuild
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_isDebugBuild, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_isDebugBuild, (void*)(&value));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0001DB80 File Offset: 0x0001BD80
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00003B09 File Offset: 0x00001D09
		public unsafe static int maxActive
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_maxActive, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_maxActive, (void*)(&value));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0001DB9C File Offset: 0x0001BD9C
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00003B17 File Offset: 0x00001D17
		public unsafe static int maxTweeners
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_maxTweeners, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_maxTweeners, (void*)(&value));
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0001DBB8 File Offset: 0x0001BDB8
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00003B25 File Offset: 0x00001D25
		public unsafe static int maxSequences
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_maxSequences, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_maxSequences, (void*)(&value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0001DBD4 File Offset: 0x0001BDD4
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00003B33 File Offset: 0x00001D33
		public unsafe static bool hasActiveTweens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_hasActiveTweens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_hasActiveTweens, (void*)(&value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0001DBF0 File Offset: 0x0001BDF0
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00003B41 File Offset: 0x00001D41
		public unsafe static bool hasActiveDefaultTweens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_hasActiveDefaultTweens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_hasActiveDefaultTweens, (void*)(&value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0001DC0C File Offset: 0x0001BE0C
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00003B4F File Offset: 0x00001D4F
		public unsafe static bool hasActiveLateTweens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_hasActiveLateTweens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_hasActiveLateTweens, (void*)(&value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0001DC28 File Offset: 0x0001BE28
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00003B5D File Offset: 0x00001D5D
		public unsafe static bool hasActiveFixedTweens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_hasActiveFixedTweens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_hasActiveFixedTweens, (void*)(&value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0001DC44 File Offset: 0x0001BE44
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00003B6B File Offset: 0x00001D6B
		public unsafe static bool hasActiveManualTweens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_hasActiveManualTweens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_hasActiveManualTweens, (void*)(&value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x0001DC60 File Offset: 0x0001BE60
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00003B79 File Offset: 0x00001D79
		public unsafe static int totActiveTweens
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveTweens, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveTweens, (void*)(&value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0001DC7C File Offset: 0x0001BE7C
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00003B87 File Offset: 0x00001D87
		public unsafe static int totActiveDefaultTweens
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveDefaultTweens, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveDefaultTweens, (void*)(&value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0001DC98 File Offset: 0x0001BE98
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00003B95 File Offset: 0x00001D95
		public unsafe static int totActiveLateTweens
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveLateTweens, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveLateTweens, (void*)(&value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0001DCB4 File Offset: 0x0001BEB4
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00003BA3 File Offset: 0x00001DA3
		public unsafe static int totActiveFixedTweens
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveFixedTweens, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveFixedTweens, (void*)(&value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00003BB1 File Offset: 0x00001DB1
		public unsafe static int totActiveManualTweens
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveManualTweens, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveManualTweens, (void*)(&value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001DCEC File Offset: 0x0001BEEC
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00003BBF File Offset: 0x00001DBF
		public unsafe static int totActiveTweeners
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveTweeners, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveTweeners, (void*)(&value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001DD08 File Offset: 0x0001BF08
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00003BCD File Offset: 0x00001DCD
		public unsafe static int totActiveSequences
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveSequences, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveSequences, (void*)(&value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0001DD24 File Offset: 0x0001BF24
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00003BDB File Offset: 0x00001DDB
		public unsafe static int totPooledTweeners
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totPooledTweeners, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totPooledTweeners, (void*)(&value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0001DD40 File Offset: 0x0001BF40
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00003BE9 File Offset: 0x00001DE9
		public unsafe static int totPooledSequences
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totPooledSequences, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totPooledSequences, (void*)(&value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001DD5C File Offset: 0x0001BF5C
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00003BF7 File Offset: 0x00001DF7
		public unsafe static int totTweeners
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totTweeners, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totTweeners, (void*)(&value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0001DD78 File Offset: 0x0001BF78
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00003C05 File Offset: 0x00001E05
		public unsafe static int totSequences
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totSequences, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totSequences, (void*)(&value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0001DD94 File Offset: 0x0001BF94
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00003C13 File Offset: 0x00001E13
		public unsafe static bool isUpdateLoop
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_isUpdateLoop, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_isUpdateLoop, (void*)(&value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00003C21 File Offset: 0x00001E21
		public unsafe static Il2CppReferenceArray<Tween> _activeTweens
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__activeTweens, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Tween>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__activeTweens, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00003C33 File Offset: 0x00001E33
		public unsafe static Il2CppReferenceArray<Tween> _pooledTweeners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__pooledTweeners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Tween>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__pooledTweeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0001DE00 File Offset: 0x0001C000
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00003C45 File Offset: 0x00001E45
		public unsafe static Stack<Tween> _PooledSequences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__PooledSequences, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<Tween>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__PooledSequences, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0001DE28 File Offset: 0x0001C028
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00003C57 File Offset: 0x00001E57
		public unsafe static List<Tween> _KillList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__KillList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__KillList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x0001DE50 File Offset: 0x0001C050
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00003C69 File Offset: 0x00001E69
		public unsafe static Dictionary<Tween, TweenLink> _TweenLinks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__TweenLinks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Tween, TweenLink>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__TweenLinks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0001DE78 File Offset: 0x0001C078
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00003C7B File Offset: 0x00001E7B
		public unsafe static int _totTweenLinks
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__totTweenLinks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__totTweenLinks, (void*)(&value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0001DE94 File Offset: 0x0001C094
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00003C89 File Offset: 0x00001E89
		public unsafe static int _maxActiveLookupId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__maxActiveLookupId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__maxActiveLookupId, (void*)(&value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0001DEB0 File Offset: 0x0001C0B0
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00003C97 File Offset: 0x00001E97
		public unsafe static bool _requiresActiveReorganization
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__requiresActiveReorganization, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__requiresActiveReorganization, (void*)(&value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0001DECC File Offset: 0x0001C0CC
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00003CA5 File Offset: 0x00001EA5
		public unsafe static int _reorganizeFromId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__reorganizeFromId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__reorganizeFromId, (void*)(&value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x0001DEE8 File Offset: 0x0001C0E8
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00003CB3 File Offset: 0x00001EB3
		public unsafe static int _minPooledTweenerId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__minPooledTweenerId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__minPooledTweenerId, (void*)(&value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x0001DF04 File Offset: 0x0001C104
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00003CC1 File Offset: 0x00001EC1
		public unsafe static int _maxPooledTweenerId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__maxPooledTweenerId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__maxPooledTweenerId, (void*)(&value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0001DF20 File Offset: 0x0001C120
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00003CCF File Offset: 0x00001ECF
		public unsafe static bool _despawnAllCalledFromUpdateLoopCallback
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__despawnAllCalledFromUpdateLoopCallback, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__despawnAllCalledFromUpdateLoopCallback, (void*)(&value));
			}
		}

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr__DefaultMaxTweeners;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr__DefaultMaxSequences;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr__MaxTweensReached;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr__EpsilonVsTimeCheck;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_isUnityEditor;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_isDebugBuild;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_maxActive;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_maxTweeners;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_maxSequences;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_hasActiveTweens;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_hasActiveDefaultTweens;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_hasActiveLateTweens;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_hasActiveFixedTweens;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_hasActiveManualTweens;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_totActiveTweens;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_totActiveDefaultTweens;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_totActiveLateTweens;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_totActiveFixedTweens;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_totActiveManualTweens;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_totActiveTweeners;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_totActiveSequences;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_totPooledTweeners;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_totPooledSequences;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_totTweeners;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_totSequences;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr_isUpdateLoop;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr__activeTweens;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr__pooledTweeners;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr__PooledSequences;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeFieldInfoPtr__KillList;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr__TweenLinks;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr__totTweenLinks;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeFieldInfoPtr__maxActiveLookupId;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr__requiresActiveReorganization;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr__reorganizeFromId;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr__minPooledTweenerId;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr__maxPooledTweenerId;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr__despawnAllCalledFromUpdateLoopCallback;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_GetTweener_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_GetSequence_Internal_Static_Sequence_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdateType_Internal_Static_Void_Tween_UpdateType_Boolean_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_AddActiveTweenToSequence_Internal_Static_Void_Tween_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_DespawnAll_Internal_Static_Int32_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_Despawn_Internal_Static_Void_Tween_Boolean_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_PurgePools_Internal_Static_Void_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_AddTweenLink_Internal_Static_Void_Tween_TweenLink_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTweenLink_Private_Static_Void_Tween_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_ResetCapacities_Internal_Static_Void_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacities_Internal_Static_Void_Int32_Int32_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Static_Int32_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Static_Void_UpdateType_Single_Single_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_FilteredOperation_Internal_Static_Int32_OperationType_FilterType_Object_Boolean_Single_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Static_Boolean_Tween_Boolean_UpdateMode_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_Flip_Internal_Static_Boolean_Tween_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_ForceInit_Internal_Static_Void_Tween_Boolean_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Internal_Static_Boolean_Tween_Single_Boolean_UpdateMode_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Internal_Static_Boolean_Tween_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_Play_Internal_Static_Boolean_Tween_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_PlayBackwards_Internal_Static_Boolean_Tween_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_PlayForward_Internal_Static_Boolean_Tween_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_Restart_Internal_Static_Boolean_Tween_Boolean_Single_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_Rewind_Internal_Static_Boolean_Tween_Boolean_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_SmoothRewind_Internal_Static_Boolean_Tween_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_TogglePause_Internal_Static_Boolean_Tween_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_TotalPooledTweens_Internal_Static_Int32_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_TotalPlayingTweens_Internal_Static_Int32_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveTweens_Internal_Static_List_1_Tween_Boolean_List_1_Tween_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_GetTweensById_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_GetTweensByTarget_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_MarkForKilling_Private_Static_Void_Tween_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateTweenLink_Private_Static_Void_Tween_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_AddActiveTween_Private_Static_Void_Tween_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_ReorganizeActiveTweens_Private_Static_Void_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_DespawnActiveTweens_Private_Static_Void_List_1_Tween_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_RemoveActiveTween_Private_Static_Void_Tween_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_ClearTweenArray_Private_Static_Void_Il2CppReferenceArray_1_Tween_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacities_Private_Static_Void_CapacityIncreaseMode_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_ManageOnRewindCallbackWhenAlreadyRewinded_Private_Static_Void_Tween_Boolean_0;

		// Token: 0x020000F2 RID: 242
		[OriginalName("DOTween.dll", "", "CapacityIncreaseMode")]
		public enum CapacityIncreaseMode
		{
			// Token: 0x04000692 RID: 1682
			TweenersAndSequences,
			// Token: 0x04000693 RID: 1683
			TweenersOnly,
			// Token: 0x04000694 RID: 1684
			SequencesOnly
		}

		// Token: 0x020000F3 RID: 243
		private sealed class MethodInfoStoreGeneric_GetTweener_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000695 RID: 1685
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenManager.NativeMethodInfoPtr_GetTweener_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<TweenManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}
	}
}
