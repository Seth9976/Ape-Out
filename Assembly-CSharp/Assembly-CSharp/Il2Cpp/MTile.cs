using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200012C RID: 300
	[Serializable]
	public class MTile : global::Il2CppSystem.Object
	{
		// Token: 0x06002556 RID: 9558 RVA: 0x0009BFB4 File Offset: 0x0009A1B4
		// Note: this type is marked as 'beforefieldinit'.
		static MTile()
		{
			Il2CppClassPointerStore<MTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MTile>.NativeClassPtr);
			MTile.NativeFieldInfoPtr_sides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MTile>.NativeClassPtr, "sides");
			MTile.NativeFieldInfoPtr_originalSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MTile>.NativeClassPtr, "originalSides");
			MTile.NativeFieldInfoPtr_originalWidths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MTile>.NativeClassPtr, "originalWidths");
			MTile.NativeFieldInfoPtr_localPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MTile>.NativeClassPtr, "localPos");
			MTile.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MTile>.NativeClassPtr, "pos");
			MTile.NativeFieldInfoPtr_tileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MTile>.NativeClassPtr, "tileSize");
			MTile.NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MTile>.NativeClassPtr, "res");
			MTile.NativeFieldInfoPtr_mapTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MTile>.NativeClassPtr, "mapTile");
			MTile.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MTile>.NativeClassPtr, "id");
			MTile.NativeFieldInfoPtr_doorWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MTile>.NativeClassPtr, "doorWidth");
			MTile.NativeMethodInfoPtr__ctor_Public_Void_Vector2_MapTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MTile>.NativeClassPtr, 100666260);
			MTile.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MTile>.NativeClassPtr, 100666261);
			MTile.NativeMethodInfoPtr_UpdateDoorways_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MTile>.NativeClassPtr, 100666262);
			MTile.NativeMethodInfoPtr_CheckCol_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MTile>.NativeClassPtr, 100666263);
			MTile.NativeMethodInfoPtr_GetSides_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MTile>.NativeClassPtr, 100666264);
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x0009C110 File Offset: 0x0009A310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73262, XrefRangeEnd = 73268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MTile(Vector2 _pos, MapTile til)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MTile>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(til);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MTile.NativeMethodInfoPtr__ctor_Public_Void_Vector2_MapTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x0009C16C File Offset: 0x0009A36C
		[CallerCount(0)]
		public unsafe MTile(Vector2 _pos, Il2CppStructArray<int> _sides, int _id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MTile>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_sides);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MTile.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x0009C1D4 File Offset: 0x0009A3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73280, RefRangeEnd = 73281, XrefRangeStart = 73268, XrefRangeEnd = 73280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDoorways()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MTile.NativeMethodInfoPtr_UpdateDoorways_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x0009C208 File Offset: 0x0009A408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73310, RefRangeEnd = 73311, XrefRangeStart = 73281, XrefRangeEnd = 73310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCol(Vector2 pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MTile.NativeMethodInfoPtr_CheckCol_Public_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x0009C254 File Offset: 0x0009A454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73339, RefRangeEnd = 73340, XrefRangeStart = 73311, XrefRangeEnd = 73339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSides()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MTile.NativeMethodInfoPtr_GetSides_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x0001A2B6 File Offset: 0x000184B6
		public MTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x0009C288 File Offset: 0x0009A488
		// (set) Token: 0x0600255E RID: 9566 RVA: 0x0001A2BF File Offset: 0x000184BF
		public unsafe Il2CppStructArray<int> sides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_sides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_sides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x0009C2B8 File Offset: 0x0009A4B8
		// (set) Token: 0x06002560 RID: 9568 RVA: 0x0001A2DE File Offset: 0x000184DE
		public unsafe Il2CppStructArray<int> originalSides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_originalSides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_originalSides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x0009C2E8 File Offset: 0x0009A4E8
		// (set) Token: 0x06002562 RID: 9570 RVA: 0x0001A2FD File Offset: 0x000184FD
		public unsafe Il2CppStructArray<int> originalWidths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_originalWidths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_originalWidths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x0009C318 File Offset: 0x0009A518
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x0001A31C File Offset: 0x0001851C
		public unsafe Vector2 localPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_localPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_localPos)) = value;
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x0009C340 File Offset: 0x0009A540
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x0001A337 File Offset: 0x00018537
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x0009C368 File Offset: 0x0009A568
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x0001A352 File Offset: 0x00018552
		public unsafe float tileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_tileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_tileSize)) = value;
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x0009C390 File Offset: 0x0009A590
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x0001A36D File Offset: 0x0001856D
		public unsafe float res
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_res);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_res)) = value;
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x0009C3B8 File Offset: 0x0009A5B8
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x0001A388 File Offset: 0x00018588
		public unsafe MapTile mapTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_mapTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_mapTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x0009C3E8 File Offset: 0x0009A5E8
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x0001A3A7 File Offset: 0x000185A7
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x0009C410 File Offset: 0x0009A610
		// (set) Token: 0x06002570 RID: 9584 RVA: 0x0001A3C2 File Offset: 0x000185C2
		public unsafe Il2CppStructArray<int> doorWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_doorWidth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MTile.NativeFieldInfoPtr_doorWidth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeFieldInfoPtr_sides;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeFieldInfoPtr_originalSides;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeFieldInfoPtr_originalWidths;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeFieldInfoPtr_localPos;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeFieldInfoPtr_tileSize;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeFieldInfoPtr_res;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeFieldInfoPtr_mapTile;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeFieldInfoPtr_doorWidth;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_MapTile_0;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDoorways_Public_Void_0;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeMethodInfoPtr_CheckCol_Public_Boolean_Vector2_0;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeMethodInfoPtr_GetSides_Public_Void_0;
	}
}
