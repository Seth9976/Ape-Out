using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000012 RID: 18
	public class GraphicRaycaster : BaseRaycaster
	{
		// Token: 0x060001BA RID: 442 RVA: 0x0000D554 File Offset: 0x0000B754
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicRaycaster()
		{
			Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "GraphicRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr);
			GraphicRaycaster.NativeFieldInfoPtr_kNoEventMaskSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "kNoEventMaskSet");
			GraphicRaycaster.NativeFieldInfoPtr_m_IgnoreReversedGraphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_IgnoreReversedGraphics");
			GraphicRaycaster.NativeFieldInfoPtr_m_BlockingObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_BlockingObjects");
			GraphicRaycaster.NativeFieldInfoPtr_m_BlockingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_BlockingMask");
			GraphicRaycaster.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_Canvas");
			GraphicRaycaster.NativeFieldInfoPtr_m_RaycastResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_RaycastResults");
			GraphicRaycaster.NativeFieldInfoPtr_s_SortedGraphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "s_SortedGraphics");
			GraphicRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663582);
			GraphicRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663583);
			GraphicRaycaster.NativeMethodInfoPtr_get_ignoreReversedGraphics_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663584);
			GraphicRaycaster.NativeMethodInfoPtr_set_ignoreReversedGraphics_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663585);
			GraphicRaycaster.NativeMethodInfoPtr_get_blockingObjects_Public_get_BlockingObjects_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663586);
			GraphicRaycaster.NativeMethodInfoPtr_set_blockingObjects_Public_set_Void_BlockingObjects_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663587);
			GraphicRaycaster.NativeMethodInfoPtr_get_blockingMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663588);
			GraphicRaycaster.NativeMethodInfoPtr_set_blockingMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663589);
			GraphicRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663590);
			GraphicRaycaster.NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663591);
			GraphicRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663592);
			GraphicRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663593);
			GraphicRaycaster.NativeMethodInfoPtr_Raycast_Private_Static_Void_Canvas_Camera_Vector2_IList_1_Graphic_List_1_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663594);
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000D714 File Offset: 0x0000B914
		public unsafe override int sortOrderPriority
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519477, XrefRangeEnd = 519480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000D75C File Offset: 0x0000B95C
		public unsafe override int renderOrderPriority
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519480, XrefRangeEnd = 519483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		public unsafe bool ignoreReversedGraphics
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_ignoreReversedGraphics_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_set_ignoreReversedGraphics_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000D820 File Offset: 0x0000BA20
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0000D85C File Offset: 0x0000BA5C
		public unsafe GraphicRaycaster.BlockingObjects blockingObjects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_blockingObjects_Public_get_BlockingObjects_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_set_blockingObjects_Public_set_Void_BlockingObjects_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000D89C File Offset: 0x0000BA9C
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		public unsafe LayerMask blockingMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_blockingMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_set_blockingMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000D918 File Offset: 0x0000BB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519483, XrefRangeEnd = 519492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000D954 File Offset: 0x0000BB54
		public unsafe Canvas canvas
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 519507, RefRangeEnd = 519519, XrefRangeStart = 519492, XrefRangeEnd = 519507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000D994 File Offset: 0x0000BB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519519, XrefRangeEnd = 519707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultAppendList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
		public unsafe override Camera eventCamera
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519707, XrefRangeEnd = 519727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000DA40 File Offset: 0x0000BC40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 519802, RefRangeEnd = 519803, XrefRangeStart = 519727, XrefRangeEnd = 519802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foundGraphics);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_Raycast_Private_Static_Void_Canvas_Camera_Vector2_IList_1_Graphic_List_1_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000029E1 File Offset: 0x00000BE1
		public GraphicRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000DABC File Offset: 0x0000BCBC
		// (set) Token: 0x060001CA RID: 458 RVA: 0x000029EA File Offset: 0x00000BEA
		public unsafe static int kNoEventMaskSet
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		// (set) Token: 0x060001CC RID: 460 RVA: 0x000029F8 File Offset: 0x00000BF8
		public unsafe bool m_IgnoreReversedGraphics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_IgnoreReversedGraphics);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_IgnoreReversedGraphics)) = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000DB00 File Offset: 0x0000BD00
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002A13 File Offset: 0x00000C13
		public unsafe GraphicRaycaster.BlockingObjects m_BlockingObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingObjects)) = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000DB28 File Offset: 0x0000BD28
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002A2E File Offset: 0x00000C2E
		public unsafe LayerMask m_BlockingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingMask)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000DB50 File Offset: 0x0000BD50
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002A49 File Offset: 0x00000C49
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000DB80 File Offset: 0x0000BD80
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002A68 File Offset: 0x00000C68
		public unsafe List<Graphic> m_RaycastResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_RaycastResults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Graphic>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_RaycastResults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002A87 File Offset: 0x00000C87
		public unsafe static List<Graphic> s_SortedGraphics
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.NativeFieldInfoPtr_s_SortedGraphics, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Graphic>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.NativeFieldInfoPtr_s_SortedGraphics, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_kNoEventMaskSet;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreReversedGraphics;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_m_BlockingObjects;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_m_BlockingMask;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastResults;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_s_SortedGraphics;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreReversedGraphics_Public_get_Boolean_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreReversedGraphics_Public_set_Void_Boolean_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_get_blockingObjects_Public_get_BlockingObjects_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_set_blockingObjects_Public_set_Void_BlockingObjects_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_blockingMask_Public_get_LayerMask_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_set_blockingMask_Public_set_Void_LayerMask_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Private_Static_Void_Canvas_Camera_Vector2_IList_1_Graphic_List_1_Graphic_0;

		// Token: 0x02000080 RID: 128
		[OriginalName("UnityEngine.UI.dll", "", "BlockingObjects")]
		public enum BlockingObjects
		{
			// Token: 0x040008AF RID: 2223
			None,
			// Token: 0x040008B0 RID: 2224
			TwoD,
			// Token: 0x040008B1 RID: 2225
			ThreeD,
			// Token: 0x040008B2 RID: 2226
			All
		}

		// Token: 0x02000081 RID: 129
		[ObfuscatedName("UnityEngine.UI.GraphicRaycaster+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000B9D RID: 2973 RVA: 0x000331E0 File Offset: 0x000313E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr);
				GraphicRaycaster.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, "<>9");
				GraphicRaycaster.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, "<>9__27_0");
				GraphicRaycaster.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, 100663597);
				GraphicRaycaster.__c.NativeMethodInfoPtr__Raycast_b__27_0_Internal_Int32_Graphic_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, 100663598);
			}

			// Token: 0x06000B9E RID: 2974 RVA: 0x0003325C File Offset: 0x0003145C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B9F RID: 2975 RVA: 0x00033298 File Offset: 0x00031498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519471, XrefRangeEnd = 519477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Raycast_b__27_0(Graphic g1, Graphic g2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(g2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.__c.NativeMethodInfoPtr__Raycast_b__27_0_Internal_Int32_Graphic_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000BA0 RID: 2976 RVA: 0x00006471 File Offset: 0x00004671
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x000332F8 File Offset: 0x000314F8
			// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x0000647A File Offset: 0x0000467A
			public unsafe static GraphicRaycaster.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00033320 File Offset: 0x00031520
			// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x0000648C File Offset: 0x0000468C
			public unsafe static Comparison<Graphic> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Graphic>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008B3 RID: 2227
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040008B4 RID: 2228
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x040008B5 RID: 2229
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040008B6 RID: 2230
			private static readonly IntPtr NativeMethodInfoPtr__Raycast_b__27_0_Internal_Int32_Graphic_Graphic_0;
		}
	}
}
