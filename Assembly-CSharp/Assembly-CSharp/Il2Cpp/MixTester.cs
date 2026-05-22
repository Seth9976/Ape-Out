using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000002 RID: 2
	public class MixTester : MonoBehaviour
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000347DC File Offset: 0x000329DC
		// Note: this type is marked as 'beforefieldinit'.
		static MixTester()
		{
			Il2CppClassPointerStore<MixTester>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MixTester");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixTester>.NativeClassPtr);
			MixTester.NativeFieldInfoPtr_floorMatInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester>.NativeClassPtr, "floorMatInt");
			MixTester.NativeFieldInfoPtr_sampInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester>.NativeClassPtr, "sampInt");
			MixTester.NativeFieldInfoPtr_seqInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester>.NativeClassPtr, "seqInt");
			MixTester.NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester>.NativeClassPtr, "Intensity");
			MixTester.NativeFieldInfoPtr_MixProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester>.NativeClassPtr, "MixProfiles");
			MixTester.NativeFieldInfoPtr_currentMixProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester>.NativeClassPtr, "currentMixProfile");
			MixTester.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester>.NativeClassPtr, 100663297);
			MixTester.NativeMethodInfoPtr_Start_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester>.NativeClassPtr, 100663298);
			MixTester.NativeMethodInfoPtr_SetMixProfile_Public_Void_MixProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester>.NativeClassPtr, 100663299);
			MixTester.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester>.NativeClassPtr, 100663300);
			MixTester.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester>.NativeClassPtr, 100663301);
			MixTester.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester>.NativeClassPtr, 100663302);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000348FC File Offset: 0x00032AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30239, XrefRangeEnd = 30249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00034930 File Offset: 0x00032B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30249, XrefRangeEnd = 30252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester.NativeMethodInfoPtr_Start_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00034970 File Offset: 0x00032B70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 30272, RefRangeEnd = 30275, XrefRangeStart = 30252, XrefRangeEnd = 30272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMixProfile(MixTester.MixProfile profile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester.NativeMethodInfoPtr_SetMixProfile_Public_Void_MixProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000349B4 File Offset: 0x00032BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30275, XrefRangeEnd = 30277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000349E8 File Offset: 0x00032BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30277, XrefRangeEnd = 30304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00034A1C File Offset: 0x00032C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30304, XrefRangeEnd = 30313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixTester()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixTester>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		public MixTester(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00034A58 File Offset: 0x00032C58
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe int floorMatInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_floorMatInt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_floorMatInt)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00034A80 File Offset: 0x00032C80
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe int sampInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_sampInt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_sampInt)) = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00034AA8 File Offset: 0x00032CA8
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000208F File Offset: 0x0000028F
		public unsafe int seqInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_seqInt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_seqInt)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00034AD0 File Offset: 0x00032CD0
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020AA File Offset: 0x000002AA
		public unsafe float Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_Intensity)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00034AF8 File Offset: 0x00032CF8
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020C5 File Offset: 0x000002C5
		public unsafe List<MixTester.MixProfile> MixProfiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_MixProfiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MixTester.MixProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_MixProfiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00034B28 File Offset: 0x00032D28
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020E4 File Offset: 0x000002E4
		public unsafe int currentMixProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_currentMixProfile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.NativeFieldInfoPtr_currentMixProfile)) = value;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_floorMatInt;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_sampInt;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_seqInt;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_Intensity;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_MixProfiles;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_currentMixProfile;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_IEnumerator_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_SetMixProfile_Public_Void_MixProfile_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200028E RID: 654
		[Serializable]
		public class MixProfile : global::Il2CppSystem.Object
		{
			// Token: 0x0600498C RID: 18828 RVA: 0x001118A0 File Offset: 0x0010FAA0
			// Note: this type is marked as 'beforefieldinit'.
			static MixProfile()
			{
				Il2CppClassPointerStore<MixTester.MixProfile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MixTester>.NativeClassPtr, "MixProfile");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixTester.MixProfile>.NativeClassPtr);
				MixTester.MixProfile.NativeFieldInfoPtr_Ambiance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester.MixProfile>.NativeClassPtr, "Ambiance");
				MixTester.MixProfile.NativeFieldInfoPtr_Reverb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester.MixProfile>.NativeClassPtr, "Reverb");
				MixTester.MixProfile.NativeFieldInfoPtr_Room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester.MixProfile>.NativeClassPtr, "Room");
				MixTester.MixProfile.NativeFieldInfoPtr_SamplerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester.MixProfile>.NativeClassPtr, "SamplerPatch");
				MixTester.MixProfile.NativeFieldInfoPtr_SequencerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester.MixProfile>.NativeClassPtr, "SequencerPatch");
				MixTester.MixProfile.NativeFieldInfoPtr_FloorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester.MixProfile>.NativeClassPtr, "FloorMaterial");
				MixTester.MixProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester.MixProfile>.NativeClassPtr, 100663303);
			}

			// Token: 0x0600498D RID: 18829 RVA: 0x00111958 File Offset: 0x0010FB58
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MixProfile()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixTester.MixProfile>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester.MixProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600498E RID: 18830 RVA: 0x0002B488 File Offset: 0x00029688
			public MixProfile(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AC0 RID: 6848
			// (get) Token: 0x0600498F RID: 18831 RVA: 0x00111994 File Offset: 0x0010FB94
			// (set) Token: 0x06004990 RID: 18832 RVA: 0x0002B491 File Offset: 0x00029691
			public unsafe SECTR_AudioAmbience Ambiance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_Ambiance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioAmbience>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_Ambiance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC1 RID: 6849
			// (get) Token: 0x06004991 RID: 18833 RVA: 0x001119C4 File Offset: 0x0010FBC4
			// (set) Token: 0x06004992 RID: 18834 RVA: 0x0002B4B0 File Offset: 0x000296B0
			public unsafe ReverbPatch Reverb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_Reverb);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReverbPatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_Reverb), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC2 RID: 6850
			// (get) Token: 0x06004993 RID: 18835 RVA: 0x001119F4 File Offset: 0x0010FBF4
			// (set) Token: 0x06004994 RID: 18836 RVA: 0x0002B4CF File Offset: 0x000296CF
			public unsafe ResonanceRoomPatch Room
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_Room);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceRoomPatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_Room), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC3 RID: 6851
			// (get) Token: 0x06004995 RID: 18837 RVA: 0x00111A24 File Offset: 0x0010FC24
			// (set) Token: 0x06004996 RID: 18838 RVA: 0x0002B4EE File Offset: 0x000296EE
			public unsafe MusicSystem.LevelSamplerPatch SamplerPatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_SamplerPatch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_SamplerPatch)) = value;
				}
			}

			// Token: 0x17001AC4 RID: 6852
			// (get) Token: 0x06004997 RID: 18839 RVA: 0x00111A4C File Offset: 0x0010FC4C
			// (set) Token: 0x06004998 RID: 18840 RVA: 0x0002B509 File Offset: 0x00029709
			public unsafe MusicSystem.LevelSequencerPatch SequencerPatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_SequencerPatch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_SequencerPatch)) = value;
				}
			}

			// Token: 0x17001AC5 RID: 6853
			// (get) Token: 0x06004999 RID: 18841 RVA: 0x00111A74 File Offset: 0x0010FC74
			// (set) Token: 0x0600499A RID: 18842 RVA: 0x0002B524 File Offset: 0x00029724
			public unsafe Level.FloorMaterial FloorMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_FloorMaterial);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester.MixProfile.NativeFieldInfoPtr_FloorMaterial)) = value;
				}
			}

			// Token: 0x04002FA0 RID: 12192
			private static readonly IntPtr NativeFieldInfoPtr_Ambiance;

			// Token: 0x04002FA1 RID: 12193
			private static readonly IntPtr NativeFieldInfoPtr_Reverb;

			// Token: 0x04002FA2 RID: 12194
			private static readonly IntPtr NativeFieldInfoPtr_Room;

			// Token: 0x04002FA3 RID: 12195
			private static readonly IntPtr NativeFieldInfoPtr_SamplerPatch;

			// Token: 0x04002FA4 RID: 12196
			private static readonly IntPtr NativeFieldInfoPtr_SequencerPatch;

			// Token: 0x04002FA5 RID: 12197
			private static readonly IntPtr NativeFieldInfoPtr_FloorMaterial;

			// Token: 0x04002FA6 RID: 12198
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200028F RID: 655
		[ObfuscatedName("MixTester+<Start>d__8")]
		public sealed class _Start_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x0600499B RID: 18843 RVA: 0x00111A9C File Offset: 0x0010FC9C
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__8()
			{
				Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MixTester>.NativeClassPtr, "<Start>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr);
				MixTester._Start_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr, "<>1__state");
				MixTester._Start_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr, "<>2__current");
				MixTester._Start_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr, "<>4__this");
				MixTester._Start_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr, 100663304);
				MixTester._Start_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr, 100663305);
				MixTester._Start_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr, 100663306);
				MixTester._Start_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr, 100663307);
				MixTester._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr, 100663308);
				MixTester._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr, 100663309);
			}

			// Token: 0x0600499C RID: 18844 RVA: 0x00111B7C File Offset: 0x0010FD7C
			[CallerCount(0)]
			public unsafe _Start_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixTester._Start_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester._Start_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600499D RID: 18845 RVA: 0x00111BC4 File Offset: 0x0010FDC4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester._Start_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600499E RID: 18846 RVA: 0x00111BF8 File Offset: 0x0010FDF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30226, XrefRangeEnd = 30234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester._Start_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001AC9 RID: 6857
			// (get) Token: 0x0600499F RID: 18847 RVA: 0x00111C34 File Offset: 0x0010FE34
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester._Start_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060049A0 RID: 18848 RVA: 0x00111C74 File Offset: 0x0010FE74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30234, XrefRangeEnd = 30239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001ACA RID: 6858
			// (get) Token: 0x060049A1 RID: 18849 RVA: 0x00111CA8 File Offset: 0x0010FEA8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixTester._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060049A2 RID: 18850 RVA: 0x0002B53F File Offset: 0x0002973F
			public _Start_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AC6 RID: 6854
			// (get) Token: 0x060049A3 RID: 18851 RVA: 0x00111CE8 File Offset: 0x0010FEE8
			// (set) Token: 0x060049A4 RID: 18852 RVA: 0x0002B548 File Offset: 0x00029748
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester._Start_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester._Start_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AC7 RID: 6855
			// (get) Token: 0x060049A5 RID: 18853 RVA: 0x00111D10 File Offset: 0x0010FF10
			// (set) Token: 0x060049A6 RID: 18854 RVA: 0x0002B563 File Offset: 0x00029763
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester._Start_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester._Start_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC8 RID: 6856
			// (get) Token: 0x060049A7 RID: 18855 RVA: 0x00111D40 File Offset: 0x0010FF40
			// (set) Token: 0x060049A8 RID: 18856 RVA: 0x0002B582 File Offset: 0x00029782
			public unsafe MixTester __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester._Start_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixTester>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixTester._Start_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FA7 RID: 12199
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002FA8 RID: 12200
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002FA9 RID: 12201
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002FAA RID: 12202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002FAB RID: 12203
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FAC RID: 12204
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002FAD RID: 12205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002FAE RID: 12206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FAF RID: 12207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
