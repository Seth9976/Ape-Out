using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000005 RID: 5
	public class AnimationOutputWeightProcessor : Object
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00004B9C File Offset: 0x00002D9C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationOutputWeightProcessor()
		{
			Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "AnimationOutputWeightProcessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr);
			AnimationOutputWeightProcessor.NativeFieldInfoPtr_m_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, "m_Output");
			AnimationOutputWeightProcessor.NativeFieldInfoPtr_m_MotionXPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, "m_MotionXPlayable");
			AnimationOutputWeightProcessor.NativeFieldInfoPtr_m_Mixers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, "m_Mixers");
			AnimationOutputWeightProcessor.NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, 100663314);
			AnimationOutputWeightProcessor.NativeMethodInfoPtr_FindMixers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, 100663315);
			AnimationOutputWeightProcessor.NativeMethodInfoPtr_FindMixers_Private_Void_Playable_Int32_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, 100663316);
			AnimationOutputWeightProcessor.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, 100663317);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004C58 File Offset: 0x00002E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472414, RefRangeEnd = 472415, XrefRangeStart = 472394, XrefRangeEnd = 472414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationOutputWeightProcessor(AnimationPlayableOutput output)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref output;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOutputWeightProcessor.NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004CA0 File Offset: 0x00002EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472436, RefRangeEnd = 472437, XrefRangeStart = 472415, XrefRangeEnd = 472436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindMixers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOutputWeightProcessor.NativeMethodInfoPtr_FindMixers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004CD4 File Offset: 0x00002ED4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 472474, RefRangeEnd = 472477, XrefRangeStart = 472437, XrefRangeEnd = 472474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindMixers(Playable parent, int port, Playable node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref parent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref node;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOutputWeightProcessor.NativeMethodInfoPtr_FindMixers_Private_Void_Playable_Int32_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004D30 File Offset: 0x00002F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472477, XrefRangeEnd = 472501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOutputWeightProcessor.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020FA File Offset: 0x000002FA
		public AnimationOutputWeightProcessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00004D64 File Offset: 0x00002F64
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002103 File Offset: 0x00000303
		public unsafe AnimationPlayableOutput m_Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationOutputWeightProcessor.NativeFieldInfoPtr_m_Output);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationOutputWeightProcessor.NativeFieldInfoPtr_m_Output)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00004D8C File Offset: 0x00002F8C
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000211E File Offset: 0x0000031E
		public unsafe AnimationMotionXToDeltaPlayable m_MotionXPlayable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationOutputWeightProcessor.NativeFieldInfoPtr_m_MotionXPlayable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationOutputWeightProcessor.NativeFieldInfoPtr_m_MotionXPlayable)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00004DB4 File Offset: 0x00002FB4
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002139 File Offset: 0x00000339
		public unsafe List<AnimationOutputWeightProcessor.WeightInfo> m_Mixers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationOutputWeightProcessor.NativeFieldInfoPtr_m_Mixers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AnimationOutputWeightProcessor.WeightInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationOutputWeightProcessor.NativeFieldInfoPtr_m_Mixers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_m_Output;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_m_MotionXPlayable;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_m_Mixers;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_FindMixers_Private_Void_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_FindMixers_Private_Void_Playable_Int32_Playable_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000052 RID: 82
		[StructLayout(2)]
		public struct WeightInfo
		{
			// Token: 0x06000529 RID: 1321 RVA: 0x00018DE4 File Offset: 0x00016FE4
			// Note: this type is marked as 'beforefieldinit'.
			static WeightInfo()
			{
				Il2CppClassPointerStore<AnimationOutputWeightProcessor.WeightInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, "WeightInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationOutputWeightProcessor.WeightInfo>.NativeClassPtr);
				AnimationOutputWeightProcessor.WeightInfo.NativeFieldInfoPtr_mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOutputWeightProcessor.WeightInfo>.NativeClassPtr, "mixer");
				AnimationOutputWeightProcessor.WeightInfo.NativeFieldInfoPtr_parentMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOutputWeightProcessor.WeightInfo>.NativeClassPtr, "parentMixer");
				AnimationOutputWeightProcessor.WeightInfo.NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOutputWeightProcessor.WeightInfo>.NativeClassPtr, "port");
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x00003B2D File Offset: 0x00001D2D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationOutputWeightProcessor.WeightInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x040003F6 RID: 1014
			private static readonly IntPtr NativeFieldInfoPtr_mixer;

			// Token: 0x040003F7 RID: 1015
			private static readonly IntPtr NativeFieldInfoPtr_parentMixer;

			// Token: 0x040003F8 RID: 1016
			private static readonly IntPtr NativeFieldInfoPtr_port;

			// Token: 0x040003F9 RID: 1017
			[FieldOffset(0)]
			public Playable mixer;

			// Token: 0x040003FA RID: 1018
			[FieldOffset(16)]
			public Playable parentMixer;

			// Token: 0x040003FB RID: 1019
			[FieldOffset(32)]
			public int port;
		}
	}
}
