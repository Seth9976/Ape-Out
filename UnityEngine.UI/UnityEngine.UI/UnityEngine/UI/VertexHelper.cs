using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200003F RID: 63
	public class VertexHelper : Object
	{
		// Token: 0x060007F4 RID: 2036 RVA: 0x00025BB8 File Offset: 0x00023DB8
		// Note: this type is marked as 'beforefieldinit'.
		static VertexHelper()
		{
			Il2CppClassPointerStore<VertexHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "VertexHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr);
			VertexHelper.NativeFieldInfoPtr_m_Positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Positions");
			VertexHelper.NativeFieldInfoPtr_m_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Colors");
			VertexHelper.NativeFieldInfoPtr_m_Uv0S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv0S");
			VertexHelper.NativeFieldInfoPtr_m_Uv1S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv1S");
			VertexHelper.NativeFieldInfoPtr_m_Uv2S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv2S");
			VertexHelper.NativeFieldInfoPtr_m_Uv3S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv3S");
			VertexHelper.NativeFieldInfoPtr_m_Normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Normals");
			VertexHelper.NativeFieldInfoPtr_m_Tangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Tangents");
			VertexHelper.NativeFieldInfoPtr_m_Indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Indices");
			VertexHelper.NativeFieldInfoPtr_s_DefaultTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "s_DefaultTangent");
			VertexHelper.NativeFieldInfoPtr_s_DefaultNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "s_DefaultNormal");
			VertexHelper.NativeFieldInfoPtr_m_ListsInitalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_ListsInitalized");
			VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664596);
			VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664597);
			VertexHelper.NativeMethodInfoPtr_InitializeListIfRequired_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664598);
			VertexHelper.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664599);
			VertexHelper.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664600);
			VertexHelper.NativeMethodInfoPtr_get_currentVertCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664601);
			VertexHelper.NativeMethodInfoPtr_get_currentIndexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664602);
			VertexHelper.NativeMethodInfoPtr_PopulateUIVertex_Public_Void_byref_UIVertex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664603);
			VertexHelper.NativeMethodInfoPtr_SetUIVertex_Public_Void_UIVertex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664604);
			VertexHelper.NativeMethodInfoPtr_FillMesh_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664605);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector4_Vector4_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664606);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664607);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664608);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664609);
			VertexHelper.NativeMethodInfoPtr_AddTriangle_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664610);
			VertexHelper.NativeMethodInfoPtr_AddUIVertexQuad_Public_Void_Il2CppStructArray_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664611);
			VertexHelper.NativeMethodInfoPtr_AddUIVertexStream_Public_Void_List_1_UIVertex_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664612);
			VertexHelper.NativeMethodInfoPtr_AddUIVertexTriangleStream_Public_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664613);
			VertexHelper.NativeMethodInfoPtr_GetUIVertexStream_Public_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664614);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00025E54 File Offset: 0x00024054
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00025E90 File Offset: 0x00024090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 529683, RefRangeEnd = 529684, XrefRangeStart = 529636, XrefRangeEnd = 529683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexHelper(Mesh m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00025EDC File Offset: 0x000240DC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 529731, RefRangeEnd = 529741, XrefRangeStart = 529684, XrefRangeEnd = 529731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeListIfRequired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_InitializeListIfRequired_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00025F10 File Offset: 0x00024110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529741, XrefRangeEnd = 529788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00025F44 File Offset: 0x00024144
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 529801, RefRangeEnd = 529812, XrefRangeStart = 529788, XrefRangeEnd = 529801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00025F78 File Offset: 0x00024178
		public unsafe int currentVertCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 529813, RefRangeEnd = 529815, XrefRangeStart = 529812, XrefRangeEnd = 529813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_get_currentVertCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00025FB4 File Offset: 0x000241B4
		public unsafe int currentIndexCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529815, XrefRangeEnd = 529816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_get_currentIndexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00025FF0 File Offset: 0x000241F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529816, XrefRangeEnd = 529820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateUIVertex(ref UIVertex vertex, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vertex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_PopulateUIVertex_Public_Void_byref_UIVertex_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0002603C File Offset: 0x0002423C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 529824, RefRangeEnd = 529825, XrefRangeStart = 529820, XrefRangeEnd = 529824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUIVertex(UIVertex vertex, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_SetUIVertex_Public_Void_UIVertex_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00026088 File Offset: 0x00024288
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 529881, RefRangeEnd = 529889, XrefRangeStart = 529825, XrefRangeEnd = 529881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_FillMesh_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000260CC File Offset: 0x000242CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 529901, RefRangeEnd = 529905, XrefRangeStart = 529889, XrefRangeEnd = 529901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv3;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tangent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector4_Vector4_Vector3_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0002616C File Offset: 0x0002436C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529905, XrefRangeEnd = 529910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tangent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector3_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000261F0 File Offset: 0x000243F0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 529921, RefRangeEnd = 529939, XrefRangeStart = 529910, XrefRangeEnd = 529921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(Vector3 position, Color32 color, Vector4 uv0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv0;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0002624C File Offset: 0x0002444C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 529940, RefRangeEnd = 529948, XrefRangeStart = 529939, XrefRangeEnd = 529940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(UIVertex v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0002628C File Offset: 0x0002448C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 529957, RefRangeEnd = 529974, XrefRangeStart = 529948, XrefRangeEnd = 529957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTriangle(int idx0, int idx1, int idx2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddTriangle_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000262E8 File Offset: 0x000244E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 529983, RefRangeEnd = 529987, XrefRangeStart = 529974, XrefRangeEnd = 529983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUIVertexQuad(Il2CppStructArray<UIVertex> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddUIVertexQuad_Public_Void_Il2CppStructArray_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0002632C File Offset: 0x0002452C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529987, XrefRangeEnd = 529992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUIVertexStream(List<UIVertex> verts, List<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddUIVertexStream_Public_Void_List_1_UIVertex_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00026380 File Offset: 0x00024580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 529997, RefRangeEnd = 529999, XrefRangeStart = 529992, XrefRangeEnd = 529997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUIVertexTriangleStream(List<UIVertex> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddUIVertexTriangleStream_Public_Void_List_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000263C4 File Offset: 0x000245C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 530002, RefRangeEnd = 530004, XrefRangeStart = 529999, XrefRangeEnd = 530002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUIVertexStream(List<UIVertex> stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_GetUIVertexStream_Public_Void_List_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00004BEB File Offset: 0x00002DEB
		public VertexHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00026408 File Offset: 0x00024608
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x00004BF4 File Offset: 0x00002DF4
		public unsafe List<Vector3> m_Positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x00026438 File Offset: 0x00024638
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x00004C13 File Offset: 0x00002E13
		public unsafe List<Color32> m_Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color32>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00026468 File Offset: 0x00024668
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00004C32 File Offset: 0x00002E32
		public unsafe List<Vector4> m_Uv0S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv0S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv0S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00026498 File Offset: 0x00024698
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00004C51 File Offset: 0x00002E51
		public unsafe List<Vector4> m_Uv1S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv1S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv1S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x000264C8 File Offset: 0x000246C8
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00004C70 File Offset: 0x00002E70
		public unsafe List<Vector4> m_Uv2S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv2S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv2S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000264F8 File Offset: 0x000246F8
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00004C8F File Offset: 0x00002E8F
		public unsafe List<Vector4> m_Uv3S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv3S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv3S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00026528 File Offset: 0x00024728
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00004CAE File Offset: 0x00002EAE
		public unsafe List<Vector3> m_Normals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Normals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Normals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00026558 File Offset: 0x00024758
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00004CCD File Offset: 0x00002ECD
		public unsafe List<Vector4> m_Tangents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Tangents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Tangents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00026588 File Offset: 0x00024788
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00004CEC File Offset: 0x00002EEC
		public unsafe List<int> m_Indices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Indices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Indices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x000265B8 File Offset: 0x000247B8
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00004D0B File Offset: 0x00002F0B
		public unsafe static Vector4 s_DefaultTangent
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(VertexHelper.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VertexHelper.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x000265D4 File Offset: 0x000247D4
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00004D19 File Offset: 0x00002F19
		public unsafe static Vector3 s_DefaultNormal
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(VertexHelper.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VertexHelper.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x000265F0 File Offset: 0x000247F0
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00004D27 File Offset: 0x00002F27
		public unsafe bool m_ListsInitalized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_ListsInitalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_ListsInitalized)) = value;
			}
		}

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeFieldInfoPtr_m_Positions;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeFieldInfoPtr_m_Colors;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv0S;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv1S;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv2S;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv3S;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr_m_Normals;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_m_Tangents;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeFieldInfoPtr_m_Indices;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTangent;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultNormal;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeFieldInfoPtr_m_ListsInitalized;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_InitializeListIfRequired_Private_Void_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_get_currentVertCount_Public_get_Int32_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_get_currentIndexCount_Public_get_Int32_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_PopulateUIVertex_Public_Void_byref_UIVertex_Int32_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_SetUIVertex_Public_Void_UIVertex_Int32_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_FillMesh_Public_Void_Mesh_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector4_Vector4_Vector3_Vector4_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector3_Vector4_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_UIVertex_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_AddTriangle_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_AddUIVertexQuad_Public_Void_Il2CppStructArray_1_UIVertex_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_AddUIVertexStream_Public_Void_List_1_UIVertex_List_1_Int32_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_AddUIVertexTriangleStream_Public_Void_List_1_UIVertex_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_GetUIVertexStream_Public_Void_List_1_UIVertex_0;
	}
}
