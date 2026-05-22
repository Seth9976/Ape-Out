using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000069 RID: 105
	public class PointerInputModule : BaseInputModule
	{
		// Token: 0x06000A41 RID: 2625 RVA: 0x0002E820 File Offset: 0x0002CA20
		// Note: this type is marked as 'beforefieldinit'.
		static PointerInputModule()
		{
			Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "PointerInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr);
			PointerInputModule.NativeFieldInfoPtr_kMouseLeftId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kMouseLeftId");
			PointerInputModule.NativeFieldInfoPtr_kMouseRightId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kMouseRightId");
			PointerInputModule.NativeFieldInfoPtr_kMouseMiddleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kMouseMiddleId");
			PointerInputModule.NativeFieldInfoPtr_kFakeTouchesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kFakeTouchesId");
			PointerInputModule.NativeFieldInfoPtr_m_PointerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "m_PointerData");
			PointerInputModule.NativeFieldInfoPtr_m_MouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "m_MouseState");
			PointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_byref_PointerEventData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664931);
			PointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664932);
			PointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664933);
			PointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664934);
			PointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664935);
			PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664936);
			PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664937);
			PointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PointerEventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664938);
			PointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664939);
			PointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664940);
			PointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664941);
			PointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664942);
			PointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664943);
			PointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664944);
			PointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664945);
			PointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664946);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002EA08 File Offset: 0x0002CC08
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 532057, RefRangeEnd = 532064, XrefRangeStart = 532052, XrefRangeEnd = 532057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPointerData(int id, out PointerEventData data, bool create)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref create;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_byref_PointerEventData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new PointerEventData(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002EA84 File Offset: 0x0002CC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532064, XrefRangeEnd = 532068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePointerData(PointerEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 532078, RefRangeEnd = 532081, XrefRangeStart = 532068, XrefRangeEnd = 532078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &released;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002EB30 File Offset: 0x0002CD30
		[CallerCount(0)]
		public unsafe void CopyFromTo(PointerEventData from, PointerEventData to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002EB84 File Offset: 0x0002CD84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 532083, RefRangeEnd = 532086, XrefRangeStart = 532081, XrefRangeEnd = 532083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData.FramePressState StateForMouseButton(int buttonId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0002EBD0 File Offset: 0x0002CDD0
		[CallerCount(0)]
		public unsafe virtual PointerInputModule.MouseState GetMousePointerEventData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseState>(intPtr3) : null;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0002EC1C File Offset: 0x0002CE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532086, XrefRangeEnd = 532107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PointerInputModule.MouseState GetMousePointerEventData(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseState>(intPtr3) : null;
			}
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0002EC74 File Offset: 0x0002CE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532107, XrefRangeEnd = 532108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData GetLastPointerEventData(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PointerEventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
			}
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002ECC0 File Offset: 0x0002CEC0
		[CallerCount(0)]
		public unsafe static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pressPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDragThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0002ED28 File Offset: 0x0002CF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532108, XrefRangeEnd = 532115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessMove(PointerEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0002ED78 File Offset: 0x0002CF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532115, XrefRangeEnd = 532167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessDrag(PointerEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0002EDC8 File Offset: 0x0002CFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532167, XrefRangeEnd = 532180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerOverGameObject(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0002EE1C File Offset: 0x0002D01C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 532196, RefRangeEnd = 532198, XrefRangeStart = 532180, XrefRangeEnd = 532196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0002EE50 File Offset: 0x0002D050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532198, XrefRangeEnd = 532230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0002EE94 File Offset: 0x0002D094
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 532253, RefRangeEnd = 532256, XrefRangeStart = 532230, XrefRangeEnd = 532253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentOverGo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0002EEE8 File Offset: 0x0002D0E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 532272, RefRangeEnd = 532274, XrefRangeStart = 532256, XrefRangeEnd = 532272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00005AD2 File Offset: 0x00003CD2
		public PointerInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0002EF24 File Offset: 0x0002D124
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00005ADB File Offset: 0x00003CDB
		public unsafe static int kMouseLeftId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*)(&value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0002EF40 File Offset: 0x0002D140
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00005AE9 File Offset: 0x00003CE9
		public unsafe static int kMouseRightId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*)(&value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0002EF5C File Offset: 0x0002D15C
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00005AF7 File Offset: 0x00003CF7
		public unsafe static int kMouseMiddleId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*)(&value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0002EF78 File Offset: 0x0002D178
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00005B05 File Offset: 0x00003D05
		public unsafe static int kFakeTouchesId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*)(&value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0002EF94 File Offset: 0x0002D194
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00005B13 File Offset: 0x00003D13
		public unsafe Dictionary<int, PointerEventData> m_PointerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_PointerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PointerEventData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_PointerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0002EFC4 File Offset: 0x0002D1C4
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00005B32 File Offset: 0x00003D32
		public unsafe PointerInputModule.MouseState m_MouseState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_MouseState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_MouseState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_kMouseLeftId;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_kMouseRightId;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_kMouseMiddleId;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr_kFakeTouchesId;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerData;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseState;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_byref_PointerEventData_Boolean_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_RemovePointerData_Protected_Void_PointerEventData_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_GetLastPointerEventData_Protected_PointerEventData_Int32_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Protected_Void_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000CA RID: 202
		public class ButtonState : Object
		{
			// Token: 0x06000CC1 RID: 3265 RVA: 0x00036B74 File Offset: 0x00034D74
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonState()
			{
				Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "ButtonState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr);
				PointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, "m_Button");
				PointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, "m_EventData");
				PointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100664947);
				PointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100664948);
				PointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100664949);
				PointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100664950);
				PointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100664951);
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00036C2C File Offset: 0x00034E2C
			// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00036C6C File Offset: 0x00034E6C
			public unsafe PointerInputModule.MouseButtonEventData eventData
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseButtonEventData>(intPtr3) : null;
				}
				[CallerCount(58)]
				[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00036CB0 File Offset: 0x00034EB0
			// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x00036CEC File Offset: 0x00034EEC
			public unsafe PointerEventData.InputButton button
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000CC6 RID: 3270 RVA: 0x00036D2C File Offset: 0x00034F2C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CC7 RID: 3271 RVA: 0x00006D74 File Offset: 0x00004F74
			public ButtonState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00036D68 File Offset: 0x00034F68
			// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x00006D7D File Offset: 0x00004F7D
			public unsafe PointerEventData.InputButton m_Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button)) = value;
				}
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00036D90 File Offset: 0x00034F90
			// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00006D98 File Offset: 0x00004F98
			public unsafe PointerInputModule.MouseButtonEventData m_EventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseButtonEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009EC RID: 2540
			private static readonly IntPtr NativeFieldInfoPtr_m_Button;

			// Token: 0x040009ED RID: 2541
			private static readonly IntPtr NativeFieldInfoPtr_m_EventData;

			// Token: 0x040009EE RID: 2542
			private static readonly IntPtr NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0;

			// Token: 0x040009EF RID: 2543
			private static readonly IntPtr NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0;

			// Token: 0x040009F0 RID: 2544
			private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_InputButton_0;

			// Token: 0x040009F1 RID: 2545
			private static readonly IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0;

			// Token: 0x040009F2 RID: 2546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000CB RID: 203
		public class MouseState : Object
		{
			// Token: 0x06000CCC RID: 3276 RVA: 0x00036DC0 File Offset: 0x00034FC0
			// Note: this type is marked as 'beforefieldinit'.
			static MouseState()
			{
				Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "MouseState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr);
				PointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, "m_TrackedButtons");
				PointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100664952);
				PointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100664953);
				PointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100664954);
				PointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_InputButton_FramePressState_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100664955);
				PointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100664956);
			}

			// Token: 0x06000CCD RID: 3277 RVA: 0x00036E64 File Offset: 0x00035064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532020, XrefRangeEnd = 532022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AnyPressesThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CCE RID: 3278 RVA: 0x00036EA0 File Offset: 0x000350A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532022, XrefRangeEnd = 532024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AnyReleasesThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CCF RID: 3279 RVA: 0x00036EDC File Offset: 0x000350DC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 532035, RefRangeEnd = 532042, XrefRangeStart = 532024, XrefRangeEnd = 532035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.ButtonState>(intPtr3) : null;
				}
			}

			// Token: 0x06000CD0 RID: 3280 RVA: 0x00036F28 File Offset: 0x00035128
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 532043, RefRangeEnd = 532046, XrefRangeStart = 532042, XrefRangeEnd = 532043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateForMouseButton;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_InputButton_FramePressState_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CD1 RID: 3281 RVA: 0x00036F88 File Offset: 0x00035188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532046, XrefRangeEnd = 532052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CD2 RID: 3282 RVA: 0x00006DB7 File Offset: 0x00004FB7
			public MouseState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00036FC4 File Offset: 0x000351C4
			// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x00006DC0 File Offset: 0x00004FC0
			public unsafe List<PointerInputModule.ButtonState> m_TrackedButtons
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PointerInputModule.ButtonState>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009F3 RID: 2547
			private static readonly IntPtr NativeFieldInfoPtr_m_TrackedButtons;

			// Token: 0x040009F4 RID: 2548
			private static readonly IntPtr NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0;

			// Token: 0x040009F5 RID: 2549
			private static readonly IntPtr NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0;

			// Token: 0x040009F6 RID: 2550
			private static readonly IntPtr NativeMethodInfoPtr_GetButtonState_Public_ButtonState_InputButton_0;

			// Token: 0x040009F7 RID: 2551
			private static readonly IntPtr NativeMethodInfoPtr_SetButtonState_Public_Void_InputButton_FramePressState_PointerEventData_0;

			// Token: 0x040009F8 RID: 2552
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000CC RID: 204
		public class MouseButtonEventData : Object
		{
			// Token: 0x06000CD5 RID: 3285 RVA: 0x00036FF4 File Offset: 0x000351F4
			// Note: this type is marked as 'beforefieldinit'.
			static MouseButtonEventData()
			{
				Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "MouseButtonEventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr);
				PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, "buttonState");
				PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, "buttonData");
				PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, 100664957);
				PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, 100664958);
				PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, 100664959);
			}

			// Token: 0x06000CD6 RID: 3286 RVA: 0x00037084 File Offset: 0x00035284
			[CallerCount(0)]
			public unsafe bool PressedThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CD7 RID: 3287 RVA: 0x000370C0 File Offset: 0x000352C0
			[CallerCount(0)]
			public unsafe bool ReleasedThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CD8 RID: 3288 RVA: 0x000370FC File Offset: 0x000352FC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseButtonEventData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CD9 RID: 3289 RVA: 0x00006DDF File Offset: 0x00004FDF
			public MouseButtonEventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00037138 File Offset: 0x00035338
			// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00006DE8 File Offset: 0x00004FE8
			public unsafe PointerEventData.FramePressState buttonState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState)) = value;
				}
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00037160 File Offset: 0x00035360
			// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00006E03 File Offset: 0x00005003
			public unsafe PointerEventData buttonData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009F9 RID: 2553
			private static readonly IntPtr NativeFieldInfoPtr_buttonState;

			// Token: 0x040009FA RID: 2554
			private static readonly IntPtr NativeFieldInfoPtr_buttonData;

			// Token: 0x040009FB RID: 2555
			private static readonly IntPtr NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0;

			// Token: 0x040009FC RID: 2556
			private static readonly IntPtr NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0;

			// Token: 0x040009FD RID: 2557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
