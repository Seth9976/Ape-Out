using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000028 RID: 40
	[StructLayout(2)]
	public struct AnimatorControllerPlayable
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x0000D944 File Offset: 0x0000BB44
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorControllerPlayable()
		{
			Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimatorControllerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr);
			AnimatorControllerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, "m_Handle");
			AnimatorControllerPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimatorControllerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663460);
			AnimatorControllerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663461);
			AnimatorControllerPlayable.NativeMethodInfoPtr_SetHandle_Public_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663462);
			AnimatorControllerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimatorControllerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663463);
			AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoInternal");
			AnimatorControllerPlayable.GetAnimatorControllerInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorControllerInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorControllerInternal");
			AnimatorControllerPlayable.GetLayerCountInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerCountInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerCountInternal");
			AnimatorControllerPlayable.GetLayerNameInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerNameInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerNameInternal");
			AnimatorControllerPlayable.GetLayerIndexInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerIndexInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerIndexInternal");
			AnimatorControllerPlayable.GetLayerWeightInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerWeightInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerWeightInternal");
			AnimatorControllerPlayable.SetLayerWeightInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetLayerWeightInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetLayerWeightInternal");
			AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfoInternal");
			AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoCountInternal");
			AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfoInternal");
			AnimatorControllerPlayable.ResolveHashInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.ResolveHashInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::ResolveHashInternal");
			AnimatorControllerPlayable.IsInTransitionInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.IsInTransitionInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::IsInTransitionInternal");
			AnimatorControllerPlayable.GetParametersArrayInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetParametersArrayInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetParametersArrayInternal");
			AnimatorControllerPlayable.GetParameterInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetParameterInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetParameterInternal");
			AnimatorControllerPlayable.GetParameterCountInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetParameterCountInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetParameterCountInternal");
			AnimatorControllerPlayable.StringToHashDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.StringToHashDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::StringToHash");
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInFixedTimeInternal");
			AnimatorControllerPlayable.CrossFadeInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.CrossFadeInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInternal");
			AnimatorControllerPlayable.PlayInFixedTimeInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.PlayInFixedTimeInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::PlayInFixedTimeInternal");
			AnimatorControllerPlayable.PlayInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.PlayInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::PlayInternal");
			AnimatorControllerPlayable.HasStateInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.HasStateInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::HasStateInternal");
			AnimatorControllerPlayable.SetFloatStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetFloatStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetFloatString");
			AnimatorControllerPlayable.SetFloatIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetFloatIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetFloatID");
			AnimatorControllerPlayable.GetFloatStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetFloatStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetFloatString");
			AnimatorControllerPlayable.GetFloatIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetFloatIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetFloatID");
			AnimatorControllerPlayable.SetBoolStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetBoolStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetBoolString");
			AnimatorControllerPlayable.SetBoolIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetBoolIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetBoolID");
			AnimatorControllerPlayable.GetBoolStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetBoolStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetBoolString");
			AnimatorControllerPlayable.GetBoolIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetBoolIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetBoolID");
			AnimatorControllerPlayable.SetIntegerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetIntegerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerString");
			AnimatorControllerPlayable.SetIntegerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetIntegerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerID");
			AnimatorControllerPlayable.GetIntegerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetIntegerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerString");
			AnimatorControllerPlayable.GetIntegerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetIntegerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerID");
			AnimatorControllerPlayable.SetTriggerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetTriggerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerString");
			AnimatorControllerPlayable.SetTriggerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetTriggerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerID");
			AnimatorControllerPlayable.ResetTriggerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.ResetTriggerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerString");
			AnimatorControllerPlayable.ResetTriggerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.ResetTriggerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerID");
			AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveString");
			AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveID");
			AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::CreateHandleInternal_Injected");
			AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorStateInfoInternal_Injected");
			AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorStateInfoInternal_Injected");
			AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorTransitionInfoInternal_Injected");
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000DC74 File Offset: 0x0000BE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484632, XrefRangeEnd = 484641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatorControllerPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000DCA8 File Offset: 0x0000BEA8
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000DCD8 File Offset: 0x0000BED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484646, RefRangeEnd = 484647, XrefRangeStart = 484641, XrefRangeEnd = 484646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandle(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr_SetHandle_Public_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000DD0C File Offset: 0x0000BF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484647, XrefRangeEnd = 484654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimatorControllerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimatorControllerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00004518 File Offset: 0x00002718
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0000DD4C File Offset: 0x0000BF4C
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x0000452A File Offset: 0x0000272A
		public unsafe static AnimatorControllerPlayable m_NullPlayable
		{
			get
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimatorControllerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animatorControllerPlayable));
				return animatorControllerPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimatorControllerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0000DD68 File Offset: 0x0000BF68
		public static AnimatorControllerPlayable Null
		{
			get
			{
				return AnimatorControllerPlayable.m_NullPlayable;
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000DD80 File Offset: 0x0000BF80
		public static AnimatorControllerPlayable Create(PlayableGraph graph, RuntimeAnimatorController controller)
		{
			PlayableHandle playableHandle = AnimatorControllerPlayable.CreateHandle(graph, controller);
			return new AnimatorControllerPlayable(playableHandle);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		public static PlayableHandle CreateHandle(PlayableGraph graph, RuntimeAnimatorController controller)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimatorControllerPlayable.CreateHandleInternal(graph, controller, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000DDD4 File Offset: 0x0000BFD4
		public static implicit operator Playable(AnimatorControllerPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000DDF4 File Offset: 0x0000BFF4
		public static explicit operator AnimatorControllerPlayable(Playable playable)
		{
			return new AnimatorControllerPlayable(playable.GetHandle());
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000DE14 File Offset: 0x0000C014
		public float GetFloat(string name)
		{
			return AnimatorControllerPlayable.GetFloatString(ref this.m_Handle, name);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000DE34 File Offset: 0x0000C034
		public float GetFloat(int id)
		{
			return AnimatorControllerPlayable.GetFloatID(ref this.m_Handle, id);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00004538 File Offset: 0x00002738
		public void SetFloat(string name, float value)
		{
			AnimatorControllerPlayable.SetFloatString(ref this.m_Handle, name, value);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00004549 File Offset: 0x00002749
		public void SetFloat(int id, float value)
		{
			AnimatorControllerPlayable.SetFloatID(ref this.m_Handle, id, value);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000DE54 File Offset: 0x0000C054
		public bool GetBool(string name)
		{
			return AnimatorControllerPlayable.GetBoolString(ref this.m_Handle, name);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000DE74 File Offset: 0x0000C074
		public bool GetBool(int id)
		{
			return AnimatorControllerPlayable.GetBoolID(ref this.m_Handle, id);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000455A File Offset: 0x0000275A
		public void SetBool(string name, bool value)
		{
			AnimatorControllerPlayable.SetBoolString(ref this.m_Handle, name, value);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000456B File Offset: 0x0000276B
		public void SetBool(int id, bool value)
		{
			AnimatorControllerPlayable.SetBoolID(ref this.m_Handle, id, value);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000DE94 File Offset: 0x0000C094
		public int GetInteger(string name)
		{
			return AnimatorControllerPlayable.GetIntegerString(ref this.m_Handle, name);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000DEB4 File Offset: 0x0000C0B4
		public int GetInteger(int id)
		{
			return AnimatorControllerPlayable.GetIntegerID(ref this.m_Handle, id);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000457C File Offset: 0x0000277C
		public void SetInteger(string name, int value)
		{
			AnimatorControllerPlayable.SetIntegerString(ref this.m_Handle, name, value);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000458D File Offset: 0x0000278D
		public void SetInteger(int id, int value)
		{
			AnimatorControllerPlayable.SetIntegerID(ref this.m_Handle, id, value);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000459E File Offset: 0x0000279E
		public void SetTrigger(string name)
		{
			AnimatorControllerPlayable.SetTriggerString(ref this.m_Handle, name);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000045AE File Offset: 0x000027AE
		public void SetTrigger(int id)
		{
			AnimatorControllerPlayable.SetTriggerID(ref this.m_Handle, id);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000045BE File Offset: 0x000027BE
		public void ResetTrigger(string name)
		{
			AnimatorControllerPlayable.ResetTriggerString(ref this.m_Handle, name);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000045CE File Offset: 0x000027CE
		public void ResetTrigger(int id)
		{
			AnimatorControllerPlayable.ResetTriggerID(ref this.m_Handle, id);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000DED4 File Offset: 0x0000C0D4
		public bool IsParameterControlledByCurve(string name)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveString(ref this.m_Handle, name);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
		public bool IsParameterControlledByCurve(int id)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveID(ref this.m_Handle, id);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000DF14 File Offset: 0x0000C114
		public int GetLayerCount()
		{
			return AnimatorControllerPlayable.GetLayerCountInternal(ref this.m_Handle);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000DF34 File Offset: 0x0000C134
		public string GetLayerName(int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerNameInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000DF54 File Offset: 0x0000C154
		public int GetLayerIndex(string layerName)
		{
			return AnimatorControllerPlayable.GetLayerIndexInternal(ref this.m_Handle, layerName);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000DF74 File Offset: 0x0000C174
		public float GetLayerWeight(int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerWeightInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000045DE File Offset: 0x000027DE
		public void SetLayerWeight(int layerIndex, float weight)
		{
			AnimatorControllerPlayable.SetLayerWeightInternal(ref this.m_Handle, layerIndex, weight);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000DF94 File Offset: 0x0000C194
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000DFD4 File Offset: 0x0000C1D4
		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
		public Il2CppStructArray<AnimatorClipInfo> GetCurrentAnimatorClipInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000E014 File Offset: 0x0000C214
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			bool flag = clips == null;
			if (flag)
			{
				throw new ArgumentNullException("clips");
			}
			AnimatorControllerPlayable.GetAnimatorClipInfoInternal(ref this.m_Handle, layerIndex, true, clips);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000E044 File Offset: 0x0000C244
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			bool flag = clips == null;
			if (flag)
			{
				throw new ArgumentNullException("clips");
			}
			AnimatorControllerPlayable.GetAnimatorClipInfoInternal(ref this.m_Handle, layerIndex, false, clips);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000045EF File Offset: 0x000027EF
		public static void GetAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex, bool isCurrent, Object clips)
		{
			AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegateField(ref handle, layerIndex, isCurrent, IL2CPP.Il2CppObjectBaseToPtr(clips));
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000E074 File Offset: 0x0000C274
		public int GetCurrentAnimatorClipInfoCount(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternal(ref this.m_Handle, layerIndex, true);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000E094 File Offset: 0x0000C294
		public int GetNextAnimatorClipInfoCount(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternal(ref this.m_Handle, layerIndex, false);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		public Il2CppStructArray<AnimatorClipInfo> GetNextAnimatorClipInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetNextAnimatorClipInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000E0D4 File Offset: 0x0000C2D4
		public bool IsInTransition(int layerIndex)
		{
			return AnimatorControllerPlayable.IsInTransitionInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000E0F4 File Offset: 0x0000C2F4
		public int GetParameterCount()
		{
			return AnimatorControllerPlayable.GetParameterCountInternal(ref this.m_Handle);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00004604 File Offset: 0x00002804
		public AnimatorControllerParameter GetParameter(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00004611 File Offset: 0x00002811
		public void CrossFadeInFixedTime(string stateName, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, -1, 0f);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000462D File Offset: 0x0000282D
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, 0f);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00004649 File Offset: 0x00002849
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, fixedTime);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00004662 File Offset: 0x00002862
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, stateNameHash, transitionDuration, -1, 0f);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00004679 File Offset: 0x00002879
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, 0f);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00004690 File Offset: 0x00002890
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000046A4 File Offset: 0x000028A4
		public void CrossFade(string stateName, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, -1, float.NegativeInfinity);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000046C0 File Offset: 0x000028C0
		public void CrossFade(string stateName, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, float.NegativeInfinity);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000046DC File Offset: 0x000028DC
		public void CrossFade(string stateName, float transitionDuration, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, normalizedTime);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000046F5 File Offset: 0x000028F5
		public void CrossFade(int stateNameHash, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, stateNameHash, transitionDuration, -1, float.NegativeInfinity);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000470C File Offset: 0x0000290C
		public void CrossFade(int stateNameHash, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, float.NegativeInfinity);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00004723 File Offset: 0x00002923
		public void CrossFade(int stateNameHash, float transitionDuration, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00004737 File Offset: 0x00002937
		public void PlayInFixedTime(string stateName)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), -1, float.NegativeInfinity);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00004752 File Offset: 0x00002952
		public void PlayInFixedTime(string stateName, int layer)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, float.NegativeInfinity);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000476D File Offset: 0x0000296D
		public void PlayInFixedTime(string stateName, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, fixedTime);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00004784 File Offset: 0x00002984
		public void PlayInFixedTime(int stateNameHash)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, stateNameHash, -1, float.NegativeInfinity);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000479A File Offset: 0x0000299A
		public void PlayInFixedTime(int stateNameHash, int layer)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, stateNameHash, layer, float.NegativeInfinity);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000047B0 File Offset: 0x000029B0
		public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, stateNameHash, layer, fixedTime);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000047C2 File Offset: 0x000029C2
		public void Play(string stateName)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), -1, float.NegativeInfinity);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000047DD File Offset: 0x000029DD
		public void Play(string stateName, int layer)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, float.NegativeInfinity);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000047F8 File Offset: 0x000029F8
		public void Play(string stateName, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, normalizedTime);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000480F File Offset: 0x00002A0F
		public void Play(int stateNameHash)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, stateNameHash, -1, float.NegativeInfinity);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00004825 File Offset: 0x00002A25
		public void Play(int stateNameHash, int layer)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, stateNameHash, layer, float.NegativeInfinity);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000483B File Offset: 0x00002A3B
		public void Play(int stateNameHash, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, stateNameHash, layer, normalizedTime);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000E114 File Offset: 0x0000C314
		public bool HasState(int layerIndex, int stateID)
		{
			return AnimatorControllerPlayable.HasStateInternal(ref this.m_Handle, layerIndex, stateID);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000E134 File Offset: 0x0000C334
		public string ResolveHash(int hash)
		{
			return AnimatorControllerPlayable.ResolveHashInternal(ref this.m_Handle, hash);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000484D File Offset: 0x00002A4D
		public static bool CreateHandleInternal(PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.CreateHandleInternal_Injected(ref graph, controller, ref handle);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000E154 File Offset: 0x0000C354
		public static RuntimeAnimatorController GetAnimatorControllerInternal(ref PlayableHandle handle)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetAnimatorControllerInternalDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00004858 File Offset: 0x00002A58
		public static int GetLayerCountInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.GetLayerCountInternalDelegateField(ref handle);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000E17C File Offset: 0x0000C37C
		public static string GetLayerNameInternal(ref PlayableHandle handle, int layerIndex)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetLayerNameInternalDelegateField(ref handle, layerIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00004865 File Offset: 0x00002A65
		public static int GetLayerIndexInternal(ref PlayableHandle handle, string layerName)
		{
			return AnimatorControllerPlayable.GetLayerIndexInternalDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(layerName));
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00004878 File Offset: 0x00002A78
		public static float GetLayerWeightInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerWeightInternalDelegateField(ref handle, layerIndex);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00004886 File Offset: 0x00002A86
		public static void SetLayerWeightInternal(ref PlayableHandle handle, int layerIndex, float weight)
		{
			AnimatorControllerPlayable.SetLayerWeightInternalDelegateField(ref handle, layerIndex, weight);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000E19C File Offset: 0x0000C39C
		public static AnimatorStateInfo GetCurrentAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			AnimatorStateInfo animatorStateInfo;
			AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_Injected(ref handle, layerIndex, out animatorStateInfo);
			return animatorStateInfo;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
		public static AnimatorStateInfo GetNextAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			AnimatorStateInfo animatorStateInfo;
			AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_Injected(ref handle, layerIndex, out animatorStateInfo);
			return animatorStateInfo;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000E1CC File Offset: 0x0000C3CC
		public static AnimatorTransitionInfo GetAnimatorTransitionInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_Injected(ref handle, layerIndex, out animatorTransitionInfo);
			return animatorTransitionInfo;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000E1E4 File Offset: 0x0000C3E4
		public static Il2CppStructArray<AnimatorClipInfo> GetCurrentAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegateField(ref handle, layerIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AnimatorClipInfo>>(intPtr2) : null;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00004895 File Offset: 0x00002A95
		public static int GetAnimatorClipInfoCountInternal(ref PlayableHandle handle, int layerIndex, bool current)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegateField(ref handle, layerIndex, current);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000E20C File Offset: 0x0000C40C
		public static Il2CppStructArray<AnimatorClipInfo> GetNextAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegateField(ref handle, layerIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AnimatorClipInfo>>(intPtr2) : null;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000E234 File Offset: 0x0000C434
		public static string ResolveHashInternal(ref PlayableHandle handle, int hash)
		{
			IntPtr intPtr = AnimatorControllerPlayable.ResolveHashInternalDelegateField(ref handle, hash);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000048A4 File Offset: 0x00002AA4
		public static bool IsInTransitionInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.IsInTransitionInternalDelegateField(ref handle, layerIndex);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000E254 File Offset: 0x0000C454
		public static Il2CppReferenceArray<AnimatorControllerParameter> GetParametersArrayInternal(ref PlayableHandle handle)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetParametersArrayInternalDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimatorControllerParameter>>(intPtr2) : null;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000E27C File Offset: 0x0000C47C
		public static AnimatorControllerParameter GetParameterInternal(ref PlayableHandle handle, int index)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetParameterInternalDelegateField(ref handle, index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatorControllerParameter>(intPtr2) : null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000048B2 File Offset: 0x00002AB2
		public static int GetParameterCountInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.GetParameterCountInternalDelegateField(ref handle);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000048BF File Offset: 0x00002ABF
		public static int StringToHash(string name)
		{
			return AnimatorControllerPlayable.StringToHashDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000048D1 File Offset: 0x00002AD1
		public static void CrossFadeInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegateField(ref handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000048E3 File Offset: 0x00002AE3
		public static void CrossFadeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternalDelegateField(ref handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000048F5 File Offset: 0x00002AF5
		public static void PlayInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternalDelegateField(ref handle, stateNameHash, layer, fixedTime);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00004905 File Offset: 0x00002B05
		public static void PlayInternal(ref PlayableHandle handle, int stateNameHash, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternalDelegateField(ref handle, stateNameHash, layer, normalizedTime);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00004915 File Offset: 0x00002B15
		public static bool HasStateInternal(ref PlayableHandle handle, int layerIndex, int stateID)
		{
			return AnimatorControllerPlayable.HasStateInternalDelegateField(ref handle, layerIndex, stateID);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00004924 File Offset: 0x00002B24
		public static void SetFloatString(ref PlayableHandle handle, string name, float value)
		{
			AnimatorControllerPlayable.SetFloatStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00004938 File Offset: 0x00002B38
		public static void SetFloatID(ref PlayableHandle handle, int id, float value)
		{
			AnimatorControllerPlayable.SetFloatIDDelegateField(ref handle, id, value);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00004947 File Offset: 0x00002B47
		public static float GetFloatString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.GetFloatStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000495A File Offset: 0x00002B5A
		public static float GetFloatID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.GetFloatIDDelegateField(ref handle, id);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00004968 File Offset: 0x00002B68
		public static void SetBoolString(ref PlayableHandle handle, string name, bool value)
		{
			AnimatorControllerPlayable.SetBoolStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000497C File Offset: 0x00002B7C
		public static void SetBoolID(ref PlayableHandle handle, int id, bool value)
		{
			AnimatorControllerPlayable.SetBoolIDDelegateField(ref handle, id, value);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000498B File Offset: 0x00002B8B
		public static bool GetBoolString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.GetBoolStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000499E File Offset: 0x00002B9E
		public static bool GetBoolID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.GetBoolIDDelegateField(ref handle, id);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000049AC File Offset: 0x00002BAC
		public static void SetIntegerString(ref PlayableHandle handle, string name, int value)
		{
			AnimatorControllerPlayable.SetIntegerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x000049C0 File Offset: 0x00002BC0
		public static void SetIntegerID(ref PlayableHandle handle, int id, int value)
		{
			AnimatorControllerPlayable.SetIntegerIDDelegateField(ref handle, id, value);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000049CF File Offset: 0x00002BCF
		public static int GetIntegerString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.GetIntegerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000049E2 File Offset: 0x00002BE2
		public static int GetIntegerID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.GetIntegerIDDelegateField(ref handle, id);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000049F0 File Offset: 0x00002BF0
		public static void SetTriggerString(ref PlayableHandle handle, string name)
		{
			AnimatorControllerPlayable.SetTriggerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00004A03 File Offset: 0x00002C03
		public static void SetTriggerID(ref PlayableHandle handle, int id)
		{
			AnimatorControllerPlayable.SetTriggerIDDelegateField(ref handle, id);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00004A11 File Offset: 0x00002C11
		public static void ResetTriggerString(ref PlayableHandle handle, string name)
		{
			AnimatorControllerPlayable.ResetTriggerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00004A24 File Offset: 0x00002C24
		public static void ResetTriggerID(ref PlayableHandle handle, int id)
		{
			AnimatorControllerPlayable.ResetTriggerIDDelegateField(ref handle, id);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00004A32 File Offset: 0x00002C32
		public static bool IsParameterControlledByCurveString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00004A45 File Offset: 0x00002C45
		public static bool IsParameterControlledByCurveID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegateField(ref handle, id);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00004A53 File Offset: 0x00002C53
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(controller), ref handle);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00004A67 File Offset: 0x00002C67
		public static void GetCurrentAnimatorStateInfoInternal_Injected(ref PlayableHandle handle, int layerIndex, out AnimatorStateInfo ret)
		{
			AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegateField(ref handle, layerIndex, out ret);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00004A76 File Offset: 0x00002C76
		public static void GetNextAnimatorStateInfoInternal_Injected(ref PlayableHandle handle, int layerIndex, out AnimatorStateInfo ret)
		{
			AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegateField(ref handle, layerIndex, out ret);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00004A85 File Offset: 0x00002C85
		public static void GetAnimatorTransitionInfoInternal_Injected(ref PlayableHandle handle, int layerIndex, out AnimatorTransitionInfo ret)
		{
			AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegateField(ref handle, layerIndex, out ret);
		}

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_SetHandle_Public_Void_PlayableHandle_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimatorControllerPlayable_0;

		// Token: 0x04000275 RID: 629
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x04000276 RID: 630
		private static readonly AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegate GetAnimatorClipInfoInternalDelegateField;

		// Token: 0x04000277 RID: 631
		private static readonly AnimatorControllerPlayable.GetAnimatorControllerInternalDelegate GetAnimatorControllerInternalDelegateField;

		// Token: 0x04000278 RID: 632
		private static readonly AnimatorControllerPlayable.GetLayerCountInternalDelegate GetLayerCountInternalDelegateField;

		// Token: 0x04000279 RID: 633
		private static readonly AnimatorControllerPlayable.GetLayerNameInternalDelegate GetLayerNameInternalDelegateField;

		// Token: 0x0400027A RID: 634
		private static readonly AnimatorControllerPlayable.GetLayerIndexInternalDelegate GetLayerIndexInternalDelegateField;

		// Token: 0x0400027B RID: 635
		private static readonly AnimatorControllerPlayable.GetLayerWeightInternalDelegate GetLayerWeightInternalDelegateField;

		// Token: 0x0400027C RID: 636
		private static readonly AnimatorControllerPlayable.SetLayerWeightInternalDelegate SetLayerWeightInternalDelegateField;

		// Token: 0x0400027D RID: 637
		private static readonly AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegate GetCurrentAnimatorClipInfoInternalDelegateField;

		// Token: 0x0400027E RID: 638
		private static readonly AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegate GetAnimatorClipInfoCountInternalDelegateField;

		// Token: 0x0400027F RID: 639
		private static readonly AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegate GetNextAnimatorClipInfoInternalDelegateField;

		// Token: 0x04000280 RID: 640
		private static readonly AnimatorControllerPlayable.ResolveHashInternalDelegate ResolveHashInternalDelegateField;

		// Token: 0x04000281 RID: 641
		private static readonly AnimatorControllerPlayable.IsInTransitionInternalDelegate IsInTransitionInternalDelegateField;

		// Token: 0x04000282 RID: 642
		private static readonly AnimatorControllerPlayable.GetParametersArrayInternalDelegate GetParametersArrayInternalDelegateField;

		// Token: 0x04000283 RID: 643
		private static readonly AnimatorControllerPlayable.GetParameterInternalDelegate GetParameterInternalDelegateField;

		// Token: 0x04000284 RID: 644
		private static readonly AnimatorControllerPlayable.GetParameterCountInternalDelegate GetParameterCountInternalDelegateField;

		// Token: 0x04000285 RID: 645
		private static readonly AnimatorControllerPlayable.StringToHashDelegate StringToHashDelegateField;

		// Token: 0x04000286 RID: 646
		private static readonly AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegate CrossFadeInFixedTimeInternalDelegateField;

		// Token: 0x04000287 RID: 647
		private static readonly AnimatorControllerPlayable.CrossFadeInternalDelegate CrossFadeInternalDelegateField;

		// Token: 0x04000288 RID: 648
		private static readonly AnimatorControllerPlayable.PlayInFixedTimeInternalDelegate PlayInFixedTimeInternalDelegateField;

		// Token: 0x04000289 RID: 649
		private static readonly AnimatorControllerPlayable.PlayInternalDelegate PlayInternalDelegateField;

		// Token: 0x0400028A RID: 650
		private static readonly AnimatorControllerPlayable.HasStateInternalDelegate HasStateInternalDelegateField;

		// Token: 0x0400028B RID: 651
		private static readonly AnimatorControllerPlayable.SetFloatStringDelegate SetFloatStringDelegateField;

		// Token: 0x0400028C RID: 652
		private static readonly AnimatorControllerPlayable.SetFloatIDDelegate SetFloatIDDelegateField;

		// Token: 0x0400028D RID: 653
		private static readonly AnimatorControllerPlayable.GetFloatStringDelegate GetFloatStringDelegateField;

		// Token: 0x0400028E RID: 654
		private static readonly AnimatorControllerPlayable.GetFloatIDDelegate GetFloatIDDelegateField;

		// Token: 0x0400028F RID: 655
		private static readonly AnimatorControllerPlayable.SetBoolStringDelegate SetBoolStringDelegateField;

		// Token: 0x04000290 RID: 656
		private static readonly AnimatorControllerPlayable.SetBoolIDDelegate SetBoolIDDelegateField;

		// Token: 0x04000291 RID: 657
		private static readonly AnimatorControllerPlayable.GetBoolStringDelegate GetBoolStringDelegateField;

		// Token: 0x04000292 RID: 658
		private static readonly AnimatorControllerPlayable.GetBoolIDDelegate GetBoolIDDelegateField;

		// Token: 0x04000293 RID: 659
		private static readonly AnimatorControllerPlayable.SetIntegerStringDelegate SetIntegerStringDelegateField;

		// Token: 0x04000294 RID: 660
		private static readonly AnimatorControllerPlayable.SetIntegerIDDelegate SetIntegerIDDelegateField;

		// Token: 0x04000295 RID: 661
		private static readonly AnimatorControllerPlayable.GetIntegerStringDelegate GetIntegerStringDelegateField;

		// Token: 0x04000296 RID: 662
		private static readonly AnimatorControllerPlayable.GetIntegerIDDelegate GetIntegerIDDelegateField;

		// Token: 0x04000297 RID: 663
		private static readonly AnimatorControllerPlayable.SetTriggerStringDelegate SetTriggerStringDelegateField;

		// Token: 0x04000298 RID: 664
		private static readonly AnimatorControllerPlayable.SetTriggerIDDelegate SetTriggerIDDelegateField;

		// Token: 0x04000299 RID: 665
		private static readonly AnimatorControllerPlayable.ResetTriggerStringDelegate ResetTriggerStringDelegateField;

		// Token: 0x0400029A RID: 666
		private static readonly AnimatorControllerPlayable.ResetTriggerIDDelegate ResetTriggerIDDelegateField;

		// Token: 0x0400029B RID: 667
		private static readonly AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegate IsParameterControlledByCurveStringDelegateField;

		// Token: 0x0400029C RID: 668
		private static readonly AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegate IsParameterControlledByCurveIDDelegateField;

		// Token: 0x0400029D RID: 669
		private static readonly AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x0400029E RID: 670
		private static readonly AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegate GetCurrentAnimatorStateInfoInternal_InjectedDelegateField;

		// Token: 0x0400029F RID: 671
		private static readonly AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegate GetNextAnimatorStateInfoInternal_InjectedDelegateField;

		// Token: 0x040002A0 RID: 672
		private static readonly AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegate GetAnimatorTransitionInfoInternal_InjectedDelegateField;

		// Token: 0x020001A7 RID: 423
		// (Invoke) Token: 0x06000844 RID: 2116
		private delegate void GetAnimatorClipInfoInternalDelegate(IntPtr handle, int layerIndex, bool isCurrent, IntPtr clips);

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x06000846 RID: 2118
		private delegate IntPtr GetAnimatorControllerInternalDelegate(IntPtr handle);

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x06000848 RID: 2120
		private delegate int GetLayerCountInternalDelegate(IntPtr handle);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x0600084A RID: 2122
		private delegate IntPtr GetLayerNameInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x020001AB RID: 427
		// (Invoke) Token: 0x0600084C RID: 2124
		private delegate int GetLayerIndexInternalDelegate(IntPtr handle, IntPtr layerName);

		// Token: 0x020001AC RID: 428
		// (Invoke) Token: 0x0600084E RID: 2126
		private delegate float GetLayerWeightInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x020001AD RID: 429
		// (Invoke) Token: 0x06000850 RID: 2128
		private delegate void SetLayerWeightInternalDelegate(IntPtr handle, int layerIndex, float weight);

		// Token: 0x020001AE RID: 430
		// (Invoke) Token: 0x06000852 RID: 2130
		private delegate IntPtr GetCurrentAnimatorClipInfoInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x020001AF RID: 431
		// (Invoke) Token: 0x06000854 RID: 2132
		private delegate int GetAnimatorClipInfoCountInternalDelegate(IntPtr handle, int layerIndex, bool current);

		// Token: 0x020001B0 RID: 432
		// (Invoke) Token: 0x06000856 RID: 2134
		private delegate IntPtr GetNextAnimatorClipInfoInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x020001B1 RID: 433
		// (Invoke) Token: 0x06000858 RID: 2136
		private delegate IntPtr ResolveHashInternalDelegate(IntPtr handle, int hash);

		// Token: 0x020001B2 RID: 434
		// (Invoke) Token: 0x0600085A RID: 2138
		private delegate bool IsInTransitionInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x020001B3 RID: 435
		// (Invoke) Token: 0x0600085C RID: 2140
		private delegate IntPtr GetParametersArrayInternalDelegate(IntPtr handle);

		// Token: 0x020001B4 RID: 436
		// (Invoke) Token: 0x0600085E RID: 2142
		private delegate IntPtr GetParameterInternalDelegate(IntPtr handle, int index);

		// Token: 0x020001B5 RID: 437
		// (Invoke) Token: 0x06000860 RID: 2144
		private delegate int GetParameterCountInternalDelegate(IntPtr handle);

		// Token: 0x020001B6 RID: 438
		// (Invoke) Token: 0x06000862 RID: 2146
		private delegate int StringToHashDelegate(IntPtr name);

		// Token: 0x020001B7 RID: 439
		// (Invoke) Token: 0x06000864 RID: 2148
		private delegate void CrossFadeInFixedTimeInternalDelegate(IntPtr handle, int stateNameHash, float transitionDuration, int layer, float fixedTime);

		// Token: 0x020001B8 RID: 440
		// (Invoke) Token: 0x06000866 RID: 2150
		private delegate void CrossFadeInternalDelegate(IntPtr handle, int stateNameHash, float transitionDuration, int layer, float normalizedTime);

		// Token: 0x020001B9 RID: 441
		// (Invoke) Token: 0x06000868 RID: 2152
		private delegate void PlayInFixedTimeInternalDelegate(IntPtr handle, int stateNameHash, int layer, float fixedTime);

		// Token: 0x020001BA RID: 442
		// (Invoke) Token: 0x0600086A RID: 2154
		private delegate void PlayInternalDelegate(IntPtr handle, int stateNameHash, int layer, float normalizedTime);

		// Token: 0x020001BB RID: 443
		// (Invoke) Token: 0x0600086C RID: 2156
		private delegate bool HasStateInternalDelegate(IntPtr handle, int layerIndex, int stateID);

		// Token: 0x020001BC RID: 444
		// (Invoke) Token: 0x0600086E RID: 2158
		private delegate void SetFloatStringDelegate(IntPtr handle, IntPtr name, float value);

		// Token: 0x020001BD RID: 445
		// (Invoke) Token: 0x06000870 RID: 2160
		private delegate void SetFloatIDDelegate(IntPtr handle, int id, float value);

		// Token: 0x020001BE RID: 446
		// (Invoke) Token: 0x06000872 RID: 2162
		private delegate float GetFloatStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x020001BF RID: 447
		// (Invoke) Token: 0x06000874 RID: 2164
		private delegate float GetFloatIDDelegate(IntPtr handle, int id);

		// Token: 0x020001C0 RID: 448
		// (Invoke) Token: 0x06000876 RID: 2166
		private delegate void SetBoolStringDelegate(IntPtr handle, IntPtr name, bool value);

		// Token: 0x020001C1 RID: 449
		// (Invoke) Token: 0x06000878 RID: 2168
		private delegate void SetBoolIDDelegate(IntPtr handle, int id, bool value);

		// Token: 0x020001C2 RID: 450
		// (Invoke) Token: 0x0600087A RID: 2170
		private delegate bool GetBoolStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x020001C3 RID: 451
		// (Invoke) Token: 0x0600087C RID: 2172
		private delegate bool GetBoolIDDelegate(IntPtr handle, int id);

		// Token: 0x020001C4 RID: 452
		// (Invoke) Token: 0x0600087E RID: 2174
		private delegate void SetIntegerStringDelegate(IntPtr handle, IntPtr name, int value);

		// Token: 0x020001C5 RID: 453
		// (Invoke) Token: 0x06000880 RID: 2176
		private delegate void SetIntegerIDDelegate(IntPtr handle, int id, int value);

		// Token: 0x020001C6 RID: 454
		// (Invoke) Token: 0x06000882 RID: 2178
		private delegate int GetIntegerStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x020001C7 RID: 455
		// (Invoke) Token: 0x06000884 RID: 2180
		private delegate int GetIntegerIDDelegate(IntPtr handle, int id);

		// Token: 0x020001C8 RID: 456
		// (Invoke) Token: 0x06000886 RID: 2182
		private delegate void SetTriggerStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x020001C9 RID: 457
		// (Invoke) Token: 0x06000888 RID: 2184
		private delegate void SetTriggerIDDelegate(IntPtr handle, int id);

		// Token: 0x020001CA RID: 458
		// (Invoke) Token: 0x0600088A RID: 2186
		private delegate void ResetTriggerStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x020001CB RID: 459
		// (Invoke) Token: 0x0600088C RID: 2188
		private delegate void ResetTriggerIDDelegate(IntPtr handle, int id);

		// Token: 0x020001CC RID: 460
		// (Invoke) Token: 0x0600088E RID: 2190
		private delegate bool IsParameterControlledByCurveStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x020001CD RID: 461
		// (Invoke) Token: 0x06000890 RID: 2192
		private delegate bool IsParameterControlledByCurveIDDelegate(IntPtr handle, int id);

		// Token: 0x020001CE RID: 462
		// (Invoke) Token: 0x06000892 RID: 2194
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr controller, IntPtr handle);

		// Token: 0x020001CF RID: 463
		// (Invoke) Token: 0x06000894 RID: 2196
		private delegate void GetCurrentAnimatorStateInfoInternal_InjectedDelegate(IntPtr handle, int layerIndex, [Out] IntPtr ret);

		// Token: 0x020001D0 RID: 464
		// (Invoke) Token: 0x06000896 RID: 2198
		private delegate void GetNextAnimatorStateInfoInternal_InjectedDelegate(IntPtr handle, int layerIndex, [Out] IntPtr ret);

		// Token: 0x020001D1 RID: 465
		// (Invoke) Token: 0x06000898 RID: 2200
		private delegate void GetAnimatorTransitionInfoInternal_InjectedDelegate(IntPtr handle, int layerIndex, [Out] IntPtr ret);
	}
}
