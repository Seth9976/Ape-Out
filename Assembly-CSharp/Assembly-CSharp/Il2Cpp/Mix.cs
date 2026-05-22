using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200000A RID: 10
	public class Mix : MonoBehaviour
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x000365D4 File Offset: 0x000347D4
		// Note: this type is marked as 'beforefieldinit'.
		static Mix()
		{
			Il2CppClassPointerStore<Mix>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Mix");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mix>.NativeClassPtr);
			Mix.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix>.NativeClassPtr, "me");
			Mix.NativeFieldInfoPtr_MixSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix>.NativeClassPtr, "MixSettings");
			Mix.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mix>.NativeClassPtr, 100663339);
			Mix.NativeMethodInfoPtr_GetMixFromLevelSamplerPatch_Public_Settings_LevelSamplerPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mix>.NativeClassPtr, 100663340);
			Mix.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mix>.NativeClassPtr, 100663341);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00036668 File Offset: 0x00034868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30657, XrefRangeEnd = 30677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mix.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0003669C File Offset: 0x0003489C
		[CallerCount(0)]
		public unsafe Mix.Settings GetMixFromLevelSamplerPatch(MusicSystem.LevelSamplerPatch patch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref patch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mix.NativeMethodInfoPtr_GetMixFromLevelSamplerPatch_Public_Settings_LevelSamplerPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mix.Settings>(intPtr3) : null;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000366E8 File Offset: 0x000348E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mix()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mix>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mix.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000028B0 File Offset: 0x00000AB0
		public Mix(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00036724 File Offset: 0x00034924
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000028B9 File Offset: 0x00000AB9
		public unsafe static Mix me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Mix.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mix>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Mix.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0003674C File Offset: 0x0003494C
		// (set) Token: 0x060000CE RID: 206 RVA: 0x000028CB File Offset: 0x00000ACB
		public unsafe Il2CppReferenceArray<Mix.Settings> MixSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.NativeFieldInfoPtr_MixSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Mix.Settings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.NativeFieldInfoPtr_MixSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_MixSettings;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_GetMixFromLevelSamplerPatch_Public_Settings_LevelSamplerPatch_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000293 RID: 659
		[Serializable]
		public class Settings : global::Il2CppSystem.Object
		{
			// Token: 0x060049B3 RID: 18867 RVA: 0x00111DD0 File Offset: 0x0010FFD0
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Mix>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr);
				Mix.Settings.NativeFieldInfoPtr_SamplerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, "SamplerPatch");
				Mix.Settings.NativeFieldInfoPtr_DrumVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, "DrumVolume");
				Mix.Settings.NativeFieldInfoPtr_CymbalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, "CymbalVolume");
				Mix.Settings.NativeFieldInfoPtr_DistortionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, "DistortionLevel");
				Mix.Settings.NativeFieldInfoPtr_DrumCompressorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, "DrumCompressorLevel");
				Mix.Settings.NativeFieldInfoPtr_Yelling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, "Yelling");
				Mix.Settings.NativeFieldInfoPtr_Vary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, "Vary");
				Mix.Settings.NativeFieldInfoPtr_TempoMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, "TempoMod");
				Mix.Settings.NativeFieldInfoPtr_VelocityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, "VelocityCurve");
				Mix.Settings.NativeFieldInfoPtr_VolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, "VolumeCurve");
				Mix.Settings.NativeFieldInfoPtr_HiHatAttenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, "HiHatAttenuation");
				Mix.Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr, 100663342);
			}

			// Token: 0x060049B4 RID: 18868 RVA: 0x00111EEC File Offset: 0x001100EC
			[CallerCount(0)]
			public unsafe Settings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mix.Settings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mix.Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049B5 RID: 18869 RVA: 0x0002B67D File Offset: 0x0002987D
			public Settings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ACD RID: 6861
			// (get) Token: 0x060049B6 RID: 18870 RVA: 0x00111F28 File Offset: 0x00110128
			// (set) Token: 0x060049B7 RID: 18871 RVA: 0x0002B686 File Offset: 0x00029886
			public unsafe MusicSystem.LevelSamplerPatch SamplerPatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_SamplerPatch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_SamplerPatch)) = value;
				}
			}

			// Token: 0x17001ACE RID: 6862
			// (get) Token: 0x060049B8 RID: 18872 RVA: 0x00111F50 File Offset: 0x00110150
			// (set) Token: 0x060049B9 RID: 18873 RVA: 0x0002B6A1 File Offset: 0x000298A1
			public unsafe int DrumVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_DrumVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_DrumVolume)) = value;
				}
			}

			// Token: 0x17001ACF RID: 6863
			// (get) Token: 0x060049BA RID: 18874 RVA: 0x00111F78 File Offset: 0x00110178
			// (set) Token: 0x060049BB RID: 18875 RVA: 0x0002B6BC File Offset: 0x000298BC
			public unsafe int CymbalVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_CymbalVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_CymbalVolume)) = value;
				}
			}

			// Token: 0x17001AD0 RID: 6864
			// (get) Token: 0x060049BC RID: 18876 RVA: 0x00111FA0 File Offset: 0x001101A0
			// (set) Token: 0x060049BD RID: 18877 RVA: 0x0002B6D7 File Offset: 0x000298D7
			public unsafe float DistortionLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_DistortionLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_DistortionLevel)) = value;
				}
			}

			// Token: 0x17001AD1 RID: 6865
			// (get) Token: 0x060049BE RID: 18878 RVA: 0x00111FC8 File Offset: 0x001101C8
			// (set) Token: 0x060049BF RID: 18879 RVA: 0x0002B6F2 File Offset: 0x000298F2
			public unsafe float DrumCompressorLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_DrumCompressorLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_DrumCompressorLevel)) = value;
				}
			}

			// Token: 0x17001AD2 RID: 6866
			// (get) Token: 0x060049C0 RID: 18880 RVA: 0x00111FF0 File Offset: 0x001101F0
			// (set) Token: 0x060049C1 RID: 18881 RVA: 0x0002B70D File Offset: 0x0002990D
			public unsafe bool Yelling
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_Yelling);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_Yelling)) = value;
				}
			}

			// Token: 0x17001AD3 RID: 6867
			// (get) Token: 0x060049C2 RID: 18882 RVA: 0x00112018 File Offset: 0x00110218
			// (set) Token: 0x060049C3 RID: 18883 RVA: 0x0002B728 File Offset: 0x00029928
			public unsafe bool Vary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_Vary);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_Vary)) = value;
				}
			}

			// Token: 0x17001AD4 RID: 6868
			// (get) Token: 0x060049C4 RID: 18884 RVA: 0x00112040 File Offset: 0x00110240
			// (set) Token: 0x060049C5 RID: 18885 RVA: 0x0002B743 File Offset: 0x00029943
			public unsafe float TempoMod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_TempoMod);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_TempoMod)) = value;
				}
			}

			// Token: 0x17001AD5 RID: 6869
			// (get) Token: 0x060049C6 RID: 18886 RVA: 0x00112068 File Offset: 0x00110268
			// (set) Token: 0x060049C7 RID: 18887 RVA: 0x0002B75E File Offset: 0x0002995E
			public unsafe AnimationCurve VelocityCurve
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_VelocityCurve);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_VelocityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AD6 RID: 6870
			// (get) Token: 0x060049C8 RID: 18888 RVA: 0x00112098 File Offset: 0x00110298
			// (set) Token: 0x060049C9 RID: 18889 RVA: 0x0002B77D File Offset: 0x0002997D
			public unsafe AnimationCurve VolumeCurve
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_VolumeCurve);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_VolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AD7 RID: 6871
			// (get) Token: 0x060049CA RID: 18890 RVA: 0x001120C8 File Offset: 0x001102C8
			// (set) Token: 0x060049CB RID: 18891 RVA: 0x0002B79C File Offset: 0x0002999C
			public unsafe float HiHatAttenuation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_HiHatAttenuation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mix.Settings.NativeFieldInfoPtr_HiHatAttenuation)) = value;
				}
			}

			// Token: 0x04002FCF RID: 12239
			private static readonly IntPtr NativeFieldInfoPtr_SamplerPatch;

			// Token: 0x04002FD0 RID: 12240
			private static readonly IntPtr NativeFieldInfoPtr_DrumVolume;

			// Token: 0x04002FD1 RID: 12241
			private static readonly IntPtr NativeFieldInfoPtr_CymbalVolume;

			// Token: 0x04002FD2 RID: 12242
			private static readonly IntPtr NativeFieldInfoPtr_DistortionLevel;

			// Token: 0x04002FD3 RID: 12243
			private static readonly IntPtr NativeFieldInfoPtr_DrumCompressorLevel;

			// Token: 0x04002FD4 RID: 12244
			private static readonly IntPtr NativeFieldInfoPtr_Yelling;

			// Token: 0x04002FD5 RID: 12245
			private static readonly IntPtr NativeFieldInfoPtr_Vary;

			// Token: 0x04002FD6 RID: 12246
			private static readonly IntPtr NativeFieldInfoPtr_TempoMod;

			// Token: 0x04002FD7 RID: 12247
			private static readonly IntPtr NativeFieldInfoPtr_VelocityCurve;

			// Token: 0x04002FD8 RID: 12248
			private static readonly IntPtr NativeFieldInfoPtr_VolumeCurve;

			// Token: 0x04002FD9 RID: 12249
			private static readonly IntPtr NativeFieldInfoPtr_HiHatAttenuation;

			// Token: 0x04002FDA RID: 12250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
