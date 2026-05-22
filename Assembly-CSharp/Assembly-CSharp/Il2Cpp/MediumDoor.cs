using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200012D RID: 301
	public class MediumDoor : MonoBehaviour
	{
		// Token: 0x06002571 RID: 9585 RVA: 0x0009C440 File Offset: 0x0009A640
		// Note: this type is marked as 'beforefieldinit'.
		static MediumDoor()
		{
			Il2CppClassPointerStore<MediumDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MediumDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr);
			MediumDoor.NativeFieldInfoPtr_controlLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "controlLight");
			MediumDoor.NativeFieldInfoPtr_lightRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "lightRends");
			MediumDoor.NativeFieldInfoPtr_greenMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "greenMat");
			MediumDoor.NativeFieldInfoPtr_redMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "redMat");
			MediumDoor.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "open");
			MediumDoor.NativeFieldInfoPtr_openScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "openScale");
			MediumDoor.NativeFieldInfoPtr_prevOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "prevOpen");
			MediumDoor.NativeFieldInfoPtr_trigged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "trigged");
			MediumDoor.NativeFieldInfoPtr_closeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "closeTimer");
			MediumDoor.NativeFieldInfoPtr_opening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "opening");
			MediumDoor.NativeFieldInfoPtr_openTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "openTimer");
			MediumDoor.NativeFieldInfoPtr_opened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "opened");
			MediumDoor.NativeFieldInfoPtr_closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "closed");
			MediumDoor.NativeFieldInfoPtr_flange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "flange");
			MediumDoor.NativeFieldInfoPtr_flangeLocPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "flangeLocPos");
			MediumDoor.NativeFieldInfoPtr_lightOffTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "lightOffTimer");
			MediumDoor.NativeFieldInfoPtr_fallin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "fallin");
			MediumDoor.NativeFieldInfoPtr_fallTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "fallTimer");
			MediumDoor.NativeFieldInfoPtr_playerTrigged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "playerTrigged");
			MediumDoor.NativeFieldInfoPtr_rendBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, "rendBounds");
			MediumDoor.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, 100666265);
			MediumDoor.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, 100666266);
			MediumDoor.NativeMethodInfoPtr_OnPrePushed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, 100666267);
			MediumDoor.NativeMethodInfoPtr_OnPushed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, 100666268);
			MediumDoor.NativeMethodInfoPtr_FallDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, 100666269);
			MediumDoor.NativeMethodInfoPtr_OnTrigStay2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, 100666270);
			MediumDoor.NativeMethodInfoPtr_DealWithFlange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, 100666271);
			MediumDoor.NativeMethodInfoPtr_GetTipPos_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, 100666272);
			MediumDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr, 100666273);
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x0009C6B4 File Offset: 0x0009A8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73340, XrefRangeEnd = 73400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediumDoor.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x0009C6E8 File Offset: 0x0009A8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73400, XrefRangeEnd = 73439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediumDoor.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x0009C71C File Offset: 0x0009A91C
		[CallerCount(0)]
		public unsafe void OnPrePushed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediumDoor.NativeMethodInfoPtr_OnPrePushed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x0009C750 File Offset: 0x0009A950
		[CallerCount(0)]
		public unsafe void OnPushed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediumDoor.NativeMethodInfoPtr_OnPushed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x0009C784 File Offset: 0x0009A984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73526, RefRangeEnd = 73527, XrefRangeStart = 73439, XrefRangeEnd = 73526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FallDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediumDoor.NativeMethodInfoPtr_FallDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x0009C7B8 File Offset: 0x0009A9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73527, XrefRangeEnd = 73533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTrigStay2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediumDoor.NativeMethodInfoPtr_OnTrigStay2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x0009C7FC File Offset: 0x0009A9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73533, XrefRangeEnd = 73538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DealWithFlange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediumDoor.NativeMethodInfoPtr_DealWithFlange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x0009C830 File Offset: 0x0009AA30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 73556, RefRangeEnd = 73561, XrefRangeStart = 73538, XrefRangeEnd = 73556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTipPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediumDoor.NativeMethodInfoPtr_GetTipPos_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x0009C86C File Offset: 0x0009AA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MediumDoor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediumDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediumDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x0001A3E1 File Offset: 0x000185E1
		public MediumDoor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x0009C8A8 File Offset: 0x0009AAA8
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x0001A3EA File Offset: 0x000185EA
		public unsafe Il2CppReferenceArray<FlashLight> controlLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_controlLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FlashLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_controlLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x0009C8D8 File Offset: 0x0009AAD8
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x0001A409 File Offset: 0x00018609
		public unsafe Il2CppReferenceArray<MeshRenderer> lightRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_lightRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_lightRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x0009C908 File Offset: 0x0009AB08
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x0001A428 File Offset: 0x00018628
		public unsafe Material greenMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_greenMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_greenMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x0009C938 File Offset: 0x0009AB38
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x0001A447 File Offset: 0x00018647
		public unsafe Material redMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_redMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_redMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x0009C968 File Offset: 0x0009AB68
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x0001A466 File Offset: 0x00018666
		public unsafe bool open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_open)) = value;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x0009C990 File Offset: 0x0009AB90
		// (set) Token: 0x06002587 RID: 9607 RVA: 0x0001A481 File Offset: 0x00018681
		public unsafe float openScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_openScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_openScale)) = value;
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x0009C9B8 File Offset: 0x0009ABB8
		// (set) Token: 0x06002589 RID: 9609 RVA: 0x0001A49C File Offset: 0x0001869C
		public unsafe bool prevOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_prevOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_prevOpen)) = value;
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x0009C9E0 File Offset: 0x0009ABE0
		// (set) Token: 0x0600258B RID: 9611 RVA: 0x0001A4B7 File Offset: 0x000186B7
		public unsafe bool trigged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_trigged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_trigged)) = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x0009CA08 File Offset: 0x0009AC08
		// (set) Token: 0x0600258D RID: 9613 RVA: 0x0001A4D2 File Offset: 0x000186D2
		public unsafe int closeTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_closeTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_closeTimer)) = value;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x0009CA30 File Offset: 0x0009AC30
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x0001A4ED File Offset: 0x000186ED
		public unsafe bool opening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_opening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_opening)) = value;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x0009CA58 File Offset: 0x0009AC58
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x0001A508 File Offset: 0x00018708
		public unsafe int openTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_openTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_openTimer)) = value;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x0009CA80 File Offset: 0x0009AC80
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x0001A523 File Offset: 0x00018723
		public unsafe bool opened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_opened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_opened)) = value;
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x0009CAA8 File Offset: 0x0009ACA8
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x0001A53E File Offset: 0x0001873E
		public unsafe bool closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_closed)) = value;
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x0009CAD0 File Offset: 0x0009ACD0
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x0001A559 File Offset: 0x00018759
		public unsafe GameObject flange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_flange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_flange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x0009CB00 File Offset: 0x0009AD00
		// (set) Token: 0x06002599 RID: 9625 RVA: 0x0001A578 File Offset: 0x00018778
		public unsafe Vector2 flangeLocPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_flangeLocPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_flangeLocPos)) = value;
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x0009CB28 File Offset: 0x0009AD28
		// (set) Token: 0x0600259B RID: 9627 RVA: 0x0001A593 File Offset: 0x00018793
		public unsafe int lightOffTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_lightOffTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_lightOffTimer)) = value;
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x0009CB50 File Offset: 0x0009AD50
		// (set) Token: 0x0600259D RID: 9629 RVA: 0x0001A5AE File Offset: 0x000187AE
		public unsafe bool fallin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_fallin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_fallin)) = value;
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x0009CB78 File Offset: 0x0009AD78
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x0001A5C9 File Offset: 0x000187C9
		public unsafe int fallTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_fallTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_fallTimer)) = value;
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x0009CBA0 File Offset: 0x0009ADA0
		// (set) Token: 0x060025A1 RID: 9633 RVA: 0x0001A5E4 File Offset: 0x000187E4
		public unsafe bool playerTrigged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_playerTrigged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_playerTrigged)) = value;
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x0009CBC8 File Offset: 0x0009ADC8
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x0001A5FF File Offset: 0x000187FF
		public unsafe Vector2 rendBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_rendBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediumDoor.NativeFieldInfoPtr_rendBounds)) = value;
			}
		}

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeFieldInfoPtr_controlLight;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeFieldInfoPtr_lightRends;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeFieldInfoPtr_greenMat;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeFieldInfoPtr_redMat;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeFieldInfoPtr_open;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeFieldInfoPtr_openScale;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeFieldInfoPtr_prevOpen;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeFieldInfoPtr_trigged;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeFieldInfoPtr_closeTimer;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeFieldInfoPtr_opening;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeFieldInfoPtr_openTimer;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeFieldInfoPtr_opened;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeFieldInfoPtr_closed;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeFieldInfoPtr_flange;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeFieldInfoPtr_flangeLocPos;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeFieldInfoPtr_lightOffTimer;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeFieldInfoPtr_fallin;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeFieldInfoPtr_fallTimer;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeFieldInfoPtr_playerTrigged;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeFieldInfoPtr_rendBounds;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeMethodInfoPtr_OnPrePushed_Public_Void_0;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeMethodInfoPtr_OnPushed_Public_Void_0;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr_FallDown_Public_Void_0;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeMethodInfoPtr_OnTrigStay2D_Public_Void_Collider2D_0;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeMethodInfoPtr_DealWithFlange_Public_Void_0;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr_GetTipPos_Public_Vector3_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
