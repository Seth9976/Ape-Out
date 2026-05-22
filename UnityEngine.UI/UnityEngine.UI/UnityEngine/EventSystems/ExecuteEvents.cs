using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.UI;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000066 RID: 102
	public static class ExecuteEvents : Object
	{
		// Token: 0x060009B9 RID: 2489 RVA: 0x0002C5B0 File Offset: 0x0002A7B0
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteEvents()
		{
			Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ExecuteEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr);
			ExecuteEvents.NativeFieldInfoPtr_s_PointerEnterHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerEnterHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerExitHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerExitHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerDownHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerDownHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerUpHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerUpHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerClickHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerClickHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_InitializePotentialDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_InitializePotentialDragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_BeginDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_BeginDragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_DragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_EndDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_EndDragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_DropHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DropHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_ScrollHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_ScrollHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_UpdateSelectedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_UpdateSelectedHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_SelectHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_SelectHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_DeselectHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DeselectHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_MoveHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_MoveHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_SubmitHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_SubmitHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_CancelHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_CancelHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_HandlerListPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_HandlerListPool");
			ExecuteEvents.NativeFieldInfoPtr_s_InternalTransformList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_InternalTransformList");
			ExecuteEvents.NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664843);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664844);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664845);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664846);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664847);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664848);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664849);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664850);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664851);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664852);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664853);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664854);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664855);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664856);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664857);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664858);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664859);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664860);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664861);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664862);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664863);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664864);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664865);
			ExecuteEvents.NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664866);
			ExecuteEvents.NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664867);
			ExecuteEvents.NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664868);
			ExecuteEvents.NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664869);
			ExecuteEvents.NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664870);
			ExecuteEvents.NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664871);
			ExecuteEvents.NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664872);
			ExecuteEvents.NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664873);
			ExecuteEvents.NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664874);
			ExecuteEvents.NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664875);
			ExecuteEvents.NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664876);
			ExecuteEvents.NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664877);
			ExecuteEvents.NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664878);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664879);
			ExecuteEvents.NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664880);
			ExecuteEvents.NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664881);
			ExecuteEvents.NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664882);
			ExecuteEvents.NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664883);
			ExecuteEvents.NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664884);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0002CAA4 File Offset: 0x0002ACA4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 531116, RefRangeEnd = 531128, XrefRangeStart = 531109, XrefRangeEnd = 531116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ValidateEventData<T>(BaseEventData data) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_ValidateEventData_Public_Static_T_BaseEventData_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0002CAE4 File Offset: 0x0002ACE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531128, XrefRangeEnd = 531138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerEnterHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0002CB2C File Offset: 0x0002AD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531138, XrefRangeEnd = 531148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerExitHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0002CB74 File Offset: 0x0002AD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531148, XrefRangeEnd = 531158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerDownHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0002CBBC File Offset: 0x0002ADBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531158, XrefRangeEnd = 531168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerUpHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0002CC04 File Offset: 0x0002AE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531168, XrefRangeEnd = 531178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerClickHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0002CC4C File Offset: 0x0002AE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531178, XrefRangeEnd = 531188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0002CC94 File Offset: 0x0002AE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531188, XrefRangeEnd = 531198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IBeginDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0002CCDC File Offset: 0x0002AEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531198, XrefRangeEnd = 531208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0002CD24 File Offset: 0x0002AF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531208, XrefRangeEnd = 531218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IEndDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0002CD6C File Offset: 0x0002AF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531218, XrefRangeEnd = 531228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IDropHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0002CDB4 File Offset: 0x0002AFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531228, XrefRangeEnd = 531238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IScrollHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0002CDFC File Offset: 0x0002AFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531238, XrefRangeEnd = 531242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0002CE44 File Offset: 0x0002B044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531242, XrefRangeEnd = 531246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(ISelectHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0002CE8C File Offset: 0x0002B08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531246, XrefRangeEnd = 531250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IDeselectHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0002CED4 File Offset: 0x0002B0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531250, XrefRangeEnd = 531261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IMoveHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0002CF1C File Offset: 0x0002B11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531261, XrefRangeEnd = 531265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(ISubmitHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0002CF64 File Offset: 0x0002B164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531265, XrefRangeEnd = 531269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(ICancelHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0002CFAC File Offset: 0x0002B1AC
		public unsafe static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531269, XrefRangeEnd = 531273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerEnterHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x0002CFE0 File Offset: 0x0002B1E0
		public unsafe static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531273, XrefRangeEnd = 531277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerExitHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0002D014 File Offset: 0x0002B214
		public unsafe static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531277, XrefRangeEnd = 531281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerDownHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0002D048 File Offset: 0x0002B248
		public unsafe static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531281, XrefRangeEnd = 531285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerUpHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0002D07C File Offset: 0x0002B27C
		public unsafe static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531285, XrefRangeEnd = 531289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerClickHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0002D0B0 File Offset: 0x0002B2B0
		public unsafe static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531289, XrefRangeEnd = 531293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IInitializePotentialDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0002D0E4 File Offset: 0x0002B2E4
		public unsafe static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531293, XrefRangeEnd = 531297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IBeginDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0002D118 File Offset: 0x0002B318
		public unsafe static ExecuteEvents.EventFunction<IDragHandler> dragHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531297, XrefRangeEnd = 531301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0002D14C File Offset: 0x0002B34C
		public unsafe static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531301, XrefRangeEnd = 531305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IEndDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0002D180 File Offset: 0x0002B380
		public unsafe static ExecuteEvents.EventFunction<IDropHandler> dropHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531305, XrefRangeEnd = 531309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDropHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0002D1B4 File Offset: 0x0002B3B4
		public unsafe static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531309, XrefRangeEnd = 531313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IScrollHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0002D1E8 File Offset: 0x0002B3E8
		public unsafe static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531313, XrefRangeEnd = 531317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IUpdateSelectedHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0002D21C File Offset: 0x0002B41C
		public unsafe static ExecuteEvents.EventFunction<ISelectHandler> selectHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531317, XrefRangeEnd = 531321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISelectHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0002D250 File Offset: 0x0002B450
		public unsafe static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531321, XrefRangeEnd = 531325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDeselectHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0002D284 File Offset: 0x0002B484
		public unsafe static ExecuteEvents.EventFunction<IMoveHandler> moveHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531325, XrefRangeEnd = 531329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IMoveHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0002D2B8 File Offset: 0x0002B4B8
		public unsafe static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531329, XrefRangeEnd = 531333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISubmitHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0002D2EC File Offset: 0x0002B4EC
		public unsafe static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531333, XrefRangeEnd = 531337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ICancelHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0002D320 File Offset: 0x0002B520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 531371, RefRangeEnd = 531372, XrefRangeStart = 531337, XrefRangeEnd = 531371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetEventChain(GameObject root, IList<Transform> eventChain)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0002D368 File Offset: 0x0002B568
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 531415, RefRangeEnd = 531453, XrefRangeStart = 531372, XrefRangeEnd = 531415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(functor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0002D3D0 File Offset: 0x0002B5D0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 531467, RefRangeEnd = 531482, XrefRangeStart = 531453, XrefRangeEnd = 531467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0002D438 File Offset: 0x0002B638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531482, XrefRangeEnd = 531501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldSendToComponent<T>(Component component)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_ShouldSendToComponent_Private_Static_Boolean_Component_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0002D47C File Offset: 0x0002B67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531501, XrefRangeEnd = 531539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002D4C4 File Offset: 0x0002B6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531539, XrefRangeEnd = 531551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanHandleEvent<T>(GameObject go)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_CanHandleEvent_Public_Static_Boolean_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002D508 File Offset: 0x0002B708
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 531584, RefRangeEnd = 531604, XrefRangeStart = 531551, XrefRangeEnd = 531584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject GetEventHandler<T>(GameObject root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_GetEventHandler_Public_Static_GameObject_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000058A7 File Offset: 0x00003AA7
		public ExecuteEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0002D54C File Offset: 0x0002B74C
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x000058B0 File Offset: 0x00003AB0
		public unsafe static ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerEnterHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerEnterHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerEnterHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0002D574 File Offset: 0x0002B774
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x000058C2 File Offset: 0x00003AC2
		public unsafe static ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerExitHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerExitHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerExitHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0002D59C File Offset: 0x0002B79C
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x000058D4 File Offset: 0x00003AD4
		public unsafe static ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerDownHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerDownHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerDownHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0002D5C4 File Offset: 0x0002B7C4
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x000058E6 File Offset: 0x00003AE6
		public unsafe static ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerUpHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerUpHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerUpHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0002D5EC File Offset: 0x0002B7EC
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x000058F8 File Offset: 0x00003AF8
		public unsafe static ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerClickHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerClickHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerClickHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0002D614 File Offset: 0x0002B814
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x0000590A File Offset: 0x00003B0A
		public unsafe static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_InitializePotentialDragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IInitializePotentialDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_InitializePotentialDragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0002D63C File Offset: 0x0002B83C
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x0000591C File Offset: 0x00003B1C
		public unsafe static ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_BeginDragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IBeginDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_BeginDragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0002D664 File Offset: 0x0002B864
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x0000592E File Offset: 0x00003B2E
		public unsafe static ExecuteEvents.EventFunction<IDragHandler> s_DragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_DragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_DragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0002D68C File Offset: 0x0002B88C
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00005940 File Offset: 0x00003B40
		public unsafe static ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_EndDragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IEndDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_EndDragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0002D6B4 File Offset: 0x0002B8B4
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00005952 File Offset: 0x00003B52
		public unsafe static ExecuteEvents.EventFunction<IDropHandler> s_DropHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_DropHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDropHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_DropHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0002D6DC File Offset: 0x0002B8DC
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00005964 File Offset: 0x00003B64
		public unsafe static ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_ScrollHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IScrollHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_ScrollHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0002D704 File Offset: 0x0002B904
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00005976 File Offset: 0x00003B76
		public unsafe static ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_UpdateSelectedHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IUpdateSelectedHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_UpdateSelectedHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0002D72C File Offset: 0x0002B92C
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00005988 File Offset: 0x00003B88
		public unsafe static ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_SelectHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISelectHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_SelectHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0002D754 File Offset: 0x0002B954
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x0000599A File Offset: 0x00003B9A
		public unsafe static ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_DeselectHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDeselectHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_DeselectHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0002D77C File Offset: 0x0002B97C
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x000059AC File Offset: 0x00003BAC
		public unsafe static ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_MoveHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IMoveHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_MoveHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0002D7A4 File Offset: 0x0002B9A4
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x000059BE File Offset: 0x00003BBE
		public unsafe static ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_SubmitHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISubmitHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_SubmitHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0002D7CC File Offset: 0x0002B9CC
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x000059D0 File Offset: 0x00003BD0
		public unsafe static ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_CancelHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ICancelHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_CancelHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0002D7F4 File Offset: 0x0002B9F4
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x000059E2 File Offset: 0x00003BE2
		public unsafe static ObjectPool<List<IEventSystemHandler>> s_HandlerListPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_HandlerListPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<List<IEventSystemHandler>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_HandlerListPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0002D81C File Offset: 0x0002BA1C
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x000059F4 File Offset: 0x00003BF4
		public unsafe static List<Transform> s_InternalTransformList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_InternalTransformList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_InternalTransformList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerEnterHandler;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerExitHandler;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerDownHandler;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerUpHandler;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerClickHandler;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeFieldInfoPtr_s_InitializePotentialDragHandler;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeFieldInfoPtr_s_BeginDragHandler;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeFieldInfoPtr_s_DragHandler;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeFieldInfoPtr_s_EndDragHandler;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeFieldInfoPtr_s_DropHandler;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeFieldInfoPtr_s_ScrollHandler;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeFieldInfoPtr_s_UpdateSelectedHandler;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeFieldInfoPtr_s_SelectHandler;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeFieldInfoPtr_s_DeselectHandler;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeFieldInfoPtr_s_MoveHandler;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeFieldInfoPtr_s_SubmitHandler;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeFieldInfoPtr_s_CancelHandler;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeFieldInfoPtr_s_HandlerListPool;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalTransformList;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0;

		// Token: 0x020000C1 RID: 193
		public sealed class EventFunction<T1> : MulticastDelegate
		{
			// Token: 0x06000CAB RID: 3243 RVA: 0x00036558 File Offset: 0x00034758
			// Note: this type is marked as 'beforefieldinit'.
			static EventFunction()
			{
				Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "EventFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)) })).TypeHandle.value);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100664886);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100664887);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100664888);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100664889);
			}

			// Token: 0x06000CAC RID: 3244 RVA: 0x00036604 File Offset: 0x00034804
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CAD RID: 3245 RVA: 0x00036660 File Offset: 0x00034860
			[CallerCount(0)]
			public unsafe void Invoke(T1 handler, BaseEventData eventData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T1 ptr4;
					if (!typeof(T1).IsValueType)
					{
						T1 t = handler;
						if (!(t is string))
						{
							ref T1 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref handler;
					}
					*ptr2 = ref ptr4;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CAE RID: 3246 RVA: 0x00036700 File Offset: 0x00034900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T1 ptr4;
					if (!typeof(T1).IsValueType)
					{
						T1 t = handler;
						if (!(t is string))
						{
							ref T1 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref handler;
					}
					*ptr2 = ref ptr4;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000CAF RID: 3247 RVA: 0x000367D4 File Offset: 0x000349D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CB0 RID: 3248 RVA: 0x00006D29 File Offset: 0x00004F29
			public EventFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000CB1 RID: 3249 RVA: 0x00006D32 File Offset: 0x00004F32
			public static implicit operator ExecuteEvents.EventFunction<T1>(Action<T1, BaseEventData> A_0)
			{
				return DelegateSupport.ConvertDelegate<ExecuteEvents.EventFunction<T1>>(A_0);
			}

			// Token: 0x06000CB2 RID: 3250 RVA: 0x00006D3A File Offset: 0x00004F3A
			public static ExecuteEvents.EventFunction<T1>operator +(ExecuteEvents.EventFunction<T1> A_0, ExecuteEvents.EventFunction<T1> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ExecuteEvents.EventFunction<T1>>();
			}

			// Token: 0x06000CB3 RID: 3251 RVA: 0x00006D48 File Offset: 0x00004F48
			public static ExecuteEvents.EventFunction<T1>operator -(ExecuteEvents.EventFunction<T1> A_0, ExecuteEvents.EventFunction<T1> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ExecuteEvents.EventFunction<T1>>();
				}
				return delegate2;
			}

			// Token: 0x040009DE RID: 2526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009DF RID: 2527
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0;

			// Token: 0x040009E0 RID: 2528
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0;

			// Token: 0x040009E1 RID: 2529
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020000C2 RID: 194
		[ObfuscatedName("UnityEngine.EventSystems.ExecuteEvents+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000CB4 RID: 3252 RVA: 0x00036818 File Offset: 0x00034A18
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ExecuteEvents.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteEvents.__c>.NativeClassPtr);
				ExecuteEvents.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents.__c>.NativeClassPtr, "<>9");
				ExecuteEvents.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.__c>.NativeClassPtr, 100664891);
				ExecuteEvents.__c.NativeMethodInfoPtr___cctor_b__79_0_Internal_Void_List_1_IEventSystemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.__c>.NativeClassPtr, 100664892);
			}

			// Token: 0x06000CB5 RID: 3253 RVA: 0x00036880 File Offset: 0x00034A80
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteEvents.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CB6 RID: 3254 RVA: 0x000368BC File Offset: 0x00034ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531107, XrefRangeEnd = 531109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__79_0(List<IEventSystemHandler> l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.__c.NativeMethodInfoPtr___cctor_b__79_0_Internal_Void_List_1_IEventSystemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CB7 RID: 3255 RVA: 0x00006D59 File Offset: 0x00004F59
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00036900 File Offset: 0x00034B00
			// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00006D62 File Offset: 0x00004F62
			public unsafe static ExecuteEvents.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009E2 RID: 2530
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040009E3 RID: 2531
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040009E4 RID: 2532
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__79_0_Internal_Void_List_1_IEventSystemHandler_0;
		}

		// Token: 0x020000C3 RID: 195
		private sealed class MethodInfoStoreGeneric_ValidateEventData_Public_Static_T_BaseEventData_0<T>
		{
			// Token: 0x040009E5 RID: 2533
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C4 RID: 196
		private sealed class MethodInfoStoreGeneric_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0<T>
		{
			// Token: 0x040009E6 RID: 2534
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C5 RID: 197
		private sealed class MethodInfoStoreGeneric_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0<T>
		{
			// Token: 0x040009E7 RID: 2535
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C6 RID: 198
		private sealed class MethodInfoStoreGeneric_ShouldSendToComponent_Private_Static_Boolean_Component_0<T>
		{
			// Token: 0x040009E8 RID: 2536
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C7 RID: 199
		private sealed class MethodInfoStoreGeneric_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0<T>
		{
			// Token: 0x040009E9 RID: 2537
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C8 RID: 200
		private sealed class MethodInfoStoreGeneric_CanHandleEvent_Public_Static_Boolean_GameObject_0<T>
		{
			// Token: 0x040009EA RID: 2538
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C9 RID: 201
		private sealed class MethodInfoStoreGeneric_GetEventHandler_Public_Static_GameObject_GameObject_0<T>
		{
			// Token: 0x040009EB RID: 2539
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
