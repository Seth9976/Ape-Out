using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x02000189 RID: 393
	[StructLayout(2)]
	public struct PlayableGraph
	{
		// Token: 0x06001DAF RID: 7599 RVA: 0x0006D600 File Offset: 0x0006B800
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableGraph()
		{
			Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableGraph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr);
			PlayableGraph.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, "m_Handle");
			PlayableGraph.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, "m_Version");
			PlayableGraph.NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665968);
			PlayableGraph.NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665969);
			PlayableGraph.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665970);
			PlayableGraph.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665971);
			PlayableGraph.NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665972);
			PlayableGraph.NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665973);
			PlayableGraph.NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665974);
			PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665975);
			PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665976);
			PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665977);
			PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665978);
			PlayableGraph.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665979);
			PlayableGraph.NativeMethodInfoPtr_IsPlaying_Injected_Private_Static_Boolean_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665980);
			PlayableGraph.NativeMethodInfoPtr_GetResolver_Injected_Private_Static_IExposedPropertyTable_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665981);
			PlayableGraph.NativeMethodInfoPtr_GetPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665982);
			PlayableGraph.NativeMethodInfoPtr_GetRootPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665983);
			PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665984);
			PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665985);
			PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665986);
			PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100665987);
			PlayableGraph.Create_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Create_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Create_Injected");
			PlayableGraph.Destroy_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Destroy_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Destroy_Injected");
			PlayableGraph.IsDone_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.IsDone_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::IsDone_Injected");
			PlayableGraph.Play_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Play_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Play_Injected");
			PlayableGraph.Stop_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Stop_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Stop_Injected");
			PlayableGraph.Evaluate_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Evaluate_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Evaluate_Injected");
			PlayableGraph.GetTimeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetTimeUpdateMode_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetTimeUpdateMode_Injected");
			PlayableGraph.SetTimeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.SetTimeUpdateMode_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::SetTimeUpdateMode_Injected");
			PlayableGraph.SetResolver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.SetResolver_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::SetResolver_Injected");
			PlayableGraph.GetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCount_Injected");
			PlayableGraph.DestroyOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroyOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyOutputInternal_Injected");
			PlayableGraph.GetOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputInternal_Injected");
			PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCountByTypeInternal_Injected");
			PlayableGraph.GetOutputByTypeInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputByTypeInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputByTypeInternal_Injected");
			PlayableGraph.DisconnectInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DisconnectInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DisconnectInternal_Injected");
			PlayableGraph.DestroyPlayableInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroyPlayableInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyPlayableInternal_Injected");
			PlayableGraph.DestroySubgraphInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroySubgraphInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroySubgraphInternal_Injected");
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0006D8E8 File Offset: 0x0006BAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503598, XrefRangeEnd = 503600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable GetRootPlayable(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0006D928 File Offset: 0x0006BB28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503608, RefRangeEnd = 503609, XrefRangeStart = 503600, XrefRangeEnd = 503608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) where U : new() where V : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = source;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref source;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceOutputPort;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref V ptr7;
			if (!typeof(V).IsValueType)
			{
				V v = destination;
				if (!(v is string))
				{
					ref V ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
					if ((ref ptr6) != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(v as string);
				}
			}
			else
			{
				ptr7 = ref destination;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationInputPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.MethodInfoStoreGeneric_Connect_Public_Boolean_U_Int32_V_Int32_0<U, V>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0006DA30 File Offset: 0x0006BC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503609, XrefRangeEnd = 503613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x0006DA60 File Offset: 0x0006BC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503613, XrefRangeEnd = 503617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlaying()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x0006DA90 File Offset: 0x0006BC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503617, XrefRangeEnd = 503621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IExposedPropertyTable GetResolver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IExposedPropertyTable>(intPtr3) : null;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x0006DAC4 File Offset: 0x0006BCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503621, XrefRangeEnd = 503625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayableCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x0006DAF4 File Offset: 0x0006BCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503625, XrefRangeEnd = 503629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRootPlayableCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0006DB24 File Offset: 0x0006BD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503629, XrefRangeEnd = 503631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableHandle CreatePlayableHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x0006DB54 File Offset: 0x0006BD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503631, XrefRangeEnd = 503635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x0006DBA4 File Offset: 0x0006BDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503635, XrefRangeEnd = 503637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableHandle GetRootPlayableInternal(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x0006DBE4 File Offset: 0x0006BDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503637, XrefRangeEnd = 503639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceOutputPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationInputPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x0006DC4C File Offset: 0x0006BE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid_Injected(ref PlayableGraph _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0006DC8C File Offset: 0x0006BE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPlaying_Injected(ref PlayableGraph _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsPlaying_Injected_Private_Static_Boolean_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x0006DCCC File Offset: 0x0006BECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetResolver_Injected_Private_Static_IExposedPropertyTable_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IExposedPropertyTable>(intPtr3) : null;
			}
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0006DD0C File Offset: 0x0006BF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPlayableCount_Injected(ref PlayableGraph _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0006DD4C File Offset: 0x0006BF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRootPlayableCount_Injected(ref PlayableGraph _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0006DD8C File Offset: 0x0006BF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503639, XrefRangeEnd = 503643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0006DDCC File Offset: 0x0006BFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x0006DE2C File Offset: 0x0006C02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503643, XrefRangeEnd = 503647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x0006DE7C File Offset: 0x0006C07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503647, XrefRangeEnd = 503651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceOutputPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destination;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationInputPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x0000FBCC File Offset: 0x0000DDCC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, ref this));
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0000FBDE File Offset: 0x0000DDDE
		public void Disconnect<U>(U input, int inputPort) where U : struct
		{
			this.DisconnectInternal(input.GetHandle(), inputPort);
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x0000FBF6 File Offset: 0x0000DDF6
		public void DestroyPlayable<U>(U playable) where U : struct
		{
			this.DestroyPlayableInternal(playable.GetHandle());
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x0000FC0D File Offset: 0x0000DE0D
		public void DestroySubgraph<U>(U playable) where U : struct
		{
			this.DestroySubgraphInternal(playable.GetHandle());
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0000FC24 File Offset: 0x0000DE24
		public void DestroyOutput<U>(U output) where U : struct
		{
			this.DestroyOutputInternal(output.GetHandle());
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x0006DEF4 File Offset: 0x0006C0F4
		public int GetOutputCountByType<T>() where T : struct
		{
			return this.GetOutputCountByTypeInternal(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x0006DF18 File Offset: 0x0006C118
		public PlayableOutput GetOutput(int index)
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !this.GetOutputInternal(index, out playableOutputHandle);
			PlayableOutput playableOutput;
			if (flag)
			{
				playableOutput = PlayableOutput.Null;
			}
			else
			{
				playableOutput = new PlayableOutput(playableOutputHandle);
			}
			return playableOutput;
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0006DF48 File Offset: 0x0006C148
		public PlayableOutput GetOutputByType<T>(int index) where T : struct
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !this.GetOutputByTypeInternal(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), index, out playableOutputHandle);
			PlayableOutput playableOutput;
			if (flag)
			{
				playableOutput = PlayableOutput.Null;
			}
			else
			{
				playableOutput = new PlayableOutput(playableOutputHandle);
			}
			return playableOutput;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0000FC3B File Offset: 0x0000DE3B
		public void Evaluate()
		{
			this.Evaluate(0f);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x0006DF84 File Offset: 0x0006C184
		public static PlayableGraph Create()
		{
			return PlayableGraph.Create(null);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x0006DF9C File Offset: 0x0006C19C
		public static PlayableGraph Create(string name)
		{
			PlayableGraph playableGraph;
			PlayableGraph.Create_Injected(name, out playableGraph);
			return playableGraph;
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x0000FC4A File Offset: 0x0000DE4A
		public void Destroy()
		{
			PlayableGraph.Destroy_Injected(ref this);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0000FC52 File Offset: 0x0000DE52
		public bool IsDone()
		{
			return PlayableGraph.IsDone_Injected(ref this);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0000FC5A File Offset: 0x0000DE5A
		public void Play()
		{
			PlayableGraph.Play_Injected(ref this);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x0000FC62 File Offset: 0x0000DE62
		public void Stop()
		{
			PlayableGraph.Stop_Injected(ref this);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x0000FC6A File Offset: 0x0000DE6A
		public void Evaluate(float deltaTime)
		{
			PlayableGraph.Evaluate_Injected(ref this, deltaTime);
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0000FC73 File Offset: 0x0000DE73
		public DirectorUpdateMode GetTimeUpdateMode()
		{
			return PlayableGraph.GetTimeUpdateMode_Injected(ref this);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x0000FC7B File Offset: 0x0000DE7B
		public void SetTimeUpdateMode(DirectorUpdateMode value)
		{
			PlayableGraph.SetTimeUpdateMode_Injected(ref this, value);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x0000FC84 File Offset: 0x0000DE84
		public void SetResolver(IExposedPropertyTable value)
		{
			PlayableGraph.SetResolver_Injected(ref this, value);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0000FC8D File Offset: 0x0000DE8D
		public int GetOutputCount()
		{
			return PlayableGraph.GetOutputCount_Injected(ref this);
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0000FC95 File Offset: 0x0000DE95
		public void DestroyOutputInternal(PlayableOutputHandle handle)
		{
			PlayableGraph.DestroyOutputInternal_Injected(ref this, ref handle);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x0000FC9F File Offset: 0x0000DE9F
		public bool GetOutputInternal(int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputInternal_Injected(ref this, index, out handle);
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x0000FCA9 File Offset: 0x0000DEA9
		public int GetOutputCountByTypeInternal(Type outputType)
		{
			return PlayableGraph.GetOutputCountByTypeInternal_Injected(ref this, outputType);
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x0000FCB2 File Offset: 0x0000DEB2
		public bool GetOutputByTypeInternal(Type outputType, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputByTypeInternal_Injected(ref this, outputType, index, out handle);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0000FCBD File Offset: 0x0000DEBD
		public void DisconnectInternal(PlayableHandle playable, int inputPort)
		{
			PlayableGraph.DisconnectInternal_Injected(ref this, ref playable, inputPort);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
		public void DestroyPlayableInternal(PlayableHandle playable)
		{
			PlayableGraph.DestroyPlayableInternal_Injected(ref this, ref playable);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0000FCD2 File Offset: 0x0000DED2
		public void DestroySubgraphInternal(PlayableHandle playable)
		{
			PlayableGraph.DestroySubgraphInternal_Injected(ref this, ref playable);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0000FCDC File Offset: 0x0000DEDC
		public static void Create_Injected(string name, out PlayableGraph ret)
		{
			PlayableGraph.Create_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), out ret);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0000FCEF File Offset: 0x0000DEEF
		public static void Destroy_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Destroy_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0000FCFC File Offset: 0x0000DEFC
		public static bool IsDone_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.IsDone_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0000FD09 File Offset: 0x0000DF09
		public static void Play_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Play_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x0000FD16 File Offset: 0x0000DF16
		public static void Stop_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Stop_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0000FD23 File Offset: 0x0000DF23
		public static void Evaluate_Injected(ref PlayableGraph _unity_self, float deltaTime)
		{
			PlayableGraph.Evaluate_InjectedDelegateField(ref _unity_self, deltaTime);
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0000FD31 File Offset: 0x0000DF31
		public static DirectorUpdateMode GetTimeUpdateMode_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetTimeUpdateMode_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x0000FD3E File Offset: 0x0000DF3E
		public static void SetTimeUpdateMode_Injected(ref PlayableGraph _unity_self, DirectorUpdateMode value)
		{
			PlayableGraph.SetTimeUpdateMode_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x0000FD4C File Offset: 0x0000DF4C
		public static void SetResolver_Injected(ref PlayableGraph _unity_self, IExposedPropertyTable value)
		{
			PlayableGraph.SetResolver_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x0000FD5F File Offset: 0x0000DF5F
		public static int GetOutputCount_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetOutputCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x0000FD6C File Offset: 0x0000DF6C
		public static void DestroyOutputInternal_Injected(ref PlayableGraph _unity_self, ref PlayableOutputHandle handle)
		{
			PlayableGraph.DestroyOutputInternal_InjectedDelegateField(ref _unity_self, ref handle);
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x0000FD7A File Offset: 0x0000DF7A
		public static bool GetOutputInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputInternal_InjectedDelegateField(ref _unity_self, index, out handle);
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x0000FD89 File Offset: 0x0000DF89
		public static int GetOutputCountByTypeInternal_Injected(ref PlayableGraph _unity_self, Type outputType)
		{
			return PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(outputType));
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x0000FD9C File Offset: 0x0000DF9C
		public static bool GetOutputByTypeInternal_Injected(ref PlayableGraph _unity_self, Type outputType, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputByTypeInternal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(outputType), index, out handle);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0000FDB1 File Offset: 0x0000DFB1
		public static void DisconnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable, int inputPort)
		{
			PlayableGraph.DisconnectInternal_InjectedDelegateField(ref _unity_self, ref playable, inputPort);
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		public static void DestroyPlayableInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable)
		{
			PlayableGraph.DestroyPlayableInternal_InjectedDelegateField(ref _unity_self, ref playable);
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x0000FDCE File Offset: 0x0000DFCE
		public static void DestroySubgraphInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable)
		{
			PlayableGraph.DestroySubgraphInternal_InjectedDelegateField(ref _unity_self, ref playable);
		}

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_IsPlaying_Public_Boolean_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableGraph_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_IsPlaying_Injected_Private_Static_Boolean_byref_PlayableGraph_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_GetResolver_Injected_Private_Static_IExposedPropertyTable_byref_PlayableGraph_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_GetRootPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0;

		// Token: 0x040016D9 RID: 5849
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x040016DA RID: 5850
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x040016DB RID: 5851
		private static readonly PlayableGraph.Create_InjectedDelegate Create_InjectedDelegateField;

		// Token: 0x040016DC RID: 5852
		private static readonly PlayableGraph.Destroy_InjectedDelegate Destroy_InjectedDelegateField;

		// Token: 0x040016DD RID: 5853
		private static readonly PlayableGraph.IsDone_InjectedDelegate IsDone_InjectedDelegateField;

		// Token: 0x040016DE RID: 5854
		private static readonly PlayableGraph.Play_InjectedDelegate Play_InjectedDelegateField;

		// Token: 0x040016DF RID: 5855
		private static readonly PlayableGraph.Stop_InjectedDelegate Stop_InjectedDelegateField;

		// Token: 0x040016E0 RID: 5856
		private static readonly PlayableGraph.Evaluate_InjectedDelegate Evaluate_InjectedDelegateField;

		// Token: 0x040016E1 RID: 5857
		private static readonly PlayableGraph.GetTimeUpdateMode_InjectedDelegate GetTimeUpdateMode_InjectedDelegateField;

		// Token: 0x040016E2 RID: 5858
		private static readonly PlayableGraph.SetTimeUpdateMode_InjectedDelegate SetTimeUpdateMode_InjectedDelegateField;

		// Token: 0x040016E3 RID: 5859
		private static readonly PlayableGraph.SetResolver_InjectedDelegate SetResolver_InjectedDelegateField;

		// Token: 0x040016E4 RID: 5860
		private static readonly PlayableGraph.GetOutputCount_InjectedDelegate GetOutputCount_InjectedDelegateField;

		// Token: 0x040016E5 RID: 5861
		private static readonly PlayableGraph.DestroyOutputInternal_InjectedDelegate DestroyOutputInternal_InjectedDelegateField;

		// Token: 0x040016E6 RID: 5862
		private static readonly PlayableGraph.GetOutputInternal_InjectedDelegate GetOutputInternal_InjectedDelegateField;

		// Token: 0x040016E7 RID: 5863
		private static readonly PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegate GetOutputCountByTypeInternal_InjectedDelegateField;

		// Token: 0x040016E8 RID: 5864
		private static readonly PlayableGraph.GetOutputByTypeInternal_InjectedDelegate GetOutputByTypeInternal_InjectedDelegateField;

		// Token: 0x040016E9 RID: 5865
		private static readonly PlayableGraph.DisconnectInternal_InjectedDelegate DisconnectInternal_InjectedDelegateField;

		// Token: 0x040016EA RID: 5866
		private static readonly PlayableGraph.DestroyPlayableInternal_InjectedDelegate DestroyPlayableInternal_InjectedDelegateField;

		// Token: 0x040016EB RID: 5867
		private static readonly PlayableGraph.DestroySubgraphInternal_InjectedDelegate DestroySubgraphInternal_InjectedDelegateField;

		// Token: 0x02000A0D RID: 2573
		private sealed class MethodInfoStoreGeneric_Connect_Public_Boolean_U_Int32_V_Int32_0<U, V>
		{
			// Token: 0x04001FF3 RID: 8179
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableGraph.NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0, Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A0E RID: 2574
		// (Invoke) Token: 0x0600329F RID: 12959
		private delegate void Create_InjectedDelegate(IntPtr name, [Out] IntPtr ret);

		// Token: 0x02000A0F RID: 2575
		// (Invoke) Token: 0x060032A1 RID: 12961
		private delegate void Destroy_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A10 RID: 2576
		// (Invoke) Token: 0x060032A3 RID: 12963
		private delegate bool IsDone_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A11 RID: 2577
		// (Invoke) Token: 0x060032A5 RID: 12965
		private delegate void Play_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A12 RID: 2578
		// (Invoke) Token: 0x060032A7 RID: 12967
		private delegate void Stop_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A13 RID: 2579
		// (Invoke) Token: 0x060032A9 RID: 12969
		private delegate void Evaluate_InjectedDelegate(IntPtr _unity_self, float deltaTime);

		// Token: 0x02000A14 RID: 2580
		// (Invoke) Token: 0x060032AB RID: 12971
		private delegate DirectorUpdateMode GetTimeUpdateMode_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A15 RID: 2581
		// (Invoke) Token: 0x060032AD RID: 12973
		private delegate void SetTimeUpdateMode_InjectedDelegate(IntPtr _unity_self, DirectorUpdateMode value);

		// Token: 0x02000A16 RID: 2582
		// (Invoke) Token: 0x060032AF RID: 12975
		private delegate void SetResolver_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x02000A17 RID: 2583
		// (Invoke) Token: 0x060032B1 RID: 12977
		private delegate int GetOutputCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A18 RID: 2584
		// (Invoke) Token: 0x060032B3 RID: 12979
		private delegate void DestroyOutputInternal_InjectedDelegate(IntPtr _unity_self, IntPtr handle);

		// Token: 0x02000A19 RID: 2585
		// (Invoke) Token: 0x060032B5 RID: 12981
		private delegate bool GetOutputInternal_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr handle);

		// Token: 0x02000A1A RID: 2586
		// (Invoke) Token: 0x060032B7 RID: 12983
		private delegate int GetOutputCountByTypeInternal_InjectedDelegate(IntPtr _unity_self, IntPtr outputType);

		// Token: 0x02000A1B RID: 2587
		// (Invoke) Token: 0x060032B9 RID: 12985
		private delegate bool GetOutputByTypeInternal_InjectedDelegate(IntPtr _unity_self, IntPtr outputType, int index, [Out] IntPtr handle);

		// Token: 0x02000A1C RID: 2588
		// (Invoke) Token: 0x060032BB RID: 12987
		private delegate void DisconnectInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable, int inputPort);

		// Token: 0x02000A1D RID: 2589
		// (Invoke) Token: 0x060032BD RID: 12989
		private delegate void DestroyPlayableInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable);

		// Token: 0x02000A1E RID: 2590
		// (Invoke) Token: 0x060032BF RID: 12991
		private delegate void DestroySubgraphInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable);
	}
}
