using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Experimental.TerrainAPI
{
	// Token: 0x02000005 RID: 5
	public static class TerrainUtility : Object
	{
		// Token: 0x060000FE RID: 254 RVA: 0x000055B8 File Offset: 0x000037B8
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainUtility()
		{
			Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine.Experimental.TerrainAPI", "TerrainUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr);
			TerrainUtility.NativeMethodInfoPtr_HasValidTerrains_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663328);
			TerrainUtility.NativeMethodInfoPtr_ClearConnectivity_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663329);
			TerrainUtility.NativeMethodInfoPtr_CollectTerrains_Internal_Static_TerrainGroups_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663330);
			TerrainUtility.NativeMethodInfoPtr_AutoConnect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663331);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005638 File Offset: 0x00003838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 514679, RefRangeEnd = 514681, XrefRangeStart = 514677, XrefRangeEnd = 514679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasValidTerrains()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_HasValidTerrains_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005668 File Offset: 0x00003868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514681, XrefRangeEnd = 514687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearConnectivity()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_ClearConnectivity_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00005690 File Offset: 0x00003890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 514717, RefRangeEnd = 514718, XrefRangeStart = 514687, XrefRangeEnd = 514717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TerrainUtility.TerrainGroups CollectTerrains(bool onlyAutoConnectedTerrains = true)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyAutoConnectedTerrains;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_CollectTerrains_Internal_Static_TerrainGroups_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TerrainUtility.TerrainGroups>(intPtr3) : null;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000056D0 File Offset: 0x000038D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514718, XrefRangeEnd = 514750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoConnect()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_AutoConnect_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002B3E File Offset: 0x00000D3E
		public TerrainUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_HasValidTerrains_Internal_Static_Boolean_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_ClearConnectivity_Internal_Static_Void_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_CollectTerrains_Internal_Static_TerrainGroups_Boolean_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_AutoConnect_Public_Static_Void_0;

		// Token: 0x020000A3 RID: 163
		public class TerrainMap : Object
		{
			// Token: 0x060002D5 RID: 725 RVA: 0x00006A94 File Offset: 0x00004C94
			// Note: this type is marked as 'beforefieldinit'.
			static TerrainMap()
			{
				Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, "TerrainMap");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr);
				TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_patchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "m_patchSize");
				TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_errorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "m_errorCode");
				TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_terrainTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "m_terrainTiles");
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663332);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_TerrainFilter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663333);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_TerrainFilter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663334);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663335);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663336);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663337);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663338);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_Validate_Private_ErrorCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663339);
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x00006B9C File Offset: 0x00004D9C
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 514368, RefRangeEnd = 514379, XrefRangeStart = 514366, XrefRangeEnd = 514368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Terrain GetTerrain(int tileX, int tileZ)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref tileX;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr3) : null;
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x00006BF8 File Offset: 0x00004DF8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 514436, RefRangeEnd = 514437, XrefRangeStart = 514379, XrefRangeEnd = 514436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TerrainUtility.TerrainMap CreateFromPlacement(Terrain originTerrain, TerrainUtility.TerrainMap.TerrainFilter filter = null, bool fullValidation = true)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(originTerrain);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullValidation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_TerrainFilter_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TerrainUtility.TerrainMap>(intPtr3) : null;
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x00006C5C File Offset: 0x00004E5C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 514476, RefRangeEnd = 514477, XrefRangeStart = 514437, XrefRangeEnd = 514476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TerrainUtility.TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, TerrainUtility.TerrainMap.TerrainFilter filter = null, bool fullValidation = true)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref gridOrigin;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridSize;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullValidation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_TerrainFilter_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TerrainUtility.TerrainMap>(intPtr3) : null;
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x00006CCC File Offset: 0x00004ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514477, XrefRangeEnd = 514482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TerrainMap()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002DA RID: 730 RVA: 0x00006D08 File Offset: 0x00004F08
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 514502, RefRangeEnd = 514503, XrefRangeStart = 514482, XrefRangeEnd = 514502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddTerrainInternal(int x, int z, Terrain terrain)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002DB RID: 731 RVA: 0x00006D68 File Offset: 0x00004F68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 514542, RefRangeEnd = 514543, XrefRangeStart = 514503, XrefRangeEnd = 514542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref tileX;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002DC RID: 732 RVA: 0x00006DD4 File Offset: 0x00004FD4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 514650, RefRangeEnd = 514651, XrefRangeStart = 514543, XrefRangeEnd = 514650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ValidateTerrain(int tileX, int tileZ)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref tileX;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002DD RID: 733 RVA: 0x00006E20 File Offset: 0x00005020
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 514665, RefRangeEnd = 514666, XrefRangeStart = 514651, XrefRangeEnd = 514665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TerrainUtility.TerrainMap.ErrorCode Validate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_Validate_Private_ErrorCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002DE RID: 734 RVA: 0x000032EB File Offset: 0x000014EB
			public TerrainMap(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060002DF RID: 735 RVA: 0x00006E5C File Offset: 0x0000505C
			// (set) Token: 0x060002E0 RID: 736 RVA: 0x000032F4 File Offset: 0x000014F4
			public unsafe Vector3 m_patchSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_patchSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_patchSize)) = value;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060002E1 RID: 737 RVA: 0x00006E84 File Offset: 0x00005084
			// (set) Token: 0x060002E2 RID: 738 RVA: 0x0000330F File Offset: 0x0000150F
			public unsafe TerrainUtility.TerrainMap.ErrorCode m_errorCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_errorCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_errorCode)) = value;
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060002E3 RID: 739 RVA: 0x00006EAC File Offset: 0x000050AC
			// (set) Token: 0x060002E4 RID: 740 RVA: 0x0000332A File Offset: 0x0000152A
			public unsafe Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain> m_terrainTiles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_terrainTiles);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_terrainTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400010D RID: 269
			private static readonly IntPtr NativeFieldInfoPtr_m_patchSize;

			// Token: 0x0400010E RID: 270
			private static readonly IntPtr NativeFieldInfoPtr_m_errorCode;

			// Token: 0x0400010F RID: 271
			private static readonly IntPtr NativeFieldInfoPtr_m_terrainTiles;

			// Token: 0x04000110 RID: 272
			private static readonly IntPtr NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0;

			// Token: 0x04000111 RID: 273
			private static readonly IntPtr NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_TerrainFilter_Boolean_0;

			// Token: 0x04000112 RID: 274
			private static readonly IntPtr NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_TerrainFilter_Boolean_0;

			// Token: 0x04000113 RID: 275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000114 RID: 276
			private static readonly IntPtr NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0;

			// Token: 0x04000115 RID: 277
			private static readonly IntPtr NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0;

			// Token: 0x04000116 RID: 278
			private static readonly IntPtr NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0;

			// Token: 0x04000117 RID: 279
			private static readonly IntPtr NativeMethodInfoPtr_Validate_Private_ErrorCode_0;

			// Token: 0x020000D5 RID: 213
			public sealed class TerrainFilter : MulticastDelegate
			{
				// Token: 0x06000335 RID: 821 RVA: 0x00007138 File Offset: 0x00005338
				// Note: this type is marked as 'beforefieldinit'.
				static TerrainFilter()
				{
					Il2CppClassPointerStore<TerrainUtility.TerrainMap.TerrainFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "TerrainFilter");
					TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TerrainFilter>.NativeClassPtr, 100663340);
					TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TerrainFilter>.NativeClassPtr, 100663341);
					TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Terrain_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TerrainFilter>.NativeClassPtr, 100663342);
					TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TerrainFilter>.NativeClassPtr, 100663343);
				}

				// Token: 0x06000336 RID: 822 RVA: 0x000071AC File Offset: 0x000053AC
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe TerrainFilter(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TerrainFilter>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000337 RID: 823 RVA: 0x00007208 File Offset: 0x00005408
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 514363, RefRangeEnd = 514364, XrefRangeStart = 514363, XrefRangeEnd = 514363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool Invoke(Terrain terrain)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06000338 RID: 824 RVA: 0x00007258 File Offset: 0x00005458
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(Terrain terrain, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Terrain_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06000339 RID: 825 RVA: 0x000072CC File Offset: 0x000054CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x0600033A RID: 826 RVA: 0x000033F1 File Offset: 0x000015F1
				public TerrainFilter(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600033B RID: 827 RVA: 0x000033FA File Offset: 0x000015FA
				public static implicit operator TerrainUtility.TerrainMap.TerrainFilter(Func<Terrain, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<TerrainUtility.TerrainMap.TerrainFilter>(A_0);
				}

				// Token: 0x0600033C RID: 828 RVA: 0x00003402 File Offset: 0x00001602
				public static TerrainUtility.TerrainMap.TerrainFilter operator +(TerrainUtility.TerrainMap.TerrainFilter A_0, TerrainUtility.TerrainMap.TerrainFilter A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<TerrainUtility.TerrainMap.TerrainFilter>();
				}

				// Token: 0x0600033D RID: 829 RVA: 0x00003410 File Offset: 0x00001610
				public static TerrainUtility.TerrainMap.TerrainFilter operator -(TerrainUtility.TerrainMap.TerrainFilter A_0, TerrainUtility.TerrainMap.TerrainFilter A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<TerrainUtility.TerrainMap.TerrainFilter>();
					}
					return delegate2;
				}

				// Token: 0x0400012C RID: 300
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400012D RID: 301
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Terrain_0;

				// Token: 0x0400012E RID: 302
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Terrain_AsyncCallback_Object_0;

				// Token: 0x0400012F RID: 303
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
			}

			// Token: 0x020000D6 RID: 214
			[StructLayout(2)]
			public struct TileCoord
			{
				// Token: 0x0600033E RID: 830 RVA: 0x0000731C File Offset: 0x0000551C
				// Note: this type is marked as 'beforefieldinit'.
				static TileCoord()
				{
					Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "TileCoord");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr);
					TerrainUtility.TerrainMap.TileCoord.NativeFieldInfoPtr_tileX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr, "tileX");
					TerrainUtility.TerrainMap.TileCoord.NativeFieldInfoPtr_tileZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr, "tileZ");
					TerrainUtility.TerrainMap.TileCoord.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr, 100663344);
				}

				// Token: 0x0600033F RID: 831 RVA: 0x00007384 File Offset: 0x00005584
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 76853, RefRangeEnd = 76855, XrefRangeStart = 76853, XrefRangeEnd = 76855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe TileCoord(int tileX, int tileZ)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref tileX;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.TileCoord.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000340 RID: 832 RVA: 0x00003421 File Offset: 0x00001621
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr, ref this));
				}

				// Token: 0x04000130 RID: 304
				private static readonly IntPtr NativeFieldInfoPtr_tileX;

				// Token: 0x04000131 RID: 305
				private static readonly IntPtr NativeFieldInfoPtr_tileZ;

				// Token: 0x04000132 RID: 306
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

				// Token: 0x04000133 RID: 307
				[FieldOffset(0)]
				public readonly int tileX;

				// Token: 0x04000134 RID: 308
				[FieldOffset(4)]
				public readonly int tileZ;
			}

			// Token: 0x020000D7 RID: 215
			[OriginalName("UnityEngine.TerrainModule.dll", "", "ErrorCode")]
			public enum ErrorCode
			{
				// Token: 0x04000136 RID: 310
				OK,
				// Token: 0x04000137 RID: 311
				Overlapping,
				// Token: 0x04000138 RID: 312
				SizeMismatch = 4,
				// Token: 0x04000139 RID: 313
				EdgeAlignmentMismatch = 8
			}

			// Token: 0x020000D8 RID: 216
			[ObfuscatedName("UnityEngine.Experimental.TerrainAPI.TerrainUtility+TerrainMap+<>c__DisplayClass4_0")]
			public sealed class __c__DisplayClass4_0 : Object
			{
				// Token: 0x06000341 RID: 833 RVA: 0x000073C4 File Offset: 0x000055C4
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass4_0()
				{
					Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "<>c__DisplayClass4_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr);
					TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeFieldInfoPtr_groupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr, "groupID");
					TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr, 100663345);
					TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr, 100663346);
				}

				// Token: 0x06000342 RID: 834 RVA: 0x0000742C File Offset: 0x0000562C
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass4_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000343 RID: 835 RVA: 0x00007468 File Offset: 0x00005668
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514364, XrefRangeEnd = 514366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CreateFromPlacement_b__0(Terrain x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06000344 RID: 836 RVA: 0x00003433 File Offset: 0x00001633
				public __c__DisplayClass4_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170000A7 RID: 167
				// (get) Token: 0x06000345 RID: 837 RVA: 0x000074B8 File Offset: 0x000056B8
				// (set) Token: 0x06000346 RID: 838 RVA: 0x0000343C File Offset: 0x0000163C
				public unsafe int groupID
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeFieldInfoPtr_groupID);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeFieldInfoPtr_groupID)) = value;
					}
				}

				// Token: 0x0400013A RID: 314
				private static readonly IntPtr NativeFieldInfoPtr_groupID;

				// Token: 0x0400013B RID: 315
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400013C RID: 316
				private static readonly IntPtr NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0;
			}

			// Token: 0x020000D9 RID: 217
			public sealed class <>c__DisplayClass4_0
			{
			}
		}

		// Token: 0x020000A4 RID: 164
		public class TerrainGroups : Dictionary<int, TerrainUtility.TerrainMap>
		{
			// Token: 0x060002E5 RID: 741 RVA: 0x00003349 File Offset: 0x00001549
			// Note: this type is marked as 'beforefieldinit'.
			static TerrainGroups()
			{
				Il2CppClassPointerStore<TerrainUtility.TerrainGroups>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, "TerrainGroups");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.TerrainGroups>.NativeClassPtr);
				TerrainUtility.TerrainGroups.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainGroups>.NativeClassPtr, 100663347);
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x00006EDC File Offset: 0x000050DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514666, XrefRangeEnd = 514669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TerrainGroups()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.TerrainGroups>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainGroups.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0000337D File Offset: 0x0000157D
			public TerrainGroups(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000118 RID: 280
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000A5 RID: 165
		[ObfuscatedName("UnityEngine.Experimental.TerrainAPI.TerrainUtility+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060002E8 RID: 744 RVA: 0x00006F18 File Offset: 0x00005118
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_0>.NativeClassPtr);
				TerrainUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_onlyAutoConnectedTerrains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_0>.NativeClassPtr, "onlyAutoConnectedTerrains");
				TerrainUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_0>.NativeClassPtr, 100663348);
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x00006F6C File Offset: 0x0000516C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EA RID: 746 RVA: 0x00003386 File Offset: 0x00001586
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x060002EB RID: 747 RVA: 0x00006FA8 File Offset: 0x000051A8
			// (set) Token: 0x060002EC RID: 748 RVA: 0x0000338F File Offset: 0x0000158F
			public unsafe bool onlyAutoConnectedTerrains
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_onlyAutoConnectedTerrains);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_onlyAutoConnectedTerrains)) = value;
				}
			}

			// Token: 0x04000119 RID: 281
			private static readonly IntPtr NativeFieldInfoPtr_onlyAutoConnectedTerrains;

			// Token: 0x0400011A RID: 282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000A6 RID: 166
		[ObfuscatedName("UnityEngine.Experimental.TerrainAPI.TerrainUtility+<>c__DisplayClass4_1")]
		public sealed class __c__DisplayClass4_1 : Object
		{
			// Token: 0x060002ED RID: 749 RVA: 0x00006FD0 File Offset: 0x000051D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_1()
			{
				Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, "<>c__DisplayClass4_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr);
				TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr, "t");
				TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr, "CS$<>8__locals1");
				TerrainUtility.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr, 100663349);
				TerrainUtility.__c__DisplayClass4_1.NativeMethodInfoPtr__CollectTerrains_b__0_Internal_Boolean_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr, 100663350);
			}

			// Token: 0x060002EE RID: 750 RVA: 0x0000704C File Offset: 0x0000524C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EF RID: 751 RVA: 0x00007088 File Offset: 0x00005288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514669, XrefRangeEnd = 514677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CollectTerrains_b__0(Terrain x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.__c__DisplayClass4_1.NativeMethodInfoPtr__CollectTerrains_b__0_Internal_Boolean_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002F0 RID: 752 RVA: 0x000033AA File Offset: 0x000015AA
			public __c__DisplayClass4_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060002F1 RID: 753 RVA: 0x000070D8 File Offset: 0x000052D8
			// (set) Token: 0x060002F2 RID: 754 RVA: 0x000033B3 File Offset: 0x000015B3
			public unsafe Terrain t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060002F3 RID: 755 RVA: 0x00007108 File Offset: 0x00005308
			// (set) Token: 0x060002F4 RID: 756 RVA: 0x000033D2 File Offset: 0x000015D2
			public unsafe TerrainUtility.__c__DisplayClass4_0 field_Public___c__DisplayClass4_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerrainUtility.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400011B RID: 283
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x0400011C RID: 284
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0;

			// Token: 0x0400011D RID: 285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400011E RID: 286
			private static readonly IntPtr NativeMethodInfoPtr__CollectTerrains_b__0_Internal_Boolean_Terrain_0;
		}

		// Token: 0x020000A7 RID: 167
		public sealed class <>c__DisplayClass4_0
		{
		}

		// Token: 0x020000A8 RID: 168
		public sealed class <>c__DisplayClass4_1
		{
		}
	}
}
