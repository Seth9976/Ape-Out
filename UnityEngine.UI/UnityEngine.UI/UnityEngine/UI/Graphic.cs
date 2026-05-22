using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x02000011 RID: 17
	public class Graphic : UIBehaviour
	{
		// Token: 0x0600014E RID: 334 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		// Note: this type is marked as 'beforefieldinit'.
		static Graphic()
		{
			Il2CppClassPointerStore<Graphic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Graphic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Graphic>.NativeClassPtr);
			Graphic.NativeFieldInfoPtr_s_DefaultUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_DefaultUI");
			Graphic.NativeFieldInfoPtr_s_WhiteTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_WhiteTexture");
			Graphic.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_Material");
			Graphic.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_Color");
			Graphic.NativeFieldInfoPtr_m_SkipLayoutUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_SkipLayoutUpdate");
			Graphic.NativeFieldInfoPtr_m_SkipMaterialUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_SkipMaterialUpdate");
			Graphic.NativeFieldInfoPtr_m_RaycastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_RaycastTarget");
			Graphic.NativeFieldInfoPtr_m_RaycastTargetCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_RaycastTargetCache");
			Graphic.NativeFieldInfoPtr_m_RaycastPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_RaycastPadding");
			Graphic.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_RectTransform");
			Graphic.NativeFieldInfoPtr_m_CanvasRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_CanvasRenderer");
			Graphic.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_Canvas");
			Graphic.NativeFieldInfoPtr_m_VertsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_VertsDirty");
			Graphic.NativeFieldInfoPtr_m_MaterialDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_MaterialDirty");
			Graphic.NativeFieldInfoPtr_m_OnDirtyLayoutCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_OnDirtyLayoutCallback");
			Graphic.NativeFieldInfoPtr_m_OnDirtyVertsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_OnDirtyVertsCallback");
			Graphic.NativeFieldInfoPtr_m_OnDirtyMaterialCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_OnDirtyMaterialCallback");
			Graphic.NativeFieldInfoPtr_s_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_Mesh");
			Graphic.NativeFieldInfoPtr_s_VertexHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_VertexHelper");
			Graphic.NativeFieldInfoPtr_m_CachedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_CachedMesh");
			Graphic.NativeFieldInfoPtr_m_CachedUvs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_CachedUvs");
			Graphic.NativeFieldInfoPtr_m_ColorTweenRunner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_ColorTweenRunner");
			Graphic.NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "<useLegacyMeshGeneration>k__BackingField");
			Graphic.NativeMethodInfoPtr_get_defaultGraphicMaterial_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663521);
			Graphic.NativeMethodInfoPtr_get_color_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663522);
			Graphic.NativeMethodInfoPtr_set_color_Public_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663523);
			Graphic.NativeMethodInfoPtr_get_raycastTarget_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663524);
			Graphic.NativeMethodInfoPtr_set_raycastTarget_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663525);
			Graphic.NativeMethodInfoPtr_get_raycastPadding_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663526);
			Graphic.NativeMethodInfoPtr_set_raycastPadding_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663527);
			Graphic.NativeMethodInfoPtr_get_useLegacyMeshGeneration_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663528);
			Graphic.NativeMethodInfoPtr_set_useLegacyMeshGeneration_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663529);
			Graphic.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663530);
			Graphic.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663531);
			Graphic.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663532);
			Graphic.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663533);
			Graphic.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663534);
			Graphic.NativeMethodInfoPtr_SetRaycastDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663535);
			Graphic.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663536);
			Graphic.NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663537);
			Graphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663538);
			Graphic.NativeMethodInfoPtr_get_depth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663539);
			Graphic.NativeMethodInfoPtr_get_rectTransform_Public_Virtual_Final_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663540);
			Graphic.NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663541);
			Graphic.NativeMethodInfoPtr_CacheCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663542);
			Graphic.NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663543);
			Graphic.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663544);
			Graphic.NativeMethodInfoPtr_get_material_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663545);
			Graphic.NativeMethodInfoPtr_set_material_Public_Virtual_New_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663546);
			Graphic.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663547);
			Graphic.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_New_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663548);
			Graphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663549);
			Graphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663550);
			Graphic.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663551);
			Graphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663552);
			Graphic.NativeMethodInfoPtr_OnCullingChanged_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663553);
			Graphic.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663554);
			Graphic.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663555);
			Graphic.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663556);
			Graphic.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663557);
			Graphic.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663558);
			Graphic.NativeMethodInfoPtr_DoMeshGeneration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663559);
			Graphic.NativeMethodInfoPtr_DoLegacyMeshGeneration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663560);
			Graphic.NativeMethodInfoPtr_get_workerMesh_Protected_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663561);
			Graphic.NativeMethodInfoPtr_OnFillVBO_Protected_Virtual_New_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663562);
			Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663563);
			Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663564);
			Graphic.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663565);
			Graphic.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663566);
			Graphic.NativeMethodInfoPtr_Raycast_Public_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663567);
			Graphic.NativeMethodInfoPtr_PixelAdjustPoint_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663568);
			Graphic.NativeMethodInfoPtr_GetPixelAdjustedRect_Public_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663569);
			Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663570);
			Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663571);
			Graphic.NativeMethodInfoPtr_CreateColorFromAlpha_Private_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663572);
			Graphic.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_New_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663573);
			Graphic.NativeMethodInfoPtr_RegisterDirtyLayoutCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663574);
			Graphic.NativeMethodInfoPtr_UnregisterDirtyLayoutCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663575);
			Graphic.NativeMethodInfoPtr_RegisterDirtyVerticesCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663576);
			Graphic.NativeMethodInfoPtr_UnregisterDirtyVerticesCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663577);
			Graphic.NativeMethodInfoPtr_RegisterDirtyMaterialCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663578);
			Graphic.NativeMethodInfoPtr_UnregisterDirtyMaterialCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663579);
			Graphic.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663581);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000C180 File Offset: 0x0000A380
		public unsafe static Material defaultGraphicMaterial
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 518547, RefRangeEnd = 518553, XrefRangeStart = 518523, XrefRangeEnd = 518547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_defaultGraphicMaterial_Public_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		// (set) Token: 0x06000151 RID: 337 RVA: 0x0000C1FC File Offset: 0x0000A3FC
		public unsafe virtual Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_color_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_set_color_Public_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000C248 File Offset: 0x0000A448
		// (set) Token: 0x06000153 RID: 339 RVA: 0x0000C290 File Offset: 0x0000A490
		public unsafe virtual bool raycastTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_raycastTarget_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518553, XrefRangeEnd = 518564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_set_raycastTarget_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000C318 File Offset: 0x0000A518
		public unsafe Vector4 raycastPadding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_raycastPadding_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_set_raycastPadding_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000C358 File Offset: 0x0000A558
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000C394 File Offset: 0x0000A594
		public unsafe bool useLegacyMeshGeneration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_useLegacyMeshGeneration_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_set_useLegacyMeshGeneration_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518564, XrefRangeEnd = 518572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Graphic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Graphic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000C410 File Offset: 0x0000A610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518572, XrefRangeEnd = 518575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAllDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000C44C File Offset: 0x0000A64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518575, XrefRangeEnd = 518581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000C488 File Offset: 0x0000A688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518581, XrefRangeEnd = 518586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVerticesDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518586, XrefRangeEnd = 518591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000C500 File Offset: 0x0000A700
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 518598, RefRangeEnd = 518601, XrefRangeStart = 518591, XrefRangeEnd = 518598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRaycastDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_SetRaycastDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000C534 File Offset: 0x0000A734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518601, XrefRangeEnd = 518609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000C570 File Offset: 0x0000A770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518609, XrefRangeEnd = 518619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000C5AC File Offset: 0x0000A7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518619, XrefRangeEnd = 518625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		public unsafe int depth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 518631, RefRangeEnd = 518633, XrefRangeStart = 518625, XrefRangeEnd = 518631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_depth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000C624 File Offset: 0x0000A824
		public unsafe virtual RectTransform rectTransform
		{
			[CallerCount(59)]
			[CachedScanResults(RefRangeStart = 518636, RefRangeEnd = 518695, XrefRangeStart = 518633, XrefRangeEnd = 518636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_rectTransform_Public_Virtual_Final_New_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000C664 File Offset: 0x0000A864
		public unsafe Canvas canvas
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 518708, RefRangeEnd = 518752, XrefRangeStart = 518695, XrefRangeEnd = 518708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 518782, RefRangeEnd = 518788, XrefRangeStart = 518752, XrefRangeEnd = 518782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_CacheCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		public unsafe CanvasRenderer canvasRenderer
		{
			[CallerCount(47)]
			[CachedScanResults(RefRangeStart = 518797, RefRangeEnd = 518844, XrefRangeStart = 518788, XrefRangeEnd = 518797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr3) : null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000C718 File Offset: 0x0000A918
		public unsafe virtual Material defaultMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518844, XrefRangeEnd = 518848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000C764 File Offset: 0x0000A964
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		public unsafe virtual Material material
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518848, XrefRangeEnd = 518860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_material_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 518876, RefRangeEnd = 518877, XrefRangeStart = 518860, XrefRangeEnd = 518876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_set_material_Public_Virtual_New_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000C800 File Offset: 0x0000AA00
		public unsafe virtual Material materialForRendering
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518877, XrefRangeEnd = 518909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000C84C File Offset: 0x0000AA4C
		public unsafe virtual Texture mainTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518909, XrefRangeEnd = 518913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_New_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000C898 File Offset: 0x0000AA98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 518942, RefRangeEnd = 518945, XrefRangeStart = 518913, XrefRangeEnd = 518942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 518978, RefRangeEnd = 518979, XrefRangeStart = 518945, XrefRangeEnd = 518978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000C910 File Offset: 0x0000AB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518979, XrefRangeEnd = 518995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000C94C File Offset: 0x0000AB4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 519023, RefRangeEnd = 519024, XrefRangeStart = 518995, XrefRangeEnd = 519023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000C988 File Offset: 0x0000AB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519024, XrefRangeEnd = 519031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCullingChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnCullingChanged_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519031, XrefRangeEnd = 519047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000CA10 File Offset: 0x0000AC10
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000CA88 File Offset: 0x0000AC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519047, XrefRangeEnd = 519056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000CAC4 File Offset: 0x0000ACC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519056, XrefRangeEnd = 519057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000CB00 File Offset: 0x0000AD00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 519134, RefRangeEnd = 519135, XrefRangeStart = 519057, XrefRangeEnd = 519134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoMeshGeneration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_DoMeshGeneration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000CB34 File Offset: 0x0000AD34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 519212, RefRangeEnd = 519213, XrefRangeStart = 519135, XrefRangeEnd = 519212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoLegacyMeshGeneration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_DoLegacyMeshGeneration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000CB68 File Offset: 0x0000AD68
		public unsafe static Mesh workerMesh
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 519246, RefRangeEnd = 519252, XrefRangeStart = 519213, XrefRangeEnd = 519246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_workerMesh_Protected_Static_get_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnFillVBO(List<UIVertex> vbo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vbo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnFillVBO_Protected_Virtual_New_Void_List_1_UIVertex_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519252, XrefRangeEnd = 519259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPopulateMesh(Mesh m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000CC3C File Offset: 0x0000AE3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 519268, RefRangeEnd = 519269, XrefRangeStart = 519259, XrefRangeEnd = 519268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPopulateMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		[CallerCount(0)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000CCC8 File Offset: 0x0000AEC8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNativeSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000CD04 File Offset: 0x0000AF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519269, XrefRangeEnd = 519343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Raycast(Vector2 sp, Camera eventCamera)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_Raycast_Public_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000CD6C File Offset: 0x0000AF6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 519367, RefRangeEnd = 519369, XrefRangeStart = 519343, XrefRangeEnd = 519367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 PixelAdjustPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_PixelAdjustPoint_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 519393, RefRangeEnd = 519401, XrefRangeStart = 519369, XrefRangeEnd = 519393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetPixelAdjustedRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_GetPixelAdjustedRect_Public_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
		[CallerCount(0)]
		public unsafe virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000CE68 File Offset: 0x0000B068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519401, XrefRangeEnd = 519434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAlpha;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		[CallerCount(0)]
		public unsafe static Color CreateColorFromAlpha(float alpha)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_CreateColorFromAlpha_Private_Static_Color_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000CF2C File Offset: 0x0000B12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519434, XrefRangeEnd = 519437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_New_Void_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000CF94 File Offset: 0x0000B194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519437, XrefRangeEnd = 519440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDirtyLayoutCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_RegisterDirtyLayoutCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519440, XrefRangeEnd = 519443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDirtyLayoutCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnregisterDirtyLayoutCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000D01C File Offset: 0x0000B21C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 519446, RefRangeEnd = 519452, XrefRangeStart = 519443, XrefRangeEnd = 519446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDirtyVerticesCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_RegisterDirtyVerticesCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000D060 File Offset: 0x0000B260
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 519455, RefRangeEnd = 519461, XrefRangeStart = 519452, XrefRangeEnd = 519455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDirtyVerticesCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnregisterDirtyVerticesCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000D0A4 File Offset: 0x0000B2A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 519464, RefRangeEnd = 519466, XrefRangeStart = 519461, XrefRangeEnd = 519464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDirtyMaterialCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_RegisterDirtyMaterialCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000D0E8 File Offset: 0x0000B2E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 519469, RefRangeEnd = 519471, XrefRangeStart = 519466, XrefRangeEnd = 519469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDirtyMaterialCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnregisterDirtyMaterialCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000D12C File Offset: 0x0000B32C
		public unsafe virtual Transform UnityEngine.UI.ICanvasElement.transform
		{
			[CallerCount(333)]
			[CachedScanResults(RefRangeStart = 456526, RefRangeEnd = 456859, XrefRangeStart = 456526, XrefRangeEnd = 456859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002767 File Offset: 0x00000967
		public Graphic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000D16C File Offset: 0x0000B36C
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002770 File Offset: 0x00000970
		public unsafe static Material s_DefaultUI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_DefaultUI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_DefaultUI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000D194 File Offset: 0x0000B394
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002782 File Offset: 0x00000982
		public unsafe static Texture2D s_WhiteTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_WhiteTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_WhiteTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000D1BC File Offset: 0x0000B3BC
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002794 File Offset: 0x00000994
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000D1EC File Offset: 0x0000B3EC
		// (set) Token: 0x06000193 RID: 403 RVA: 0x000027B3 File Offset: 0x000009B3
		public unsafe Color m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Color)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000D214 File Offset: 0x0000B414
		// (set) Token: 0x06000195 RID: 405 RVA: 0x000027CE File Offset: 0x000009CE
		public unsafe bool m_SkipLayoutUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipLayoutUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipLayoutUpdate)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000D23C File Offset: 0x0000B43C
		// (set) Token: 0x06000197 RID: 407 RVA: 0x000027E9 File Offset: 0x000009E9
		public unsafe bool m_SkipMaterialUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipMaterialUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipMaterialUpdate)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000D264 File Offset: 0x0000B464
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002804 File Offset: 0x00000A04
		public unsafe bool m_RaycastTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastTarget)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000D28C File Offset: 0x0000B48C
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0000281F File Offset: 0x00000A1F
		public unsafe bool m_RaycastTargetCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastTargetCache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastTargetCache)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000D2B4 File Offset: 0x0000B4B4
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0000283A File Offset: 0x00000A3A
		public unsafe Vector4 m_RaycastPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastPadding)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000D2DC File Offset: 0x0000B4DC
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002855 File Offset: 0x00000A55
		public unsafe RectTransform m_RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000D30C File Offset: 0x0000B50C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002874 File Offset: 0x00000A74
		public unsafe CanvasRenderer m_CanvasRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CanvasRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CanvasRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000D33C File Offset: 0x0000B53C
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002893 File Offset: 0x00000A93
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000D36C File Offset: 0x0000B56C
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000028B2 File Offset: 0x00000AB2
		public unsafe bool m_VertsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_VertsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_VertsDirty)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000D394 File Offset: 0x0000B594
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x000028CD File Offset: 0x00000ACD
		public unsafe bool m_MaterialDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_MaterialDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_MaterialDirty)) = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000028E8 File Offset: 0x00000AE8
		public unsafe UnityAction m_OnDirtyLayoutCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyLayoutCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyLayoutCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000D3EC File Offset: 0x0000B5EC
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002907 File Offset: 0x00000B07
		public unsafe UnityAction m_OnDirtyVertsCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyVertsCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyVertsCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000D41C File Offset: 0x0000B61C
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002926 File Offset: 0x00000B26
		public unsafe UnityAction m_OnDirtyMaterialCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyMaterialCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyMaterialCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000D44C File Offset: 0x0000B64C
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002945 File Offset: 0x00000B45
		public unsafe static Mesh s_Mesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_Mesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_Mesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000D474 File Offset: 0x0000B674
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002957 File Offset: 0x00000B57
		public unsafe static VertexHelper s_VertexHelper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_VertexHelper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VertexHelper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_VertexHelper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000D49C File Offset: 0x0000B69C
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002969 File Offset: 0x00000B69
		public unsafe Mesh m_CachedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000D4CC File Offset: 0x0000B6CC
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002988 File Offset: 0x00000B88
		public unsafe Il2CppStructArray<Vector2> m_CachedUvs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedUvs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedUvs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000D4FC File Offset: 0x0000B6FC
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x000029A7 File Offset: 0x00000BA7
		public unsafe TweenRunner<ColorTween> m_ColorTweenRunner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_ColorTweenRunner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenRunner<ColorTween>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_ColorTweenRunner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000D52C File Offset: 0x0000B72C
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x000029C6 File Offset: 0x00000BC6
		public unsafe bool _useLegacyMeshGeneration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField)) = value;
			}
		}

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultUI;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_s_WhiteTexture;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipLayoutUpdate;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipMaterialUpdate;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastTarget;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastTargetCache;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastPadding;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasRenderer;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_m_VertsDirty;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialDirty;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDirtyLayoutCallback;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDirtyVertsCallback;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDirtyMaterialCallback;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_s_Mesh;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_s_VertexHelper;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedMesh;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedUvs;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorTweenRunner;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultGraphicMaterial_Public_Static_get_Material_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_Virtual_New_get_Color_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Virtual_New_set_Void_Color_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastTarget_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_set_raycastTarget_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastPadding_Public_get_Vector4_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_set_raycastPadding_Public_set_Void_Vector4_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_get_useLegacyMeshGeneration_Protected_get_Boolean_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_set_useLegacyMeshGeneration_Protected_set_Void_Boolean_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_SetAllDirty_Public_Virtual_New_Void_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_New_Void_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_New_Void_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_New_Void_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_SetRaycastDirty_Public_Void_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_get_Int32_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_Virtual_Final_New_get_RectTransform_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_CacheCanvas_Private_Void_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_Virtual_New_get_Material_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_Virtual_New_set_Void_Material_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_New_get_Material_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_Virtual_New_get_Texture_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_OnCullingChanged_Public_Virtual_New_Void_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_New_Void_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_New_Void_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_DoMeshGeneration_Private_Void_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_DoLegacyMeshGeneration_Private_Void_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_get_workerMesh_Protected_Static_get_Mesh_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_OnFillVBO_Protected_Virtual_New_Void_List_1_UIVertex_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_Mesh_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_VertexHelper_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeSize_Public_Virtual_New_Void_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_New_Boolean_Vector2_Camera_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_PixelAdjustPoint_Public_Vector2_Vector2_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelAdjustedRect_Public_Rect_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_CreateColorFromAlpha_Private_Static_Color_Single_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_New_Void_Single_Single_Boolean_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDirtyLayoutCallback_Public_Void_UnityAction_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDirtyLayoutCallback_Public_Void_UnityAction_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDirtyVerticesCallback_Public_Void_UnityAction_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDirtyVerticesCallback_Public_Void_UnityAction_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDirtyMaterialCallback_Public_Void_UnityAction_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDirtyMaterialCallback_Public_Void_UnityAction_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_get_Transform_0;
	}
}
