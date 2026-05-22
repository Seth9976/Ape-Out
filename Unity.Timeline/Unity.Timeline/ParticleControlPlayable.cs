using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000035 RID: 53
	public class ParticleControlPlayable : PlayableBehaviour
	{
		// Token: 0x0600043D RID: 1085 RVA: 0x00015460 File Offset: 0x00013660
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleControlPlayable()
		{
			Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ParticleControlPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr);
			ParticleControlPlayable.NativeFieldInfoPtr_kUnsetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, "kUnsetTime");
			ParticleControlPlayable.NativeFieldInfoPtr_m_LastPlayableTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, "m_LastPlayableTime");
			ParticleControlPlayable.NativeFieldInfoPtr_m_LastParticleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, "m_LastParticleTime");
			ParticleControlPlayable.NativeFieldInfoPtr_m_RandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, "m_RandomSeed");
			ParticleControlPlayable.NativeFieldInfoPtr__particleSystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, "<particleSystem>k__BackingField");
			ParticleControlPlayable.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ParticleControlPlayable_PlayableGraph_ParticleSystem_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, 100664017);
			ParticleControlPlayable.NativeMethodInfoPtr_get_particleSystem_Public_get_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, 100664018);
			ParticleControlPlayable.NativeMethodInfoPtr_set_particleSystem_Private_set_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, 100664019);
			ParticleControlPlayable.NativeMethodInfoPtr_Initialize_Public_Void_ParticleSystem_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, 100664020);
			ParticleControlPlayable.NativeMethodInfoPtr_SetRandomSeed_Private_Static_Void_ParticleSystem_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, 100664021);
			ParticleControlPlayable.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, 100664022);
			ParticleControlPlayable.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, 100664023);
			ParticleControlPlayable.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, 100664024);
			ParticleControlPlayable.NativeMethodInfoPtr_Simulate_Private_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, 100664025);
			ParticleControlPlayable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr, 100664026);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000155BC File Offset: 0x000137BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478856, RefRangeEnd = 478857, XrefRangeStart = 478824, XrefRangeEnd = 478856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomSeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleControlPlayable.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ParticleControlPlayable_PlayableGraph_ParticleSystem_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ScriptPlayable<ParticleControlPlayable>(intPtr);
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00015614 File Offset: 0x00013814
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x00015654 File Offset: 0x00013854
		public unsafe ParticleSystem particleSystem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleControlPlayable.NativeMethodInfoPtr_get_particleSystem_Public_get_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleControlPlayable.NativeMethodInfoPtr_set_particleSystem_Private_set_Void_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00015698 File Offset: 0x00013898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478857, XrefRangeEnd = 478861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ParticleSystem ps, uint randomSeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomSeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleControlPlayable.NativeMethodInfoPtr_Initialize_Public_Void_ParticleSystem_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000156E8 File Offset: 0x000138E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 478886, RefRangeEnd = 478889, XrefRangeStart = 478861, XrefRangeEnd = 478886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomSeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleControlPlayable.NativeMethodInfoPtr_SetRandomSeed_Private_Static_Void_ParticleSystem_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0001572C File Offset: 0x0001392C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478889, XrefRangeEnd = 478915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PrepareFrame(Playable playable, FrameData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleControlPlayable.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00015784 File Offset: 0x00013984
		[CallerCount(0)]
		public unsafe override void OnBehaviourPlay(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleControlPlayable.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000157DC File Offset: 0x000139DC
		[CallerCount(0)]
		public unsafe override void OnBehaviourPause(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleControlPlayable.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00015834 File Offset: 0x00013A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478923, RefRangeEnd = 478924, XrefRangeStart = 478915, XrefRangeEnd = 478923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Simulate(float time, bool restart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleControlPlayable.NativeMethodInfoPtr_Simulate_Private_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00015880 File Offset: 0x00013A80
		[CallerCount(0)]
		public unsafe ParticleControlPlayable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleControlPlayable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleControlPlayable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00003564 File Offset: 0x00001764
		public ParticleControlPlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x000158BC File Offset: 0x00013ABC
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0000356D File Offset: 0x0000176D
		public unsafe static float kUnsetTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ParticleControlPlayable.NativeFieldInfoPtr_kUnsetTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParticleControlPlayable.NativeFieldInfoPtr_kUnsetTime, (void*)(&value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x000158D8 File Offset: 0x00013AD8
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x0000357B File Offset: 0x0000177B
		public unsafe float m_LastPlayableTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleControlPlayable.NativeFieldInfoPtr_m_LastPlayableTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleControlPlayable.NativeFieldInfoPtr_m_LastPlayableTime)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00015900 File Offset: 0x00013B00
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00003596 File Offset: 0x00001796
		public unsafe float m_LastParticleTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleControlPlayable.NativeFieldInfoPtr_m_LastParticleTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleControlPlayable.NativeFieldInfoPtr_m_LastParticleTime)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00015928 File Offset: 0x00013B28
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x000035B1 File Offset: 0x000017B1
		public unsafe uint m_RandomSeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleControlPlayable.NativeFieldInfoPtr_m_RandomSeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleControlPlayable.NativeFieldInfoPtr_m_RandomSeed)) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00015950 File Offset: 0x00013B50
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x000035CC File Offset: 0x000017CC
		public unsafe ParticleSystem _particleSystem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleControlPlayable.NativeFieldInfoPtr__particleSystem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleControlPlayable.NativeFieldInfoPtr__particleSystem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeFieldInfoPtr_kUnsetTime;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeFieldInfoPtr_m_LastPlayableTime;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeFieldInfoPtr_m_LastParticleTime;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeFieldInfoPtr_m_RandomSeed;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeFieldInfoPtr__particleSystem_k__BackingField;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ParticleControlPlayable_PlayableGraph_ParticleSystem_UInt32_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_get_particleSystem_Public_get_ParticleSystem_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_set_particleSystem_Private_set_Void_ParticleSystem_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ParticleSystem_UInt32_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomSeed_Private_Static_Void_ParticleSystem_UInt32_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Private_Void_Single_Boolean_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
