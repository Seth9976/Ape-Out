using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class ParticleSystem : Component
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002C08 File Offset: 0x00000E08
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleSystem()
		{
			Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine", "ParticleSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Vector3_Vector3_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663297);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663298);
			ParticleSystem.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663299);
			ParticleSystem.NativeMethodInfoPtr_get_particleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663300);
			ParticleSystem.NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663301);
			ParticleSystem.NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663302);
			ParticleSystem.NativeMethodInfoPtr_get_useAutoRandomSeed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663303);
			ParticleSystem.NativeMethodInfoPtr_set_useAutoRandomSeed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663304);
			ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663305);
			ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663306);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663307);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663308);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663309);
			ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663310);
			ParticleSystem.NativeMethodInfoPtr_Play_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663311);
			ParticleSystem.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663312);
			ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_Boolean_ParticleSystemStopBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663313);
			ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663314);
			ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663315);
			ParticleSystem.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663316);
			ParticleSystem.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663317);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663318);
			ParticleSystem.NativeMethodInfoPtr_Emit_Internal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663319);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_EmitParams_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663320);
			ParticleSystem.NativeMethodInfoPtr_EmitOld_Internal_Private_Void_byref_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663321);
			ParticleSystem.NativeMethodInfoPtr_get_main_Public_get_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663322);
			ParticleSystem.NativeMethodInfoPtr_get_shape_Public_get_ShapeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663323);
			ParticleSystem.NativeMethodInfoPtr_get_subEmitters_Public_get_SubEmittersModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663324);
			ParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663325);
			ParticleSystem.NativeMethodInfoPtr_Emit_Injected_Private_Void_byref_EmitParams_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663326);
			ParticleSystem.get_isEmittingDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_isEmittingDelegate>("UnityEngine.ParticleSystem::get_isEmitting");
			ParticleSystem.get_isStoppedDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_isStoppedDelegate>("UnityEngine.ParticleSystem::get_isStopped");
			ParticleSystem.get_isPausedDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_isPausedDelegate>("UnityEngine.ParticleSystem::get_isPaused");
			ParticleSystem.set_timeDelegateField = IL2CPP.ResolveICall<ParticleSystem.set_timeDelegate>("UnityEngine.ParticleSystem::set_time");
			ParticleSystem.get_randomSeedDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_randomSeedDelegate>("UnityEngine.ParticleSystem::get_randomSeed");
			ParticleSystem.get_proceduralSimulationSupportedDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_proceduralSimulationSupportedDelegate>("UnityEngine.ParticleSystem::get_proceduralSimulationSupported");
			ParticleSystem.GetParticleCurrentSizeDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetParticleCurrentSizeDelegate>("UnityEngine.ParticleSystem::GetParticleCurrentSize");
			ParticleSystem.GetParticleMeshIndexDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetParticleMeshIndexDelegate>("UnityEngine.ParticleSystem::GetParticleMeshIndex");
			ParticleSystem.SetParticlesWithNativeArrayDelegateField = IL2CPP.ResolveICall<ParticleSystem.SetParticlesWithNativeArrayDelegate>("UnityEngine.ParticleSystem::SetParticlesWithNativeArray");
			ParticleSystem.GetParticlesWithNativeArrayDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetParticlesWithNativeArrayDelegate>("UnityEngine.ParticleSystem::GetParticlesWithNativeArray");
			ParticleSystem.SetCustomParticleDataDelegateField = IL2CPP.ResolveICall<ParticleSystem.SetCustomParticleDataDelegate>("UnityEngine.ParticleSystem::SetCustomParticleData");
			ParticleSystem.GetCustomParticleDataDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetCustomParticleDataDelegate>("UnityEngine.ParticleSystem::GetCustomParticleData");
			ParticleSystem.PauseDelegateField = IL2CPP.ResolveICall<ParticleSystem.PauseDelegate>("UnityEngine.ParticleSystem::Pause");
			ParticleSystem.IsAliveDelegateField = IL2CPP.ResolveICall<ParticleSystem.IsAliveDelegate>("UnityEngine.ParticleSystem::IsAlive");
			ParticleSystem.TriggerSubEmitterDelegateField = IL2CPP.ResolveICall<ParticleSystem.TriggerSubEmitterDelegate>("UnityEngine.ParticleSystem::TriggerSubEmitter");
			ParticleSystem.ResetPreMappedBufferMemoryDelegateField = IL2CPP.ResolveICall<ParticleSystem.ResetPreMappedBufferMemoryDelegate>("UnityEngine.ParticleSystem::ResetPreMappedBufferMemory");
			ParticleSystem.SetMaximumPreMappedBufferCountsDelegateField = IL2CPP.ResolveICall<ParticleSystem.SetMaximumPreMappedBufferCountsDelegate>("UnityEngine.ParticleSystem::SetMaximumPreMappedBufferCounts");
			ParticleSystem.AllocateAxisOfRotationAttributeDelegateField = IL2CPP.ResolveICall<ParticleSystem.AllocateAxisOfRotationAttributeDelegate>("UnityEngine.ParticleSystem::AllocateAxisOfRotationAttribute");
			ParticleSystem.AllocateMeshIndexAttributeDelegateField = IL2CPP.ResolveICall<ParticleSystem.AllocateMeshIndexAttributeDelegate>("UnityEngine.ParticleSystem::AllocateMeshIndexAttribute");
			ParticleSystem.AllocateCustomDataAttributeDelegateField = IL2CPP.ResolveICall<ParticleSystem.AllocateCustomDataAttributeDelegate>("UnityEngine.ParticleSystem::AllocateCustomDataAttribute");
			ParticleSystem.GetManagedJobDataDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetManagedJobDataDelegate>("UnityEngine.ParticleSystem::GetManagedJobData");
			ParticleSystem.GetParticleCurrentSize3D_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetParticleCurrentSize3D_InjectedDelegate>("UnityEngine.ParticleSystem::GetParticleCurrentSize3D_Injected");
			ParticleSystem.GetParticleCurrentColor_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetParticleCurrentColor_InjectedDelegate>("UnityEngine.ParticleSystem::GetParticleCurrentColor_Injected");
			ParticleSystem.TriggerSubEmitterForParticle_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystem.TriggerSubEmitterForParticle_InjectedDelegate>("UnityEngine.ParticleSystem::TriggerSubEmitterForParticle_Injected");
			ParticleSystem.GetManagedJobHandle_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetManagedJobHandle_InjectedDelegate>("UnityEngine.ParticleSystem::GetManagedJobHandle_Injected");
			ParticleSystem.SetManagedJobHandle_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystem.SetManagedJobHandle_InjectedDelegate>("UnityEngine.ParticleSystem::SetManagedJobHandle_Injected");
			ParticleSystem.ScheduleManagedJob_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystem.ScheduleManagedJob_InjectedDelegate>("UnityEngine.ParticleSystem::ScheduleManagedJob_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00003028 File Offset: 0x00001228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512406, XrefRangeEnd = 512412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Vector3_Vector3_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000030A0 File Offset: 0x000012A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512412, XrefRangeEnd = 512414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000030E0 File Offset: 0x000012E0
		public unsafe bool isPlaying
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512414, XrefRangeEnd = 512418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000311C File Offset: 0x0000131C
		public unsafe int particleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512418, XrefRangeEnd = 512422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_particleCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00003158 File Offset: 0x00001358
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000020DD File Offset: 0x000002DD
		public unsafe float time
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512422, XrefRangeEnd = 512426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				ParticleSystem.set_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000020F0 File Offset: 0x000002F0
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00003194 File Offset: 0x00001394
		public unsafe uint randomSeed
		{
			get
			{
				return ParticleSystem.get_randomSeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 512430, RefRangeEnd = 512431, XrefRangeStart = 512426, XrefRangeEnd = 512430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000031D4 File Offset: 0x000013D4
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00003210 File Offset: 0x00001410
		public unsafe bool useAutoRandomSeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512431, XrefRangeEnd = 512435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_useAutoRandomSeed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512435, XrefRangeEnd = 512439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_useAutoRandomSeed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003250 File Offset: 0x00001450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512439, XrefRangeEnd = 512443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000032C0 File Offset: 0x000014C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512443, XrefRangeEnd = 512447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003320 File Offset: 0x00001520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512447, XrefRangeEnd = 512451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000339C File Offset: 0x0000159C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512451, XrefRangeEnd = 512455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003408 File Offset: 0x00001608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512455, XrefRangeEnd = 512459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003468 File Offset: 0x00001668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512459, XrefRangeEnd = 512463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withChildren;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixedTimeStep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000034D0 File Offset: 0x000016D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512463, XrefRangeEnd = 512467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(bool withChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withChildren;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Play_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003510 File Offset: 0x00001710
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 512471, RefRangeEnd = 512475, XrefRangeStart = 512467, XrefRangeEnd = 512471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003544 File Offset: 0x00001744
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 512479, RefRangeEnd = 512482, XrefRangeStart = 512475, XrefRangeEnd = 512479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withChildren;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_Boolean_ParticleSystemStopBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003590 File Offset: 0x00001790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512482, XrefRangeEnd = 512486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(bool withChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withChildren;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000035D0 File Offset: 0x000017D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512490, RefRangeEnd = 512492, XrefRangeStart = 512486, XrefRangeEnd = 512490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003604 File Offset: 0x00001804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512492, XrefRangeEnd = 512496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool withChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withChildren;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003644 File Offset: 0x00001844
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 512500, RefRangeEnd = 512504, XrefRangeStart = 512496, XrefRangeEnd = 512500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003678 File Offset: 0x00001878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512508, RefRangeEnd = 512510, XrefRangeStart = 512504, XrefRangeEnd = 512508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000036B8 File Offset: 0x000018B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512508, RefRangeEnd = 512510, XrefRangeStart = 512508, XrefRangeEnd = 512510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit_Internal(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Internal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000036F8 File Offset: 0x000018F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512510, XrefRangeEnd = 512512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(ParticleSystem.EmitParams emitParams, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref emitParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_EmitParams_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003744 File Offset: 0x00001944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512512, XrefRangeEnd = 512516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitOld_Internal(ref ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_EmitOld_Internal_Private_Void_byref_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00003784 File Offset: 0x00001984
		public unsafe ParticleSystem.MainModule main
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 206026, RefRangeEnd = 206033, XrefRangeStart = 206026, XrefRangeEnd = 206033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_main_Public_get_MainModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.MainModule(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000037BC File Offset: 0x000019BC
		public unsafe ParticleSystem.ShapeModule shape
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 206026, RefRangeEnd = 206033, XrefRangeStart = 206026, XrefRangeEnd = 206033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_shape_Public_get_ShapeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.ShapeModule(intPtr);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000037F4 File Offset: 0x000019F4
		public unsafe ParticleSystem.SubEmittersModule subEmitters
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 206026, RefRangeEnd = 206033, XrefRangeStart = 206026, XrefRangeEnd = 206033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_subEmitters_Public_get_SubEmittersModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.SubEmittersModule(intPtr);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000382C File Offset: 0x00001A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003868 File Offset: 0x00001A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512516, XrefRangeEnd = 512520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &emitParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Injected_Private_Void_byref_EmitParams_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		public ParticleSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000038B4 File Offset: 0x00001AB4
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000038D4 File Offset: 0x00001AD4
		public float startDelay
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.startDelayMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startDelayMultiplier = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000038F4 File Offset: 0x00001AF4
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00003914 File Offset: 0x00001B14
		public bool loop
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.loop;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.loop = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003934 File Offset: 0x00001B34
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00003954 File Offset: 0x00001B54
		public bool playOnAwake
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.playOnAwake;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.playOnAwake = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003974 File Offset: 0x00001B74
		public float duration
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.duration;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003994 File Offset: 0x00001B94
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000039B4 File Offset: 0x00001BB4
		public float playbackSpeed
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.simulationSpeed;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.simulationSpeed = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002059 File Offset: 0x00000259
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		public bool enableEmission
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002073 File Offset: 0x00000273
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002080 File Offset: 0x00000280
		public float emissionRate
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000039D4 File Offset: 0x00001BD4
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000039F4 File Offset: 0x00001BF4
		public float startSpeed
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.startSpeedMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startSpeedMultiplier = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003A14 File Offset: 0x00001C14
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00003A34 File Offset: 0x00001C34
		public float startSize
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.startSizeMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startSizeMultiplier = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000208D File Offset: 0x0000028D
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000209A File Offset: 0x0000029A
		public Color startColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003A54 File Offset: 0x00001C54
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00003A74 File Offset: 0x00001C74
		public float startRotation
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.startRotationMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startRotationMultiplier = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003A94 File Offset: 0x00001C94
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00003AD8 File Offset: 0x00001CD8
		public Vector3 startRotation3D
		{
			get
			{
				ParticleSystem.MainModule mainModule = this.main;
				float startRotationXMultiplier = mainModule.startRotationXMultiplier;
				mainModule = this.main;
				float startRotationYMultiplier = mainModule.startRotationYMultiplier;
				mainModule = this.main;
				return new Vector3(startRotationXMultiplier, startRotationYMultiplier, mainModule.startRotationZMultiplier);
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startRotationXMultiplier = value.x;
				main.startRotationYMultiplier = value.y;
				main.startRotationZMultiplier = value.z;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003B18 File Offset: 0x00001D18
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00003B38 File Offset: 0x00001D38
		public float startLifetime
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.startLifetimeMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startLifetimeMultiplier = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003B58 File Offset: 0x00001D58
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00003B78 File Offset: 0x00001D78
		public float gravityModifier
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.gravityModifierMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.gravityModifierMultiplier = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003B98 File Offset: 0x00001D98
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00003BB8 File Offset: 0x00001DB8
		public int maxParticles
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.maxParticles;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.maxParticles = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00003BD8 File Offset: 0x00001DD8
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00003BF8 File Offset: 0x00001DF8
		public ParticleSystemSimulationSpace simulationSpace
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.simulationSpace;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.simulationSpace = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003C18 File Offset: 0x00001E18
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00003C38 File Offset: 0x00001E38
		public ParticleSystemScalingMode scalingMode
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.scalingMode;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.scalingMode = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003C58 File Offset: 0x00001E58
		public bool automaticCullingEnabled
		{
			get
			{
				return this.proceduralSimulationSupported;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000020A7 File Offset: 0x000002A7
		public bool isEmitting
		{
			get
			{
				return ParticleSystem.get_isEmittingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000020B9 File Offset: 0x000002B9
		public bool isStopped
		{
			get
			{
				return ParticleSystem.get_isStoppedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000020CB File Offset: 0x000002CB
		public bool isPaused
		{
			get
			{
				return ParticleSystem.get_isPausedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002102 File Offset: 0x00000302
		public bool proceduralSimulationSupported
		{
			get
			{
				return ParticleSystem.get_proceduralSimulationSupportedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002114 File Offset: 0x00000314
		public float GetParticleCurrentSize(ref ParticleSystem.Particle particle)
		{
			return ParticleSystem.GetParticleCurrentSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref particle);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003C70 File Offset: 0x00001E70
		public Vector3 GetParticleCurrentSize3D(ref ParticleSystem.Particle particle)
		{
			Vector3 vector;
			this.GetParticleCurrentSize3D_Injected(ref particle, out vector);
			return vector;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003C88 File Offset: 0x00001E88
		public Color32 GetParticleCurrentColor(ref ParticleSystem.Particle particle)
		{
			Color32 color;
			this.GetParticleCurrentColor_Injected(ref particle, out color);
			return color;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002127 File Offset: 0x00000327
		public int GetParticleMeshIndex(ref ParticleSystem.Particle particle)
		{
			return ParticleSystem.GetParticleMeshIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref particle);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000213A File Offset: 0x0000033A
		public void SetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles)
		{
			this.SetParticles(particles, -1);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002146 File Offset: 0x00000346
		public void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset)
		{
			ParticleSystem.SetParticlesWithNativeArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), particles, particlesLength, size, offset);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000215D File Offset: 0x0000035D
		public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			this.SetParticlesWithNativeArray((IntPtr)particles.GetUnsafeReadOnlyPtr<ParticleSystem.Particle>(), particles.Length, size, offset);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000217D File Offset: 0x0000037D
		public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size)
		{
			this.SetParticles(particles, size, 0);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000218A File Offset: 0x0000038A
		public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles)
		{
			this.SetParticles(particles, -1);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002196 File Offset: 0x00000396
		public int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset)
		{
			return ParticleSystem.GetParticlesWithNativeArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), particles, particlesLength, size, offset);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003CA0 File Offset: 0x00001EA0
		public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			return this.GetParticlesWithNativeArray((IntPtr)NativeArrayUnsafeUtility.GetUnsafePtr<ParticleSystem.Particle>(particles), particles.Length, size, offset);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size)
		{
			return this.GetParticles(particles, size, 0);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003CEC File Offset: 0x00001EEC
		public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles)
		{
			return this.GetParticles(particles, -1);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000021AD File Offset: 0x000003AD
		public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
			ParticleSystem.SetCustomParticleDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(customData), streamIndex);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000021C6 File Offset: 0x000003C6
		public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
			return ParticleSystem.GetCustomParticleDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(customData), streamIndex);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000021DF File Offset: 0x000003DF
		public void Simulate(float t, bool withChildren, bool restart)
		{
			this.Simulate(t, withChildren, restart, true);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000021ED File Offset: 0x000003ED
		public void Simulate(float t, bool withChildren)
		{
			this.Simulate(t, withChildren, true);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000021FA File Offset: 0x000003FA
		public void Simulate(float t)
		{
			this.Simulate(t, true);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002206 File Offset: 0x00000406
		public void Pause(bool withChildren)
		{
			ParticleSystem.PauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), withChildren);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002219 File Offset: 0x00000419
		public void Pause()
		{
			this.Pause(true);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002224 File Offset: 0x00000424
		public bool IsAlive(bool withChildren)
		{
			return ParticleSystem.IsAliveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), withChildren);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003D08 File Offset: 0x00001F08
		public bool IsAlive()
		{
			return this.IsAlive(true);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002237 File Offset: 0x00000437
		public void TriggerSubEmitter(int subEmitterIndex)
		{
			this.TriggerSubEmitter(subEmitterIndex, null);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002243 File Offset: 0x00000443
		public void TriggerSubEmitter(int subEmitterIndex, ref ParticleSystem.Particle particle)
		{
			this.TriggerSubEmitterForParticle(subEmitterIndex, particle);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002254 File Offset: 0x00000454
		public void TriggerSubEmitterForParticle(int subEmitterIndex, ParticleSystem.Particle particle)
		{
			this.TriggerSubEmitterForParticle_Injected(subEmitterIndex, ref particle);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000225F File Offset: 0x0000045F
		public void TriggerSubEmitter(int subEmitterIndex, List<ParticleSystem.Particle> particles)
		{
			ParticleSystem.TriggerSubEmitterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), subEmitterIndex, IL2CPP.Il2CppObjectBaseToPtr(particles));
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002278 File Offset: 0x00000478
		public static void ResetPreMappedBufferMemory()
		{
			ParticleSystem.ResetPreMappedBufferMemoryDelegateField();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002284 File Offset: 0x00000484
		public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount)
		{
			ParticleSystem.SetMaximumPreMappedBufferCountsDelegateField(vertexBuffersCount, indexBuffersCount);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002292 File Offset: 0x00000492
		public void AllocateAxisOfRotationAttribute()
		{
			ParticleSystem.AllocateAxisOfRotationAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000022A4 File Offset: 0x000004A4
		public void AllocateMeshIndexAttribute()
		{
			ParticleSystem.AllocateMeshIndexAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000022B6 File Offset: 0x000004B6
		public void AllocateCustomDataAttribute(ParticleSystemCustomData stream)
		{
			ParticleSystem.AllocateCustomDataAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stream);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000022C9 File Offset: 0x000004C9
		public unsafe void* GetManagedJobData()
		{
			return ParticleSystem.GetManagedJobDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003D24 File Offset: 0x00001F24
		public JobHandle GetManagedJobHandle()
		{
			JobHandle jobHandle;
			this.GetManagedJobHandle_Injected(out jobHandle);
			return jobHandle;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000022DB File Offset: 0x000004DB
		public void SetManagedJobHandle(JobHandle handle)
		{
			this.SetManagedJobHandle_Injected(ref handle);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003D3C File Offset: 0x00001F3C
		public unsafe static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData)
		{
			JobHandle jobHandle;
			ParticleSystem.ScheduleManagedJob_Injected(ref parameters, additionalData, out jobHandle);
			return jobHandle;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00003D54 File Offset: 0x00001F54
		public ParticleSystem.TextureSheetAnimationModule textureSheetAnimation
		{
			get
			{
				return new ParticleSystem.TextureSheetAnimationModule(this);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000022E5 File Offset: 0x000004E5
		public void GetParticleCurrentSize3D_Injected(ref ParticleSystem.Particle particle, out Vector3 ret)
		{
			ParticleSystem.GetParticleCurrentSize3D_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref particle, out ret);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000022F9 File Offset: 0x000004F9
		public void GetParticleCurrentColor_Injected(ref ParticleSystem.Particle particle, out Color32 ret)
		{
			ParticleSystem.GetParticleCurrentColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref particle, out ret);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000230D File Offset: 0x0000050D
		public void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref ParticleSystem.Particle particle)
		{
			ParticleSystem.TriggerSubEmitterForParticle_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), subEmitterIndex, ref particle);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002321 File Offset: 0x00000521
		public void GetManagedJobHandle_Injected(out JobHandle ret)
		{
			ParticleSystem.GetManagedJobHandle_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002334 File Offset: 0x00000534
		public void SetManagedJobHandle_Injected(ref JobHandle handle)
		{
			ParticleSystem.SetManagedJobHandle_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref handle);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002347 File Offset: 0x00000547
		public unsafe static void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret)
		{
			ParticleSystem.ScheduleManagedJob_InjectedDelegateField(ref parameters, additionalData, out ret);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Vector3_Vector3_Single_Single_Color32_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Particle_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_particleCount_Public_get_Int32_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_useAutoRandomSeed_Public_get_Boolean_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_set_useAutoRandomSeed_Public_set_Void_Boolean_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_Int32_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_Int32_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_Boolean_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_Boolean_ParticleSystemStopBehavior_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_Boolean_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_Boolean_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Int32_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Internal_Private_Void_Int32_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_EmitParams_Int32_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_EmitOld_Internal_Private_Void_byref_Particle_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_get_MainModule_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_shape_Public_get_ShapeModule_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_subEmitters_Public_get_SubEmittersModule_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Injected_Private_Void_byref_EmitParams_Int32_0;

		// Token: 0x0400001F RID: 31
		private static readonly ParticleSystem.get_isEmittingDelegate get_isEmittingDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly ParticleSystem.get_isStoppedDelegate get_isStoppedDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly ParticleSystem.get_isPausedDelegate get_isPausedDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly ParticleSystem.set_timeDelegate set_timeDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly ParticleSystem.get_randomSeedDelegate get_randomSeedDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly ParticleSystem.get_proceduralSimulationSupportedDelegate get_proceduralSimulationSupportedDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly ParticleSystem.GetParticleCurrentSizeDelegate GetParticleCurrentSizeDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly ParticleSystem.GetParticleMeshIndexDelegate GetParticleMeshIndexDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly ParticleSystem.SetParticlesWithNativeArrayDelegate SetParticlesWithNativeArrayDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly ParticleSystem.GetParticlesWithNativeArrayDelegate GetParticlesWithNativeArrayDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly ParticleSystem.SetCustomParticleDataDelegate SetCustomParticleDataDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly ParticleSystem.GetCustomParticleDataDelegate GetCustomParticleDataDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly ParticleSystem.PauseDelegate PauseDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly ParticleSystem.IsAliveDelegate IsAliveDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly ParticleSystem.TriggerSubEmitterDelegate TriggerSubEmitterDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly ParticleSystem.ResetPreMappedBufferMemoryDelegate ResetPreMappedBufferMemoryDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly ParticleSystem.SetMaximumPreMappedBufferCountsDelegate SetMaximumPreMappedBufferCountsDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly ParticleSystem.AllocateAxisOfRotationAttributeDelegate AllocateAxisOfRotationAttributeDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly ParticleSystem.AllocateMeshIndexAttributeDelegate AllocateMeshIndexAttributeDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly ParticleSystem.AllocateCustomDataAttributeDelegate AllocateCustomDataAttributeDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly ParticleSystem.GetManagedJobDataDelegate GetManagedJobDataDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly ParticleSystem.GetParticleCurrentSize3D_InjectedDelegate GetParticleCurrentSize3D_InjectedDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly ParticleSystem.GetParticleCurrentColor_InjectedDelegate GetParticleCurrentColor_InjectedDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly ParticleSystem.TriggerSubEmitterForParticle_InjectedDelegate TriggerSubEmitterForParticle_InjectedDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly ParticleSystem.GetManagedJobHandle_InjectedDelegate GetManagedJobHandle_InjectedDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly ParticleSystem.SetManagedJobHandle_InjectedDelegate SetManagedJobHandle_InjectedDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly ParticleSystem.ScheduleManagedJob_InjectedDelegate ScheduleManagedJob_InjectedDelegateField;

		// Token: 0x0200003B RID: 59
		public sealed class MainModule : ValueType
		{
			// Token: 0x060000FE RID: 254 RVA: 0x00004F14 File Offset: 0x00003114
			// Note: this type is marked as 'beforefieldinit'.
			static MainModule()
			{
				Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "MainModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr);
				ParticleSystem.MainModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.MainModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663327);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_duration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663328);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663329);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSpeed_Public_set_Void_MinMaxCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663330);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSize_Public_get_MinMaxCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663331);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSize_Public_set_Void_MinMaxCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663332);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_customSimulationSpace_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663333);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_duration_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663334);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663335);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSpeed_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663336);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSize_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663337);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSize_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663338);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_customSimulationSpace_Injected_Private_Static_Void_byref_MainModule_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663339);
			}

			// Token: 0x060000FF RID: 255 RVA: 0x00005058 File Offset: 0x00003258
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MainModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000100 RID: 256 RVA: 0x000050A8 File Offset: 0x000032A8
			public unsafe float duration
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512359, XrefRangeEnd = 512363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_duration_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000101 RID: 257 RVA: 0x000050EC File Offset: 0x000032EC
			public unsafe bool loop
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512363, XrefRangeEnd = 512367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700004E RID: 78
			// (set) Token: 0x06000102 RID: 258 RVA: 0x00005130 File Offset: 0x00003330
			public unsafe ParticleSystem.MinMaxCurve startSpeed
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512367, XrefRangeEnd = 512369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSpeed_Public_set_Void_MinMaxCurve_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000103 RID: 259 RVA: 0x0000517C File Offset: 0x0000337C
			// (set) Token: 0x06000104 RID: 260 RVA: 0x000051B8 File Offset: 0x000033B8
			public unsafe ParticleSystem.MinMaxCurve startSize
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512369, XrefRangeEnd = 512371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSize_Public_get_MinMaxCurve_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ParticleSystem.MinMaxCurve(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512371, XrefRangeEnd = 512373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSize_Public_set_Void_MinMaxCurve_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000050 RID: 80
			// (set) Token: 0x06000105 RID: 261 RVA: 0x00005204 File Offset: 0x00003404
			public unsafe Transform customSimulationSpace
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512373, XrefRangeEnd = 512377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_customSimulationSpace_Public_set_Void_Transform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000106 RID: 262 RVA: 0x0000524C File Offset: 0x0000344C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_duration_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000107 RID: 263 RVA: 0x00005294 File Offset: 0x00003494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool get_loop_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000108 RID: 264 RVA: 0x000052DC File Offset: 0x000034DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512377, XrefRangeEnd = 512381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSpeed_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxCurve_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000109 RID: 265 RVA: 0x00005330 File Offset: 0x00003530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512381, XrefRangeEnd = 512385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void get_startSize_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self));
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSize_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxCurve_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				ret = ((intPtr4 == 0) ? null : new ParticleSystem.MinMaxCurve(intPtr4));
			}

			// Token: 0x0600010A RID: 266 RVA: 0x00005390 File Offset: 0x00003590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512385, XrefRangeEnd = 512389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startSize_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSize_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxCurve_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600010B RID: 267 RVA: 0x000053E4 File Offset: 0x000035E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_customSimulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, Transform value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_customSimulationSpace_Injected_Private_Static_Void_byref_MainModule_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600010C RID: 268 RVA: 0x00002A01 File Offset: 0x00000C01
			public MainModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600010D RID: 269 RVA: 0x00002A0A File Offset: 0x00000C0A
			public MainModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr))
			{
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x0600010E RID: 270 RVA: 0x00005434 File Offset: 0x00003634
			// (set) Token: 0x0600010F RID: 271 RVA: 0x00002A1C File Offset: 0x00000C1C
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MainModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MainModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000192 RID: 402
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000193 RID: 403
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;

			// Token: 0x04000194 RID: 404
			private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_get_Single_0;

			// Token: 0x04000195 RID: 405
			private static readonly IntPtr NativeMethodInfoPtr_get_loop_Public_get_Boolean_0;

			// Token: 0x04000196 RID: 406
			private static readonly IntPtr NativeMethodInfoPtr_set_startSpeed_Public_set_Void_MinMaxCurve_0;

			// Token: 0x04000197 RID: 407
			private static readonly IntPtr NativeMethodInfoPtr_get_startSize_Public_get_MinMaxCurve_0;

			// Token: 0x04000198 RID: 408
			private static readonly IntPtr NativeMethodInfoPtr_set_startSize_Public_set_Void_MinMaxCurve_0;

			// Token: 0x04000199 RID: 409
			private static readonly IntPtr NativeMethodInfoPtr_set_customSimulationSpace_Public_set_Void_Transform_0;

			// Token: 0x0400019A RID: 410
			private static readonly IntPtr NativeMethodInfoPtr_get_duration_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x0400019B RID: 411
			private static readonly IntPtr NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_byref_MainModule_0;

			// Token: 0x0400019C RID: 412
			private static readonly IntPtr NativeMethodInfoPtr_set_startSpeed_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxCurve_0;

			// Token: 0x0400019D RID: 413
			private static readonly IntPtr NativeMethodInfoPtr_get_startSize_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxCurve_0;

			// Token: 0x0400019E RID: 414
			private static readonly IntPtr NativeMethodInfoPtr_set_startSize_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxCurve_0;

			// Token: 0x0400019F RID: 415
			private static readonly IntPtr NativeMethodInfoPtr_set_customSimulationSpace_Injected_Private_Static_Void_byref_MainModule_Transform_0;
		}

		// Token: 0x0200003C RID: 60
		public sealed class ShapeModule : ValueType
		{
			// Token: 0x06000110 RID: 272 RVA: 0x00005464 File Offset: 0x00003664
			// Note: this type is marked as 'beforefieldinit'.
			static ShapeModule()
			{
				Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "ShapeModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr);
				ParticleSystem.ShapeModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.ShapeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr, 100663340);
				ParticleSystem.ShapeModule.NativeMethodInfoPtr_set_radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr, 100663341);
				ParticleSystem.ShapeModule.NativeMethodInfoPtr_set_radius_Injected_Private_Static_Void_byref_ShapeModule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr, 100663342);
			}

			// Token: 0x06000111 RID: 273 RVA: 0x000054E0 File Offset: 0x000036E0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShapeModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.ShapeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000052 RID: 82
			// (set) Token: 0x06000112 RID: 274 RVA: 0x00005530 File Offset: 0x00003730
			public unsafe float radius
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512389, XrefRangeEnd = 512393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.ShapeModule.NativeMethodInfoPtr_set_radius_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000113 RID: 275 RVA: 0x00005574 File Offset: 0x00003774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_radius_Injected(ref ParticleSystem.ShapeModule _unity_self, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.ShapeModule.NativeMethodInfoPtr_set_radius_Injected_Private_Static_Void_byref_ShapeModule_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000114 RID: 276 RVA: 0x00002A3B File Offset: 0x00000C3B
			public ShapeModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00002A44 File Offset: 0x00000C44
			public ShapeModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr))
			{
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000116 RID: 278 RVA: 0x000055C0 File Offset: 0x000037C0
			// (set) Token: 0x06000117 RID: 279 RVA: 0x00002A56 File Offset: 0x00000C56
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ShapeModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ShapeModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001A0 RID: 416
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x040001A1 RID: 417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;

			// Token: 0x040001A2 RID: 418
			private static readonly IntPtr NativeMethodInfoPtr_set_radius_Public_set_Void_Single_0;

			// Token: 0x040001A3 RID: 419
			private static readonly IntPtr NativeMethodInfoPtr_set_radius_Injected_Private_Static_Void_byref_ShapeModule_Single_0;
		}

		// Token: 0x0200003D RID: 61
		public sealed class SubEmittersModule : ValueType
		{
			// Token: 0x06000118 RID: 280 RVA: 0x000055F0 File Offset: 0x000037F0
			// Note: this type is marked as 'beforefieldinit'.
			static SubEmittersModule()
			{
				Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "SubEmittersModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr);
				ParticleSystem.SubEmittersModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.SubEmittersModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr, 100663343);
				ParticleSystem.SubEmittersModule.NativeMethodInfoPtr_get_subEmittersCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr, 100663344);
				ParticleSystem.SubEmittersModule.NativeMethodInfoPtr_GetSubEmitterSystem_Public_ParticleSystem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr, 100663345);
				ParticleSystem.SubEmittersModule.NativeMethodInfoPtr_get_subEmittersCount_Injected_Private_Static_Int32_byref_SubEmittersModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr, 100663346);
				ParticleSystem.SubEmittersModule.NativeMethodInfoPtr_GetSubEmitterSystem_Injected_Private_Static_ParticleSystem_byref_SubEmittersModule_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr, 100663347);
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00005694 File Offset: 0x00003894
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubEmittersModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.SubEmittersModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x0600011A RID: 282 RVA: 0x000056E4 File Offset: 0x000038E4
			public unsafe int subEmittersCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512393, XrefRangeEnd = 512397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.SubEmittersModule.NativeMethodInfoPtr_get_subEmittersCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00005728 File Offset: 0x00003928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512397, XrefRangeEnd = 512401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParticleSystem GetSubEmitterSystem(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.SubEmittersModule.NativeMethodInfoPtr_GetSubEmitterSystem_Public_ParticleSystem_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr3) : null;
				}
			}

			// Token: 0x0600011C RID: 284 RVA: 0x0000577C File Offset: 0x0000397C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int get_subEmittersCount_Injected(ref ParticleSystem.SubEmittersModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.SubEmittersModule.NativeMethodInfoPtr_get_subEmittersCount_Injected_Private_Static_Int32_byref_SubEmittersModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600011D RID: 285 RVA: 0x000057C4 File Offset: 0x000039C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ParticleSystem GetSubEmitterSystem_Injected(ref ParticleSystem.SubEmittersModule _unity_self, int index)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.SubEmittersModule.NativeMethodInfoPtr_GetSubEmitterSystem_Injected_Private_Static_ParticleSystem_byref_SubEmittersModule_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr3) : null;
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00002A75 File Offset: 0x00000C75
			public SubEmittersModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00002A7E File Offset: 0x00000C7E
			public SubEmittersModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr))
			{
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000120 RID: 288 RVA: 0x0000581C File Offset: 0x00003A1C
			// (set) Token: 0x06000121 RID: 289 RVA: 0x00002A90 File Offset: 0x00000C90
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.SubEmittersModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.SubEmittersModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001A4 RID: 420
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x040001A5 RID: 421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;

			// Token: 0x040001A6 RID: 422
			private static readonly IntPtr NativeMethodInfoPtr_get_subEmittersCount_Public_get_Int32_0;

			// Token: 0x040001A7 RID: 423
			private static readonly IntPtr NativeMethodInfoPtr_GetSubEmitterSystem_Public_ParticleSystem_Int32_0;

			// Token: 0x040001A8 RID: 424
			private static readonly IntPtr NativeMethodInfoPtr_get_subEmittersCount_Injected_Private_Static_Int32_byref_SubEmittersModule_0;

			// Token: 0x040001A9 RID: 425
			private static readonly IntPtr NativeMethodInfoPtr_GetSubEmitterSystem_Injected_Private_Static_ParticleSystem_byref_SubEmittersModule_Int32_0;
		}

		// Token: 0x0200003E RID: 62
		public sealed class TextureSheetAnimationModule : ValueType
		{
			// Token: 0x06000122 RID: 290 RVA: 0x00002AAF File Offset: 0x00000CAF
			// Note: this type is marked as 'beforefieldinit'.
			static TextureSheetAnimationModule()
			{
				Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "TextureSheetAnimationModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr);
				ParticleSystem.TextureSheetAnimationModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, "m_ParticleSystem");
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00002AE3 File Offset: 0x00000CE3
			public TextureSheetAnimationModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000124 RID: 292 RVA: 0x00002AEC File Offset: 0x00000CEC
			public TextureSheetAnimationModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr))
			{
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000125 RID: 293 RVA: 0x0000584C File Offset: 0x00003A4C
			// (set) Token: 0x06000126 RID: 294 RVA: 0x00002AFE File Offset: 0x00000CFE
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.TextureSheetAnimationModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.TextureSheetAnimationModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001AA RID: 426
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;
		}

		// Token: 0x0200003F RID: 63
		[StructLayout(2)]
		public struct Particle
		{
			// Token: 0x06000127 RID: 295 RVA: 0x0000587C File Offset: 0x00003A7C
			// Note: this type is marked as 'beforefieldinit'.
			static Particle()
			{
				Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "Particle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr);
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Position");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Velocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_AnimatedVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_AnimatedVelocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_InitialVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_InitialVelocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_AxisOfRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_AxisOfRotation");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Rotation");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_AngularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_AngularVelocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_StartSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_StartSize");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_StartColor");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_RandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_RandomSeed");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_ParentRandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_ParentRandomSeed");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Lifetime");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_StartLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_StartLifetime");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_MeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_MeshIndex");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_EmitAccumulator0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_EmitAccumulator0");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_EmitAccumulator1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_EmitAccumulator1");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Flags");
				ParticleSystem.Particle.NativeMethodInfoPtr_set_lifetime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663348);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663349);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663350);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_remainingLifetime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663351);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663352);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663353);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663354);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663355);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663356);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_rotation3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663357);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_angularVelocity3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663358);
			}

			// Token: 0x17000056 RID: 86
			// (set) Token: 0x06000128 RID: 296 RVA: 0x00005AD8 File Offset: 0x00003CD8
			public unsafe float lifetime
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_lifetime_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000057 RID: 87
			// (set) Token: 0x06000129 RID: 297 RVA: 0x00005B0C File Offset: 0x00003D0C
			public unsafe Vector3 position
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000058 RID: 88
			// (set) Token: 0x0600012A RID: 298 RVA: 0x00005B40 File Offset: 0x00003D40
			public unsafe Vector3 velocity
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000059 RID: 89
			// (set) Token: 0x0600012B RID: 299 RVA: 0x00005B74 File Offset: 0x00003D74
			public unsafe float remainingLifetime
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_remainingLifetime_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700005A RID: 90
			// (set) Token: 0x0600012C RID: 300 RVA: 0x00005BA8 File Offset: 0x00003DA8
			public unsafe float startLifetime
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700005B RID: 91
			// (set) Token: 0x0600012D RID: 301 RVA: 0x00005BDC File Offset: 0x00003DDC
			public unsafe Color32 startColor
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700005C RID: 92
			// (set) Token: 0x0600012E RID: 302 RVA: 0x00005C10 File Offset: 0x00003E10
			public unsafe uint randomSeed
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700005D RID: 93
			// (set) Token: 0x0600012F RID: 303 RVA: 0x00005C44 File Offset: 0x00003E44
			public unsafe float startSize
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700005E RID: 94
			// (set) Token: 0x06000130 RID: 304 RVA: 0x00005C78 File Offset: 0x00003E78
			public unsafe float rotation
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700005F RID: 95
			// (set) Token: 0x06000131 RID: 305 RVA: 0x00005CAC File Offset: 0x00003EAC
			public unsafe Vector3 rotation3D
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_rotation3D_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000060 RID: 96
			// (set) Token: 0x06000132 RID: 306 RVA: 0x00005CE0 File Offset: 0x00003EE0
			public unsafe Vector3 angularVelocity3D
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_angularVelocity3D_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00002B1D File Offset: 0x00000D1D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, ref this));
			}

			// Token: 0x040001AB RID: 427
			private static readonly IntPtr NativeFieldInfoPtr_m_Position;

			// Token: 0x040001AC RID: 428
			private static readonly IntPtr NativeFieldInfoPtr_m_Velocity;

			// Token: 0x040001AD RID: 429
			private static readonly IntPtr NativeFieldInfoPtr_m_AnimatedVelocity;

			// Token: 0x040001AE RID: 430
			private static readonly IntPtr NativeFieldInfoPtr_m_InitialVelocity;

			// Token: 0x040001AF RID: 431
			private static readonly IntPtr NativeFieldInfoPtr_m_AxisOfRotation;

			// Token: 0x040001B0 RID: 432
			private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

			// Token: 0x040001B1 RID: 433
			private static readonly IntPtr NativeFieldInfoPtr_m_AngularVelocity;

			// Token: 0x040001B2 RID: 434
			private static readonly IntPtr NativeFieldInfoPtr_m_StartSize;

			// Token: 0x040001B3 RID: 435
			private static readonly IntPtr NativeFieldInfoPtr_m_StartColor;

			// Token: 0x040001B4 RID: 436
			private static readonly IntPtr NativeFieldInfoPtr_m_RandomSeed;

			// Token: 0x040001B5 RID: 437
			private static readonly IntPtr NativeFieldInfoPtr_m_ParentRandomSeed;

			// Token: 0x040001B6 RID: 438
			private static readonly IntPtr NativeFieldInfoPtr_m_Lifetime;

			// Token: 0x040001B7 RID: 439
			private static readonly IntPtr NativeFieldInfoPtr_m_StartLifetime;

			// Token: 0x040001B8 RID: 440
			private static readonly IntPtr NativeFieldInfoPtr_m_MeshIndex;

			// Token: 0x040001B9 RID: 441
			private static readonly IntPtr NativeFieldInfoPtr_m_EmitAccumulator0;

			// Token: 0x040001BA RID: 442
			private static readonly IntPtr NativeFieldInfoPtr_m_EmitAccumulator1;

			// Token: 0x040001BB RID: 443
			private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

			// Token: 0x040001BC RID: 444
			private static readonly IntPtr NativeMethodInfoPtr_set_lifetime_Public_set_Void_Single_0;

			// Token: 0x040001BD RID: 445
			private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

			// Token: 0x040001BE RID: 446
			private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0;

			// Token: 0x040001BF RID: 447
			private static readonly IntPtr NativeMethodInfoPtr_set_remainingLifetime_Public_set_Void_Single_0;

			// Token: 0x040001C0 RID: 448
			private static readonly IntPtr NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0;

			// Token: 0x040001C1 RID: 449
			private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0;

			// Token: 0x040001C2 RID: 450
			private static readonly IntPtr NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0;

			// Token: 0x040001C3 RID: 451
			private static readonly IntPtr NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0;

			// Token: 0x040001C4 RID: 452
			private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0;

			// Token: 0x040001C5 RID: 453
			private static readonly IntPtr NativeMethodInfoPtr_set_rotation3D_Public_set_Void_Vector3_0;

			// Token: 0x040001C6 RID: 454
			private static readonly IntPtr NativeMethodInfoPtr_set_angularVelocity3D_Public_set_Void_Vector3_0;

			// Token: 0x040001C7 RID: 455
			[FieldOffset(0)]
			public Vector3 m_Position;

			// Token: 0x040001C8 RID: 456
			[FieldOffset(12)]
			public Vector3 m_Velocity;

			// Token: 0x040001C9 RID: 457
			[FieldOffset(24)]
			public Vector3 m_AnimatedVelocity;

			// Token: 0x040001CA RID: 458
			[FieldOffset(36)]
			public Vector3 m_InitialVelocity;

			// Token: 0x040001CB RID: 459
			[FieldOffset(48)]
			public Vector3 m_AxisOfRotation;

			// Token: 0x040001CC RID: 460
			[FieldOffset(60)]
			public Vector3 m_Rotation;

			// Token: 0x040001CD RID: 461
			[FieldOffset(72)]
			public Vector3 m_AngularVelocity;

			// Token: 0x040001CE RID: 462
			[FieldOffset(84)]
			public Vector3 m_StartSize;

			// Token: 0x040001CF RID: 463
			[FieldOffset(96)]
			public Color32 m_StartColor;

			// Token: 0x040001D0 RID: 464
			[FieldOffset(100)]
			public uint m_RandomSeed;

			// Token: 0x040001D1 RID: 465
			[FieldOffset(104)]
			public uint m_ParentRandomSeed;

			// Token: 0x040001D2 RID: 466
			[FieldOffset(108)]
			public float m_Lifetime;

			// Token: 0x040001D3 RID: 467
			[FieldOffset(112)]
			public float m_StartLifetime;

			// Token: 0x040001D4 RID: 468
			[FieldOffset(116)]
			public int m_MeshIndex;

			// Token: 0x040001D5 RID: 469
			[FieldOffset(120)]
			public float m_EmitAccumulator0;

			// Token: 0x040001D6 RID: 470
			[FieldOffset(124)]
			public float m_EmitAccumulator1;

			// Token: 0x040001D7 RID: 471
			[FieldOffset(128)]
			public uint m_Flags;

			// Token: 0x020000B5 RID: 181
			public enum Flags
			{
				// Token: 0x040001FD RID: 509
				Size3D = 1,
				// Token: 0x040001FE RID: 510
				Rotation3D,
				// Token: 0x040001FF RID: 511
				MeshIndex = 4
			}
		}

		// Token: 0x02000040 RID: 64
		[Serializable]
		public sealed class MinMaxCurve : ValueType
		{
			// Token: 0x06000134 RID: 308 RVA: 0x00005D14 File Offset: 0x00003F14
			// Note: this type is marked as 'beforefieldinit'.
			static MinMaxCurve()
			{
				Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "MinMaxCurve");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr);
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_Mode");
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_CurveMultiplier");
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_CurveMin");
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_CurveMax");
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_ConstantMin");
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_ConstantMax");
				ParticleSystem.MinMaxCurve.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, 100663359);
				ParticleSystem.MinMaxCurve.NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, 100663360);
			}

			// Token: 0x06000135 RID: 309 RVA: 0x00005DE0 File Offset: 0x00003FE0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 512401, RefRangeEnd = 512405, XrefRangeStart = 512401, XrefRangeEnd = 512401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MinMaxCurve(float constant)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref constant;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MinMaxCurve.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000136 RID: 310 RVA: 0x00005E2C File Offset: 0x0000402C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512405, XrefRangeEnd = 512406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe static implicit operator ParticleSystem.MinMaxCurve(float constant)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref constant;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MinMaxCurve.NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxCurve_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ParticleSystem.MinMaxCurve(intPtr);
				}
			}

			// Token: 0x06000137 RID: 311 RVA: 0x00002B2F File Offset: 0x00000D2F
			public MinMaxCurve(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000138 RID: 312 RVA: 0x00002B38 File Offset: 0x00000D38
			public MinMaxCurve()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr))
			{
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00005E64 File Offset: 0x00004064
			// (set) Token: 0x0600013A RID: 314 RVA: 0x00002B4A File Offset: 0x00000D4A
			public unsafe ParticleSystemCurveMode m_Mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_Mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_Mode)) = value;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600013B RID: 315 RVA: 0x00005E8C File Offset: 0x0000408C
			// (set) Token: 0x0600013C RID: 316 RVA: 0x00002B65 File Offset: 0x00000D65
			public unsafe float m_CurveMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMultiplier)) = value;
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600013D RID: 317 RVA: 0x00005EB4 File Offset: 0x000040B4
			// (set) Token: 0x0600013E RID: 318 RVA: 0x00002B80 File Offset: 0x00000D80
			public unsafe AnimationCurve m_CurveMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMin);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMin), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600013F RID: 319 RVA: 0x00005EE4 File Offset: 0x000040E4
			// (set) Token: 0x06000140 RID: 320 RVA: 0x00002B9F File Offset: 0x00000D9F
			public unsafe AnimationCurve m_CurveMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMax);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMax), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000141 RID: 321 RVA: 0x00005F14 File Offset: 0x00004114
			// (set) Token: 0x06000142 RID: 322 RVA: 0x00002BBE File Offset: 0x00000DBE
			public unsafe float m_ConstantMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMin)) = value;
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000143 RID: 323 RVA: 0x00005F3C File Offset: 0x0000413C
			// (set) Token: 0x06000144 RID: 324 RVA: 0x00002BD9 File Offset: 0x00000DD9
			public unsafe float m_ConstantMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMax)) = value;
				}
			}

			// Token: 0x040001D8 RID: 472
			private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

			// Token: 0x040001D9 RID: 473
			private static readonly IntPtr NativeFieldInfoPtr_m_CurveMultiplier;

			// Token: 0x040001DA RID: 474
			private static readonly IntPtr NativeFieldInfoPtr_m_CurveMin;

			// Token: 0x040001DB RID: 475
			private static readonly IntPtr NativeFieldInfoPtr_m_CurveMax;

			// Token: 0x040001DC RID: 476
			private static readonly IntPtr NativeFieldInfoPtr_m_ConstantMin;

			// Token: 0x040001DD RID: 477
			private static readonly IntPtr NativeFieldInfoPtr_m_ConstantMax;

			// Token: 0x040001DE RID: 478
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

			// Token: 0x040001DF RID: 479
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxCurve_Single_0;
		}

		// Token: 0x02000041 RID: 65
		[StructLayout(2)]
		public struct EmitParams
		{
			// Token: 0x06000145 RID: 325 RVA: 0x00005F64 File Offset: 0x00004164
			// Note: this type is marked as 'beforefieldinit'.
			static EmitParams()
			{
				Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "EmitParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr);
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_Particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_Particle");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_PositionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_PositionSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_VelocitySet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_VelocitySet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_AxisOfRotationSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_AxisOfRotationSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_RotationSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_RotationSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_AngularVelocitySet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_AngularVelocitySet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_StartSizeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_StartSizeSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_StartColorSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_StartColorSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_RandomSeedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_RandomSeedSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_StartLifetimeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_StartLifetimeSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_MeshIndexSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_MeshIndexSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_ApplyShapeToPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_ApplyShapeToPosition");
				ParticleSystem.EmitParams.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, 100663361);
				ParticleSystem.EmitParams.NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, 100663362);
				ParticleSystem.EmitParams.NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, 100663363);
				ParticleSystem.EmitParams.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, 100663364);
			}

			// Token: 0x17000067 RID: 103
			// (set) Token: 0x06000146 RID: 326 RVA: 0x000060D0 File Offset: 0x000042D0
			public unsafe Vector3 position
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmitParams.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000068 RID: 104
			// (set) Token: 0x06000147 RID: 327 RVA: 0x00006104 File Offset: 0x00004304
			public unsafe float startLifetime
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmitParams.NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000069 RID: 105
			// (set) Token: 0x06000148 RID: 328 RVA: 0x00006138 File Offset: 0x00004338
			public unsafe float rotation
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmitParams.NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700006A RID: 106
			// (set) Token: 0x06000149 RID: 329 RVA: 0x0000616C File Offset: 0x0000436C
			public unsafe Color32 startColor
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmitParams.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600014A RID: 330 RVA: 0x00002BF4 File Offset: 0x00000DF4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, ref this));
			}

			// Token: 0x040001E0 RID: 480
			private static readonly IntPtr NativeFieldInfoPtr_m_Particle;

			// Token: 0x040001E1 RID: 481
			private static readonly IntPtr NativeFieldInfoPtr_m_PositionSet;

			// Token: 0x040001E2 RID: 482
			private static readonly IntPtr NativeFieldInfoPtr_m_VelocitySet;

			// Token: 0x040001E3 RID: 483
			private static readonly IntPtr NativeFieldInfoPtr_m_AxisOfRotationSet;

			// Token: 0x040001E4 RID: 484
			private static readonly IntPtr NativeFieldInfoPtr_m_RotationSet;

			// Token: 0x040001E5 RID: 485
			private static readonly IntPtr NativeFieldInfoPtr_m_AngularVelocitySet;

			// Token: 0x040001E6 RID: 486
			private static readonly IntPtr NativeFieldInfoPtr_m_StartSizeSet;

			// Token: 0x040001E7 RID: 487
			private static readonly IntPtr NativeFieldInfoPtr_m_StartColorSet;

			// Token: 0x040001E8 RID: 488
			private static readonly IntPtr NativeFieldInfoPtr_m_RandomSeedSet;

			// Token: 0x040001E9 RID: 489
			private static readonly IntPtr NativeFieldInfoPtr_m_StartLifetimeSet;

			// Token: 0x040001EA RID: 490
			private static readonly IntPtr NativeFieldInfoPtr_m_MeshIndexSet;

			// Token: 0x040001EB RID: 491
			private static readonly IntPtr NativeFieldInfoPtr_m_ApplyShapeToPosition;

			// Token: 0x040001EC RID: 492
			private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

			// Token: 0x040001ED RID: 493
			private static readonly IntPtr NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0;

			// Token: 0x040001EE RID: 494
			private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0;

			// Token: 0x040001EF RID: 495
			private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0;

			// Token: 0x040001F0 RID: 496
			[FieldOffset(0)]
			public ParticleSystem.Particle m_Particle;

			// Token: 0x040001F1 RID: 497
			[FieldOffset(132)]
			[MarshalAs(4)]
			public bool m_PositionSet;

			// Token: 0x040001F2 RID: 498
			[FieldOffset(133)]
			[MarshalAs(4)]
			public bool m_VelocitySet;

			// Token: 0x040001F3 RID: 499
			[FieldOffset(134)]
			[MarshalAs(4)]
			public bool m_AxisOfRotationSet;

			// Token: 0x040001F4 RID: 500
			[FieldOffset(135)]
			[MarshalAs(4)]
			public bool m_RotationSet;

			// Token: 0x040001F5 RID: 501
			[FieldOffset(136)]
			[MarshalAs(4)]
			public bool m_AngularVelocitySet;

			// Token: 0x040001F6 RID: 502
			[FieldOffset(137)]
			[MarshalAs(4)]
			public bool m_StartSizeSet;

			// Token: 0x040001F7 RID: 503
			[FieldOffset(138)]
			[MarshalAs(4)]
			public bool m_StartColorSet;

			// Token: 0x040001F8 RID: 504
			[FieldOffset(139)]
			[MarshalAs(4)]
			public bool m_RandomSeedSet;

			// Token: 0x040001F9 RID: 505
			[FieldOffset(140)]
			[MarshalAs(4)]
			public bool m_StartLifetimeSet;

			// Token: 0x040001FA RID: 506
			[FieldOffset(141)]
			[MarshalAs(4)]
			public bool m_MeshIndexSet;

			// Token: 0x040001FB RID: 507
			[FieldOffset(142)]
			[MarshalAs(4)]
			public bool m_ApplyShapeToPosition;
		}

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600014C RID: 332
		private delegate bool get_isEmittingDelegate(IntPtr @this);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x0600014E RID: 334
		private delegate bool get_isStoppedDelegate(IntPtr @this);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000150 RID: 336
		private delegate bool get_isPausedDelegate(IntPtr @this);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000152 RID: 338
		private delegate void set_timeDelegate(IntPtr @this, float value);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000154 RID: 340
		private delegate uint get_randomSeedDelegate(IntPtr @this);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000156 RID: 342
		private delegate bool get_proceduralSimulationSupportedDelegate(IntPtr @this);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000158 RID: 344
		private delegate float GetParticleCurrentSizeDelegate(IntPtr @this, IntPtr particle);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600015A RID: 346
		private delegate int GetParticleMeshIndexDelegate(IntPtr @this, IntPtr particle);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600015C RID: 348
		private delegate void SetParticlesWithNativeArrayDelegate(IntPtr @this, IntPtr particles, int particlesLength, int size, int offset);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600015E RID: 350
		private delegate int GetParticlesWithNativeArrayDelegate(IntPtr @this, IntPtr particles, int particlesLength, int size, int offset);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000160 RID: 352
		private delegate void SetCustomParticleDataDelegate(IntPtr @this, IntPtr customData, ParticleSystemCustomData streamIndex);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000162 RID: 354
		private delegate int GetCustomParticleDataDelegate(IntPtr @this, IntPtr customData, ParticleSystemCustomData streamIndex);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000164 RID: 356
		private delegate void PauseDelegate(IntPtr @this, bool withChildren);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000166 RID: 358
		private delegate bool IsAliveDelegate(IntPtr @this, bool withChildren);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000168 RID: 360
		private delegate void TriggerSubEmitterDelegate(IntPtr @this, int subEmitterIndex, IntPtr particles);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600016A RID: 362
		private delegate void ResetPreMappedBufferMemoryDelegate();

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x0600016C RID: 364
		private delegate void SetMaximumPreMappedBufferCountsDelegate(int vertexBuffersCount, int indexBuffersCount);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x0600016E RID: 366
		private delegate void AllocateAxisOfRotationAttributeDelegate(IntPtr @this);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000170 RID: 368
		private delegate void AllocateMeshIndexAttributeDelegate(IntPtr @this);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000172 RID: 370
		private delegate void AllocateCustomDataAttributeDelegate(IntPtr @this, ParticleSystemCustomData stream);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000174 RID: 372
		private delegate IntPtr GetManagedJobDataDelegate(IntPtr @this);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000176 RID: 374
		private delegate void GetParticleCurrentSize3D_InjectedDelegate(IntPtr @this, IntPtr particle, [Out] IntPtr ret);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000178 RID: 376
		private delegate void GetParticleCurrentColor_InjectedDelegate(IntPtr @this, IntPtr particle, [Out] IntPtr ret);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600017A RID: 378
		private delegate void TriggerSubEmitterForParticle_InjectedDelegate(IntPtr @this, int subEmitterIndex, IntPtr particle);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600017C RID: 380
		private delegate void GetManagedJobHandle_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x0600017E RID: 382
		private delegate void SetManagedJobHandle_InjectedDelegate(IntPtr @this, IntPtr handle);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000180 RID: 384
		private delegate void ScheduleManagedJob_InjectedDelegate(IntPtr parameters, IntPtr additionalData, [Out] IntPtr ret);
	}
}
