using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000028 RID: 40
	public class GuardAudioStateTiming : ScriptableObject
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x00043524 File Offset: 0x00041724
		// Note: this type is marked as 'beforefieldinit'.
		static GuardAudioStateTiming()
		{
			Il2CppClassPointerStore<GuardAudioStateTiming>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardAudioStateTiming");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardAudioStateTiming>.NativeClassPtr);
			GuardAudioStateTiming.NativeFieldInfoPtr_NormalBreathingStartPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioStateTiming>.NativeClassPtr, "NormalBreathingStartPoints");
			GuardAudioStateTiming.NativeFieldInfoPtr_StressedBreathingStartPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioStateTiming>.NativeClassPtr, "StressedBreathingStartPoints");
			GuardAudioStateTiming.NativeFieldInfoPtr_StrugglingStartPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioStateTiming>.NativeClassPtr, "StrugglingStartPoints");
			GuardAudioStateTiming.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioStateTiming>.NativeClassPtr, 100663734);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000435A4 File Offset: 0x000417A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35176, XrefRangeEnd = 35188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardAudioStateTiming()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardAudioStateTiming>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioStateTiming.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00004EFD File Offset: 0x000030FD
		public GuardAudioStateTiming(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x000435E0 File Offset: 0x000417E0
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00004F06 File Offset: 0x00003106
		public unsafe List<float> NormalBreathingStartPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioStateTiming.NativeFieldInfoPtr_NormalBreathingStartPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioStateTiming.NativeFieldInfoPtr_NormalBreathingStartPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00043610 File Offset: 0x00041810
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00004F25 File Offset: 0x00003125
		public unsafe List<float> StressedBreathingStartPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioStateTiming.NativeFieldInfoPtr_StressedBreathingStartPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioStateTiming.NativeFieldInfoPtr_StressedBreathingStartPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00043640 File Offset: 0x00041840
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00004F44 File Offset: 0x00003144
		public unsafe List<float> StrugglingStartPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioStateTiming.NativeFieldInfoPtr_StrugglingStartPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioStateTiming.NativeFieldInfoPtr_StrugglingStartPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_NormalBreathingStartPoints;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_StressedBreathingStartPoints;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr_StrugglingStartPoints;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
