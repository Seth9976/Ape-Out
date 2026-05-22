using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppTMPro
{
	// Token: 0x02000030 RID: 48
	public static class TMP_MaterialManager : global::Il2CppSystem.Object
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x0001C3CC File Offset: 0x0001A5CC
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_MaterialManager()
		{
			Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_MaterialManager");
			TMP_MaterialManager.NativeFieldInfoPtr_m_materialList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_materialList");
			TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_fallbackMaterials");
			TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterialLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_fallbackMaterialLookup");
			TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackCleanupList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_fallbackCleanupList");
			TMP_MaterialManager.NativeFieldInfoPtr_isFallbackListDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "isFallbackListDirty");
			TMP_MaterialManager.NativeMethodInfoPtr_OnPreRender_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663964);
			TMP_MaterialManager.NativeMethodInfoPtr_GetStencilMaterial_Public_Static_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663965);
			TMP_MaterialManager.NativeMethodInfoPtr_ReleaseStencilMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663966);
			TMP_MaterialManager.NativeMethodInfoPtr_GetBaseMaterial_Public_Static_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663967);
			TMP_MaterialManager.NativeMethodInfoPtr_SetStencil_Public_Static_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663968);
			TMP_MaterialManager.NativeMethodInfoPtr_AddMaskingMaterial_Public_Static_Void_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663969);
			TMP_MaterialManager.NativeMethodInfoPtr_RemoveStencilMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663970);
			TMP_MaterialManager.NativeMethodInfoPtr_ReleaseBaseMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663971);
			TMP_MaterialManager.NativeMethodInfoPtr_ClearMaterials_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663972);
			TMP_MaterialManager.NativeMethodInfoPtr_GetStencilID_Public_Static_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663973);
			TMP_MaterialManager.NativeMethodInfoPtr_GetMaterialForRendering_Public_Static_Material_MaskableGraphic_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663974);
			TMP_MaterialManager.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Private_Static_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663975);
			TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Internal_Static_Material_TMP_FontAsset_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663976);
			TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663977);
			TMP_MaterialManager.NativeMethodInfoPtr_AddFallbackMaterialReference_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663978);
			TMP_MaterialManager.NativeMethodInfoPtr_RemoveFallbackMaterialReference_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663979);
			TMP_MaterialManager.NativeMethodInfoPtr_CleanupFallbackMaterials_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663980);
			TMP_MaterialManager.NativeMethodInfoPtr_ReleaseFallbackMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663981);
			TMP_MaterialManager.NativeMethodInfoPtr_CopyMaterialPresetProperties_Public_Static_Void_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100663982);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0001C5D4 File Offset: 0x0001A7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457009, XrefRangeEnd = 457016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnPreRender()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_OnPreRender_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0001C5FC File Offset: 0x0001A7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457016, XrefRangeEnd = 457044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetStencilMaterial(Material baseMaterial, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetStencilMaterial_Public_Static_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0001C650 File Offset: 0x0001A850
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 457068, RefRangeEnd = 457070, XrefRangeStart = 457044, XrefRangeEnd = 457068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseStencilMaterial(Material stencilMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ReleaseStencilMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0001C688 File Offset: 0x0001A888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457070, XrefRangeEnd = 457089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetBaseMaterial(Material stencilMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetBaseMaterial_Public_Static_Material_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0001C6CC File Offset: 0x0001A8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457089, XrefRangeEnd = 457105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material SetStencil(Material material, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_SetStencil_Public_Static_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0001C720 File Offset: 0x0001A920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457105, XrefRangeEnd = 457127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_AddMaskingMaterial_Public_Static_Void_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0001C778 File Offset: 0x0001A978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457127, XrefRangeEnd = 457148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveStencilMaterial(Material stencilMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_RemoveStencilMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0001C7B0 File Offset: 0x0001A9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457148, XrefRangeEnd = 457197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseBaseMaterial(Material baseMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ReleaseBaseMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0001C7E8 File Offset: 0x0001A9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457197, XrefRangeEnd = 457219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearMaterials()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ClearMaterials_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0001C810 File Offset: 0x0001AA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457219, XrefRangeEnd = 457304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStencilID(GameObject obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetStencilID_Public_Static_Int32_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0001C854 File Offset: 0x0001AA54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 457341, RefRangeEnd = 457343, XrefRangeStart = 457304, XrefRangeEnd = 457341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetMaterialForRendering_Public_Static_Material_MaskableGraphic_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0001C8AC File Offset: 0x0001AAAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 457377, RefRangeEnd = 457378, XrefRangeStart = 457343, XrefRangeEnd = 457377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindRootSortOverrideCanvas(Transform start)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Private_Static_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001C8F0 File Offset: 0x0001AAF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 457411, RefRangeEnd = 457413, XrefRangeStart = 457378, XrefRangeEnd = 457411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Internal_Static_Material_TMP_FontAsset_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0001C954 File Offset: 0x0001AB54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 457478, RefRangeEnd = 457482, XrefRangeStart = 457413, XrefRangeEnd = 457478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceMaterial);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0001C9AC File Offset: 0x0001ABAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 457506, RefRangeEnd = 457508, XrefRangeStart = 457482, XrefRangeEnd = 457506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddFallbackMaterialReference(Material targetMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_AddFallbackMaterialReference_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001C9E4 File Offset: 0x0001ABE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457508, XrefRangeEnd = 457538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFallbackMaterialReference(Material targetMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_RemoveFallbackMaterialReference_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0001CA1C File Offset: 0x0001AC1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 457568, RefRangeEnd = 457569, XrefRangeStart = 457538, XrefRangeEnd = 457568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupFallbackMaterials()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_CleanupFallbackMaterials_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0001CA44 File Offset: 0x0001AC44
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 457602, RefRangeEnd = 457608, XrefRangeStart = 457569, XrefRangeEnd = 457602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseFallbackMaterial(Material fallbackMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallbackMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ReleaseFallbackMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0001CA7C File Offset: 0x0001AC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457608, XrefRangeEnd = 457650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyMaterialPresetProperties(Material source, Material destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_CopyMaterialPresetProperties_Public_Static_Void_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000462E File Offset: 0x0000282E
		public TMP_MaterialManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001CAC4 File Offset: 0x0001ACC4
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00004637 File Offset: 0x00002837
		public unsafe static List<TMP_MaterialManager.MaskingMaterial> m_materialList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_materialList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_MaterialManager.MaskingMaterial>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_materialList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0001CAEC File Offset: 0x0001ACEC
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00004649 File Offset: 0x00002849
		public unsafe static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterials, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<long, TMP_MaterialManager.FallbackMaterial>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterials, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0001CB14 File Offset: 0x0001AD14
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0000465B File Offset: 0x0000285B
		public unsafe static Dictionary<int, long> m_fallbackMaterialLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterialLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, long>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterialLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001CB3C File Offset: 0x0001AD3C
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0000466D File Offset: 0x0000286D
		public unsafe static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackCleanupList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_MaterialManager.FallbackMaterial>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackCleanupList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0001CB64 File Offset: 0x0001AD64
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0000467F File Offset: 0x0000287F
		public unsafe static bool isFallbackListDirty
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_isFallbackListDirty, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_isFallbackListDirty, (void*)(&value));
			}
		}

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_m_materialList;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackMaterials;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackMaterialLookup;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackCleanupList;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr_isFallbackListDirty;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_OnPreRender_Private_Static_Void_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_GetStencilMaterial_Public_Static_Material_Material_Int32_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseStencilMaterial_Public_Static_Void_Material_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseMaterial_Public_Static_Material_Material_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_SetStencil_Public_Static_Material_Material_Int32_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_AddMaskingMaterial_Public_Static_Void_Material_Material_Int32_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_RemoveStencilMaterial_Public_Static_Void_Material_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseBaseMaterial_Public_Static_Void_Material_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_ClearMaterials_Public_Static_Void_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_GetStencilID_Public_Static_Int32_GameObject_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterialForRendering_Public_Static_Material_MaskableGraphic_Material_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_FindRootSortOverrideCanvas_Private_Static_Transform_Transform_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_GetFallbackMaterial_Internal_Static_Material_TMP_FontAsset_Material_Int32_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_AddFallbackMaterialReference_Public_Static_Void_Material_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFallbackMaterialReference_Public_Static_Void_Material_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_CleanupFallbackMaterials_Public_Static_Void_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseFallbackMaterial_Public_Static_Void_Material_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_CopyMaterialPresetProperties_Public_Static_Void_Material_Material_0;

		// Token: 0x0200009B RID: 155
		public class FallbackMaterial : global::Il2CppSystem.Object
		{
			// Token: 0x06000F65 RID: 3941 RVA: 0x0003D694 File Offset: 0x0003B894
			// Note: this type is marked as 'beforefieldinit'.
			static FallbackMaterial()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "FallbackMaterial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr);
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "fallbackID");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "sourceMaterial");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterialCRC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "sourceMaterialCRC");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "fallbackMaterial");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "count");
				TMP_MaterialManager.FallbackMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, 100663983);
			}

			// Token: 0x06000F66 RID: 3942 RVA: 0x0003D738 File Offset: 0x0003B938
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FallbackMaterial()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.FallbackMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F67 RID: 3943 RVA: 0x000094DF File Offset: 0x000076DF
			public FallbackMaterial(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700059B RID: 1435
			// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0003D774 File Offset: 0x0003B974
			// (set) Token: 0x06000F69 RID: 3945 RVA: 0x000094E8 File Offset: 0x000076E8
			public unsafe long fallbackID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackID)) = value;
				}
			}

			// Token: 0x1700059C RID: 1436
			// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0003D79C File Offset: 0x0003B99C
			// (set) Token: 0x06000F6B RID: 3947 RVA: 0x00009503 File Offset: 0x00007703
			public unsafe Material sourceMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700059D RID: 1437
			// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0003D7CC File Offset: 0x0003B9CC
			// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00009522 File Offset: 0x00007722
			public unsafe int sourceMaterialCRC
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterialCRC);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterialCRC)) = value;
				}
			}

			// Token: 0x1700059E RID: 1438
			// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0003D7F4 File Offset: 0x0003B9F4
			// (set) Token: 0x06000F6F RID: 3951 RVA: 0x0000953D File Offset: 0x0000773D
			public unsafe Material fallbackMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700059F RID: 1439
			// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0003D824 File Offset: 0x0003BA24
			// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0000955C File Offset: 0x0000775C
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x04000C2D RID: 3117
			private static readonly IntPtr NativeFieldInfoPtr_fallbackID;

			// Token: 0x04000C2E RID: 3118
			private static readonly IntPtr NativeFieldInfoPtr_sourceMaterial;

			// Token: 0x04000C2F RID: 3119
			private static readonly IntPtr NativeFieldInfoPtr_sourceMaterialCRC;

			// Token: 0x04000C30 RID: 3120
			private static readonly IntPtr NativeFieldInfoPtr_fallbackMaterial;

			// Token: 0x04000C31 RID: 3121
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000C32 RID: 3122
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200009C RID: 156
		public class MaskingMaterial : global::Il2CppSystem.Object
		{
			// Token: 0x06000F72 RID: 3954 RVA: 0x0003D84C File Offset: 0x0003BA4C
			// Note: this type is marked as 'beforefieldinit'.
			static MaskingMaterial()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "MaskingMaterial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr);
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_baseMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "baseMaterial");
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "count");
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "stencilID");
				TMP_MaterialManager.MaskingMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, 100663984);
			}

			// Token: 0x06000F73 RID: 3955 RVA: 0x0003D8DC File Offset: 0x0003BADC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MaskingMaterial()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.MaskingMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F74 RID: 3956 RVA: 0x00009577 File Offset: 0x00007777
			public MaskingMaterial(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A0 RID: 1440
			// (get) Token: 0x06000F75 RID: 3957 RVA: 0x0003D918 File Offset: 0x0003BB18
			// (set) Token: 0x06000F76 RID: 3958 RVA: 0x00009580 File Offset: 0x00007780
			public unsafe Material baseMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_baseMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_baseMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A1 RID: 1441
			// (get) Token: 0x06000F77 RID: 3959 RVA: 0x0003D948 File Offset: 0x0003BB48
			// (set) Token: 0x06000F78 RID: 3960 RVA: 0x0000959F File Offset: 0x0000779F
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A2 RID: 1442
			// (get) Token: 0x06000F79 RID: 3961 RVA: 0x0003D978 File Offset: 0x0003BB78
			// (set) Token: 0x06000F7A RID: 3962 RVA: 0x000095BE File Offset: 0x000077BE
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170005A3 RID: 1443
			// (get) Token: 0x06000F7B RID: 3963 RVA: 0x0003D9A0 File Offset: 0x0003BBA0
			// (set) Token: 0x06000F7C RID: 3964 RVA: 0x000095D9 File Offset: 0x000077D9
			public unsafe int stencilID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilID)) = value;
				}
			}

			// Token: 0x04000C33 RID: 3123
			private static readonly IntPtr NativeFieldInfoPtr_baseMaterial;

			// Token: 0x04000C34 RID: 3124
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C35 RID: 3125
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000C36 RID: 3126
			private static readonly IntPtr NativeFieldInfoPtr_stencilID;

			// Token: 0x04000C37 RID: 3127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200009D RID: 157
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F7D RID: 3965 RVA: 0x0003D9C8 File Offset: 0x0003BBC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass9_0.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr, 100663985);
				TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__GetBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr, 100663986);
			}

			// Token: 0x06000F7E RID: 3966 RVA: 0x0003DA30 File Offset: 0x0003BC30
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F7F RID: 3967 RVA: 0x0003DA6C File Offset: 0x0003BC6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456969, XrefRangeEnd = 456979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBaseMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__GetBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F80 RID: 3968 RVA: 0x000095F4 File Offset: 0x000077F4
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A4 RID: 1444
			// (get) Token: 0x06000F81 RID: 3969 RVA: 0x0003DABC File Offset: 0x0003BCBC
			// (set) Token: 0x06000F82 RID: 3970 RVA: 0x000095FD File Offset: 0x000077FD
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass9_0.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass9_0.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C38 RID: 3128
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C39 RID: 3129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C3A RID: 3130
			private static readonly IntPtr NativeMethodInfoPtr__GetBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}

		// Token: 0x0200009E RID: 158
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F83 RID: 3971 RVA: 0x0003DAEC File Offset: 0x0003BCEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass11_0.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr, 100663987);
				TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__AddMaskingMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr, 100663988);
			}

			// Token: 0x06000F84 RID: 3972 RVA: 0x0003DB54 File Offset: 0x0003BD54
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F85 RID: 3973 RVA: 0x0003DB90 File Offset: 0x0003BD90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456979, XrefRangeEnd = 456989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddMaskingMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__AddMaskingMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F86 RID: 3974 RVA: 0x0000961C File Offset: 0x0000781C
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A5 RID: 1445
			// (get) Token: 0x06000F87 RID: 3975 RVA: 0x0003DBE0 File Offset: 0x0003BDE0
			// (set) Token: 0x06000F88 RID: 3976 RVA: 0x00009625 File Offset: 0x00007825
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass11_0.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass11_0.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C3B RID: 3131
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C3C RID: 3132
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C3D RID: 3133
			private static readonly IntPtr NativeMethodInfoPtr__AddMaskingMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}

		// Token: 0x0200009F RID: 159
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F89 RID: 3977 RVA: 0x0003DC10 File Offset: 0x0003BE10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass12_0.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr, 100663989);
				TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveStencilMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr, 100663990);
			}

			// Token: 0x06000F8A RID: 3978 RVA: 0x0003DC78 File Offset: 0x0003BE78
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F8B RID: 3979 RVA: 0x0003DCB4 File Offset: 0x0003BEB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456989, XrefRangeEnd = 456999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveStencilMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveStencilMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F8C RID: 3980 RVA: 0x00009644 File Offset: 0x00007844
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A6 RID: 1446
			// (get) Token: 0x06000F8D RID: 3981 RVA: 0x0003DD04 File Offset: 0x0003BF04
			// (set) Token: 0x06000F8E RID: 3982 RVA: 0x0000964D File Offset: 0x0000784D
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass12_0.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass12_0.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C3E RID: 3134
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C3F RID: 3135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C40 RID: 3136
			private static readonly IntPtr NativeMethodInfoPtr__RemoveStencilMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}

		// Token: 0x020000A0 RID: 160
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F8F RID: 3983 RVA: 0x0003DD34 File Offset: 0x0003BF34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass13_0.NativeFieldInfoPtr_baseMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr, "baseMaterial");
				TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr, 100663991);
				TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ReleaseBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr, 100663992);
			}

			// Token: 0x06000F90 RID: 3984 RVA: 0x0003DD9C File Offset: 0x0003BF9C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F91 RID: 3985 RVA: 0x0003DDD8 File Offset: 0x0003BFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456999, XrefRangeEnd = 457009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ReleaseBaseMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ReleaseBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F92 RID: 3986 RVA: 0x0000966C File Offset: 0x0000786C
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A7 RID: 1447
			// (get) Token: 0x06000F93 RID: 3987 RVA: 0x0003DE28 File Offset: 0x0003C028
			// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00009675 File Offset: 0x00007875
			public unsafe Material baseMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass13_0.NativeFieldInfoPtr_baseMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass13_0.NativeFieldInfoPtr_baseMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C41 RID: 3137
			private static readonly IntPtr NativeFieldInfoPtr_baseMaterial;

			// Token: 0x04000C42 RID: 3138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C43 RID: 3139
			private static readonly IntPtr NativeMethodInfoPtr__ReleaseBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}
	}
}
