using System;
using Il2CppDG.Tweening;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2Cpp
{
	// Token: 0x02000007 RID: 7
	public class DrumReverbController : MonoBehaviour
	{
		// Token: 0x0600005A RID: 90 RVA: 0x000355F0 File Offset: 0x000337F0
		// Note: this type is marked as 'beforefieldinit'.
		static DrumReverbController()
		{
			Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DrumReverbController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr);
			DrumReverbController.NativeFieldInfoPtr_MasterMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "MasterMixer");
			DrumReverbController.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "me");
			DrumReverbController.NativeFieldInfoPtr_DryLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "DryLevel");
			DrumReverbController.NativeFieldInfoPtr_Room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "Room");
			DrumReverbController.NativeFieldInfoPtr_RoomHF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "RoomHF");
			DrumReverbController.NativeFieldInfoPtr_DecayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "DecayTime");
			DrumReverbController.NativeFieldInfoPtr_DecayHFRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "DecayHFRatio");
			DrumReverbController.NativeFieldInfoPtr_Reflections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "Reflections");
			DrumReverbController.NativeFieldInfoPtr_ReflectDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "ReflectDelay");
			DrumReverbController.NativeFieldInfoPtr_Reverb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "Reverb");
			DrumReverbController.NativeFieldInfoPtr_ReverbDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "ReverbDelay");
			DrumReverbController.NativeFieldInfoPtr_Diffusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "Diffusion");
			DrumReverbController.NativeFieldInfoPtr_Density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "Density");
			DrumReverbController.NativeFieldInfoPtr_HFReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "HFReference");
			DrumReverbController.NativeFieldInfoPtr_RoomLF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "RoomLF");
			DrumReverbController.NativeFieldInfoPtr_LFReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "LFReference");
			DrumReverbController.NativeFieldInfoPtr_presetPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, "presetPatch");
			DrumReverbController.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, 100663323);
			DrumReverbController.NativeMethodInfoPtr_SetReverbPreset_Public_Void_ReverbPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, 100663324);
			DrumReverbController.NativeMethodInfoPtr_TransitionToNewReverbPreset_Public_Void_ReverbPreset_Single_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, 100663325);
			DrumReverbController.NativeMethodInfoPtr_SetNewReverbPatch_Public_Void_ReverbPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, 100663326);
			DrumReverbController.NativeMethodInfoPtr_TransitionToNewReverbPatch_Public_Void_ReverbPatch_Single_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, 100663327);
			DrumReverbController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr, 100663328);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000357EC File Offset: 0x000339EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30383, XrefRangeEnd = 30403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrumReverbController.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00035820 File Offset: 0x00033A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30403, XrefRangeEnd = 30411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReverbPreset(DrumReverbController.ReverbPreset Preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Preset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrumReverbController.NativeMethodInfoPtr_SetReverbPreset_Public_Void_ReverbPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00035860 File Offset: 0x00033A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30411, XrefRangeEnd = 30419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransitionToNewReverbPreset(DrumReverbController.ReverbPreset Preset, float TransitionTime, Ease EaseType = Ease.OutQuad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Preset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TransitionTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref EaseType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrumReverbController.NativeMethodInfoPtr_TransitionToNewReverbPreset_Public_Void_ReverbPreset_Single_Ease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000358BC File Offset: 0x00033ABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30434, RefRangeEnd = 30436, XrefRangeStart = 30419, XrefRangeEnd = 30434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewReverbPatch(ReverbPatch NewPatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(NewPatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrumReverbController.NativeMethodInfoPtr_SetNewReverbPatch_Public_Void_ReverbPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00035900 File Offset: 0x00033B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30522, RefRangeEnd = 30523, XrefRangeStart = 30436, XrefRangeEnd = 30522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransitionToNewReverbPatch(ReverbPatch NewPatch, float TransitionTime, Ease EaseType = Ease.OutQuad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(NewPatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TransitionTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref EaseType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrumReverbController.NativeMethodInfoPtr_TransitionToNewReverbPatch_Public_Void_ReverbPatch_Single_Ease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00035960 File Offset: 0x00033B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30523, XrefRangeEnd = 30554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrumReverbController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrumReverbController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrumReverbController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000023CA File Offset: 0x000005CA
		public DrumReverbController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0003599C File Offset: 0x00033B9C
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000023D3 File Offset: 0x000005D3
		public unsafe AudioMixer MasterMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_MasterMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_MasterMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000359CC File Offset: 0x00033BCC
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000023F2 File Offset: 0x000005F2
		public unsafe static DrumReverbController me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DrumReverbController.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrumReverbController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DrumReverbController.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000359F4 File Offset: 0x00033BF4
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002404 File Offset: 0x00000604
		public unsafe string DryLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_DryLevel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_DryLevel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00035A1C File Offset: 0x00033C1C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002423 File Offset: 0x00000623
		public unsafe string Room
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_Room);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_Room), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00035A44 File Offset: 0x00033C44
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002442 File Offset: 0x00000642
		public unsafe string RoomHF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_RoomHF);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_RoomHF), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00035A6C File Offset: 0x00033C6C
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002461 File Offset: 0x00000661
		public unsafe string DecayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_DecayTime);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_DecayTime), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00035A94 File Offset: 0x00033C94
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002480 File Offset: 0x00000680
		public unsafe string DecayHFRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_DecayHFRatio);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_DecayHFRatio), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00035ABC File Offset: 0x00033CBC
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000249F File Offset: 0x0000069F
		public unsafe string Reflections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_Reflections);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_Reflections), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00035AE4 File Offset: 0x00033CE4
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000024BE File Offset: 0x000006BE
		public unsafe string ReflectDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_ReflectDelay);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_ReflectDelay), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00035B0C File Offset: 0x00033D0C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000024DD File Offset: 0x000006DD
		public unsafe string Reverb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_Reverb);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_Reverb), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00035B34 File Offset: 0x00033D34
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000024FC File Offset: 0x000006FC
		public unsafe string ReverbDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_ReverbDelay);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_ReverbDelay), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00035B5C File Offset: 0x00033D5C
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000251B File Offset: 0x0000071B
		public unsafe string Diffusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_Diffusion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_Diffusion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00035B84 File Offset: 0x00033D84
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000253A File Offset: 0x0000073A
		public unsafe string Density
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_Density);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_Density), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00035BAC File Offset: 0x00033DAC
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002559 File Offset: 0x00000759
		public unsafe string HFReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_HFReference);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_HFReference), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00035BD4 File Offset: 0x00033DD4
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002578 File Offset: 0x00000778
		public unsafe string RoomLF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_RoomLF);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_RoomLF), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00035BFC File Offset: 0x00033DFC
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002597 File Offset: 0x00000797
		public unsafe string LFReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_LFReference);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_LFReference), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00035C24 File Offset: 0x00033E24
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000025B6 File Offset: 0x000007B6
		public unsafe ReverbPatch presetPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_presetPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReverbPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrumReverbController.NativeFieldInfoPtr_presetPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_MasterMixer;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_DryLevel;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_Room;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_RoomHF;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_DecayTime;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_DecayHFRatio;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_Reflections;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_ReflectDelay;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_Reverb;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_ReverbDelay;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_Diffusion;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_Density;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_HFReference;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_RoomLF;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_LFReference;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_presetPatch;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_SetReverbPreset_Public_Void_ReverbPreset_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_TransitionToNewReverbPreset_Public_Void_ReverbPreset_Single_Ease_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_SetNewReverbPatch_Public_Void_ReverbPatch_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_TransitionToNewReverbPatch_Public_Void_ReverbPatch_Single_Ease_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000292 RID: 658
		[OriginalName("Assembly-CSharp.dll", "", "ReverbPreset")]
		public enum ReverbPreset
		{
			// Token: 0x04002FB3 RID: 12211
			Off,
			// Token: 0x04002FB4 RID: 12212
			Generic,
			// Token: 0x04002FB5 RID: 12213
			PaddedCell,
			// Token: 0x04002FB6 RID: 12214
			Room,
			// Token: 0x04002FB7 RID: 12215
			Bathroom,
			// Token: 0x04002FB8 RID: 12216
			Livingroom,
			// Token: 0x04002FB9 RID: 12217
			Stoneroom,
			// Token: 0x04002FBA RID: 12218
			Auditorium,
			// Token: 0x04002FBB RID: 12219
			Concerthall,
			// Token: 0x04002FBC RID: 12220
			Cave,
			// Token: 0x04002FBD RID: 12221
			Arena,
			// Token: 0x04002FBE RID: 12222
			Hangar,
			// Token: 0x04002FBF RID: 12223
			CarpetedHallway,
			// Token: 0x04002FC0 RID: 12224
			Hallway,
			// Token: 0x04002FC1 RID: 12225
			StoneCorridor,
			// Token: 0x04002FC2 RID: 12226
			Alley,
			// Token: 0x04002FC3 RID: 12227
			Forest,
			// Token: 0x04002FC4 RID: 12228
			City,
			// Token: 0x04002FC5 RID: 12229
			Mountains,
			// Token: 0x04002FC6 RID: 12230
			Quarry,
			// Token: 0x04002FC7 RID: 12231
			Plain,
			// Token: 0x04002FC8 RID: 12232
			ParkingLot,
			// Token: 0x04002FC9 RID: 12233
			SewerPipe,
			// Token: 0x04002FCA RID: 12234
			Underwater,
			// Token: 0x04002FCB RID: 12235
			Drugged,
			// Token: 0x04002FCC RID: 12236
			Dizzy,
			// Token: 0x04002FCD RID: 12237
			Psychotic,
			// Token: 0x04002FCE RID: 12238
			User
		}
	}
}
