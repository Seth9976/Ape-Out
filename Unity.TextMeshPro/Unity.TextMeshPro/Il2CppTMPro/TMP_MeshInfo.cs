using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x02000032 RID: 50
	public sealed class TMP_MeshInfo : ValueType
	{
		// Token: 0x06000551 RID: 1361 RVA: 0x0001CB80 File Offset: 0x0001AD80
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_MeshInfo()
		{
			Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_MeshInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr);
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultColor");
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultNormal");
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultTangent");
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultBounds");
			TMP_MeshInfo.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "mesh");
			TMP_MeshInfo.NativeFieldInfoPtr_vertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "vertexCount");
			TMP_MeshInfo.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "vertices");
			TMP_MeshInfo.NativeFieldInfoPtr_normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "normals");
			TMP_MeshInfo.NativeFieldInfoPtr_tangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "tangents");
			TMP_MeshInfo.NativeFieldInfoPtr_uvs0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "uvs0");
			TMP_MeshInfo.NativeFieldInfoPtr_uvs2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "uvs2");
			TMP_MeshInfo.NativeFieldInfoPtr_colors32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "colors32");
			TMP_MeshInfo.NativeFieldInfoPtr_triangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "triangles");
			TMP_MeshInfo.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "material");
			TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100663993);
			TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100663994);
			TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100663995);
			TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100663996);
			TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100663997);
			TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100663998);
			TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100663999);
			TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664000);
			TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664001);
			TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664002);
			TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664003);
			TMP_MeshInfo.NativeMethodInfoPtr_SwapVertexData_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664004);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 457716, RefRangeEnd = 457720, XrefRangeStart = 457650, XrefRangeEnd = 457716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_MeshInfo(Mesh mesh, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0001CE18 File Offset: 0x0001B018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457720, XrefRangeEnd = 457786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolumetric;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0001CE84 File Offset: 0x0001B084
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 457822, RefRangeEnd = 457829, XrefRangeStart = 457786, XrefRangeEnd = 457822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeMeshInfo(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0001CEC8 File Offset: 0x0001B0C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 457876, RefRangeEnd = 457878, XrefRangeStart = 457829, XrefRangeEnd = 457876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeMeshInfo(int size, bool isVolumetric)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolumetric;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0001CF1C File Offset: 0x0001B11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457878, XrefRangeEnd = 457895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0001CF54 File Offset: 0x0001B154
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 457931, RefRangeEnd = 457934, XrefRangeStart = 457895, XrefRangeEnd = 457931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool uploadChanges)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uploadChanges;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0001CF98 File Offset: 0x0001B198
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 457935, RefRangeEnd = 457937, XrefRangeStart = 457934, XrefRangeEnd = 457935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0001CFD0 File Offset: 0x0001B1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457937, XrefRangeEnd = 457938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0001D014 File Offset: 0x0001B214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 457955, RefRangeEnd = 457956, XrefRangeStart = 457938, XrefRangeEnd = 457955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices(int startIndex, bool updateMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0001D068 File Offset: 0x0001B268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457956, XrefRangeEnd = 457957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGeometry(VertexSortingOrder order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_VertexSortingOrder_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0001D0AC File Offset: 0x0001B2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457957, XrefRangeEnd = 457966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGeometry(IList<int> sortingOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortingOrder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_IList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0001D0F4 File Offset: 0x0001B2F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 457966, RefRangeEnd = 457968, XrefRangeStart = 457966, XrefRangeEnd = 457966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapVertexData(int src, int dst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_SwapVertexData_Public_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000468D File Offset: 0x0000288D
		public TMP_MeshInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00004696 File Offset: 0x00002896
		public TMP_MeshInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0001D148 File Offset: 0x0001B348
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x000046A8 File Offset: 0x000028A8
		public unsafe static Color32 s_DefaultColor
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultColor, (void*)(&value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0001D164 File Offset: 0x0001B364
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x000046B6 File Offset: 0x000028B6
		public unsafe static Vector3 s_DefaultNormal
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0001D180 File Offset: 0x0001B380
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x000046C4 File Offset: 0x000028C4
		public unsafe static Vector4 s_DefaultTangent
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0001D19C File Offset: 0x0001B39C
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x000046D2 File Offset: 0x000028D2
		public unsafe static Bounds s_DefaultBounds
		{
			get
			{
				Bounds bounds;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultBounds, (void*)(&bounds));
				return bounds;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultBounds, (void*)(&value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0001D1B8 File Offset: 0x0001B3B8
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x000046E0 File Offset: 0x000028E0
		public unsafe Mesh mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x000046FF File Offset: 0x000028FF
		public unsafe int vertexCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertexCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertexCount)) = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0001D210 File Offset: 0x0001B410
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x0000471A File Offset: 0x0000291A
		public unsafe Il2CppStructArray<Vector3> vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0001D240 File Offset: 0x0001B440
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00004739 File Offset: 0x00002939
		public unsafe Il2CppStructArray<Vector3> normals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_normals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_normals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0001D270 File Offset: 0x0001B470
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00004758 File Offset: 0x00002958
		public unsafe Il2CppStructArray<Vector4> tangents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_tangents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_tangents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0001D2A0 File Offset: 0x0001B4A0
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00004777 File Offset: 0x00002977
		public unsafe Il2CppStructArray<Vector2> uvs0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00004796 File Offset: 0x00002996
		public unsafe Il2CppStructArray<Vector2> uvs2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001D300 File Offset: 0x0001B500
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x000047B5 File Offset: 0x000029B5
		public unsafe Il2CppStructArray<Color32> colors32
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_colors32);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_colors32), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0001D330 File Offset: 0x0001B530
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x000047D4 File Offset: 0x000029D4
		public unsafe Il2CppStructArray<int> triangles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_triangles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_triangles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001D360 File Offset: 0x0001B560
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x000047F3 File Offset: 0x000029F3
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultColor;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultNormal;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTangent;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultBounds;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr_vertexCount;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr_vertices;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeFieldInfoPtr_normals;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr_tangents;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr_uvs0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeFieldInfoPtr_uvs2;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr_colors32;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr_triangles;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_Boolean_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_Boolean_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_Boolean_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_Boolean_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_SortGeometry_Public_Void_VertexSortingOrder_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_SortGeometry_Public_Void_IList_1_Int32_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_SwapVertexData_Public_Void_Int32_Int32_0;
	}
}
