using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001C5 RID: 453
	public class TileBags : ScriptableObject
	{
		// Token: 0x060031EB RID: 12779 RVA: 0x000BD8B4 File Offset: 0x000BBAB4
		// Note: this type is marked as 'beforefieldinit'.
		static TileBags()
		{
			Il2CppClassPointerStore<TileBags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TileBags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBags>.NativeClassPtr);
			TileBags.NativeFieldInfoPtr_worldInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "worldInd");
			TileBags.NativeFieldInfoPtr_labopenTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "labopenTileArr");
			TileBags.NativeFieldInfoPtr_labtightTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "labtightTileArr");
			TileBags.NativeFieldInfoPtr_stealthTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "stealthTileArr");
			TileBags.NativeFieldInfoPtr_hallTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "hallTileArr");
			TileBags.NativeFieldInfoPtr_setPieceArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "setPieceArr");
			TileBags.NativeFieldInfoPtr_staticTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "staticTileArr");
			TileBags.NativeFieldInfoPtr_specialLvlTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "specialLvlTileArr");
			TileBags.NativeFieldInfoPtr_bunkerhallTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "bunkerhallTileArr");
			TileBags.NativeFieldInfoPtr_bunkerroomTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "bunkerroomTileArr");
			TileBags.NativeFieldInfoPtr_bunkerroomblownTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "bunkerroomblownTileArr");
			TileBags.NativeFieldInfoPtr_bunkerhallblownTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "bunkerhallblownTileArr");
			TileBags.NativeFieldInfoPtr_hangerTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "hangerTileArr");
			TileBags.NativeFieldInfoPtr_zooTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "zooTileArr");
			TileBags.NativeFieldInfoPtr_zoobsTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "zoobsTileArr");
			TileBags.NativeFieldInfoPtr_zoooutdoorTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "zoooutdoorTileArr");
			TileBags.NativeFieldInfoPtr_zoooutdoorhabTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "zoooutdoorhabTileArr");
			TileBags.NativeFieldInfoPtr_boatTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "boatTileArr");
			TileBags.NativeFieldInfoPtr_boatcrewTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "boatcrewTileArr");
			TileBags.NativeFieldInfoPtr_bunkerindoorhangerTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "bunkerindoorhangerTileArr");
			TileBags.NativeFieldInfoPtr_boatdeckTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "boatdeckTileArr");
			TileBags.NativeFieldInfoPtr_boatharborTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "boatharborTileArr");
			TileBags.NativeFieldInfoPtr_outdoorTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "outdoorTileArr");
			TileBags.NativeFieldInfoPtr_outdoorbuildingTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "outdoorbuildingTileArr");
			TileBags.NativeFieldInfoPtr_officeTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "officeTileArr");
			TileBags.NativeFieldInfoPtr_officeconstructionTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "officeconstructionTileArr");
			TileBags.NativeFieldInfoPtr_officelobbyTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "officelobbyTileArr");
			TileBags.NativeFieldInfoPtr_specialStarts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBags>.NativeClassPtr, "specialStarts");
			TileBags.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBags>.NativeClassPtr, 100667188);
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x000BDB28 File Offset: 0x000BBD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileBags()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileBags>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileBags.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x0002236C File Offset: 0x0002056C
		public TileBags(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x060031EE RID: 12782 RVA: 0x000BDB64 File Offset: 0x000BBD64
		// (set) Token: 0x060031EF RID: 12783 RVA: 0x00022375 File Offset: 0x00020575
		public unsafe int worldInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_worldInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_worldInd)) = value;
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x000BDB8C File Offset: 0x000BBD8C
		// (set) Token: 0x060031F1 RID: 12785 RVA: 0x00022390 File Offset: 0x00020590
		public unsafe Il2CppReferenceArray<MapTile> labopenTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_labopenTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_labopenTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x000BDBBC File Offset: 0x000BBDBC
		// (set) Token: 0x060031F3 RID: 12787 RVA: 0x000223AF File Offset: 0x000205AF
		public unsafe Il2CppReferenceArray<MapTile> labtightTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_labtightTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_labtightTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x000BDBEC File Offset: 0x000BBDEC
		// (set) Token: 0x060031F5 RID: 12789 RVA: 0x000223CE File Offset: 0x000205CE
		public unsafe Il2CppReferenceArray<MapTile> stealthTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_stealthTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_stealthTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x060031F6 RID: 12790 RVA: 0x000BDC1C File Offset: 0x000BBE1C
		// (set) Token: 0x060031F7 RID: 12791 RVA: 0x000223ED File Offset: 0x000205ED
		public unsafe Il2CppReferenceArray<MapTile> hallTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_hallTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_hallTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x060031F8 RID: 12792 RVA: 0x000BDC4C File Offset: 0x000BBE4C
		// (set) Token: 0x060031F9 RID: 12793 RVA: 0x0002240C File Offset: 0x0002060C
		public unsafe Il2CppReferenceArray<MapTile> setPieceArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_setPieceArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_setPieceArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x060031FA RID: 12794 RVA: 0x000BDC7C File Offset: 0x000BBE7C
		// (set) Token: 0x060031FB RID: 12795 RVA: 0x0002242B File Offset: 0x0002062B
		public unsafe Il2CppReferenceArray<MapTile> staticTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_staticTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_staticTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x000BDCAC File Offset: 0x000BBEAC
		// (set) Token: 0x060031FD RID: 12797 RVA: 0x0002244A File Offset: 0x0002064A
		public unsafe Il2CppReferenceArray<MapTile> specialLvlTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_specialLvlTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_specialLvlTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x000BDCDC File Offset: 0x000BBEDC
		// (set) Token: 0x060031FF RID: 12799 RVA: 0x00022469 File Offset: 0x00020669
		public unsafe Il2CppReferenceArray<MapTile> bunkerhallTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_bunkerhallTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_bunkerhallTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x000BDD0C File Offset: 0x000BBF0C
		// (set) Token: 0x06003201 RID: 12801 RVA: 0x00022488 File Offset: 0x00020688
		public unsafe Il2CppReferenceArray<MapTile> bunkerroomTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_bunkerroomTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_bunkerroomTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06003202 RID: 12802 RVA: 0x000BDD3C File Offset: 0x000BBF3C
		// (set) Token: 0x06003203 RID: 12803 RVA: 0x000224A7 File Offset: 0x000206A7
		public unsafe Il2CppReferenceArray<MapTile> bunkerroomblownTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_bunkerroomblownTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_bunkerroomblownTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06003204 RID: 12804 RVA: 0x000BDD6C File Offset: 0x000BBF6C
		// (set) Token: 0x06003205 RID: 12805 RVA: 0x000224C6 File Offset: 0x000206C6
		public unsafe Il2CppReferenceArray<MapTile> bunkerhallblownTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_bunkerhallblownTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_bunkerhallblownTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06003206 RID: 12806 RVA: 0x000BDD9C File Offset: 0x000BBF9C
		// (set) Token: 0x06003207 RID: 12807 RVA: 0x000224E5 File Offset: 0x000206E5
		public unsafe Il2CppReferenceArray<MapTile> hangerTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_hangerTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_hangerTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06003208 RID: 12808 RVA: 0x000BDDCC File Offset: 0x000BBFCC
		// (set) Token: 0x06003209 RID: 12809 RVA: 0x00022504 File Offset: 0x00020704
		public unsafe Il2CppReferenceArray<MapTile> zooTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_zooTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_zooTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x000BDDFC File Offset: 0x000BBFFC
		// (set) Token: 0x0600320B RID: 12811 RVA: 0x00022523 File Offset: 0x00020723
		public unsafe Il2CppReferenceArray<MapTile> zoobsTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_zoobsTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_zoobsTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x000BDE2C File Offset: 0x000BC02C
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x00022542 File Offset: 0x00020742
		public unsafe Il2CppReferenceArray<MapTile> zoooutdoorTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_zoooutdoorTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_zoooutdoorTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x000BDE5C File Offset: 0x000BC05C
		// (set) Token: 0x0600320F RID: 12815 RVA: 0x00022561 File Offset: 0x00020761
		public unsafe Il2CppReferenceArray<MapTile> zoooutdoorhabTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_zoooutdoorhabTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_zoooutdoorhabTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x000BDE8C File Offset: 0x000BC08C
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x00022580 File Offset: 0x00020780
		public unsafe Il2CppReferenceArray<MapTile> boatTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_boatTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_boatTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06003212 RID: 12818 RVA: 0x000BDEBC File Offset: 0x000BC0BC
		// (set) Token: 0x06003213 RID: 12819 RVA: 0x0002259F File Offset: 0x0002079F
		public unsafe Il2CppReferenceArray<MapTile> boatcrewTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_boatcrewTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_boatcrewTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x000BDEEC File Offset: 0x000BC0EC
		// (set) Token: 0x06003215 RID: 12821 RVA: 0x000225BE File Offset: 0x000207BE
		public unsafe Il2CppReferenceArray<MapTile> bunkerindoorhangerTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_bunkerindoorhangerTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_bunkerindoorhangerTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06003216 RID: 12822 RVA: 0x000BDF1C File Offset: 0x000BC11C
		// (set) Token: 0x06003217 RID: 12823 RVA: 0x000225DD File Offset: 0x000207DD
		public unsafe Il2CppReferenceArray<MapTile> boatdeckTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_boatdeckTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_boatdeckTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06003218 RID: 12824 RVA: 0x000BDF4C File Offset: 0x000BC14C
		// (set) Token: 0x06003219 RID: 12825 RVA: 0x000225FC File Offset: 0x000207FC
		public unsafe Il2CppReferenceArray<MapTile> boatharborTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_boatharborTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_boatharborTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x000BDF7C File Offset: 0x000BC17C
		// (set) Token: 0x0600321B RID: 12827 RVA: 0x0002261B File Offset: 0x0002081B
		public unsafe Il2CppReferenceArray<MapTile> outdoorTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_outdoorTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_outdoorTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x0600321C RID: 12828 RVA: 0x000BDFAC File Offset: 0x000BC1AC
		// (set) Token: 0x0600321D RID: 12829 RVA: 0x0002263A File Offset: 0x0002083A
		public unsafe Il2CppReferenceArray<MapTile> outdoorbuildingTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_outdoorbuildingTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_outdoorbuildingTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x0600321E RID: 12830 RVA: 0x000BDFDC File Offset: 0x000BC1DC
		// (set) Token: 0x0600321F RID: 12831 RVA: 0x00022659 File Offset: 0x00020859
		public unsafe Il2CppReferenceArray<MapTile> officeTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_officeTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_officeTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06003220 RID: 12832 RVA: 0x000BE00C File Offset: 0x000BC20C
		// (set) Token: 0x06003221 RID: 12833 RVA: 0x00022678 File Offset: 0x00020878
		public unsafe Il2CppReferenceArray<MapTile> officeconstructionTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_officeconstructionTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_officeconstructionTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06003222 RID: 12834 RVA: 0x000BE03C File Offset: 0x000BC23C
		// (set) Token: 0x06003223 RID: 12835 RVA: 0x00022697 File Offset: 0x00020897
		public unsafe Il2CppReferenceArray<MapTile> officelobbyTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_officelobbyTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_officelobbyTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06003224 RID: 12836 RVA: 0x000BE06C File Offset: 0x000BC26C
		// (set) Token: 0x06003225 RID: 12837 RVA: 0x000226B6 File Offset: 0x000208B6
		public unsafe Il2CppStructArray<int> specialStarts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_specialStarts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileBags.NativeFieldInfoPtr_specialStarts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeFieldInfoPtr_worldInd;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeFieldInfoPtr_labopenTileArr;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeFieldInfoPtr_labtightTileArr;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeFieldInfoPtr_stealthTileArr;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeFieldInfoPtr_hallTileArr;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeFieldInfoPtr_setPieceArr;

		// Token: 0x04001D47 RID: 7495
		private static readonly IntPtr NativeFieldInfoPtr_staticTileArr;

		// Token: 0x04001D48 RID: 7496
		private static readonly IntPtr NativeFieldInfoPtr_specialLvlTileArr;

		// Token: 0x04001D49 RID: 7497
		private static readonly IntPtr NativeFieldInfoPtr_bunkerhallTileArr;

		// Token: 0x04001D4A RID: 7498
		private static readonly IntPtr NativeFieldInfoPtr_bunkerroomTileArr;

		// Token: 0x04001D4B RID: 7499
		private static readonly IntPtr NativeFieldInfoPtr_bunkerroomblownTileArr;

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeFieldInfoPtr_bunkerhallblownTileArr;

		// Token: 0x04001D4D RID: 7501
		private static readonly IntPtr NativeFieldInfoPtr_hangerTileArr;

		// Token: 0x04001D4E RID: 7502
		private static readonly IntPtr NativeFieldInfoPtr_zooTileArr;

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeFieldInfoPtr_zoobsTileArr;

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeFieldInfoPtr_zoooutdoorTileArr;

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeFieldInfoPtr_zoooutdoorhabTileArr;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeFieldInfoPtr_boatTileArr;

		// Token: 0x04001D53 RID: 7507
		private static readonly IntPtr NativeFieldInfoPtr_boatcrewTileArr;

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeFieldInfoPtr_bunkerindoorhangerTileArr;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeFieldInfoPtr_boatdeckTileArr;

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeFieldInfoPtr_boatharborTileArr;

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeFieldInfoPtr_outdoorTileArr;

		// Token: 0x04001D58 RID: 7512
		private static readonly IntPtr NativeFieldInfoPtr_outdoorbuildingTileArr;

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeFieldInfoPtr_officeTileArr;

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeFieldInfoPtr_officeconstructionTileArr;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeFieldInfoPtr_officelobbyTileArr;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeFieldInfoPtr_specialStarts;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
