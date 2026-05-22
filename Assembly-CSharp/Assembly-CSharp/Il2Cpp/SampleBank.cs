using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public class SampleBank : ScriptableObject
	{
		// Token: 0x06000204 RID: 516 RVA: 0x00039750 File Offset: 0x00037950
		// Note: this type is marked as 'beforefieldinit'.
		static SampleBank()
		{
			Il2CppClassPointerStore<SampleBank>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SampleBank");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SampleBank>.NativeClassPtr);
			SampleBank.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleBank>.NativeClassPtr, "Name");
			SampleBank.NativeFieldInfoPtr_DrumsAndArticulations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleBank>.NativeClassPtr, "DrumsAndArticulations");
			SampleBank.NativeFieldInfoPtr_Mics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleBank>.NativeClassPtr, "Mics");
			SampleBank.NativeFieldInfoPtr_DrumSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleBank>.NativeClassPtr, "DrumSamples");
			SampleBank.NativeMethodInfoPtr_InterpretSamples_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleBank>.NativeClassPtr, 100663412);
			SampleBank.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleBank>.NativeClassPtr, 100663413);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000397F8 File Offset: 0x000379F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31716, XrefRangeEnd = 31747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InterpretSamples()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleBank.NativeMethodInfoPtr_InterpretSamples_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0003982C File Offset: 0x00037A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31747, XrefRangeEnd = 31773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SampleBank()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SampleBank>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleBank.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00003792 File Offset: 0x00001992
		public SampleBank(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00039868 File Offset: 0x00037A68
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000379B File Offset: 0x0000199B
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleBank.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleBank.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00039890 File Offset: 0x00037A90
		// (set) Token: 0x0600020B RID: 523 RVA: 0x000037BA File Offset: 0x000019BA
		public unsafe List<string> DrumsAndArticulations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleBank.NativeFieldInfoPtr_DrumsAndArticulations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleBank.NativeFieldInfoPtr_DrumsAndArticulations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000398C0 File Offset: 0x00037AC0
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000037D9 File Offset: 0x000019D9
		public unsafe List<string> Mics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleBank.NativeFieldInfoPtr_Mics);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleBank.NativeFieldInfoPtr_Mics), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000398F0 File Offset: 0x00037AF0
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000037F8 File Offset: 0x000019F8
		public unsafe List<DrumSample> DrumSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleBank.NativeFieldInfoPtr_DrumSamples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DrumSample>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleBank.NativeFieldInfoPtr_DrumSamples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_DrumsAndArticulations;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_Mics;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_DrumSamples;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_InterpretSamples_Public_Void_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
