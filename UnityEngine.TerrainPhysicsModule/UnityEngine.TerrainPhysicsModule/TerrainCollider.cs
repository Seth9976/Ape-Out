using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class TerrainCollider : Collider
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000208C File Offset: 0x0000028C
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainCollider()
		{
			Il2CppClassPointerStore<TerrainCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainPhysicsModule.dll", "UnityEngine", "TerrainCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainCollider>.NativeClassPtr);
			TerrainCollider.get_terrainDataDelegateField = IL2CPP.ResolveICall<TerrainCollider.get_terrainDataDelegate>("UnityEngine.TerrainCollider::get_terrainData");
			TerrainCollider.set_terrainDataDelegateField = IL2CPP.ResolveICall<TerrainCollider.set_terrainDataDelegate>("UnityEngine.TerrainCollider::set_terrainData");
			TerrainCollider.Raycast_InjectedDelegateField = IL2CPP.ResolveICall<TerrainCollider.Raycast_InjectedDelegate>("UnityEngine.TerrainCollider::Raycast_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public TerrainCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020EC File Offset: 0x000002EC
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		public TerrainData terrainData
		{
			get
			{
				IntPtr intPtr = TerrainCollider.get_terrainDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerrainData>(intPtr2) : null;
			}
			set
			{
				TerrainCollider.set_terrainDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002118 File Offset: 0x00000318
		public RaycastHit Raycast(Ray ray, float maxDistance, bool hitHoles, ref bool hasHit)
		{
			RaycastHit raycastHit;
			this.Raycast_Injected(ref ray, maxDistance, hitHoles, ref hasHit, out raycastHit);
			return raycastHit;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002134 File Offset: 0x00000334
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, bool hitHoles)
		{
			bool flag = false;
			hitInfo = this.Raycast(ray, maxDistance, hitHoles, ref flag);
			return flag;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002071 File Offset: 0x00000271
		public void Raycast_Injected(ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret)
		{
			TerrainCollider.Raycast_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref ray, maxDistance, hitHoles, ref hasHit, out ret);
		}

		// Token: 0x04000001 RID: 1
		private static readonly TerrainCollider.get_terrainDataDelegate get_terrainDataDelegateField;

		// Token: 0x04000002 RID: 2
		private static readonly TerrainCollider.set_terrainDataDelegate set_terrainDataDelegateField;

		// Token: 0x04000003 RID: 3
		private static readonly TerrainCollider.Raycast_InjectedDelegate Raycast_InjectedDelegateField;

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000009 RID: 9
		private delegate IntPtr get_terrainDataDelegate(IntPtr @this);

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600000B RID: 11
		private delegate void set_terrainDataDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600000D RID: 13
		private delegate void Raycast_InjectedDelegate(IntPtr @this, IntPtr ray, float maxDistance, bool hitHoles, IntPtr hasHit, [Out] IntPtr ret);
	}
}
