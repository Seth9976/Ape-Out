using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000031 RID: 49
	public class RectMask2D : UIBehaviour
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x0001BA10 File Offset: 0x00019C10
		// Note: this type is marked as 'beforefieldinit'.
		static RectMask2D()
		{
			Il2CppClassPointerStore<RectMask2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "RectMask2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr);
			RectMask2D.NativeFieldInfoPtr_m_VertexClipper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_VertexClipper");
			RectMask2D.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_RectTransform");
			RectMask2D.NativeFieldInfoPtr_m_MaskableTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_MaskableTargets");
			RectMask2D.NativeFieldInfoPtr_m_ClipTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_ClipTargets");
			RectMask2D.NativeFieldInfoPtr_m_ShouldRecalculateClipRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_ShouldRecalculateClipRects");
			RectMask2D.NativeFieldInfoPtr_m_Clippers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Clippers");
			RectMask2D.NativeFieldInfoPtr_m_LastClipRectCanvasSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_LastClipRectCanvasSpace");
			RectMask2D.NativeFieldInfoPtr_m_ForceClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_ForceClip");
			RectMask2D.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Padding");
			RectMask2D.NativeFieldInfoPtr_m_Softness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Softness");
			RectMask2D.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Canvas");
			RectMask2D.NativeFieldInfoPtr_m_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Corners");
			RectMask2D.NativeMethodInfoPtr_get_padding_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664177);
			RectMask2D.NativeMethodInfoPtr_set_padding_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664178);
			RectMask2D.NativeMethodInfoPtr_get_softness_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664179);
			RectMask2D.NativeMethodInfoPtr_set_softness_Public_set_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664180);
			RectMask2D.NativeMethodInfoPtr_get_Canvas_Internal_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664181);
			RectMask2D.NativeMethodInfoPtr_get_canvasRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664182);
			RectMask2D.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664183);
			RectMask2D.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664184);
			RectMask2D.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664185);
			RectMask2D.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664186);
			RectMask2D.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664187);
			RectMask2D.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664188);
			RectMask2D.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664189);
			RectMask2D.NativeMethodInfoPtr_PerformClipping_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664190);
			RectMask2D.NativeMethodInfoPtr_UpdateClipSoftness_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664191);
			RectMask2D.NativeMethodInfoPtr_AddClippable_Public_Void_IClippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664192);
			RectMask2D.NativeMethodInfoPtr_RemoveClippable_Public_Void_IClippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664193);
			RectMask2D.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664194);
			RectMask2D.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664195);
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0001BCAC File Offset: 0x00019EAC
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x0001BCE8 File Offset: 0x00019EE8
		public unsafe Vector4 padding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_padding_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525946, XrefRangeEnd = 525947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_set_padding_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0001BD28 File Offset: 0x00019F28
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0001BD64 File Offset: 0x00019F64
		public unsafe Vector2Int softness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_softness_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525947, XrefRangeEnd = 525948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_set_softness_Public_set_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0001BDA4 File Offset: 0x00019FA4
		public unsafe Canvas Canvas
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 525980, RefRangeEnd = 525988, XrefRangeStart = 525948, XrefRangeEnd = 525980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_Canvas_Internal_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0001BDE4 File Offset: 0x00019FE4
		public unsafe Rect canvasRect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525988, XrefRangeEnd = 525991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_canvasRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0001BE20 File Offset: 0x0001A020
		public unsafe RectTransform rectTransform
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 525994, RefRangeEnd = 525999, XrefRangeStart = 525991, XrefRangeEnd = 525994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0001BE60 File Offset: 0x0001A060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525999, XrefRangeEnd = 526029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectMask2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0001BE9C File Offset: 0x0001A09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526029, XrefRangeEnd = 526035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0001BED8 File Offset: 0x0001A0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526035, XrefRangeEnd = 526049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0001BF14 File Offset: 0x0001A114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0001BF50 File Offset: 0x0001A150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526049, XrefRangeEnd = 526056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0001BFB8 File Offset: 0x0001A1B8
		public unsafe Rect rootCanvasRect
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 526066, RefRangeEnd = 526067, XrefRangeStart = 526056, XrefRangeEnd = 526066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526067, XrefRangeEnd = 526117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PerformClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_PerformClipping_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0001C030 File Offset: 0x0001A230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526117, XrefRangeEnd = 526138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateClipSoftness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_UpdateClipSoftness_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0001C06C File Offset: 0x0001A26C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 526158, RefRangeEnd = 526159, XrefRangeStart = 526138, XrefRangeEnd = 526158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClippable(IClippable clippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clippable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_AddClippable_Public_Void_IClippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 526182, RefRangeEnd = 526183, XrefRangeStart = 526159, XrefRangeEnd = 526182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveClippable(IClippable clippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clippable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_RemoveClippable_Public_Void_IClippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0001C0F4 File Offset: 0x0001A2F4
		[CallerCount(0)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0001C130 File Offset: 0x0001A330
		[CallerCount(0)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00003D83 File Offset: 0x00001F83
		public RectMask2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0001C16C File Offset: 0x0001A36C
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00003D8C File Offset: 0x00001F8C
		public unsafe RectangularVertexClipper m_VertexClipper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_VertexClipper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectangularVertexClipper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_VertexClipper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0001C19C File Offset: 0x0001A39C
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00003DAB File Offset: 0x00001FAB
		public unsafe RectTransform m_RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0001C1CC File Offset: 0x0001A3CC
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00003DCA File Offset: 0x00001FCA
		public unsafe HashSet<MaskableGraphic> m_MaskableTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_MaskableTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<MaskableGraphic>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_MaskableTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0001C1FC File Offset: 0x0001A3FC
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00003DE9 File Offset: 0x00001FE9
		public unsafe HashSet<IClippable> m_ClipTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ClipTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IClippable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ClipTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0001C22C File Offset: 0x0001A42C
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00003E08 File Offset: 0x00002008
		public unsafe bool m_ShouldRecalculateClipRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ShouldRecalculateClipRects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ShouldRecalculateClipRects)) = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0001C254 File Offset: 0x0001A454
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00003E23 File Offset: 0x00002023
		public unsafe List<RectMask2D> m_Clippers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Clippers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectMask2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Clippers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0001C284 File Offset: 0x0001A484
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00003E42 File Offset: 0x00002042
		public unsafe Rect m_LastClipRectCanvasSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_LastClipRectCanvasSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_LastClipRectCanvasSpace)) = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0001C2AC File Offset: 0x0001A4AC
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00003E5D File Offset: 0x0000205D
		public unsafe bool m_ForceClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ForceClip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ForceClip)) = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0001C2D4 File Offset: 0x0001A4D4
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00003E78 File Offset: 0x00002078
		public unsafe Vector4 m_Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Padding)) = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0001C2FC File Offset: 0x0001A4FC
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00003E93 File Offset: 0x00002093
		public unsafe Vector2Int m_Softness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Softness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Softness)) = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0001C324 File Offset: 0x0001A524
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00003EAE File Offset: 0x000020AE
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0001C354 File Offset: 0x0001A554
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00003ECD File Offset: 0x000020CD
		public unsafe Il2CppStructArray<Vector3> m_Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr_m_VertexClipper;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskableTargets;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipTargets;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRecalculateClipRects;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_m_Clippers;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr_m_LastClipRectCanvasSpace;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceClip;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr_m_Softness;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr_m_Corners;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_get_padding_Public_get_Vector4_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_set_padding_Public_set_Void_Vector4_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_get_softness_Public_get_Vector2Int_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_set_softness_Public_set_Void_Vector2Int_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_get_Canvas_Internal_get_Canvas_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_get_canvasRect_Public_get_Rect_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_PerformClipping_Public_Virtual_New_Void_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClipSoftness_Public_Virtual_New_Void_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_AddClippable_Public_Void_IClippable_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_RemoveClippable_Public_Void_IClippable_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;
	}
}
