using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001BE RID: 446
	public class SwingyDoor : MessageReceiver
	{
		// Token: 0x0600311F RID: 12575 RVA: 0x000BB8A4 File Offset: 0x000B9AA4
		// Note: this type is marked as 'beforefieldinit'.
		static SwingyDoor()
		{
			Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SwingyDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr);
			SwingyDoor.NativeFieldInfoPtr_swinging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "swinging");
			SwingyDoor.NativeFieldInfoPtr_swung = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "swung");
			SwingyDoor.NativeFieldInfoPtr_openAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "openAng");
			SwingyDoor.NativeFieldInfoPtr_arr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "arr");
			SwingyDoor.NativeFieldInfoPtr_pt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "pt");
			SwingyDoor.NativeFieldInfoPtr_dust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "dust");
			SwingyDoor.NativeFieldInfoPtr_obstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "obstacle");
			SwingyDoor.NativeFieldInfoPtr_swingClockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "swingClockwise");
			SwingyDoor.NativeFieldInfoPtr_pushOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "pushOver");
			SwingyDoor.NativeFieldInfoPtr_containerDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "containerDoor");
			SwingyDoor.NativeFieldInfoPtr_defAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "defAng");
			SwingyDoor.NativeFieldInfoPtr_startRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "startRan");
			SwingyDoor.NativeFieldInfoPtr_obstLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "obstLayer");
			SwingyDoor.NativeFieldInfoPtr_defLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "defLayer");
			SwingyDoor.NativeFieldInfoPtr_defClockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "defClockwise");
			SwingyDoor.NativeFieldInfoPtr_currentLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, "currentLayer");
			SwingyDoor.NativeMethodInfoPtr_MyStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, 100667148);
			SwingyDoor.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, 100667149);
			SwingyDoor.NativeMethodInfoPtr_MyFixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, 100667150);
			SwingyDoor.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, 100667151);
			SwingyDoor.NativeMethodInfoPtr_ResetPos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, 100667152);
			SwingyDoor.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, 100667153);
			SwingyDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr, 100667154);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x000BBAA0 File Offset: 0x000B9CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84985, RefRangeEnd = 84986, XrefRangeStart = 84927, XrefRangeEnd = 84985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingyDoor.NativeMethodInfoPtr_MyStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000BBAD4 File Offset: 0x000B9CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84986, XrefRangeEnd = 85003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingyDoor.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x000BBB08 File Offset: 0x000B9D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85003, XrefRangeEnd = 85093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingyDoor.NativeMethodInfoPtr_MyFixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x000BBB3C File Offset: 0x000B9D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85093, XrefRangeEnd = 85124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPushed(Vector2 pushVect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pushVect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SwingyDoor.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x000BBB88 File Offset: 0x000B9D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85127, RefRangeEnd = 85128, XrefRangeStart = 85124, XrefRangeEnd = 85127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingyDoor.NativeMethodInfoPtr_ResetPos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x000BBBBC File Offset: 0x000B9DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85128, XrefRangeEnd = 85191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingyDoor.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x000BBBF0 File Offset: 0x000B9DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85191, XrefRangeEnd = 85197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwingyDoor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwingyDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingyDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x00021B10 File Offset: 0x0001FD10
		public SwingyDoor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x000BBC2C File Offset: 0x000B9E2C
		// (set) Token: 0x06003129 RID: 12585 RVA: 0x00021B19 File Offset: 0x0001FD19
		public unsafe bool swinging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_swinging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_swinging)) = value;
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x000BBC54 File Offset: 0x000B9E54
		// (set) Token: 0x0600312B RID: 12587 RVA: 0x00021B34 File Offset: 0x0001FD34
		public unsafe bool swung
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_swung);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_swung)) = value;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x000BBC7C File Offset: 0x000B9E7C
		// (set) Token: 0x0600312D RID: 12589 RVA: 0x00021B4F File Offset: 0x0001FD4F
		public unsafe float openAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_openAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_openAng)) = value;
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x000BBCA4 File Offset: 0x000B9EA4
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x00021B6A File Offset: 0x0001FD6A
		public unsafe Il2CppReferenceArray<Collider2D> arr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_arr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_arr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x000BBCD4 File Offset: 0x000B9ED4
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x00021B89 File Offset: 0x0001FD89
		public unsafe Vector2 pt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_pt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_pt)) = value;
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x000BBCFC File Offset: 0x000B9EFC
		// (set) Token: 0x06003133 RID: 12595 RVA: 0x00021BA4 File Offset: 0x0001FDA4
		public unsafe ParticleSystem dust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_dust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_dust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06003134 RID: 12596 RVA: 0x000BBD2C File Offset: 0x000B9F2C
		// (set) Token: 0x06003135 RID: 12597 RVA: 0x00021BC3 File Offset: 0x0001FDC3
		public unsafe Obstacle obstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_obstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Obstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_obstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x000BBD5C File Offset: 0x000B9F5C
		// (set) Token: 0x06003137 RID: 12599 RVA: 0x00021BE2 File Offset: 0x0001FDE2
		public unsafe bool swingClockwise
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_swingClockwise);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_swingClockwise)) = value;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06003138 RID: 12600 RVA: 0x000BBD84 File Offset: 0x000B9F84
		// (set) Token: 0x06003139 RID: 12601 RVA: 0x00021BFD File Offset: 0x0001FDFD
		public unsafe bool pushOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_pushOver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_pushOver)) = value;
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x0600313A RID: 12602 RVA: 0x000BBDAC File Offset: 0x000B9FAC
		// (set) Token: 0x0600313B RID: 12603 RVA: 0x00021C18 File Offset: 0x0001FE18
		public unsafe bool containerDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_containerDoor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_containerDoor)) = value;
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x0600313C RID: 12604 RVA: 0x000BBDD4 File Offset: 0x000B9FD4
		// (set) Token: 0x0600313D RID: 12605 RVA: 0x00021C33 File Offset: 0x0001FE33
		public unsafe float defAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_defAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_defAng)) = value;
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x000BBDFC File Offset: 0x000B9FFC
		// (set) Token: 0x0600313F RID: 12607 RVA: 0x00021C4E File Offset: 0x0001FE4E
		public unsafe bool startRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_startRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_startRan)) = value;
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06003140 RID: 12608 RVA: 0x000BBE24 File Offset: 0x000BA024
		// (set) Token: 0x06003141 RID: 12609 RVA: 0x00021C69 File Offset: 0x0001FE69
		public unsafe int obstLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_obstLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_obstLayer)) = value;
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06003142 RID: 12610 RVA: 0x000BBE4C File Offset: 0x000BA04C
		// (set) Token: 0x06003143 RID: 12611 RVA: 0x00021C84 File Offset: 0x0001FE84
		public unsafe int defLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_defLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_defLayer)) = value;
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x000BBE74 File Offset: 0x000BA074
		// (set) Token: 0x06003145 RID: 12613 RVA: 0x00021C9F File Offset: 0x0001FE9F
		public unsafe bool defClockwise
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_defClockwise);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_defClockwise)) = value;
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06003146 RID: 12614 RVA: 0x000BBE9C File Offset: 0x000BA09C
		// (set) Token: 0x06003147 RID: 12615 RVA: 0x00021CBA File Offset: 0x0001FEBA
		public unsafe int currentLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_currentLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingyDoor.NativeFieldInfoPtr_currentLayer)) = value;
			}
		}

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeFieldInfoPtr_swinging;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeFieldInfoPtr_swung;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeFieldInfoPtr_openAng;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeFieldInfoPtr_arr;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeFieldInfoPtr_pt;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeFieldInfoPtr_dust;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeFieldInfoPtr_obstacle;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeFieldInfoPtr_swingClockwise;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeFieldInfoPtr_pushOver;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeFieldInfoPtr_containerDoor;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeFieldInfoPtr_defAng;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeFieldInfoPtr_startRan;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeFieldInfoPtr_obstLayer;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeFieldInfoPtr_defLayer;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeFieldInfoPtr_defClockwise;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeFieldInfoPtr_currentLayer;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeMethodInfoPtr_MyStart_Private_Void_0;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Private_Void_0;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeMethodInfoPtr_ResetPos_Public_Void_0;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
