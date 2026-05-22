using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	// Token: 0x0200002B RID: 43
	public class MaskableGraphic : Graphic
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x0001A3B8 File Offset: 0x000185B8
		// Note: this type is marked as 'beforefieldinit'.
		static MaskableGraphic()
		{
			Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "MaskableGraphic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr);
			MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculateStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_ShouldRecalculateStencil");
			MaskableGraphic.NativeFieldInfoPtr_m_MaskMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_MaskMaterial");
			MaskableGraphic.NativeFieldInfoPtr_m_ParentMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_ParentMask");
			MaskableGraphic.NativeFieldInfoPtr_m_Maskable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_Maskable");
			MaskableGraphic.NativeFieldInfoPtr_m_IsMaskingGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_IsMaskingGraphic");
			MaskableGraphic.NativeFieldInfoPtr_m_IncludeForMasking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_IncludeForMasking");
			MaskableGraphic.NativeFieldInfoPtr_m_OnCullStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_OnCullStateChanged");
			MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_ShouldRecalculate");
			MaskableGraphic.NativeFieldInfoPtr_m_StencilValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_StencilValue");
			MaskableGraphic.NativeFieldInfoPtr_m_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_Corners");
			MaskableGraphic.NativeMethodInfoPtr_get_onCullStateChanged_Public_get_CullStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664126);
			MaskableGraphic.NativeMethodInfoPtr_set_onCullStateChanged_Public_set_Void_CullStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664127);
			MaskableGraphic.NativeMethodInfoPtr_get_maskable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664128);
			MaskableGraphic.NativeMethodInfoPtr_set_maskable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664129);
			MaskableGraphic.NativeMethodInfoPtr_get_isMaskingGraphic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664130);
			MaskableGraphic.NativeMethodInfoPtr_set_isMaskingGraphic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664131);
			MaskableGraphic.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664132);
			MaskableGraphic.NativeMethodInfoPtr_Cull_Public_Virtual_New_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664133);
			MaskableGraphic.NativeMethodInfoPtr_UpdateCull_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664134);
			MaskableGraphic.NativeMethodInfoPtr_SetClipRect_Public_Virtual_New_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664135);
			MaskableGraphic.NativeMethodInfoPtr_SetClipSoftness_Public_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664136);
			MaskableGraphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664137);
			MaskableGraphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664138);
			MaskableGraphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664139);
			MaskableGraphic.NativeMethodInfoPtr_ParentMaskStateChanged_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664140);
			MaskableGraphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664141);
			MaskableGraphic.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664142);
			MaskableGraphic.NativeMethodInfoPtr_UpdateClipParent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664143);
			MaskableGraphic.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664144);
			MaskableGraphic.NativeMethodInfoPtr_RecalculateMasking_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664145);
			MaskableGraphic.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664146);
			MaskableGraphic.NativeMethodInfoPtr_UnityEngine_UI_IClippable_get_gameObject_Private_Virtual_Final_New_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664147);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0001A668 File Offset: 0x00018868
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x0001A6A8 File Offset: 0x000188A8
		public unsafe MaskableGraphic.CullStateChangedEvent onCullStateChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_onCullStateChanged_Public_get_CullStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MaskableGraphic.CullStateChangedEvent>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 386301, RefRangeEnd = 386305, XrefRangeStart = 386301, XrefRangeEnd = 386305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_set_onCullStateChanged_Public_set_Void_CullStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0001A6EC File Offset: 0x000188EC
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x0001A728 File Offset: 0x00018928
		public unsafe bool maskable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_maskable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_set_maskable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0001A768 File Offset: 0x00018968
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x0001A7A4 File Offset: 0x000189A4
		public unsafe bool isMaskingGraphic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_isMaskingGraphic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_set_isMaskingGraphic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001A7E4 File Offset: 0x000189E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525551, XrefRangeEnd = 525564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0001A840 File Offset: 0x00018A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525564, XrefRangeEnd = 525568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cull(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_Cull_Public_Virtual_New_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0001A898 File Offset: 0x00018A98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 525581, RefRangeEnd = 525584, XrefRangeStart = 525568, XrefRangeEnd = 525581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCull(bool cull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_UpdateCull_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525584, XrefRangeEnd = 525590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetClipRect(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_SetClipRect_Public_Virtual_New_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0001A930 File Offset: 0x00018B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525590, XrefRangeEnd = 525593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetClipSoftness(Vector2 clipSoftness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipSoftness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_SetClipSoftness_Public_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001A97C File Offset: 0x00018B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525593, XrefRangeEnd = 525596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001A9B8 File Offset: 0x00018BB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 525603, RefRangeEnd = 525606, XrefRangeStart = 525596, XrefRangeEnd = 525603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0001A9F4 File Offset: 0x00018BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525606, XrefRangeEnd = 525615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001AA30 File Offset: 0x00018C30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ParentMaskStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_ParentMaskStateChanged_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0001AA6C File Offset: 0x00018C6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 525619, RefRangeEnd = 525621, XrefRangeStart = 525615, XrefRangeEnd = 525619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001AAA8 File Offset: 0x00018CA8
		public unsafe Rect rootCanvasRect
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 525637, RefRangeEnd = 525638, XrefRangeStart = 525621, XrefRangeEnd = 525637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0001AAE4 File Offset: 0x00018CE4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 525682, RefRangeEnd = 525692, XrefRangeStart = 525638, XrefRangeEnd = 525682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateClipParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_UpdateClipParent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001AB18 File Offset: 0x00018D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecalculateClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001AB54 File Offset: 0x00018D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525692, XrefRangeEnd = 525696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecalculateMasking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_RecalculateMasking_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001AB90 File Offset: 0x00018D90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 525715, RefRangeEnd = 525721, XrefRangeStart = 525696, XrefRangeEnd = 525715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaskableGraphic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0001ABCC File Offset: 0x00018DCC
		public unsafe virtual GameObject UnityEngine.UI.IClippable.gameObject
		{
			[CallerCount(197)]
			[CachedScanResults(RefRangeStart = 494113, RefRangeEnd = 494310, XrefRangeStart = 494113, XrefRangeEnd = 494310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_UnityEngine_UI_IClippable_get_gameObject_Private_Virtual_Final_New_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00003B02 File Offset: 0x00001D02
		public MaskableGraphic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0001AC0C File Offset: 0x00018E0C
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00003B0B File Offset: 0x00001D0B
		public unsafe bool m_ShouldRecalculateStencil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculateStencil);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculateStencil)) = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0001AC34 File Offset: 0x00018E34
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00003B26 File Offset: 0x00001D26
		public unsafe Material m_MaskMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_MaskMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_MaskMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0001AC64 File Offset: 0x00018E64
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00003B45 File Offset: 0x00001D45
		public unsafe RectMask2D m_ParentMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ParentMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectMask2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ParentMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0001AC94 File Offset: 0x00018E94
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00003B64 File Offset: 0x00001D64
		public unsafe bool m_Maskable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Maskable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Maskable)) = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001ACBC File Offset: 0x00018EBC
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00003B7F File Offset: 0x00001D7F
		public unsafe bool m_IsMaskingGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IsMaskingGraphic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IsMaskingGraphic)) = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001ACE4 File Offset: 0x00018EE4
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00003B9A File Offset: 0x00001D9A
		public unsafe bool m_IncludeForMasking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IncludeForMasking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IncludeForMasking)) = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0001AD0C File Offset: 0x00018F0C
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00003BB5 File Offset: 0x00001DB5
		public unsafe MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_OnCullStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskableGraphic.CullStateChangedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_OnCullStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0001AD3C File Offset: 0x00018F3C
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00003BD4 File Offset: 0x00001DD4
		public unsafe bool m_ShouldRecalculate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculate)) = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0001AD64 File Offset: 0x00018F64
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00003BEF File Offset: 0x00001DEF
		public unsafe int m_StencilValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_StencilValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_StencilValue)) = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0001AD8C File Offset: 0x00018F8C
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00003C0A File Offset: 0x00001E0A
		public unsafe Il2CppStructArray<Vector3> m_Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRecalculateStencil;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskMaterial;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentMask;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeFieldInfoPtr_m_Maskable;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeFieldInfoPtr_m_IsMaskingGraphic;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeFieldInfoPtr_m_IncludeForMasking;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_m_OnCullStateChanged;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRecalculate;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_m_StencilValue;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_m_Corners;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_get_onCullStateChanged_Public_get_CullStateChangedEvent_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_set_onCullStateChanged_Public_set_Void_CullStateChangedEvent_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_get_maskable_Public_get_Boolean_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_set_maskable_Public_set_Void_Boolean_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_get_isMaskingGraphic_Public_get_Boolean_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_set_isMaskingGraphic_Public_set_Void_Boolean_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_Virtual_New_Void_Rect_Boolean_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCull_Private_Void_Boolean_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_SetClipRect_Public_Virtual_New_Void_Rect_Boolean_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_SetClipSoftness_Public_Virtual_New_Void_Vector2_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_ParentMaskStateChanged_Public_Virtual_New_Void_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClipParent_Private_Void_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_New_Void_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateMasking_Public_Virtual_New_Void_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_IClippable_get_gameObject_Private_Virtual_Final_New_get_GameObject_0;

		// Token: 0x0200009F RID: 159
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool>
		{
			// Token: 0x06000C13 RID: 3091 RVA: 0x000067AD File Offset: 0x000049AD
			// Note: this type is marked as 'beforefieldinit'.
			static CullStateChangedEvent()
			{
				Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "CullStateChangedEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr);
				MaskableGraphic.CullStateChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr, 100664148);
			}

			// Token: 0x06000C14 RID: 3092 RVA: 0x000348AC File Offset: 0x00032AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525549, XrefRangeEnd = 525551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CullStateChangedEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.CullStateChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C15 RID: 3093 RVA: 0x000067E1 File Offset: 0x000049E1
			public CullStateChangedEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400095A RID: 2394
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
