using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000002 RID: 2
	public class ITilemap : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000029A0 File Offset: 0x00000BA0
		// Note: this type is marked as 'beforefieldinit'.
		static ITilemap()
		{
			Il2CppClassPointerStore<ITilemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "ITilemap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ITilemap>.NativeClassPtr);
			ITilemap.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "s_Instance");
			ITilemap.NativeFieldInfoPtr_m_Tilemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "m_Tilemap");
			ITilemap.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663297);
			ITilemap.NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663298);
			ITilemap.NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002A34 File Offset: 0x00000C34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ITilemap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ITilemap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITilemap.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002A70 File Offset: 0x00000C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515599, XrefRangeEnd = 515601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTile(Vector3Int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITilemap.NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002AB0 File Offset: 0x00000CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515601, XrefRangeEnd = 515606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ITilemap CreateInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITilemap.NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITilemap>(intPtr3) : null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public ITilemap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002AE4 File Offset: 0x00000CE4
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static ITilemap s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ITilemap.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITilemap>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ITilemap.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002B0C File Offset: 0x00000D0C
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe Tilemap m_Tilemap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_Tilemap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_Tilemap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000208A File Offset: 0x0000028A
		public void SetTilemapInstance(Tilemap tilemap)
		{
			this.m_Tilemap = tilemap;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002B3C File Offset: 0x00000D3C
		public Vector3Int origin
		{
			get
			{
				return this.m_Tilemap.origin;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002B5C File Offset: 0x00000D5C
		public Vector3Int size
		{
			get
			{
				return this.m_Tilemap.size;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002B7C File Offset: 0x00000D7C
		public Bounds localBounds
		{
			get
			{
				return this.m_Tilemap.localBounds;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002B9C File Offset: 0x00000D9C
		public BoundsInt cellBounds
		{
			get
			{
				return this.m_Tilemap.cellBounds;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002BBC File Offset: 0x00000DBC
		public virtual Sprite GetSprite(Vector3Int position)
		{
			return this.m_Tilemap.GetSprite(position);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002BDC File Offset: 0x00000DDC
		public virtual Color GetColor(Vector3Int position)
		{
			return this.m_Tilemap.GetColor(position);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002BFC File Offset: 0x00000DFC
		public virtual Matrix4x4 GetTransformMatrix(Vector3Int position)
		{
			return this.m_Tilemap.GetTransformMatrix(position);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002C1C File Offset: 0x00000E1C
		public virtual TileFlags GetTileFlags(Vector3Int position)
		{
			return this.m_Tilemap.GetTileFlags(position);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002C3C File Offset: 0x00000E3C
		public virtual TileBase GetTile(Vector3Int position)
		{
			return this.m_Tilemap.GetTile(position);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C5C File Offset: 0x00000E5C
		public virtual T GetTile<T>(Vector3Int position) where T : TileBase
		{
			return this.m_Tilemap.GetTile<T>(position);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002C7C File Offset: 0x00000E7C
		public T GetComponent<T>()
		{
			return this.m_Tilemap.GetComponent<T>();
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_Tilemap;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0;
	}
}
