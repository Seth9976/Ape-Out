using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Tilemaps
{
	// Token: 0x0200000C RID: 12
	public sealed class TilemapCollider2D : Collider2D
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002932 File Offset: 0x00000B32
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002944 File Offset: 0x00000B44
		public uint maximumTileChangeCount
		{
			get
			{
				return TilemapCollider2D.get_maximumTileChangeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapCollider2D.set_maximumTileChangeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002957 File Offset: 0x00000B57
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002969 File Offset: 0x00000B69
		public float extrusionFactor
		{
			get
			{
				return TilemapCollider2D.get_extrusionFactorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapCollider2D.set_extrusionFactorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000297C File Offset: 0x00000B7C
		public bool hasTilemapChanges
		{
			get
			{
				return TilemapCollider2D.get_hasTilemapChangesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000298E File Offset: 0x00000B8E
		public void ProcessTilemapChanges()
		{
			TilemapCollider2D.ProcessTilemapChangesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0400007A RID: 122
		private static readonly TilemapCollider2D.get_maximumTileChangeCountDelegate get_maximumTileChangeCountDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.get_maximumTileChangeCountDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_maximumTileChangeCount");

		// Token: 0x0400007B RID: 123
		private static readonly TilemapCollider2D.set_maximumTileChangeCountDelegate set_maximumTileChangeCountDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.set_maximumTileChangeCountDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::set_maximumTileChangeCount");

		// Token: 0x0400007C RID: 124
		private static readonly TilemapCollider2D.get_extrusionFactorDelegate get_extrusionFactorDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.get_extrusionFactorDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_extrusionFactor");

		// Token: 0x0400007D RID: 125
		private static readonly TilemapCollider2D.set_extrusionFactorDelegate set_extrusionFactorDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.set_extrusionFactorDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::set_extrusionFactor");

		// Token: 0x0400007E RID: 126
		private static readonly TilemapCollider2D.get_hasTilemapChangesDelegate get_hasTilemapChangesDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.get_hasTilemapChangesDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_hasTilemapChanges");

		// Token: 0x0400007F RID: 127
		private static readonly TilemapCollider2D.ProcessTilemapChangesDelegate ProcessTilemapChangesDelegateField = IL2CPP.ResolveICall<TilemapCollider2D.ProcessTilemapChangesDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::ProcessTilemapChanges");

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x0600017B RID: 379
		private delegate uint get_maximumTileChangeCountDelegate(IntPtr @this);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x0600017D RID: 381
		private delegate void set_maximumTileChangeCountDelegate(IntPtr @this, uint value);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x0600017F RID: 383
		private delegate float get_extrusionFactorDelegate(IntPtr @this);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000181 RID: 385
		private delegate void set_extrusionFactorDelegate(IntPtr @this, float value);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000183 RID: 387
		private delegate bool get_hasTilemapChangesDelegate(IntPtr @this);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x06000185 RID: 389
		private delegate void ProcessTilemapChangesDelegate(IntPtr @this);
	}
}
