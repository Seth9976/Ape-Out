using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x02000048 RID: 72
	[Serializable]
	public class TouchControl : CustomControllerControl
	{
		// Token: 0x060005BD RID: 1469 RVA: 0x000439B8 File Offset: 0x00041BB8
		// Note: this type is marked as 'beforefieldinit'.
		static TouchControl()
		{
			Il2CppClassPointerStore<TouchControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "TouchControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchControl>.NativeClassPtr);
			TouchControl.NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, "_canvas");
			TouchControl.NativeFieldInfoPtr___rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, "__rectTransform");
			TouchControl.NativeMethodInfoPtr_get_touchController_Internal_get_TouchController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664260);
			TouchControl.NativeMethodInfoPtr_get_canvas_Internal_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664261);
			TouchControl.NativeMethodInfoPtr_get_canvasTransform_Internal_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664262);
			TouchControl.NativeMethodInfoPtr_get_rectTransform_Internal_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664263);
			TouchControl.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664264);
			TouchControl.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664265);
			TouchControl.NativeMethodInfoPtr_OnCanvasGroupChanged_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664266);
			TouchControl.NativeMethodInfoPtr_OnTransformParentChanged_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664267);
			TouchControl.NativeMethodInfoPtr_get_hasController_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664268);
			TouchControl.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664269);
			TouchControl.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664270);
			TouchControl.NativeMethodInfoPtr_FindController_Internal_Virtual_IComponentController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664271);
			TouchControl.NativeMethodInfoPtr_GetRequiredControllerType_Internal_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664272);
			TouchControl.NativeMethodInfoPtr_bJGcSKFfswQsFOMCCKwvAFvSIyET_Private_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControl>.NativeClassPtr, 100664273);
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00043B28 File Offset: 0x00041D28
		public unsafe TouchController touchController
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246163, XrefRangeEnd = 246165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_get_touchController_Internal_get_TouchController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchController>(intPtr3) : null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00043B68 File Offset: 0x00041D68
		public unsafe Canvas canvas
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_get_canvas_Internal_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00043BA8 File Offset: 0x00041DA8
		public unsafe RectTransform canvasTransform
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 246181, RefRangeEnd = 246184, XrefRangeStart = 246165, XrefRangeEnd = 246181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_get_canvasTransform_Internal_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00043BE8 File Offset: 0x00041DE8
		public unsafe RectTransform rectTransform
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 246187, RefRangeEnd = 246203, XrefRangeStart = 246184, XrefRangeEnd = 246187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_get_rectTransform_Internal_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00043C28 File Offset: 0x00041E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00043C64 File Offset: 0x00041E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246203, XrefRangeEnd = 246205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00043CA0 File Offset: 0x00041EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246205, XrefRangeEnd = 246207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasGroupChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_OnCanvasGroupChanged_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00043CDC File Offset: 0x00041EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_OnTransformParentChanged_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00043D18 File Offset: 0x00041F18
		public unsafe override bool hasController
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246207, XrefRangeEnd = 246221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_get_hasController_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00043D60 File Offset: 0x00041F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246221, XrefRangeEnd = 246223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool nSRkgireMOAkpBoLMmrDfIispUMG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00043DA8 File Offset: 0x00041FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246223, XrefRangeEnd = 246225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00043DE4 File Offset: 0x00041FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246225, XrefRangeEnd = 246235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IComponentController FindController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_FindController_Internal_Virtual_IComponentController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComponentController>(intPtr3) : null;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00043E30 File Offset: 0x00042030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246235, XrefRangeEnd = 246241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetRequiredControllerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchControl.NativeMethodInfoPtr_GetRequiredControllerType_Internal_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00043E7C File Offset: 0x0004207C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 246287, RefRangeEnd = 246301, XrefRangeStart = 246241, XrefRangeEnd = 246287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe bool bJGcSKFfswQsFOMCCKwvAFvSIyET(bool A_1, bool A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchControl.NativeMethodInfoPtr_bJGcSKFfswQsFOMCCKwvAFvSIyET_Private_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00003D69 File Offset: 0x00001F69
		public TouchControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00043ED4 File Offset: 0x000420D4
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00003D72 File Offset: 0x00001F72
		public unsafe Canvas _canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchControl.NativeFieldInfoPtr__canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchControl.NativeFieldInfoPtr__canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00043F04 File Offset: 0x00042104
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00003D91 File Offset: 0x00001F91
		public unsafe RectTransform __rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchControl.NativeFieldInfoPtr___rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchControl.NativeFieldInfoPtr___rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr__canvas;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr___rectTransform;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_get_touchController_Internal_get_TouchController_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_get_canvas_Internal_get_Canvas_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_get_canvasTransform_Internal_get_RectTransform_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Internal_get_RectTransform_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasGroupChanged_Internal_Virtual_Void_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Internal_Virtual_Void_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_get_hasController_Internal_Virtual_get_Boolean_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_FindController_Internal_Virtual_IComponentController_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredControllerType_Internal_Virtual_Type_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_bJGcSKFfswQsFOMCCKwvAFvSIyET_Private_Boolean_Boolean_Boolean_0;
	}
}
