using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppRewired.Demos
{
	// Token: 0x0200020E RID: 526
	public class TouchJoystickExample : MonoBehaviour
	{
		// Token: 0x0600404E RID: 16462 RVA: 0x000F07C4 File Offset: 0x000EE9C4
		// Note: this type is marked as 'beforefieldinit'.
		static TouchJoystickExample()
		{
			Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "TouchJoystickExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr);
			TouchJoystickExample.NativeFieldInfoPtr_allowMouseControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "allowMouseControl");
			TouchJoystickExample.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "radius");
			TouchJoystickExample.NativeFieldInfoPtr_origAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "origAnchoredPosition");
			TouchJoystickExample.NativeFieldInfoPtr_origWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "origWorldPosition");
			TouchJoystickExample.NativeFieldInfoPtr_origScreenResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "origScreenResolution");
			TouchJoystickExample.NativeFieldInfoPtr_origScreenOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "origScreenOrientation");
			TouchJoystickExample.NativeFieldInfoPtr_hasFinger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "hasFinger");
			TouchJoystickExample.NativeFieldInfoPtr_lastFingerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "lastFingerId");
			TouchJoystickExample.NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "<position>k__BackingField");
			TouchJoystickExample.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669573);
			TouchJoystickExample.NativeMethodInfoPtr_set_position_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669574);
			TouchJoystickExample.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669575);
			TouchJoystickExample.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669576);
			TouchJoystickExample.NativeMethodInfoPtr_Restart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669577);
			TouchJoystickExample.NativeMethodInfoPtr_StoreOrigValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669578);
			TouchJoystickExample.NativeMethodInfoPtr_UpdateValue_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669579);
			TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669580);
			TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669581);
			TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669582);
			TouchJoystickExample.NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669583);
			TouchJoystickExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100669584);
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x0600404F RID: 16463 RVA: 0x000F0998 File Offset: 0x000EEB98
		// (set) Token: 0x06004050 RID: 16464 RVA: 0x000F09D4 File Offset: 0x000EEBD4
		public unsafe Vector2 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_set_position_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x000F0A14 File Offset: 0x000EEC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103327, XrefRangeEnd = 103332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x000F0A48 File Offset: 0x000EEC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103332, XrefRangeEnd = 103340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x000F0A7C File Offset: 0x000EEC7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103348, RefRangeEnd = 103350, XrefRangeStart = 103340, XrefRangeEnd = 103348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Restart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_Restart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x000F0AB0 File Offset: 0x000EECB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103366, RefRangeEnd = 103368, XrefRangeStart = 103350, XrefRangeEnd = 103366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreOrigValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_StoreOrigValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x000F0AE4 File Offset: 0x000EECE4
		[CallerCount(0)]
		public unsafe void UpdateValue(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_UpdateValue_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x000F0B24 File Offset: 0x000EED24
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x000F0B68 File Offset: 0x000EED68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103368, XrefRangeEnd = 103369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x000F0BAC File Offset: 0x000EEDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103369, XrefRangeEnd = 103374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_EventSystems_IDragHandler_OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x000F0BF0 File Offset: 0x000EEDF0
		[CallerCount(0)]
		public unsafe static bool IsMousePointerId(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x000F0C30 File Offset: 0x000EEE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103374, XrefRangeEnd = 103377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchJoystickExample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x00027583 File Offset: 0x00025783
		public TouchJoystickExample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x0600405C RID: 16476 RVA: 0x000F0C6C File Offset: 0x000EEE6C
		// (set) Token: 0x0600405D RID: 16477 RVA: 0x0002758C File Offset: 0x0002578C
		public unsafe bool allowMouseControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_allowMouseControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_allowMouseControl)) = value;
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x0600405E RID: 16478 RVA: 0x000F0C94 File Offset: 0x000EEE94
		// (set) Token: 0x0600405F RID: 16479 RVA: 0x000275A7 File Offset: 0x000257A7
		public unsafe int radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_radius)) = value;
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x000F0CBC File Offset: 0x000EEEBC
		// (set) Token: 0x06004061 RID: 16481 RVA: 0x000275C2 File Offset: 0x000257C2
		public unsafe Vector2 origAnchoredPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origAnchoredPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origAnchoredPosition)) = value;
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x000F0CE4 File Offset: 0x000EEEE4
		// (set) Token: 0x06004063 RID: 16483 RVA: 0x000275DD File Offset: 0x000257DD
		public unsafe Vector3 origWorldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origWorldPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origWorldPosition)) = value;
			}
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06004064 RID: 16484 RVA: 0x000F0D0C File Offset: 0x000EEF0C
		// (set) Token: 0x06004065 RID: 16485 RVA: 0x000275F8 File Offset: 0x000257F8
		public unsafe Vector2 origScreenResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origScreenResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origScreenResolution)) = value;
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x000F0D34 File Offset: 0x000EEF34
		// (set) Token: 0x06004067 RID: 16487 RVA: 0x00027613 File Offset: 0x00025813
		public unsafe ScreenOrientation origScreenOrientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origScreenOrientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origScreenOrientation)) = value;
			}
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x000F0D5C File Offset: 0x000EEF5C
		// (set) Token: 0x06004069 RID: 16489 RVA: 0x0002762E File Offset: 0x0002582E
		public unsafe bool hasFinger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_hasFinger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_hasFinger)) = value;
			}
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x0600406A RID: 16490 RVA: 0x000F0D84 File Offset: 0x000EEF84
		// (set) Token: 0x0600406B RID: 16491 RVA: 0x00027649 File Offset: 0x00025849
		public unsafe int lastFingerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_lastFingerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_lastFingerId)) = value;
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x000F0DAC File Offset: 0x000EEFAC
		// (set) Token: 0x0600406D RID: 16493 RVA: 0x00027664 File Offset: 0x00025864
		public unsafe Vector2 _position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr__position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr__position_k__BackingField)) = value;
			}
		}

		// Token: 0x0400277D RID: 10109
		private static readonly IntPtr NativeFieldInfoPtr_allowMouseControl;

		// Token: 0x0400277E RID: 10110
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x0400277F RID: 10111
		private static readonly IntPtr NativeFieldInfoPtr_origAnchoredPosition;

		// Token: 0x04002780 RID: 10112
		private static readonly IntPtr NativeFieldInfoPtr_origWorldPosition;

		// Token: 0x04002781 RID: 10113
		private static readonly IntPtr NativeFieldInfoPtr_origScreenResolution;

		// Token: 0x04002782 RID: 10114
		private static readonly IntPtr NativeFieldInfoPtr_origScreenOrientation;

		// Token: 0x04002783 RID: 10115
		private static readonly IntPtr NativeFieldInfoPtr_hasFinger;

		// Token: 0x04002784 RID: 10116
		private static readonly IntPtr NativeFieldInfoPtr_lastFingerId;

		// Token: 0x04002785 RID: 10117
		private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;

		// Token: 0x04002786 RID: 10118
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

		// Token: 0x04002787 RID: 10119
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Private_set_Void_Vector2_0;

		// Token: 0x04002788 RID: 10120
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002789 RID: 10121
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400278A RID: 10122
		private static readonly IntPtr NativeMethodInfoPtr_Restart_Private_Void_0;

		// Token: 0x0400278B RID: 10123
		private static readonly IntPtr NativeMethodInfoPtr_StoreOrigValues_Private_Void_0;

		// Token: 0x0400278C RID: 10124
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Private_Void_Vector3_0;

		// Token: 0x0400278D RID: 10125
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400278E RID: 10126
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400278F RID: 10127
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04002790 RID: 10128
		private static readonly IntPtr NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0;

		// Token: 0x04002791 RID: 10129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
