using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000065 RID: 101
	public class Alarm : MonoBehaviour
	{
		// Token: 0x06000D94 RID: 3476 RVA: 0x0005C880 File Offset: 0x0005AA80
		// Note: this type is marked as 'beforefieldinit'.
		static Alarm()
		{
			Il2CppClassPointerStore<Alarm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Alarm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Alarm>.NativeClassPtr);
			Alarm.NativeFieldInfoPtr_beams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alarm>.NativeClassPtr, "beams");
			Alarm.NativeFieldInfoPtr_blinking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alarm>.NativeClassPtr, "blinking");
			Alarm.NativeFieldInfoPtr_blinkLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alarm>.NativeClassPtr, "blinkLength");
			Alarm.NativeFieldInfoPtr_blinkGap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alarm>.NativeClassPtr, "blinkGap");
			Alarm.NativeFieldInfoPtr_beamAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alarm>.NativeClassPtr, "beamAng");
			Alarm.NativeFieldInfoPtr_blinkTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alarm>.NativeClassPtr, "blinkTimer");
			Alarm.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alarm>.NativeClassPtr, "on");
			Alarm.NativeFieldInfoPtr_spinSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alarm>.NativeClassPtr, "spinSpd");
			Alarm.NativeFieldInfoPtr_ang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alarm>.NativeClassPtr, "ang");
			Alarm.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alarm>.NativeClassPtr, 100664482);
			Alarm.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alarm>.NativeClassPtr, 100664483);
			Alarm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alarm>.NativeClassPtr, 100664484);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0005C9A0 File Offset: 0x0005ABA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44073, XrefRangeEnd = 44122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alarm.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0005C9D4 File Offset: 0x0005ABD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44122, XrefRangeEnd = 44140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alarm.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0005CA08 File Offset: 0x0005AC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44140, XrefRangeEnd = 44143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Alarm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Alarm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alarm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0000A4EF File Offset: 0x000086EF
		public Alarm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0005CA44 File Offset: 0x0005AC44
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x0000A4F8 File Offset: 0x000086F8
		public unsafe Il2CppReferenceArray<FlashLight> beams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_beams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FlashLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_beams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0005CA74 File Offset: 0x0005AC74
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x0000A517 File Offset: 0x00008717
		public unsafe bool blinking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_blinking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_blinking)) = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0005CA9C File Offset: 0x0005AC9C
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x0000A532 File Offset: 0x00008732
		public unsafe float blinkLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_blinkLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_blinkLength)) = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0005CAC4 File Offset: 0x0005ACC4
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x0000A54D File Offset: 0x0000874D
		public unsafe float blinkGap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_blinkGap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_blinkGap)) = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0005CAEC File Offset: 0x0005ACEC
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0000A568 File Offset: 0x00008768
		public unsafe float beamAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_beamAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_beamAng)) = value;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0005CB14 File Offset: 0x0005AD14
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x0000A583 File Offset: 0x00008783
		public unsafe float blinkTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_blinkTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_blinkTimer)) = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0005CB3C File Offset: 0x0005AD3C
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x0000A59E File Offset: 0x0000879E
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0005CB64 File Offset: 0x0005AD64
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x0000A5B9 File Offset: 0x000087B9
		public unsafe float spinSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_spinSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_spinSpd)) = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x0005CB8C File Offset: 0x0005AD8C
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x0000A5D4 File Offset: 0x000087D4
		public unsafe float ang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_ang);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alarm.NativeFieldInfoPtr_ang)) = value;
			}
		}

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeFieldInfoPtr_beams;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeFieldInfoPtr_blinking;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeFieldInfoPtr_blinkLength;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeFieldInfoPtr_blinkGap;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeFieldInfoPtr_beamAng;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeFieldInfoPtr_blinkTimer;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeFieldInfoPtr_spinSpd;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeFieldInfoPtr_ang;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
