using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class SamplerPatch : ScriptableObject
	{
		// Token: 0x06000210 RID: 528 RVA: 0x00039920 File Offset: 0x00037B20
		// Note: this type is marked as 'beforefieldinit'.
		static SamplerPatch()
		{
			Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SamplerPatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr);
			SamplerPatch.NativeFieldInfoPtr_roundRobinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "roundRobinCount");
			SamplerPatch.NativeFieldInfoPtr_velocityLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "velocityLevels");
			SamplerPatch.NativeFieldInfoPtr_orderedByRoundRobin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "orderedByRoundRobin");
			SamplerPatch.NativeFieldInfoPtr_OriginSampleBank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "OriginSampleBank");
			SamplerPatch.NativeFieldInfoPtr_SampleBankDrumSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "SampleBankDrumSelections");
			SamplerPatch.NativeFieldInfoPtr_SampleBankRoundRobins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "SampleBankRoundRobins");
			SamplerPatch.NativeFieldInfoPtr_SampleBankVelocityLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "SampleBankVelocityLevels");
			SamplerPatch.NativeFieldInfoPtr_SampleBankMicSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "SampleBankMicSelections");
			SamplerPatch.NativeFieldInfoPtr_Samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "Samples");
			SamplerPatch.NativeFieldInfoPtr_MetronomeClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "MetronomeClick");
			SamplerPatch.NativeFieldInfoPtr_MetronomeBell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "MetronomeBell");
			SamplerPatch.NativeFieldInfoPtr_AcousticBassDrum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "AcousticBassDrum");
			SamplerPatch.NativeFieldInfoPtr_BassDrum1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "BassDrum1");
			SamplerPatch.NativeFieldInfoPtr_SideStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "SideStick");
			SamplerPatch.NativeFieldInfoPtr_AcousticSnare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "AcousticSnare");
			SamplerPatch.NativeFieldInfoPtr_HandClap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "HandClap");
			SamplerPatch.NativeFieldInfoPtr_ElectricSnare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "ElectricSnare");
			SamplerPatch.NativeFieldInfoPtr_LowFloorTom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "LowFloorTom");
			SamplerPatch.NativeFieldInfoPtr_ClosedHiHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "ClosedHiHat");
			SamplerPatch.NativeFieldInfoPtr_FloorTom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "FloorTom");
			SamplerPatch.NativeFieldInfoPtr_PedalHiHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "PedalHiHat");
			SamplerPatch.NativeFieldInfoPtr_LowTom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "LowTom");
			SamplerPatch.NativeFieldInfoPtr_OpenHiHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "OpenHiHat");
			SamplerPatch.NativeFieldInfoPtr_LowMidTom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "LowMidTom");
			SamplerPatch.NativeFieldInfoPtr_HiMidTom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "HiMidTom");
			SamplerPatch.NativeFieldInfoPtr_CrashCymbal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "CrashCymbal1");
			SamplerPatch.NativeFieldInfoPtr_HighTom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "HighTom");
			SamplerPatch.NativeFieldInfoPtr_RideCymbal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "RideCymbal1");
			SamplerPatch.NativeFieldInfoPtr_ChineseCymbal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "ChineseCymbal");
			SamplerPatch.NativeFieldInfoPtr_RideBell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "RideBell");
			SamplerPatch.NativeFieldInfoPtr_Tambourine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "Tambourine");
			SamplerPatch.NativeFieldInfoPtr_SplashCymbal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "SplashCymbal");
			SamplerPatch.NativeFieldInfoPtr_Cowbell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "Cowbell");
			SamplerPatch.NativeFieldInfoPtr_CrashCymbal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "CrashCymbal2");
			SamplerPatch.NativeFieldInfoPtr_Vibraslap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "Vibraslap");
			SamplerPatch.NativeFieldInfoPtr_RideCymbal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "RideCymbal2");
			SamplerPatch.NativeFieldInfoPtr_HiBongo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "HiBongo");
			SamplerPatch.NativeFieldInfoPtr_LowBongo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "LowBongo");
			SamplerPatch.NativeFieldInfoPtr_MuteHiConga = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "MuteHiConga");
			SamplerPatch.NativeFieldInfoPtr_OpenHiConga = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "OpenHiConga");
			SamplerPatch.NativeFieldInfoPtr_LowConga = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "LowConga");
			SamplerPatch.NativeFieldInfoPtr_HighTimbale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "HighTimbale");
			SamplerPatch.NativeFieldInfoPtr_LowTimbale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "LowTimbale");
			SamplerPatch.NativeFieldInfoPtr_HighAgogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "HighAgogo");
			SamplerPatch.NativeFieldInfoPtr_LowAgogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "LowAgogo");
			SamplerPatch.NativeFieldInfoPtr_Cabasa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "Cabasa");
			SamplerPatch.NativeFieldInfoPtr_Maracas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "Maracas");
			SamplerPatch.NativeFieldInfoPtr_ShortWhistle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "ShortWhistle");
			SamplerPatch.NativeFieldInfoPtr_LongWhistle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "LongWhistle");
			SamplerPatch.NativeFieldInfoPtr_ShortGuiro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "ShortGuiro");
			SamplerPatch.NativeFieldInfoPtr_LongGuiro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "LongGuiro");
			SamplerPatch.NativeFieldInfoPtr_Claves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "Claves");
			SamplerPatch.NativeFieldInfoPtr_HiWoodBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "HiWoodBlock");
			SamplerPatch.NativeFieldInfoPtr_LowWoodBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "LowWoodBlock");
			SamplerPatch.NativeFieldInfoPtr_MuteCuica = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "MuteCuica");
			SamplerPatch.NativeFieldInfoPtr_OpenCuica = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "OpenCuica");
			SamplerPatch.NativeFieldInfoPtr_MuteTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "MuteTriangle");
			SamplerPatch.NativeFieldInfoPtr_OpenTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "OpenTriangle");
			SamplerPatch.NativeFieldInfoPtr_VelocityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "VelocityCurve");
			SamplerPatch.NativeFieldInfoPtr_VolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "VolumeCurve");
			SamplerPatch.NativeFieldInfoPtr_MyReverbPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, "MyReverbPatch");
			SamplerPatch.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, 100663414);
			SamplerPatch.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, 100663415);
			SamplerPatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr, 100663416);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00039E50 File Offset: 0x00038050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31970, RefRangeEnd = 31972, XrefRangeStart = 31773, XrefRangeEnd = 31970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SamplerPatch.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00039E84 File Offset: 0x00038084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31972, XrefRangeEnd = 31979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SamplerPatch.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00039EB8 File Offset: 0x000380B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31979, XrefRangeEnd = 32221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SamplerPatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SamplerPatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SamplerPatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00003817 File Offset: 0x00001A17
		public SamplerPatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00039EF4 File Offset: 0x000380F4
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00003820 File Offset: 0x00001A20
		public unsafe int roundRobinCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_roundRobinCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_roundRobinCount)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00039F1C File Offset: 0x0003811C
		// (set) Token: 0x06000218 RID: 536 RVA: 0x0000383B File Offset: 0x00001A3B
		public unsafe int velocityLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_velocityLevels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_velocityLevels)) = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00039F44 File Offset: 0x00038144
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00003856 File Offset: 0x00001A56
		public unsafe bool orderedByRoundRobin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_orderedByRoundRobin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_orderedByRoundRobin)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00039F6C File Offset: 0x0003816C
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00003871 File Offset: 0x00001A71
		public unsafe string OriginSampleBank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_OriginSampleBank);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_OriginSampleBank), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00039F94 File Offset: 0x00038194
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00003890 File Offset: 0x00001A90
		public unsafe List<int> SampleBankDrumSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SampleBankDrumSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SampleBankDrumSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00039FC4 File Offset: 0x000381C4
		// (set) Token: 0x06000220 RID: 544 RVA: 0x000038AF File Offset: 0x00001AAF
		public unsafe List<int> SampleBankRoundRobins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SampleBankRoundRobins);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SampleBankRoundRobins), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00039FF4 File Offset: 0x000381F4
		// (set) Token: 0x06000222 RID: 546 RVA: 0x000038CE File Offset: 0x00001ACE
		public unsafe List<int> SampleBankVelocityLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SampleBankVelocityLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SampleBankVelocityLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0003A024 File Offset: 0x00038224
		// (set) Token: 0x06000224 RID: 548 RVA: 0x000038ED File Offset: 0x00001AED
		public unsafe List<int> SampleBankMicSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SampleBankMicSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SampleBankMicSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0003A054 File Offset: 0x00038254
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0000390C File Offset: 0x00001B0C
		public unsafe Il2CppReferenceArray<List<AudioClip>> Samples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Samples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<AudioClip>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Samples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0003A084 File Offset: 0x00038284
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0000392B File Offset: 0x00001B2B
		public unsafe List<AudioClip> MetronomeClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MetronomeClick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MetronomeClick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0003A0B4 File Offset: 0x000382B4
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000394A File Offset: 0x00001B4A
		public unsafe List<AudioClip> MetronomeBell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MetronomeBell);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MetronomeBell), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0003A0E4 File Offset: 0x000382E4
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00003969 File Offset: 0x00001B69
		public unsafe List<AudioClip> AcousticBassDrum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_AcousticBassDrum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_AcousticBassDrum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0003A114 File Offset: 0x00038314
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00003988 File Offset: 0x00001B88
		public unsafe List<AudioClip> BassDrum1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_BassDrum1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_BassDrum1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0003A144 File Offset: 0x00038344
		// (set) Token: 0x06000230 RID: 560 RVA: 0x000039A7 File Offset: 0x00001BA7
		public unsafe List<AudioClip> SideStick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SideStick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SideStick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0003A174 File Offset: 0x00038374
		// (set) Token: 0x06000232 RID: 562 RVA: 0x000039C6 File Offset: 0x00001BC6
		public unsafe List<AudioClip> AcousticSnare
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_AcousticSnare);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_AcousticSnare), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0003A1A4 File Offset: 0x000383A4
		// (set) Token: 0x06000234 RID: 564 RVA: 0x000039E5 File Offset: 0x00001BE5
		public unsafe List<AudioClip> HandClap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HandClap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HandClap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0003A1D4 File Offset: 0x000383D4
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00003A04 File Offset: 0x00001C04
		public unsafe List<AudioClip> ElectricSnare
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_ElectricSnare);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_ElectricSnare), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0003A204 File Offset: 0x00038404
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00003A23 File Offset: 0x00001C23
		public unsafe List<AudioClip> LowFloorTom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowFloorTom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowFloorTom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0003A234 File Offset: 0x00038434
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00003A42 File Offset: 0x00001C42
		public unsafe List<AudioClip> ClosedHiHat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_ClosedHiHat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_ClosedHiHat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0003A264 File Offset: 0x00038464
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00003A61 File Offset: 0x00001C61
		public unsafe List<AudioClip> FloorTom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_FloorTom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_FloorTom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0003A294 File Offset: 0x00038494
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00003A80 File Offset: 0x00001C80
		public unsafe List<AudioClip> PedalHiHat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_PedalHiHat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_PedalHiHat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0003A2C4 File Offset: 0x000384C4
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00003A9F File Offset: 0x00001C9F
		public unsafe List<AudioClip> LowTom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowTom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowTom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0003A2F4 File Offset: 0x000384F4
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00003ABE File Offset: 0x00001CBE
		public unsafe List<AudioClip> OpenHiHat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_OpenHiHat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_OpenHiHat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0003A324 File Offset: 0x00038524
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00003ADD File Offset: 0x00001CDD
		public unsafe List<AudioClip> LowMidTom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowMidTom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowMidTom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0003A354 File Offset: 0x00038554
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00003AFC File Offset: 0x00001CFC
		public unsafe List<AudioClip> HiMidTom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HiMidTom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HiMidTom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0003A384 File Offset: 0x00038584
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00003B1B File Offset: 0x00001D1B
		public unsafe List<AudioClip> CrashCymbal1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_CrashCymbal1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_CrashCymbal1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0003A3B4 File Offset: 0x000385B4
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00003B3A File Offset: 0x00001D3A
		public unsafe List<AudioClip> HighTom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HighTom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HighTom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0003A3E4 File Offset: 0x000385E4
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00003B59 File Offset: 0x00001D59
		public unsafe List<AudioClip> RideCymbal1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_RideCymbal1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_RideCymbal1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0003A414 File Offset: 0x00038614
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00003B78 File Offset: 0x00001D78
		public unsafe List<AudioClip> ChineseCymbal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_ChineseCymbal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_ChineseCymbal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0003A444 File Offset: 0x00038644
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00003B97 File Offset: 0x00001D97
		public unsafe List<AudioClip> RideBell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_RideBell);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_RideBell), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0003A474 File Offset: 0x00038674
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00003BB6 File Offset: 0x00001DB6
		public unsafe List<AudioClip> Tambourine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Tambourine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Tambourine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0003A4A4 File Offset: 0x000386A4
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00003BD5 File Offset: 0x00001DD5
		public unsafe List<AudioClip> SplashCymbal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SplashCymbal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_SplashCymbal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0003A4D4 File Offset: 0x000386D4
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00003BF4 File Offset: 0x00001DF4
		public unsafe List<AudioClip> Cowbell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Cowbell);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Cowbell), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0003A504 File Offset: 0x00038704
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00003C13 File Offset: 0x00001E13
		public unsafe List<AudioClip> CrashCymbal2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_CrashCymbal2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_CrashCymbal2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0003A534 File Offset: 0x00038734
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00003C32 File Offset: 0x00001E32
		public unsafe List<AudioClip> Vibraslap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Vibraslap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Vibraslap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0003A564 File Offset: 0x00038764
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00003C51 File Offset: 0x00001E51
		public unsafe List<AudioClip> RideCymbal2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_RideCymbal2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_RideCymbal2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0003A594 File Offset: 0x00038794
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00003C70 File Offset: 0x00001E70
		public unsafe List<AudioClip> HiBongo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HiBongo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HiBongo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0003A5C4 File Offset: 0x000387C4
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00003C8F File Offset: 0x00001E8F
		public unsafe List<AudioClip> LowBongo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowBongo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowBongo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0003A5F4 File Offset: 0x000387F4
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00003CAE File Offset: 0x00001EAE
		public unsafe List<AudioClip> MuteHiConga
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MuteHiConga);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MuteHiConga), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0003A624 File Offset: 0x00038824
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00003CCD File Offset: 0x00001ECD
		public unsafe List<AudioClip> OpenHiConga
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_OpenHiConga);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_OpenHiConga), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0003A654 File Offset: 0x00038854
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00003CEC File Offset: 0x00001EEC
		public unsafe List<AudioClip> LowConga
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowConga);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowConga), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0003A684 File Offset: 0x00038884
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00003D0B File Offset: 0x00001F0B
		public unsafe List<AudioClip> HighTimbale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HighTimbale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HighTimbale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0003A6B4 File Offset: 0x000388B4
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00003D2A File Offset: 0x00001F2A
		public unsafe List<AudioClip> LowTimbale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowTimbale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowTimbale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0003A6E4 File Offset: 0x000388E4
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00003D49 File Offset: 0x00001F49
		public unsafe List<AudioClip> HighAgogo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HighAgogo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HighAgogo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0003A714 File Offset: 0x00038914
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00003D68 File Offset: 0x00001F68
		public unsafe List<AudioClip> LowAgogo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowAgogo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowAgogo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0003A744 File Offset: 0x00038944
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00003D87 File Offset: 0x00001F87
		public unsafe List<AudioClip> Cabasa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Cabasa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Cabasa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0003A774 File Offset: 0x00038974
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00003DA6 File Offset: 0x00001FA6
		public unsafe List<AudioClip> Maracas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Maracas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Maracas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0003A7A4 File Offset: 0x000389A4
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00003DC5 File Offset: 0x00001FC5
		public unsafe List<AudioClip> ShortWhistle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_ShortWhistle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_ShortWhistle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0003A7D4 File Offset: 0x000389D4
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00003DE4 File Offset: 0x00001FE4
		public unsafe List<AudioClip> LongWhistle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LongWhistle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LongWhistle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0003A804 File Offset: 0x00038A04
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00003E03 File Offset: 0x00002003
		public unsafe List<AudioClip> ShortGuiro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_ShortGuiro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_ShortGuiro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0003A834 File Offset: 0x00038A34
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00003E22 File Offset: 0x00002022
		public unsafe List<AudioClip> LongGuiro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LongGuiro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LongGuiro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0003A864 File Offset: 0x00038A64
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00003E41 File Offset: 0x00002041
		public unsafe List<AudioClip> Claves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Claves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_Claves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0003A894 File Offset: 0x00038A94
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00003E60 File Offset: 0x00002060
		public unsafe List<AudioClip> HiWoodBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HiWoodBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_HiWoodBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0003A8C4 File Offset: 0x00038AC4
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00003E7F File Offset: 0x0000207F
		public unsafe List<AudioClip> LowWoodBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowWoodBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_LowWoodBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0003A8F4 File Offset: 0x00038AF4
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00003E9E File Offset: 0x0000209E
		public unsafe List<AudioClip> MuteCuica
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MuteCuica);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MuteCuica), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0003A924 File Offset: 0x00038B24
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00003EBD File Offset: 0x000020BD
		public unsafe List<AudioClip> OpenCuica
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_OpenCuica);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_OpenCuica), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0003A954 File Offset: 0x00038B54
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00003EDC File Offset: 0x000020DC
		public unsafe List<AudioClip> MuteTriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MuteTriangle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MuteTriangle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0003A984 File Offset: 0x00038B84
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00003EFB File Offset: 0x000020FB
		public unsafe List<AudioClip> OpenTriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_OpenTriangle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_OpenTriangle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0003A9B4 File Offset: 0x00038BB4
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00003F1A File Offset: 0x0000211A
		public unsafe AnimationCurve VelocityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_VelocityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_VelocityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0003A9E4 File Offset: 0x00038BE4
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00003F39 File Offset: 0x00002139
		public unsafe AnimationCurve VolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_VolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_VolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0003AA14 File Offset: 0x00038C14
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00003F58 File Offset: 0x00002158
		public unsafe ReverbPatch MyReverbPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MyReverbPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReverbPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamplerPatch.NativeFieldInfoPtr_MyReverbPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_roundRobinCount;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_velocityLevels;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_orderedByRoundRobin;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr_OriginSampleBank;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr_SampleBankDrumSelections;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_SampleBankRoundRobins;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_SampleBankVelocityLevels;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeFieldInfoPtr_SampleBankMicSelections;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_Samples;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeFieldInfoPtr_MetronomeClick;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_MetronomeBell;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeFieldInfoPtr_AcousticBassDrum;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_BassDrum1;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_SideStick;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_AcousticSnare;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_HandClap;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_ElectricSnare;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_LowFloorTom;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_ClosedHiHat;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_FloorTom;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_PedalHiHat;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_LowTom;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_OpenHiHat;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_LowMidTom;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_HiMidTom;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_CrashCymbal1;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_HighTom;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_RideCymbal1;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_ChineseCymbal;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_RideBell;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_Tambourine;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_SplashCymbal;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_Cowbell;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_CrashCymbal2;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_Vibraslap;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_RideCymbal2;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_HiBongo;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_LowBongo;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_MuteHiConga;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_OpenHiConga;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_LowConga;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_HighTimbale;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_LowTimbale;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_HighAgogo;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_LowAgogo;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_Cabasa;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_Maracas;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_ShortWhistle;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_LongWhistle;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_ShortGuiro;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_LongGuiro;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_Claves;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_HiWoodBlock;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_LowWoodBlock;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_MuteCuica;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_OpenCuica;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_MuteTriangle;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_OpenTriangle;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCurve;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_VolumeCurve;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_MyReverbPatch;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
