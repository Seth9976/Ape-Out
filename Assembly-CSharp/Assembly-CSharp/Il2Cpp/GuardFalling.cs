using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000F2 RID: 242
	public class GuardFalling : GuardMode
	{
		// Token: 0x06001C9A RID: 7322 RVA: 0x00084B4C File Offset: 0x00082D4C
		// Note: this type is marked as 'beforefieldinit'.
		static GuardFalling()
		{
			Il2CppClassPointerStore<GuardFalling>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardFalling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr);
			GuardFalling.NativeFieldInfoPtr_pushSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "pushSpd");
			GuardFalling.NativeFieldInfoPtr_pushDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "pushDir");
			GuardFalling.NativeFieldInfoPtr_pushDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "pushDist");
			GuardFalling.NativeFieldInfoPtr_minPushSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "minPushSpd");
			GuardFalling.NativeFieldInfoPtr_paraAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "paraAmount");
			GuardFalling.NativeFieldInfoPtr_truePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "truePos");
			GuardFalling.NativeFieldInfoPtr_fallVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "fallVel");
			GuardFalling.NativeFieldInfoPtr_pushDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "pushDrag");
			GuardFalling.NativeFieldInfoPtr_manualDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "manualDist");
			GuardFalling.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "startPos");
			GuardFalling.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "time");
			GuardFalling.NativeFieldInfoPtr_aud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "aud");
			GuardFalling.NativeFieldInfoPtr_FallInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, "FallInstance");
			GuardFalling.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, 100665623);
			GuardFalling.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, 100665624);
			GuardFalling.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, 100665625);
			GuardFalling.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr, 100665626);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00084CD0 File Offset: 0x00082ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63455, RefRangeEnd = 63456, XrefRangeStart = 63451, XrefRangeEnd = 63455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardFalling(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardFalling>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardFalling.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00084D1C File Offset: 0x00082F1C
		[CallerCount(0)]
		public unsafe override bool ShouldAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardFalling.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00084D64 File Offset: 0x00082F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63456, XrefRangeEnd = 63497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardFalling.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00084DA0 File Offset: 0x00082FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63497, XrefRangeEnd = 63518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardFalling.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00014259 File Offset: 0x00012459
		public GuardFalling(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x00084DDC File Offset: 0x00082FDC
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x00014262 File Offset: 0x00012462
		public unsafe float pushSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_pushSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_pushSpd)) = value;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x00084E04 File Offset: 0x00083004
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x0001427D File Offset: 0x0001247D
		public unsafe Vector2 pushDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_pushDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_pushDir)) = value;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x00084E2C File Offset: 0x0008302C
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x00014298 File Offset: 0x00012498
		public unsafe float pushDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_pushDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_pushDist)) = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00084E54 File Offset: 0x00083054
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x000142B3 File Offset: 0x000124B3
		public unsafe float minPushSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_minPushSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_minPushSpd)) = value;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x00084E7C File Offset: 0x0008307C
		// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x000142CE File Offset: 0x000124CE
		public unsafe float paraAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_paraAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_paraAmount)) = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00084EA4 File Offset: 0x000830A4
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x000142E9 File Offset: 0x000124E9
		public unsafe Vector2 truePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_truePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_truePos)) = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00084ECC File Offset: 0x000830CC
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x00014304 File Offset: 0x00012504
		public unsafe float fallVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_fallVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_fallVel)) = value;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00084EF4 File Offset: 0x000830F4
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x0001431F File Offset: 0x0001251F
		public unsafe float pushDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_pushDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_pushDrag)) = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00084F1C File Offset: 0x0008311C
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x0001433A File Offset: 0x0001253A
		public unsafe float manualDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_manualDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_manualDist)) = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00084F44 File Offset: 0x00083144
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00014355 File Offset: 0x00012555
		public unsafe Vector2 startPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_startPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_startPos)) = value;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00084F6C File Offset: 0x0008316C
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x00014370 File Offset: 0x00012570
		public unsafe float time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00084F94 File Offset: 0x00083194
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x0001438B File Offset: 0x0001258B
		public unsafe Transform aud
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_aud);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_aud), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00084FC4 File Offset: 0x000831C4
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x000143AA File Offset: 0x000125AA
		public SECTR_AudioCueInstance FallInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_FallInstance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFalling.NativeFieldInfoPtr_FallInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeFieldInfoPtr_pushSpd;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeFieldInfoPtr_pushDir;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeFieldInfoPtr_pushDist;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeFieldInfoPtr_minPushSpd;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeFieldInfoPtr_paraAmount;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeFieldInfoPtr_truePos;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeFieldInfoPtr_fallVel;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeFieldInfoPtr_pushDrag;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeFieldInfoPtr_manualDist;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeFieldInfoPtr_startPos;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeFieldInfoPtr_aud;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeFieldInfoPtr_FallInstance;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
