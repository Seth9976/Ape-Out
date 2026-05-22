using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public class MeshCollider : Collider
	{
		// Token: 0x06000121 RID: 289 RVA: 0x000065D4 File Offset: 0x000047D4
		// Note: this type is marked as 'beforefieldinit'.
		static MeshCollider()
		{
			Il2CppClassPointerStore<MeshCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "MeshCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr);
			MeshCollider.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663351);
			MeshCollider.NativeMethodInfoPtr_get_convex_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663352);
			MeshCollider.NativeMethodInfoPtr_set_convex_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663353);
			MeshCollider.set_sharedMeshDelegateField = IL2CPP.ResolveICall<MeshCollider.set_sharedMeshDelegate>("UnityEngine.MeshCollider::set_sharedMesh");
			MeshCollider.get_cookingOptionsDelegateField = IL2CPP.ResolveICall<MeshCollider.get_cookingOptionsDelegate>("UnityEngine.MeshCollider::get_cookingOptions");
			MeshCollider.set_cookingOptionsDelegateField = IL2CPP.ResolveICall<MeshCollider.set_cookingOptionsDelegate>("UnityEngine.MeshCollider::set_cookingOptions");
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00006670 File Offset: 0x00004870
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002B18 File Offset: 0x00000D18
		public unsafe Mesh sharedMesh
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 513675, RefRangeEnd = 513677, XrefRangeStart = 513671, XrefRangeEnd = 513675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			set
			{
				MeshCollider.set_sharedMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000066B0 File Offset: 0x000048B0
		// (set) Token: 0x06000124 RID: 292 RVA: 0x000066EC File Offset: 0x000048EC
		public unsafe bool convex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 513681, RefRangeEnd = 513682, XrefRangeStart = 513677, XrefRangeEnd = 513681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_get_convex_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 513686, RefRangeEnd = 513687, XrefRangeStart = 513682, XrefRangeEnd = 513686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_set_convex_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002B0F File Offset: 0x00000D0F
		public MeshCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000672C File Offset: 0x0000492C
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002B30 File Offset: 0x00000D30
		public bool inflateMesh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00002B33 File Offset: 0x00000D33
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002B45 File Offset: 0x00000D45
		public MeshColliderCookingOptions cookingOptions
		{
			get
			{
				return MeshCollider.get_cookingOptionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				MeshCollider.set_cookingOptionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00006740 File Offset: 0x00004940
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002B58 File Offset: 0x00000D58
		public float skinWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00006758 File Offset: 0x00004958
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00002B5B File Offset: 0x00000D5B
		public bool smoothSphereCollisions
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_get_convex_Public_get_Boolean_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_set_convex_Public_set_Void_Boolean_0;

		// Token: 0x040000C3 RID: 195
		private static readonly MeshCollider.set_sharedMeshDelegate set_sharedMeshDelegateField;

		// Token: 0x040000C4 RID: 196
		private static readonly MeshCollider.get_cookingOptionsDelegate get_cookingOptionsDelegateField;

		// Token: 0x040000C5 RID: 197
		private static readonly MeshCollider.set_cookingOptionsDelegate set_cookingOptionsDelegateField;

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x06000432 RID: 1074
		private delegate void set_sharedMeshDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000434 RID: 1076
		private delegate MeshColliderCookingOptions get_cookingOptionsDelegate(IntPtr @this);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x06000436 RID: 1078
		private delegate void set_cookingOptionsDelegate(IntPtr @this, MeshColliderCookingOptions value);
	}
}
