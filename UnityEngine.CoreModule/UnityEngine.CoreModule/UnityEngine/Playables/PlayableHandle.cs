using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x0200018B RID: 395
	[StructLayout(2)]
	public struct PlayableHandle
	{
		// Token: 0x06001DF0 RID: 7664 RVA: 0x0006DFB4 File Offset: 0x0006C1B4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableHandle()
		{
			Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr);
			PlayableHandle.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Handle");
			PlayableHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Version");
			PlayableHandle.NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Null");
			PlayableHandle.NativeMethodInfoPtr_GetObject_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665988);
			PlayableHandle.NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665989);
			PlayableHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665990);
			PlayableHandle.NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665991);
			PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665992);
			PlayableHandle.NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665993);
			PlayableHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665994);
			PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665995);
			PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665996);
			PlayableHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665997);
			PlayableHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665998);
			PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665999);
			PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666000);
			PlayableHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666001);
			PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666002);
			PlayableHandle.NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666003);
			PlayableHandle.NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666004);
			PlayableHandle.NativeMethodInfoPtr_Play_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666005);
			PlayableHandle.NativeMethodInfoPtr_Pause_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666006);
			PlayableHandle.NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666007);
			PlayableHandle.NativeMethodInfoPtr_GetTime_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666008);
			PlayableHandle.NativeMethodInfoPtr_SetTime_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666009);
			PlayableHandle.NativeMethodInfoPtr_IsDone_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666010);
			PlayableHandle.NativeMethodInfoPtr_GetDuration_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666011);
			PlayableHandle.NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666012);
			PlayableHandle.NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666013);
			PlayableHandle.NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666014);
			PlayableHandle.NativeMethodInfoPtr_GetInputCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666015);
			PlayableHandle.NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666016);
			PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666017);
			PlayableHandle.NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666018);
			PlayableHandle.NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666019);
			PlayableHandle.NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666020);
			PlayableHandle.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666021);
			PlayableHandle.NativeMethodInfoPtr_GetScriptInstance_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666022);
			PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666023);
			PlayableHandle.NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666024);
			PlayableHandle.NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666025);
			PlayableHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666027);
			PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666028);
			PlayableHandle.NativeMethodInfoPtr_SetScriptInstance_Injected_Private_Static_Void_byref_PlayableHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666029);
			PlayableHandle.NativeMethodInfoPtr_GetPlayState_Injected_Private_Static_PlayState_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666030);
			PlayableHandle.NativeMethodInfoPtr_Play_Injected_Private_Static_Void_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666031);
			PlayableHandle.NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666032);
			PlayableHandle.NativeMethodInfoPtr_SetSpeed_Injected_Private_Static_Void_byref_PlayableHandle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666033);
			PlayableHandle.NativeMethodInfoPtr_GetTime_Injected_Private_Static_Double_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666034);
			PlayableHandle.NativeMethodInfoPtr_SetTime_Injected_Private_Static_Void_byref_PlayableHandle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666035);
			PlayableHandle.NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666036);
			PlayableHandle.NativeMethodInfoPtr_GetDuration_Injected_Private_Static_Double_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666037);
			PlayableHandle.NativeMethodInfoPtr_SetDuration_Injected_Private_Static_Void_byref_PlayableHandle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666038);
			PlayableHandle.NativeMethodInfoPtr_SetPropagateSetTime_Injected_Private_Static_Void_byref_PlayableHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666039);
			PlayableHandle.NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666040);
			PlayableHandle.NativeMethodInfoPtr_GetInputCount_Injected_Private_Static_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666041);
			PlayableHandle.NativeMethodInfoPtr_SetInputCount_Injected_Private_Static_Void_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666042);
			PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666043);
			PlayableHandle.NativeMethodInfoPtr_GetPreviousTime_Injected_Private_Static_Double_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666044);
			PlayableHandle.NativeMethodInfoPtr_SetTraversalMode_Injected_Private_Static_Void_byref_PlayableHandle_PlayableTraversalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666045);
			PlayableHandle.NativeMethodInfoPtr_GetTimeWrapMode_Injected_Private_Static_DirectorWrapMode_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666046);
			PlayableHandle.NativeMethodInfoPtr_SetTimeWrapMode_Injected_Private_Static_Void_byref_PlayableHandle_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666047);
			PlayableHandle.NativeMethodInfoPtr_GetScriptInstance_Injected_Private_Static_Object_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666048);
			PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666049);
			PlayableHandle.NativeMethodInfoPtr_SetInputWeightFromIndex_Injected_Private_Static_Void_byref_PlayableHandle_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666050);
			PlayableHandle.NativeMethodInfoPtr_GetInputWeightFromIndex_Injected_Private_Static_Single_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100666051);
			PlayableHandle.IsNull_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsNull_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::IsNull_Injected");
			PlayableHandle.GetJobType_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetJobType_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetJobType_Injected");
			PlayableHandle.CanChangeInputs_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanChangeInputs_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanChangeInputs_Injected");
			PlayableHandle.CanSetWeights_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanSetWeights_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanSetWeights_Injected");
			PlayableHandle.CanDestroy_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanDestroy_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanDestroy_Injected");
			PlayableHandle.GetSpeed_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetSpeed_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetSpeed_Injected");
			PlayableHandle.SetDone_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetDone_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetDone_Injected");
			PlayableHandle.GetPropagateSetTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetPropagateSetTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetPropagateSetTime_Injected");
			PlayableHandle.GetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetOutputCount_Injected");
			PlayableHandle.SetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetOutputCount_Injected");
			PlayableHandle.SetDelay_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetDelay_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetDelay_Injected");
			PlayableHandle.GetDelay_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetDelay_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetDelay_Injected");
			PlayableHandle.IsDelayed_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsDelayed_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::IsDelayed_Injected");
			PlayableHandle.SetLeadTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetLeadTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetLeadTime_Injected");
			PlayableHandle.GetLeadTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetLeadTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetLeadTime_Injected");
			PlayableHandle.GetTraversalMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetTraversalMode_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetTraversalMode_Injected");
			PlayableHandle.GetJobData_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetJobData_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetJobData_Injected");
			PlayableHandle.GetOutputHandle_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetOutputHandle_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetOutputHandle_Injected");
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x0006E61C File Offset: 0x0006C81C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 503656, RefRangeEnd = 503666, XrefRangeStart = 503651, XrefRangeEnd = 503656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetObject<T>() where T : class
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.MethodInfoStoreGeneric_GetObject_Internal_T_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0006E64C File Offset: 0x0006C84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503666, XrefRangeEnd = 503671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayableOfType<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x0006E67C File Offset: 0x0006C87C
		public unsafe static PlayableHandle Null
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503671, XrefRangeEnd = 503675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0006E6AC File Offset: 0x0006C8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503675, XrefRangeEnd = 503676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable GetInput(int inputPort)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputPort;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0006E6EC File Offset: 0x0006C8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503676, XrefRangeEnd = 503677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetInputWeight(int inputIndex, float weight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x0006E738 File Offset: 0x0006C938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503677, XrefRangeEnd = 503678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetInputWeight(int inputIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0006E778 File Offset: 0x0006C978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503678, XrefRangeEnd = 503681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PlayableHandle x, PlayableHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0006E7C4 File Offset: 0x0006C9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503681, XrefRangeEnd = 503686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x0006E808 File Offset: 0x0006CA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503686, XrefRangeEnd = 503689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x0006E848 File Offset: 0x0006CA48
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x0006E878 File Offset: 0x0006CA78
		[CallerCount(0)]
		public unsafe static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x0006E8C4 File Offset: 0x0006CAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503689, XrefRangeEnd = 503690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckInputBounds(int inputIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x0006E904 File Offset: 0x0006CB04
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 503691, RefRangeEnd = 503703, XrefRangeStart = 503690, XrefRangeEnd = 503691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckInputBounds(int inputIndex, bool acceptAny)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptAny;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x0006E950 File Offset: 0x0006CB50
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 503710, RefRangeEnd = 503724, XrefRangeStart = 503703, XrefRangeEnd = 503710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0006E980 File Offset: 0x0006CB80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 503731, RefRangeEnd = 503733, XrefRangeStart = 503724, XrefRangeEnd = 503731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetPlayableType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Internal_Type_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0006E9B4 File Offset: 0x0006CBB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503740, RefRangeEnd = 503741, XrefRangeStart = 503733, XrefRangeEnd = 503740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScriptInstance(Object scriptInstance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scriptInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0006E9EC File Offset: 0x0006CBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503741, XrefRangeEnd = 503748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayState GetPlayState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0006EA1C File Offset: 0x0006CC1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503755, RefRangeEnd = 503756, XrefRangeStart = 503748, XrefRangeEnd = 503755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Play_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0006EA44 File Offset: 0x0006CC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503756, XrefRangeEnd = 503763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Pause_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x0006EA6C File Offset: 0x0006CC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503763, XrefRangeEnd = 503770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpeed(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0006EAA0 File Offset: 0x0006CCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503770, XrefRangeEnd = 503777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetTime_Internal_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x0006EAD0 File Offset: 0x0006CCD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503784, RefRangeEnd = 503785, XrefRangeStart = 503777, XrefRangeEnd = 503784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTime_Internal_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x0006EB04 File Offset: 0x0006CD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503785, XrefRangeEnd = 503792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsDone_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0006EB34 File Offset: 0x0006CD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503792, XrefRangeEnd = 503799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetDuration()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetDuration_Internal_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x0006EB64 File Offset: 0x0006CD64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 503806, RefRangeEnd = 503808, XrefRangeStart = 503799, XrefRangeEnd = 503806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDuration(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x0006EB98 File Offset: 0x0006CD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503808, XrefRangeEnd = 503815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPropagateSetTime(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0006EBCC File Offset: 0x0006CDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503815, XrefRangeEnd = 503820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableGraph GetGraph()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x0006EBFC File Offset: 0x0006CDFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 503827, RefRangeEnd = 503830, XrefRangeStart = 503820, XrefRangeEnd = 503827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInputCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputCount_Internal_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x0006EC2C File Offset: 0x0006CE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503837, RefRangeEnd = 503838, XrefRangeStart = 503830, XrefRangeEnd = 503837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInputCount(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x0006EC60 File Offset: 0x0006CE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503838, XrefRangeEnd = 503843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInputWeight(PlayableHandle input, float weight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0006ECA0 File Offset: 0x0006CEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503843, XrefRangeEnd = 503850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetPreviousTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0006ECD0 File Offset: 0x0006CED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503850, XrefRangeEnd = 503857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTraversalMode(PlayableTraversalMode mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0006ED04 File Offset: 0x0006CF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503857, XrefRangeEnd = 503864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectorWrapMode GetTimeWrapMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0006ED34 File Offset: 0x0006CF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503864, XrefRangeEnd = 503871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeWrapMode(DirectorWrapMode mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x0006ED68 File Offset: 0x0006CF68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503878, RefRangeEnd = 503879, XrefRangeStart = 503871, XrefRangeEnd = 503878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetScriptInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetScriptInstance_Private_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0006ED9C File Offset: 0x0006CF9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503884, RefRangeEnd = 503885, XrefRangeStart = 503879, XrefRangeEnd = 503884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableHandle GetInputHandle(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0006EDDC File Offset: 0x0006CFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503885, XrefRangeEnd = 503892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInputWeightFromIndex(int index, float weight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0006EE1C File Offset: 0x0006D01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503892, XrefRangeEnd = 503901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetInputWeightFromIndex(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0006EE5C File Offset: 0x0006D05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503901, XrefRangeEnd = 503905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x0006EE9C File Offset: 0x0006D09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503905, XrefRangeEnd = 503909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetPlayableType_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0006EEDC File Offset: 0x0006D0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503909, XrefRangeEnd = 503913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetScriptInstance_Injected(ref PlayableHandle _unity_self, Object scriptInstance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scriptInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetScriptInstance_Injected_Private_Static_Void_byref_PlayableHandle_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0006EF20 File Offset: 0x0006D120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503913, XrefRangeEnd = 503917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayState GetPlayState_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayState_Injected_Private_Static_PlayState_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x0006EF60 File Offset: 0x0006D160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503917, XrefRangeEnd = 503921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Play_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Play_Injected_Private_Static_Void_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0006EF94 File Offset: 0x0006D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503921, XrefRangeEnd = 503925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x0006EFC8 File Offset: 0x0006D1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503925, XrefRangeEnd = 503929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSpeed_Injected(ref PlayableHandle _unity_self, double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetSpeed_Injected_Private_Static_Void_byref_PlayableHandle_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0006F008 File Offset: 0x0006D208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503929, XrefRangeEnd = 503933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetTime_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetTime_Injected_Private_Static_Double_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0006F048 File Offset: 0x0006D248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503933, XrefRangeEnd = 503937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTime_Injected(ref PlayableHandle _unity_self, double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTime_Injected_Private_Static_Void_byref_PlayableHandle_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0006F088 File Offset: 0x0006D288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503937, XrefRangeEnd = 503941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDone_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0006F0C8 File Offset: 0x0006D2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503941, XrefRangeEnd = 503945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetDuration_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetDuration_Injected_Private_Static_Double_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0006F108 File Offset: 0x0006D308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503945, XrefRangeEnd = 503949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDuration_Injected(ref PlayableHandle _unity_self, double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetDuration_Injected_Private_Static_Void_byref_PlayableHandle_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0006F148 File Offset: 0x0006D348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503949, XrefRangeEnd = 503953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetPropagateSetTime_Injected_Private_Static_Void_byref_PlayableHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0006F188 File Offset: 0x0006D388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503953, XrefRangeEnd = 503957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x0006F1C8 File Offset: 0x0006D3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503957, XrefRangeEnd = 503961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInputCount_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputCount_Injected_Private_Static_Int32_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0006F208 File Offset: 0x0006D408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503961, XrefRangeEnd = 503965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputCount_Injected_Private_Static_Void_byref_PlayableHandle_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0006F248 File Offset: 0x0006D448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503965, XrefRangeEnd = 503969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, float weight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &input;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0006F298 File Offset: 0x0006D498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503969, XrefRangeEnd = 503973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetPreviousTime_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPreviousTime_Injected_Private_Static_Double_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0006F2D8 File Offset: 0x0006D4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503973, XrefRangeEnd = 503977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTraversalMode_Injected_Private_Static_Void_byref_PlayableHandle_PlayableTraversalMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0006F318 File Offset: 0x0006D518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503977, XrefRangeEnd = 503981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetTimeWrapMode_Injected_Private_Static_DirectorWrapMode_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0006F358 File Offset: 0x0006D558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503981, XrefRangeEnd = 503985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTimeWrapMode_Injected_Private_Static_Void_byref_PlayableHandle_DirectorWrapMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0006F398 File Offset: 0x0006D598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503985, XrefRangeEnd = 503989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetScriptInstance_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetScriptInstance_Injected_Private_Static_Object_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0006F3D8 File Offset: 0x0006D5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503989, XrefRangeEnd = 503993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0006F428 File Offset: 0x0006D628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503993, XrefRangeEnd = 503997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeightFromIndex_Injected_Private_Static_Void_byref_PlayableHandle_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0006F478 File Offset: 0x0006D678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503997, XrefRangeEnd = 504001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputWeightFromIndex_Injected_Private_Static_Single_byref_PlayableHandle_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0000FDDC File Offset: 0x0000DFDC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x0006F4C4 File Offset: 0x0006D6C4
		// (set) Token: 0x06001E32 RID: 7730 RVA: 0x0000FDEE File Offset: 0x0000DFEE
		public unsafe static PlayableHandle m_Null
		{
			get
			{
				PlayableHandle playableHandle;
				IL2CPP.il2cpp_field_static_get_value(PlayableHandle.NativeFieldInfoPtr_m_Null, (void*)(&playableHandle));
				return playableHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableHandle.NativeFieldInfoPtr_m_Null, (void*)(&value));
			}
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0006F4E0 File Offset: 0x0006D6E0
		public Playable GetOutput(int outputPort)
		{
			return new Playable(this.GetOutputHandle(outputPort));
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0006F500 File Offset: 0x0006D700
		public void Destroy()
		{
			this.GetGraph().DestroyPlayable<Playable>(new Playable(this));
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0006F528 File Offset: 0x0006D728
		public static bool operator !=(PlayableHandle x, PlayableHandle y)
		{
			return !PlayableHandle.CompareVersion(x, y);
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0000FDFC File Offset: 0x0000DFFC
		public bool IsNull()
		{
			return PlayableHandle.IsNull_Injected(ref this);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0000FE04 File Offset: 0x0000E004
		public Type GetJobType()
		{
			return PlayableHandle.GetJobType_Injected(ref this);
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0000FE0C File Offset: 0x0000E00C
		public bool CanChangeInputs()
		{
			return PlayableHandle.CanChangeInputs_Injected(ref this);
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0000FE14 File Offset: 0x0000E014
		public bool CanSetWeights()
		{
			return PlayableHandle.CanSetWeights_Injected(ref this);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x0000FE1C File Offset: 0x0000E01C
		public bool CanDestroy()
		{
			return PlayableHandle.CanDestroy_Injected(ref this);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0000FE24 File Offset: 0x0000E024
		public double GetSpeed()
		{
			return PlayableHandle.GetSpeed_Injected(ref this);
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0000FE2C File Offset: 0x0000E02C
		public void SetDone(bool value)
		{
			PlayableHandle.SetDone_Injected(ref this, value);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0000FE35 File Offset: 0x0000E035
		public bool GetPropagateSetTime()
		{
			return PlayableHandle.GetPropagateSetTime_Injected(ref this);
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0000FE3D File Offset: 0x0000E03D
		public int GetOutputCount()
		{
			return PlayableHandle.GetOutputCount_Injected(ref this);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0000FE45 File Offset: 0x0000E045
		public void SetOutputCount(int value)
		{
			PlayableHandle.SetOutputCount_Injected(ref this, value);
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0000FE4E File Offset: 0x0000E04E
		public void SetDelay(double delay)
		{
			PlayableHandle.SetDelay_Injected(ref this, delay);
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0000FE57 File Offset: 0x0000E057
		public double GetDelay()
		{
			return PlayableHandle.GetDelay_Injected(ref this);
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x0000FE5F File Offset: 0x0000E05F
		public bool IsDelayed()
		{
			return PlayableHandle.IsDelayed_Injected(ref this);
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0000FE67 File Offset: 0x0000E067
		public void SetLeadTime(float value)
		{
			PlayableHandle.SetLeadTime_Injected(ref this, value);
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0000FE70 File Offset: 0x0000E070
		public float GetLeadTime()
		{
			return PlayableHandle.GetLeadTime_Injected(ref this);
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0000FE78 File Offset: 0x0000E078
		public PlayableTraversalMode GetTraversalMode()
		{
			return PlayableHandle.GetTraversalMode_Injected(ref this);
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0000FE80 File Offset: 0x0000E080
		public IntPtr GetJobData()
		{
			return PlayableHandle.GetJobData_Injected(ref this);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0006F544 File Offset: 0x0006D744
		public PlayableHandle GetOutputHandle(int index)
		{
			PlayableHandle playableHandle;
			PlayableHandle.GetOutputHandle_Injected(ref this, index, out playableHandle);
			return playableHandle;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x0000FE88 File Offset: 0x0000E088
		public static bool IsNull_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.IsNull_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x0006F55C File Offset: 0x0006D75C
		public static Type GetJobType_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr intPtr = PlayableHandle.GetJobType_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x0000FE95 File Offset: 0x0000E095
		public static bool CanChangeInputs_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanChangeInputs_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x0000FEA2 File Offset: 0x0000E0A2
		public static bool CanSetWeights_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanSetWeights_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x0000FEAF File Offset: 0x0000E0AF
		public static bool CanDestroy_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanDestroy_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0000FEBC File Offset: 0x0000E0BC
		public static double GetSpeed_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetSpeed_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x0000FEC9 File Offset: 0x0000E0C9
		public static void SetDone_Injected(ref PlayableHandle _unity_self, bool value)
		{
			PlayableHandle.SetDone_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x0000FED7 File Offset: 0x0000E0D7
		public static bool GetPropagateSetTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetPropagateSetTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x0000FEE4 File Offset: 0x0000E0E4
		public static int GetOutputCount_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetOutputCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0000FEF1 File Offset: 0x0000E0F1
		public static void SetOutputCount_Injected(ref PlayableHandle _unity_self, int value)
		{
			PlayableHandle.SetOutputCount_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x0000FEFF File Offset: 0x0000E0FF
		public static void SetDelay_Injected(ref PlayableHandle _unity_self, double delay)
		{
			PlayableHandle.SetDelay_InjectedDelegateField(ref _unity_self, delay);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0000FF0D File Offset: 0x0000E10D
		public static double GetDelay_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetDelay_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0000FF1A File Offset: 0x0000E11A
		public static bool IsDelayed_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.IsDelayed_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0000FF27 File Offset: 0x0000E127
		public static void SetLeadTime_Injected(ref PlayableHandle _unity_self, float value)
		{
			PlayableHandle.SetLeadTime_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0000FF35 File Offset: 0x0000E135
		public static float GetLeadTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetLeadTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0000FF42 File Offset: 0x0000E142
		public static PlayableTraversalMode GetTraversalMode_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetTraversalMode_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0000FF4F File Offset: 0x0000E14F
		public static IntPtr GetJobData_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetJobData_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0000FF5C File Offset: 0x0000E15C
		public static void GetOutputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
		{
			PlayableHandle.GetOutputHandle_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeFieldInfoPtr_m_Null;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Internal_T_0;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_0;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableType_Internal_Type_0;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeMethodInfoPtr_Play_Internal_Void_0;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Internal_Void_0;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Internal_Double_0;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Internal_Void_Double_0;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeMethodInfoPtr_IsDone_Internal_Boolean_0;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Internal_Double_0;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeMethodInfoPtr_GetInputCount_Internal_Int32_0;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeMethodInfoPtr_GetScriptInstance_Private_Object_0;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeMethodInfoPtr_SetScriptInstance_Injected_Private_Static_Void_byref_PlayableHandle_Object_0;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayState_Injected_Private_Static_PlayState_byref_PlayableHandle_0;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeMethodInfoPtr_Play_Injected_Private_Static_Void_byref_PlayableHandle_0;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_byref_PlayableHandle_0;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeed_Injected_Private_Static_Void_byref_PlayableHandle_Double_0;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Injected_Private_Static_Double_byref_PlayableHandle_0;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Injected_Private_Static_Void_byref_PlayableHandle_Double_0;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_PlayableHandle_0;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Injected_Private_Static_Double_byref_PlayableHandle_0;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeMethodInfoPtr_SetDuration_Injected_Private_Static_Void_byref_PlayableHandle_Double_0;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeMethodInfoPtr_SetPropagateSetTime_Injected_Private_Static_Void_byref_PlayableHandle_Boolean_0;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeMethodInfoPtr_GetInputCount_Injected_Private_Static_Int32_byref_PlayableHandle_0;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeMethodInfoPtr_SetInputCount_Injected_Private_Static_Void_byref_PlayableHandle_Int32_0;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousTime_Injected_Private_Static_Double_byref_PlayableHandle_0;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr_SetTraversalMode_Injected_Private_Static_Void_byref_PlayableHandle_PlayableTraversalMode_0;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeWrapMode_Injected_Private_Static_DirectorWrapMode_byref_PlayableHandle_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeWrapMode_Injected_Private_Static_Void_byref_PlayableHandle_DirectorWrapMode_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_GetScriptInstance_Injected_Private_Static_Object_byref_PlayableHandle_0;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeightFromIndex_Injected_Private_Static_Void_byref_PlayableHandle_Int32_Single_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr_GetInputWeightFromIndex_Injected_Private_Static_Single_byref_PlayableHandle_Int32_0;

		// Token: 0x04001732 RID: 5938
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x04001733 RID: 5939
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x04001734 RID: 5940
		private static readonly PlayableHandle.IsNull_InjectedDelegate IsNull_InjectedDelegateField;

		// Token: 0x04001735 RID: 5941
		private static readonly PlayableHandle.GetJobType_InjectedDelegate GetJobType_InjectedDelegateField;

		// Token: 0x04001736 RID: 5942
		private static readonly PlayableHandle.CanChangeInputs_InjectedDelegate CanChangeInputs_InjectedDelegateField;

		// Token: 0x04001737 RID: 5943
		private static readonly PlayableHandle.CanSetWeights_InjectedDelegate CanSetWeights_InjectedDelegateField;

		// Token: 0x04001738 RID: 5944
		private static readonly PlayableHandle.CanDestroy_InjectedDelegate CanDestroy_InjectedDelegateField;

		// Token: 0x04001739 RID: 5945
		private static readonly PlayableHandle.GetSpeed_InjectedDelegate GetSpeed_InjectedDelegateField;

		// Token: 0x0400173A RID: 5946
		private static readonly PlayableHandle.SetDone_InjectedDelegate SetDone_InjectedDelegateField;

		// Token: 0x0400173B RID: 5947
		private static readonly PlayableHandle.GetPropagateSetTime_InjectedDelegate GetPropagateSetTime_InjectedDelegateField;

		// Token: 0x0400173C RID: 5948
		private static readonly PlayableHandle.GetOutputCount_InjectedDelegate GetOutputCount_InjectedDelegateField;

		// Token: 0x0400173D RID: 5949
		private static readonly PlayableHandle.SetOutputCount_InjectedDelegate SetOutputCount_InjectedDelegateField;

		// Token: 0x0400173E RID: 5950
		private static readonly PlayableHandle.SetDelay_InjectedDelegate SetDelay_InjectedDelegateField;

		// Token: 0x0400173F RID: 5951
		private static readonly PlayableHandle.GetDelay_InjectedDelegate GetDelay_InjectedDelegateField;

		// Token: 0x04001740 RID: 5952
		private static readonly PlayableHandle.IsDelayed_InjectedDelegate IsDelayed_InjectedDelegateField;

		// Token: 0x04001741 RID: 5953
		private static readonly PlayableHandle.SetLeadTime_InjectedDelegate SetLeadTime_InjectedDelegateField;

		// Token: 0x04001742 RID: 5954
		private static readonly PlayableHandle.GetLeadTime_InjectedDelegate GetLeadTime_InjectedDelegateField;

		// Token: 0x04001743 RID: 5955
		private static readonly PlayableHandle.GetTraversalMode_InjectedDelegate GetTraversalMode_InjectedDelegateField;

		// Token: 0x04001744 RID: 5956
		private static readonly PlayableHandle.GetJobData_InjectedDelegate GetJobData_InjectedDelegateField;

		// Token: 0x04001745 RID: 5957
		private static readonly PlayableHandle.GetOutputHandle_InjectedDelegate GetOutputHandle_InjectedDelegateField;

		// Token: 0x02000A1F RID: 2591
		private sealed class MethodInfoStoreGeneric_GetObject_Internal_T_0<T>
		{
			// Token: 0x04001FF4 RID: 8180
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableHandle.NativeMethodInfoPtr_GetObject_Internal_T_0, Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A20 RID: 2592
		private sealed class MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>
		{
			// Token: 0x04001FF5 RID: 8181
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableHandle.NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0, Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A21 RID: 2593
		// (Invoke) Token: 0x060032C3 RID: 12995
		private delegate bool IsNull_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A22 RID: 2594
		// (Invoke) Token: 0x060032C5 RID: 12997
		private delegate IntPtr GetJobType_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A23 RID: 2595
		// (Invoke) Token: 0x060032C7 RID: 12999
		private delegate bool CanChangeInputs_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A24 RID: 2596
		// (Invoke) Token: 0x060032C9 RID: 13001
		private delegate bool CanSetWeights_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A25 RID: 2597
		// (Invoke) Token: 0x060032CB RID: 13003
		private delegate bool CanDestroy_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A26 RID: 2598
		// (Invoke) Token: 0x060032CD RID: 13005
		private delegate double GetSpeed_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A27 RID: 2599
		// (Invoke) Token: 0x060032CF RID: 13007
		private delegate void SetDone_InjectedDelegate(IntPtr _unity_self, bool value);

		// Token: 0x02000A28 RID: 2600
		// (Invoke) Token: 0x060032D1 RID: 13009
		private delegate bool GetPropagateSetTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A29 RID: 2601
		// (Invoke) Token: 0x060032D3 RID: 13011
		private delegate int GetOutputCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A2A RID: 2602
		// (Invoke) Token: 0x060032D5 RID: 13013
		private delegate void SetOutputCount_InjectedDelegate(IntPtr _unity_self, int value);

		// Token: 0x02000A2B RID: 2603
		// (Invoke) Token: 0x060032D7 RID: 13015
		private delegate void SetDelay_InjectedDelegate(IntPtr _unity_self, double delay);

		// Token: 0x02000A2C RID: 2604
		// (Invoke) Token: 0x060032D9 RID: 13017
		private delegate double GetDelay_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A2D RID: 2605
		// (Invoke) Token: 0x060032DB RID: 13019
		private delegate bool IsDelayed_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A2E RID: 2606
		// (Invoke) Token: 0x060032DD RID: 13021
		private delegate void SetLeadTime_InjectedDelegate(IntPtr _unity_self, float value);

		// Token: 0x02000A2F RID: 2607
		// (Invoke) Token: 0x060032DF RID: 13023
		private delegate float GetLeadTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A30 RID: 2608
		// (Invoke) Token: 0x060032E1 RID: 13025
		private delegate PlayableTraversalMode GetTraversalMode_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A31 RID: 2609
		// (Invoke) Token: 0x060032E3 RID: 13027
		private delegate IntPtr GetJobData_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A32 RID: 2610
		// (Invoke) Token: 0x060032E5 RID: 13029
		private delegate void GetOutputHandle_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr ret);
	}
}
