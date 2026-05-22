using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x02000051 RID: 81
	[Serializable]
	public sealed class TouchRegion : TouchInteractable
	{
		// Token: 0x060009C9 RID: 2505 RVA: 0x00052F8C File Offset: 0x0005118C
		// Note: this type is marked as 'beforefieldinit'.
		static TouchRegion()
		{
			Il2CppClassPointerStore<TouchRegion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "TouchRegion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr);
			TouchRegion.NativeFieldInfoPtr__hideAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "_hideAtRuntime");
			TouchRegion.NativeFieldInfoPtr__onPointerDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "_onPointerDown");
			TouchRegion.NativeFieldInfoPtr__onPointerUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "_onPointerUp");
			TouchRegion.NativeFieldInfoPtr__onPointerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "_onPointerEnter");
			TouchRegion.NativeFieldInfoPtr__onPointerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "_onPointerExit");
			TouchRegion.NativeFieldInfoPtr__onBeginDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "_onBeginDrag");
			TouchRegion.NativeFieldInfoPtr__onDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "_onDrag");
			TouchRegion.NativeFieldInfoPtr__onEndDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "_onEndDrag");
			TouchRegion.NativeMethodInfoPtr_get_hideAtRuntime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664889);
			TouchRegion.NativeMethodInfoPtr_set_hideAtRuntime_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664890);
			TouchRegion.NativeMethodInfoPtr_add_PointerDownEvent_Public_add_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664891);
			TouchRegion.NativeMethodInfoPtr_remove_PointerDownEvent_Public_rem_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664892);
			TouchRegion.NativeMethodInfoPtr_add_PointerUpEvent_Public_add_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664893);
			TouchRegion.NativeMethodInfoPtr_remove_PointerUpEvent_Public_rem_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664894);
			TouchRegion.NativeMethodInfoPtr_add_PointerEnterEvent_Public_add_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664895);
			TouchRegion.NativeMethodInfoPtr_remove_PointerEnterEvent_Public_rem_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664896);
			TouchRegion.NativeMethodInfoPtr_add_PointerExitEvent_Public_add_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664897);
			TouchRegion.NativeMethodInfoPtr_remove_PointerExitEvent_Public_rem_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664898);
			TouchRegion.NativeMethodInfoPtr_add_BeginDragEvent_Public_add_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664899);
			TouchRegion.NativeMethodInfoPtr_remove_BeginDragEvent_Public_rem_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664900);
			TouchRegion.NativeMethodInfoPtr_add_DragEvent_Public_add_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664901);
			TouchRegion.NativeMethodInfoPtr_remove_DragEvent_Public_rem_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664902);
			TouchRegion.NativeMethodInfoPtr_add_EndDragEvent_Public_add_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664903);
			TouchRegion.NativeMethodInfoPtr_remove_EndDragEvent_Public_rem_Void_UnityAction_1_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664904);
			TouchRegion.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664905);
			TouchRegion.NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664906);
			TouchRegion.NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664907);
			TouchRegion.NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664908);
			TouchRegion.NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664909);
			TouchRegion.NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664910);
			TouchRegion.NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664911);
			TouchRegion.NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664912);
			TouchRegion.NativeMethodInfoPtr_OnBeginDrag_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664913);
			TouchRegion.NativeMethodInfoPtr_OnDrag_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664914);
			TouchRegion.NativeMethodInfoPtr_OnEndDrag_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, 100664915);
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00053278 File Offset: 0x00051478
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x000532B4 File Offset: 0x000514B4
		public unsafe bool hideAtRuntime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_get_hideAtRuntime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_set_hideAtRuntime_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000532F4 File Offset: 0x000514F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250505, RefRangeEnd = 250507, XrefRangeStart = 250500, XrefRangeEnd = 250505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PointerDownEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_add_PointerDownEvent_Public_add_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00053338 File Offset: 0x00051538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250507, XrefRangeEnd = 250510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PointerDownEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_remove_PointerDownEvent_Public_rem_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0005337C File Offset: 0x0005157C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250515, RefRangeEnd = 250517, XrefRangeStart = 250510, XrefRangeEnd = 250515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PointerUpEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_add_PointerUpEvent_Public_add_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000533C0 File Offset: 0x000515C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250517, XrefRangeEnd = 250520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PointerUpEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_remove_PointerUpEvent_Public_rem_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00053404 File Offset: 0x00051604
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250525, RefRangeEnd = 250527, XrefRangeStart = 250520, XrefRangeEnd = 250525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PointerEnterEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_add_PointerEnterEvent_Public_add_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00053448 File Offset: 0x00051648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250527, XrefRangeEnd = 250530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PointerEnterEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_remove_PointerEnterEvent_Public_rem_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0005348C File Offset: 0x0005168C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250535, RefRangeEnd = 250537, XrefRangeStart = 250530, XrefRangeEnd = 250535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PointerExitEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_add_PointerExitEvent_Public_add_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000534D0 File Offset: 0x000516D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250537, XrefRangeEnd = 250540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PointerExitEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_remove_PointerExitEvent_Public_rem_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00053514 File Offset: 0x00051714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250540, XrefRangeEnd = 250545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_BeginDragEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_add_BeginDragEvent_Public_add_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00053558 File Offset: 0x00051758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250545, XrefRangeEnd = 250548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_BeginDragEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_remove_BeginDragEvent_Public_rem_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0005359C File Offset: 0x0005179C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250548, XrefRangeEnd = 250553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_DragEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_add_DragEvent_Public_add_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000535E0 File Offset: 0x000517E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250553, XrefRangeEnd = 250556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_DragEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_remove_DragEvent_Public_rem_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00053624 File Offset: 0x00051824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250556, XrefRangeEnd = 250561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_EndDragEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_add_EndDragEvent_Public_add_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00053668 File Offset: 0x00051868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250561, XrefRangeEnd = 250564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_EndDragEvent(UnityAction<PointerEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_remove_EndDragEvent_Public_rem_Void_UnityAction_1_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000536AC File Offset: 0x000518AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250564, XrefRangeEnd = 250603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchRegion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000536E8 File Offset: 0x000518E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250603, XrefRangeEnd = 250607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0005371C File Offset: 0x0005191C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00053750 File Offset: 0x00051950
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void zKEQtrzzyQhnNzFWJQGLGZUsGJG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00053784 File Offset: 0x00051984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250607, XrefRangeEnd = 250619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000537C8 File Offset: 0x000519C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250619, XrefRangeEnd = 250631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0005380C File Offset: 0x00051A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250631, XrefRangeEnd = 250643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00053850 File Offset: 0x00051A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250643, XrefRangeEnd = 250655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00053894 File Offset: 0x00051A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250655, XrefRangeEnd = 250670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_OnBeginDrag_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000538D8 File Offset: 0x00051AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250670, XrefRangeEnd = 250685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_OnDrag_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0005391C File Offset: 0x00051B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250685, XrefRangeEnd = 250700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NativeMethodInfoPtr_OnEndDrag_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0000550B File Offset: 0x0000370B
		public TouchRegion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00053960 File Offset: 0x00051B60
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00005514 File Offset: 0x00003714
		public unsafe bool _hideAtRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__hideAtRuntime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__hideAtRuntime)) = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00053988 File Offset: 0x00051B88
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0000552F File Offset: 0x0000372F
		public unsafe TouchRegion.iKKkKcKKtMKVvRaqjPYlSlNvgCR _onPointerDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onPointerDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchRegion.iKKkKcKKtMKVvRaqjPYlSlNvgCR>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onPointerDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x000539B8 File Offset: 0x00051BB8
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x0000554E File Offset: 0x0000374E
		public unsafe TouchRegion.lVBVRCdiBoRMYljqrkgHVkuGqnr _onPointerUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onPointerUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchRegion.lVBVRCdiBoRMYljqrkgHVkuGqnr>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onPointerUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x000539E8 File Offset: 0x00051BE8
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0000556D File Offset: 0x0000376D
		public unsafe TouchRegion.YPUYDDyRhLBzLrlKWfcyOtSkDbV _onPointerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onPointerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchRegion.YPUYDDyRhLBzLrlKWfcyOtSkDbV>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onPointerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00053A18 File Offset: 0x00051C18
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x0000558C File Offset: 0x0000378C
		public unsafe TouchRegion.aJuPLuPnuyyiXowTTTjdfBeczds _onPointerExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onPointerExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchRegion.aJuPLuPnuyyiXowTTTjdfBeczds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onPointerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00053A48 File Offset: 0x00051C48
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x000055AB File Offset: 0x000037AB
		public unsafe TouchRegion.zIuOuoscAvWLTUBnbNkIhXXjJJO _onBeginDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onBeginDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchRegion.zIuOuoscAvWLTUBnbNkIhXXjJJO>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onBeginDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00053A78 File Offset: 0x00051C78
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x000055CA File Offset: 0x000037CA
		public unsafe TouchRegion.NkiAFsdKJVjIDwbsOPrbdBllTOrv _onDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchRegion.NkiAFsdKJVjIDwbsOPrbdBllTOrv>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00053AA8 File Offset: 0x00051CA8
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x000055E9 File Offset: 0x000037E9
		public unsafe TouchRegion.EoMxoOmMaTNRvFmNWxLshCwBDlh _onEndDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onEndDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchRegion.EoMxoOmMaTNRvFmNWxLshCwBDlh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchRegion.NativeFieldInfoPtr__onEndDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeFieldInfoPtr__hideAtRuntime;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeFieldInfoPtr__onPointerDown;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeFieldInfoPtr__onPointerUp;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeFieldInfoPtr__onPointerEnter;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeFieldInfoPtr__onPointerExit;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeFieldInfoPtr__onBeginDrag;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeFieldInfoPtr__onDrag;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeFieldInfoPtr__onEndDrag;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_get_hideAtRuntime_Public_get_Boolean_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_set_hideAtRuntime_Public_set_Void_Boolean_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_add_PointerDownEvent_Public_add_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_remove_PointerDownEvent_Public_rem_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_add_PointerUpEvent_Public_add_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_remove_PointerUpEvent_Public_rem_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_add_PointerEnterEvent_Public_add_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_remove_PointerEnterEvent_Public_rem_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_add_PointerExitEvent_Public_add_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_remove_PointerExitEvent_Public_rem_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_add_BeginDragEvent_Public_add_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_remove_BeginDragEvent_Public_rem_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_add_DragEvent_Public_add_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_remove_DragEvent_Public_rem_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_add_EndDragEvent_Public_add_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_remove_EndDragEvent_Public_rem_Void_UnityAction_1_PointerEventData_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x02000267 RID: 615
		[Serializable]
		public class iKKkKcKKtMKVvRaqjPYlSlNvgCR : UnityEvent<PointerEventData>
		{
			// Token: 0x06003955 RID: 14677 RVA: 0x0001425B File Offset: 0x0001245B
			// Note: this type is marked as 'beforefieldinit'.
			static iKKkKcKKtMKVvRaqjPYlSlNvgCR()
			{
				Il2CppClassPointerStore<TouchRegion.iKKkKcKKtMKVvRaqjPYlSlNvgCR>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "iKKkKcKKtMKVvRaqjPYlSlNvgCR");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchRegion.iKKkKcKKtMKVvRaqjPYlSlNvgCR>.NativeClassPtr);
				TouchRegion.iKKkKcKKtMKVvRaqjPYlSlNvgCR.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion.iKKkKcKKtMKVvRaqjPYlSlNvgCR>.NativeClassPtr, 100664916);
			}

			// Token: 0x06003956 RID: 14678 RVA: 0x001171B0 File Offset: 0x001153B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250486, XrefRangeEnd = 250488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe iKKkKcKKtMKVvRaqjPYlSlNvgCR()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchRegion.iKKkKcKKtMKVvRaqjPYlSlNvgCR>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.iKKkKcKKtMKVvRaqjPYlSlNvgCR.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003957 RID: 14679 RVA: 0x0001428F File Offset: 0x0001248F
			public iKKkKcKKtMKVvRaqjPYlSlNvgCR(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003065 RID: 12389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000268 RID: 616
		[Serializable]
		public class lVBVRCdiBoRMYljqrkgHVkuGqnr : UnityEvent<PointerEventData>
		{
			// Token: 0x06003958 RID: 14680 RVA: 0x00014298 File Offset: 0x00012498
			// Note: this type is marked as 'beforefieldinit'.
			static lVBVRCdiBoRMYljqrkgHVkuGqnr()
			{
				Il2CppClassPointerStore<TouchRegion.lVBVRCdiBoRMYljqrkgHVkuGqnr>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "lVBVRCdiBoRMYljqrkgHVkuGqnr");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchRegion.lVBVRCdiBoRMYljqrkgHVkuGqnr>.NativeClassPtr);
				TouchRegion.lVBVRCdiBoRMYljqrkgHVkuGqnr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion.lVBVRCdiBoRMYljqrkgHVkuGqnr>.NativeClassPtr, 100664917);
			}

			// Token: 0x06003959 RID: 14681 RVA: 0x001171EC File Offset: 0x001153EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250488, XrefRangeEnd = 250490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe lVBVRCdiBoRMYljqrkgHVkuGqnr()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchRegion.lVBVRCdiBoRMYljqrkgHVkuGqnr>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.lVBVRCdiBoRMYljqrkgHVkuGqnr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600395A RID: 14682 RVA: 0x000142CC File Offset: 0x000124CC
			public lVBVRCdiBoRMYljqrkgHVkuGqnr(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003066 RID: 12390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000269 RID: 617
		[Serializable]
		public class YPUYDDyRhLBzLrlKWfcyOtSkDbV : UnityEvent<PointerEventData>
		{
			// Token: 0x0600395B RID: 14683 RVA: 0x000142D5 File Offset: 0x000124D5
			// Note: this type is marked as 'beforefieldinit'.
			static YPUYDDyRhLBzLrlKWfcyOtSkDbV()
			{
				Il2CppClassPointerStore<TouchRegion.YPUYDDyRhLBzLrlKWfcyOtSkDbV>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "YPUYDDyRhLBzLrlKWfcyOtSkDbV");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchRegion.YPUYDDyRhLBzLrlKWfcyOtSkDbV>.NativeClassPtr);
				TouchRegion.YPUYDDyRhLBzLrlKWfcyOtSkDbV.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion.YPUYDDyRhLBzLrlKWfcyOtSkDbV>.NativeClassPtr, 100664918);
			}

			// Token: 0x0600395C RID: 14684 RVA: 0x00117228 File Offset: 0x00115428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250490, XrefRangeEnd = 250492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe YPUYDDyRhLBzLrlKWfcyOtSkDbV()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchRegion.YPUYDDyRhLBzLrlKWfcyOtSkDbV>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.YPUYDDyRhLBzLrlKWfcyOtSkDbV.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600395D RID: 14685 RVA: 0x00014309 File Offset: 0x00012509
			public YPUYDDyRhLBzLrlKWfcyOtSkDbV(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003067 RID: 12391
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200026A RID: 618
		[Serializable]
		public class aJuPLuPnuyyiXowTTTjdfBeczds : UnityEvent<PointerEventData>
		{
			// Token: 0x0600395E RID: 14686 RVA: 0x00014312 File Offset: 0x00012512
			// Note: this type is marked as 'beforefieldinit'.
			static aJuPLuPnuyyiXowTTTjdfBeczds()
			{
				Il2CppClassPointerStore<TouchRegion.aJuPLuPnuyyiXowTTTjdfBeczds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "aJuPLuPnuyyiXowTTTjdfBeczds");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchRegion.aJuPLuPnuyyiXowTTTjdfBeczds>.NativeClassPtr);
				TouchRegion.aJuPLuPnuyyiXowTTTjdfBeczds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion.aJuPLuPnuyyiXowTTTjdfBeczds>.NativeClassPtr, 100664919);
			}

			// Token: 0x0600395F RID: 14687 RVA: 0x00117264 File Offset: 0x00115464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250492, XrefRangeEnd = 250494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe aJuPLuPnuyyiXowTTTjdfBeczds()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchRegion.aJuPLuPnuyyiXowTTTjdfBeczds>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.aJuPLuPnuyyiXowTTTjdfBeczds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003960 RID: 14688 RVA: 0x00014346 File Offset: 0x00012546
			public aJuPLuPnuyyiXowTTTjdfBeczds(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003068 RID: 12392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200026B RID: 619
		[Serializable]
		public class zIuOuoscAvWLTUBnbNkIhXXjJJO : UnityEvent<PointerEventData>
		{
			// Token: 0x06003961 RID: 14689 RVA: 0x0001434F File Offset: 0x0001254F
			// Note: this type is marked as 'beforefieldinit'.
			static zIuOuoscAvWLTUBnbNkIhXXjJJO()
			{
				Il2CppClassPointerStore<TouchRegion.zIuOuoscAvWLTUBnbNkIhXXjJJO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "zIuOuoscAvWLTUBnbNkIhXXjJJO");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchRegion.zIuOuoscAvWLTUBnbNkIhXXjJJO>.NativeClassPtr);
				TouchRegion.zIuOuoscAvWLTUBnbNkIhXXjJJO.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion.zIuOuoscAvWLTUBnbNkIhXXjJJO>.NativeClassPtr, 100664920);
			}

			// Token: 0x06003962 RID: 14690 RVA: 0x001172A0 File Offset: 0x001154A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250494, XrefRangeEnd = 250496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe zIuOuoscAvWLTUBnbNkIhXXjJJO()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchRegion.zIuOuoscAvWLTUBnbNkIhXXjJJO>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.zIuOuoscAvWLTUBnbNkIhXXjJJO.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003963 RID: 14691 RVA: 0x00014383 File Offset: 0x00012583
			public zIuOuoscAvWLTUBnbNkIhXXjJJO(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003069 RID: 12393
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200026C RID: 620
		[Serializable]
		public class NkiAFsdKJVjIDwbsOPrbdBllTOrv : UnityEvent<PointerEventData>
		{
			// Token: 0x06003964 RID: 14692 RVA: 0x0001438C File Offset: 0x0001258C
			// Note: this type is marked as 'beforefieldinit'.
			static NkiAFsdKJVjIDwbsOPrbdBllTOrv()
			{
				Il2CppClassPointerStore<TouchRegion.NkiAFsdKJVjIDwbsOPrbdBllTOrv>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "NkiAFsdKJVjIDwbsOPrbdBllTOrv");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchRegion.NkiAFsdKJVjIDwbsOPrbdBllTOrv>.NativeClassPtr);
				TouchRegion.NkiAFsdKJVjIDwbsOPrbdBllTOrv.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion.NkiAFsdKJVjIDwbsOPrbdBllTOrv>.NativeClassPtr, 100664921);
			}

			// Token: 0x06003965 RID: 14693 RVA: 0x001172DC File Offset: 0x001154DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250496, XrefRangeEnd = 250498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NkiAFsdKJVjIDwbsOPrbdBllTOrv()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchRegion.NkiAFsdKJVjIDwbsOPrbdBllTOrv>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.NkiAFsdKJVjIDwbsOPrbdBllTOrv.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003966 RID: 14694 RVA: 0x000143C0 File Offset: 0x000125C0
			public NkiAFsdKJVjIDwbsOPrbdBllTOrv(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400306A RID: 12394
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200026D RID: 621
		[Serializable]
		public class EoMxoOmMaTNRvFmNWxLshCwBDlh : UnityEvent<PointerEventData>
		{
			// Token: 0x06003967 RID: 14695 RVA: 0x000143C9 File Offset: 0x000125C9
			// Note: this type is marked as 'beforefieldinit'.
			static EoMxoOmMaTNRvFmNWxLshCwBDlh()
			{
				Il2CppClassPointerStore<TouchRegion.EoMxoOmMaTNRvFmNWxLshCwBDlh>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchRegion>.NativeClassPtr, "EoMxoOmMaTNRvFmNWxLshCwBDlh");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchRegion.EoMxoOmMaTNRvFmNWxLshCwBDlh>.NativeClassPtr);
				TouchRegion.EoMxoOmMaTNRvFmNWxLshCwBDlh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchRegion.EoMxoOmMaTNRvFmNWxLshCwBDlh>.NativeClassPtr, 100664922);
			}

			// Token: 0x06003968 RID: 14696 RVA: 0x00117318 File Offset: 0x00115518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250498, XrefRangeEnd = 250500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EoMxoOmMaTNRvFmNWxLshCwBDlh()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchRegion.EoMxoOmMaTNRvFmNWxLshCwBDlh>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchRegion.EoMxoOmMaTNRvFmNWxLshCwBDlh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003969 RID: 14697 RVA: 0x000143FD File Offset: 0x000125FD
			public EoMxoOmMaTNRvFmNWxLshCwBDlh(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400306B RID: 12395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
