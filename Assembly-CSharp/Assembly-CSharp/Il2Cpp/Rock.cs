using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000170 RID: 368
	public class Rock : MonoBehaviour
	{
		// Token: 0x06002C13 RID: 11283 RVA: 0x000AE060 File Offset: 0x000AC260
		// Note: this type is marked as 'beforefieldinit'.
		static Rock()
		{
			Il2CppClassPointerStore<Rock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Rock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rock>.NativeClassPtr);
			Rock.NativeFieldInfoPtr_botMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "botMesh");
			Rock.NativeFieldInfoPtr_topMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "topMesh");
			Rock.NativeFieldInfoPtr_shadowMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "shadowMesh");
			Rock.NativeFieldInfoPtr_botRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "botRend");
			Rock.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "verts");
			Rock.NativeFieldInfoPtr_debugPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "debugPt");
			Rock.NativeFieldInfoPtr_shadowVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "shadowVerts");
			Rock.NativeFieldInfoPtr_tris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "tris");
			Rock.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "uv");
			Rock.NativeFieldInfoPtr_big = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "big");
			Rock.NativeFieldInfoPtr_paralaxAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "paralaxAmount");
			Rock.NativeFieldInfoPtr_botMeshVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "botMeshVerts");
			Rock.NativeFieldInfoPtr_topMeshVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rock>.NativeClassPtr, "topMeshVerts");
			Rock.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rock>.NativeClassPtr, 100666749);
			Rock.NativeMethodInfoPtr_InitShit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rock>.NativeClassPtr, 100666750);
			Rock.NativeMethodInfoPtr_MakeMesh_Public_Void_MeshFilter_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rock>.NativeClassPtr, 100666751);
			Rock.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rock>.NativeClassPtr, 100666752);
			Rock.NativeMethodInfoPtr_GetTopVert_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rock>.NativeClassPtr, 100666753);
			Rock.NativeMethodInfoPtr_GetBotVert_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rock>.NativeClassPtr, 100666754);
			Rock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rock>.NativeClassPtr, 100666755);
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x000AE220 File Offset: 0x000AC420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79873, XrefRangeEnd = 79878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rock.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000AE254 File Offset: 0x000AC454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79878, XrefRangeEnd = 80023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rock.NativeMethodInfoPtr_InitShit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x000AE288 File Offset: 0x000AC488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80071, RefRangeEnd = 80073, XrefRangeStart = 80023, XrefRangeEnd = 80071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeMesh(MeshFilter msh, int ptNum, float rad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rock.NativeMethodInfoPtr_MakeMesh_Public_Void_MeshFilter_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x000AE2E8 File Offset: 0x000AC4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80073, XrefRangeEnd = 80094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rock.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x000AE31C File Offset: 0x000AC51C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80106, RefRangeEnd = 80109, XrefRangeStart = 80094, XrefRangeEnd = 80106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTopVert(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rock.NativeMethodInfoPtr_GetTopVert_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x000AE368 File Offset: 0x000AC568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80109, XrefRangeEnd = 80113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBotVert(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rock.NativeMethodInfoPtr_GetBotVert_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x000AE3B4 File Offset: 0x000AC5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80113, XrefRangeEnd = 80121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x0001E8F7 File Offset: 0x0001CAF7
		public Rock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x000AE3F0 File Offset: 0x000AC5F0
		// (set) Token: 0x06002C1D RID: 11293 RVA: 0x0001E900 File Offset: 0x0001CB00
		public unsafe MeshFilter botMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_botMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_botMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x000AE420 File Offset: 0x000AC620
		// (set) Token: 0x06002C1F RID: 11295 RVA: 0x0001E91F File Offset: 0x0001CB1F
		public unsafe MeshFilter topMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_topMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_topMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x000AE450 File Offset: 0x000AC650
		// (set) Token: 0x06002C21 RID: 11297 RVA: 0x0001E93E File Offset: 0x0001CB3E
		public unsafe MeshFilter shadowMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_shadowMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_shadowMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x000AE480 File Offset: 0x000AC680
		// (set) Token: 0x06002C23 RID: 11299 RVA: 0x0001E95D File Offset: 0x0001CB5D
		public unsafe MeshRenderer botRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_botRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_botRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x000AE4B0 File Offset: 0x000AC6B0
		// (set) Token: 0x06002C25 RID: 11301 RVA: 0x0001E97C File Offset: 0x0001CB7C
		public unsafe Il2CppStructArray<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x000AE4E0 File Offset: 0x000AC6E0
		// (set) Token: 0x06002C27 RID: 11303 RVA: 0x0001E99B File Offset: 0x0001CB9B
		public unsafe Vector2 debugPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_debugPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_debugPt)) = value;
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06002C28 RID: 11304 RVA: 0x000AE508 File Offset: 0x000AC708
		// (set) Token: 0x06002C29 RID: 11305 RVA: 0x0001E9B6 File Offset: 0x0001CBB6
		public unsafe Il2CppStructArray<Vector3> shadowVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_shadowVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_shadowVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x000AE538 File Offset: 0x000AC738
		// (set) Token: 0x06002C2B RID: 11307 RVA: 0x0001E9D5 File Offset: 0x0001CBD5
		public unsafe Il2CppStructArray<int> tris
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_tris);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_tris), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06002C2C RID: 11308 RVA: 0x000AE568 File Offset: 0x000AC768
		// (set) Token: 0x06002C2D RID: 11309 RVA: 0x0001E9F4 File Offset: 0x0001CBF4
		public unsafe Il2CppStructArray<Vector2> uv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_uv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_uv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x000AE598 File Offset: 0x000AC798
		// (set) Token: 0x06002C2F RID: 11311 RVA: 0x0001EA13 File Offset: 0x0001CC13
		public unsafe bool big
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_big);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_big)) = value;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06002C30 RID: 11312 RVA: 0x000AE5C0 File Offset: 0x000AC7C0
		// (set) Token: 0x06002C31 RID: 11313 RVA: 0x0001EA2E File Offset: 0x0001CC2E
		public unsafe float paralaxAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_paralaxAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_paralaxAmount)) = value;
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x000AE5E8 File Offset: 0x000AC7E8
		// (set) Token: 0x06002C33 RID: 11315 RVA: 0x0001EA49 File Offset: 0x0001CC49
		public unsafe Il2CppStructArray<Vector3> botMeshVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_botMeshVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_botMeshVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06002C34 RID: 11316 RVA: 0x000AE618 File Offset: 0x000AC818
		// (set) Token: 0x06002C35 RID: 11317 RVA: 0x0001EA68 File Offset: 0x0001CC68
		public unsafe Il2CppStructArray<Vector3> topMeshVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_topMeshVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rock.NativeFieldInfoPtr_topMeshVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeFieldInfoPtr_botMesh;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeFieldInfoPtr_topMesh;

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeFieldInfoPtr_shadowMesh;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeFieldInfoPtr_botRend;

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeFieldInfoPtr_debugPt;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeFieldInfoPtr_shadowVerts;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeFieldInfoPtr_tris;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeFieldInfoPtr_big;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeFieldInfoPtr_paralaxAmount;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeFieldInfoPtr_botMeshVerts;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeFieldInfoPtr_topMeshVerts;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr_InitShit_Public_Void_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr_MakeMesh_Public_Void_MeshFilter_Int32_Single_0;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeMethodInfoPtr_GetTopVert_Public_Int32_Int32_0;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeMethodInfoPtr_GetBotVert_Public_Int32_Int32_0;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
