using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000049 RID: 73
	public class SECTR_Door : MonoBehaviour
	{
		// Token: 0x06000ACF RID: 2767 RVA: 0x00054334 File Offset: 0x00052534
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_Door()
		{
			Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_Door");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr);
			SECTR_Door.NativeFieldInfoPtr_controlParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "controlParam");
			SECTR_Door.NativeFieldInfoPtr_canOpenParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "canOpenParam");
			SECTR_Door.NativeFieldInfoPtr_closedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "closedState");
			SECTR_Door.NativeFieldInfoPtr_waitingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "waitingState");
			SECTR_Door.NativeFieldInfoPtr_openingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "openingState");
			SECTR_Door.NativeFieldInfoPtr_openState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "openState");
			SECTR_Door.NativeFieldInfoPtr_closingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "closingState");
			SECTR_Door.NativeFieldInfoPtr_lastState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "lastState");
			SECTR_Door.NativeFieldInfoPtr_cachedAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "cachedAnimator");
			SECTR_Door.NativeFieldInfoPtr_openCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "openCount");
			SECTR_Door.NativeFieldInfoPtr_Portal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "Portal");
			SECTR_Door.NativeFieldInfoPtr_ControlParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "ControlParam");
			SECTR_Door.NativeFieldInfoPtr_CanOpenParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "CanOpenParam");
			SECTR_Door.NativeFieldInfoPtr_OpenState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "OpenState");
			SECTR_Door.NativeFieldInfoPtr_ClosedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "ClosedState");
			SECTR_Door.NativeFieldInfoPtr_OpeningState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "OpeningState");
			SECTR_Door.NativeFieldInfoPtr_ClosingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "ClosingState");
			SECTR_Door.NativeFieldInfoPtr_WaitingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, "WaitingState");
			SECTR_Door.NativeMethodInfoPtr_OpenDoor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, 100664203);
			SECTR_Door.NativeMethodInfoPtr_CloseDoor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, 100664204);
			SECTR_Door.NativeMethodInfoPtr_IsFullyOpen_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, 100664205);
			SECTR_Door.NativeMethodInfoPtr_IsClosed_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, 100664206);
			SECTR_Door.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, 100664207);
			SECTR_Door.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, 100664208);
			SECTR_Door.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, 100664209);
			SECTR_Door.NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, 100664210);
			SECTR_Door.NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, 100664211);
			SECTR_Door.NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, 100664212);
			SECTR_Door.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr, 100664213);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x000545A8 File Offset: 0x000527A8
		[CallerCount(0)]
		public unsafe void OpenDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Door.NativeMethodInfoPtr_OpenDoor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000545DC File Offset: 0x000527DC
		[CallerCount(0)]
		public unsafe void CloseDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Door.NativeMethodInfoPtr_CloseDoor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00054610 File Offset: 0x00052810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40587, XrefRangeEnd = 40589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFullyOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Door.NativeMethodInfoPtr_IsFullyOpen_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0005464C File Offset: 0x0005284C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40589, XrefRangeEnd = 40591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Door.NativeMethodInfoPtr_IsClosed_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00054688 File Offset: 0x00052888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40591, XrefRangeEnd = 40608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_Door.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000546C4 File Offset: 0x000528C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40608, XrefRangeEnd = 40619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Door.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x000546F8 File Offset: 0x000528F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40619, XrefRangeEnd = 40645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Door.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0005472C File Offset: 0x0005292C
		[CallerCount(0)]
		public unsafe virtual void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_Door.NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0005477C File Offset: 0x0005297C
		[CallerCount(0)]
		public unsafe virtual void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_Door.NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x000547CC File Offset: 0x000529CC
		[CallerCount(0)]
		public unsafe virtual bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_Door.NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00054814 File Offset: 0x00052A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40645, XrefRangeEnd = 40662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_Door()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_Door>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Door.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00008BD8 File Offset: 0x00006DD8
		public SECTR_Door(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00054850 File Offset: 0x00052A50
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x00008BE1 File Offset: 0x00006DE1
		public unsafe int controlParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_controlParam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_controlParam)) = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00054878 File Offset: 0x00052A78
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00008BFC File Offset: 0x00006DFC
		public unsafe int canOpenParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_canOpenParam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_canOpenParam)) = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x000548A0 File Offset: 0x00052AA0
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00008C17 File Offset: 0x00006E17
		public unsafe int closedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_closedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_closedState)) = value;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x000548C8 File Offset: 0x00052AC8
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00008C32 File Offset: 0x00006E32
		public unsafe int waitingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_waitingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_waitingState)) = value;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000548F0 File Offset: 0x00052AF0
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00008C4D File Offset: 0x00006E4D
		public unsafe int openingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_openingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_openingState)) = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00054918 File Offset: 0x00052B18
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00008C68 File Offset: 0x00006E68
		public unsafe int openState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_openState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_openState)) = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00054940 File Offset: 0x00052B40
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00008C83 File Offset: 0x00006E83
		public unsafe int closingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_closingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_closingState)) = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00054968 File Offset: 0x00052B68
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x00008C9E File Offset: 0x00006E9E
		public unsafe int lastState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_lastState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_lastState)) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00054990 File Offset: 0x00052B90
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x00008CB9 File Offset: 0x00006EB9
		public unsafe Animator cachedAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_cachedAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_cachedAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x000549C0 File Offset: 0x00052BC0
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x00008CD8 File Offset: 0x00006ED8
		public unsafe int openCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_openCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_openCount)) = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x000549E8 File Offset: 0x00052BE8
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x00008CF3 File Offset: 0x00006EF3
		public unsafe SECTR_Portal Portal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_Portal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Portal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_Portal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00054A18 File Offset: 0x00052C18
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x00008D12 File Offset: 0x00006F12
		public unsafe string ControlParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_ControlParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_ControlParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00054A40 File Offset: 0x00052C40
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x00008D31 File Offset: 0x00006F31
		public unsafe string CanOpenParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_CanOpenParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_CanOpenParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00054A68 File Offset: 0x00052C68
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00008D50 File Offset: 0x00006F50
		public unsafe string OpenState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_OpenState);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_OpenState), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00054A90 File Offset: 0x00052C90
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00008D6F File Offset: 0x00006F6F
		public unsafe string ClosedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_ClosedState);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_ClosedState), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00054AB8 File Offset: 0x00052CB8
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x00008D8E File Offset: 0x00006F8E
		public unsafe string OpeningState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_OpeningState);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_OpeningState), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00054AE0 File Offset: 0x00052CE0
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00008DAD File Offset: 0x00006FAD
		public unsafe string ClosingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_ClosingState);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_ClosingState), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x00054B08 File Offset: 0x00052D08
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x00008DCC File Offset: 0x00006FCC
		public unsafe string WaitingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_WaitingState);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Door.NativeFieldInfoPtr_WaitingState), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeFieldInfoPtr_controlParam;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeFieldInfoPtr_canOpenParam;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeFieldInfoPtr_closedState;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeFieldInfoPtr_waitingState;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeFieldInfoPtr_openingState;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeFieldInfoPtr_openState;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeFieldInfoPtr_closingState;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeFieldInfoPtr_lastState;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeFieldInfoPtr_cachedAnimator;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_openCount;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_Portal;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_ControlParam;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_CanOpenParam;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_OpenState;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_ClosedState;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeFieldInfoPtr_OpeningState;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeFieldInfoPtr_ClosingState;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeFieldInfoPtr_WaitingState;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_OpenDoor_Public_Void_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_CloseDoor_Public_Void_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_IsFullyOpen_Public_Boolean_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_IsClosed_Public_Boolean_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
