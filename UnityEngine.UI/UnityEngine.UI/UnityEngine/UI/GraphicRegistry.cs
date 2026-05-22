using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000013 RID: 19
	public class GraphicRegistry : Object
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicRegistry()
		{
			Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "GraphicRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr);
			GraphicRegistry.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "s_Instance");
			GraphicRegistry.NativeFieldInfoPtr_m_Graphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "m_Graphics");
			GraphicRegistry.NativeFieldInfoPtr_m_RaycastableGraphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "m_RaycastableGraphics");
			GraphicRegistry.NativeFieldInfoPtr_s_EmptyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "s_EmptyList");
			GraphicRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663599);
			GraphicRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663600);
			GraphicRegistry.NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663601);
			GraphicRegistry.NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663602);
			GraphicRegistry.NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663603);
			GraphicRegistry.NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663604);
			GraphicRegistry.NativeMethodInfoPtr_DisableGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663605);
			GraphicRegistry.NativeMethodInfoPtr_DisableRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663606);
			GraphicRegistry.NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663607);
			GraphicRegistry.NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663608);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000DD20 File Offset: 0x0000BF20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 519830, RefRangeEnd = 519831, XrefRangeStart = 519803, XrefRangeEnd = 519830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000DD5C File Offset: 0x0000BF5C
		public unsafe static GraphicRegistry instance
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 519843, RefRangeEnd = 519858, XrefRangeStart = 519831, XrefRangeEnd = 519843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicRegistry>(intPtr3) : null;
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000DD90 File Offset: 0x0000BF90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 519904, RefRangeEnd = 519910, XrefRangeStart = 519858, XrefRangeEnd = 519904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 519955, RefRangeEnd = 519958, XrefRangeStart = 519910, XrefRangeEnd = 519955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000DE20 File Offset: 0x0000C020
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 520002, RefRangeEnd = 520008, XrefRangeStart = 519958, XrefRangeEnd = 520002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000DE68 File Offset: 0x0000C068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 520048, RefRangeEnd = 520050, XrefRangeStart = 520008, XrefRangeEnd = 520048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520082, RefRangeEnd = 520083, XrefRangeStart = 520050, XrefRangeEnd = 520082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_DisableGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000DEF8 File Offset: 0x0000C0F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520112, RefRangeEnd = 520113, XrefRangeStart = 520083, XrefRangeEnd = 520112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_DisableRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000DF40 File Offset: 0x0000C140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520113, XrefRangeEnd = 520122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<Graphic> GetGraphicsForCanvas(Canvas canvas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Graphic>>(intPtr3) : null;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000DF84 File Offset: 0x0000C184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520122, XrefRangeEnd = 520131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Graphic>>(intPtr3) : null;
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002A99 File Offset: 0x00000C99
		public GraphicRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002AA2 File Offset: 0x00000CA2
		public unsafe static GraphicRegistry s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicRegistry.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRegistry.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000DFF0 File Offset: 0x0000C1F0
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002AB4 File Offset: 0x00000CB4
		public unsafe Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_Graphics);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Canvas, IndexedSet<Graphic>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_Graphics), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000E020 File Offset: 0x0000C220
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002AD3 File Offset: 0x00000CD3
		public unsafe Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_RaycastableGraphics);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Canvas, IndexedSet<Graphic>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_RaycastableGraphics), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000E050 File Offset: 0x0000C250
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002AF2 File Offset: 0x00000CF2
		public unsafe static List<Graphic> s_EmptyList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicRegistry.NativeFieldInfoPtr_s_EmptyList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Graphic>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRegistry.NativeFieldInfoPtr_s_EmptyList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_m_Graphics;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastableGraphics;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyList;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_DisableGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_DisableRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0;
	}
}
