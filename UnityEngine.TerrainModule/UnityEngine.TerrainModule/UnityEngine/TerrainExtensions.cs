using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public static class TerrainExtensions
	{
		// Token: 0x06000105 RID: 261 RVA: 0x000056F8 File Offset: 0x000038F8
		public static void UpdateGIMaterials(Terrain terrain)
		{
			bool flag = terrain.terrainData == null;
			if (flag)
			{
				throw new ArgumentException("Invalid terrainData.");
			}
			TerrainExtensions.UpdateGIMaterialsForTerrain(terrain.GetInstanceID(), new Rect(0f, 0f, 1f, 1f));
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005748 File Offset: 0x00003948
		public static void UpdateGIMaterials(Terrain terrain, int x, int y, int width, int height)
		{
			bool flag = terrain.terrainData == null;
			if (flag)
			{
				throw new ArgumentException("Invalid terrainData.");
			}
			float num = (float)terrain.terrainData.alphamapWidth;
			float num2 = (float)terrain.terrainData.alphamapHeight;
			TerrainExtensions.UpdateGIMaterialsForTerrain(terrain.GetInstanceID(), new Rect((float)x / num, (float)y / num2, (float)width / num, (float)height / num2));
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002B58 File Offset: 0x00000D58
		public static void UpdateGIMaterialsForTerrain(int terrainInstanceID, Rect uvBounds)
		{
			TerrainExtensions.UpdateGIMaterialsForTerrain_Injected(terrainInstanceID, ref uvBounds);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002B62 File Offset: 0x00000D62
		public static void UpdateGIMaterialsForTerrain_Injected(int terrainInstanceID, ref Rect uvBounds)
		{
			TerrainExtensions.UpdateGIMaterialsForTerrain_InjectedDelegateField(terrainInstanceID, ref uvBounds);
		}

		// Token: 0x040000C8 RID: 200
		private static readonly TerrainExtensions.UpdateGIMaterialsForTerrain_InjectedDelegate UpdateGIMaterialsForTerrain_InjectedDelegateField = IL2CPP.ResolveICall<TerrainExtensions.UpdateGIMaterialsForTerrain_InjectedDelegate>("UnityEngine.TerrainExtensions::UpdateGIMaterialsForTerrain_Injected");

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x060002F6 RID: 758
		private delegate void UpdateGIMaterialsForTerrain_InjectedDelegate(int terrainInstanceID, IntPtr uvBounds);
	}
}
