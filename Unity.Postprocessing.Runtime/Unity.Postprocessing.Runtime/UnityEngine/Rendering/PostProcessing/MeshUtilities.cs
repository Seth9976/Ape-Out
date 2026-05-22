using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200005E RID: 94
	public static class MeshUtilities : Object
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x00016190 File Offset: 0x00014390
		// Note: this type is marked as 'beforefieldinit'.
		static MeshUtilities()
		{
			Il2CppClassPointerStore<MeshUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "MeshUtilities");
			MeshUtilities.NativeFieldInfoPtr_s_Primitives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtilities>.NativeClassPtr, "s_Primitives");
			MeshUtilities.NativeFieldInfoPtr_s_ColliderPrimitives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtilities>.NativeClassPtr, "s_ColliderPrimitives");
			MeshUtilities.NativeMethodInfoPtr_GetColliderMesh_Internal_Static_Mesh_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtilities>.NativeClassPtr, 100663786);
			MeshUtilities.NativeMethodInfoPtr_GetPrimitive_Internal_Static_Mesh_PrimitiveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtilities>.NativeClassPtr, 100663787);
			MeshUtilities.NativeMethodInfoPtr_GetBuiltinMesh_Private_Static_Mesh_PrimitiveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtilities>.NativeClassPtr, 100663788);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001621C File Offset: 0x0001441C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448506, XrefRangeEnd = 448529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GetColliderMesh(Collider collider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtilities.NativeMethodInfoPtr_GetColliderMesh_Internal_Static_Mesh_Collider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00016260 File Offset: 0x00014460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 448552, RefRangeEnd = 448553, XrefRangeStart = 448529, XrefRangeEnd = 448552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GetPrimitive(PrimitiveType primitiveType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref primitiveType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtilities.NativeMethodInfoPtr_GetPrimitive_Internal_Static_Mesh_PrimitiveType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000162A0 File Offset: 0x000144A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448553, XrefRangeEnd = 448564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GetBuiltinMesh(PrimitiveType primitiveType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref primitiveType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtilities.NativeMethodInfoPtr_GetBuiltinMesh_Private_Static_Mesh_PrimitiveType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00004AD6 File Offset: 0x00002CD6
		public MeshUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x000162E0 File Offset: 0x000144E0
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00004ADF File Offset: 0x00002CDF
		public unsafe static Dictionary<PrimitiveType, Mesh> s_Primitives
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MeshUtilities.NativeFieldInfoPtr_s_Primitives, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PrimitiveType, Mesh>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshUtilities.NativeFieldInfoPtr_s_Primitives, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00016308 File Offset: 0x00014508
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00004AF1 File Offset: 0x00002CF1
		public unsafe static Dictionary<Type, PrimitiveType> s_ColliderPrimitives
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MeshUtilities.NativeFieldInfoPtr_s_ColliderPrimitives, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, PrimitiveType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshUtilities.NativeFieldInfoPtr_s_ColliderPrimitives, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeFieldInfoPtr_s_Primitives;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr_s_ColliderPrimitives;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_GetColliderMesh_Internal_Static_Mesh_Collider_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimitive_Internal_Static_Mesh_PrimitiveType_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltinMesh_Private_Static_Mesh_PrimitiveType_0;
	}
}
