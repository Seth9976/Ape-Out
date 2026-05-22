using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000F3 RID: 243
	public class GuardFleeing : GuardMode
	{
		// Token: 0x06001CBA RID: 7354 RVA: 0x00084FF4 File Offset: 0x000831F4
		// Note: this type is marked as 'beforefieldinit'.
		static GuardFleeing()
		{
			Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardFleeing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr);
			GuardFleeing.NativeFieldInfoPtr_stat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, "stat");
			GuardFleeing.NativeFieldInfoPtr_goVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, "goVect");
			GuardFleeing.NativeFieldInfoPtr_goAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, "goAng");
			GuardFleeing.NativeFieldInfoPtr_pathin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, "pathin");
			GuardFleeing.NativeFieldInfoPtr_endPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, "endPt");
			GuardFleeing.NativeFieldInfoPtr_trgtPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, "trgtPos");
			GuardFleeing.NativeFieldInfoPtr_cowering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, "cowering");
			GuardFleeing.NativeFieldInfoPtr_prevCowering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, "prevCowering");
			GuardFleeing.NativeFieldInfoPtr_cowerLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, "cowerLoop");
			GuardFleeing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, 100665627);
			GuardFleeing.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, 100665628);
			GuardFleeing.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, 100665629);
			GuardFleeing.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, 100665630);
			GuardFleeing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, 100665631);
			GuardFleeing.NativeMethodInfoPtr_ManageSomeShit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr, 100665632);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00085150 File Offset: 0x00083350
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 63518, RefRangeEnd = 63521, XrefRangeStart = 63518, XrefRangeEnd = 63518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardFleeing(GuardState st, float mSpd, float rRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardFleeing>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mSpd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardFleeing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x000851B8 File Offset: 0x000833B8
		[CallerCount(0)]
		public unsafe override bool ShouldAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardFleeing.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00085200 File Offset: 0x00083400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63521, XrefRangeEnd = 63527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardFleeing.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0008523C File Offset: 0x0008343C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63527, XrefRangeEnd = 63532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardFleeing.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00085278 File Offset: 0x00083478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63562, RefRangeEnd = 63563, XrefRangeStart = 63532, XrefRangeEnd = 63562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardFleeing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x000852B4 File Offset: 0x000834B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63579, RefRangeEnd = 63580, XrefRangeStart = 63563, XrefRangeEnd = 63579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManageSomeShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardFleeing.NativeMethodInfoPtr_ManageSomeShit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x000143D8 File Offset: 0x000125D8
		public GuardFleeing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x000852E8 File Offset: 0x000834E8
		// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x000143E1 File Offset: 0x000125E1
		public unsafe StatusFleeing stat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_stat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatusFleeing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_stat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00085318 File Offset: 0x00083518
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00014400 File Offset: 0x00012600
		public unsafe Vector2 goVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_goVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_goVect)) = value;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x00085340 File Offset: 0x00083540
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0001441B File Offset: 0x0001261B
		public unsafe float goAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_goAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_goAng)) = value;
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x00085368 File Offset: 0x00083568
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x00014436 File Offset: 0x00012636
		public unsafe bool pathin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_pathin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_pathin)) = value;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00085390 File Offset: 0x00083590
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x00014451 File Offset: 0x00012651
		public unsafe Vector2 endPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_endPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_endPt)) = value;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x000853B8 File Offset: 0x000835B8
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x0001446C File Offset: 0x0001266C
		public unsafe Vector2 trgtPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_trgtPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_trgtPos)) = value;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x000853E0 File Offset: 0x000835E0
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x00014487 File Offset: 0x00012687
		public unsafe bool cowering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_cowering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_cowering)) = value;
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00085408 File Offset: 0x00083608
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x000144A2 File Offset: 0x000126A2
		public unsafe bool prevCowering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_prevCowering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_prevCowering)) = value;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x00085430 File Offset: 0x00083630
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x000144BD File Offset: 0x000126BD
		public SECTR_AudioCueInstance cowerLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_cowerLoop);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFleeing.NativeFieldInfoPtr_cowerLoop), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeFieldInfoPtr_stat;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeFieldInfoPtr_goVect;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeFieldInfoPtr_goAng;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeFieldInfoPtr_pathin;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeFieldInfoPtr_endPt;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeFieldInfoPtr_trgtPos;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeFieldInfoPtr_cowering;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeFieldInfoPtr_prevCowering;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeFieldInfoPtr_cowerLoop;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_ManageSomeShit_Public_Void_0;
	}
}
