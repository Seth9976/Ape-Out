using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000B7 RID: 183
	public class Door : MonoBehaviour
	{
		// Token: 0x06001615 RID: 5653 RVA: 0x0007297C File Offset: 0x00070B7C
		// Note: this type is marked as 'beforefieldinit'.
		static Door()
		{
			Il2CppClassPointerStore<Door>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Door");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Door>.NativeClassPtr);
			Door.NativeFieldInfoPtr_openSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "openSpeed");
			Door.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "open");
			Door.NativeFieldInfoPtr_openScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "openScale");
			Door.NativeFieldInfoPtr_subDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "subDoor");
			Door.NativeFieldInfoPtr_subDoorTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "subDoorTrans");
			Door.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "trigger");
			Door.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "colliders");
			Door.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "startFlag");
			Door.NativeFieldInfoPtr_tim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "tim");
			Door.NativeFieldInfoPtr_caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "caps");
			Door.NativeFieldInfoPtr_subSprs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "subSprs");
			Door.NativeFieldInfoPtr_defLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "defLayer");
			Door.NativeFieldInfoPtr_overhangDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "overhangDoor");
			Door.NativeFieldInfoPtr_sr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "sr");
			Door.NativeFieldInfoPtr_rendBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "rendBounds");
			Door.NativeFieldInfoPtr_openingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "openingSound");
			Door.NativeFieldInfoPtr_closingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "closingSound");
			Door.NativeFieldInfoPtr_dontMoveTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "dontMoveTrigger");
			Door.NativeFieldInfoPtr_startRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "startRan");
			Door.NativeFieldInfoPtr_myPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "myPos");
			Door.NativeFieldInfoPtr_defLayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "defLayerId");
			Door.NativeFieldInfoPtr_ignoreId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "ignoreId");
			Door.NativeFieldInfoPtr_collidersOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, "collidersOn");
			Door.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Door>.NativeClassPtr, 100665154);
			Door.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Door>.NativeClassPtr, 100665155);
			Door.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Door>.NativeClassPtr, 100665156);
			Door.NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Door>.NativeClassPtr, 100665157);
			Door.NativeMethodInfoPtr_CastYourself_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Door>.NativeClassPtr, 100665158);
			Door.NativeMethodInfoPtr_PlaceMe_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Door>.NativeClassPtr, 100665159);
			Door.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Door>.NativeClassPtr, 100665160);
			Door.NativeMethodInfoPtr_ResetOpen_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Door>.NativeClassPtr, 100665161);
			Door.NativeMethodInfoPtr_OnTrigStay2D_Public_Virtual_New_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Door>.NativeClassPtr, 100665162);
			Door.NativeMethodInfoPtr_SetTriggerSize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Door>.NativeClassPtr, 100665163);
			Door.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Door>.NativeClassPtr, 100665164);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00072C54 File Offset: 0x00070E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 55010, RefRangeEnd = 55012, XrefRangeStart = 54953, XrefRangeEnd = 55010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Door.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00072C90 File Offset: 0x00070E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55012, XrefRangeEnd = 55045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Door.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00072CC4 File Offset: 0x00070EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55045, XrefRangeEnd = 55080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Door.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00072CF8 File Offset: 0x00070EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55080, XrefRangeEnd = 55098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Door.NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00072D34 File Offset: 0x00070F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55098, XrefRangeEnd = 55217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CastYourself()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Door.NativeMethodInfoPtr_CastYourself_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00072D70 File Offset: 0x00070F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55290, RefRangeEnd = 55291, XrefRangeStart = 55217, XrefRangeEnd = 55290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Door.NativeMethodInfoPtr_PlaceMe_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00072DA4 File Offset: 0x00070FA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 55503, RefRangeEnd = 55505, XrefRangeStart = 55291, XrefRangeEnd = 55503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Door.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00072DE0 File Offset: 0x00070FE0
		[CallerCount(0)]
		public unsafe virtual void ResetOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Door.NativeMethodInfoPtr_ResetOpen_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00072E1C File Offset: 0x0007101C
		[CallerCount(0)]
		public unsafe virtual void OnTrigStay2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Door.NativeMethodInfoPtr_OnTrigStay2D_Public_Virtual_New_Void_Collider2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00072E6C File Offset: 0x0007106C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55505, XrefRangeEnd = 55529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetTriggerSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Door.NativeMethodInfoPtr_SetTriggerSize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00072EA8 File Offset: 0x000710A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Door()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Door>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Door.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0000FF9F File Offset: 0x0000E19F
		public Door(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x00072EE4 File Offset: 0x000710E4
		// (set) Token: 0x06001623 RID: 5667 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		public unsafe float openSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_openSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_openSpeed)) = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x00072F0C File Offset: 0x0007110C
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x0000FFC3 File Offset: 0x0000E1C3
		public unsafe bool open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_open)) = value;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00072F34 File Offset: 0x00071134
		// (set) Token: 0x06001627 RID: 5671 RVA: 0x0000FFDE File Offset: 0x0000E1DE
		public unsafe float openScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_openScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_openScale)) = value;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x00072F5C File Offset: 0x0007115C
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x0000FFF9 File Offset: 0x0000E1F9
		public unsafe GameObject subDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_subDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_subDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00072F8C File Offset: 0x0007118C
		// (set) Token: 0x0600162B RID: 5675 RVA: 0x00010018 File Offset: 0x0000E218
		public unsafe Transform subDoorTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_subDoorTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_subDoorTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00072FBC File Offset: 0x000711BC
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x00010037 File Offset: 0x0000E237
		public unsafe CircleCollider2D trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x00072FEC File Offset: 0x000711EC
		// (set) Token: 0x0600162F RID: 5679 RVA: 0x00010056 File Offset: 0x0000E256
		public unsafe Il2CppReferenceArray<BoxCollider2D> colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x0007301C File Offset: 0x0007121C
		// (set) Token: 0x06001631 RID: 5681 RVA: 0x00010075 File Offset: 0x0000E275
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x00073044 File Offset: 0x00071244
		// (set) Token: 0x06001633 RID: 5683 RVA: 0x00010090 File Offset: 0x0000E290
		public unsafe int tim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_tim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_tim)) = value;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x0007306C File Offset: 0x0007126C
		// (set) Token: 0x06001635 RID: 5685 RVA: 0x000100AB File Offset: 0x0000E2AB
		public unsafe Il2CppReferenceArray<GameObject> caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x0007309C File Offset: 0x0007129C
		// (set) Token: 0x06001637 RID: 5687 RVA: 0x000100CA File Offset: 0x0000E2CA
		public unsafe Il2CppReferenceArray<GameObject> subSprs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_subSprs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_subSprs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x000730CC File Offset: 0x000712CC
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x000100E9 File Offset: 0x0000E2E9
		public unsafe string defLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_defLayer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_defLayer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x000730F4 File Offset: 0x000712F4
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x00010108 File Offset: 0x0000E308
		public unsafe bool overhangDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_overhangDoor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_overhangDoor)) = value;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x0007311C File Offset: 0x0007131C
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x00010123 File Offset: 0x0000E323
		public unsafe SpriteRenderer sr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_sr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_sr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x0007314C File Offset: 0x0007134C
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x00010142 File Offset: 0x0000E342
		public unsafe Vector3 rendBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_rendBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_rendBounds)) = value;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x00073174 File Offset: 0x00071374
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x0001015D File Offset: 0x0000E35D
		public unsafe bool openingSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_openingSound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_openingSound)) = value;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x0007319C File Offset: 0x0007139C
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x00010178 File Offset: 0x0000E378
		public unsafe bool closingSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_closingSound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_closingSound)) = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x000731C4 File Offset: 0x000713C4
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x00010193 File Offset: 0x0000E393
		public unsafe bool dontMoveTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_dontMoveTrigger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_dontMoveTrigger)) = value;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x000731EC File Offset: 0x000713EC
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x000101AE File Offset: 0x0000E3AE
		public unsafe bool startRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_startRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_startRan)) = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00073214 File Offset: 0x00071414
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x000101C9 File Offset: 0x0000E3C9
		public unsafe Vector3 myPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_myPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_myPos)) = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x0007323C File Offset: 0x0007143C
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x000101E4 File Offset: 0x0000E3E4
		public unsafe int defLayerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_defLayerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_defLayerId)) = value;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x00073264 File Offset: 0x00071464
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x000101FF File Offset: 0x0000E3FF
		public unsafe int ignoreId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_ignoreId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_ignoreId)) = value;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x0007328C File Offset: 0x0007148C
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x0001021A File Offset: 0x0000E41A
		public unsafe bool collidersOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_collidersOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Door.NativeFieldInfoPtr_collidersOn)) = value;
			}
		}

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeFieldInfoPtr_openSpeed;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeFieldInfoPtr_open;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeFieldInfoPtr_openScale;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeFieldInfoPtr_subDoor;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeFieldInfoPtr_subDoorTrans;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeFieldInfoPtr_trigger;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeFieldInfoPtr_colliders;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeFieldInfoPtr_tim;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeFieldInfoPtr_caps;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeFieldInfoPtr_subSprs;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeFieldInfoPtr_defLayer;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeFieldInfoPtr_overhangDoor;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeFieldInfoPtr_sr;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeFieldInfoPtr_rendBounds;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeFieldInfoPtr_openingSound;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeFieldInfoPtr_closingSound;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeFieldInfoPtr_dontMoveTrigger;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeFieldInfoPtr_startRan;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeFieldInfoPtr_myPos;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeFieldInfoPtr_defLayerId;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeFieldInfoPtr_ignoreId;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeFieldInfoPtr_collidersOn;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_CastYourself_Public_Virtual_New_Void_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_PlaceMe_Public_Void_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_ResetOpen_Public_Virtual_New_Void_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_OnTrigStay2D_Public_Virtual_New_Void_Collider2D_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_SetTriggerSize_Public_Virtual_New_Void_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
