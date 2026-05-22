using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000005 RID: 5
	public sealed class Tilemap : GridLayout
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003674 File Offset: 0x00001874
		// Note: this type is marked as 'beforefieldinit'.
		static Tilemap()
		{
			Il2CppClassPointerStore<Tilemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "Tilemap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tilemap>.NativeClassPtr);
			Tilemap.NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663321);
			Tilemap.NativeMethodInfoPtr_RefreshTile_Injected_Private_Void_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663322);
			Tilemap.get_layoutGridDelegateField = IL2CPP.ResolveICall<Tilemap.get_layoutGridDelegate>("UnityEngine.Tilemaps.Tilemap::get_layoutGrid");
			Tilemap.get_animationFrameRateDelegateField = IL2CPP.ResolveICall<Tilemap.get_animationFrameRateDelegate>("UnityEngine.Tilemaps.Tilemap::get_animationFrameRate");
			Tilemap.set_animationFrameRateDelegateField = IL2CPP.ResolveICall<Tilemap.set_animationFrameRateDelegate>("UnityEngine.Tilemaps.Tilemap::set_animationFrameRate");
			Tilemap.get_orientationDelegateField = IL2CPP.ResolveICall<Tilemap.get_orientationDelegate>("UnityEngine.Tilemaps.Tilemap::get_orientation");
			Tilemap.set_orientationDelegateField = IL2CPP.ResolveICall<Tilemap.set_orientationDelegate>("UnityEngine.Tilemaps.Tilemap::set_orientation");
			Tilemap.SetTileAssetsDelegateField = IL2CPP.ResolveICall<Tilemap.SetTileAssetsDelegate>("UnityEngine.Tilemaps.Tilemap::SetTileAssets");
			Tilemap.RefreshAllTilesDelegateField = IL2CPP.ResolveICall<Tilemap.RefreshAllTilesDelegate>("UnityEngine.Tilemaps.Tilemap::RefreshAllTiles");
			Tilemap.SwapTileAssetDelegateField = IL2CPP.ResolveICall<Tilemap.SwapTileAssetDelegate>("UnityEngine.Tilemaps.Tilemap::SwapTileAsset");
			Tilemap.ContainsTileAssetDelegateField = IL2CPP.ResolveICall<Tilemap.ContainsTileAssetDelegate>("UnityEngine.Tilemaps.Tilemap::ContainsTileAsset");
			Tilemap.GetUsedTilesCountDelegateField = IL2CPP.ResolveICall<Tilemap.GetUsedTilesCountDelegate>("UnityEngine.Tilemaps.Tilemap::GetUsedTilesCount");
			Tilemap.Internal_GetUsedTilesNonAllocDelegateField = IL2CPP.ResolveICall<Tilemap.Internal_GetUsedTilesNonAllocDelegate>("UnityEngine.Tilemaps.Tilemap::Internal_GetUsedTilesNonAlloc");
			Tilemap.ClearAllTilesDelegateField = IL2CPP.ResolveICall<Tilemap.ClearAllTilesDelegate>("UnityEngine.Tilemaps.Tilemap::ClearAllTiles");
			Tilemap.ResizeBoundsDelegateField = IL2CPP.ResolveICall<Tilemap.ResizeBoundsDelegate>("UnityEngine.Tilemaps.Tilemap::ResizeBounds");
			Tilemap.CompressBoundsDelegateField = IL2CPP.ResolveICall<Tilemap.CompressBoundsDelegate>("UnityEngine.Tilemaps.Tilemap::CompressBounds");
			Tilemap.get_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_localBounds_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_localBounds_Injected");
			Tilemap.get_localFrameBounds_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_localFrameBounds_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_localFrameBounds_Injected");
			Tilemap.get_color_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_color_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_color_Injected");
			Tilemap.set_color_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.set_color_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_color_Injected");
			Tilemap.get_origin_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_origin_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_origin_Injected");
			Tilemap.set_origin_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.set_origin_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_origin_Injected");
			Tilemap.get_size_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_size_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_size_Injected");
			Tilemap.set_size_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.set_size_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_size_Injected");
			Tilemap.get_tileAnchor_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_tileAnchor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_tileAnchor_Injected");
			Tilemap.set_tileAnchor_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.set_tileAnchor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_tileAnchor_Injected");
			Tilemap.get_orientationMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_orientationMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_orientationMatrix_Injected");
			Tilemap.set_orientationMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.set_orientationMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_orientationMatrix_Injected");
			Tilemap.GetTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAsset_Injected");
			Tilemap.GetTileAssetsBlock_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTileAssetsBlock_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAssetsBlock_Injected");
			Tilemap.SetTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTileAsset_Injected");
			Tilemap.INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::INTERNAL_CALL_SetTileAssetsBlock_Injected");
			Tilemap.GetSprite_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetSprite_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetSprite_Injected");
			Tilemap.GetTransformMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTransformMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTransformMatrix_Injected");
			Tilemap.SetTransformMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetTransformMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTransformMatrix_Injected");
			Tilemap.GetColor_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetColor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetColor_Injected");
			Tilemap.SetColor_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetColor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetColor_Injected");
			Tilemap.GetTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileFlags_Injected");
			Tilemap.SetTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTileFlags_Injected");
			Tilemap.AddTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.AddTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::AddTileFlags_Injected");
			Tilemap.RemoveTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.RemoveTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::RemoveTileFlags_Injected");
			Tilemap.GetInstantiatedObject_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetInstantiatedObject_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetInstantiatedObject_Injected");
			Tilemap.GetObjectToInstantiate_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetObjectToInstantiate_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetObjectToInstantiate_Injected");
			Tilemap.SetColliderType_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetColliderType_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetColliderType_Injected");
			Tilemap.GetColliderType_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetColliderType_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetColliderType_Injected");
			Tilemap.FloodFillTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.FloodFillTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::FloodFillTileAsset_Injected");
			Tilemap.BoxFillTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.BoxFillTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::BoxFillTileAsset_Injected");
			Tilemap.InsertCells_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.InsertCells_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::InsertCells_Injected");
			Tilemap.DeleteCells_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.DeleteCells_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::DeleteCells_Injected");
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003990 File Offset: 0x00001B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515611, XrefRangeEnd = 515613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTile(Vector3Int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000039D0 File Offset: 0x00001BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515613, XrefRangeEnd = 515617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTile_Injected(ref Vector3Int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_RefreshTile_Injected_Private_Void_byref_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002150 File Offset: 0x00000350
		public Tilemap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003A10 File Offset: 0x00001C10
		public Grid layoutGrid
		{
			get
			{
				IntPtr intPtr = Tilemap.get_layoutGridDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003A3C File Offset: 0x00001C3C
		public Vector3 GetCellCenterLocal(Vector3Int position)
		{
			return base.CellToLocalInterpolated(position) + base.CellToLocalInterpolated(this.tileAnchor);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003A6C File Offset: 0x00001C6C
		public Vector3 GetCellCenterWorld(Vector3Int position)
		{
			return base.LocalToWorld(base.CellToLocalInterpolated(position) + base.CellToLocalInterpolated(this.tileAnchor));
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003AA4 File Offset: 0x00001CA4
		public BoundsInt cellBounds
		{
			get
			{
				return new BoundsInt(this.origin, this.size);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00003AC8 File Offset: 0x00001CC8
		public Bounds localBounds
		{
			get
			{
				Bounds bounds;
				this.get_localBounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public Bounds localFrameBounds
		{
			get
			{
				Bounds bounds;
				this.get_localFrameBounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002159 File Offset: 0x00000359
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0000216B File Offset: 0x0000036B
		public float animationFrameRate
		{
			get
			{
				return Tilemap.get_animationFrameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Tilemap.set_animationFrameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003AF8 File Offset: 0x00001CF8
		// (set) Token: 0x06000048 RID: 72 RVA: 0x0000217E File Offset: 0x0000037E
		public Color color
		{
			get
			{
				Color color;
				this.get_color_Injected(out color);
				return color;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00003B10 File Offset: 0x00001D10
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002188 File Offset: 0x00000388
		public Vector3Int origin
		{
			get
			{
				Vector3Int vector3Int;
				this.get_origin_Injected(out vector3Int);
				return vector3Int;
			}
			set
			{
				this.set_origin_Injected(ref value);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003B28 File Offset: 0x00001D28
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002192 File Offset: 0x00000392
		public Vector3Int size
		{
			get
			{
				Vector3Int vector3Int;
				this.get_size_Injected(out vector3Int);
				return vector3Int;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003B40 File Offset: 0x00001D40
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000219C File Offset: 0x0000039C
		public Vector3 tileAnchor
		{
			get
			{
				Vector3 vector;
				this.get_tileAnchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_tileAnchor_Injected(ref value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000021A6 File Offset: 0x000003A6
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000021B8 File Offset: 0x000003B8
		public Tilemap.Orientation orientation
		{
			get
			{
				return Tilemap.get_orientationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Tilemap.set_orientationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003B58 File Offset: 0x00001D58
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000021CB File Offset: 0x000003CB
		public Matrix4x4 orientationMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_orientationMatrix_Injected(out matrix4x);
				return matrix4x;
			}
			set
			{
				this.set_orientationMatrix_Injected(ref value);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000021D5 File Offset: 0x000003D5
		public Object GetTileAsset(Vector3Int position)
		{
			return this.GetTileAsset_Injected(ref position);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003B70 File Offset: 0x00001D70
		public TileBase GetTile(Vector3Int position)
		{
			return this.GetTileAsset(position).TryCast<TileBase>();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003B90 File Offset: 0x00001D90
		public T GetTile<T>(Vector3Int position) where T : TileBase
		{
			return this.GetTileAsset(position).TryCast<T>().Cast<T>();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000021DF File Offset: 0x000003DF
		public Il2CppReferenceArray<Object> GetTileAssetsBlock(Vector3Int position, Vector3Int blockDimensions)
		{
			return this.GetTileAssetsBlock_Injected(ref position, ref blockDimensions);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000021EB File Offset: 0x000003EB
		public Il2CppReferenceArray<TileBase> GetTilesBlock(BoundsInt bounds)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000021F8 File Offset: 0x000003F8
		public void SetTileAsset(Vector3Int position, Object tile)
		{
			this.SetTileAsset_Injected(ref position, tile);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002203 File Offset: 0x00000403
		public void SetTile(Vector3Int position, TileBase tile)
		{
			this.SetTileAsset(position, tile);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000220F File Offset: 0x0000040F
		public void SetTileAssets(Il2CppStructArray<Vector3Int> positionArray, Il2CppReferenceArray<Object> tileArray)
		{
			Tilemap.SetTileAssetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positionArray), IL2CPP.Il2CppObjectBaseToPtr(tileArray));
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003BB4 File Offset: 0x00001DB4
		public void SetTiles(Il2CppStructArray<Vector3Int> positionArray, Il2CppReferenceArray<TileBase> tileArray)
		{
			this.SetTileAssets(positionArray, tileArray);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000222D File Offset: 0x0000042D
		public void INTERNAL_CALL_SetTileAssetsBlock(Vector3Int position, Vector3Int blockDimensions, Il2CppReferenceArray<Object> tileArray)
		{
			this.INTERNAL_CALL_SetTileAssetsBlock_Injected(ref position, ref blockDimensions, tileArray);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public void SetTilesBlock(BoundsInt position, Il2CppReferenceArray<TileBase> tileArray)
		{
			this.INTERNAL_CALL_SetTileAssetsBlock(position.min, position.size, tileArray);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003BF8 File Offset: 0x00001DF8
		public bool HasTile(Vector3Int position)
		{
			return this.GetTileAsset(position) != null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000223A File Offset: 0x0000043A
		public void RefreshAllTiles()
		{
			Tilemap.RefreshAllTilesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000224C File Offset: 0x0000044C
		public void SwapTileAsset(Object changeTile, Object newTile)
		{
			Tilemap.SwapTileAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(changeTile), IL2CPP.Il2CppObjectBaseToPtr(newTile));
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000226A File Offset: 0x0000046A
		public void SwapTile(TileBase changeTile, TileBase newTile)
		{
			this.SwapTileAsset(changeTile, newTile);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002276 File Offset: 0x00000476
		public bool ContainsTileAsset(Object tileAsset)
		{
			return Tilemap.ContainsTileAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(tileAsset));
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003C18 File Offset: 0x00001E18
		public bool ContainsTile(TileBase tileAsset)
		{
			return this.ContainsTileAsset(tileAsset);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000228E File Offset: 0x0000048E
		public int GetUsedTilesCount()
		{
			return Tilemap.GetUsedTilesCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003C34 File Offset: 0x00001E34
		public int GetUsedTilesNonAlloc(Il2CppReferenceArray<TileBase> usedTiles)
		{
			return this.Internal_GetUsedTilesNonAlloc(usedTiles);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000022A0 File Offset: 0x000004A0
		public int Internal_GetUsedTilesNonAlloc(Il2CppReferenceArray<Object> usedTiles)
		{
			return Tilemap.Internal_GetUsedTilesNonAllocDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(usedTiles));
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000022B8 File Offset: 0x000004B8
		public Sprite GetSprite(Vector3Int position)
		{
			return this.GetSprite_Injected(ref position);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003C50 File Offset: 0x00001E50
		public Matrix4x4 GetTransformMatrix(Vector3Int position)
		{
			Matrix4x4 matrix4x;
			this.GetTransformMatrix_Injected(ref position, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000022C2 File Offset: 0x000004C2
		public void SetTransformMatrix(Vector3Int position, Matrix4x4 transform)
		{
			this.SetTransformMatrix_Injected(ref position, ref transform);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003C68 File Offset: 0x00001E68
		public Color GetColor(Vector3Int position)
		{
			Color color;
			this.GetColor_Injected(ref position, out color);
			return color;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000022CE File Offset: 0x000004CE
		public void SetColor(Vector3Int position, Color color)
		{
			this.SetColor_Injected(ref position, ref color);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000022DA File Offset: 0x000004DA
		public TileFlags GetTileFlags(Vector3Int position)
		{
			return this.GetTileFlags_Injected(ref position);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000022E4 File Offset: 0x000004E4
		public void SetTileFlags(Vector3Int position, TileFlags flags)
		{
			this.SetTileFlags_Injected(ref position, flags);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000022EF File Offset: 0x000004EF
		public void AddTileFlags(Vector3Int position, TileFlags flags)
		{
			this.AddTileFlags_Injected(ref position, flags);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000022FA File Offset: 0x000004FA
		public void RemoveTileFlags(Vector3Int position, TileFlags flags)
		{
			this.RemoveTileFlags_Injected(ref position, flags);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002305 File Offset: 0x00000505
		public GameObject GetInstantiatedObject(Vector3Int position)
		{
			return this.GetInstantiatedObject_Injected(ref position);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000230F File Offset: 0x0000050F
		public GameObject GetObjectToInstantiate(Vector3Int position)
		{
			return this.GetObjectToInstantiate_Injected(ref position);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002319 File Offset: 0x00000519
		public void SetColliderType(Vector3Int position, Tile.ColliderType colliderType)
		{
			this.SetColliderType_Injected(ref position, colliderType);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002324 File Offset: 0x00000524
		public Tile.ColliderType GetColliderType(Vector3Int position)
		{
			return this.GetColliderType_Injected(ref position);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000232E File Offset: 0x0000052E
		public void FloodFill(Vector3Int position, TileBase tile)
		{
			this.FloodFillTileAsset(position, tile);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000233A File Offset: 0x0000053A
		public void FloodFillTileAsset(Vector3Int position, Object tile)
		{
			this.FloodFillTileAsset_Injected(ref position, tile);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002345 File Offset: 0x00000545
		public void BoxFill(Vector3Int position, TileBase tile, int startX, int startY, int endX, int endY)
		{
			this.BoxFillTileAsset(position, tile, startX, startY, endX, endY);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002358 File Offset: 0x00000558
		public void BoxFillTileAsset(Vector3Int position, Object tile, int startX, int startY, int endX, int endY)
		{
			this.BoxFillTileAsset_Injected(ref position, tile, startX, startY, endX, endY);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000236A File Offset: 0x0000056A
		public void InsertCells(Vector3Int position, Vector3Int insertCells)
		{
			this.InsertCells(position, insertCells.x, insertCells.y, insertCells.z);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000238A File Offset: 0x0000058A
		public void InsertCells(Vector3Int position, int numColumns, int numRows, int numLayers)
		{
			this.InsertCells_Injected(ref position, numColumns, numRows, numLayers);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002398 File Offset: 0x00000598
		public void DeleteCells(Vector3Int position, Vector3Int deleteCells)
		{
			this.DeleteCells(position, deleteCells.x, deleteCells.y, deleteCells.z);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000023B8 File Offset: 0x000005B8
		public void DeleteCells(Vector3Int position, int numColumns, int numRows, int numLayers)
		{
			this.DeleteCells_Injected(ref position, numColumns, numRows, numLayers);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000023C6 File Offset: 0x000005C6
		public void ClearAllTiles()
		{
			Tilemap.ClearAllTilesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000023D8 File Offset: 0x000005D8
		public void ResizeBounds()
		{
			Tilemap.ResizeBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000023EA File Offset: 0x000005EA
		public void CompressBounds()
		{
			Tilemap.CompressBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000023FC File Offset: 0x000005FC
		public void get_localBounds_Injected(out Bounds ret)
		{
			Tilemap.get_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000240F File Offset: 0x0000060F
		public void get_localFrameBounds_Injected(out Bounds ret)
		{
			Tilemap.get_localFrameBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002422 File Offset: 0x00000622
		public void get_color_Injected(out Color ret)
		{
			Tilemap.get_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002435 File Offset: 0x00000635
		public void set_color_Injected(ref Color value)
		{
			Tilemap.set_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002448 File Offset: 0x00000648
		public void get_origin_Injected(out Vector3Int ret)
		{
			Tilemap.get_origin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000245B File Offset: 0x0000065B
		public void set_origin_Injected(ref Vector3Int value)
		{
			Tilemap.set_origin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000246E File Offset: 0x0000066E
		public void get_size_Injected(out Vector3Int ret)
		{
			Tilemap.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002481 File Offset: 0x00000681
		public void set_size_Injected(ref Vector3Int value)
		{
			Tilemap.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002494 File Offset: 0x00000694
		public void get_tileAnchor_Injected(out Vector3 ret)
		{
			Tilemap.get_tileAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000024A7 File Offset: 0x000006A7
		public void set_tileAnchor_Injected(ref Vector3 value)
		{
			Tilemap.set_tileAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000024BA File Offset: 0x000006BA
		public void get_orientationMatrix_Injected(out Matrix4x4 ret)
		{
			Tilemap.get_orientationMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000024CD File Offset: 0x000006CD
		public void set_orientationMatrix_Injected(ref Matrix4x4 value)
		{
			Tilemap.set_orientationMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003C80 File Offset: 0x00001E80
		public Object GetTileAsset_Injected(ref Vector3Int position)
		{
			IntPtr intPtr = Tilemap.GetTileAsset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003CB0 File Offset: 0x00001EB0
		public Il2CppReferenceArray<Object> GetTileAssetsBlock_Injected(ref Vector3Int position, ref Vector3Int blockDimensions)
		{
			IntPtr intPtr = Tilemap.GetTileAssetsBlock_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref blockDimensions);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000024E0 File Offset: 0x000006E0
		public void SetTileAsset_Injected(ref Vector3Int position, Object tile)
		{
			Tilemap.SetTileAsset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(tile));
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000024F9 File Offset: 0x000006F9
		public void INTERNAL_CALL_SetTileAssetsBlock_Injected(ref Vector3Int position, ref Vector3Int blockDimensions, Il2CppReferenceArray<Object> tileArray)
		{
			Tilemap.INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref blockDimensions, IL2CPP.Il2CppObjectBaseToPtr(tileArray));
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003CE0 File Offset: 0x00001EE0
		public Sprite GetSprite_Injected(ref Vector3Int position)
		{
			IntPtr intPtr = Tilemap.GetSprite_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002513 File Offset: 0x00000713
		public void GetTransformMatrix_Injected(ref Vector3Int position, out Matrix4x4 ret)
		{
			Tilemap.GetTransformMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, out ret);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002527 File Offset: 0x00000727
		public void SetTransformMatrix_Injected(ref Vector3Int position, ref Matrix4x4 transform)
		{
			Tilemap.SetTransformMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref transform);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000253B File Offset: 0x0000073B
		public void GetColor_Injected(ref Vector3Int position, out Color ret)
		{
			Tilemap.GetColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, out ret);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000254F File Offset: 0x0000074F
		public void SetColor_Injected(ref Vector3Int position, ref Color color)
		{
			Tilemap.SetColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref color);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002563 File Offset: 0x00000763
		public TileFlags GetTileFlags_Injected(ref Vector3Int position)
		{
			return Tilemap.GetTileFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002576 File Offset: 0x00000776
		public void SetTileFlags_Injected(ref Vector3Int position, TileFlags flags)
		{
			Tilemap.SetTileFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, flags);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000258A File Offset: 0x0000078A
		public void AddTileFlags_Injected(ref Vector3Int position, TileFlags flags)
		{
			Tilemap.AddTileFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, flags);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000259E File Offset: 0x0000079E
		public void RemoveTileFlags_Injected(ref Vector3Int position, TileFlags flags)
		{
			Tilemap.RemoveTileFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, flags);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003D10 File Offset: 0x00001F10
		public GameObject GetInstantiatedObject_Injected(ref Vector3Int position)
		{
			IntPtr intPtr = Tilemap.GetInstantiatedObject_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003D40 File Offset: 0x00001F40
		public GameObject GetObjectToInstantiate_Injected(ref Vector3Int position)
		{
			IntPtr intPtr = Tilemap.GetObjectToInstantiate_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000025B2 File Offset: 0x000007B2
		public void SetColliderType_Injected(ref Vector3Int position, Tile.ColliderType colliderType)
		{
			Tilemap.SetColliderType_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, colliderType);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000025C6 File Offset: 0x000007C6
		public Tile.ColliderType GetColliderType_Injected(ref Vector3Int position)
		{
			return Tilemap.GetColliderType_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000025D9 File Offset: 0x000007D9
		public void FloodFillTileAsset_Injected(ref Vector3Int position, Object tile)
		{
			Tilemap.FloodFillTileAsset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(tile));
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000025F2 File Offset: 0x000007F2
		public void BoxFillTileAsset_Injected(ref Vector3Int position, Object tile, int startX, int startY, int endX, int endY)
		{
			Tilemap.BoxFillTileAsset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(tile), startX, startY, endX, endY);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002612 File Offset: 0x00000812
		public void InsertCells_Injected(ref Vector3Int position, int numColumns, int numRows, int numLayers)
		{
			Tilemap.InsertCells_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, numColumns, numRows, numLayers);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002629 File Offset: 0x00000829
		public void DeleteCells_Injected(ref Vector3Int position, int numColumns, int numRows, int numLayers)
		{
			Tilemap.DeleteCells_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, numColumns, numRows, numLayers);
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTile_Injected_Private_Void_byref_Vector3Int_0;

		// Token: 0x04000023 RID: 35
		private static readonly Tilemap.get_layoutGridDelegate get_layoutGridDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly Tilemap.get_animationFrameRateDelegate get_animationFrameRateDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly Tilemap.set_animationFrameRateDelegate set_animationFrameRateDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly Tilemap.get_orientationDelegate get_orientationDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly Tilemap.set_orientationDelegate set_orientationDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly Tilemap.SetTileAssetsDelegate SetTileAssetsDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly Tilemap.RefreshAllTilesDelegate RefreshAllTilesDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly Tilemap.SwapTileAssetDelegate SwapTileAssetDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly Tilemap.ContainsTileAssetDelegate ContainsTileAssetDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly Tilemap.GetUsedTilesCountDelegate GetUsedTilesCountDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly Tilemap.Internal_GetUsedTilesNonAllocDelegate Internal_GetUsedTilesNonAllocDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly Tilemap.ClearAllTilesDelegate ClearAllTilesDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly Tilemap.ResizeBoundsDelegate ResizeBoundsDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly Tilemap.CompressBoundsDelegate CompressBoundsDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly Tilemap.get_localBounds_InjectedDelegate get_localBounds_InjectedDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly Tilemap.get_localFrameBounds_InjectedDelegate get_localFrameBounds_InjectedDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly Tilemap.get_color_InjectedDelegate get_color_InjectedDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly Tilemap.set_color_InjectedDelegate set_color_InjectedDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly Tilemap.get_origin_InjectedDelegate get_origin_InjectedDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly Tilemap.set_origin_InjectedDelegate set_origin_InjectedDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly Tilemap.get_size_InjectedDelegate get_size_InjectedDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly Tilemap.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly Tilemap.get_tileAnchor_InjectedDelegate get_tileAnchor_InjectedDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly Tilemap.set_tileAnchor_InjectedDelegate set_tileAnchor_InjectedDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly Tilemap.get_orientationMatrix_InjectedDelegate get_orientationMatrix_InjectedDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly Tilemap.set_orientationMatrix_InjectedDelegate set_orientationMatrix_InjectedDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly Tilemap.GetTileAsset_InjectedDelegate GetTileAsset_InjectedDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly Tilemap.GetTileAssetsBlock_InjectedDelegate GetTileAssetsBlock_InjectedDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly Tilemap.SetTileAsset_InjectedDelegate SetTileAsset_InjectedDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly Tilemap.INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegate INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly Tilemap.GetSprite_InjectedDelegate GetSprite_InjectedDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly Tilemap.GetTransformMatrix_InjectedDelegate GetTransformMatrix_InjectedDelegateField;

		// Token: 0x04000043 RID: 67
		private static readonly Tilemap.SetTransformMatrix_InjectedDelegate SetTransformMatrix_InjectedDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly Tilemap.GetColor_InjectedDelegate GetColor_InjectedDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly Tilemap.SetColor_InjectedDelegate SetColor_InjectedDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly Tilemap.GetTileFlags_InjectedDelegate GetTileFlags_InjectedDelegateField;

		// Token: 0x04000047 RID: 71
		private static readonly Tilemap.SetTileFlags_InjectedDelegate SetTileFlags_InjectedDelegateField;

		// Token: 0x04000048 RID: 72
		private static readonly Tilemap.AddTileFlags_InjectedDelegate AddTileFlags_InjectedDelegateField;

		// Token: 0x04000049 RID: 73
		private static readonly Tilemap.RemoveTileFlags_InjectedDelegate RemoveTileFlags_InjectedDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly Tilemap.GetInstantiatedObject_InjectedDelegate GetInstantiatedObject_InjectedDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly Tilemap.GetObjectToInstantiate_InjectedDelegate GetObjectToInstantiate_InjectedDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly Tilemap.SetColliderType_InjectedDelegate SetColliderType_InjectedDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly Tilemap.GetColliderType_InjectedDelegate GetColliderType_InjectedDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly Tilemap.FloodFillTileAsset_InjectedDelegate FloodFillTileAsset_InjectedDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly Tilemap.BoxFillTileAsset_InjectedDelegate BoxFillTileAsset_InjectedDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly Tilemap.InsertCells_InjectedDelegate InsertCells_InjectedDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly Tilemap.DeleteCells_InjectedDelegate DeleteCells_InjectedDelegateField;

		// Token: 0x0200000E RID: 14
		public enum Orientation
		{
			// Token: 0x04000085 RID: 133
			XY,
			// Token: 0x04000086 RID: 134
			XZ,
			// Token: 0x04000087 RID: 135
			YX,
			// Token: 0x04000088 RID: 136
			YZ,
			// Token: 0x04000089 RID: 137
			ZX,
			// Token: 0x0400008A RID: 138
			ZY,
			// Token: 0x0400008B RID: 139
			Custom
		}

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x060000FD RID: 253
		private delegate IntPtr get_layoutGridDelegate(IntPtr @this);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x060000FF RID: 255
		private delegate float get_animationFrameRateDelegate(IntPtr @this);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000101 RID: 257
		private delegate void set_animationFrameRateDelegate(IntPtr @this, float value);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000103 RID: 259
		private delegate Tilemap.Orientation get_orientationDelegate(IntPtr @this);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000105 RID: 261
		private delegate void set_orientationDelegate(IntPtr @this, Tilemap.Orientation value);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000107 RID: 263
		private delegate void SetTileAssetsDelegate(IntPtr @this, IntPtr positionArray, IntPtr tileArray);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000109 RID: 265
		private delegate void RefreshAllTilesDelegate(IntPtr @this);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x0600010B RID: 267
		private delegate void SwapTileAssetDelegate(IntPtr @this, IntPtr changeTile, IntPtr newTile);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600010D RID: 269
		private delegate bool ContainsTileAssetDelegate(IntPtr @this, IntPtr tileAsset);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600010F RID: 271
		private delegate int GetUsedTilesCountDelegate(IntPtr @this);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000111 RID: 273
		private delegate int Internal_GetUsedTilesNonAllocDelegate(IntPtr @this, IntPtr usedTiles);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000113 RID: 275
		private delegate void ClearAllTilesDelegate(IntPtr @this);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000115 RID: 277
		private delegate void ResizeBoundsDelegate(IntPtr @this);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000117 RID: 279
		private delegate void CompressBoundsDelegate(IntPtr @this);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000119 RID: 281
		private delegate void get_localBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x0600011B RID: 283
		private delegate void get_localFrameBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x0600011D RID: 285
		private delegate void get_color_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x0600011F RID: 287
		private delegate void set_color_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x06000121 RID: 289
		private delegate void get_origin_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000123 RID: 291
		private delegate void set_origin_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000125 RID: 293
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000127 RID: 295
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000129 RID: 297
		private delegate void get_tileAnchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x0600012B RID: 299
		private delegate void set_tileAnchor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x0600012D RID: 301
		private delegate void get_orientationMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x0600012F RID: 303
		private delegate void set_orientationMatrix_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000131 RID: 305
		private delegate IntPtr GetTileAsset_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000133 RID: 307
		private delegate IntPtr GetTileAssetsBlock_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr blockDimensions);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000135 RID: 309
		private delegate void SetTileAsset_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr tile);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000137 RID: 311
		private delegate void INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr blockDimensions, IntPtr tileArray);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000139 RID: 313
		private delegate IntPtr GetSprite_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x0600013B RID: 315
		private delegate void GetTransformMatrix_InjectedDelegate(IntPtr @this, IntPtr position, [Out] IntPtr ret);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x0600013D RID: 317
		private delegate void SetTransformMatrix_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr transform);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600013F RID: 319
		private delegate void GetColor_InjectedDelegate(IntPtr @this, IntPtr position, [Out] IntPtr ret);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000141 RID: 321
		private delegate void SetColor_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr color);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000143 RID: 323
		private delegate TileFlags GetTileFlags_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000145 RID: 325
		private delegate void SetTileFlags_InjectedDelegate(IntPtr @this, IntPtr position, TileFlags flags);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000147 RID: 327
		private delegate void AddTileFlags_InjectedDelegate(IntPtr @this, IntPtr position, TileFlags flags);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000149 RID: 329
		private delegate void RemoveTileFlags_InjectedDelegate(IntPtr @this, IntPtr position, TileFlags flags);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x0600014B RID: 331
		private delegate IntPtr GetInstantiatedObject_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600014D RID: 333
		private delegate IntPtr GetObjectToInstantiate_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x0600014F RID: 335
		private delegate void SetColliderType_InjectedDelegate(IntPtr @this, IntPtr position, Tile.ColliderType colliderType);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000151 RID: 337
		private delegate Tile.ColliderType GetColliderType_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000153 RID: 339
		private delegate void FloodFillTileAsset_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr tile);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000155 RID: 341
		private delegate void BoxFillTileAsset_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr tile, int startX, int startY, int endX, int endY);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000157 RID: 343
		private delegate void InsertCells_InjectedDelegate(IntPtr @this, IntPtr position, int numColumns, int numRows, int numLayers);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000159 RID: 345
		private delegate void DeleteCells_InjectedDelegate(IntPtr @this, IntPtr position, int numColumns, int numRows, int numLayers);
	}
}
