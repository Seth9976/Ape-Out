using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppDG.Tweening
{
	// Token: 0x02000019 RID: 25
	public class Tween : ABSSequentiable
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x000105E8 File Offset: 0x0000E7E8
		// Note: this type is marked as 'beforefieldinit'.
		static Tween()
		{
			Il2CppClassPointerStore<Tween>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "Tween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tween>.NativeClassPtr);
			Tween.NativeFieldInfoPtr_timeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "timeScale");
			Tween.NativeFieldInfoPtr_isBackwards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isBackwards");
			Tween.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "id");
			Tween.NativeFieldInfoPtr_stringId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "stringId");
			Tween.NativeFieldInfoPtr_intId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "intId");
			Tween.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "target");
			Tween.NativeFieldInfoPtr_updateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "updateType");
			Tween.NativeFieldInfoPtr_isIndependentUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isIndependentUpdate");
			Tween.NativeFieldInfoPtr_onPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onPlay");
			Tween.NativeFieldInfoPtr_onPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onPause");
			Tween.NativeFieldInfoPtr_onRewind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onRewind");
			Tween.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onUpdate");
			Tween.NativeFieldInfoPtr_onStepComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onStepComplete");
			Tween.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onComplete");
			Tween.NativeFieldInfoPtr_onKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onKill");
			Tween.NativeFieldInfoPtr_onWaypointChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onWaypointChange");
			Tween.NativeFieldInfoPtr_isFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isFrom");
			Tween.NativeFieldInfoPtr_isBlendable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isBlendable");
			Tween.NativeFieldInfoPtr_isRecyclable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isRecyclable");
			Tween.NativeFieldInfoPtr_isSpeedBased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isSpeedBased");
			Tween.NativeFieldInfoPtr_autoKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "autoKill");
			Tween.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "duration");
			Tween.NativeFieldInfoPtr_loops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "loops");
			Tween.NativeFieldInfoPtr_loopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "loopType");
			Tween.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "delay");
			Tween.NativeFieldInfoPtr__isRelative_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "<isRelative>k__BackingField");
			Tween.NativeFieldInfoPtr_easeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "easeType");
			Tween.NativeFieldInfoPtr_customEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "customEase");
			Tween.NativeFieldInfoPtr_easeOvershootOrAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "easeOvershootOrAmplitude");
			Tween.NativeFieldInfoPtr_easePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "easePeriod");
			Tween.NativeFieldInfoPtr_typeofT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "typeofT1");
			Tween.NativeFieldInfoPtr_typeofT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "typeofT2");
			Tween.NativeFieldInfoPtr_typeofTPlugOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "typeofTPlugOptions");
			Tween.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "<active>k__BackingField");
			Tween.NativeFieldInfoPtr_isSequenced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isSequenced");
			Tween.NativeFieldInfoPtr_sequenceParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "sequenceParent");
			Tween.NativeFieldInfoPtr_activeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "activeId");
			Tween.NativeFieldInfoPtr_specialStartupMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "specialStartupMode");
			Tween.NativeFieldInfoPtr_creationLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "creationLocked");
			Tween.NativeFieldInfoPtr_startupDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "startupDone");
			Tween.NativeFieldInfoPtr__playedOnce_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "<playedOnce>k__BackingField");
			Tween.NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "<position>k__BackingField");
			Tween.NativeFieldInfoPtr_fullDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "fullDuration");
			Tween.NativeFieldInfoPtr_completedLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "completedLoops");
			Tween.NativeFieldInfoPtr_isPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isPlaying");
			Tween.NativeFieldInfoPtr_isComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isComplete");
			Tween.NativeFieldInfoPtr_elapsedDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "elapsedDelay");
			Tween.NativeFieldInfoPtr_delayComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "delayComplete");
			Tween.NativeFieldInfoPtr_miscInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "miscInt");
			Tween.NativeMethodInfoPtr_get_isRelative_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663894);
			Tween.NativeMethodInfoPtr_set_isRelative_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663895);
			Tween.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663896);
			Tween.NativeMethodInfoPtr_set_active_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663897);
			Tween.NativeMethodInfoPtr_get_fullPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663898);
			Tween.NativeMethodInfoPtr_set_fullPosition_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663899);
			Tween.NativeMethodInfoPtr_get_playedOnce_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663900);
			Tween.NativeMethodInfoPtr_set_playedOnce_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663901);
			Tween.NativeMethodInfoPtr_get_position_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663902);
			Tween.NativeMethodInfoPtr_set_position_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663903);
			Tween.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663904);
			Tween.NativeMethodInfoPtr_Validate_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663905);
			Tween.NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_New_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663906);
			Tween.NativeMethodInfoPtr_Startup_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663907);
			Tween.NativeMethodInfoPtr_ApplyTween_Internal_Abstract_Virtual_New_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663908);
			Tween.NativeMethodInfoPtr_DoGoto_Internal_Static_Boolean_Tween_Single_Int32_UpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663909);
			Tween.NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663910);
			Tween.NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663911);
			Tween.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663912);
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00010B68 File Offset: 0x0000ED68
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00010BA4 File Offset: 0x0000EDA4
		public unsafe bool isRelative
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_get_isRelative_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_set_isRelative_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00010BE4 File Offset: 0x0000EDE4
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00010C20 File Offset: 0x0000EE20
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_set_active_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00010C60 File Offset: 0x0000EE60
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00010C9C File Offset: 0x0000EE9C
		public unsafe float fullPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122184, XrefRangeEnd = 122185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_get_fullPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122185, XrefRangeEnd = 122186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_set_fullPosition_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00010CDC File Offset: 0x0000EEDC
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00010D18 File Offset: 0x0000EF18
		public unsafe bool playedOnce
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_get_playedOnce_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_set_playedOnce_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00010D58 File Offset: 0x0000EF58
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00010D94 File Offset: 0x0000EF94
		public unsafe float position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_get_position_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_set_position_Internal_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00010DD4 File Offset: 0x0000EFD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122186, RefRangeEnd = 122188, XrefRangeStart = 122186, XrefRangeEnd = 122186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tween.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00010E10 File Offset: 0x0000F010
		[CallerCount(0)]
		public unsafe virtual bool Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tween.NativeMethodInfoPtr_Validate_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00010E58 File Offset: 0x0000F058
		[CallerCount(0)]
		public unsafe virtual float UpdateDelay(float elapsed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elapsed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tween.NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_New_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00010EAC File Offset: 0x0000F0AC
		[CallerCount(0)]
		public unsafe virtual bool Startup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tween.NativeMethodInfoPtr_Startup_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00010EF4 File Offset: 0x0000F0F4
		[CallerCount(0)]
		public unsafe virtual bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref prevPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevCompletedLoops;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCompletedSteps;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInversePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateNotice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tween.NativeMethodInfoPtr_ApplyTween_Internal_Abstract_Virtual_New_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00010F90 File Offset: 0x0000F190
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 122205, RefRangeEnd = 122212, XrefRangeStart = 122188, XrefRangeEnd = 122205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toCompletedLoops;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_DoGoto_Internal_Static_Boolean_Tween_Single_Int32_UpdateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00010FFC File Offset: 0x0000F1FC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 122217, RefRangeEnd = 122238, XrefRangeStart = 122212, XrefRangeEnd = 122217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool OnTweenCallback(TweenCallback callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00011040 File Offset: 0x0000F240
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 122242, RefRangeEnd = 122245, XrefRangeStart = 122238, XrefRangeEnd = 122242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool OnTweenCallback<T>(TweenCallback<T> callback, T param)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = param;
				if (!(t is string))
				{
					ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr3) != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref param;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.MethodInfoStoreGeneric_OnTweenCallback_Internal_Static_Boolean_TweenCallback_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000110E0 File Offset: 0x0000F2E0
		[CallerCount(0)]
		public unsafe Tween()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tween>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000025FB File Offset: 0x000007FB
		public Tween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0001111C File Offset: 0x0000F31C
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002604 File Offset: 0x00000804
		public unsafe float timeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_timeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_timeScale)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00011144 File Offset: 0x0000F344
		// (set) Token: 0x06000201 RID: 513 RVA: 0x0000261F File Offset: 0x0000081F
		public unsafe bool isBackwards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isBackwards);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isBackwards)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0001116C File Offset: 0x0000F36C
		// (set) Token: 0x06000203 RID: 515 RVA: 0x0000263A File Offset: 0x0000083A
		public unsafe Object id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_id);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0001119C File Offset: 0x0000F39C
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002659 File Offset: 0x00000859
		public unsafe string stringId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_stringId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_stringId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000111C4 File Offset: 0x0000F3C4
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002678 File Offset: 0x00000878
		public unsafe int intId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_intId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_intId)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000208 RID: 520 RVA: 0x000111EC File Offset: 0x0000F3EC
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002693 File Offset: 0x00000893
		public unsafe Object target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0001121C File Offset: 0x0000F41C
		// (set) Token: 0x0600020B RID: 523 RVA: 0x000026B2 File Offset: 0x000008B2
		public unsafe UpdateType updateType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_updateType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_updateType)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00011244 File Offset: 0x0000F444
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000026CD File Offset: 0x000008CD
		public unsafe bool isIndependentUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isIndependentUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isIndependentUpdate)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0001126C File Offset: 0x0000F46C
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000026E8 File Offset: 0x000008E8
		public unsafe TweenCallback onPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onPlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onPlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0001129C File Offset: 0x0000F49C
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002707 File Offset: 0x00000907
		public unsafe TweenCallback onPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onPause);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onPause), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000112CC File Offset: 0x0000F4CC
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002726 File Offset: 0x00000926
		public unsafe TweenCallback onRewind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onRewind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onRewind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000112FC File Offset: 0x0000F4FC
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002745 File Offset: 0x00000945
		public unsafe TweenCallback onUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0001132C File Offset: 0x0000F52C
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002764 File Offset: 0x00000964
		public unsafe TweenCallback onStepComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onStepComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onStepComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0001135C File Offset: 0x0000F55C
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002783 File Offset: 0x00000983
		public unsafe TweenCallback onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0001138C File Offset: 0x0000F58C
		// (set) Token: 0x0600021B RID: 539 RVA: 0x000027A2 File Offset: 0x000009A2
		public unsafe TweenCallback onKill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onKill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onKill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000113BC File Offset: 0x0000F5BC
		// (set) Token: 0x0600021D RID: 541 RVA: 0x000027C1 File Offset: 0x000009C1
		public unsafe TweenCallback<int> onWaypointChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onWaypointChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onWaypointChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000113EC File Offset: 0x0000F5EC
		// (set) Token: 0x0600021F RID: 543 RVA: 0x000027E0 File Offset: 0x000009E0
		public unsafe bool isFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isFrom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isFrom)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00011414 File Offset: 0x0000F614
		// (set) Token: 0x06000221 RID: 545 RVA: 0x000027FB File Offset: 0x000009FB
		public unsafe bool isBlendable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isBlendable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isBlendable)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0001143C File Offset: 0x0000F63C
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002816 File Offset: 0x00000A16
		public unsafe bool isRecyclable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isRecyclable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isRecyclable)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00011464 File Offset: 0x0000F664
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002831 File Offset: 0x00000A31
		public unsafe bool isSpeedBased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isSpeedBased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isSpeedBased)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0001148C File Offset: 0x0000F68C
		// (set) Token: 0x06000227 RID: 551 RVA: 0x0000284C File Offset: 0x00000A4C
		public unsafe bool autoKill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_autoKill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_autoKill)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000228 RID: 552 RVA: 0x000114B4 File Offset: 0x0000F6B4
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002867 File Offset: 0x00000A67
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600022A RID: 554 RVA: 0x000114DC File Offset: 0x0000F6DC
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00002882 File Offset: 0x00000A82
		public unsafe int loops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_loops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_loops)) = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00011504 File Offset: 0x0000F704
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0000289D File Offset: 0x00000A9D
		public unsafe LoopType loopType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_loopType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_loopType)) = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0001152C File Offset: 0x0000F72C
		// (set) Token: 0x0600022F RID: 559 RVA: 0x000028B8 File Offset: 0x00000AB8
		public unsafe float delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00011554 File Offset: 0x0000F754
		// (set) Token: 0x06000231 RID: 561 RVA: 0x000028D3 File Offset: 0x00000AD3
		public unsafe bool _isRelative_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr__isRelative_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr__isRelative_k__BackingField)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0001157C File Offset: 0x0000F77C
		// (set) Token: 0x06000233 RID: 563 RVA: 0x000028EE File Offset: 0x00000AEE
		public unsafe Ease easeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easeType)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000115A4 File Offset: 0x0000F7A4
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002909 File Offset: 0x00000B09
		public unsafe EaseFunction customEase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_customEase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_customEase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000236 RID: 566 RVA: 0x000115D4 File Offset: 0x0000F7D4
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00002928 File Offset: 0x00000B28
		public unsafe float easeOvershootOrAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easeOvershootOrAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easeOvershootOrAmplitude)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000238 RID: 568 RVA: 0x000115FC File Offset: 0x0000F7FC
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002943 File Offset: 0x00000B43
		public unsafe float easePeriod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easePeriod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easePeriod)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00011624 File Offset: 0x0000F824
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0000295E File Offset: 0x00000B5E
		public unsafe Type typeofT1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofT1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofT1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00011654 File Offset: 0x0000F854
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0000297D File Offset: 0x00000B7D
		public unsafe Type typeofT2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofT2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofT2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00011684 File Offset: 0x0000F884
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0000299C File Offset: 0x00000B9C
		public unsafe Type typeofTPlugOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofTPlugOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofTPlugOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000116B4 File Offset: 0x0000F8B4
		// (set) Token: 0x06000241 RID: 577 RVA: 0x000029BB File Offset: 0x00000BBB
		public unsafe bool _active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr__active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr__active_k__BackingField)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000116DC File Offset: 0x0000F8DC
		// (set) Token: 0x06000243 RID: 579 RVA: 0x000029D6 File Offset: 0x00000BD6
		public unsafe bool isSequenced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isSequenced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isSequenced)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00011704 File Offset: 0x0000F904
		// (set) Token: 0x06000245 RID: 581 RVA: 0x000029F1 File Offset: 0x00000BF1
		public unsafe Sequence sequenceParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_sequenceParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_sequenceParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00011734 File Offset: 0x0000F934
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002A10 File Offset: 0x00000C10
		public unsafe int activeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_activeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_activeId)) = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0001175C File Offset: 0x0000F95C
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002A2B File Offset: 0x00000C2B
		public unsafe SpecialStartupMode specialStartupMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_specialStartupMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_specialStartupMode)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00011784 File Offset: 0x0000F984
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00002A46 File Offset: 0x00000C46
		public unsafe bool creationLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_creationLocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_creationLocked)) = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000117AC File Offset: 0x0000F9AC
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002A61 File Offset: 0x00000C61
		public unsafe bool startupDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_startupDone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_startupDone)) = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000117D4 File Offset: 0x0000F9D4
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00002A7C File Offset: 0x00000C7C
		public unsafe bool _playedOnce_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr__playedOnce_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr__playedOnce_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000117FC File Offset: 0x0000F9FC
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00002A97 File Offset: 0x00000C97
		public unsafe float _position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr__position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr__position_k__BackingField)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00011824 File Offset: 0x0000FA24
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public unsafe float fullDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_fullDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_fullDuration)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0001184C File Offset: 0x0000FA4C
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002ACD File Offset: 0x00000CCD
		public unsafe int completedLoops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_completedLoops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_completedLoops)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00011874 File Offset: 0x0000FA74
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002AE8 File Offset: 0x00000CE8
		public unsafe bool isPlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isPlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isPlaying)) = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0001189C File Offset: 0x0000FA9C
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00002B03 File Offset: 0x00000D03
		public unsafe bool isComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isComplete)) = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600025A RID: 602 RVA: 0x000118C4 File Offset: 0x0000FAC4
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00002B1E File Offset: 0x00000D1E
		public unsafe float elapsedDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_elapsedDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_elapsedDelay)) = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600025C RID: 604 RVA: 0x000118EC File Offset: 0x0000FAEC
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002B39 File Offset: 0x00000D39
		public unsafe bool delayComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_delayComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_delayComplete)) = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00011914 File Offset: 0x0000FB14
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002B54 File Offset: 0x00000D54
		public unsafe int miscInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_miscInt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_miscInt)) = value;
			}
		}

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_timeScale;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_isBackwards;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_stringId;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_intId;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_updateType;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_isIndependentUpdate;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr_onPlay;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_onPause;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_onRewind;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_onStepComplete;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_onKill;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_onWaypointChange;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_isFrom;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_isBlendable;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_isRecyclable;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_isSpeedBased;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_autoKill;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_loops;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_loopType;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr__isRelative_k__BackingField;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_easeType;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_customEase;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_easeOvershootOrAmplitude;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_easePeriod;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_typeofT1;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_typeofT2;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_typeofTPlugOptions;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_isSequenced;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_sequenceParent;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_activeId;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_specialStartupMode;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_creationLocked;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_startupDone;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr__playedOnce_k__BackingField;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_fullDuration;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_completedLoops;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_isPlaying;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_isComplete;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_elapsedDelay;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_delayComplete;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr_miscInt;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_get_isRelative_Public_get_Boolean_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_set_isRelative_Internal_set_Void_Boolean_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Internal_set_Void_Boolean_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_get_fullPosition_Public_get_Single_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_set_fullPosition_Public_set_Void_Single_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_get_playedOnce_Public_get_Boolean_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_set_playedOnce_Private_set_Void_Boolean_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Single_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Internal_set_Void_Single_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_New_Single_Single_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_Startup_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTween_Internal_Abstract_Virtual_New_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_DoGoto_Internal_Static_Boolean_Tween_Single_Int32_UpdateMode_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_1_T_T_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000DB RID: 219
		private sealed class MethodInfoStoreGeneric_OnTweenCallback_Internal_Static_Boolean_TweenCallback_1_T_T_0<T>
		{
			// Token: 0x0400063C RID: 1596
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tween.NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_1_T_T_0, Il2CppClassPointerStore<Tween>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
