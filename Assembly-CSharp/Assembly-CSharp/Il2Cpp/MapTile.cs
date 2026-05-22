using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200012B RID: 299
	public class MapTile : MonoBehaviour
	{
		// Token: 0x06002522 RID: 9506 RVA: 0x0009B84C File Offset: 0x00099A4C
		// Note: this type is marked as 'beforefieldinit'.
		static MapTile()
		{
			Il2CppClassPointerStore<MapTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MapTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapTile>.NativeClassPtr);
			MapTile.NativeFieldInfoPtr_spawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "spawnPoints");
			MapTile.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "path");
			MapTile.NativeFieldInfoPtr_tilePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "tilePos");
			MapTile.NativeFieldInfoPtr_mTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "mTiles");
			MapTile.NativeFieldInfoPtr_palMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "palMat");
			MapTile.NativeFieldInfoPtr_wereUpdatingDoorsNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "wereUpdatingDoorsNow");
			MapTile.NativeFieldInfoPtr_dontPathFindHere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "dontPathFindHere");
			MapTile.NativeFieldInfoPtr_animals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "animals");
			MapTile.NativeFieldInfoPtr_ambNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "ambNum");
			MapTile.NativeFieldInfoPtr_tileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "tileID");
			MapTile.NativeFieldInfoPtr_inUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "inUse");
			MapTile.NativeFieldInfoPtr_dontReuse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "dontReuse");
			MapTile.NativeFieldInfoPtr_butDoCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "butDoCull");
			MapTile.NativeFieldInfoPtr_floorRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "floorRend");
			MapTile.NativeFieldInfoPtr_startRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "startRan");
			MapTile.NativeFieldInfoPtr_glassList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "glassList");
			MapTile.NativeFieldInfoPtr_swingyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "swingyList");
			MapTile.NativeFieldInfoPtr_containerDoorList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "containerDoorList");
			MapTile.NativeFieldInfoPtr_refresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "refresh");
			MapTile.NativeFieldInfoPtr_onlyXCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "onlyXCheck");
			MapTile.NativeFieldInfoPtr_cageDoorList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "cageDoorList");
			MapTile.NativeFieldInfoPtr_spawnProbList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTile>.NativeClassPtr, "spawnProbList");
			MapTile.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTile>.NativeClassPtr, 100666254);
			MapTile.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTile>.NativeClassPtr, 100666255);
			MapTile.NativeMethodInfoPtr_DestroyAnimals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTile>.NativeClassPtr, 100666256);
			MapTile.NativeMethodInfoPtr_MyStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTile>.NativeClassPtr, 100666257);
			MapTile.NativeMethodInfoPtr_UpdateDoorways_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTile>.NativeClassPtr, 100666258);
			MapTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTile>.NativeClassPtr, 100666259);
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x0009BAAC File Offset: 0x00099CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73097, XrefRangeEnd = 73154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTile.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x0009BAE0 File Offset: 0x00099CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73154, XrefRangeEnd = 73174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTile.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x0009BB14 File Offset: 0x00099D14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73194, RefRangeEnd = 73195, XrefRangeStart = 73174, XrefRangeEnd = 73194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyAnimals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTile.NativeMethodInfoPtr_DestroyAnimals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x0009BB48 File Offset: 0x00099D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73226, RefRangeEnd = 73227, XrefRangeStart = 73195, XrefRangeEnd = 73226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTile.NativeMethodInfoPtr_MyStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x0009BB7C File Offset: 0x00099D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73227, XrefRangeEnd = 73229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDoorways()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTile.NativeMethodInfoPtr_UpdateDoorways_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0009BBB0 File Offset: 0x00099DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73229, XrefRangeEnd = 73262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapTile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x0001A02B File Offset: 0x0001822B
		public MapTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x0009BBEC File Offset: 0x00099DEC
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x0001A034 File Offset: 0x00018234
		public unsafe Il2CppReferenceArray<Transform> spawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_spawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_spawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x0009BC1C File Offset: 0x00099E1C
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x0001A053 File Offset: 0x00018253
		public unsafe string path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x0009BC44 File Offset: 0x00099E44
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x0001A072 File Offset: 0x00018272
		public unsafe Il2CppStructArray<Vector2> tilePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_tilePos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_tilePos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x0009BC74 File Offset: 0x00099E74
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x0001A091 File Offset: 0x00018291
		public unsafe Il2CppReferenceArray<MTile> mTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_mTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_mTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x0009BCA4 File Offset: 0x00099EA4
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x0001A0B0 File Offset: 0x000182B0
		public unsafe Material palMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_palMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_palMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x0009BCD4 File Offset: 0x00099ED4
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x0001A0CF File Offset: 0x000182CF
		public unsafe bool wereUpdatingDoorsNow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_wereUpdatingDoorsNow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_wereUpdatingDoorsNow)) = value;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x0009BCFC File Offset: 0x00099EFC
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x0001A0EA File Offset: 0x000182EA
		public unsafe bool dontPathFindHere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_dontPathFindHere);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_dontPathFindHere)) = value;
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x0009BD24 File Offset: 0x00099F24
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x0001A105 File Offset: 0x00018305
		public unsafe List<GameObject> animals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_animals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_animals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x0009BD54 File Offset: 0x00099F54
		// (set) Token: 0x0600253B RID: 9531 RVA: 0x0001A124 File Offset: 0x00018324
		public unsafe int ambNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_ambNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_ambNum)) = value;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x0009BD7C File Offset: 0x00099F7C
		// (set) Token: 0x0600253D RID: 9533 RVA: 0x0001A13F File Offset: 0x0001833F
		public unsafe int tileID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_tileID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_tileID)) = value;
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x0009BDA4 File Offset: 0x00099FA4
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x0001A15A File Offset: 0x0001835A
		public unsafe bool inUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_inUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_inUse)) = value;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x0009BDCC File Offset: 0x00099FCC
		// (set) Token: 0x06002541 RID: 9537 RVA: 0x0001A175 File Offset: 0x00018375
		public unsafe bool dontReuse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_dontReuse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_dontReuse)) = value;
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x0009BDF4 File Offset: 0x00099FF4
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x0001A190 File Offset: 0x00018390
		public unsafe bool butDoCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_butDoCull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_butDoCull)) = value;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x0009BE1C File Offset: 0x0009A01C
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x0001A1AB File Offset: 0x000183AB
		public unsafe Il2CppReferenceArray<Renderer> floorRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_floorRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_floorRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x0009BE4C File Offset: 0x0009A04C
		// (set) Token: 0x06002547 RID: 9543 RVA: 0x0001A1CA File Offset: 0x000183CA
		public unsafe bool startRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_startRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_startRan)) = value;
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x0009BE74 File Offset: 0x0009A074
		// (set) Token: 0x06002549 RID: 9545 RVA: 0x0001A1E5 File Offset: 0x000183E5
		public unsafe List<GameObject> glassList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_glassList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_glassList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x0009BEA4 File Offset: 0x0009A0A4
		// (set) Token: 0x0600254B RID: 9547 RVA: 0x0001A204 File Offset: 0x00018404
		public unsafe List<SwingyDoor> swingyList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_swingyList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SwingyDoor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_swingyList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x0009BED4 File Offset: 0x0009A0D4
		// (set) Token: 0x0600254D RID: 9549 RVA: 0x0001A223 File Offset: 0x00018423
		public unsafe List<ContainerDoor> containerDoorList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_containerDoorList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ContainerDoor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_containerDoorList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x0009BF04 File Offset: 0x0009A104
		// (set) Token: 0x0600254F RID: 9551 RVA: 0x0001A242 File Offset: 0x00018442
		public unsafe bool refresh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_refresh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_refresh)) = value;
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002550 RID: 9552 RVA: 0x0009BF2C File Offset: 0x0009A12C
		// (set) Token: 0x06002551 RID: 9553 RVA: 0x0001A25D File Offset: 0x0001845D
		public unsafe bool onlyXCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_onlyXCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_onlyXCheck)) = value;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x0009BF54 File Offset: 0x0009A154
		// (set) Token: 0x06002553 RID: 9555 RVA: 0x0001A278 File Offset: 0x00018478
		public unsafe List<CageDoor> cageDoorList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_cageDoorList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CageDoor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_cageDoorList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x0009BF84 File Offset: 0x0009A184
		// (set) Token: 0x06002555 RID: 9557 RVA: 0x0001A297 File Offset: 0x00018497
		public unsafe List<SpawnProbability> spawnProbList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_spawnProbList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpawnProbability>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTile.NativeFieldInfoPtr_spawnProbList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeFieldInfoPtr_spawnPoints;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeFieldInfoPtr_tilePos;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeFieldInfoPtr_mTiles;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeFieldInfoPtr_palMat;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeFieldInfoPtr_wereUpdatingDoorsNow;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeFieldInfoPtr_dontPathFindHere;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeFieldInfoPtr_animals;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeFieldInfoPtr_ambNum;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeFieldInfoPtr_tileID;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeFieldInfoPtr_inUse;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeFieldInfoPtr_dontReuse;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeFieldInfoPtr_butDoCull;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeFieldInfoPtr_floorRend;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeFieldInfoPtr_startRan;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeFieldInfoPtr_glassList;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeFieldInfoPtr_swingyList;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeFieldInfoPtr_containerDoorList;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeFieldInfoPtr_refresh;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeFieldInfoPtr_onlyXCheck;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeFieldInfoPtr_cageDoorList;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeFieldInfoPtr_spawnProbList;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeMethodInfoPtr_DestroyAnimals_Public_Void_0;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeMethodInfoPtr_MyStart_Public_Void_0;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDoorways_Public_Void_0;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
