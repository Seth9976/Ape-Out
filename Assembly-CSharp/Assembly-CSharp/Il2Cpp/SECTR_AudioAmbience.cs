using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000033 RID: 51
	[Serializable]
	public class SECTR_AudioAmbience : global::Il2CppSystem.Object
	{
		// Token: 0x0600087E RID: 2174 RVA: 0x0004CD80 File Offset: 0x0004AF80
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_AudioAmbience()
		{
			Il2CppClassPointerStore<SECTR_AudioAmbience>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_AudioAmbience");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_AudioAmbience>.NativeClassPtr);
			SECTR_AudioAmbience.NativeFieldInfoPtr_BackgroundLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioAmbience>.NativeClassPtr, "BackgroundLoop");
			SECTR_AudioAmbience.NativeFieldInfoPtr_OneShots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioAmbience>.NativeClassPtr, "OneShots");
			SECTR_AudioAmbience.NativeFieldInfoPtr_OneShotInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioAmbience>.NativeClassPtr, "OneShotInterval");
			SECTR_AudioAmbience.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioAmbience>.NativeClassPtr, "Volume");
			SECTR_AudioAmbience.NativeFieldInfoPtr_UseOneShotCuesProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioAmbience>.NativeClassPtr, "UseOneShotCuesProbability");
			SECTR_AudioAmbience.NativeFieldInfoPtr_TotalProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioAmbience>.NativeClassPtr, "TotalProbability");
			SECTR_AudioAmbience.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioAmbience>.NativeClassPtr, 100663911);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0004CE3C File Offset: 0x0004B03C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36996, RefRangeEnd = 36999, XrefRangeStart = 36990, XrefRangeEnd = 36996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioAmbience()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioAmbience>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioAmbience.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000079F7 File Offset: 0x00005BF7
		public SECTR_AudioAmbience(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x0004CE78 File Offset: 0x0004B078
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00007A00 File Offset: 0x00005C00
		public unsafe SECTR_AudioCue BackgroundLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_BackgroundLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_BackgroundLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0004CEA8 File Offset: 0x0004B0A8
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00007A1F File Offset: 0x00005C1F
		public unsafe List<SECTR_AudioCue> OneShots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_OneShots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_AudioCue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_OneShots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0004CED8 File Offset: 0x0004B0D8
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x00007A3E File Offset: 0x00005C3E
		public unsafe Vector2 OneShotInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_OneShotInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_OneShotInterval)) = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x0004CF00 File Offset: 0x0004B100
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x00007A59 File Offset: 0x00005C59
		public unsafe float Volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_Volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_Volume)) = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x0004CF28 File Offset: 0x0004B128
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x00007A74 File Offset: 0x00005C74
		public unsafe bool UseOneShotCuesProbability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_UseOneShotCuesProbability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_UseOneShotCuesProbability)) = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0004CF50 File Offset: 0x0004B150
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00007A8F File Offset: 0x00005C8F
		public unsafe float TotalProbability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_TotalProbability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioAmbience.NativeFieldInfoPtr_TotalProbability)) = value;
			}
		}

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeFieldInfoPtr_BackgroundLoop;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeFieldInfoPtr_OneShots;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeFieldInfoPtr_OneShotInterval;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeFieldInfoPtr_Volume;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeFieldInfoPtr_UseOneShotCuesProbability;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeFieldInfoPtr_TotalProbability;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
